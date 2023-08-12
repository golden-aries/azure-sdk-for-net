using System.Text.Json;
using TxExperiment;

namespace TxTests;

public class UnitTest1
{
    private string json = @"
{
  ""id"": ""chatcmpl-7mSfLlVaFSuxrRjnPbvjCj9oVbZ6W"",
  ""created"": 1691786602,
  ""choices"": [
    {
      ""message"": {
        ""role"": ""assistant"",
        ""content"": ""Bob Cat is reporting that their tester is not functioning properly.""
      },
      ""index"": 0,
      ""finishReason"": ""stop""
    }
  ],
  ""usage"": {
    ""completionTokens"": 12,
    ""promptTokens"": 408,
    ""totalTokens"": 420
  }
}
";

    private string dJson = @"
{""id"":""chatcmpl-7mU0CM5ObhQkFGgUSPuRN20CHPlZL"",""object"":""chat.completion"",""created"":1691789428,""model"":""gpt-35-turbo"",""choices"":[{""index"":0,""finish_reason"":""stop"",""message"":{""role"":""assistant"",""content"":""Bob Cat is reporting that their tester is not functioning properly.""}}],""usage"":{""completion_tokens"":17,""prompt_tokens"":408,""total_tokens"":425}}";

    private string vJson = @"
{
  ""Id"": ""chatcmpl-7mU0CM5ObhQkFGgUSPuRN20CHPlZL"",
  ""Created"": ""2023-08-11T21:30:28Z"",
  ""Choices"": [
    {
      ""Message"": {
        ""Role"": {
          ""Label"": ""assistant""
        },
        ""Content"": ""Bob Cat is reporting that their tester is not functioning properly.""
      },
      ""Index"": 0,
      ""FinishReason"": ""stop""
    }
  ],
  ""Usage"": {
    ""CompletionTokens"": 17,
    ""PromptTokens"": 408,
    ""TotalTokens"": 425
  }
}";

    private string rJson = @"
{
  ""Id"": ""chatcmpl-7mU0CM5ObhQkFGgUSPuRN20CHPlZL"",
  ""Created"": ""2023-08-11T21:30:28Z"",
  ""Choices"": [
    {
      ""Message"": {
        ""Role"": {
          ""Label"": ""assistant""
        },
        ""Content"": ""Bob Cat is reporting that their tester is not functioning properly.""
      },
      ""Index"": 0,
      ""FinishReason"": ""stop""
    }
  ],
  ""Usage"": {
    ""CompletionTokens"": 17,
    ""PromptTokens"": 408,
    ""TotalTokens"": 425
  }
}";
    [Fact]
    public void Test1()
    {
        var elem = JsonSerializer.Deserialize<JsonElement>(dJson);
        var completion = TxChatCompletionDeserializer.DeserializeChatCompletions(elem);
    }
}
