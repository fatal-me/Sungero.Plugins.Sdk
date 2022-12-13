using System;
using System.Globalization;

namespace Sungero.Plugins.Sdk
{
  /// <summary>
  /// Класс для получения информации о пользователе.
  /// </summary>
  public static class UserInfo
  {
    /// <summary>
    /// Получатель информации о пользователе.
    /// </summary>
    private static Lazy<IUserInfoGetter> userInfoGetter;
    
    /// <summary>
    /// Установить объект для получения информации о пользователе.
    /// </summary>
    /// <param name="userInfoGetter">Ленивый объект для получения информации о пользователе.</param>
    public static void SetUserInfoGetter(Lazy<IUserInfoGetter> userInfoGetter)
    {
      UserInfo.userInfoGetter = userInfoGetter;
    }

    /// <summary>
    /// Культура пользователя.
    /// </summary>    
    public static CultureInfo CultureInfo
    {
      get
      {
        CheckUserInfoGetter();

        return userInfoGetter.Value.CultureInfo;
      }
    }
    
    /// <summary>
    /// Проверить наличие объекта для получения информации о пользователе.
    /// </summary>
    private static void CheckUserInfoGetter()
    {
      if (userInfoGetter?.Value == null)
        throw new NullReferenceException("UserInfoGetter has no implementation.");
    }    
  }
}