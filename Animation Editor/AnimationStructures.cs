using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animation_Editor
{
    public class YANMFile
    {
        public string type { get; set; }
        public int numOfAnimSegments { get; set; }
        public YANM[] SubContainer { get; set; }
        public string YANMType { get; set; }
    }

    public class YANM
    {
        public PREYANMHEADER headerContainer { get; set; }

        // Header Data
        public int headerStart { get; set; }
        public int hipStart { get; set; }
        public int xPosModelStart { get; set; }
        public int yPosModelStart { get; set; }
        public int spineStart { get; set; }
        public int headStart { get; set; }
        public int neckStart { get; set; }
        public int leftShoulderStart { get; set; }
        public int leftArmStart { get; set; }
        public int leftElbowStart { get; set; }
        public int leftHandStart { get; set; }
        public int leftFingers1 { get; set; }
        public int leftFingers2 { get; set; }
        public int leftFingers3 { get; set; }
        public int leftFingers4 { get; set; }
        public int leftFingers5 { get; set; }
        public int leftFingers6 { get; set; }
        public int leftFingers7 { get; set; }
        public int leftFingers8 { get; set; }
        public int leftFingers9 { get; set; }
        public int leftFingers10 { get; set; }
        public int leftFingers11 { get; set; }
        public int leftFingers12 { get; set; }
        public int leftFingers13 { get; set; }
        public int leftFingers14 { get; set; }
        public int leftFingers15 { get; set; }
        public int leftFingers16 { get; set; }
        public int leftFingers17 { get; set; }
        public int rightShoulderStart { get; set; }
        public int rightArmStart { get; set; }
        public int rightElbowStart { get; set; }
        public int rightHandStart { get; set; }
        public int rightFingers1 { get; set; }
        public int rightFingers2 { get; set; }
        public int rightFingers3 { get; set; }
        public int rightFingers4 { get; set; }
        public int rightFingers5 { get; set; }
        public int rightFingers6 { get; set; }
        public int rightFingers7 { get; set; }
        public int rightFingers8 { get; set; }
        public int rightFingers9 { get; set; }
        public int rightFingers10 { get; set; }
        public int rightFingers11 { get; set; }
        public int rightFingers12 { get; set; }
        public int rightFingers13 { get; set; }
        public int rightFingers14 { get; set; }
        public int rightFingers15 { get; set; }
        public int rightFingers16 { get; set; }
        public int rightFingers17 { get; set; }
        public int leftLeg { get; set; }
        public int leftKnee { get; set; }
        public int leftFoot { get; set; }
        public int rightLeg { get; set; }
        public int rightKnee { get; set; }
        public int rightFoot { get; set; }
    }
        public class PREYANMHEADER
        {
            public byte[] stream { get; set; }
            public int beginOffset { get; set; }
            public int endOffset { get; set; }
            public int numOfSegments { get; set; }
        }
    }