using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Research.Kinect.Nui;
using Microsoft.Research.Kinect.Audio;
using Coding4Fun.Kinect.WinForm;
using WindowsInput;

namespace morrisonm48.EasyKin
{
    public partial class frmActivate : Form
    {
        Runtime nui = new Runtime();

        public frmActivate()
        {
            InitializeComponent();
        }

        private void frmActivate_Load(object sender, EventArgs e)
        {
            //initialize skeletal tracking
            nui.Initialize(RuntimeOptions.UseSkeletalTracking | RuntimeOptions.UseDepth);
            //smooth skeletal jitter
            nui.SkeletonEngine.TransformSmooth = true;
            var parameters = new TransformSmoothParameters
            {
                Smoothing = 0.75f,
                Correction = 0.0f,
                Prediction = 0.0f,
                JitterRadius = 0.05f,
                MaxDeviationRadius = 0.04f
            };
            nui.SkeletonEngine.SmoothParameters = parameters;
            //get ready to receive skeletal data
            nui.SkeletonFrameReady += new EventHandler<SkeletonFrameReadyEventArgs>(nui_SkeletonFrameReady;
        }



    }
}
