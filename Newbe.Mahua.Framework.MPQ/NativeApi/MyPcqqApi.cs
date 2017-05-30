using System.Runtime.InteropServices;

namespace Newbe.Mahua.Framework.MPQ.NativeApi
{
    public class MyPcqqApi : IMyPcqqApi
    {
        /// <summary>
        /// �����ύ��QQ�ż���õ�ҳ������ò���Bkn��G_tk`
        /// </summary>
        /// <param name="��Ӧ��QQ"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetGtk_Bkn(string ��Ӧ��QQ)
            => NativeMethods.Api_GetGtk_Bkn(��Ӧ��QQ);

        /// <summary>
        /// �����ύ��QQ�ż���õ�ҳ������ò�����Bkn��G_tk`
        /// </summary>
        /// <param name="��Ӧ��QQ"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetBkn32(string ��Ӧ��QQ)
            => NativeMethods.Api_GetBkn32(��Ӧ��QQ);

        /// <summary>
        /// �����ύ��QQ�ż���õ�ҳ������ò�����Ldw`
        /// </summary>
        /// <param name="��Ӧ��QQ"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetLdw(string ��Ӧ��QQ)
            => NativeMethods.Api_GetLdw(��Ӧ��QQ);

        /// <summary>
        /// ȡ�ÿ������Ŀ¼.���ܼ����ˡ�`
        /// </summary>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetRunPath()
            => NativeMethods.Api_GetRunPath();

        /// <summary>
        /// ȡ�õ�ǰ��������߿��õ�QQ�б�`
        /// </summary>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetOnlineQQlist()
            => NativeMethods.Api_GetOnlineQQlist();

        /// <summary>
        /// ȡ�ÿ��������QQ�б�����δ��¼�Լ���¼ʧ�ܵ�QQ`
        /// </summary>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetQQlist()
            => NativeMethods.Api_GetQQlist();

        /// <summary>
        /// ����QQȡ�ö�Ӧ�ĻỰ��Կ`
        /// </summary>
        /// <param name="��Ӧ��QQ"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetSessionkey(string ��Ӧ��QQ)
            => NativeMethods.Api_GetSessionkey(��Ӧ��QQ);

        /// <summary>
        /// ȡ��ҳ���¼�õ�Clientkey`
        /// </summary>
        /// <param name="��Ӧ��QQ"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetClientkey(string ��Ӧ��QQ)
            => NativeMethods.Api_GetClientkey(��Ӧ��QQ);

        /// <summary>
        /// ȡ��ҳ���¼�õĳ�Clientkey`
        /// </summary>
        /// <param name="��Ӧ��QQ"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetLongClientkey(string ��Ӧ��QQ)
            => NativeMethods.Api_GetLongClientkey(��Ӧ��QQ);

        /// <summary>
        /// ȡ��ҳ������õ�Cookies`
        /// </summary>
        /// <param name="��Ӧ��QQ"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetCookies(string ��Ӧ��QQ)
            => NativeMethods.Api_GetCookies(��Ӧ��QQ);

        /// <summary>
        /// ȡ�ÿ�������õ���Ϣ����ǰ׺`
        /// </summary>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetPrefix()
            => NativeMethods.Api_GetPrefix();

        /// <summary>
        /// ��Ⱥ��Ƭ������ٻ��浱��.`
        /// </summary>
        /// <param name="Ⱥ��"></param>
        /// <param name="QQ"></param>
        /// <param name="��Ƭ"></param>
        /// <returns></returns>
        void IMyPcqqApi.Api_Cache_NameCard(string Ⱥ��, string QQ, string ��Ƭ)
            => NativeMethods.Api_Cache_NameCard(Ⱥ��, QQ, ��Ƭ);

        /// <summary>
        /// ��ָ��QQ�Ƴ�QQ������`
        /// </summary>
        /// <param name="��Ӧ��QQ"></param>
        /// <param name="QQ"></param>
        /// <returns></returns>
        void IMyPcqqApi.Api_DBan(string ��Ӧ��QQ, string QQ)
            => NativeMethods.Api_DBan(��Ӧ��QQ, QQ);

        /// <summary>
        /// ��ָ��QQ����QQ������`
        /// </summary>
        /// <param name="��Ӧ��QQ"></param>
        /// <param name="QQ"></param>
        /// <returns></returns>
        void IMyPcqqApi.Api_Ban(string ��Ӧ��QQ, string QQ)
            => NativeMethods.Api_Ban(��Ӧ��QQ, QQ);

        /// <summary>
        /// ����Ⱥ��Ա`
        /// </summary>
        /// <param name="��Ӧ��QQ"></param>
        /// <param name="Ⱥ��">���Զ�������Ⱥ.</param>
        /// <param name="QQ">���Զ���.����ΪȫȺ����</param>
        /// <param name="ʱ��">��λ:�� ���Ϊ1����. Ϊ���������ȫȺ����</param>
        /// <returns></returns>
        bool IMyPcqqApi.Api_Shutup(string ��Ӧ��QQ, string Ⱥ��, string QQ, int ʱ��)
            => NativeMethods.Api_Shutup(��Ӧ��QQ, Ⱥ��, QQ, ʱ��);

        /// <summary>
        /// ��Ⱥ����`
        /// </summary>
        /// <param name="��Ӧ��QQ"></param>
        /// <param name="Ⱥ��"></param>
        /// <param name="����"></param>
        /// <param name="����"></param>
        /// <returns></returns>
        void IMyPcqqApi.Api_SetNotice(string ��Ӧ��QQ, string Ⱥ��, string ����, string ����)
            => NativeMethods.Api_SetNotice(��Ӧ��QQ, Ⱥ��, ����, ����);

        /// <summary>
        /// ȡȺ����`
        /// </summary>
        /// <param name="��Ӧ��QQ"></param>
        /// <param name="Ⱥ��"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetNotice(string ��Ӧ��QQ, string Ⱥ��)
            => NativeMethods.Api_GetNotice(��Ӧ��QQ, Ⱥ��);

        /// <summary>
        /// ȡȺ��Ƭ`
        /// </summary>
        /// <param name="��Ӧ��QQ"></param>
        /// <param name="Ⱥ��"></param>
        /// <param name="QQ"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetNameCard(string ��Ӧ��QQ, string Ⱥ��, string QQ)
            => NativeMethods.Api_GetNameCard(��Ӧ��QQ, Ⱥ��, QQ);

