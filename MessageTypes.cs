namespace UnitedStateRP.Networking.Data
{
    // الرسائل اللي يرسلها السيرفر للاعبين
    public enum ServerPackets
    {
        Welcome = 1,       // رسالة الترحيب عند الاتصال
        SpawnPlayer,       // أمر إظهار لاعب جديد بالخريطة
        PlayerPosition,    // تحديث مكان اللاعب
        PlayerRotation,    // تحديث اتجاه اللاعب
        ChatMessage        // إرسال رسالة شات
    }

    // الرسائل اللي يرسلها اللاعب للسيرفر
    public enum ClientPackets
    {
        WelcomeReceived = 1, // تأكيد استلام الترحيب
        PlayerMovement,      // إرسال إحداثيات الحركة (X, Y, Z)
        SendChatMessage      // إرسال رسالة للشات
    }
}
