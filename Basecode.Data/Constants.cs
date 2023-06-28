using System.Configuration;

namespace Basecode.Data
{
    public static class Constants
    {
        public class Token
        {
            public const string Issuer = "Basecode:Issuer";
            public const string Audience = "Basecode:Audience";            
            public const string SecretKey = "Basecode:AuthSecretKey";
            public const string POST = "POST";
            public const string TokenPath = "/api/token";
            public const string Username = "username";
            public const string Password = "password";
            public const string RefreshToken = "refresh_token";
            public const string UserID = "user_id";
        }

        public class SortDirection
        {
            public const string Ascending = "Ascending";
            public const string Descending = "Descending";
        }

        public class Claims
        {
            public const string Id = "userId";
            public const string UserName = "userName";
            public const string Role = "userRole";
        }

        public class ClaimTypes
        {
            public const string UserName = "user_name";
            public const string ID = "id";
            public const string UserId = "user_id";
            public const string FullName = "full_name";
        }

        public class Common
        {
            public const string Basecode = "Basecode";
            public const string OAuth = "/oauth";
            public const string Client = "Client";
            public const string ClientID = "ClientID";
            public const string ClientSecret = "ClientSecret";
            public const string JSONContentType = "application/json";
            public const string Bearer = "Bearer";

            // Messages
            public const string BadRequest = "Bad Request";
            public const string InvalidRole = "Invalid Role";
            public const string EmailSuccess = "Email Successfully Sent!";
        }

        public class Attachment
        {
            // Messages
            public const string FileNotFound = "File cannot be found.";
            public const string FileEmpty = "File is empty.";

            public const string DownloadAttachment = "downloadAttachment";
            public const string DownloadImage = "downloadImage";
            public const string AttachmentPath = "Attachment:AttachmentPath";
            public const string FullFilePath = "{0}\\{1}\\";
        }

        public class Exception
        {
            public const string ErrorProcessing = "An error was encountered while processing the request. Please refresh the page and try again. If the problem still occurs, contact your administrator.";
            public const string IO = "An error was encountered while processing a file upload/download request.";
            public const string DB = "An error was encountered while processing a database request.";
            public const string SMTP = "An error was encountered while processing an email sending request.";
        }

        public class Roles
        {
            public const string Admin = "Administrator";
            public const string User = "User";

        }

        #region SMTP
        /// <summary>
        /// Constants for SMTP
        /// </summary>
        public static class SMTP
        {
            public const string Format = "text/html";

            public static string SMTPClient
            {
                get
                {
                    return "smtp.gmail.com";
                }
            }

            public static string EmailAddress
            {
                get
                {
                    return "";
                }
            }

            public static string EmailPassword
            {
                get
                {
                    return "";
                }
            }

            public static string GroupEmail
            {
                get
                {
                    return "";
                }
            }

            public static string Email
            {
                get
                {
                    return "";
                }
            }

            public static string EmailName
            {
                get
                {
                    return "JumpStart Email";
                }
            }
        }
        #endregion SMTP

        #region Upload

        public static class Upload
        {
            public static string RootUploadPath = ConfigurationManager.AppSettings["RootUploadPath"].ToString();
            public const string UploadPath = "\\Attachment\\{0}\\";

            public const string AbsolutePath = "{0}{1}\\{2}\\";
            public const string RelativePath = "\\{0}\\{1}\\{2}\\";
            public const string FilePath = "{0}://{1}:{2}{3}";
            public const string FormData = "form-data";
            public const string Slash = "\\";
            public const string Id = "Id";
            public const string ModuleName = "ModuleName";
            public const string RemovedFileList = "RemovedFileList";
            public const string AttachmentPath = "Attachment";
            public const string FileToDelete = "{0}{1}\\{2}\\{3}";
            public const string FileNameAppendFormat = "{0} ({1}).{2}";
            public const string FilePathKey = "filePath";
            public const string FileNameKey = "fileName";
            public const string FileIDKey = "id";
            public const char PeriodCharType = '.';
            public const string FilePathFormat = "{0}/{1}/{2}/";
            public const string Attachment = "Attachments";
            public const string ClientSignature = "ClientSignature";
        }

        #endregion Upload

        public class User
        {
            public const string InvalidUserNamePassword = "Invalid username or password.";
        }

        public class Student
        {
            // Sort Keys
            public const string StudentHeaderId = "stud_id";
            public const string StudentHeaderName = "stud_name";
            public const string StudentHeaderEmail = "stud_email";
            public const string StudentHeaderClass = "stud_class";
            public const string StudentHeaderEnrollYear = "stud_enrollYear";
            public const string StudentHeaderCity = "stud_city";
            public const string StudentHeaderCountry = "stud_country";

            // Messages
            public const string StudentNameExists = "Student name already exists";
            public const string StudentEntryInvalid = "Student entry is not valid!";
            public const string StudentNotExist = "Student does not exist.";       
            public const string StudentDoesNotExists = "Student does not exist.";
            public const string StudentSuccessAdd = "Student added successfully.";
            public const string StudentSuccessEdit = "Student is updated successfully.";
            public const string StudentSuccessDelete = "Student is deleted successfully.";
        }
        public class Reports
        {
            public const string ExcelTable = "<!DOCTYPE HTML><html><body><table border='1'><tr><td>This is a sample file. This a sample file.</td></tr></table></body></html>";
            public const string PDFContent = "<!DOCTYPE HTML><html><body><table border='1'><tr><td>This is a sample file. This a sample file.</td></tr></table></body></html>";
        }
    }
}