        /// <summary>
        /// ����Ⱥ��Ƭ`
        /// </summary>
        /// <param name="��Ӧ��QQ"></param>
        /// <param name="Ⱥ��"></param>
        /// <param name="QQ"></param>
        /// <param name="��Ƭ"></param>
        /// <returns></returns>
        void IMyPcqqApi.Api_SetNameCard(string ��Ӧ��QQ, string Ⱥ��, string QQ, string ��Ƭ)
            => NativeMethods.Api_SetNameCard(��Ӧ��QQ, Ⱥ��, QQ, ��Ƭ);

        /// <summary>
        /// �˳�������`
        /// </summary>
        /// <param name="��Ӧ��QQ"></param>
        /// <param name="������ID"></param>
        /// <returns></returns>
        void IMyPcqqApi.Api_QuitDG(string ��Ӧ��QQ, string ������ID)
            => NativeMethods.Api_QuitDG(��Ӧ��QQ, ������ID);

        /// <summary>
        /// ɾ������`
        /// </summary>
        /// <param name="��Ӧ��QQ"></param>
        /// <param name="QQ"></param>
        /// <returns></returns>
        bool IMyPcqqApi.Api_DelFriend(string ��Ӧ��QQ, string QQ)
            => NativeMethods.Api_DelFriend(��Ӧ��QQ, QQ);

        /// <summary>
        /// �������Ƴ�Ⱥ`
        /// </summary>
        /// <param name="��Ӧ��QQ"></param>
        /// <param name="Ⱥ��"></param>
        /// <param name="����"></param>
        /// <returns></returns>
        bool IMyPcqqApi.Api_Kick(string ��Ӧ��QQ, string Ⱥ��, string ����)
            => NativeMethods.Api_Kick(��Ӧ��QQ, Ⱥ��, ����);

        /// <summary>
        /// ������Ⱥ.Ϊ�˱����桢Ⱥ����Ϊ��������֤��ʱ����ֱ��ʧ�ܲ�����`
        /// </summary>
        /// <param name="��Ӧ��QQ"></param>
        /// <param name="Ⱥ��"></param>
        /// <param name="��������"></param>
        /// <returns></returns>
        void IMyPcqqApi.Api_JoinGroup(string ��Ӧ��QQ, string Ⱥ��, string ��������)
            => NativeMethods.Api_JoinGroup(��Ӧ��QQ, Ⱥ��, ��������);

        /// <summary>
        /// �˳�Ⱥ`
        /// </summary>
        /// <param name="��Ӧ��QQ"></param>
        /// <param name="Ⱥ��"></param>
        /// <returns></returns>
        void IMyPcqqApi.Api_QuitGroup(string ��Ӧ��QQ, string Ⱥ��)
            => NativeMethods.Api_QuitGroup(��Ӧ��QQ, Ⱥ��);

        /// <summary>
        /// ����ֵ:�ɹ�����ͼƬGUID���ڷ��͸�ͼƬ.ʧ�ܷ��ؿ�.  ͼƬ�ߴ�ӦС��4MB`
        /// </summary>
        /// <param name="��Ӧ��QQ">������QQ</param>
        /// <param name="��_�ϴ�����">1����2Ⱥ ע:����ͼ��Ⱥͼ��GUID������ͬ����ͨ�� ��Ҫ�Ǳ��ϴ���Ⱥ��������������2 ��ʱ�Ự��������Ϣ��Ҫ����1</param>
        /// <param name="��_�ο�����">�ϴ���ͼƬ������Ⱥ�Ż�QQ</param>
        /// <param name="��_ͼƬ����">ַ, ͼƬ�ֽڼ����ݻ��ֽڼ�����ָ��()</param>
        /// <returns></returns>
        string IMyPcqqApi.Api_UploadPic(string ��Ӧ��QQ, int ��_�ϴ�����, string ��_�ο�����, byte[] ��_ͼƬ����)
            => NativeMethods.Api_UploadPic(��Ӧ��QQ, ��_�ϴ�����, ��_�ο�����, ��_ͼƬ����);

        /// <summary>
        /// ����ͼƬGUIDȡ��ͼƬ�������� ʧ�ܷ��ؿ�`
        /// </summary>
        /// <param name="ͼƬGUID">{xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx}.jpg������GUID</param>
        /// <returns></returns>
        string IMyPcqqApi.Api_GuidGetPicLink(string ͼƬGUID)
            => NativeMethods.Api_GuidGetPicLink(ͼƬGUID);

        /// <summary>
        /// �ظ���Ϣ �뾡������ʹ�ø�API`
        /// </summary>
        /// <param name="��Ӧ��QQ"></param>
        /// <param name="��Ϣ����">1���� 2Ⱥ 3������ 4Ⱥ��ʱ�Ự 5��������ʱ�Ự</param>
        /// <param name="�ظ�����">����������Ϣ�Ķ���</param>
        /// <param name="����">��Ϣ����</param>
        /// <returns></returns>
        int IMyPcqqApi.Api_Reply(string ��Ӧ��QQ, int ��Ϣ����, string �ظ�����, string ����)
            => NativeMethods.Api_Reply(��Ӧ��QQ, ��Ϣ����, �ظ�����, ����);

        /// <summary>
        /// �����Ŀ�귢����Ϣ ֧�ֺ��� Ⱥ ������ Ⱥ��ʱ�Ự ��������ʱ�Ự`
        /// </summary>
        /// <param name="��Ӧ��QQ"></param>
        /// <param name="��Ϣ����">1���� 2Ⱥ 3������ 4Ⱥ��ʱ�Ự 5��������ʱ�Ự</param>
        /// <param name="�ο�������">������˵����������ջ�����</param>
        /// <param name="����Ⱥ_������">����Ⱥ��Ϣ����������Ϣ��Ⱥ��ʱ�Ự��Ϣ����������ʱ�Ự��Ϣʱ��д</param>
        /// <param name="���Ŷ���">���ս���������Ϣ�Ķ���QQ</param>
        /// <param name="����">��Ϣ����</param>
        /// <returns></returns>
        int IMyPcqqApi.Api_SendMsg(string ��Ӧ��QQ, int ��Ϣ����, int �ο�������, string ����Ⱥ_������, string ���Ŷ���, string ����)
            => NativeMethods.Api_SendMsg(��Ӧ��QQ, ��Ϣ����, �ο�������, ����Ⱥ_������, ���Ŷ���, ����);

        /// <summary>
        /// ���ͷ��`
        /// </summary>
        /// <param name="�������"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_Send(string �������)
            => NativeMethods.Api_Send(�������);

        /// <summary>
        /// �ڿ�ܼ�¼ҳ���һ����Ϣ`
        /// </summary>
        /// <param name="����">���������</param>
        /// <returns></returns>
        int IMyPcqqApi.Api_OutPut(string ����)
            => NativeMethods.Api_OutPut(����);

