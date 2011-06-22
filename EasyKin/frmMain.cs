using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EasyKin
{
    public partial class frmMain : Form
    {
        string strPregeneratedCode = @"

// In order to run this code, create a new wpf application in Visual Studio C#
// Then add a new reference to Microsoft.Research.Kinect from the .NET filter
// You also need to make sure to add InputSimulator and Coding4Fun.Kinect.Wpf through the browse menu
// (you might need to download those)
// After that, select everything in this text box, copy and paste it into MainWindow.xaml.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text;
using Microsoft.Research.Kinect.Nui;
using Microsoft.Research.Kinect.Audio;
using Coding4Fun.Kinect.Wpf;
using WindowsInput;
//**********************Change WpfApplication1 to the name of your solution************
namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //refernce the Kinect runtime
        Runtime nui = new Runtime();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //initialize skeletal tracking
            nui.Initialize(RuntimeOptions.UseSkeletalTracking);
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
            nui.SkeletonFrameReady += new EventHandler<SkeletonFrameReadyEventArgs>(nui_SkeletonFrameReady);
        }

        //once there is a skeletal lock, do stuff
        void nui_SkeletonFrameReady(object sender, SkeletonFrameReadyEventArgs e)
        {
            SkeletonFrame allSkeletons = e.SkeletonFrame;

            //track the first skeleton for input
            SkeletonData skeleton = (from s in allSkeletons.Skeletons
                                     where s.TrackingState == SkeletonTrackingState.Tracked
                                     select s).FirstOrDefault();
            
            //Prep all joints for input (Since we don't know what user will add and want the code to look organised)
            //Not concerend with speed at the moment
            Joint jntHead = skeleton.Joints[JointID.Head].ScaleTo(640, 480);
            Joint jntShoulderLT = skeleton.Joints[JointID.ShoulderLeft].ScaleTo(640, 480);
            Joint jntShoulderCTR = skeleton.Joints[JointID.ShoulderCenter].ScaleTo(640, 480);
            Joint jntShoulderRT = skeleton.Joints[JointID.ShoulderRight].ScaleTo(640, 480);
            Joint jntElbowLT = skeleton.Joints[JointID.ElbowLeft].ScaleTo(640, 480);
            Joint jntElbowRT = skeleton.Joints[JointID.ElbowRight].ScaleTo(640, 480);
            Joint jntWristLT = skeleton.Joints[JointID.WristRight].ScaleTo(640, 480);
            Joint jntWristRT = skeleton.Joints[JointID.WristLeft].ScaleTo(640, 480);
            Joint jntHandLT = skeleton.Joints[JointID.HandLeft].ScaleTo(640, 480);
            Joint jntHandRT = skeleton.Joints[JointID.HandRight].ScaleTo(640, 480);
            Joint jntSpine = skeleton.Joints[JointID.Spine].ScaleTo(640, 480);
            Joint jntHipLT = skeleton.Joints[JointID.HipLeft].ScaleTo(640, 480);
            Joint jntHipCTR = skeleton.Joints[JointID.HipCenter].ScaleTo(640, 480);
            Joint jntHipRT = skeleton.Joints[JointID.HipRight].ScaleTo(640, 480);
            Joint jntKneeLT = skeleton.Joints[JointID.KneeLeft].ScaleTo(640, 480);
            Joint jntKneeRT = skeleton.Joints[JointID.KneeRight].ScaleTo(640, 480);
            Joint jntAnkleLT = skeleton.Joints[JointID.AnkleLeft].ScaleTo(640, 480);
            Joint jntAnkleRT = skeleton.Joints[JointID.AnkleRight].ScaleTo(640, 480);
            Joint jntFootLT = skeleton.Joints[JointID.FootLeft].ScaleTo(640, 480);
            Joint jntFootRT = skeleton.Joints[JointID.FootRight].ScaleTo(640, 480);
";
        public frmMain()
        {
            InitializeComponent(); 
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string[] straBodyParts = new string[10] { "Head", "Shoulder", "Elbow", "Wrist", "Hand", "Spine", "Hip", "Knee", "Ankle", "Foot"};
            string[] straPeripherals = new string[3] { "Keyboard", "Mouse", "Keyboard(Special)" };
            string[] straActions = new string[2] { "Press", "Hold"};
            string[] straXY = new string[2] { "X", "Y" };

            cbxBodyPart.MaxDropDownItems = straBodyParts.GetLength(0);
            cbxBodyPart.Items.AddRange(straBodyParts);
            cbxPeriph.MaxDropDownItems = straPeripherals.GetLength(0);
            cbxPeriph.Items.AddRange(straPeripherals);
            cbxButtonAction.MaxDropDownItems = straActions.GetLength(0);
            cbxButtonAction.Items.AddRange(straActions);
            cbxXY.MaxDropDownItems = straXY.GetLength(0);
            cbxXY.Items.AddRange(straXY);

            cbxPartModifier.Enabled = false;
            cbxXY.Enabled = false;
            tbxCoordinate.Enabled = false;
            cbxPeriphButton.Enabled = false;


            rtbGeneratedCode.Text = strPregeneratedCode;
        }

        private void cbxBodyPart_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string[] straLeftRight = new string[2] { "Left", "Right" };
            string[] straLeftRightCenter = new string[3] { "Left", "Right", "Center" };

            switch (cbxBodyPart.SelectedItem.ToString())
            {
                case "Head":
                    cbxPartModifier.Items.Clear();
                    cbxPartModifier.Text = "";
                    cbxPartModifier.Enabled = false;
                    cbxXY.Enabled = true;
                    break;
                case "Shoulder":
                    cbxPartModifier.Items.Clear();
                    cbxPartModifier.MaxDropDownItems = straLeftRightCenter.GetLength(0);
                    cbxPartModifier.Items.AddRange(straLeftRightCenter);
                    cbxPartModifier.Enabled = true;
                    cbxXY.Enabled = true;
                    break;
                case "Elbow":
                    cbxPartModifier.Items.Clear();
                    cbxPartModifier.MaxDropDownItems = straLeftRight.GetLength(0);
                    cbxPartModifier.Items.AddRange(straLeftRight);
                    cbxPartModifier.Enabled = true;
                    cbxXY.Enabled = true;
                    break;
                case "Wrist":
                    cbxPartModifier.Items.Clear();
                    cbxPartModifier.MaxDropDownItems = straLeftRight.GetLength(0);
                    cbxPartModifier.Items.AddRange(straLeftRight);
                    cbxPartModifier.Enabled = true;
                    cbxXY.Enabled = true;
                    break;
                case "Hand":
                    cbxPartModifier.Items.Clear();
                    cbxPartModifier.MaxDropDownItems = straLeftRight.GetLength(0);
                    cbxPartModifier.Items.AddRange(straLeftRight);
                    cbxPartModifier.Enabled = true;
                    cbxXY.Enabled = true;
                    break; 
                case "Spine":
                    cbxPartModifier.Items.Clear();
                    cbxPartModifier.Text = "";
                    cbxPartModifier.Enabled = false;
                    cbxXY.Enabled = true;
                    break;
                case "Hip":
                    cbxPartModifier.Items.Clear();
                    cbxPartModifier.MaxDropDownItems = straLeftRightCenter.GetLength(0);
                    cbxPartModifier.Items.AddRange(straLeftRightCenter);
                    cbxPartModifier.Enabled = true;
                    cbxXY.Enabled = true;
                    break;
                case "Knee":
                    cbxPartModifier.Items.Clear();
                    cbxPartModifier.MaxDropDownItems = straLeftRight.GetLength(0);
                    cbxPartModifier.Items.AddRange(straLeftRight);
                    cbxPartModifier.Enabled = true;
                    cbxXY.Enabled = true;
                    break;
                case "Ankle":
                    cbxPartModifier.Items.Clear();
                    cbxPartModifier.MaxDropDownItems = straLeftRight.GetLength(0);
                    cbxPartModifier.Items.AddRange(straLeftRight);
                    cbxPartModifier.Enabled = true;
                    cbxXY.Enabled = true;
                    break;
                case "Foot":
                    cbxPartModifier.Items.Clear();
                    cbxPartModifier.MaxDropDownItems = straLeftRight.GetLength(0);
                    cbxPartModifier.Items.AddRange(straLeftRight);
                    cbxPartModifier.Enabled = true;
                    cbxXY.Enabled = true;
                    break;
            }
        }

        private void cbxXY_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxXY.SelectedItem.ToString() == "X")
            {
                tbxCoordinate.Enabled = true;
            }
            if (cbxXY.SelectedItem.ToString() == "Y")
            {
                tbxCoordinate.Enabled = true;
            }
        }

        private void cbxPeriph_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] straKeyboardKeys = new string[] {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0"};
            string[] straKeyboardSpecial = new string[] {"Space", "LShift", "RShift", "Return", "Backspace", "LControl", "RControl", "Tab", "Capital"};
            string[] straMouseButtons = new string[5] {"LButton", "RButton", "MButton", "XButton1", "XButton2"};
            switch (cbxPeriph.SelectedItem.ToString())
            {
                case "Keyboard":
                    cbxPeriphButton.Items.Clear();
                    cbxPeriphButton.MaxDropDownItems = straKeyboardKeys.GetLength(0);
                    cbxPeriphButton.Items.AddRange(straKeyboardKeys);
                    cbxPeriphButton.Enabled = true;
                    break;
                case "Mouse":
                    cbxPeriphButton.Items.Clear();
                    cbxPeriphButton.MaxDropDownItems = straMouseButtons.GetLength(0);
                    cbxPeriphButton.Items.AddRange(straMouseButtons);
                    cbxPeriphButton.Enabled = true;
                    break;
                case "Keyboard(Special)":
                    cbxPeriphButton.Items.Clear();
                    cbxPeriphButton.MaxDropDownItems = straKeyboardSpecial.GetLength(0);
                    cbxPeriphButton.Items.AddRange(straKeyboardSpecial);
                    cbxPeriphButton.Enabled = true;
                    break;                
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbxBodyPart.Items.Clear();
            cbxBodyPart.Text = "";
            cbxButtonAction.Items.Clear();
            cbxButtonAction.Text = "";
            cbxXY.Items.Clear();
            cbxXY.Text = "";
            cbxPartModifier.Items.Clear();
            cbxPartModifier.Text = "";
            cbxPeriph.Items.Clear();
            cbxPeriph.Text = "";
            cbxPeriphButton.Items.Clear();
            cbxPeriphButton.Text = "";
            tbxCoordinate.Clear();
            tbxCoordinate.Text = "";

            string[] straBodyParts = new string[10] { "Head", "Shoulder", "Elbow", "Wrist", "Hand", "Spine", "Hip", "Knee", "Ankle", "Foot" };
            string[] straPeripherals = new string[3] { "Keyboard", "Mouse", "Keyboard(Special)" };
            string[] straActions = new string[2] { "Press", "Hold" };
            string[] straXY = new string[2] { "X", "Y" };

            cbxBodyPart.MaxDropDownItems = straBodyParts.GetLength(0);
            cbxBodyPart.Items.AddRange(straBodyParts);
            cbxPeriph.MaxDropDownItems = straPeripherals.GetLength(0);
            cbxPeriph.Items.AddRange(straPeripherals);
            cbxButtonAction.MaxDropDownItems = straActions.GetLength(0);
            cbxButtonAction.Items.AddRange(straActions);
            cbxXY.MaxDropDownItems = straXY.GetLength(0);
            cbxXY.Items.AddRange(straXY);

            cbxPartModifier.Enabled = false;
            cbxXY.Enabled = false;
            tbxCoordinate.Enabled = false;
            cbxPeriphButton.Enabled = false;

            rtbGeneratedCode.Text = "";
        }

        private void btnGenerateCode_Click(object sender, EventArgs e)
        {
            if (tbxCoordinate.Text != "" && cbxButtonAction.SelectedItem.ToString() != "" && cbxPeriphButton.SelectedItem.ToString() != "")
            {
            string strTempCode = "if (";

            //figure out which joint to track and begin constructing code
            switch (cbxBodyPart.SelectedItem.ToString())
            {
                    //joints with 2 modifiers
                case "Head":
                    strTempCode += "jntHead.Position.";
                    break;
                case "Spine":
                    strTempCode += "jntSpine.Position.";
                    break;

                    //joints with 3 modifiers
                case "Shoulder":
                    strTempCode += "jntShoulder";
                    switch (cbxPartModifier.SelectedItem.ToString())
                    {
                        case "Left":
                            strTempCode += "LT.Position.";
                            break;
                        case "Right":
                            strTempCode += "RT.Position.";
                            break;
                        case "Center":
                            strTempCode += "CTR.Position.";
                            break;
                    }
                    break;
                case "Hip":
                    strTempCode += "jntHip";
                    switch (cbxPartModifier.SelectedItem.ToString())
                    {
                        case "Left":
                            strTempCode += "LT.Position.";
                            break;
                        case "Right":
                            strTempCode += "RT.Position.";
                            break;
                        case "Center":
                            strTempCode += "CTR.Position.";
                            break;
                    }
                    break;
                    
                    //joints with 2 modifiers
                case "Elbow":
                    strTempCode += "jntElbow";
                    switch (cbxPartModifier.SelectedItem.ToString())
                    {
                        case "Left":
                            strTempCode += "LT.Position.";
                            break;
                        case "Right":
                            strTempCode += "RT.Position.";
                            break;
                    }
                    break;
                case "Wrist":
                    strTempCode += "jntWrist";
                    switch (cbxPartModifier.SelectedItem.ToString())
                    {
                        case "Left":
                            strTempCode += "LT.Position.";
                            break;
                        case "Right":
                            strTempCode += "RT.Position.";
                            break;
                    }
                    break;
                case "Hand":
                    strTempCode += "jntHand";
                    switch (cbxPartModifier.SelectedItem.ToString())
                    {
                        case "Left":
                            strTempCode += "LT.Position.";
                            break;
                        case "Right":
                            strTempCode += "RT.Position.";
                            break;
                    }
                    break;
                case "Knee":
                    strTempCode += "jntKnee";
                    switch (cbxPartModifier.SelectedItem.ToString())
                    {
                        case "Left":
                            strTempCode += "LT.Position.";
                            break;
                        case "Right":
                            strTempCode += "RT.Position.";
                            break;
                    }
                    break;
                case "Ankle":
                    strTempCode += "jntAnkle";
                    switch (cbxPartModifier.SelectedItem.ToString())
                    {
                        case "Left":
                            strTempCode += "LT.Position.";
                            break;
                        case "Right":
                            strTempCode += "RT.Position.";
                            break;
                    }
                    break;
                case "Foot":
                    strTempCode += "jntFoot";
                    switch (cbxPartModifier.SelectedItem.ToString())
                    {
                        case "Left":
                            strTempCode += "LT.Position.";
                            break;
                        case "Right":
                            strTempCode += "RT.Position.";
                            break;
                    }
                    break;
            }

            //figure out which axis to track and continue constructing code
            if (cbxXY.SelectedItem.ToString() == "X")
                strTempCode += "X >= ";
            if (cbxXY.SelectedItem.ToString() == "Y")
                strTempCode += "Y >= ";

            switch (cbxButtonAction.SelectedItem.ToString())
            {
                case "Press":
                    //add the coordinate the bodypart must pass, close the top bit, and begin telling the computer what to do
                    strTempCode += tbxCoordinate.Text + @")
            {
                InputSimulator.SimulateKeyPress(VirtualKeyCode.";
                    switch (cbxPeriph.SelectedItem.ToString())
                    {
                        case "Keyboard(Special)":
                            strTempCode += cbxPeriphButton.SelectedItem.ToString().ToUpper() + @");
            }
";
                            break;

                        case "Keyboard":
                            strTempCode += "VK_" + cbxPeriphButton.SelectedItem.ToString().ToUpper() + @");
            }
";
                            break;

                        case "Mouse":
                            strTempCode += cbxPeriphButton.SelectedItem.ToString().ToUpper() + @");
            }
";
                            break;
                    }
                    break;

                case "Hold":
                    //add the coordinate the bodypart must pass, close the top bit, and begin telling the computer what to do
                    strTempCode += tbxCoordinate.Text + @")
            {
                InputSimulator.SimulateKeyDown(VirtualKeyCode.";
                    switch (cbxPeriph.SelectedItem.ToString())
                    {
                        case "Keyboard(Special)":
                            strTempCode += cbxPeriphButton.SelectedItem.ToString().ToUpper() + @");
            }
            InputSimulator.SimulateKeyUp(VirtualKeyCode." + cbxPeriphButton.SelectedItem.ToString().ToUpper() + @");
";
                            break;

                        case "Keyboard":
                            strTempCode += "VK_" + cbxPeriphButton.SelectedItem.ToString().ToUpper() + @");
            }
            InputSimulator.SimulateKeyUp(VirtualKeyCode." + "VK_" + cbxPeriphButton.SelectedItem.ToString().ToUpper() + @");
";
                            break;

                        case "Mouse":
                            strTempCode += cbxPeriphButton.SelectedItem.ToString().ToUpper() + @");
            }
            InputSimulator.SimulateKeyUp(VirtualKeyCode." + cbxPeriphButton.SelectedItem.ToString().ToUpper() + @");
";
                            break;
                    }
                    break;
            }
            
            rtbGeneratedCode.AppendText(@"
            " + strTempCode);
            }            
            else
            {
                MessageBox.Show(@"Not enough info to generate code voodoo!
Make sure all enabled boxes are filled out.", "Oops!");
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            rtbGeneratedCode.Text = strPregeneratedCode;
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            Stack<string> stckDeleteIn = new Stack<string>(rtbGeneratedCode.Lines);
            stckDeleteIn.Pop();
            //straDelete[rtbGeneratedCode.Lines.Length+1]
            Stack<string> stckDeleteOut = new Stack<string>(stckDeleteIn.ToArray());
            rtbGeneratedCode.Lines = stckDeleteOut.ToArray();
        }

        private void btnSealCode_Click_1(object sender, EventArgs e)
        {
            if (rtbGeneratedCode.Lines.Contains("            nui.Uninitialize();") == false)
            {
                rtbGeneratedCode.AppendText(@"
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            nui.Uninitialize();
        }
    }
}");
            }
        }

        private void btnSaveCode_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "EasyKin Configurations (*.kcfg)|*.kcfg";

            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFileDialog1.FileName.Length > 0)
            {
                rtbGeneratedCode.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }             
    }
}
