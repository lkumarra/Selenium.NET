namespace SeleniumPOM.Interfaces
{
    public interface IConfig
    {
        /// <summary>
        /// Get the Browser name from config file.
        /// </summary>
        /// <returns>Name of web browser</returns>
        string GetBrowser();

        /// <summary>
        /// Get the UserName from Config file.
        /// </summary>
        /// <returns>User Name</returns>
        string GetUserName();

        /// <summary>
        /// Get Password from Config file.
        /// </summary>
        /// <returns>Password</returns>
        string GetPassword();

        /// <summary>
        /// Get Url from config file.
        /// </summary>
        /// <returns>Url</returns>
        string GetUrl();
    }
}
