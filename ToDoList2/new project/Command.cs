using Amazon.Runtime.Internal;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;

namespace ToDoList2.new_project
{
    public class CreateBatteryCommand : IRequest<Guid>
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        Guid IRequest<Guid>.Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

}
