/*
 * Created by Ranorex
 * User: Sandeep
 * Date: 04-08-2016
 * Time: 12:01 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace trial
{
    /// <summary>
    /// Description of UserCodeModule1.
    /// </summary>
    [TestModule("D0697171-9AAA-42C1-B8CD-C23A3244B3AC", ModuleType.UserCode, 1)]
    public class UserCodeModule1 : ITestModule
    {
   // var  repo12 = newrepo.Instance;
   
    
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public UserCodeModule1()
        {
            // Do not delete - a parameterless constructor is required!
        }

string newd = "";
//[TestVariable("28902557-0917-4fe5-b590-87e14a764dae")]


        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
          //  var repo = newrepo.Instance;
        //    var dubberMozillaFirefox = repo1.DubberMozillaFirefox;

            //    Report.Log(ReportLevel.Info, "Website", "Opening web site 'https://tigers.dubber.net/login' with browser 'Firefox' in normal mode.", new RecordItemIndex(0));
         //   Host.Local.OpenBrowser("https://tigers.dubber.net/login", "Firefox", "", false, false, false, false, false);
          //  Delay.Milliseconds(0);
            
          /*  var repo = trialRepository.Instance;
            var emailAddress = repo.DubberMozillaFirefox.Grouping.EmailAddress;
           // emailAddress.Click();
          //  emailAddress. = "qa+4@dxfs";
            var userPassword = repo.Dubber.UserPassword;
            userPassword.Click();
            userPassword.Value = _NewVariable;*/
              Report.Log(ReportLevel.Info, "Website", "Opening web site 'https://tigers.dubber.net/login' with browser 'Chrome' in normal mode.", new RecordItemIndex(0));
            Host.Local.OpenBrowser("https://tigers.dubber.net/login", "Chrome", "", false, false, false, false, false);
            Delay.Milliseconds(0);
            var repo1 = newrepo.Instance;
            var emailAddress1 = repo1.DubberMozillaFirefox.Grouping.EmailAddress;
            emailAddress1.Click();
            emailAddress1.TextValue = "qa+4@dubber,net";
            var userPassword = repo1.Dubber.UserPassword;
            userPassword.Value = newd;
         
              
        }
    }
}