        /// <summary>
        /// ȡ�ñ��������״̬`
        /// </summary>
        /// <returns></returns>
        bool IMyPcqqApi.Api_IsEnable()
            => NativeMethods.Api_IsEnable();

        /// <summary>
        /// ��¼һ���ִ��QQ`
        /// </summary>
        /// <param name="QQ">����¼��Q</param>
        /// <returns></returns>
        bool IMyPcqqApi.Api_Login(string QQ)
            => NativeMethods.Api_Login(QQ);

        /// <summary>
        /// ��ָ��QQ����`
        /// </summary>
        /// <param name="QQ"></param>
        /// <returns></returns>
        void IMyPcqqApi.Api_Logout(string QQ)
            => NativeMethods.Api_Logout(QQ);

        /// <summary>
        /// tean�����㷨`
        /// </summary>
        /// <param name="��������"></param>
        /// <param name="Key"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_Tea����(string ��������, string Key)
            => NativeMethods.Api_Tea����(��������, Key);

        /// <summary>
        /// tean�����㷨`
        /// </summary>
        /// <param name="��������"></param>
        /// <param name="Key"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_Tea����(string ��������, string Key)
            => NativeMethods.Api_Tea����(��������, Key);

        /// <summary>
        /// ȡ�û���`
        /// </summary>
        /// <param name="QQ"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetNick(string QQ)
            => NativeMethods.Api_GetNick(QQ);

        /// <summary>
        /// ȡQQ�ȼ�+QQ��Ա�ȼ� ����json��ʽ��Ϣ`
        /// </summary>
        /// <param name="QQ"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetQQLevel(string QQ)
            => NativeMethods.Api_GetQQLevel(QQ);

        /// <summary>
        /// Ⱥ��תȺID`
        /// </summary>
        /// <param name="Ⱥ��"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_GNGetGid(string Ⱥ��)
            => NativeMethods.Api_GNGetGid(Ⱥ��);

        /// <summary>
        /// ȺIDתȺ��`
        /// </summary>
        /// <param name="ȺID"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_GidGetGN(string ȺID)
            => NativeMethods.Api_GidGetGN(ȺID);

        /// <summary>
        /// ȡ��ܰ汾��(����ʱ���`
        /// </summary>
        /// <returns></returns>
        int IMyPcqqApi.Api_GetVersion()
            => NativeMethods.Api_GetVersion();

        /// <summary>
        /// ȡ��ܰ汾��`
        /// </summary>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetVersionName()
            => NativeMethods.Api_GetVersionName();

        /// <summary>
        /// ȡ��ǰ����ڲ�ʱ���_�������������ʱ��ͬ��`
        /// </summary>
        /// <returns></returns>
        int IMyPcqqApi.Api_GetTimeStamp()
            => NativeMethods.Api_GetTimeStamp();

        /// <summary>
        /// ȡ�ÿ������б���������Ϣ`
        /// </summary>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetLog()
            => NativeMethods.Api_GetLog();

        /// <summary>
        /// �ж��Ƿ��ڱ�����Ⱥ��Ϣ״̬��`
        /// </summary>
        /// <param name="��Ӧ��QQ"></param>
        /// <returns></returns>
        bool IMyPcqqApi.Api_IfBlock(string ��Ӧ��QQ)
            => NativeMethods.Api_IfBlock(��Ӧ��QQ);

        /// <summary>
        /// ȡ����Ⱥ�����ڵ�Ⱥ���б�`
        /// </summary>
        /// <param name="��Ӧ��QQ"></param>
        /// <param name="Ⱥ��"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetAdminList(string ��Ӧ��QQ, string Ⱥ��)
            => NativeMethods.Api_GetAdminList(��Ӧ��QQ, Ⱥ��);

        /// <summary>
        /// ��˵˵`
        /// </summary>
        /// <param name="��Ӧ��QQ"></param>
        /// <param name="����"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_AddTaotao(string ��Ӧ��QQ, string ����)
            => NativeMethods.Api_AddTaotao(��Ӧ��QQ, ����);

        /// <summary>
        /// ȡ��ǩ`
        /// </summary>
        /// <param name="��Ӧ��QQ"></param>
        /// <param name="����"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetSign(string ��Ӧ��QQ, string ����)
            => NativeMethods.Api_GetSign(��Ӧ��QQ, ����);

        /// <summary>
        /// ���ø�ǩ`
        /// </summary>
        /// <param name="��Ӧ��QQ"></param>
        /// <param name="����"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_SetSign(string ��Ӧ��QQ, string ����)
            => NativeMethods.Api_SetSign(��Ӧ��QQ, ����);

        /// <summary>
        /// ͨ��qun.qzone.qq.com�ӿ�ȡ��ȡȺ�б�.�ɹ�����ת����JSON��ʽ�ı���Ϣ`
        /// </summary>
        /// <param name="��Ӧ��QQ"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetGroupListA(string ��Ӧ��QQ)
            => NativeMethods.Api_GetGroupListA(��Ӧ��QQ);

        /// <summary>
        /// ͨ��qun.qq.com�ӿ�ȡ��ȡȺ�б�.�ɹ�����ת����JSON��ʽ�ı���Ϣ`
        /// </summary>
        /// <param name="��Ӧ��QQ"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetGroupListB(string ��Ӧ��QQ)
            => NativeMethods.Api_GetGroupListB(��Ӧ��QQ);

        /// <summary>
        /// ͨ��qun.qq.com�ӿ�ȡ��Ⱥ��Ա�б� �ɹ�����ת����JSON��ʽ�ı�`
        /// </summary>
        /// <param name="��Ӧ��QQ"></param>
        /// <param name="Ⱥ��"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetGroupMemberA(string ��Ӧ��QQ, string Ⱥ��)
            => NativeMethods.Api_GetGroupMemberA(��Ӧ��QQ, Ⱥ��);

        /// <summary>
        /// ͨ��qun.qzone.qq.com�ӿ�ȡ��Ⱥ��Ա�б� �ɹ�����ת����JSON��ʽ�ı�`
        /// </summary>
        /// <param name="��Ӧ��QQ"></param>
        /// <param name="Ⱥ��"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetGroupMemberB(string ��Ӧ��QQ, string Ⱥ��)
            => NativeMethods.Api_GetGroupMemberB(��Ӧ��QQ, Ⱥ��);

        /// <summary>
        /// ͨ��qun.qq.com�ӿ�ȡ�ú����б��ɹ�����ת����JSON�ı�`
        /// </summary>
        /// <param name="��Ӧ��QQ"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetFriendList(string ��Ӧ��QQ)
            => NativeMethods.Api_GetFriendList(��Ӧ��QQ);

