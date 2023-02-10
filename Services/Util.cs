namespace POC_NET7.Services;

public class Util {
    public int CalculateAge (int yearOfBirth) {
        return DateTime.UtcNow.Year - yearOfBirth;
    }
}