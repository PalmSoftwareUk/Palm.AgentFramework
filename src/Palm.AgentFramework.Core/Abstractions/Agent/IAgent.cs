using Palm.AgentFramework.Core.Abstractions.IO;

namespace Palm.AgentFramework.Core.Abstractions.Agent;

/// <summary>
/// Converts the prompt to a string.
/// </summary>
public interface IAgent;

/// <summary>
/// Represents an agent that can be executed.
/// </summary>
/// <typeparam name="TInput">The type of input for the agent.</typeparam>
/// <typeparam name="TOutput">The type of output for the agent.</typeparam>
public interface IAgent<in TInput, TOutput> : IAgent where TInput : IAgentInput where TOutput : IAgentOutput
{
    Task<TOutput> ExecuteAsync(TInput input);
    
}