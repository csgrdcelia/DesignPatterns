using System.Collections.Generic;
namespace ComputerBuilderNs
{
    public class Computer
    {
        private double _basePrice = 300;

        private ICPU _cpu;
        private IHeadphone _headphone;
        private IMouse _mouse;
        private IBag _bag;
        private IKeyboard _keyboard;
        private List<IScreen> _screens;
        private List<IRam> _rams;
        private List<IStorage> _storages;
        private List<IGPU> _gpus;

        public Computer(ICPU cpu, IHeadphone headphone, IMouse mouse, IBag bag, IKeyboard keyboard, List<IScreen> screens, List<IRam> rams, List<IStorage> storages, List<IGPU> gpus) 
        {
            _cpu = cpu;
            _headphone = headphone;
            _mouse = mouse;
            _bag = bag;
            _keyboard = keyboard;
            _screens = screens;
            _rams = rams;
            _storages = storages;
            _gpus = gpus;
        }
        public double GetPrice() {
            double price = _basePrice;

            price += _cpu == null ? 0 : _cpu.GetPrice();
            price += _mouse == null ? 0 : _mouse.GetPrice();
            price += _keyboard == null ? 0 : _keyboard.GetPrice();
            price += _headphone == null ? 0 : _headphone.GetPrice();
            price += _bag == null ? 0 : _bag.GetPrice();

            foreach(IScreen screen in _screens) 
            {
                price += screen.GetPrice();
            }

            foreach(IRam ram in _rams) 
            {
                price += ram.GetPrice();
            }

            foreach(IStorage storage in _storages) 
            {
                price += storage.GetPrice();
            }

            foreach(IGPU gpu in _gpus) 
            {
                price += gpu.GetPrice();
            }

            return price;
        }

    }
}