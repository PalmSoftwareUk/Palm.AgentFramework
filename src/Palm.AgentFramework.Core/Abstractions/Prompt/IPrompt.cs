namespace Palm.AgentFramework.Core.Abstractions.Prompt;

/// <summary>
/// Represents a prompt that can be converted to a string.
/// </summary>
public interface IPrompt
{
    /// <summary>
    /// Converts the prompt to a string.
    /// </summary>
    Task<string> ToPromptString();
}