        /// <summary>
        /// ȡQ�� �ɹ�����Q�� ʧ�ܷ���-1`
        /// </summary>
        /// <param name="��Ӧ��QQ"></param>
        /// <param name="QQ"></param>
        /// <returns></returns>
        int IMyPcqqApi.Api_GetQQAge(string ��Ӧ��QQ, string QQ)
            => NativeMethods.Api_GetQQAge(��Ӧ��QQ, QQ);

        /// <summary>
        /// ȡ���� �ɹ��������� ʧ�ܷ���-1`
        /// </summary>
        /// <param name="��Ӧ��QQ"></param>
        /// <param name="QQ"></param>
        /// <returns></returns>
        int IMyPcqqApi.Api_GetAge(string ��Ӧ��QQ, string QQ)
            => NativeMethods.Api_GetAge(��Ӧ��QQ, QQ);

        /// <summary>
        /// ȡ����˵��`
        /// </summary>
        /// <param name="��Ӧ��QQ"></param>
        /// <param name="QQ">����QQ</param>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetPersonalProfile(string ��Ӧ��QQ, string QQ)
            => NativeMethods.Api_GetPersonalProfile(��Ӧ��QQ, QQ);

        /// <summary>
        /// ȡ���� �ɹ��������� ʧ�ܷ��ؿ�`
        /// </summary>
        /// <param name="��Ӧ��QQ"></param>
        /// <param name="QQ"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetEmail(string ��Ӧ��QQ, string QQ)
            => NativeMethods.Api_GetEmail(��Ӧ��QQ, QQ);

        /// <summary>
        /// ȡ�����Ա� 1�� 2Ů  δ��ʧ�ܷ���-1`
        /// </summary>
        /// <param name="��Ӧ��QQ"></param>
        /// <param name="QQ"></param>
        /// <returns></returns>
        int IMyPcqqApi.Api_GetGender(string ��Ӧ��QQ, string QQ)
            => NativeMethods.Api_GetGender(��Ӧ��QQ, QQ);

        /// <summary>
        /// ����ѷ��͡��������롯��״̬��Ϣ.�������յ���Ϣ֮�� ���������롱״̬�����̱����`
        /// </summary>
        /// <param name="��Ӧ��QQ"></param>
        /// <param name="QQ"></param>
        /// <returns></returns>
        int IMyPcqqApi.Api_SendTyping(string ��Ӧ��QQ, string QQ)
            => NativeMethods.Api_SendTyping(��Ӧ��QQ, QQ);

        /// <summary>
        /// ����ѷ��ʹ��ڶ�����Ϣ`
        /// </summary>
        /// <param name="��Ӧ��QQ"></param>
        /// <param name="QQ"></param>
        /// <returns></returns>
        int IMyPcqqApi.Api_SendShake(string ��Ӧ��QQ, string QQ)
            => NativeMethods.Api_SendShake(��Ӧ��QQ, QQ);

        /// <summary>
        /// ȡ�ÿ�������һ�������ҿ���ʹ�õ�QQ`
        /// </summary>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetRadomOnlineQQ()
            => NativeMethods.Api_GetRadomOnlineQQ();

        /// <summary>
        /// ���ʺ��б����һ��Q.����Q�Ѵ���ʱ�򸲸�����`
        /// </summary>
        /// <param name="QQ"></param>
        /// <param name="����"></param>
        /// <param name="�Զ���¼">���п��ʱ�Ƿ��Զ���¼��Q.����Ӻ���Ҫ��¼��Q����Ҫͨ��Api_Login����</param>
        /// <returns></returns>
        bool IMyPcqqApi.Api_AddQQ(string QQ, string ����, bool �Զ���¼)
            => NativeMethods.Api_AddQQ(QQ, ����, �Զ���¼);

        /// <summary>
        /// ��������״̬+������Ϣ `
        /// </summary>
        /// <param name="��Ӧ��QQ"></param>
        /// <param name="����״̬">1~6 �ֱ��Ӧ��������, Q�Ұ�, �뿪, æµ, �������, ����</param>
        /// <param name="״̬������Ϣ">���255�ֽ�</param>
        /// <returns></returns>
        bool IMyPcqqApi.Api_SetOLStatus(string ��Ӧ��QQ, int ����״̬, string ״̬������Ϣ)
            => NativeMethods.Api_SetOLStatus(��Ӧ��QQ, ����״̬, ״̬������Ϣ);

        /// <summary>
        /// ȡ�û�����`
        /// </summary>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetMC()
            => NativeMethods.Api_GetMC();

        /// <summary>
        /// ����������Ⱥ ʧ�ܷ��ش�������`
        /// </summary>
        /// <param name="��Ӧ��QQ"></param>
        /// <param name="����QQ">��������û��зָ�</param>
        /// <param name="Ⱥ��"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_GroupInvitation(string ��Ӧ��QQ, string ����QQ, string Ⱥ��)
            => NativeMethods.Api_GroupInvitation(��Ӧ��QQ, ����QQ, Ⱥ��);

        /// <summary>
        /// ����һ�������� �ɹ�����������ID ʧ�ܷ��ؿ� ע:ÿ24Сʱֻ�ܴ���100�������� ���ŵ���`
        /// </summary>
        /// <param name="��Ӧ��QQ"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_CreateDG(string ��Ӧ��QQ)
            => NativeMethods.Api_CreateDG(��Ӧ��QQ);

        /// <summary>
        /// �������Ƴ�������.�ɹ����ؿ� ʧ�ܷ�������`
        /// </summary>
        /// <param name="��Ӧ��QQ"></param>
        /// <param name="������ID"></param>
        /// <param name="��Ա"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_KickDG(string ��Ӧ��QQ, string ������ID, string ��Ա)
            => NativeMethods.Api_KickDG(��Ӧ��QQ, ������ID, ��Ա);

        /// <summary>
        /// ���������������� �ɹ����ؿ� ʧ�ܷ�������`
        /// </summary>
        /// <param name="��Ӧ��QQ"></param>
        /// <param name="������ID"></param>
        /// <param name="��Ա��">�����Ա�û��з��ָ�</param>
        /// <returns></returns>
        string IMyPcqqApi.Api_DGInvitation(string ��Ӧ��QQ, string ������ID, string ��Ա��)
            => NativeMethods.Api_DGInvitation(��Ӧ��QQ, ������ID, ��Ա��);

