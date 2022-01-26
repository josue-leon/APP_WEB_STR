using System;
using System.Runtime.Serialization;

namespace SignalRWebApp.Models
{
    [Serializable]
    [DataContract(IsReference = true)]
    public abstract class EntityBase
    {
    }
}
