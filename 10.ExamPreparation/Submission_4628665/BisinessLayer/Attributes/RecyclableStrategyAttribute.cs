using RecyclingStation.WasteDisposal.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecyclingStation.BisinessLayer.Attributes
{
    public class RecyclableStrategyAttribute : DisposableAttribute
    {
        public RecyclableStrategyAttribute(Type correspondingStrategyType) : base(correspondingStrategyType)
        {
        }
    }
}
