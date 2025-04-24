namespace QMS.core.Services.SystemLogs;

public interface ISystemLogService
{
    bool WriteLog(string strMessage);
}
