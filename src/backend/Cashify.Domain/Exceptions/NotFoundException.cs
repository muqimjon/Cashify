﻿namespace RateIdeas.Application.Commons.Exceptions;

public class NotFoundException(string message)
    : BaseException(message, 404)
{
}
