public interface IUser 
{
  public string FirstName { get; }
  public string LastName { get; }
}

public class User: IUser 
{
  public string FirstName { get; private set; }
  public string LastName { get; private set; }

  public User(string firstName, string lastName)
  {
    FirstName = firstName;
    LastName = lastName;
  }
}

public class NullUser: IUser 
{
  public string FirstName { get; } = string.Empty;
  public string LastName { get; } = string.Empty;
}


public void SaveUser(User userToSave)
{
  //if (userToSave == null) throw new ArgumentNullException(nameof(userToSave));
  //if (userToSave.FirstName == null) throw new ArgumentNullException(nameof(userToSave.FirstName));
  //if (userToSave.LastName == null) throw new ArgumentNullException(nameof(userToSave.LastName));

  // Save User without checking for properties if they are null
}


public User GetUserById(int userId)
{
  var userFromDb = _userRepo.GetUserById(userId);

  if (userFromDb is null)
    return new NullUser();

  return userFromDb;
}