        /// <summary>
        /// �ɹ������Ի��з��ָ����������б�.���Ϊ100��������  ʧ�ܷ��ؿ�`
        /// </summary>
        /// <param name="��Ӧ��QQ"></param>
        /// <returns></returns>
        string IMyPcqqApi.Api_GetDGList(string ��Ӧ��QQ)
            => NativeMethods.Api_GetDGList(��Ӧ��QQ);

        /// <summary>
        /// �������һ��������Ϣ����ν�ĵ�裩��������`
        /// </summary>
        /// <param name="��Ӧ��QQ"></param>
        /// <param name="���Ŷ�������">ͬApi_SendMsg  1���� 2Ⱥ 3������ 4Ⱥ��ʱ�Ự 5��������ʱ�Ự</param>
        /// <param name="���Ŷ�������Ⱥ_������">��Ⱥ�ڡ���ʱ�Ự���� ���ѿɲ���</param>
        /// <param name="���Ŷ���QQ">��ʱ�Ự�����ѱ��� ����Ⱥ�ڿɲ���</param>
        /// <param name="���ּ��">����Ĭ�ϡ�QQ���� �ķ���</param>
        /// <param name="���ֲ���ҳ������">����ֱ��������Ӿ��� ����Ϊ�� �޷��㿪</param>
        /// <param name="���ַ�������">����ֱ��������Ӿ��� �ɿ� ��:http://url.cn/cDiJT4</param>
        /// <param name="�����ļ�ֱ������">����ֱ��������Ӿ��� ���ɿ� ��:http://url.cn/djwXjr</param>
        /// <param name="����">�ɿ�</param>
        /// <param name="������">�ɿ�</param>
        /// <param name="������Դ��">�ɿ� Ϊ��Ĭ��QQ����</param>
        /// <param name="������Դͼ������">�ɿ� Ϊ��Ĭ��QQ���� http://qzonestyle.gtimg.cn/ac/qzone/applogo/64/308/100497308_64.gif</param>
        /// <returns></returns>
        bool IMyPcqqApi.Api_SendMusic(string ��Ӧ��QQ, int ���Ŷ�������, string ���Ŷ�������Ⱥ_������, string ���Ŷ���QQ, string ���ּ��,
            string ���ֲ���ҳ������, string ���ַ�������, string �����ļ�ֱ������, string ����, string ������, string ������Դ��, string ������Դͼ������)
            => NativeMethods.Api_SendMusic(��Ӧ��QQ, ���Ŷ�������, ���Ŷ�������Ⱥ_������, ���Ŷ���QQ, ���ּ��, ���ֲ���ҳ������, ���ַ�������, �����ļ�ֱ������, ����,
                ������, ������Դ��, ������Դͼ������);

        /// <summary>
        /// `
        /// </summary>
        /// <param name="��Ӧ��QQ"></param>
        /// <param name="���Ŷ�������">ͬApi_SendMsg  1���� 2Ⱥ 3������ 4Ⱥ��ʱ�Ự 5��������ʱ�Ự</param>
        /// <param name="���Ŷ�������Ⱥ_������">��Ⱥ�ڡ���ʱ�Ự���� ���ѿɲ���</param>
        /// <param name="���Ŷ���QQ">��ʱ�Ự�����ѱ��� ����Ⱥ�ڿɲ���</param>
        /// <param name="ObjectMsg"></param>
        /// <param name="�ṹ������">00 ���� 02 ��� ��������</param>
        /// <returns></returns>
        bool IMyPcqqApi.Api_SendObjectMsg(string ��Ӧ��QQ, int ���Ŷ�������, string ���Ŷ�������Ⱥ_������, string ���Ŷ���QQ, string ObjectMsg,
            int �ṹ������)
            => NativeMethods.Api_SendObjectMsg(��Ӧ��QQ, ���Ŷ�������, ���Ŷ�������Ⱥ_������, ���Ŷ���QQ, ObjectMsg, �ṹ������);

        /// <summary>
        /// �ж϶����Ƿ�Ϊ���ѣ�˫��`
        /// </summary>
        /// <param name="��Ӧ��QQ"></param>
        /// <param name="����QQ"></param>
        /// <returns></returns>
        bool IMyPcqqApi.Api_IsFriend(string ��Ӧ��QQ, string ����QQ)
            => NativeMethods.Api_IsFriend(��Ӧ��QQ, ����QQ);

        private static class NativeMethods
        {
            /// <summary>
            /// �����ύ��QQ�ż���õ�ҳ������ò���Bkn��G_tk`
            /// </summary>
            /// <param name="��Ӧ��QQ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetGtk_Bkn(string ��Ӧ��QQ);

            /// <summary>
            /// �����ύ��QQ�ż���õ�ҳ������ò�����Bkn��G_tk`
            /// </summary>
            /// <param name="��Ӧ��QQ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetBkn32(string ��Ӧ��QQ);

            /// <summary>
            /// �����ύ��QQ�ż���õ�ҳ������ò�����Ldw`
            /// </summary>
            /// <param name="��Ӧ��QQ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetLdw(string ��Ӧ��QQ);

            /// <summary>
            /// ȡ�ÿ������Ŀ¼.���ܼ����ˡ�`
            /// </summary>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetRunPath();

            /// <summary>
            /// ȡ�õ�ǰ��������߿��õ�QQ�б�`
            /// </summary>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetOnlineQQlist();

            /// <summary>
            /// ȡ�ÿ��������QQ�б�����δ��¼�Լ���¼ʧ�ܵ�QQ`
            /// </summary>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetQQlist();

            /// <summary>
            /// ����QQȡ�ö�Ӧ�ĻỰ��Կ`
            /// </summary>
            /// <param name="��Ӧ��QQ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetSessionkey(string ��Ӧ��QQ);

            /// <summary>
            /// ȡ��ҳ���¼�õ�Clientkey`
            /// </summary>
            /// <param name="��Ӧ��QQ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetClientkey(string ��Ӧ��QQ);

            /// <summary>
            /// ȡ��ҳ���¼�õĳ�Clientkey`
            /// </summary>
            /// <param name="��Ӧ��QQ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetLongClientkey(string ��Ӧ��QQ);

            /// <summary>
            /// ȡ��ҳ������õ�Cookies`
            /// </summary>
            /// <param name="��Ӧ��QQ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetCookies(string ��Ӧ��QQ);

            /// <summary>
            /// ȡ�ÿ�������õ���Ϣ����ǰ׺`
            /// </summary>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetPrefix();

            /// <summary>
            /// ��Ⱥ��Ƭ������ٻ��浱��.`
            /// </summary>
            /// <param name="Ⱥ��"></param>
            /// <param name="QQ"></param>
            /// <param name="��Ƭ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern void Api_Cache_NameCard(string Ⱥ��, string QQ, string ��Ƭ);

