using System.Collections.Generic;
namespace ComputerBuilderNs
{
    public class ComputerBuilder : IComputerBuilder
    {
        private ICPU _cpu;
        private IHeadphone _headphone;
        private IMouse _mouse;
        private IBag _bag;
        private IKeyboard _keyboard;
        private List<IScreen> _screens;
        private List<IRam> _rams;
        private List<IStorage> _storages;
        private List<IGPU> _gpus;

        public ComputerBuilder() 
        {
            _screens = new List<IScreen>();
            _rams = new List<IRam>();
            _storages = new List<IStorage>();
            _gpus = new List<IGPU>();
        }

        public ComputerBuilder SetCPU(ICPU cpu) 
        {
            _cpu = cpu;
            return this;
        }
        public ComputerBuilder SetHeadphone(IHeadphone headphone) 
        {
            _headphone = headphone;
            return this;
        }
        public ComputerBuilder SetMouse(IMouse mouse) 
        {
            _mouse = mouse;
            return this;
        }
        public ComputerBuilder SetBag(IBag bag)
        {
            _bag = bag;
            return this;
        }
        public ComputerBuilder SetKeyboard(IKeyboard keyboard)
        {
            _keyboard = keyboard;
            return this;
        }
        public ComputerBuilder AddScreen(IScreen screen)
        {
            _screens.Add(screen);
            return this;
        }
        public ComputerBuilder AddRam(IRam ram)
        {
            _rams.Add(ram);
            return this;
        }
        public ComputerBuilder AddStorage(IStorage storage)
        {
            _storages.Add(storage);
            return this;
        }
        public ComputerBuilder AddGPU(IGPU gpu)
        {
            _gpus.Add(gpu);
            return this;
        }
        
        public Computer Build()
        {
            if(_cpu == null || _rams.Count == 0 || _storages.Count == 0)
                throw new IncompleteComputerException();
            return new Computer(_cpu, _headphone, _mouse, _bag, _keyboard, _screens, _rams, _storages, _gpus);
        }
    }
}