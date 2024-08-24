namespace RateIdeas.Application.Commons.Exceptions;

public class AlreadyExistException(string model, string prop, dynamic value)
    : BaseException($"{model} is already exist with {prop}: {value}", 409)
{
}