            /// <summary>
            /// ��ָ��QQ�Ƴ�QQ������`
            /// </summary>
            /// <param name="��Ӧ��QQ"></param>
            /// <param name="QQ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern void Api_DBan(string ��Ӧ��QQ, string QQ);

            /// <summary>
            /// ��ָ��QQ����QQ������`
            /// </summary>
            /// <param name="��Ӧ��QQ"></param>
            /// <param name="QQ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern void Api_Ban(string ��Ӧ��QQ, string QQ);

            /// <summary>
            /// ����Ⱥ��Ա`
            /// </summary>
            /// <param name="��Ӧ��QQ"></param>
            /// <param name="Ⱥ��">���Զ�������Ⱥ.</param>
            /// <param name="QQ">���Զ���.����ΪȫȺ����</param>
            /// <param name="ʱ��">��λ:�� ���Ϊ1����. Ϊ���������ȫȺ����</param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern bool Api_Shutup(string ��Ӧ��QQ, string Ⱥ��, string QQ, int ʱ��);

            /// <summary>
            /// ��Ⱥ����`
            /// </summary>
            /// <param name="��Ӧ��QQ"></param>
            /// <param name="Ⱥ��"></param>
            /// <param name="����"></param>
            /// <param name="����"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern void Api_SetNotice(string ��Ӧ��QQ, string Ⱥ��, string ����, string ����);

            /// <summary>
            /// ȡȺ����`
            /// </summary>
            /// <param name="��Ӧ��QQ"></param>
            /// <param name="Ⱥ��"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetNotice(string ��Ӧ��QQ, string Ⱥ��);

            /// <summary>
            /// ȡȺ��Ƭ`
            /// </summary>
            /// <param name="��Ӧ��QQ"></param>
            /// <param name="Ⱥ��"></param>
            /// <param name="QQ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetNameCard(string ��Ӧ��QQ, string Ⱥ��, string QQ);

            /// <summary>
            /// ����Ⱥ��Ƭ`
            /// </summary>
            /// <param name="��Ӧ��QQ"></param>
            /// <param name="Ⱥ��"></param>
            /// <param name="QQ"></param>
            /// <param name="��Ƭ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern void Api_SetNameCard(string ��Ӧ��QQ, string Ⱥ��, string QQ, string ��Ƭ);

            /// <summary>
            /// �˳�������`
            /// </summary>
            /// <param name="��Ӧ��QQ"></param>
            /// <param name="������ID"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern void Api_QuitDG(string ��Ӧ��QQ, string ������ID);

            /// <summary>
            /// ɾ������`
            /// </summary>
            /// <param name="��Ӧ��QQ"></param>
            /// <param name="QQ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern bool Api_DelFriend(string ��Ӧ��QQ, string QQ);

            /// <summary>
            /// �������Ƴ�Ⱥ`
            /// </summary>
            /// <param name="��Ӧ��QQ"></param>
            /// <param name="Ⱥ��"></param>
            /// <param name="����"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern bool Api_Kick(string ��Ӧ��QQ, string Ⱥ��, string ����);

            /// <summary>
            /// ������Ⱥ.Ϊ�˱����桢Ⱥ����Ϊ��������֤��ʱ����ֱ��ʧ�ܲ�����`
            /// </summary>
            /// <param name="��Ӧ��QQ"></param>
            /// <param name="Ⱥ��"></param>
            /// <param name="��������"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern void Api_JoinGroup(string ��Ӧ��QQ, string Ⱥ��, string ��������);

            /// <summary>
            /// �˳�Ⱥ`
            /// </summary>
            /// <param name="��Ӧ��QQ"></param>
            /// <param name="Ⱥ��"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern void Api_QuitGroup(string ��Ӧ��QQ, string Ⱥ��);

            /// <summary>
            /// ����ֵ:�ɹ�����ͼƬGUID���ڷ��͸�ͼƬ.ʧ�ܷ��ؿ�.  ͼƬ�ߴ�ӦС��4MB`
            /// </summary>
            /// <param name="��Ӧ��QQ">������QQ</param>
            /// <param name="��_�ϴ�����">1����2Ⱥ ע:����ͼ��Ⱥͼ��GUID������ͬ����ͨ�� ��Ҫ�Ǳ��ϴ���Ⱥ��������������2 ��ʱ�Ự��������Ϣ��Ҫ����1</param>
            /// <param name="��_�ο�����">�ϴ���ͼƬ������Ⱥ�Ż�QQ</param>
            /// <param name="��_ͼƬ����">ַ, ͼƬ�ֽڼ����ݻ��ֽڼ�����ָ��()</param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_UploadPic(string ��Ӧ��QQ, int ��_�ϴ�����, string ��_�ο�����, byte[] ��_ͼƬ����);

            /// <summary>
            /// ����ͼƬGUIDȡ��ͼƬ�������� ʧ�ܷ��ؿ�`
            /// </summary>
            /// <param name="ͼƬGUID">{xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx}.jpg������GUID</param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GuidGetPicLink(string ͼƬGUID);

            /// <summary>
            /// �ظ���Ϣ �뾡������ʹ�ø�API`
            /// </summary>
            /// <param name="��Ӧ��QQ"></param>
            /// <param name="��Ϣ����">1���� 2Ⱥ 3������ 4Ⱥ��ʱ�Ự 5��������ʱ�Ự</param>
            /// <param name="�ظ�����">����������Ϣ�Ķ���</param>
            /// <param name="����">��Ϣ����</param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern int Api_Reply(string ��Ӧ��QQ, int ��Ϣ����, string �ظ�����, string ����);

            /// <summary>
            /// �����Ŀ�귢����Ϣ ֧�ֺ��� Ⱥ ������ Ⱥ��ʱ�Ự ��������ʱ�Ự`
            /// </summary>
            /// <param name="��Ӧ��QQ"></param>
            /// <param name="��Ϣ����">1���� 2Ⱥ 3������ 4Ⱥ��ʱ�Ự 5��������ʱ�Ự</param>
            /// <param name="�ο�������">������˵����������ջ�����</param>
            /// <param name="����Ⱥ_������">����Ⱥ��Ϣ����������Ϣ��Ⱥ��ʱ�Ự��Ϣ����������ʱ�Ự��Ϣʱ��д</param>
            /// <param name="���Ŷ���">���ս���������Ϣ�Ķ���QQ</param>
            /// <param name="����">��Ϣ����</param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern int Api_SendMsg(string ��Ӧ��QQ, int ��Ϣ����, int �ο�������, string ����Ⱥ_������, string ���Ŷ���,
                string ����);

