using System.Globalization;

namespace Sungero.Plugins.Sdk
{
  /// <summary>
  /// Получатель информации о пользователе.
  /// </summary>  
  public interface IUserInfoGetter
  {
    /// <summary>
    /// Культура пользователя.
    /// </summary>
    CultureInfo CultureInfo { get; }
  }
}