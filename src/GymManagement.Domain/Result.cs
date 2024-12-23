public class Result<T>
{
    public bool IsSuccess { get; private set; }
    public string Error { get; private set; }
    public T Value { get; private set; }

    private Result(bool isSuccess, T value, string error)
    {
        IsSuccess = isSuccess;
        Value = value;
        Error = error;
    }

    public static Result<T> Success(T value)
    {
        return new Result<T>(true, value, null);
    }

    public static Result<T> Failure(string error)
    {
        return new Result<T>(false, default, error);
    }

    public TResult Match<TResult>(Func<T, TResult> onSuccess, Func<string, TResult> onFailure)
    {
        return IsSuccess ? onSuccess(Value) : onFailure(Error);
    }

    // Implicit conversion from T to Result<T>
    public static implicit operator Result<T>(T value)
    {
        return Success(value);
    }

    // Implicit conversion from string (error) to Result<T>
    public static implicit operator Result<T>(string error)
    {
        return Failure(error);
    }
}