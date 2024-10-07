using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Robot.Dance.Wonderful.Show.RNRobotDanceWonderfulShow
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNRobotDanceWonderfulShowModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNRobotDanceWonderfulShowModule"/>.
        /// </summary>
        internal RNRobotDanceWonderfulShowModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNRobotDanceWonderfulShow";
            }
        }
    }
}
