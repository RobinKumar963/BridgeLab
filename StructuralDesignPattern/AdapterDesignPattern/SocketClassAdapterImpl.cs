
namespace Bridgelabz.DesignPattern.StructuralDesignPattern.AdapterDesignPattern
{
    class SocketClassAdapterImpl : Socket , SocketAdapter
    {
        public Volt Get120Volt()
        {
            return GetVolt(); 
        }

        public Volt Get12Volt()
        {
            Volt v = GetVolt();
            return ConvertVolt(v, 10); 
        }

        public Volt Get3Volt()
        {
            Volt v = GetVolt();
            return ConvertVolt(v, 40);
        }
        private Volt ConvertVolt(Volt v, int i)
        {
            return new Volt(v.GetVolts() / i);
        }


    }
}