            /// <summary>
            /// ���ͷ��`
            /// </summary>
            /// <param name="�������"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_Send(string �������);

            /// <summary>
            /// �ڿ�ܼ�¼ҳ���һ����Ϣ`
            /// </summary>
            /// <param name="����">���������</param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern int Api_OutPut(string ����);

            /// <summary>
            /// ȡ�ñ��������״̬`
            /// </summary>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern bool Api_IsEnable();

            /// <summary>
            /// ��¼һ���ִ��QQ`
            /// </summary>
            /// <param name="QQ">����¼��Q</param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern bool Api_Login(string QQ);

            /// <summary>
            /// ��ָ��QQ����`
            /// </summary>
            /// <param name="QQ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern void Api_Logout(string QQ);

            /// <summary>
            /// tean�����㷨`
            /// </summary>
            /// <param name="��������"></param>
            /// <param name="Key"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_Tea����(string ��������, string Key);

            /// <summary>
            /// tean�����㷨`
            /// </summary>
            /// <param name="��������"></param>
            /// <param name="Key"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_Tea����(string ��������, string Key);

            /// <summary>
            /// ȡ�û���`
            /// </summary>
            /// <param name="QQ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetNick(string QQ);

            /// <summary>
            /// ȡQQ�ȼ�+QQ��Ա�ȼ� ����json��ʽ��Ϣ`
            /// </summary>
            /// <param name="QQ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetQQLevel(string QQ);

            /// <summary>
            /// Ⱥ��תȺID`
            /// </summary>
            /// <param name="Ⱥ��"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GNGetGid(string Ⱥ��);

            /// <summary>
            /// ȺIDתȺ��`
            /// </summary>
            /// <param name="ȺID"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GidGetGN(string ȺID);

            /// <summary>
            /// ȡ��ܰ汾��(����ʱ���`
            /// </summary>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern int Api_GetVersion();

            /// <summary>
            /// ȡ��ܰ汾��`
            /// </summary>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetVersionName();

            /// <summary>
            /// ȡ��ǰ����ڲ�ʱ���_�������������ʱ��ͬ��`
            /// </summary>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern int Api_GetTimeStamp();

            /// <summary>
            /// ȡ�ÿ������б���������Ϣ`
            /// </summary>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetLog();

            /// <summary>
            /// �ж��Ƿ��ڱ�����Ⱥ��Ϣ״̬��`
            /// </summary>
            /// <param name="��Ӧ��QQ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern bool Api_IfBlock(string ��Ӧ��QQ);

            /// <summary>
            /// ȡ����Ⱥ�����ڵ�Ⱥ���б�`
            /// </summary>
            /// <param name="��Ӧ��QQ"></param>
            /// <param name="Ⱥ��"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetAdminList(string ��Ӧ��QQ, string Ⱥ��);

            /// <summary>
            /// ��˵˵`
            /// </summary>
            /// <param name="��Ӧ��QQ"></param>
            /// <param name="����"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_AddTaotao(string ��Ӧ��QQ, string ����);

            /// <summary>
            /// ȡ��ǩ`
            /// </summary>
            /// <param name="��Ӧ��QQ"></param>
            /// <param name="����"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetSign(string ��Ӧ��QQ, string ����);

            /// <summary>
            /// ���ø�ǩ`
            /// </summary>
            /// <param name="��Ӧ��QQ"></param>
            /// <param name="����"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_SetSign(string ��Ӧ��QQ, string ����);

            /// <summary>
            /// ͨ��qun.qzone.qq.com�ӿ�ȡ��ȡȺ�б�.�ɹ�����ת����JSON��ʽ�ı���Ϣ`
            /// </summary>
            /// <param name="��Ӧ��QQ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetGroupListA(string ��Ӧ��QQ);

            /// <summary>
            /// ͨ��qun.qq.com�ӿ�ȡ��ȡȺ�б�.�ɹ�����ת����JSON��ʽ�ı���Ϣ`
            /// </summary>
            /// <param name="��Ӧ��QQ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetGroupListB(string ��Ӧ��QQ);

            /// <summary>
            /// ͨ��qun.qq.com�ӿ�ȡ��Ⱥ��Ա�б� �ɹ�����ת����JSON��ʽ�ı�`
            /// </summary>
            /// <param name="��Ӧ��QQ"></param>
            /// <param name="Ⱥ��"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetGroupMemberA(string ��Ӧ��QQ, string Ⱥ��);

            /// <summary>
            /// ͨ��qun.qzone.qq.com�ӿ�ȡ��Ⱥ��Ա�б� �ɹ�����ת����JSON��ʽ�ı�`
            /// </summary>
            /// <param name="��Ӧ��QQ"></param>
            /// <param name="Ⱥ��"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetGroupMemberB(string ��Ӧ��QQ, string Ⱥ��);

            /// <summary>
            /// ͨ��qun.qq.com�ӿ�ȡ�ú����б��ɹ�����ת����JSON�ı�`
            /// </summary>
            /// <param name="��Ӧ��QQ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetFriendList(string ��Ӧ��QQ);

            /// <summary>
            /// ȡQ�� �ɹ�����Q�� ʧ�ܷ���-1`
            /// </summary>
            /// <param name="��Ӧ��QQ"></param>
            /// <param name="QQ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern int Api_GetQQAge(string ��Ӧ��QQ, string QQ);

            /// <summary>
            /// ȡ���� �ɹ��������� ʧ�ܷ���-1`
            /// </summary>
            /// <param name="��Ӧ��QQ"></param>
            /// <param name="QQ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern int Api_GetAge(string ��Ӧ��QQ, string QQ);

            /// <summary>
            /// ȡ����˵��`
            /// </summary>
            /// <param name="��Ӧ��QQ"></param>
            /// <param name="QQ">����QQ</param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetPersonalProfile(string ��Ӧ��QQ, string QQ);

            /// <summary>
            /// ȡ���� �ɹ��������� ʧ�ܷ��ؿ�`
            /// </summary>
            /// <param name="��Ӧ��QQ"></param>
            /// <param name="QQ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetEmail(string ��Ӧ��QQ, string QQ);

            /// <summary>
            /// ȡ�����Ա� 1�� 2Ů  δ��ʧ�ܷ���-1`
            /// </summary>
            /// <param name="��Ӧ��QQ"></param>
            /// <param name="QQ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern int Api_GetGender(string ��Ӧ��QQ, string QQ);

