namespace GymManagement.Domain;

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
        return new Result<T>(true, value, null!);
    }

    public static Result<T> Failure(string error)
    {
        return new Result<T>(false, default!, error);
    }

    /// <summary>
    /// Matches the Result state and executes the corresponding function.
    /// </summary>
    public TResult Match<TResult>(Func<T, TResult> onSuccess, Func<string, TResult> onFailure)
    {
        return IsSuccess ? onSuccess(Value) : onFailure(Error);
    }
}