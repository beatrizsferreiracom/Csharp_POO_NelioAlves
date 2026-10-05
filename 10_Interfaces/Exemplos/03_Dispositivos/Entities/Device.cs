using System;

namespace Dispositivos.Entities
{
    abstract class Device
    {
        public int SerialNumber { get; set; }

        public abstract void ProcessDoc(string document);
    }
}