            /// <summary>
            /// ����ѷ��͡��������롯��״̬��Ϣ.�������յ���Ϣ֮�� ���������롱״̬�����̱����`
            /// </summary>
            /// <param name="��Ӧ��QQ"></param>
            /// <param name="QQ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern int Api_SendTyping(string ��Ӧ��QQ, string QQ);

            /// <summary>
            /// ����ѷ��ʹ��ڶ�����Ϣ`
            /// </summary>
            /// <param name="��Ӧ��QQ"></param>
            /// <param name="QQ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern int Api_SendShake(string ��Ӧ��QQ, string QQ);

            /// <summary>
            /// ȡ�ÿ�������һ�������ҿ���ʹ�õ�QQ`
            /// </summary>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetRadomOnlineQQ();

            /// <summary>
            /// ���ʺ��б����һ��Q.����Q�Ѵ���ʱ�򸲸�����`
            /// </summary>
            /// <param name="QQ"></param>
            /// <param name="����"></param>
            /// <param name="�Զ���¼">���п��ʱ�Ƿ��Զ���¼��Q.����Ӻ���Ҫ��¼��Q����Ҫͨ��Api_Login����</param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern bool Api_AddQQ(string QQ, string ����, bool �Զ���¼);

            /// <summary>
            /// ��������״̬+������Ϣ `
            /// </summary>
            /// <param name="��Ӧ��QQ"></param>
            /// <param name="����״̬">1~6 �ֱ��Ӧ��������, Q�Ұ�, �뿪, æµ, �������, ����</param>
            /// <param name="״̬������Ϣ">���255�ֽ�</param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern bool Api_SetOLStatus(string ��Ӧ��QQ, int ����״̬, string ״̬������Ϣ);

            /// <summary>
            /// ȡ�û�����`
            /// </summary>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetMC();

            /// <summary>
            /// ����������Ⱥ ʧ�ܷ��ش�������`
            /// </summary>
            /// <param name="��Ӧ��QQ"></param>
            /// <param name="����QQ">��������û��зָ�</param>
            /// <param name="Ⱥ��"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GroupInvitation(string ��Ӧ��QQ, string ����QQ, string Ⱥ��);

            /// <summary>
            /// ����һ�������� �ɹ�����������ID ʧ�ܷ��ؿ� ע:ÿ24Сʱֻ�ܴ���100�������� ���ŵ���`
            /// </summary>
            /// <param name="��Ӧ��QQ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_CreateDG(string ��Ӧ��QQ);

            /// <summary>
            /// �������Ƴ�������.�ɹ����ؿ� ʧ�ܷ�������`
            /// </summary>
            /// <param name="��Ӧ��QQ"></param>
            /// <param name="������ID"></param>
            /// <param name="��Ա"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_KickDG(string ��Ӧ��QQ, string ������ID, string ��Ա);

            /// <summary>
            /// ���������������� �ɹ����ؿ� ʧ�ܷ�������`
            /// </summary>
            /// <param name="��Ӧ��QQ"></param>
            /// <param name="������ID"></param>
            /// <param name="��Ա��">�����Ա�û��з��ָ�</param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_DGInvitation(string ��Ӧ��QQ, string ������ID, string ��Ա��);

            /// <summary>
            /// �ɹ������Ի��з��ָ����������б�.���Ϊ100��������  ʧ�ܷ��ؿ�`
            /// </summary>
            /// <param name="��Ӧ��QQ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern string Api_GetDGList(string ��Ӧ��QQ);

            /// <summary>
            /// �������һ��������Ϣ����ν�ĵ�裩��������`
            /// </summary>
            /// <param name="��Ӧ��QQ"></param>
            /// <param name="���Ŷ�������">ͬApi_SendMsg  1���� 2Ⱥ 3������ 4Ⱥ��ʱ�Ự 5��������ʱ�Ự</param>
            /// <param name="���Ŷ�������Ⱥ_������">��Ⱥ�ڡ���ʱ�Ự���� ���ѿɲ���</param>
            /// <param name="���Ŷ���QQ">��ʱ�Ự�����ѱ��� ����Ⱥ�ڿɲ���</param>
            /// <param name="���ּ��">����Ĭ�ϡ�QQ���� �ķ���</param>
            /// <param name="���ֲ���ҳ������">����ֱ��������Ӿ��� ����Ϊ�� �޷��㿪</param>
            /// <param name="���ַ�������">����ֱ��������Ӿ��� �ɿ� ��:http://url.cn/cDiJT4</param>
            /// <param name="�����ļ�ֱ������">����ֱ��������Ӿ��� ���ɿ� ��:http://url.cn/djwXjr</param>
            /// <param name="����">�ɿ�</param>
            /// <param name="������">�ɿ�</param>
            /// <param name="������Դ��">�ɿ� Ϊ��Ĭ��QQ����</param>
            /// <param name="������Դͼ������">�ɿ� Ϊ��Ĭ��QQ���� http://qzonestyle.gtimg.cn/ac/qzone/applogo/64/308/100497308_64.gif</param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern bool Api_SendMusic(string ��Ӧ��QQ, int ���Ŷ�������, string ���Ŷ�������Ⱥ_������, string ���Ŷ���QQ,
                string ���ּ��, string ���ֲ���ҳ������, string ���ַ�������, string �����ļ�ֱ������, string ����, string ������, string ������Դ��,
                string ������Դͼ������);

            /// <summary>
            /// `
            /// </summary>
            /// <param name="��Ӧ��QQ"></param>
            /// <param name="���Ŷ�������">ͬApi_SendMsg  1���� 2Ⱥ 3������ 4Ⱥ��ʱ�Ự 5��������ʱ�Ự</param>
            /// <param name="���Ŷ�������Ⱥ_������">��Ⱥ�ڡ���ʱ�Ự���� ���ѿɲ���</param>
            /// <param name="���Ŷ���QQ">��ʱ�Ự�����ѱ��� ����Ⱥ�ڿɲ���</param>
            /// <param name="ObjectMsg"></param>
            /// <param name="�ṹ������">00 ���� 02 ��� ��������</param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern bool Api_SendObjectMsg(string ��Ӧ��QQ, int ���Ŷ�������, string ���Ŷ�������Ⱥ_������, string ���Ŷ���QQ,
                string ObjectMsg, int �ṹ������);

            /// <summary>
            /// �ж϶����Ƿ�Ϊ���ѣ�˫��`
            /// </summary>
            /// <param name="��Ӧ��QQ"></param>
            /// <param name="����QQ"></param>
            /// <returns></returns>
            [DllImport("Message.dll")]
            public static extern bool Api_IsFriend(string ��Ӧ��QQ, string ����QQ);
        }
    }
}