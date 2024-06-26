using ForgeWorks.ProtoLab.Integration;

namespace ProtoLab.Sample.StateConfigurator._01;

[Integration("sample_01")]
public class StateConfig
{
    public StateConfiguration state_config { get; set; } = new()
    {
        on_state = "launch.execute",
        execute = "write_line"
    };

    //  this can go anywhere; not required to be in Integration class
    [StateAction("write_line")]
    private void WriteLine()
    {
        Console.WriteLine($"{nameof(StateConfig)}.{nameof(WriteLine)}");
    }
}
