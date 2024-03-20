namespace Core;

public enum PacketType
{
    LoginRequest,
    LoginResponse,
    CreateRoomRequest,
    CreateRoomResponse,
    RoomListRequest,
    RoomListResponse,
    EnterRoomRequest,
    EnterRoomResponse,
    UserEnter,
    UserLeave,
    Chat,
    Duplicate,
    HeartBeat
}
