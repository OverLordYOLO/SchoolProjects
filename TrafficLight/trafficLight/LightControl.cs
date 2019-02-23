using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace trafficLight
{
    class LightControl
    {
        Bitmap RedOn;
        Bitmap RedOff;
        Bitmap OrangeOn;
        Bitmap OrangeOff;
        Bitmap GreenOn;
        Bitmap GreenOff;

        private LightControllerForm controllerForm;
        private LightDisplayForm displayForm;
        private LightLogic lLogic;
        Thread lLogicThread;
        private LightState desiredState = LightState.RED;
        private bool powerSavingMode = false;
        private bool abortThread = false;

        LightState[] testSeq = { LightState.GREEN, LightState.GREEN_ORANGE, LightState.ORANGE_RED, LightState.RED };
        public LightControl(LightControllerForm controllerForm)
        {
            RedOn = GetImageByName("trafficLight.Res.red_on_Light.bmp");
            RedOff = GetImageByName("trafficLight.Res.red_off_Light.bmp");
            OrangeOn = GetImageByName("trafficLight.Res.orange_on_Light.bmp");
            OrangeOff = GetImageByName("trafficLight.Res.orange_off_Light.bmp");
            GreenOn = GetImageByName("trafficLight.Res.green_on_Light.bmp");
            GreenOff = GetImageByName("trafficLight.Res.green_off_Light.bmp");

            this.lLogic = new LightLogic();
            this.controllerForm = controllerForm;
            this.SetupAndShowDisplayForm();

            this.RegisterHandlers();
        }

        private void ControlLightLogic()
        {

            while (abortThread == false)
            {
                LightState nextState = this.lLogic.GetCurrentState();
                if (this.powerSavingMode)
                {
                    nextState = lLogic.PowerSaver();
                } else if (this.desiredState == LightState.INFINITE)
                {
                    nextState = lLogic.GetNextAutomaticState();
                } else
                {
                    if (this.lLogic.GetCurrentState() == this.desiredState) return;
                    nextState = this.lLogic.GotoState(this.desiredState);
                }
                this.SetLights(nextState);
                this.wait();

            }
        }
        private void wait(int sleepInMillis = 1000, int sleepCycleInMillis = 20)
        {
            int cycles = sleepInMillis / sleepCycleInMillis;
            int curCycle = 0;
            while (!abortThread && curCycle < cycles)
            {
                curCycle++;
                Thread.Sleep(sleepCycleInMillis);
            }
        }
        private void SetLights(LightState state)
        {
            switch (state)
            {
                case LightState.GREEN:
                    this.displayForm.SetStopImage(this.RedOff);
                    this.displayForm.SetAttentionImage(this.OrangeOff);
                    this.displayForm.SetGoImage(this.GreenOn);
                    break;
                case LightState.GREEN_ORANGE:
                    this.displayForm.SetStopImage(this.RedOff);
                    this.displayForm.SetAttentionImage(this.OrangeOn);
                    this.displayForm.SetGoImage(this.GreenOn);
                    break;
                case LightState.ORANGE:
                    this.displayForm.SetStopImage(this.RedOff);
                    this.displayForm.SetAttentionImage(this.OrangeOn);
                    this.displayForm.SetGoImage(this.GreenOff);
                    break;
                case LightState.ORANGE_RED:
                    this.displayForm.SetStopImage(this.RedOn);
                    this.displayForm.SetAttentionImage(this.OrangeOn);
                    this.displayForm.SetGoImage(this.GreenOff);
                    break;
                case LightState.RED:
                    this.displayForm.SetStopImage(this.RedOn);
                    this.displayForm.SetAttentionImage(this.OrangeOff);
                    this.displayForm.SetGoImage(this.GreenOff);
                    break;
                case LightState.OFF:
                    this.displayForm.SetStopImage(this.RedOff);
                    this.displayForm.SetAttentionImage(this.OrangeOff);
                    this.displayForm.SetGoImage(this.GreenOff);
                    break;
            }
        }

        private void SetupAndShowDisplayForm()
        {
            this.displayForm = new LightDisplayForm();

            this.SetLights(this.lLogic.SetState(LightState.RED));
            this.displayForm.Show();
        }

        private Bitmap GetImageByName(string imgName)
        {
            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream(imgName);
            return new Bitmap(myStream);
        }
        private void RegisterHandlers()
        {
            this.displayForm.RegisterOnFormDispose(this.DisposeFormHandler);
            this.controllerForm.registerStopButtonClick(this.StopModeClickedHandler);
            this.controllerForm.registerAttentionButtonClick(this.AttentionStateClickedHandler);
            this.controllerForm.registerGoButtonClick(this.GoStateClickedHandler);
            this.controllerForm.registerAutoButtonClick(this.AutoModeClickedHandler);
            this.controllerForm.registerPowerSaverButtonClick(this.PowerSaverClickedHandler);
            this.controllerForm.registerNextStepButtonClick(this.NextStepClickedHandler);
            this.controllerForm.registershutdownButtonClick(this.ShutdownClickedHandler);
        }

        private void ShutdownClickedHandler(object sender, EventArgs e)
        {
            this.stopThread();
            this.displayForm.SetStopImage(this.RedOff);
            this.displayForm.SetAttentionImage(this.OrangeOff);
            this.displayForm.SetGoImage(this.GreenOff);
        }

        private void DisposeFormHandler(object sender, EventArgs e)
        {
            this.abortThread = true;
        }
        private void NextStepClickedHandler(object sender, EventArgs e)
        {
            this.stopThread();
            this.SetLights(this.lLogic.GetNextAutomaticState());
        }
        private void StopModeClickedHandler(object sender, EventArgs e)
        {
            this.GotoState(LightState.RED);
        }
        private void AttentionStateClickedHandler(object sender, EventArgs e)
        {
            this.GotoState(LightState.ORANGE);
        }
        private void GoStateClickedHandler(object sender, EventArgs e)
        {
            this.GotoState(LightState.GREEN);
        }
        private void AutoModeClickedHandler(object sender, EventArgs e)
        {
            this.GotoState(LightState.INFINITE);
        }
        private void PowerSaverClickedHandler(object sender, EventArgs e)
        {
            this.GotoState(LightState.INFINITE, true);
        }
        private void GotoState(LightState desiredState, bool powerSavingMode = false)
        {
            this.stopThread();
            this.desiredState = desiredState;
            this.powerSavingMode = powerSavingMode;
            ThreadStart thStart = new ThreadStart(this.ControlLightLogic);
            this.lLogicThread = new Thread(thStart);
            this.lLogicThread.Start();
        }
        private void stopThread()
        {
            if (this.lLogicThread != null && this.lLogicThread.IsAlive)
            {
                this.abortThread = true;
                int timeoutInMillis = 500;
                int sleepInMillis = 5;
                int iteration = 0;
                while (this.lLogicThread.IsAlive)
                {
                    if (iteration >= timeoutInMillis / sleepInMillis)
                    {
                        this.lLogicThread.Abort();
                    }
                }
            }
            this.abortThread = false;
        }
    }
}
