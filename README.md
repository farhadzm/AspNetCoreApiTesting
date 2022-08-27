# AspNetCoreApiTesting
An example of writing test for APIs in Asp.Net Core with xUnit
```csharp
[Fact]
public async Task When_IdIsNotValid_Then_NotFoundStatusCodeShouldBeReturned()
{
    var httpClient = _factory.CreateClient();

    var userResponse = await httpClient.GetAsync($"/api/users/{-1}");

    userResponse.StatusCode.Should().Be(HttpStatusCode.NotFound);
}

```
