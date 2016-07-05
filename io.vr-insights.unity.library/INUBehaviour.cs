using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace io.vr_insights.unity.library
{
    public interface INUBehaviour<D, A>
        where D : INUBehaviourDetector
        where A : INUBehaviourActivator
    {

    }

    public interface INUBehaviourDetector
    {
        
        void behaviourDetected(String type, String data);
    }

    public interface INUBehaviourActivator
    {
        void behaviourActivated(String type, String data);
    }
}
