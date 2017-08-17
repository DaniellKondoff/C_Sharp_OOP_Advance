using RecyclingStation.WasteDisposal.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecyclingStation.BisinessLayer.Attributes
{
    public class BurnableStrategyAttribute : DisposableAttribute
    {
        public BurnableStrategyAttribute(Type correspondingStrategyType) : base(correspondingStrategyType)
        {
        }
    }
}
