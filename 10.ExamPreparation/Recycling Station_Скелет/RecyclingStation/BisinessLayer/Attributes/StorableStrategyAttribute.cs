using RecyclingStation.WasteDisposal.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecyclingStation.BisinessLayer.Attributes
{
    public class StorableStrategyAttribute : DisposableAttribute
    {
        public StorableStrategyAttribute(Type correspondingStrategyType) : base(correspondingStrategyType)
        {
        }
    }
}
