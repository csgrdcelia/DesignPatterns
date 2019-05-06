using System.Collections.Generic;
namespace ComputerBuilderNs
{
    public interface IComputerBuilder 
    {
         ComputerBuilder SetCPU(ICPU cpu);
         ComputerBuilder SetHeadphone(IHeadphone headphone);
         ComputerBuilder SetMouse(IMouse mouse);
         ComputerBuilder SetBag(IBag bag);
         ComputerBuilder SetKeyboard(IKeyboard keyboard);
         ComputerBuilder AddScreen(IScreen screen);
         ComputerBuilder AddRam(IRam ram);
         ComputerBuilder AddStorage(IStorage storage);
         ComputerBuilder AddGPU(IGPU gpu);

         Computer Build(); 
    }
}