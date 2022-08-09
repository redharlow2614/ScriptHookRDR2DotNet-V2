﻿// This is a custom generated file. The program is not ready for release yet.

using Any = System.UInt64;
using ScrHandle = System.Int32;
using BOOL = System.Boolean;
using AnimScene = System.Int32;
using Blip = System.Int32;
using Cam = System.Int32;
using Entity = System.Int32;
using FireId = System.Int32;
using Hash = System.UInt32;
using Interior = System.Int32;
using ItemSet = System.Int32;
using Object = System.Int32;
using Ped = System.Int32;
using PersChar = System.Int32;
using Pickup = System.Int32;
using Player = System.UInt32;
using PopZone = System.Int32;
using Prompt = System.Int32;
using PropSet = System.Int32;
using Vehicle = System.Int32;
using Volume = System.Int32;

using RDR2.Math;

namespace RDR2.Native
{
	public static class BUILTIN
	{
		public static void WAIT(int ms) { Function.Call(0x4EDE34FBADD967A6, ms); }
		public static int TIMERA() { return Function.Call<int>(0x83666F9FB8FEBD4B); }
		public static int TIMERB() { return Function.Call<int>(0xC9D9444186B5A374); }
		public static void SETTIMERA(int value) { Function.Call(0xC1B1E9A034A63A62, value); }
		public static void SETTIMERB(int value) { Function.Call(0x5AE11BC36633DE4E, value); }
		public static float TIMESTEP() { return Function.Call<float>(0x0000000050597EE2); }
		public static float SIN(float value) { return Function.Call<float>(0x0BADBFA3B172435F, value); }
		public static float COS(float value) { return Function.Call<float>(0xD0FFB162F40A139C, value); }
		public static float SQRT(float value) { return Function.Call<float>(0x71D93B57D07F9804, value); }
		public static float POW(float _base, float exponent) { return Function.Call<float>(0xE3621CC40F31FE2E, _base, exponent); }
		public static float _LOG10(float value) { return Function.Call<float>(0xE816E655DE37FE20, value); }
		public static float VMAG(float x, float y, float z) { return Function.Call<float>(0x652D2EEEF1D3E62C, x, y, z); }
		public static float VMAG2(float x, float y, float z) { return Function.Call<float>(0xA8CEACB4F35AE058, x, y, z); }
		public static float VDIST(float x1, float y1, float z1, float x2, float y2, float z2) { return Function.Call<float>(0x2A488C176D52CCA5, x1, y1, z1, x2, y2, z2); }
		public static float VDIST2(float x1, float y1, float z1, float x2, float y2, float z2) { return Function.Call<float>(0xB7A628320EFF8E47, x1, y1, z1, x2, y2, z2); }
		public static int SHIFT_LEFT(int value, int bitShift) { return Function.Call<int>(0xEDD95A39E5544DE8, value, bitShift); }
		public static int SHIFT_RIGHT(int value, int bitShift) { return Function.Call<int>(0x97EF1E5BCE9DC075, value, bitShift); }
		public static int FLOOR(float value) { return Function.Call<int>(0xF34EE736CF047844, value); }
		public static int CEIL(float value) { return Function.Call<int>(0x11E019C8F43ACC8A, value); }
		public static int ROUND(float value) { return Function.Call<int>(0xF2DB717A73826179, value); }
		public static float TO_FLOAT(int value) { return Function.Call<float>(0xBBDA792448DB5A89, value); }
		public static void SET_THREAD_PRIORITY(int priority) { Function.Call(0x42B65DEEF2EDF2A1, priority); }
	}

	public static class AICOVERPOINT
	{
		public static int _0x53E4D0C079CA6855(ScrHandle handle) { return Function.Call<int>(0x53E4D0C079CA6855, handle); }
		public static BOOL _DOES_COVER_POINT_EXIST(ScrHandle handle) { return Function.Call<BOOL>(0xC276FE69DDA22BAD, handle); }
		public static int _0x5F5B1B7E8E8F94C6(int ped) { return Function.Call<int>(0x5F5B1B7E8E8F94C6, ped); }
		public static void TASK_ENTER_COVER(int ped) { Function.Call(0x4972A022AE6DAFA1, ped); }
		public static void TASK_EXIT_COVER(int ped) { Function.Call(0x2BC4A6D92D140112, ped); }
		public static int _0x957D7E750216D74B(int ped) { return Function.Call<int>(0x957D7E750216D74B, ped); }
		public static void _0x89783FDDF079C88D(Any p0) { Function.Call(0x89783FDDF079C88D, p0); }
		public static void _0x64340DC208D671D5(string coverLayer) { Function.Call(0x64340DC208D671D5, coverLayer); }
		public static void _0x7A1FDCF35EAA140F(string coverLayer) { Function.Call(0x7A1FDCF35EAA140F, coverLayer); }
		public static void _REQUEST_FLINCH_COVER_ANIM(int ped) { Function.Call(0x2A31D13C5F021D0D, ped); }
		public static void _0x3C7A9C2C953128FE(int ped) { Function.Call(0x3C7A9C2C953128FE, ped); }
		public static unsafe void _0xEBA51A294C73292E(Any* args) { Function.Call(0xEBA51A294C73292E, args); }
		public static void _0x140B3CB1D424A945(int ped, Hash weaponHash) { Function.Call(0x140B3CB1D424A945, ped, weaponHash); }
		public static BOOL _ARE_LOAD_COVER_ANIMS_LOADED(int ped) { return Function.Call<BOOL>(0x8CBE916CFC64AD5C, ped); }
		public static void _STOP_RUNNING_COVER_ANIMS(int ped) { Function.Call(0x1A7A802B2301EDC0, ped); }
		public static unsafe void _0x733077295AB51304(Any* args) { Function.Call(0x733077295AB51304, args); }
		public static unsafe ScrHandle _ADD_SCRIPTED_COVER_POINT(Any* data) { return Function.Call<ScrHandle>(0x975BD6351648935F, data); }
	}

	public static class AITRANSPORT
	{
		public static unsafe void TASK_ENTER_TRANSPORT(Any* args) { Function.Call(0xAEE3ADD08829CB6F, args); }
		public static unsafe void TASK_EXIT_TRANSPORT(Any* args) { Function.Call(0xC273A5B8488F7838, args); }
		public static void SET_PED_ON_TRANSPORT_SEAT(int ped, int transportEntity, int seat, int flags) { Function.Call(0xE588B5A8A005CB5E, ped, transportEntity, seat, flags); }
		public static void SET_PED_OFF_TRANSPORT_SEAT(int ped, int flags) { Function.Call(0x8886D83A430537FD, ped, flags); }
		public static void SET_TRANSPORT_CONFIG_FLAG(int transportEntity, int flagId, BOOL value) { Function.Call(0xBA8818212633500A, transportEntity, flagId, value); }
		public static BOOL GET_TRANSPORT_CONFIG_FLAG(int transportEntity, int flagId, BOOL p2) { return Function.Call<BOOL>(0xF382C92CCC1CCDBC, transportEntity, flagId, p2); }
		public static unsafe Any _GET_TRANSPORT_USAGE_FLAGS(int transportEntity, int* flags) { return Function.Call<Any>(0xE195C5A82156321D, transportEntity, flags); }
		public static void _SET_TRANSPORT_USAGE_FLAGS(int transportEntity, int flags) { Function.Call(0xE2487779957FE897, transportEntity, flags); }
		public static void SET_TRANSPORT_ACCESSIBLE_SEAT_FLAGS(int transportEntity, int flags) { Function.Call(0xDD0660C997DE94FD, transportEntity, flags); }
		public static void _0x4B6C9A43F7D9109B(Any p0, Any p1) { Function.Call(0x4B6C9A43F7D9109B, p0, p1); }
		public static BOOL _IS_PED_ON_TRANSPORT_ENTITY(int ped, int transportEntity) { return Function.Call<BOOL>(0x159EF5B6EDCE00E8, ped, transportEntity); }
		public static BOOL _IS_PED_ON_TRANSPORT_SEAT(int ped, BOOL p1) { return Function.Call<BOOL>(0xDC44F405A6B98D03, ped, p1); }
		public static BOOL _IS_TRANSPORT_SEAT_OCCUPIED(int transportEntity, int seatIndex) { return Function.Call<BOOL>(0x2E2E06023D07631E, transportEntity, seatIndex); }
		public static BOOL _IS_TRANSPORT_SEAT_FREE(int transportEntity, int seatIndex) { return Function.Call<BOOL>(0x43FF27FC1829C202, transportEntity, seatIndex); }
		public static int _GET_PED_IN_TRANSPORT_SEAT(int transportEntity, int seatIndex) { return Function.Call<int>(0xFFEC4B0A1A3ED515, transportEntity, seatIndex); }
		public static BOOL IS_PED_ENTERING_TRANSPORT(int ped, int transportEntity, BOOL p2) { return Function.Call<BOOL>(0x619E63980BFC0096, ped, transportEntity, p2); }
		public static BOOL IS_PED_EXITING_TRANSPORT(int ped, int transportEntity) { return Function.Call<BOOL>(0x660639BC60157048, ped, transportEntity); }
		public static void _0x4248AB2EEB3C75AD(int transportEntity, int ped, BOOL p2) { Function.Call(0x4248AB2EEB3C75AD, transportEntity, ped, p2); }
		public static void _SET_PED_USE_TRANSPORT_SEAT_PREFERENCE(int ped, int transportEntity, int preferenceSlot, int p3, int seatIndex) { Function.Call(0xB7079F4C72896756, ped, transportEntity, preferenceSlot, p3, seatIndex); }
		public static void _0x5639FBEA922788DA(int transportEntity) { Function.Call(0x5639FBEA922788DA, transportEntity); }
		public static void _SET_AI_CAN_USE_TRANSPORT(int transportEntity, BOOL state) { Function.Call(0x67F7CEAC2391E114, transportEntity, state); }
		public static void _0x8C8371EDFAF014A0(int ped, float p1) { Function.Call(0x8C8371EDFAF014A0, ped, p1); }
		public static void _0xF8C20282B237E3F7(int ped) { Function.Call(0xF8C20282B237E3F7, ped); }
		public static void _0x13F138225C202F66(int transportEntity, int p1) { Function.Call(0x13F138225C202F66, transportEntity, p1); }
	}

	public static class ANIMSCENE
	{
		public static AnimScene _CREATE_ANIM_SCENE(string animDict, int flags, string playbackListName, BOOL p3, BOOL p4) { return Function.Call<AnimScene>(0x1FCA98E33C1437B3, animDict, flags, playbackListName, p3, p4); }
		public static void _DELETE_ANIM_SCENE(AnimScene animScene) { Function.Call(0x84EEDB2C6E650000, animScene); }
		public static void TRIGGER_ANIM_SCENE_SKIP(AnimScene animScene) { Function.Call(0x4B85B3CF9197AEDF, animScene); }
		public static BOOL _0x4B85B3CF91972222(AnimScene animScene) { return Function.Call<BOOL>(0x4B85B3CF91972222, animScene); }
		public static void _CLEAR_ANIM_SCENE_WAS_SKIPPED(AnimScene animScene) { Function.Call(0x8A8208AE92BF87A5, animScene); }
		public static BOOL DOES_ANIM_SCENE_EXIST(AnimScene animScene) { return Function.Call<BOOL>(0x25557E324489393C, animScene); }
		public static BOOL _DOES_ENTITY_WITH_ID_EXIST_IN_ANIM_SCENE(AnimScene animScene, string entityId) { return Function.Call<BOOL>(0x6F1F0B17109309DA, animScene, entityId); }
		public static BOOL _DOES_ANIM_SCENE_OWNERSHIP_OF_ENTITY_EXIST(AnimScene animScene, string entityName) { return Function.Call<BOOL>(0x9D1ECA9337BE9FC3, animScene, entityName); }
		public static void LOAD_ANIM_SCENE(AnimScene animScene) { Function.Call(0xAF068580194D9DC7, animScene); }
		public static BOOL IS_ANIM_SCENE_LOADED(AnimScene animScene, BOOL p1, BOOL p2) { return Function.Call<BOOL>(0x477122B8D05E7968, animScene, p1, p2); }
		public static BOOL _IS_ANIM_SCENE_LOADING(AnimScene animScene, BOOL p1) { return Function.Call<BOOL>(0x59606519FF9D3EC2, animScene, p1); }
		public static BOOL _IS_ANIM_SCENE_METADATA_ASSET_IN_RANGE_LOADING(AnimScene animScene, BOOL p1) { return Function.Call<BOOL>(0xF8D1D2DAB6007EEF, animScene, p1); }
		public static BOOL IS_ANIM_SCENE_METADATA_LOADED(AnimScene animScene, BOOL p1) { return Function.Call<BOOL>(0x95531A4A20CCE7BC, animScene, p1); }
		public static int _GET_ANIM_SCENE_PLAYBACK_LIST_PHASE_AUDIO_LOAD_STRESS(AnimScene animScene, string phaseName) { return Function.Call<int>(0x9E036D5204FFBBC8, animScene, phaseName); }
		public static void START_ANIM_SCENE(AnimScene animScene) { Function.Call(0xF4D94AF761768700, animScene); }
		public static void RESET_ANIM_SCENE(AnimScene animScene, string playbackListName) { Function.Call(0x8FDF221F13537936, animScene, playbackListName); }
		public static void ABORT_ANIM_SCENE(AnimScene animScene, BOOL p1) { Function.Call(0x718CF1328D20C2B3, animScene, p1); }
		public static void RESUME_ANIM_SCENE_FROM_LAST_CHECKPOINT(AnimScene animScene) { Function.Call(0x8E1BA705F63C1925, animScene); }
		public static BOOL IS_ANIM_SCENE_RUNNING(AnimScene animScene, BOOL p1) { return Function.Call<BOOL>(0xCBFC7725DE6CE2E0, animScene, p1); }
		public static BOOL IS_ANIM_SCENE_FINISHED(AnimScene animScene, BOOL p1) { return Function.Call<BOOL>(0xD8254CB2C586412B, animScene, p1); }
		public static BOOL IS_ANIM_SCENE_EXITING_THIS_FRAME(AnimScene animScene) { return Function.Call<BOOL>(0xCDC5512A407CF08D, animScene); }
		public static BOOL HAS_ANIM_SCENE_EXITED(AnimScene animScene, BOOL p1) { return Function.Call<BOOL>(0xF94692EB9DC15D74, animScene, p1); }
		public static BOOL _0x73616E64696C132E(AnimScene animScene, BOOL p1) { return Function.Call<BOOL>(0x73616E64696C132E, animScene, p1); }
		public static BOOL IS_ANIM_SCENE_IN_SECTION(AnimScene animScene, string sectionName, BOOL p2) { return Function.Call<BOOL>(0x8D81E7824B7753F7, animScene, sectionName, p2); }
		public static BOOL _IS_ANIM_SCENE_SKIPPABLE(AnimScene animScene) { return Function.Call<BOOL>(0x4CDFFE3189EBDBD0, animScene); }
		public static BOOL _IS_ANIM_SCENE_ABORTED(AnimScene animScene) { return Function.Call<BOOL>(0x34A0671BE613D3D0, animScene); }
		public static BOOL _0xD70C7A30412F8FA0(AnimScene animScene) { return Function.Call<BOOL>(0xD70C7A30412F8FA0, animScene); }
		public static BOOL _0x9AAE3C1148A09BCA(AnimScene animScene) { return Function.Call<BOOL>(0x9AAE3C1148A09BCA, animScene); }
		public static BOOL _0xA96619FE85159ED2(AnimScene animScene) { return Function.Call<BOOL>(0xA96619FE85159ED2, animScene); }
		public static void FADE_ANIM_SCENE_AUDIO_IN(AnimScene animScene, float p1) { Function.Call(0xA41351EA2A18A0AD, animScene, p1); }
		public static void FADE_ANIM_SCENE_AUDIO_OUT(AnimScene animScene, float p1) { Function.Call(0x323E3AD772BA5D57, animScene, p1); }
		public static void BLOCK_ANIM_SCENE_FADING_NEXT_FRAME(BOOL p0, BOOL p1) { Function.Call(0x1B70811D3BF75DB9, p0, p1); }
		public static void SET_ANIM_SCENE_ORIGIN(AnimScene animScene, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, int order) { Function.Call(0x020894BF17A02EF2, animScene, posX, posY, posZ, rotX, rotY, rotZ, order); }
		public static unsafe void GET_ANIM_SCENE_ORIGIN(AnimScene animScene, Vector3* position, Vector3* rotation, int order) { Function.Call(0xADF1D53F3B1FE0A7, animScene, position, rotation, order); }
		public static void SET_ANIM_SCENE_PAUSED(AnimScene animScene, BOOL toggle) { Function.Call(0xD6824B7D24DC0CE0, animScene, toggle); }
		public static BOOL _IS_ANIM_SCENE_PAUSED(AnimScene animScene) { return Function.Call<BOOL>(0x4B4038796F0D6566, animScene); }
		public static void SET_ANIM_SCENE_RATE(AnimScene animScene, float rate) { Function.Call(0x75820B801CFF262A, animScene, rate); }
		public static float _GET_ANIM_SCENE_RATE(AnimScene animScene) { return Function.Call<float>(0x43C21623E42B821B, animScene); }
		public static float GET_ANIM_SCENE_PHASE(AnimScene animScene) { return Function.Call<float>(0x3FBC3F51BF12DFBF, animScene); }
		public static float _GET_ANIM_SCENE_TIME(AnimScene animScene) { return Function.Call<float>(0x61BE7D6186260002, animScene); }
		public static float _GET_ANIM_SCENE_DURATION(AnimScene animScene) { return Function.Call<float>(0x49F1D143ADE32656, animScene); }
		public static void SET_ANIM_SCENE_ENTITY(AnimScene animScene, string entityName, int entity, int flags) { Function.Call(0x8B720AD451CA2AB3, animScene, entityName, entity, flags); }
		public static void REMOVE_ANIM_SCENE_ENTITY(AnimScene animScene, string entityName, int entity) { Function.Call(0x2BF96692C67F3E53, animScene, entityName, entity); }
		public static BOOL IS_ENTITY_EXITING_ANIM_SCENE_THIS_FRAME(AnimScene animScene, string entityName) { return Function.Call<BOOL>(0x005E6F28DD7ED58D, animScene, entityName); }
		public static BOOL COULD_ANIM_SCENE_ENTITY_REACH_EXIT_NEXT_FRAME(AnimScene animScene, string entityName, Any p2, Any p3) { return Function.Call<BOOL>(0x73616E64696C616E, animScene, entityName, p2, p3); }
		public static BOOL HAS_ENTITY_EXITED_ANIM_SCENE(AnimScene animScene, string entityName) { return Function.Call<BOOL>(0xB89FCFF19DAFFF28, animScene, entityName); }
		public static BOOL _HAS_ENTITY_ENTERED_ANIM_SCENE(AnimScene animScene, string entityName) { return Function.Call<BOOL>(0x337F1CC8EE895601, animScene, entityName); }
		public static int _GET_ANIM_SCENE_PED(AnimScene animScene, string name, BOOL isNetwork) { return Function.Call<int>(0xE5822422197BBBA3, animScene, name, isNetwork); }
		public static Object _GET_ANIM_SCENE_OBJECT(AnimScene animScene, string name, BOOL isNetwork) { return Function.Call<Object>(0xFB5674687A1B2814, animScene, name, isNetwork); }
		public static int _GET_ANIM_SCENE_VEHICLE(AnimScene animScene, string name, BOOL isNetwork) { return Function.Call<int>(0x430EE0A19BC5A287, animScene, name, isNetwork); }
		public static void SET_ANIM_SCENE_BOOL(AnimScene animScene, string name, BOOL value, BOOL p3) { Function.Call(0x519E96C2C68B404B, animScene, name, value, p3); }
		public static BOOL GET_ANIM_SCENE_BOOL(AnimScene animScene, string name) { return Function.Call<BOOL>(0x07A6F6447ECA9B64, animScene, name); }
		public static void SET_ANIM_SCENE_FLOAT(AnimScene animScene, string name, float value, BOOL p3, BOOL p4) { Function.Call(0x6BC5104E68CBEFE8, animScene, name, value, p3, p4); }
		public static float GET_ANIM_SCENE_FLOAT(AnimScene animScene, string name) { return Function.Call<float>(0xCC24CB07F60B496E, animScene, name); }
		public static void SET_ANIM_SCENE_INT(AnimScene animScene, string name, int value, BOOL p3) { Function.Call(0x3A379D2166CF5B92, animScene, name, value, p3); }
		public static int GET_ANIM_SCENE_INT(AnimScene animScene, string name) { return Function.Call<int>(0x2B7277484CC095FD, animScene, name); }
		public static unsafe BOOL GET_ANIM_SCENE_ENTITY_LOCATION_DATA(AnimScene animScene, string entityName, Vector3* matrix, BOOL p3, string playbackListName, int p5) { return Function.Call<BOOL>(0x8398438D8F14F56D, animScene, entityName, matrix, p3, playbackListName, p5); }
		public static BOOL IS_ENTITY_PLAYING_ANIM_SCENE(int entity, AnimScene animScene) { return Function.Call<BOOL>(0x3AB6C7B0BB0DF4B1, entity, animScene); }
		public static void ATTACH_ANIM_SCENE_TO_ENTITY(AnimScene animScene, int entity, int p2) { Function.Call(0xDC418495DBA327A1, animScene, entity, p2); }
		public static void ATTACH_ANIM_SCENE_TO_ENTITY_PRESERVING_LOCATION(AnimScene animScene, int entity, int p2) { Function.Call(0x1C0B105C3F30B88D, animScene, entity, p2); }
		public static void DETACH_ANIM_SCENE(AnimScene animScene) { Function.Call(0x6843A1AA3A336DFF, animScene); }
		public static void DETACH_ANIM_SCENE_PRESERVING_LOCATION(AnimScene animScene) { Function.Call(0xA2507C4948C83D2E, animScene); }
		public static void TAKE_OWNERSHIP_OF_ANIM_SCENE(AnimScene animScene) { Function.Call(0xF7A4C571E572D237, animScene); }
		public static BOOL CHECK_OWNERSHIP_OF_ANIM_SCENE(AnimScene animScene) { return Function.Call<BOOL>(0x661B8683611B9B97, animScene); }
		public static void SET_ANIM_SCENE_PLAYBACK_LIST(AnimScene animScene, string playbackListName) { Function.Call(0xAB5E7CAB074D6B84, animScene, playbackListName); }
		public static BOOL _0x1C5D33A4293E6DDE(AnimScene animScene, string phaseName) { return Function.Call<BOOL>(0x1C5D33A4293E6DDE, animScene, phaseName); }
		public static BOOL _DOES_ANIM_SCENE_PLAY_LIST_EXIST(AnimScene animScene, string playbackListName) { return Function.Call<BOOL>(0xA9016536015DE29D, animScene, playbackListName); }
		public static void SET_ANIM_SCENE_PLAY_LIST(AnimScene animScene, string playlistName, BOOL p2) { Function.Call(0x15598CFB25F3DC7E, animScene, playlistName, p2); }
		public static BOOL _IS_ANIM_SCENE_PLAYBACK_LIST_PHASE_ACTIVE(AnimScene animScene, string phaseName) { return Function.Call<BOOL>(0x1F0E401031E20146, animScene, phaseName); }
		public static BOOL REQUEST_ANIM_SCENE_PLAY_LIST(AnimScene animScene, string playlistName) { return Function.Call<BOOL>(0xDF7B5144E25CD3FE, animScene, playlistName); }
		public static BOOL _RELEASE_ANIM_SCENE_PLAY_LIST(AnimScene animScene, string playlistName) { return Function.Call<BOOL>(0xAE6ADA8FE7E84ACC, animScene, playlistName); }
		public static Hash _GET_ANIM_SCENE_DICT(AnimScene animScene) { return Function.Call<Hash>(0xAE5ADA4FE3E21ADC, animScene); }
		public static BOOL _0x1407F5115FB9583E(AnimScene animScene, string p1) { return Function.Call<BOOL>(0x1407F5115FB9583E, animScene, p1); }
		public static BOOL _IS_ANIM_SCENE_PLAYBACK_LIST_PHASE_LOADED(AnimScene animScene, string phaseName) { return Function.Call<BOOL>(0x23E33CB9F4A3F547, animScene, phaseName); }
		public static BOOL _IS_ANIM_SCENE_PLAYBACK_LIST_PHASE_LOADING(AnimScene animScene, string phaseName) { return Function.Call<BOOL>(0x0DF57F86FE71DBE5, animScene, phaseName); }
		public static void _0x1AD896BF43619551() { Function.Call(0x1AD896BF43619551); }
		public static int GET_ANIM_SCENE_CURRENT_ACTIVE_CAMERA_COUNT(AnimScene animScene) { return Function.Call<int>(0x4822A65D5AF64E69, animScene); }
		public static BOOL _0x5D7BFDA2290B4E39(string p0) { return Function.Call<BOOL>(0x5D7BFDA2290B4E39, p0); }
		public static BOOL _IS_MGM_SYSTEM_LOADED(string mgmFilename) { return Function.Call<BOOL>(0xFDFC14799373283F, mgmFilename); }
		public static BOOL _LOAD_MGM_ASSETS(string mgmFilename) { return Function.Call<BOOL>(0xB727A847862CB00A, mgmFilename); }
		public static int _CREATE_MGM_SYSTEM(string mgmFilename) { return Function.Call<int>(0xA1300DE03E5D1973, mgmFilename); }
		public static void _DELETE_MGM_SYSTEM(int mgmHandle) { Function.Call(0x53CB3970BA02E3CC, mgmHandle); }
		public static void _0xB1A196BAFE650402(int mgmHandle, int ped) { Function.Call(0xB1A196BAFE650402, mgmHandle, ped); }
		public static void _0xAE6DE22DE0ED4554(int mgmHandle, int ped) { Function.Call(0xAE6DE22DE0ED4554, mgmHandle, ped); }
		public static BOOL _0x61B2AAEF645DDAF0(int mgmEventHandle, string p1, int seatId, int p3, BOOL p4) { return Function.Call<BOOL>(0x61B2AAEF645DDAF0, mgmEventHandle, p1, seatId, p3, p4); }
		public static void _SET_MGM_EVENT(int mgmEventHandle, string p1, Any seatId, int p3, float p4) { Function.Call(0x07706C4CC9C6CC9E, mgmEventHandle, p1, seatId, p3, p4); }
		public static void _0x3641FCD53E59B335(int mgmHandle, int ped, string secondaryVoiceString) { Function.Call(0x3641FCD53E59B335, mgmHandle, ped, secondaryVoiceString); }
		public static void _SET_BREAKOUT_ARCHETYPE(int ped, string archetype) { Function.Call(0x99B2A2E3655DEAF1, ped, archetype); }
		public static void _CLEAR_BREAKOUT_ARCHETYPE(int ped) { Function.Call(0xBC781D24AA11F179, ped); }
		public static BOOL _0x3B393716C3FD8237(int ped) { return Function.Call<BOOL>(0x3B393716C3FD8237, ped); }
		public static void _0xE12D7B4B959644CD() { Function.Call(0xE12D7B4B959644CD); }
		public static void _0xC1193521E3B9FADD(int entity, BOOL p1) { Function.Call(0xC1193521E3B9FADD, entity, p1); }
		public static void _REQUEST_PHOTO_MODE_FREEZE() { Function.Call(0x7C709C01D43D94CD); }
		public static void _REQUEST_PHOTO_MODE_DEFREEZE() { Function.Call(0x41AFA5F228B0B6B0); }
		public static BOOL _0x2DB524750DC41ED4() { return Function.Call<BOOL>(0x2DB524750DC41ED4); }
		public static BOOL _0xEA41D44A8D42057B() { return Function.Call<BOOL>(0xEA41D44A8D42057B); }
		public static void _PAUSE_SCRIPT_THREADS(BOOL toggle) { Function.Call(0x37C1257849DEF24A, toggle); }
		public static void _0xCDCD7B2D49AEE73A(BOOL p0) { Function.Call(0xCDCD7B2D49AEE73A, p0); }
		public static BOOL WAS_ANIM_SCENE_SKIPPED(AnimScene animScene) { return Function.Call<BOOL>(0xEF324E9550A394D5, animScene); }
	}

	public static class _NAMESPACE4
	{
		public static unsafe void _0xC31C44C43B48FDE3(Any* gamerHandle, int badSportBehaviorType) { Function.Call(0xC31C44C43B48FDE3, gamerHandle, badSportBehaviorType); }
	}

	public static class ATTRIBUTE
	{
		public static void SET_ATTRIBUTE_BASE_RANK(int ped, int attributeIndex, int newValue) { Function.Call(0x5DA12E025D47D4E5, ped, attributeIndex, newValue); }
		public static int GET_ATTRIBUTE_RANK(int ped, int attributeIndex) { return Function.Call<int>(0xA4C8E23E29040DE0, ped, attributeIndex); }
		public static int GET_ATTRIBUTE_BASE_RANK(int ped, int attributeIndex) { return Function.Call<int>(0x147149F2E909323C, ped, attributeIndex); }
		public static int GET_ATTRIBUTE_BONUS_RANK(int ped, int coreIndex) { return Function.Call<int>(0x0EFA71F4B4330E04, ped, coreIndex); }
		public static int GET_MAX_ATTRIBUTE_RANK(int ped, int attributeIndex) { return Function.Call<int>(0x704674A0535A471D, ped, attributeIndex); }
		public static void SET_ATTRIBUTE_BONUS_RANK(int ped, int attributeIndex, int newValue) { Function.Call(0x920F9488BD115EFB, ped, attributeIndex, newValue); }
		public static int GET_DEFAULT_ATTRIBUTE_RANK(int ped, int attributeIndex) { return Function.Call<int>(0x958DD43D41F89A47, ped, attributeIndex); }
		public static int GET_DEFAULT_MAX_ATTRIBUTE_RANK(int ped, int attributeIndex) { return Function.Call<int>(0x7C059C55AD940CB4, ped, attributeIndex); }
		public static void ADD_ATTRIBUTE_POINTS(int ped, int attributeIndex, int p2) { Function.Call(0x75415EE0CB583760, ped, attributeIndex, p2); }
		public static void SET_ATTRIBUTE_POINTS(int ped, int attributeIndex, int p2) { Function.Call(0x09A59688C26D88DF, ped, attributeIndex, p2); }
		public static int GET_ATTRIBUTE_POINTS(int ped, int attributeIndex) { return Function.Call<int>(0x219DA04BAA9CB065, ped, attributeIndex); }
		public static int GET_MAX_ATTRIBUTE_POINTS(int ped, int attributeIndex) { return Function.Call<int>(0x223BF310F854871C, ped, attributeIndex); }
		public static void _SET_ATTRIBUTE_CORE_VALUE(int ped, int coreIndex, int value) { Function.Call(0xC6258F41D86676E0, ped, coreIndex, value); }
		public static int _GET_ATTRIBUTE_CORE_VALUE(int ped, int coreIndex) { return Function.Call<int>(0x36731AC041289BB1, ped, coreIndex); }
		public static int GET_DEFAULT_ATTRIBUTE_POINTS_NEEDED_FOR_RANK(Hash modelHash, int attributeIndex, int rank) { return Function.Call<int>(0x94A7F191DB49A44D, modelHash, attributeIndex, rank); }
		public static void ENABLE_ATTRIBUTE_OVERPOWER(int ped, int attributeIndex, float value, BOOL makeSound) { Function.Call(0xF6A7C08DF2E28B28, ped, attributeIndex, value, makeSound); }
		public static void _ENABLE_ATTRIBUTE_CORE_OVERPOWER(int ped, int coreIndex, float value, BOOL makeSound) { Function.Call(0x4AF5A4C7B9157D14, ped, coreIndex, value, makeSound); }
		public static void DISABLE_ATTRIBUTE_OVERPOWER(int ped, int attributeIndex) { Function.Call(0xF8DAC3D85636C241, ped, attributeIndex); }
		public static BOOL _IS_ATTRIBUTE_OVERPOWERED(int ped, int attributeIndex) { return Function.Call<BOOL>(0x103C2F885ABEB00B, ped, attributeIndex); }
		public static BOOL _IS_ATTRIBUTE_CORE_OVERPOWERED(int ped, int coreIndex) { return Function.Call<BOOL>(0x200373A8DF081F22, ped, coreIndex); }
		public static float _GET_ATTRIBUTE_OVERPOWER_SECONDS_LEFT(int ped, int attributeIndex) { return Function.Call<float>(0x4C9F782180712742, ped, attributeIndex); }
		public static float _GET_ATTRIBUTE_CORE_OVERPOWER_SECONDS_LEFT(int ped, int coreIndex) { return Function.Call<float>(0xB429F58803D285B1, ped, coreIndex); }
		public static void _START_ITEM_PREVIEW(Any p0, Any p1) { Function.Call(0x7E2C766ADB2C5F1A, p0, p1); }
		public static void STOP_ITEM_PREVIEW() { Function.Call(0xD962F8579D702DB5); }
		public static void _SET_STATUS_EFFECT_CORE_ICON(int statusEffectType) { Function.Call(0xA4D3A1C008F250DF, statusEffectType); }
		public static void _SET_STATUS_EFFECT_PERIODIC_ICON(int statusEffectType) { Function.Call(0xFB6E111908502871, statusEffectType); }
		public static void _STOP_STATUS_EFFECT_PERIODIC_ICON(int statusEffectType) { Function.Call(0x3FC4C027FD0936F4, statusEffectType); }
	}

	public static class AUDIO
	{
		public static void _0x7455CD705F7E933E() { Function.Call(0x7455CD705F7E933E); }
		public static void CLEAR_CONVERSATION_HISTORY() { Function.Call(0x33D51F801CB16E4F); }
		public static void _CLEAR_CONVERSATION_HISTORY_FOR_SCRIPTED_CONVERSATION(string convoRoot) { Function.Call(0xEF51242E35242B47, convoRoot); }
		public static BOOL CREATE_NEW_SCRIPTED_CONVERSATION(string convoRoot) { return Function.Call<BOOL>(0xD2C91A0B572AAE56, convoRoot); }
		public static Any _0xDF947FE0D551684E(Any p0, Any p1) { return Function.Call<Any>(0xDF947FE0D551684E, p0, p1); }
		public static void ADD_PED_TO_CONVERSATION(string convoRoot, int ped, string characterName) { Function.Call(0x95D9F4BC443956E7, convoRoot, ped, characterName); }
		public static void _0xA2323A2EAE32A290(Any p0, Any p1, Any p2) { Function.Call(0xA2323A2EAE32A290, p0, p1, p2); }
		public static Any _0x79F9C57B8D0DFE90(Any p0, Any p1) { return Function.Call<Any>(0x79F9C57B8D0DFE90, p0, p1); }
		public static void START_SCRIPT_CONVERSATION(string convoRoot, BOOL p1, BOOL p2, BOOL clone) { Function.Call(0x6B17C62C9635D2DC, convoRoot, p1, p2, clone); }
		public static void PRELOAD_SCRIPT_CONVERSATION(string convoRoot, BOOL p1, BOOL p2, BOOL clone) { Function.Call(0x3B3CAD6166916D87, convoRoot, p1, p2, clone); }
		public static void START_PRELOADED_CONVERSATION(string convoRoot) { Function.Call(0x23641AFE870AF385, convoRoot); }
		public static Any _0x0CB3D1919E8D7CBA(Any p0) { return Function.Call<Any>(0x0CB3D1919E8D7CBA, p0); }
		public static Any _0xFE5C6177064BD390(Any p0) { return Function.Call<Any>(0xFE5C6177064BD390, p0); }
		public static BOOL _IS_SCRIPTED_CONVERSATION_CREATED(string convoRoot) { return Function.Call<BOOL>(0xD89504D9D7D5057D, convoRoot); }
		public static Any _0x5A13586A9447931F(Any p0) { return Function.Call<Any>(0x5A13586A9447931F, p0); }
		public static BOOL IS_SCRIPTED_CONVERSATION_LOADED(string convoRoot) { return Function.Call<BOOL>(0xDF0D54BE7A776737, convoRoot); }
		public static Any _0xA2CAC9DEF0195E6F(Any p0) { return Function.Call<Any>(0xA2CAC9DEF0195E6F, p0); }
		public static BOOL IS_SCRIPTED_CONVERSATION_PLAYING(string p0) { return Function.Call<BOOL>(0x1ECC76792F661CF5, p0); }
		public static Any _0xF01C570E0A0A1E67(Any p0) { return Function.Call<Any>(0xF01C570E0A0A1E67, p0); }
		public static Any _0x847748AE5D7B1071(Any p0) { return Function.Call<Any>(0x847748AE5D7B1071, p0); }
		public static Any _0xD0730C1FA40348D9(Any p0) { return Function.Call<Any>(0xD0730C1FA40348D9, p0); }
		public static int GET_CURRENT_SCRIPTED_CONVERSATION_LINE(string p0) { return Function.Call<int>(0x480357EE890C295A, p0); }
		public static void PAUSE_SCRIPTED_CONVERSATION(string p0, BOOL p1, BOOL p2, BOOL p3, BOOL p4) { Function.Call(0x8530AD776CD72B12, p0, p1, p2, p3, p4); }
		public static void RESTART_SCRIPTED_CONVERSATION(string p0) { Function.Call(0x9AEB285D1818C9AC, p0); }
		public static void _0x36559148B78853B3(Any p0, BOOL p1, Any p2) { Function.Call(0x36559148B78853B3, p0, p1, p2); }
		public static int STOP_SCRIPTED_CONVERSATION(string p0, BOOL p1, BOOL p2) { return Function.Call<int>(0xD79DEEFB53455EBA, p0, p1, p2); }
		public static void SKIP_TO_NEXT_SCRIPTED_CONVERSATION_LINE(string p0) { Function.Call(0x9663FE6B7A61EB00, p0); }
		public static Any _0xF336E9F989B3518F(Any p0) { return Function.Call<Any>(0xF336E9F989B3518F, p0); }
		public static Any _0x254B0241E964B450(Any p0, Any p1) { return Function.Call<Any>(0x254B0241E964B450, p0, p1); }
		public static Any _0x152ED1B56E8F1F50(Any p0, Any p1) { return Function.Call<Any>(0x152ED1B56E8F1F50, p0, p1); }
		public static Any _0x935DBD96D4A3DA1F(Any p0, Any p1) { return Function.Call<Any>(0x935DBD96D4A3DA1F, p0, p1); }
		public static Any _0x295859EB18F48D82(Any p0) { return Function.Call<Any>(0x295859EB18F48D82, p0); }
		public static void _0x40CA665AB9D8D505(string convoRoot, int singleLineIndex) { Function.Call(0x40CA665AB9D8D505, convoRoot, singleLineIndex); }
		public static void _0xF232C2C546AC16D0(Any p0) { Function.Call(0xF232C2C546AC16D0, p0); }
		public static void _0x1E6F9A9FE1A99F36(Any p0) { Function.Call(0x1E6F9A9FE1A99F36, p0); }
		public static void REGISTER_SCRIPT_WITH_AUDIO(int p0) { Function.Call(0xC6ED9D5092438D91, p0); }
		public static void UNREGISTER_SCRIPT_WITH_AUDIO() { Function.Call(0xA8638BE228D4751A); }
		public static BOOL REQUEST_SCRIPT_AUDIO_BANK(string audioBank) { return Function.Call<BOOL>(0x2F844A8B08D76685, audioBank); }
		public static void RELEASE_NAMED_SCRIPT_AUDIO_BANK(string audioBank) { Function.Call(0x77ED170667F50170, audioBank); }
		public static void RELEASE_SCRIPT_AUDIO_BANK() { Function.Call(0x7A2D8AD0A9EB9C3F); }
		public static int GET_SOUND_ID() { return Function.Call<int>(0x430386FE9BF80B45); }
		public static void RELEASE_SOUND_ID(int soundId) { Function.Call(0x353FC880830B88FA, soundId); }
		public static void PLAY_SOUND(string audioName, string audioRef, BOOL p2, Any p3, BOOL p4, Any p5) { Function.Call(0x7FF4944CC209192D, audioName, audioRef, p2, p3, p4, p5); }
		public static void PLAY_SOUND_FRONTEND(string audioName, string audioRef, BOOL p2, Any p3) { Function.Call(0x67C540AA08E4A6F5, audioName, audioRef, p2, p3); }
		public static void _PLAY_SOUND_FROM_ITEM(Hash item, Hash soundSet, Any p2) { Function.Call(0xE8EAFF7B41EDD291, item, soundSet, p2); }
		public static void PLAY_SOUND_FROM_ENTITY(string audioName, int entity, string audioRef, BOOL isNetwork, Any p4, Any p5) { Function.Call(0x6FB1DA3CA9DA7D90, audioName, entity, audioRef, isNetwork, p4, p5); }
		public static void _PLAY_SOUND_FROM_POSITION(string audioName, float x, float y, float z, string audioRef, BOOL isNetwork, Any p6, BOOL p7, Any p8) { Function.Call(0xCCE219C922737BFA, audioName, x, y, z, audioRef, isNetwork, p6, p7, p8); }
		public static void _STOP_SOUND_WITH_NAME(string audioName, string audioRef) { Function.Call(0x0F2A2175734926D8, audioName, audioRef); }
		public static Any _0x580D71DFE0088E34(Any p0, Any p1) { return Function.Call<Any>(0x580D71DFE0088E34, p0, p1); }
		public static BOOL _IS_SCRIPTED_AUDIO_CUSTOM(Hash item, Hash soundSet) { return Function.Call<BOOL>(0x6DF942C4179BE5AB, item, soundSet); }
		public static void _SET_VARIABLE_ON_SOUND_WITH_NAME(string variableName, float variableValue, string audioName, string audioRef) { Function.Call(0x9821B68CD3E05F2B, variableName, variableValue, audioName, audioRef); }
		public static void _SET_WHISTLE_CONFIG_FOR_PED(int ped, string whistleConfig, float value) { Function.Call(0x9963681A8BC69BF3, ped, whistleConfig, value); }
		public static void _SET_SOUND_RELATIONSHIP_ON_PED(int ped, string p1, string p2) { Function.Call(0x2E31ACA7477CF00F, ped, p1, p2); }
		public static void _PLAY_SOUND_FRONTEND_WITH_SOUND_ID(int soundId, string name, string soundSet, BOOL p3) { Function.Call(0xCE5D0FFE83939AF1, soundId, name, soundSet, p3); }
		public static void _PLAY_SOUND_FROM_ENTITY_WITH_SET(int soundId, string soundName, int entity, string soundsetName, BOOL p4, Any p5) { Function.Call(0xF1C5310FEAA36B48, soundId, soundName, entity, soundsetName, p4, p5); }
		public static void _PLAY_SOUND_FROM_POSITION_WITH_ID(int soundId, string soundName, float x, float y, float z, string soundsetName, BOOL p6, int p7, BOOL p8) { Function.Call(0xDCF5BA95BBF0FABA, soundId, soundName, x, y, z, soundsetName, p6, p7, p8); }
		public static void _UPDATE_SOUND_POSITION(int soundId, float x, float y, float z) { Function.Call(0x0286617C8FC50A53, soundId, x, y, z); }
		public static void _STOP_SOUND_WITH_ID(int soundId) { Function.Call(0x3210BCB36AF7621B, soundId); }
		public static void _SET_VARIABLE_ON_SOUND_WITH_ID(int soundId, string variableName, float variableValue) { Function.Call(0x503703EC1781B7D6, soundId, variableName, variableValue); }
		public static BOOL PREPARE_SOUND(string soundName, string soundsetName, int soundId) { return Function.Call<BOOL>(0xE368E8422C860BA7, soundName, soundsetName, soundId); }
		public static void _RELEASE_SHARD_SOUNDS(string soundName, string soundsetName) { Function.Call(0x9D746964E0CF2C5F, soundName, soundsetName); }
		public static BOOL PREPARE_SOUNDSET(string soundsetName, BOOL p1) { return Function.Call<BOOL>(0xD9130842D7226045, soundsetName, p1); }
		public static void _RELEASE_SOUNDSET(string soundsetName) { Function.Call(0x531A78D6BF27014B, soundsetName); }
		public static BOOL PREPARE_SOUND_WITH_ENTITY(string soundName, int entity, string soundsetName, int soundId) { return Function.Call<BOOL>(0x4AD019591E94C064, soundName, entity, soundsetName, soundId); }
		public static void _0x3E93DDDCBB6111E4(Any p0, Any p1) { Function.Call(0x3E93DDDCBB6111E4, p0, p1); }
		public static BOOL _HAS_SOUND_AUDIO_NAME_FINISHED(string audioName, string soundsetName) { return Function.Call<BOOL>(0x714A0EA7DE1167BE, audioName, soundsetName); }
		public static BOOL _HAS_SOUND_ID_FINISHED(int soundId) { return Function.Call<BOOL>(0x84848E1C0FC67DBB, soundId); }
		public static unsafe BOOL PLAY_PED_AMBIENT_SPEECH_NATIVE(int ped, Any* _params) { return Function.Call<BOOL>(0x8E04FEDD28D42462, ped, _params); }
		public static unsafe BOOL PLAY_AMBIENT_SPEECH_FROM_POSITION_NATIVE(float x, float y, float z, Any* _params) { return Function.Call<BOOL>(0xED640017ED337E45, x, y, z, _params); }
		public static Any _0x72E4D1C4639BC465(Any p0, Any p1) { return Function.Call<Any>(0x72E4D1C4639BC465, p0, p1); }
		public static Any _0xB18FEC133C7C6C69(Any p0) { return Function.Call<Any>(0xB18FEC133C7C6C69, p0); }
		public static void _0xDC93F0948F2C28F4(Any p0) { Function.Call(0xDC93F0948F2C28F4, p0); }
		public static void _0x0D7FD6A55FD63AEF(int p0, int p1, BOOL p2) { Function.Call(0x0D7FD6A55FD63AEF, p0, p1, p2); }
		public static void _0x660A8F876DF1D4F8(Any p0) { Function.Call(0x660A8F876DF1D4F8, p0); }
		public static void _0x380A2E353AD30917(Any p0, Any p1, Any p2) { Function.Call(0x380A2E353AD30917, p0, p1, p2); }
		public static void _0x0FAF7171BF613B80(Any p0) { Function.Call(0x0FAF7171BF613B80, p0); }
		public static void PLAY_PAIN(int ped, int painId, float p2, BOOL p3, BOOL isNetwork) { Function.Call(0xBC9AE166038A5CEC, ped, painId, p2, p3, isNetwork); }
		public static void _0x6652B0C8F3D414D0(Any p0) { Function.Call(0x6652B0C8F3D414D0, p0); }
		public static void _0xF092B6030D6FD49C(int ropeId, string name) { Function.Call(0xF092B6030D6FD49C, ropeId, name); }
		public static void _0x2651DDC0EA269073(int ropeId, float p1) { Function.Call(0x2651DDC0EA269073, ropeId, p1); }
		public static void SET_AMBIENT_VOICE_NAME(int ped, string name) { Function.Call(0x6C8065A3B780185B, ped, name); }
		public static void _SET_VOFX_PED_VOICE(int ped, Hash voice) { Function.Call(0x2703EFB583F0949A, ped, voice); }
		public static void STOP_CURRENT_PLAYING_SPEECH(int ped, Any p1) { Function.Call(0x79D2F0E66F81D90D, ped, p1); }
		public static void STOP_CURRENT_PLAYING_AMBIENT_SPEECH(int ped, Any p1) { Function.Call(0xB8BEC0CA6F0EDB0F, ped, p1); }
		public static BOOL IS_AMBIENT_SPEECH_PLAYING(int ped) { return Function.Call<BOOL>(0x9072C8B49907BFAD, ped); }
		public static BOOL IS_SCRIPTED_SPEECH_PLAYING(Any p0) { return Function.Call<BOOL>(0xCC9AA18DCC7084F4, p0); }
		public static BOOL IS_ANY_SPEECH_PLAYING(int ped) { return Function.Call<BOOL>(0x729072355FA39EC9, ped); }
		public static Any _0x2B101AD9F651243A() { return Function.Call<Any>(0x2B101AD9F651243A); }
		public static Any _0x4A98E228A936DBCC(Any p0) { return Function.Call<Any>(0x4A98E228A936DBCC, p0); }
		public static Any _0x6BFFB7C276866996(Any p0) { return Function.Call<Any>(0x6BFFB7C276866996, p0); }
		public static BOOL DOES_CONTEXT_EXIST_FOR_THIS_PED(int ped, string speechName, BOOL unk) { return Function.Call<BOOL>(0x49B99BF3FDA89A7A, ped, speechName, unk); }
		public static Any _0xF0EE69F500952FA5(Any p0) { return Function.Call<Any>(0xF0EE69F500952FA5, p0); }
		public static Any _0x9D6DEC9791A4E501(Any p0, Any p1, Any p2, Any p3) { return Function.Call<Any>(0x9D6DEC9791A4E501, p0, p1, p2, p3); }
		public static void _0x864A842B86993851(int ped) { Function.Call(0x864A842B86993851, ped); }
		public static BOOL IS_PED_IN_CURRENT_CONVERSATION(string p0, int ped, Any p2) { return Function.Call<BOOL>(0x049E937F18F4020C, p0, ped, p2); }
		public static BOOL _IS_PED_IN_ANY_CONVERSATION(int ped, BOOL p1) { return Function.Call<BOOL>(0x54B187F111D9C6F8, ped, p1); }
		public static void SET_PED_IS_DRUNK(int ped, BOOL toggle) { Function.Call(0x95D2D383D5396B8A, ped, toggle); }
		public static void _0x3A00D87B20A2A5E4(Any p0, Any p1) { Function.Call(0x3A00D87B20A2A5E4, p0, p1); }
		public static void _0xD47D47EFBF103FB8(Any p0, Any p1) { Function.Call(0xD47D47EFBF103FB8, p0, p1); }
		public static void PLAY_ANIMAL_VOCALIZATION(int ped, string vocalizationName, BOOL p2) { Function.Call(0xEE066C7006C49C0A, ped, vocalizationName, p2); }
		public static void _PLAY_ANIMAL_VOCALIZATION_PHEROMONE_VIAL_RESPONSE(int ped, Hash p1, BOOL p2) { Function.Call(0x0E53530D9B2DB01D, ped, p1, p2); }
		public static BOOL IS_ANIMAL_VOCALIZATION_PLAYING(int pedHandle) { return Function.Call<BOOL>(0xC265DF9FB44A9FBD, pedHandle); }
		public static void SET_ANIMAL_MOOD(int animal, int mood) { Function.Call(0xCC97B29285B1DC3B, animal, mood); }
		public static void _0xFCDEC42B1C78B7F8(Any p0, Any p1) { Function.Call(0xFCDEC42B1C78B7F8, p0, p1); }
		public static void _0xEB4D592620B8C209(Any p0) { Function.Call(0xEB4D592620B8C209, p0); }
		public static void _0xA6847BBA4FCDD13F(Any p0, Any p1) { Function.Call(0xA6847BBA4FCDD13F, p0, p1); }
		public static void SET_STATIC_EMITTER_ENABLED(string emitterName, BOOL toggle) { Function.Call(0x399D2D3B33F1B8EB, emitterName, toggle); }
		public static void PLAY_END_CREDITS_MUSIC(BOOL play) { Function.Call(0xCD536C4D33DCC900, play); }
		public static Any _0x7678FE0455ED1145(Any p0, Any p1, Any p2) { return Function.Call<Any>(0x7678FE0455ED1145, p0, p1, p2); }
		public static Any _0xFFE9C53DEEA3DB0B(Any p0, Any p1, float x, float y, float z, BOOL isSrlLoaded, Any p6) { return Function.Call<Any>(0xFFE9C53DEEA3DB0B, p0, p1, x, y, z, isSrlLoaded, p6); }
		public static void _0x5E3CCF03995388B5(Any p0, Any p1, Any p2, Any p3) { Function.Call(0x5E3CCF03995388B5, p0, p1, p2, p3); }
		public static void _0x43037ABFE214A851() { Function.Call(0x43037ABFE214A851); }
		public static void SET_AMBIENT_ZONE_STATE(string zoneName, BOOL isEnabled, BOOL p2) { Function.Call(0xBDA07E5950085E46, zoneName, isEnabled, p2); }
		public static void CLEAR_AMBIENT_ZONE_STATE(string zoneName, BOOL p1) { Function.Call(0x218DD44AAAC964FF, zoneName, p1); }
		public static void SET_AMBIENT_ZONE_LIST_STATE(string ambientZone, BOOL p1, BOOL p2) { Function.Call(0x9748FA4DE50CCE3E, ambientZone, p1, p2); }
		public static void CLEAR_AMBIENT_ZONE_LIST_STATE(string ambientZone, BOOL p1) { Function.Call(0x120C48C614909FA4, ambientZone, p1); }
		public static void SET_AMBIENT_ZONE_STATE_PERSISTENT(string ambientZone, BOOL p1, BOOL p2) { Function.Call(0x1D6650420CEC9D3B, ambientZone, p1, p2); }
		public static void SET_AMBIENT_ZONE_LIST_STATE_PERSISTENT(string ambientZone, BOOL p1, BOOL p2) { Function.Call(0xF3638DAE8C4045E1, ambientZone, p1, p2); }
		public static void _SET_AMBIENT_ZONE_POSITION(string ambientZone, float x, float y, float z, float heading) { Function.Call(0x3743CE6948194349, ambientZone, x, y, z, heading); }
		public static BOOL IS_HORN_ACTIVE(int vehicle) { return Function.Call<BOOL>(0x9D6BFC12B05C6121, vehicle); }
		public static void _0xFD461D0ABA5559B1(Any p0, Any p1) { Function.Call(0xFD461D0ABA5559B1, p0, p1); }
		public static BOOL IS_STREAM_PLAYING(int streamId) { return Function.Call<BOOL>(0xD11FA52EB849D978, streamId); }
		public static BOOL LOAD_STREAM(string streamName, string soundSet) { return Function.Call<BOOL>(0x1F1F957154EC51DF, streamName, soundSet); }
		public static void PLAY_STREAM_FROM_PED(int ped, int streamId) { Function.Call(0x89049DD63C08B5D1, ped, streamId); }
		public static void PLAY_STREAM_FRONTEND(int streamId) { Function.Call(0x58FCE43488F9F5F4, streamId); }
		public static void PLAY_STREAM_FROM_POSITION(float x, float y, float z, int streamId) { Function.Call(0x21442F412E8DE56B, x, y, z, streamId); }
		public static void _0x3A3BE6B920525237(Any p0, Any p1) { Function.Call(0x3A3BE6B920525237, p0, p1); }
		public static void STOP_STREAM(int streamId) { Function.Call(0xA4718A1419D18151, streamId); }
		public static void STOP_PED_SPEAKING(int ped, BOOL shaking) { Function.Call(0x9D64D7405520E3D3, ped, shaking); }
		public static void DISABLE_PED_PAIN_AUDIO(int ped, BOOL toggle) { Function.Call(0xA9A41C1E940FB0E8, ped, toggle); }
		public static BOOL IS_AMBIENT_SPEECH_DISABLED(int ped) { return Function.Call<BOOL>(0x932C2D096A2C3FFF, ped); }
		public static Any SET_IS_SCRIPTED_SPEECH_DISABLED(int ped, BOOL disabled) { return Function.Call<Any>(0xB2DE3AEBE31150E2, ped, disabled); }
		public static void _BLOCK_SPEECH_CONTEXT(string context, BOOL block) { Function.Call(0x6378A235374B852F, context, block); }
		public static void _0x87E6302FC61208CC(Any p0) { Function.Call(0x87E6302FC61208CC, p0); }
		public static void SET_HORN_ENABLED(int vehicle, BOOL toggle) { Function.Call(0x76D683C108594D0E, vehicle, toggle); }
		public static void SET_AUDIO_VEHICLE_PRIORITY(int vehicle, Any p1) { Function.Call(0xE5564483E407F914, vehicle, p1); }
		public static void _0x259ACC5B52A2B2D9(Any p0, Any p1) { Function.Call(0x259ACC5B52A2B2D9, p0, p1); }
		public static void _FORCE_VEHICLE_ENGINE_AUDIO(int vehicle, string audioName) { Function.Call(0x4F0C413926060B38, vehicle, audioName); }
		public static void SET_GPS_ACTIVE(BOOL active) { Function.Call(0x3BD3F52BA9B1E4E8, active); }
		public static BOOL _START_AUDIO_SCENESET(string audioName, string sceneset) { return Function.Call<BOOL>(0x6339C1EA3979B5F7, audioName, sceneset); }
		public static void _STOP_AUDIO_SCENESET(string sceneset) { Function.Call(0x9428447DED71FC7E, sceneset); }
		public static BOOL _SET_AUDIO_SCENESET(string audioName, string sceneset) { return Function.Call<BOOL>(0xAC84686C06184B0D, audioName, sceneset); }
		public static BOOL START_AUDIO_SCENE(string scene) { return Function.Call<BOOL>(0x013A80FC08F6E4F2, scene); }
		public static Any _0xDC2F83A0612CA34D(Any p0) { return Function.Call<Any>(0xDC2F83A0612CA34D, p0); }
		public static void STOP_AUDIO_SCENE(string scene) { Function.Call(0xDFE8422B3B94E688, scene); }
		public static void _0x6AB944DF68B512D3(Any p0) { Function.Call(0x6AB944DF68B512D3, p0); }
		public static void STOP_AUDIO_SCENES() { Function.Call(0xBAC7FC81A75EC1A1); }
		public static BOOL IS_AUDIO_SCENE_ACTIVE(string scene) { return Function.Call<BOOL>(0xB65B60556E2A9225, scene); }
		public static void SET_AUDIO_SCENE_VARIABLE(string scene, string variable, float value) { Function.Call(0xEF21A9EF089A2668, scene, variable, value); }
		public static Any _0x8B25A18E390F75BF(Any p0) { return Function.Call<Any>(0x8B25A18E390F75BF, p0); }
		public static void ADD_ENTITY_TO_AUDIO_MIX_GROUP(int entity, string groupName, float p2) { Function.Call(0x153973AB99FE8980, entity, groupName, p2); }
		public static Any _0x131EC9247E7A2903(Any p0) { return Function.Call<Any>(0x131EC9247E7A2903, p0); }
		public static void REMOVE_ENTITY_FROM_AUDIO_MIX_GROUP(int entity, float p1) { Function.Call(0x18EB48CFC41F2EA0, entity, p1); }
		public static Any _0xE600F61F54A444A6() { return Function.Call<Any>(0xE600F61F54A444A6); }
		public static BOOL AUDIO_IS_SCRIPTED_MUSIC_PLAYING() { return Function.Call<BOOL>(0x845FFC3A4FEEFA3E); }
		public static Hash _0xBE28DB99556FF8D9(int entity) { return Function.Call<Hash>(0xBE28DB99556FF8D9, entity); }
		public static void _0x8E901B65206C2D3E(int ped) { Function.Call(0x8E901B65206C2D3E, ped); }
		public static void _0xC4CFCE4C656EF480(int ped) { Function.Call(0xC4CFCE4C656EF480, ped); }
		public static void _0xABDB4863D3D72021(int entity, Any p1, Any p2, float p3, Any p4) { Function.Call(0xABDB4863D3D72021, entity, p1, p2, p3, p4); }
		public static void _0xB93A769B8B726950(int ped, Hash p1) { Function.Call(0xB93A769B8B726950, ped, p1); }
		public static void _0xE891504B2F0E2DBA(Any p0, Any p1) { Function.Call(0xE891504B2F0E2DBA, p0, p1); }
		public static void _0x9EB779765E68C52E(Any p0, Any p1) { Function.Call(0x9EB779765E68C52E, p0, p1); }
		public static void _0xE9694B2D6CB87B06(int entity, Any p1) { Function.Call(0xE9694B2D6CB87B06, entity, p1); }
		public static Any _0x886657C5B3D8EDE3(int entity) { return Function.Call<Any>(0x886657C5B3D8EDE3, entity); }
		public static Any _0xC68C02DE259C927C(Any p0) { return Function.Call<Any>(0xC68C02DE259C927C, p0); }
		public static Any _0x2FFF4A78384AFFDF(int entity) { return Function.Call<Any>(0x2FFF4A78384AFFDF, entity); }
		public static AnimScene _0x62377977E4F08668(int entity) { return Function.Call<AnimScene>(0x62377977E4F08668, entity); }
		public static Any _GET_PED_SONG_INDEX_HOST(int ped) { return Function.Call<Any>(0x2DBBF0C5E19383EE, ped); }
		public static Any _0xD05A460328560477(Any p0) { return Function.Call<Any>(0xD05A460328560477, p0); }
		public static void _0x8D29FDF565DED9AE(Any p0, Any p1, Any p2) { Function.Call(0x8D29FDF565DED9AE, p0, p1, p2); }
		public static void _0x448F2647DD6F2E27(Any p0, Any p1, Any p2, Any p3, Any p4) { Function.Call(0x448F2647DD6F2E27, p0, p1, p2, p3, p4); }
		public static void _0x139A4B9DF2D26CBF(Any p0, Any p1) { Function.Call(0x139A4B9DF2D26CBF, p0, p1); }
		public static void _0x018ABE833CA64D2A(Any p0, Any p1) { Function.Call(0x018ABE833CA64D2A, p0, p1); }
		public static void _0xBC07CA8FD710E7FD(Any p0, Any p1) { Function.Call(0xBC07CA8FD710E7FD, p0, p1); }
		public static BOOL PREPARE_MUSIC_EVENT(string _eventName) { return Function.Call<BOOL>(0x1E5185B72EF5158A, _eventName); }
		public static BOOL CANCEL_MUSIC_EVENT(string _eventName) { return Function.Call<BOOL>(0x5B17A90291133DA5, _eventName); }
		public static BOOL TRIGGER_MUSIC_EVENT(string _eventName) { return Function.Call<BOOL>(0x706D57B0F50DA710, _eventName); }
		public static Any _TRIGGER_MUSIC_EVENT_WITH_HASH(Hash _eventName) { return Function.Call<Any>(0x05D6195FB4D428F4, _eventName); }
		public static int GET_MUSIC_PLAYTIME() { return Function.Call<int>(0xE7A0D23DC414507B); }
		public static void _0xF64034D533CE8AAC(Any p0, Any p1, Any p2) { Function.Call(0xF64034D533CE8AAC, p0, p1, p2); }
		public static void SET_PED_WALLA_DENSITY(float p0, float p1) { Function.Call(0x149AEE66F0CB3A99, p0, p1); }
		public static void _0xDAD6CD07CAA4F382() { Function.Call(0xDAD6CD07CAA4F382); }
		public static void SET_PED_INTERIOR_WALLA_DENSITY(float p0, float p1) { Function.Call(0x8BF907833BE275DE, p0, p1); }
		public static void FORCE_PED_PANIC_WALLA() { Function.Call(0x062D5EAD4DA2FA6A); }
		public static void _0x138ADB94F8B90616() { Function.Call(0x138ADB94F8B90616); }
		public static void _0xBF4DC1784BE94DFA(int ped, BOOL p1, Hash hash) { Function.Call(0xBF4DC1784BE94DFA, ped, p1, hash); }
		public static void SET_AUDIO_FLAG(string flagName, BOOL toggle) { Function.Call(0xB9EFD5C25018725A, flagName, toggle); }
		public static void _0x6DA15746D5CC1A92(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5) { Function.Call(0x6DA15746D5CC1A92, p0, p1, p2, p3, p4, p5); }
		public static void _0x078F77FD1A43EAB3(Any p0, Any p1) { Function.Call(0x078F77FD1A43EAB3, p0, p1); }
		public static void _0x3D0BBCCF401B5FDB() { Function.Call(0x3D0BBCCF401B5FDB); }
		public static void SET_PORTAL_SETTINGS_OVERRIDE(string p0, string p1) { Function.Call(0x044DBAD7A7FA2BE5, p0, p1); }
		public static void REMOVE_PORTAL_SETTINGS_OVERRIDE(string p0) { Function.Call(0xB4BBFD9CD8B3922B, p0); }
		public static void _0xEA546C31FD45F8CD(Any p0) { Function.Call(0xEA546C31FD45F8CD, p0); }
		public static Any _0x44A5EEF54F62E823(Any p0) { return Function.Call<Any>(0x44A5EEF54F62E823, p0); }
		public static void _0x017492B2201E3428(Any p0, Any p1, Any p2, Any p3) { Function.Call(0x017492B2201E3428, p0, p1, p2, p3); }
		public static void _0xC886CD666ADD42E1(Any p0, Any p1) { Function.Call(0xC886CD666ADD42E1, p0, p1); }
		public static void _0x5AE0CB5F35F034FD(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7) { Function.Call(0x5AE0CB5F35F034FD, p0, p1, p2, p3, p4, p5, p6, p7); }
		public static void _0x821C32C728B24477(Any p0, Any p1, Any p2) { Function.Call(0x821C32C728B24477, p0, p1, p2); }
		public static void _0x06C5DF5EE444BC6B(Any p0, Any p1, Any p2, Any p3, Any p4) { Function.Call(0x06C5DF5EE444BC6B, p0, p1, p2, p3, p4); }
		public static void _0x341CDD17EFC2472E(Any p0, Any p1) { Function.Call(0x341CDD17EFC2472E, p0, p1); }
		public static void _0x7E176C676F8652A9(Any p0) { Function.Call(0x7E176C676F8652A9, p0); }
		public static Any _0x2B9C37C01BF25EDB(Any p0) { return Function.Call<Any>(0x2B9C37C01BF25EDB, p0); }
		public static Any _0xA6A3A3F96B8B030E() { return Function.Call<Any>(0xA6A3A3F96B8B030E); }
		public static int _GET_LOADED_STREAM_ID_FROM_CREATION(string streamName, string soundSet) { return Function.Call<int>(0x0556C784FA056628, streamName, soundSet); }
		public static Any _0xC369E2234E34A0CA(Any p0, Any p1) { return Function.Call<Any>(0xC369E2234E34A0CA, p0, p1); }
		public static void _0x35B8C070E0C16E2F(Any p0, Any p1) { Function.Call(0x35B8C070E0C16E2F, p0, p1); }
		public static void _0xE7E6CB8B713ED190() { Function.Call(0xE7E6CB8B713ED190); }
		public static void _0x569ABC36E28DDEAA() { Function.Call(0x569ABC36E28DDEAA); }
		public static void _0x839C9F124BE74D94(Any p0, Any p1, Any p2, Any p3, Any p4) { Function.Call(0x839C9F124BE74D94, p0, p1, p2, p3, p4); }
		public static void AUDIO_TRIGGER_EXPLOSION(string name, float x, float y, float z) { Function.Call(0x374F0E716BFCDE82, name, x, y, z); }
		public static void _0x3E98AC9D8C56C62C(Any p0) { Function.Call(0x3E98AC9D8C56C62C, p0); }
		public static void _0xCBF2BEBB468A34F3(Any p0) { Function.Call(0xCBF2BEBB468A34F3, p0); }
		public static void _0xA2B851605748AD0E() { Function.Call(0xA2B851605748AD0E); }
		public static void _0xCFAD2C8CD1054523(Any p0, Any p1, Any p2, Any p3) { Function.Call(0xCFAD2C8CD1054523, p0, p1, p2, p3); }
		public static void _0xD733528B6C35647A(Any p0, Any p1) { Function.Call(0xD733528B6C35647A, p0, p1); }
		public static void _0x5BC885EBD75FAA7D(Any p0, Any p1) { Function.Call(0x5BC885EBD75FAA7D, p0, p1); }
		public static void _0x6B7A88A61B41E589(Any p0) { Function.Call(0x6B7A88A61B41E589, p0); }
		public static void _0x4BE3EC91C01F0FE8() { Function.Call(0x4BE3EC91C01F0FE8); }
		public static void SET_AUDIO_ONLINE_TRANSITION_STAGE(string p0) { Function.Call(0x9B1FC259187C97C0, p0); }
		public static void _0x2E399EAFBEEA74D5() { Function.Call(0x2E399EAFBEEA74D5); }
		public static void _0x64B956F4E761DF5C(Any p0) { Function.Call(0x64B956F4E761DF5C, p0); }
	}

	public static class BOUNTY
	{
		public static unsafe BOOL _BOUNTY_REQUEST_PAY_OFF_BOUNTY(Any* _outRpcGuid) { return Function.Call<BOOL>(0x537CE992BD2D7BCB, _outRpcGuid); }
		public static unsafe BOOL _BOUNTY_REQUEST_PAY_OFF_BOUNTY_EX(Any* _outRpcGuid, Hash p1, Hash costType) { return Function.Call<BOOL>(0x587BCEC31D64F382, _outRpcGuid, p1, costType); }
		public static unsafe BOOL _BOUNTY_REQUEST_SELF_REPORT_CRIME(Any* _outRpcGuid, Hash crimeType, BOOL p2) { return Function.Call<BOOL>(0x188B748861B5BA17, _outRpcGuid, crimeType, p2); }
		public static unsafe BOOL _BOUNTY_REQUEST_SELF_REPORT_KILLED_BY_BOUNTY_HUNTER(Any* _outRpcGuid) { return Function.Call<BOOL>(0xB462D69D406A2602, _outRpcGuid); }
		public static unsafe BOOL BOUNTY_GET_BOUNTY_ON_PLAYER(Any* gamerHandle, Any* bountyData) { return Function.Call<BOOL>(0x4EF23E04A0C8FF51, gamerHandle, bountyData); }
		public static unsafe BOOL _BOUNTY_IS_REQUEST_PENDING(Any* rpcGuid) { return Function.Call<BOOL>(0x03B61CD51097DE60, rpcGuid); }
		public static unsafe BOOL _BOUNTY_REQUEST_BEGIN_WANTED_POSTER(Any* _outRpcGuid, int p1) { return Function.Call<BOOL>(0xFFA13742E43507E3, _outRpcGuid, p1); }
		public static unsafe BOOL _0x81847C2134039BDC(Any* p0) { return Function.Call<BOOL>(0x81847C2134039BDC, p0); }
		public static unsafe BOOL _BOUNTY_REQUEST_COMPLETE_WANTED_POSTER(Any* _outRpcGuid, Any* p1) { return Function.Call<BOOL>(0x727AB6F008BB9F29, _outRpcGuid, p1); }
		public static unsafe BOOL _BOUNTY_REQUEST_COMPLETE_SPLIT_WANTED_POSTER(Any* _outRpcGuid, Any* p1) { return Function.Call<BOOL>(0xFBD137BF0EC50FC9, _outRpcGuid, p1); }
		public static void _BOUNTY_CANCEL_WANTED_POSTER() { Function.Call(0x6A9DF0FCD0C87FF9); }
		public static unsafe BOOL BOUNTY_REQUEST_BEGIN_LEGENDARY_MISSION(Any* _outRpcGuid, int p1, int p2) { return Function.Call<BOOL>(0xFC81D7C7A151CFAA, _outRpcGuid, p1, p2); }
		public static unsafe BOOL BOUNTY_REQUEST_BEGIN_LEGENDARY_MISSION_FOR_POSSE(Any* _outRpcGuid, int p1, int p2) { return Function.Call<BOOL>(0x48E4E23F1739E197, _outRpcGuid, p1, p2); }
		public static unsafe BOOL _BOUNTY_REQUEST_COMPLETE_LEGENDARY_MISSION(Any* _outRpcGuid, Any* p1) { return Function.Call<BOOL>(0xA7309AC0DCF6D950, _outRpcGuid, p1); }
		public static void _BOUNTY_CANCEL_LEGENDARY_MISSION() { Function.Call(0x2BA1BCC99826CDA2); }
		public static unsafe BOOL BOUNTY_GET_WANTED_POSTER_SLOT(Hash p0, Hash p1, Any* p2) { return Function.Call<BOOL>(0xB395A44A0C7CA615, p0, p1, p2); }
		public static unsafe BOOL BOUNTY_GET_LEGENDARY_TARGET(Any p0, Any* p1) { return Function.Call<BOOL>(0x85E4D7B225A30ED1, p0, p1); }
		public static unsafe BOOL _0x86EC5F83867C4B70(Any* p0) { return Function.Call<BOOL>(0x86EC5F83867C4B70, p0); }
		public static unsafe BOOL BOUNTY_GET_COOLDOWN_COLLECTION(Any* p0) { return Function.Call<BOOL>(0x8FAF4D262FABA99C, p0); }
		public static unsafe BOOL _BOUNTY_REQUEST_BECOME_TARGET_OF_CHARACTER_BOUNTY_HUNT(Any* _outRpcGuid) { return Function.Call<BOOL>(0xB096547D61868254, _outRpcGuid); }
		public static unsafe BOOL _0x27D3A0E1FE090A43(Any* p0) { return Function.Call<BOOL>(0x27D3A0E1FE090A43, p0); }
		public static unsafe BOOL _BOUNTY_REQUEST_CLAIM_CHARACTER_BOUNTY(Any* _outRpcGuid, int p1, Any* p2) { return Function.Call<BOOL>(0xA9C3B0F746375162, _outRpcGuid, p1, p2); }
		public static unsafe BOOL _BOUNTY_REQUEST_POSSE_LEADER_CLAIM_CHARACTER_BOUNTY(Any* _outRpcGuid, int p1, Any* p2) { return Function.Call<BOOL>(0x5B53CA0E2AC3FF45, _outRpcGuid, p1, p2); }
		public static unsafe BOOL _BOUNTY_REQUEST_POSSE_MEMBER_CLAIM_CHARACTER_BOUNTY_SHARE(Any* _outRpcGuid, Any* p1) { return Function.Call<BOOL>(0x22D3A61CE053270C, _outRpcGuid, p1); }
		public static void _BOUNTY_CLEAR_BEING_BOUNTY_HUNTER() { Function.Call(0xA59D1997ECD99F0A); }
		public static unsafe BOOL _BOUNTY_REQUEST_ESCAPED_CHARACTER_BOUNTY_HUNT(Any* _outRpcGuid) { return Function.Call<BOOL>(0x12E981D53B07BF48, _outRpcGuid); }
		public static unsafe BOOL _BOUNTY_REQUEST_POSSE_LEADER_ESCAPED_CHARACTER_BOUNTY_HUNT(Any* _outRpcGuid) { return Function.Call<BOOL>(0x2D874BA20E8E1F20, _outRpcGuid); }
		public static unsafe BOOL _BOUNTY_REQUEST_POSSE_MEMBER_ESCAPED_CHARACTER_BOUNTY_HUNT(Any* _outRpcGuid) { return Function.Call<BOOL>(0x8521C2E235558278, _outRpcGuid); }
		public static void _BOUNTY_CLEAR_BEING_TARGET() { Function.Call(0x932DB3C05A7465D1); }
		public static unsafe BOOL _BOUNTY_REQUEST_SERVED_FULL_JAIL_SENTENCE(Any* _outRpcGuid) { return Function.Call<BOOL>(0x3F73AED12A5EF0FF, _outRpcGuid); }
		public static unsafe BOOL _BOUNTY_REQUEST_BRIBE_JAIL_GUARD(Any* _outRpcGuid, int p1) { return Function.Call<BOOL>(0x28717806D3BDD0D0, _outRpcGuid, p1); }
		public static int _0xF8BCC5ECA33AC9C1() { return Function.Call<int>(0xF8BCC5ECA33AC9C1); }
		public static int _0xD6A67E2FF373D0E3(int p0) { return Function.Call<int>(0xD6A67E2FF373D0E3, p0); }
	}

	public static class BRAIN
	{
		public static void REGISTER_OBJECT_SCRIPT_BRAIN(string scriptName, Hash modelHash, int p2, float activationRange, int p4, int p5) { Function.Call(0x16AF9B4EEAC3B305, scriptName, modelHash, p2, activationRange, p4, p5); }
		public static int _START_PRELOADED_SCRIPT_BRAIN(int entity, string scriptName, int scriptStackSize, BOOL p3) { return Function.Call<int>(0x4E4507CC5E4DB869, entity, scriptName, scriptStackSize, p3); }
		public static unsafe int _START_SCRIPT_BRAIN(int entity, string scriptName, int p2, Any* p3, int p4, BOOL p5) { return Function.Call<int>(0x6F62FAE266DCFC81, entity, scriptName, p2, p3, p4, p5); }
		public static void _REMOVE_SCRIPT_BRAIN_ENTITY(int entity) { Function.Call(0x38F1E09224EECA09, entity); }
		public static int _GET_SCRIPT_BRAIN_ENTITY() { return Function.Call<int>(0x6818D1A194E29983); }
		public static void _0xA6AC35DB4A7957A8(int flag) { Function.Call(0xA6AC35DB4A7957A8, flag); }
		public static void _0x4AA5EA1EDFB25786(int flag) { Function.Call(0x4AA5EA1EDFB25786, flag); }
		public static void ENABLE_SCRIPT_BRAIN_SET(int brainSet) { Function.Call(0x1CF6E5C6750EADBD, brainSet); }
		public static void DISABLE_SCRIPT_BRAIN_SET(int brainSet) { Function.Call(0x3F44EA613A5B2676, brainSet); }
		public static void _PREPARE_SCRIPT_BRAIN() { Function.Call(0xA32B0B05EFF75730); }
		public static void _0x74C333E34DF74E8A(string scriptName) { Function.Call(0x74C333E34DF74E8A, scriptName); }
	}

	public static class CAM
	{
		public static void RENDER_SCRIPT_CAMS(BOOL render, BOOL ease, int easeTime, BOOL p3, BOOL p4, int p5) { Function.Call(0x33281167E4942E4F, render, ease, easeTime, p3, p4, p5); }
		public static void STOP_RENDERING_SCRIPT_CAMS_USING_CATCH_UP(BOOL render, float distance, int blendBackSmoothingType, BOOL p3, BOOL p4, BOOL p5) { Function.Call(0x8C7C7FF7CF0E5153, render, distance, blendBackSmoothingType, p3, p4, p5); }
		public static Cam CREATE_CAM(string camName, BOOL p1) { return Function.Call<Cam>(0xE72CDBA7F0A02DD6, camName, p1); }
		public static Cam CREATE_CAM_WITH_PARAMS(string camName, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, float fov, BOOL p8, int p9) { return Function.Call<Cam>(0x40C23491CE83708E, camName, posX, posY, posZ, rotX, rotY, rotZ, fov, p8, p9); }
		public static Cam CREATE_CAMERA(Hash camHash, BOOL p1) { return Function.Call<Cam>(0x57CDF879EA466C46, camHash, p1); }
		public static Cam CREATE_CAMERA_WITH_PARAMS(Hash camHash, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, float fov, BOOL p8, Any p9) { return Function.Call<Cam>(0x98B99B9F27E2D60B, camHash, posX, posY, posZ, rotX, rotY, rotZ, fov, p8, p9); }
		public static void DESTROY_CAM(Cam cam, BOOL p1) { Function.Call(0x4E67E0B6D7FD5145, cam, p1); }
		public static void DESTROY_ALL_CAMS(BOOL p0) { Function.Call(0x163600D6E136C9F8, p0); }
		public static BOOL DOES_CAM_EXIST(Cam cam) { return Function.Call<BOOL>(0x153AD457764FD704, cam); }
		public static void SET_CAM_ACTIVE(Cam cam, BOOL active) { Function.Call(0x87295BCA613800C8, cam, active); }
		public static BOOL IS_CAM_ACTIVE(Cam cam) { return Function.Call<BOOL>(0x63EFCC7E1810B8E6, cam); }
		public static BOOL IS_CAM_RENDERING(Cam cam) { return Function.Call<BOOL>(0x4415F8A6C536D39F, cam); }
		public static Cam GET_RENDERING_CAM() { return Function.Call<Cam>(0x03A8931ECC8015D6); }
		public static Vector3 GET_CAM_COORD(Cam cam) { return Function.Call<Vector3>(0x6B12F11C2A9F0344, cam); }
		public static Vector3 GET_CAM_ROT(Cam cam, int rotationOrder) { return Function.Call<Vector3>(0x9BF96B57254E7889, cam, rotationOrder); }
		public static float GET_CAM_FOV(Cam cam) { return Function.Call<float>(0x8101D32A0A6B0F60, cam); }
		public static void SET_CAM_PARAMS(Cam cam, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, float fieldOfView, Any p8, int p9, int p10, int p11, Any p12, Any p13) { Function.Call(0xA47BBFFFB83D4D0A, cam, posX, posY, posZ, rotX, rotY, rotZ, fieldOfView, p8, p9, p10, p11, p12, p13); }
		public static void SET_CAM_COORD(Cam cam, float posX, float posY, float posZ) { Function.Call(0xF9EE7D419EE49DE6, cam, posX, posY, posZ); }
		public static void SET_CAM_ROT(Cam cam, float rotX, float rotY, float rotZ, int rotationOrder) { Function.Call(0x63DFA6810AD78719, cam, rotX, rotY, rotZ, rotationOrder); }
		public static void SET_CAM_FOV(Cam cam, float fieldOfView) { Function.Call(0x27666E5988D9D429, cam, fieldOfView); }
		public static void SET_CAM_NEAR_CLIP(Cam cam, float nearClip) { Function.Call(0xA924028272A61364, cam, nearClip); }
		public static void SET_CAM_FAR_CLIP(Cam cam, float farClip) { Function.Call(0x5E32817BF6302111, cam, farClip); }
		public static void SET_CAM_MOTION_BLUR_STRENGTH(Cam cam, float strength) { Function.Call(0x45FD891364181F9E, cam, strength); }
		public static void _0xFC3F638BE2B6BB02() { Function.Call(0xFC3F638BE2B6BB02); }
		public static unsafe void _0xE4B7945EF4F1BFB2(Cam cam, float* p1) { Function.Call(0xE4B7945EF4F1BFB2, cam, p1); }
		public static void _0x1FC6C727D30FFDDE(Any p0) { Function.Call(0x1FC6C727D30FFDDE, p0); }
		public static void ATTACH_CAM_TO_ENTITY(Cam cam, int entity, float xOffset, float yOffset, float zOffset, BOOL isRelative) { Function.Call(0xFDC0DF7F6FB0A592, cam, entity, xOffset, yOffset, zOffset, isRelative); }
		public static void ATTACH_CAM_TO_PED_BONE(Cam cam, int ped, int boneIndex, float x, float y, float z, BOOL heading) { Function.Call(0xDFC1E4A44C0324CA, cam, ped, boneIndex, x, y, z, heading); }
		public static void DETACH_CAM(Cam cam) { Function.Call(0x05B41DDBEB559556, cam); }
		public static void POINT_CAM_AT_COORD(Cam cam, float x, float y, float z) { Function.Call(0x948B39341C3A40C2, cam, x, y, z); }
		public static void POINT_CAM_AT_ENTITY(Cam cam, int entity, float p2, float p3, float p4, BOOL p5) { Function.Call(0xFC2867E6074D3A61, cam, entity, p2, p3, p4, p5); }
		public static void STOP_CAM_POINTING(Cam cam) { Function.Call(0xCA1B30A3357C71F1, cam); }
		public static void _SET_CAM_FOCUS_DISTANCE(Cam cam, float distance) { Function.Call(0x11F32BB61B756732, cam, distance); }
		public static void _0x9F97E85EC142255E(Any p0, Any p1) { Function.Call(0x9F97E85EC142255E, p0, p1); }
		public static void SET_CAM_AFFECTS_AIMING(Cam cam, BOOL toggle) { Function.Call(0x3CB9E8BDE5E76F33, cam, toggle); }
		public static void SET_CAM_CONTROLS_MINI_MAP_HEADING(Cam cam, BOOL p1) { Function.Call(0x1B8F3CE5A6001298, cam, p1); }
		public static void _0x42ED56B02E05D109(Any p0, BOOL p1) { Function.Call(0x42ED56B02E05D109, p0, p1); }
		public static void ADD_CAM_SPLINE_NODE(Cam camera, float x, float y, float z, float xRot, float yRot, float zRot, int length, int p8, int p9) { Function.Call(0xF1F57F9D230F9CD1, camera, x, y, z, xRot, yRot, zRot, length, p8, p9); }
		public static void SET_CAM_SPLINE_PHASE(Cam cam, float p1) { Function.Call(0xF1898A68E7C15636, cam, p1); }
		public static float GET_CAM_SPLINE_PHASE(Cam cam) { return Function.Call<float>(0x095EDCD24D90033A, cam); }
		public static void SET_CAM_SPLINE_DURATION(Cam cam, int timeDuration) { Function.Call(0xFF6311652CA91015, cam, timeDuration); }
		public static void SET_CAM_SPLINE_SMOOTHING_STYLE(Cam cam, int smoothingStyle) { Function.Call(0x84B3645618E726B0, cam, smoothingStyle); }
		public static void SET_CAM_ACTIVE_WITH_INTERP(Cam camTo, Cam camFrom, int duration, int easeLocation, int easeRotation) { Function.Call(0x8B15AE2987C1AC8F, camTo, camFrom, duration, easeLocation, easeRotation); }
		public static BOOL IS_CAM_INTERPOLATING(Cam cam) { return Function.Call<BOOL>(0x578F8F1CAA17BD2B, cam); }
		public static void SHAKE_CAM(Cam cam, string type, float amplitude) { Function.Call(0xF9A7BCF5D050D4E7, cam, type, amplitude); }
		public static BOOL IS_CAM_SHAKING(Cam cam) { return Function.Call<BOOL>(0x2EEB402BD7320159, cam); }
		public static void STOP_CAM_SHAKING(Cam cam, BOOL p1) { Function.Call(0xB78CC4B4706614B0, cam, p1); }
		public static BOOL PLAY_CAM_ANIM(Cam cam, string animName, string animDictionary, float x, float y, float z, float xRot, float yRot, float zRot, BOOL p9, int p10) { return Function.Call<BOOL>(0xA263DDF694D563F6, cam, animName, animDictionary, x, y, z, xRot, yRot, zRot, p9, p10); }
		public static void _0xCF69EA05CD9C33C9() { Function.Call(0xCF69EA05CD9C33C9); }
		public static BOOL _IS_ANIM_SCENE_CAM_ACTIVE() { return Function.Call<BOOL>(0x20389408F0E93B9A); }
		public static BOOL IS_SCREEN_FADED_OUT() { return Function.Call<BOOL>(0xF5472C80DF2FF847); }
		public static BOOL IS_SCREEN_FADED_IN() { return Function.Call<BOOL>(0x37F9A426FBCF4AF2); }
		public static BOOL IS_SCREEN_FADING_OUT() { return Function.Call<BOOL>(0x02F39BEFE7B88D00); }
		public static BOOL IS_SCREEN_FADING_IN() { return Function.Call<BOOL>(0x0CECCC63FFA2EF24); }
		public static void DO_SCREEN_FADE_IN(int duration) { Function.Call(0x6A053CF596F67DF7, duration); }
		public static void DO_SCREEN_FADE_OUT(int duration) { Function.Call(0x40C719A5E410B9E4, duration); }
		public static BOOL HAS_LETTER_BOX() { return Function.Call<BOOL>(0x81DCFD13CF39920E); }
		public static void _REQUEST_LETTER_BOX_NOW(BOOL p0, BOOL p1) { Function.Call(0x69D65E89FFD72313, p0, p1); }
		public static void _REQUEST_LETTER_BOX_OVERTIME(int p0, int p1, BOOL p2, int p3, BOOL p4, BOOL p5) { Function.Call(0xE296208C273BD7F0, p0, p1, p2, p3, p4, p5); }
		public static void _FORCE_LETTER_BOX_THIS_UPDATE() { Function.Call(0xC64ABC0676AF262B); }
		public static float GET_LETTER_BOX_RATIO() { return Function.Call<float>(0xA2B1C7EF759A63CE); }
		public static Any _0x73FF6BE63DC18819() { return Function.Call<Any>(0x73FF6BE63DC18819); }
		public static Any _0x450769C833D58844() { return Function.Call<Any>(0x450769C833D58844); }
		public static void SET_WIDESCREEN_BORDERS(BOOL p0, int p1) { Function.Call(0xD7F4D54CF80AFA34, p0, p1); }
		public static Vector3 GET_GAMEPLAY_CAM_COORD() { return Function.Call<Vector3>(0x595320200B98596E); }
		public static Vector3 GET_GAMEPLAY_CAM_ROT(int rotationOrder) { return Function.Call<Vector3>(0x0252D2B5582957A6, rotationOrder); }
		public static float GET_GAMEPLAY_CAM_FOV() { return Function.Call<float>(0xF6A96E5ACEEC6E50); }
		public static void _0x8459B3E64257B21D(float p0) { Function.Call(0x8459B3E64257B21D, p0); }
		public static float GET_GAMEPLAY_CAM_RELATIVE_HEADING() { return Function.Call<float>(0xC4ABF536048998AA); }
		public static void SET_GAMEPLAY_CAM_RELATIVE_HEADING(float heading, float p1) { Function.Call(0x5D1EB123EAC5D071, heading, p1); }
		public static float GET_GAMEPLAY_CAM_RELATIVE_PITCH() { return Function.Call<float>(0x99AADEBBA803F827); }
		public static void SET_GAMEPLAY_CAM_RELATIVE_PITCH(float x, float Value2) { Function.Call(0xFB760AF4F537B8BF, x, Value2); }
		public static void _0x0961B089947BA6D0(Any p0) { Function.Call(0x0961B089947BA6D0, p0); }
		public static void _0x04084490CC302CFB() { Function.Call(0x04084490CC302CFB); }
		public static void _0x1DD95A8D6B24A0C9(BOOL p0) { Function.Call(0x1DD95A8D6B24A0C9, p0); }
		public static BOOL _IS_IN_FULL_FIRST_PERSON_MODE() { return Function.Call<BOOL>(0xD1BA66940E94C547); }
		public static void SHAKE_GAMEPLAY_CAM(string shakeName, float intensity) { Function.Call(0xD9B31B4650520529, shakeName, intensity); }
		public static void _0xC3E9E5D4F413B773(string shakeName, float intensity) { Function.Call(0xC3E9E5D4F413B773, shakeName, intensity); }
		public static BOOL IS_GAMEPLAY_CAM_SHAKING() { return Function.Call<BOOL>(0xEA4C5F4AA0A4DBEF); }
		public static BOOL _0x0060B31968E60E41(string shakeName) { return Function.Call<BOOL>(0x0060B31968E60E41, shakeName); }
		public static void SET_GAMEPLAY_CAM_SHAKE_AMPLITUDE(float amplitude) { Function.Call(0x570E35F5C4A44838, amplitude); }
		public static void _0xFEFDDC6E8FDF8A75(string shakeName, float intensity) { Function.Call(0xFEFDDC6E8FDF8A75, shakeName, intensity); }
		public static void STOP_GAMEPLAY_CAM_SHAKING(BOOL p0) { Function.Call(0xE0DE43D290FB65F9, p0); }
		public static void _0x4285804FD65D8066(string shakeName, BOOL p1) { Function.Call(0x4285804FD65D8066, shakeName, p1); }
		public static void SET_GAMEPLAY_CAM_FOLLOW_PED_THIS_UPDATE(int ped) { Function.Call(0x82E41D6ADE924FCA, ped); }
		public static BOOL IS_GAMEPLAY_CAM_RENDERING() { return Function.Call<BOOL>(0x8660EA714834E412); }
		public static BOOL _0x251241CAEC707106() { return Function.Call<BOOL>(0x251241CAEC707106); }
		public static BOOL _0x43AB9D5A7D415478() { return Function.Call<BOOL>(0x43AB9D5A7D415478); }
		public static BOOL IS_GAMEPLAY_CAM_LOOKING_BEHIND() { return Function.Call<BOOL>(0x8FE0D24FFD04D5A2); }
		public static void _DISABLE_CAM_COLLISION_FOR_ENTITY(int entity) { Function.Call(0xD904F75DBD7AB865, entity); }
		public static void DISABLE_CAM_COLLISION_FOR_OBJECT(int entity) { Function.Call(0x7E3F546ACFE6C8D9, entity); }
		public static void _0x39073DA4EDDBC91D(Any p0) { Function.Call(0x39073DA4EDDBC91D, p0); }
		public static void _0x70A6658D476C6187() { Function.Call(0x70A6658D476C6187); }
		public static void _0x18C3DFAC458783BB() { Function.Call(0x18C3DFAC458783BB); }
		public static void _0xF1A6FEEDF3776EF9() { Function.Call(0xF1A6FEEDF3776EF9); }
		public static void _0xE6F364DE6C2FDEFE() { Function.Call(0xE6F364DE6C2FDEFE); }
		public static void _0x0F1FFEF5D54AE832() { Function.Call(0x0F1FFEF5D54AE832); }
		public static void _0x3C8F74E8FE751614() { Function.Call(0x3C8F74E8FE751614); }
		public static void _0x06557F6D96C86881() { Function.Call(0x06557F6D96C86881); }
		public static BOOL IS_SPHERE_VISIBLE(float x, float y, float z, float radius) { return Function.Call<BOOL>(0x2E941B5FFA2989C6, x, y, z, radius); }
		public static Any _0x190F7DA1AC09A8EF() { return Function.Call<Any>(0x190F7DA1AC09A8EF); }
		public static void _SET_GAMEPLAY_CAM_INITIAL_ZOOM(float camInitialZoom) { Function.Call(0xBCDA0BA8762FACB9, camInitialZoom); }
		public static void _SET_GAMEPLAY_CAM_INITIAL_HEADING(float camInitialHeading) { Function.Call(0x6C1053C433A573CF, camInitialHeading); }
		public static void _SET_GAMEPLAY_CAM_INITIAL_PITCH(float camInitialPitch) { Function.Call(0x449995EA846D3FC2, camInitialPitch); }
		public static void _CLAMP_GAMEPLAY_CAM_YAW(float minimum, float maximum) { Function.Call(0x14F3947318CA8AD2, minimum, maximum); }
		public static void _CLAMP_GAMEPLAY_CAM_PITCH(float minimum, float maximum) { Function.Call(0x326C7AA308F3DF6A, minimum, maximum); }
		public static void _ANIMATE_GAMEPLAY_CAM_ZOOM(float p0, float distance) { Function.Call(0x2126C740A4AC370B, p0, distance); }
		public static void SET_IN_VEHICLE_CAM_STATE_THIS_UPDATE(int vehicle, int p1) { Function.Call(0xFA1D5E8D1C3CCD67, vehicle, p1); }
		public static void _DISABLE_FIRST_PERSON_CAM_THIS_FRAME() { Function.Call(0x9C473089A934C930); }
		public static void _0x77D65669A05D1A1A() { Function.Call(0x77D65669A05D1A1A); }
		public static void _DISABLE_CINEMATIC_MODE_THIS_FRAME() { Function.Call(0x8910C24B7E0046EC); }
		public static BOOL _IS_IN_CINEMATIC_MODE() { return Function.Call<BOOL>(0x74F1D22EFA71FAB8); }
		public static void _0x718C6ECF5E8CBDD4() { Function.Call(0x718C6ECF5E8CBDD4); }
		public static void _FORCE_THIRD_PERSON_CAM_THIS_FRAME() { Function.Call(0x8370D34BD2E60B73); }
		public static void _FORCE_THIRD_PERSON_CAM_FAR_THIS_FRAME() { Function.Call(0x1CFB749AD4317BDE); }
		public static BOOL _FORCE_FIRST_PERSON_CAM_THIS_FRAME() { return Function.Call<BOOL>(0x90DA5BA5C2635416); }
		public static void _DISABLE_FIRST_PERSON_CAM_THIS_FRAME_2() { Function.Call(0x05AB44D906738426); }
		public static void _0x632BE8D84846FA56() { Function.Call(0x632BE8D84846FA56); }
		public static void _0x71D71E08A7ED5BD7(Any p0) { Function.Call(0x71D71E08A7ED5BD7, p0); }
		public static BOOL IS_FOLLOW_VEHICLE_CAM_ACTIVE() { return Function.Call<BOOL>(0xA40C2F51FB589E9A); }
		public static void _0x7E40A01B11398FCB() { Function.Call(0x7E40A01B11398FCB); }
		public static BOOL IS_AIM_CAM_ACTIVE() { return Function.Call<BOOL>(0x698F456FB909E077); }
		public static BOOL IS_FIRST_PERSON_AIM_CAM_ACTIVE() { return Function.Call<BOOL>(0xF63134C54B6EC212); }
		public static BOOL IS_FIRST_PERSON_CAMERA_ACTIVE(Any p0, Any p1, Any p2) { return Function.Call<BOOL>(0xA24C1D341C6E0D53, p0, p1, p2); }
		public static Any _0xDC62CD70658E7A02() { return Function.Call<Any>(0xDC62CD70658E7A02); }
		public static Any _0x796085220ADCC847() { return Function.Call<Any>(0x796085220ADCC847); }
		public static Any _0xB6A80E1E3A5444F1() { return Function.Call<Any>(0xB6A80E1E3A5444F1); }
		public static Any _0x8B1A5FE7E41E52B2() { return Function.Call<Any>(0x8B1A5FE7E41E52B2); }
		public static float GET_FIRST_PERSON_AIM_CAM_ZOOM_FACTOR() { return Function.Call<float>(0xB4132CA1B0EE1365); }
		public static void _0x05BD5E4088B30A66(float p0, float p1) { Function.Call(0x05BD5E4088B30A66, p0, p1); }
		public static void _SET_FIRST_PERSON_CAM_PITCH_RANGE(float p0, float p1) { Function.Call(0x715B7F5E8BED32A2, p0, p1); }
		public static void _0xC205B3C54C6A4E37(Any p0) { Function.Call(0xC205B3C54C6A4E37, p0); }
		public static Vector3 GET_FINAL_RENDERED_CAM_COORD() { return Function.Call<Vector3>(0x5352E025EC2B416F); }
		public static Vector3 GET_FINAL_RENDERED_CAM_ROT(int rotationOrder) { return Function.Call<Vector3>(0x602685BD85DD26CA, rotationOrder); }
		public static float GET_FINAL_RENDERED_CAM_FOV() { return Function.Call<float>(0x04AF77971E508F6A); }
		public static void SET_GAMEPLAY_COORD_HINT(float x, float y, float z, int duration, int blendOutDuration, int blendInDuration, int unk) { Function.Call(0xFA33B8C69A4A6A0F, x, y, z, duration, blendOutDuration, blendInDuration, unk); }
		public static void SET_GAMEPLAY_PED_HINT(int p0, float x1, float y1, float z1, BOOL p4, Any p5, Any p6, Any p7) { Function.Call(0x90FB951648851733, p0, x1, y1, z1, p4, p5, p6, p7); }
		public static void SET_GAMEPLAY_VEHICLE_HINT(Any p0, float p1, float p2, float p3, BOOL p4, Any p5, Any p6, Any p7) { Function.Call(0xE2B2BB7DAC280515, p0, p1, p2, p3, p4, p5, p6, p7); }
		public static void SET_GAMEPLAY_OBJECT_HINT(Any p0, float p1, float p2, float p3, BOOL p4, Any p5, Any p6, Any p7) { Function.Call(0xC40551D65F2BF297, p0, p1, p2, p3, p4, p5, p6, p7); }
		public static void SET_GAMEPLAY_ENTITY_HINT(int entity, float xOffset, float yOffset, float zOffset, BOOL p4, int p5, int p6, int p7, Any p8) { Function.Call(0xD1F7F32640ADFD12, entity, xOffset, yOffset, zOffset, p4, p5, p6, p7, p8); }
		public static BOOL IS_GAMEPLAY_HINT_ACTIVE() { return Function.Call<BOOL>(0x2E04AB5FEE042D4A); }
		public static void STOP_GAMEPLAY_HINT(BOOL p0) { Function.Call(0x1BCEC33D54CFCA8A, p0); }
		public static void _0x93759A83D0D844E7(BOOL p0) { Function.Call(0x93759A83D0D844E7, p0); }
		public static void _0x88544C0E3291DCAE(Any p0) { Function.Call(0x88544C0E3291DCAE, p0); }
		public static void SET_GAMEPLAY_HINT_FOV(float FOV) { Function.Call(0x661E58BC6F00A49A, FOV); }
		public static void SET_GAMEPLAY_HINT_FOLLOW_DISTANCE_SCALAR(float p0) { Function.Call(0xDDDC54181868F81F, p0); }
		public static void SET_GAMEPLAY_HINT_BASE_ORBIT_PITCH_OFFSET(float p0) { Function.Call(0x421192A2DA48FD01, p0); }
		public static void _SET_GAMEPLAY_HINT_ANIM_OFFSETX(float p0) { Function.Call(0xF86B6F93727C59C9, p0); }
		public static void _SET_GAMEPLAY_HINT_ANIM_OFFSETY(float p0) { Function.Call(0x29E74F819150CC32, p0); }
		public static void _0xF48664E9C83825E3(Any p0, Any p1) { Function.Call(0xF48664E9C83825E3, p0, p1); }
		public static void _0x1F6EBD94680252CE(Any p0, Any p1) { Function.Call(0x1F6EBD94680252CE, p0, p1); }
		public static void _0xE28F73212A813E82(Any p0, Any p1, Any p2, Any p3) { Function.Call(0xE28F73212A813E82, p0, p1, p2, p3); }
		public static void _0x4D2F46D1B28D90FB(Any p0, Any p1) { Function.Call(0x4D2F46D1B28D90FB, p0, p1); }
		public static unsafe void _START_CAMERA_ORBIT(Any* p0) { Function.Call(0x65B205BF30C13DDB, p0); }
		public static void _0x641092322A8852AB() { Function.Call(0x641092322A8852AB); }
		public static void _0xDB382FE20C2DA222(Any p0) { Function.Call(0xDB382FE20C2DA222, p0); }
		public static void _0x2DD3149DC34A3F4C(Any p0) { Function.Call(0x2DD3149DC34A3F4C, p0); }
		public static void _FREEZE_GAMEPLAY_CAM_THIS_FRAME() { Function.Call(0x027CAB2C3AF27010); }
		public static void _0x3C486E334520579D() { Function.Call(0x3C486E334520579D); }
		public static void _0x41E452A3C580D1A7() { Function.Call(0x41E452A3C580D1A7); }
		public static void SET_CINEMATIC_BUTTON_ACTIVE(BOOL p0) { Function.Call(0xB90411F480457A6C, p0); }
		public static BOOL IS_CINEMATIC_CAM_RENDERING() { return Function.Call<BOOL>(0xBF7C780731AADBF8); }
		public static void _DISABLE_VEHICLE_FIRST_PERSON_CAM_THIS_FRAME() { Function.Call(0xA5929C2E57AC90D1); }
		public static void _INVALIDATE_VEHICLE_IDLE_CAM() { Function.Call(0x634F4A0562CF19B8); }
		public static void FORCE_CINEMATIC_RENDERING_THIS_UPDATE(BOOL p0) { Function.Call(0x702B75DC9D3EDE56, p0); }
		public static void _0x9AC65A36D3C0C189(Any p0) { Function.Call(0x9AC65A36D3C0C189, p0); }
		public static BOOL _0x975F6EBB62632FE3() { return Function.Call<BOOL>(0x975F6EBB62632FE3); }
		public static void SET_CINEMATIC_MODE_ACTIVE(BOOL p0) { Function.Call(0xCE7A90B160F75046, p0); }
		public static BOOL _0x1811A02277A9E49D() { return Function.Call<BOOL>(0x1811A02277A9E49D); }
		public static void _FORCE_CINEMATIC_DEATH_CAM_ON_PED(int targetPed) { Function.Call(0xE3639DB78B3B5400, targetPed); }
		public static void _0x986F7A51EE3E1F92(Any p0, Any p1) { Function.Call(0x986F7A51EE3E1F92, p0, p1); }
		public static void _0x5B637D6F3B67716A(Any p0) { Function.Call(0x5B637D6F3B67716A, p0); }
		public static void _0xC252C0CC969AF79A(Any p0) { Function.Call(0xC252C0CC969AF79A, p0); }
		public static void _0xE2BB2D6A9FE2ECDE(Any p0) { Function.Call(0xE2BB2D6A9FE2ECDE, p0); }
		public static void _SET_START_CINEMATIC_DEATH_CAM(BOOL p0) { Function.Call(0x6E969927CF632608, p0); }
		public static Any _0x6072B7420A83A03F() { return Function.Call<Any>(0x6072B7420A83A03F); }
		public static BOOL _0x1204EB53A5FBC63D() { return Function.Call<BOOL>(0x1204EB53A5FBC63D); }
		public static void _0x6519238858AF5479(Any p0) { Function.Call(0x6519238858AF5479, p0); }
		public static void _CREATE_KILL_CAM(int ped) { Function.Call(0x2F994CC29CAA9D22, ped); }
		public static BOOL _IS_CAM_PHOTOFX_RUNNING() { return Function.Call<BOOL>(0xA14D5FE82BCB1D9E); }
		public static Any _0x6DFD37E586D4F44F() { return Function.Call<Any>(0x6DFD37E586D4F44F); }
		public static Any _0x80D7A3E39B120BC4() { return Function.Call<Any>(0x80D7A3E39B120BC4); }
		public static void _0x63E5841A9264D016(Any p0) { Function.Call(0x63E5841A9264D016, p0); }
		public static void _TRIGGER_MISSION_FAILED_CAM() { Function.Call(0x9A92C06ACBAF9731); }
		public static void _0x16E9ABDD34DDD931() { Function.Call(0x16E9ABDD34DDD931); }
		public static BOOL IS_DEATH_FAIL_CAMERA_RUNNING() { return Function.Call<BOOL>(0x139EFB0A71DD9011); }
		public static Any _0x7CE9DC58E3E4755F() { return Function.Call<Any>(0x7CE9DC58E3E4755F); }
		public static void _0x3B8E3AD9677CE12B(Any p0, Any p1, Any p2) { Function.Call(0x3B8E3AD9677CE12B, p0, p1, p2); }
		public static void _0xDF7F5BE9150E47E4(Any p0) { Function.Call(0xDF7F5BE9150E47E4, p0); }
		public static void _0xB85C13E0BF1F2A1C(Any p0) { Function.Call(0xB85C13E0BF1F2A1C, p0); }
		public static void _0x066167C63111D8CF(Any p0, Any p1, Any p2, Any p3, Any p4) { Function.Call(0x066167C63111D8CF, p0, p1, p2, p3, p4); }
		public static void _0xA8BA2E0204D8486F() { Function.Call(0xA8BA2E0204D8486F); }
		public static void _0xC3742F1FDF0A6824() { Function.Call(0xC3742F1FDF0A6824); }
		public static void _0x0FF7125F07DEB84F(Any p0, Any p1) { Function.Call(0x0FF7125F07DEB84F, p0, p1); }
		public static void _0x6CAB0BA160B168D2() { Function.Call(0x6CAB0BA160B168D2); }
		public static void _LOAD_CINEMATIC_CAM_LOCATION(string locationDictName) { Function.Call(0x1B3C2D961F5FC0E1, locationDictName); }
		public static void _UNLOAD_CINEMATIC_CAMERA_LOCATION(string dictionaryName) { Function.Call(0x2412216FCC7B4E3E, dictionaryName); }
		public static BOOL _0xAA235E2F2C09E952(string sLocationDictName) { return Function.Call<BOOL>(0xAA235E2F2C09E952, sLocationDictName); }
		public static Any _0x595550376B7EA230(Any p0) { return Function.Call<Any>(0x595550376B7EA230, p0); }
		public static Any _0x465F04F68AD38197(Any p0, Any p1, Any p2) { return Function.Call<Any>(0x465F04F68AD38197, p0, p1, p2); }
		public static Any _0xEA113BF9B0C0C5D7(Any p0, Any p1, Any p2) { return Function.Call<Any>(0xEA113BF9B0C0C5D7, p0, p1, p2); }
		public static void _CINEMATIC_LOCATION_TRIGGER_SCRIPTED_SHOT_EVENT_2(string dictionary, string shotName, int duration) { Function.Call(0xBC016635D6A73B31, dictionary, shotName, duration); }
		public static void CINEMATIC_LOCATION_TRIGGER_SCRIPTED_SHOT_EVENT(string dictionary, string shotName, string cameraName, Any p3) { Function.Call(0x02389579A53C3276, dictionary, shotName, cameraName, p3); }
		public static void _0xA54D643D0773EB65(Any p0, Any p1, Any p2) { Function.Call(0xA54D643D0773EB65, p0, p1, p2); }
		public static void CINEMATIC_LOCATION_STOP_SCRIPTED_SHOT_EVENT(Any p0, Any p1, Any p2) { Function.Call(0x6D4D25C2137FF511, p0, p1, p2); }
		public static BOOL _0xC3AEBB276825A359(string dictionary, string shotName, int duration) { return Function.Call<BOOL>(0xC3AEBB276825A359, dictionary, shotName, duration); }
		public static BOOL _0x1D931B7CC0EE3956(string dictionary, string shotName, string cameraName) { return Function.Call<BOOL>(0x1D931B7CC0EE3956, dictionary, shotName, cameraName); }
		public static void _CINEMATIC_LOCATION_SET_LOCATION_AND_ROTATION(string name, float x, float y, float z, float rotX, float rotY, float rotZ) { Function.Call(0x0E94C95EC3185FA9, name, x, y, z, rotX, rotY, rotZ); }
		public static void CINEMATIC_LOCATION_OVERRIDE_TARGET_ENTITY_THIS_UPDATE(string name, int entity) { Function.Call(0x0B0F914459731F60, name, entity); }
		public static void _LOAD_CAMERA_DATA_DICT(string cameraDictionary) { Function.Call(0x6A4D224FC7643941, cameraDictionary); }
		public static void _UNLOAD_CAMERA_DATA_DICT(string cameraDictionary) { Function.Call(0x798BE43C9393632B, cameraDictionary); }
		public static BOOL _IS_CAM_DATA_DICT_LOADED(string cameraDictionary) { return Function.Call<BOOL>(0xDD0B7C5AE58F721D, cameraDictionary); }
		public static Any _0xC285FD21294A1C49(Any p0) { return Function.Call<Any>(0xC285FD21294A1C49, p0); }
		public static void _CAM_CREATE(string cameraDictionary) { Function.Call(0xB8B207C34285E978, cameraDictionary); }
		public static void _CAM_DESTROY(string cameraDictionary) { Function.Call(0x0A5A4F1979ABB40E, cameraDictionary); }
		public static BOOL _IS_CAMERA_AVAILABLE(string cameraDictionary) { return Function.Call<BOOL>(0x927B810E43E99932, cameraDictionary); }
		public static Any _0x4138EE36BC3DC0A7(Any p0, Any p1) { return Function.Call<Any>(0x4138EE36BC3DC0A7, p0, p1); }
		public static void _0xFEB8646818294C75(Any p0, Any p1) { Function.Call(0xFEB8646818294C75, p0, p1); }
		public static void _0x29E6655DF3590B0D(Any p0) { Function.Call(0x29E6655DF3590B0D, p0); }
		public static void _0xAC77757C05DE9E5A(string cameraDictionary) { Function.Call(0xAC77757C05DE9E5A, cameraDictionary); }
		public static void _0x8E036B41C37D0E5F(Any p0) { Function.Call(0x8E036B41C37D0E5F, p0); }
		public static void _0x1D9F72DD4FD9A9D7(Any p0) { Function.Call(0x1D9F72DD4FD9A9D7, p0); }
		public static void _CAM_CREATE_2(string cameraDictionary) { Function.Call(0x7B0279170961A73F, cameraDictionary); }
		public static void _0x728491FB3DFFEF99(Any p0) { Function.Call(0x728491FB3DFFEF99, p0); }
		public static Any _0x14C4A49E36C29E49() { return Function.Call<Any>(0x14C4A49E36C29E49); }
		public static Any _0xF824530B612FE0CE() { return Function.Call<Any>(0xF824530B612FE0CE); }
		public static Any _0xEF9A3132A0AA6B19() { return Function.Call<Any>(0xEF9A3132A0AA6B19); }
		public static Any _0x5060FA977CEA4455() { return Function.Call<Any>(0x5060FA977CEA4455); }
		public static float _GET_PHOTO_MODE_FOCAL_LENGTH() { return Function.Call<float>(0x2533BAFFBE737E54); }
		public static float _GET_PHOTO_MODE_FOCUS_DISTANCE() { return Function.Call<float>(0x18FC740FFDCD7454); }
		public static float _GET_PHOTO_MODE_DOF() { return Function.Call<float>(0x4653A741D17F2CD0); }
		public static Any _0x2AB7C81B3F70570C() { return Function.Call<Any>(0x2AB7C81B3F70570C); }
		public static void _0x8505E05FC8822843(Any p0) { Function.Call(0x8505E05FC8822843, p0); }
	}

	public static class CLOCK
	{
		public static void SET_CLOCK_TIME(int hour, int minute, int second) { Function.Call(0x3A52C59FFB2DEED8, hour, minute, second); }
		public static void PAUSE_CLOCK(BOOL toggle, Any unused) { Function.Call(0x4D1A590C92BF377E, toggle, unused); }
		public static void _PAUSE_CLOCK_THIS_FRAME(BOOL toggle) { Function.Call(0x568D998A9FF96774, toggle); }
		public static void ADVANCE_CLOCK_TIME_TO(int hour, int minute, int second) { Function.Call(0x0184750AE88D0B1D, hour, minute, second); }
		public static void ADD_TO_CLOCK_TIME(int hours, int minutes, int seconds) { Function.Call(0xAB7C251C7701D336, hours, minutes, seconds); }
		public static int GET_CLOCK_HOURS() { return Function.Call<int>(0xC82CF208C2B19199); }
		public static int GET_CLOCK_MINUTES() { return Function.Call<int>(0x4E162231B823DBBF); }
		public static int GET_CLOCK_SECONDS() { return Function.Call<int>(0xB6101ABE62B5F080); }
		public static void _SET_MILLISECONDS_PER_GAME_MINUTE(int ms) { Function.Call(0x04EEDB3848DACF68, ms); }
		public static int _GET_SECONDS_SINCE_BASE_YEAR() { return Function.Call<int>(0x78FD8BE812E436B2); }
		public static void SET_CLOCK_DATE(int day, int month, int year) { Function.Call(0x02AD3092562941E2, day, month, year); }
		public static int GET_CLOCK_DAY_OF_WEEK() { return Function.Call<int>(0x4DD02D4C7FB30076); }
		public static int GET_CLOCK_DAY_OF_MONTH() { return Function.Call<int>(0xDF2FD796C54480A5); }
		public static int GET_CLOCK_MONTH() { return Function.Call<int>(0x2D44E8FC79EAB1AC); }
		public static int GET_CLOCK_YEAR() { return Function.Call<int>(0xE136DCA28C4A48BA); }
		public static int GET_MILLISECONDS_PER_GAME_MINUTE() { return Function.Call<int>(0xE4CB8D126501EC52); }
		public static unsafe void GET_POSIX_TIME(int* year, int* month, int* day, int* hour, int* minute, int* second) { Function.Call(0x90338AD4A784E455, year, month, day, hour, minute, second); }
		public static unsafe void _GET_POSIX_TIME_STRUCT(Any* _outTime) { Function.Call(0x86A68E84E5884951, _outTime); }
		public static unsafe void _ADD_TIME_TO_DATE_TIME(Any* inDateTime, Any* timeToAdd, Any* _outDateTime) { Function.Call(0x28EEACE9B43D9597, inDateTime, timeToAdd, _outDateTime); }
	}

	public static class COLLECTION
	{
		public static Hash _COLLECTABLE_GET_CATEGORY(Hash collectableItem) { return Function.Call<Hash>(0x725D52F21A5E9EF6, collectableItem); }
		public static Hash _COLLECTABLE_GET_SUBCATEGORY(Hash collectableItem) { return Function.Call<Hash>(0x6052B4DE6657684F, collectableItem); }
		public static Hash _COLLECTABLE_GET_IPL(Hash collectableItem) { return Function.Call<Hash>(0x922A79CD4A033B8B, collectableItem); }
		public static Vector3 _COLLECTABLE_GET_PLACEMENT_LOCATION(Hash collectableItem) { return Function.Call<Vector3>(0x1F1DD794908C2BFA, collectableItem); }
		public static int _COLLECTABLE_GET_NUM_FOUND(Hash collectableItem) { return Function.Call<int>(0xF83D3DDA4D3C8169, collectableItem); }
		public static int _COLLECTABLE_GET_NUM_TURNED_IN(Hash collectableItem) { return Function.Call<int>(0x9A03F22AD446EEAC, collectableItem); }
		public static void _COLLECTABLE_INCREMENT_NUM_FOUND(Hash collectableItem, int amount) { Function.Call(0x3EA62E56F386C997, collectableItem, amount); }
		public static void _COLLECTABLE_INCREMENT_NUM_TURNED_IN(Hash collectableItem, int amount) { Function.Call(0x398FAB9C96A81924, collectableItem, amount); }
		public static int _COLLECTABLE_CATEGORY_GET_NUM_COLLECTABLES(Hash collectableCategory, Hash collectableSubcategory) { return Function.Call<int>(0x62CAB7DB62EAD434, collectableCategory, collectableSubcategory); }
		public static Hash _COLLECTABLE_GET_COLLECTABLE_ITEM_HASH(int index, Hash collectableCategory, Hash collectableSubcategory) { return Function.Call<Hash>(0x126CBEBBA46693CF, index, collectableCategory, collectableSubcategory); }
		public static int _COLLECTABLE_CATEGORY_GET_NUM_FOUND(Hash collectableCategory, Hash collectableSubcategory) { return Function.Call<int>(0x5461C821D00FE15A, collectableCategory, collectableSubcategory); }
		public static int _COLLECTABLE_CATEGORY_GET_NUM_TURNED_IN(Hash collectableCategory, Hash collectableSubcategory) { return Function.Call<int>(0x3A65F4844913A047, collectableCategory, collectableSubcategory); }
		public static int _0x33825A7388A6B9F6(Hash collectableCategory, int p1) { return Function.Call<int>(0x33825A7388A6B9F6, collectableCategory, p1); }
		public static int _0x755901C7598B97BC(Hash collectableCategory, int p1) { return Function.Call<int>(0x755901C7598B97BC, collectableCategory, p1); }
		public static Any _0xB9020EC89C07DF04(Hash collectableCategory, int p1, int index) { return Function.Call<Any>(0xB9020EC89C07DF04, collectableCategory, p1, index); }
		public static BOOL _0xFC832B06127D8E99(Hash collectableCategory, int p1) { return Function.Call<BOOL>(0xFC832B06127D8E99, collectableCategory, p1); }
		public static void COLLECTABLE_CATEGORY_SET_HAS_RECEIVED_LIST(Any p0, Any p1, Any p2) { Function.Call(0x0B6D275D2F242E17, p0, p1, p2); }
		public static BOOL _0x6BAB7ACED1017204(Hash collectableCategory, int p1) { return Function.Call<BOOL>(0x6BAB7ACED1017204, collectableCategory, p1); }
		public static BOOL _0x61BEFBA3CE7A3BC8(Hash collectableCategory, int p1) { return Function.Call<BOOL>(0x61BEFBA3CE7A3BC8, collectableCategory, p1); }
		public static Any _0xC4AC39719C1BB559(Hash collectableCategory, Any p1) { return Function.Call<Any>(0xC4AC39719C1BB559, collectableCategory, p1); }
		public static Any _0x93F2E7B5DB85657B(Any p0, Any p1) { return Function.Call<Any>(0x93F2E7B5DB85657B, p0, p1); }
		public static Hash COLLECTABLE_GET_CATEGORY_ITEM_SET_BUY_AWARD(Hash collectableCategory, Hash p1) { return Function.Call<Hash>(0xCC644BC1DD655269, collectableCategory, p1); }
		public static Hash _0x9ADEE485726025D4(Hash collectableCategory) { return Function.Call<Hash>(0x9ADEE485726025D4, collectableCategory); }
		public static Any _0xD1806FB3EDED6D11(Hash collectableCategory, int p1) { return Function.Call<Any>(0xD1806FB3EDED6D11, collectableCategory, p1); }
		public static Any _0x3FD91F1A148A0468(Hash collectableCategory, int p1) { return Function.Call<Any>(0x3FD91F1A148A0468, collectableCategory, p1); }
		public static Any _0xC3CA424E1F12ED0C(Hash collectableCategory, int p1) { return Function.Call<Any>(0xC3CA424E1F12ED0C, collectableCategory, p1); }
		public static Hash _COLLECTABLE_CATEGORY_GET_TOAST_TEXTURE_NAME(Hash collectableCategory, Hash collectableSubcategory) { return Function.Call<Hash>(0xD52D20B0C76BB26D, collectableCategory, collectableSubcategory); }
		public static Hash _COLLECTABLE_CATEGORY_GET_TOAST_TEXTURE_DICTIONARY(Hash collectableCategory, Hash collectableSubcategory) { return Function.Call<Hash>(0x13AAECDA43318BFE, collectableCategory, collectableSubcategory); }
		public static Any _0xD297F68928A58130(Hash collectableCategory, int p1) { return Function.Call<Any>(0xD297F68928A58130, collectableCategory, p1); }
		public static Any _0x775FA1FC87666847(Hash collectableCategory, int p1) { return Function.Call<Any>(0x775FA1FC87666847, collectableCategory, p1); }
		public static Any _0xEC3959E9950BF56B(int p0) { return Function.Call<Any>(0xEC3959E9950BF56B, p0); }
	}

	public static class COMPANION
	{
		public static void _0xD730281E496621FB(int ped, Hash p1) { Function.Call(0xD730281E496621FB, ped, p1); }
		public static void _0xBF6583E926D13890(Any p0, Any p1) { Function.Call(0xBF6583E926D13890, p0, p1); }
		public static void _0x0A8FD91EDE7B328A(Any p0, Any p1) { Function.Call(0x0A8FD91EDE7B328A, p0, p1); }
		public static void _0x991E3346D788F20F(Any p0, Any p1) { Function.Call(0x991E3346D788F20F, p0, p1); }
		public static void _0xCE27824B5968B79A(Any p0, Any p1) { Function.Call(0xCE27824B5968B79A, p0, p1); }
		public static void _0xF06CBB8CCCA823C0(Any p0, Any p1) { Function.Call(0xF06CBB8CCCA823C0, p0, p1); }
		public static void _0x2917E634206B9E17(int ped, int p1) { Function.Call(0x2917E634206B9E17, ped, p1); }
		public static void _0xD428C3F92FC3F6F8(int ped, string p1) { Function.Call(0xD428C3F92FC3F6F8, ped, p1); }
		public static void _0xDEB369F6AD168C58(int ped, int p1) { Function.Call(0xDEB369F6AD168C58, ped, p1); }
		public static void _0x1740E3DEE0AE4D27(int ped, int p1) { Function.Call(0x1740E3DEE0AE4D27, ped, p1); }
		public static void _0x0DE02DA3C0F66955(Any p0, Any p1) { Function.Call(0x0DE02DA3C0F66955, p0, p1); }
		public static void _0x0F1CD8CA9E65D5F6(int groupId, Hash p1) { Function.Call(0x0F1CD8CA9E65D5F6, groupId, p1); }
		public static Any _0xB7E0590C86E1711F(Any p0) { return Function.Call<Any>(0xB7E0590C86E1711F, p0); }
		public static void _0xA079FF7CFB9AC8BD(Any p0, Any p1) { Function.Call(0xA079FF7CFB9AC8BD, p0, p1); }
		public static void _0x61BDA07407754A5C(Any p0, Any p1, Any p2, Any p3) { Function.Call(0x61BDA07407754A5C, p0, p1, p2, p3); }
		public static void _0xD55A871E1CE3481B(Any p0, Any p1, Any p2, Any p3) { Function.Call(0xD55A871E1CE3481B, p0, p1, p2, p3); }
		public static void _0x0C6A00DAE896614C(Any p0, Any p1) { Function.Call(0x0C6A00DAE896614C, p0, p1); }
		public static void _0x8FB98B719AA0075A(Any p0, Any p1, Any p2, Any p3, Any p4) { Function.Call(0x8FB98B719AA0075A, p0, p1, p2, p3, p4); }
		public static void _0x9C902084F48D2E6C(Any p0) { Function.Call(0x9C902084F48D2E6C, p0); }
		public static void _0xD747979C053EFA7A(Any p0) { Function.Call(0xD747979C053EFA7A, p0); }
		public static void _0x3CAAD93FA5B9579A(Volume volume, int p1, int p2) { Function.Call(0x3CAAD93FA5B9579A, volume, p1, p2); }
		public static void _0x7274F84B1501B523(Any p0) { Function.Call(0x7274F84B1501B523, p0); }
		public static Any _0x722FBE08EF5B87BD(Any p0, Any p1, Any p2, Any p3, Any p4) { return Function.Call<Any>(0x722FBE08EF5B87BD, p0, p1, p2, p3, p4); }
		public static void _ACTIVATE_COMPANION_ANALYSIS(int groupId) { Function.Call(0xCBD9EC60495C728C, groupId); }
		public static void _DEACTIVATE_COMPANION_ANALYSIS(int groupId) { Function.Call(0x72B7F65F11FC8896, groupId); }
	}

	public static class COMPENDIUM
	{
		public static Any _0x725D52F21A5E9E22(Hash category) { return Function.Call<Any>(0x725D52F21A5E9E22, category); }
		public static int _COMPENDIUM_GET_NUM_OF_ENTRIES_IN_CATEGORY(Hash category) { return Function.Call<int>(0x729D52F61A5A9E22, category); }
		public static Any _0x729D52461AEA9E22(Hash category) { return Function.Call<Any>(0x729D52461AEA9E22, category); }
		public static Any COMPENDIUM_GET_SHORT_DESCRIPTION_FROM_PED(int ped) { return Function.Call<Any>(0x6C5E5D48E48B4C65, ped); }
		public static Any COMPENDIUM_GET_SUBCATEGORY_PED_IS_IN(Hash p0, int ped) { return Function.Call<Any>(0x9B657550DF55EC96, p0, ped); }
		public static Any _0xCD278B6BFBDBDC22(Any p0, Any p1) { return Function.Call<Any>(0xCD278B6BFBDBDC22, p0, p1); }
		public static Any COMPENDIUM_GET_NUM_ENTRIES_IN_SUBCATEGORY(Hash p0, Hash p1) { return Function.Call<Any>(0xF58A0C0E086E8E36, p0, p1); }
		public static Any COMPENDIUM_GET_ENTRY_BY_INDEX_IN_SUBCATEGORY(Hash p0, Any p1, Any p2) { return Function.Call<Any>(0x5CEB63B2E3D9895F, p0, p1, p2); }
		public static Any COMPENDIUM_GET_ENTRY_BY_PED_INDEX(Any p0, Any p1) { return Function.Call<Any>(0x1CFA0219D8E1CF25, p0, p1); }
		public static Any COMPENDIUM_GET_ENTRY_BY_STAT_ITEM(Any p0, Any p1) { return Function.Call<Any>(0x66EC938394D76C85, p0, p1); }
		public static Any COMPENDIUM_GET_SUBCATEGORY_TOAST_APP_ID(Any p0, Any p1) { return Function.Call<Any>(0x2BF30D9D4D680112, p0, p1); }
		public static Any COMPENDIUM_GET_MAP_DISCOVERABLE_FROM_STAT_ITEM(Any p0, Any p1, Any p2, Any p3) { return Function.Call<Any>(0x729D54121A5E9E20, p0, p1, p2, p3); }
		public static void COMPENDIUM_ANIMAL_OBSERVED_BY_STAT_NAME(Hash animalType, BOOL p1) { Function.Call(0x725D52F26A5E9E10, animalType, p1); }
		public static Any COMPENDIUM_WAS_ANIMAL_OBSERVED(Any p0) { return Function.Call<Any>(0x23B5E9C5160BC04F, p0); }
		public static void COMPENDIUM_ANIMAL_SET_DISCOVERED(Any p0) { Function.Call(0x67F35C7C9F2BDCFE, p0); }
		public static Any COMPENDIUM_GET_STUDY_AWARD_ID(Any p0) { return Function.Call<Any>(0x9F678782720349E4, p0); }
		public static Any COMPENDIUM_ANIMAL_GET_SAMPLE_INVENTORY_ITEM(Any p0) { return Function.Call<Any>(0x4E4ACAE1C671A9DA, p0); }
		public static Any COMPENDIUM_ANIMAL_HAS_SAMPLE(Any p0) { return Function.Call<Any>(0x6FC24625E4FCAC27, p0); }
		public static Any COMPENDIUM_ANIMAL_HAS_STAMP(Any p0) { return Function.Call<Any>(0xBCF569FC32FFF456, p0); }
		public static Any COMPENDIUM_GET_SUBCATEGORY_SAMPLE_TOAST_TITLE(Any p0, Any p1) { return Function.Call<Any>(0x5E50C67EB60951E6, p0, p1); }
		public static Any COMPENDIUM_GET_SUBCATEGORY_SAMPLE_TOAST_DESC_PROGRESS(Any p0, Any p1) { return Function.Call<Any>(0x82BFB5B367957699, p0, p1); }
		public static Any COMPENDIUM_GET_SUBCATEGORY_SAMPLE_TOAST_DESC_COMPLETE(Any p0, Any p1) { return Function.Call<Any>(0x59D4D68CDB82427C, p0, p1); }
		public static void COMPENDIUM_FISH_CAUGHT(Any p0, Any p1) { Function.Call(0x725D52F21A5E9E00, p0, p1); }
		public static Any COMPENDIUM_FISH_GET_LURE_SUITABILITY_BY_STAT_ITEM(Any p0, Any p1) { return Function.Call<Any>(0x725D52F21A5E9E81, p0, p1); }
		public static void COMPENDIUM_GANG_CAMP_FOUND(Any p0, Any p1) { Function.Call(0x725D52F21A5E9E03, p0, p1); }
		public static void COMPENDIUM_GANG_AMBUSH_SURVIVED(Any p0) { Function.Call(0x725D52F21A5E9E04, p0); }
		public static void COMPENDIUM_GANG_ENCOUNTERED(Any p0) { Function.Call(0x725D52F21A5E9E05, p0); }
		public static void COMPENDIUM_GANG_BOUNTY_CAPTURED(Any p0) { Function.Call(0x725D52F21A5E9E06, p0); }
		public static void COMPENDIUM_GANG_MEMBER_KILLED(Any p0) { Function.Call(0x725D52F21A5E9E07, p0); }
		public static void COMPENDIUM_GANG_HIDEOUT_FOUND(Any p0, Any p1) { Function.Call(0x725D52F21A5E9E08, p0, p1); }
		public static void COMPENDIUM_HERB_PICKED(Hash herbType, float x, float y, float z) { Function.Call(0x725D52F21A5E9E09, herbType, x, y, z); }
		public static void COMPENDIUM_HORSE_BONDING(int ped, int bondingLevel) { Function.Call(0x725D52F21A5E9E50, ped, bondingLevel); }
		public static void COMPENDIUM_HORSE_WILD_BROKEN(Any p0) { Function.Call(0x725852D21A2E9E50, p0); }
		public static void COMPENDIUM_HORSE_OBSERVED(Any p0, Any p1) { Function.Call(0x725D58F2125E5E50, p0, p1); }
	}

	public static class CRASHLOG
	{
		public static void _0x0FD3ECF9D0C8655F(string p0) { Function.Call(0x0FD3ECF9D0C8655F, p0); }
		public static void _0xCA0BAC376C541978(string p0) { Function.Call(0xCA0BAC376C541978, p0); }
		public static BOOL _0x3A66F1963B223F61(string p0) { return Function.Call<BOOL>(0x3A66F1963B223F61, p0); }
		public static BOOL _0x7C680FF55617F82F() { return Function.Call<BOOL>(0x7C680FF55617F82F); }
		public static BOOL _0xD8E3D22AA4F0E0A5(string p0) { return Function.Call<BOOL>(0xD8E3D22AA4F0E0A5, p0); }
		public static BOOL _0xA67F0B039D9CD513(BOOL p0) { return Function.Call<BOOL>(0xA67F0B039D9CD513, p0); }
		public static BOOL _0xE72E234B30DA7B7A(int p0) { return Function.Call<BOOL>(0xE72E234B30DA7B7A, p0); }
		public static BOOL _0x87F005C969EF1563(float p0) { return Function.Call<BOOL>(0x87F005C969EF1563, p0); }
		public static BOOL _0x23CCAB8F40B9CBEE(float x, float y, float z) { return Function.Call<BOOL>(0x23CCAB8F40B9CBEE, x, y, z); }
		public static BOOL _0xF0D545C1EEAD614A() { return Function.Call<BOOL>(0xF0D545C1EEAD614A); }
		public static BOOL _0x33C1D63E55FA4284(string p0) { return Function.Call<BOOL>(0x33C1D63E55FA4284, p0); }
		public static void _0x4E42CA5BCD45444A() { Function.Call(0x4E42CA5BCD45444A); }
		public static void _0xDA05310EA94DC8C6(string p0, string p1) { Function.Call(0xDA05310EA94DC8C6, p0, p1); }
	}

	public static class CREW
	{
		public static BOOL NETWORK_FIND_GAMERS_IN_CREW(int p0) { return Function.Call<BOOL>(0xE532D6811B3A4D2A, p0); }
		public static BOOL NETWORK_CLAN_SERVICE_IS_VALID() { return Function.Call<BOOL>(0x579CCED0265D4896); }
		public static unsafe BOOL NETWORK_CLAN_PLAYER_IS_ACTIVE(Any* gamerHandle) { return Function.Call<BOOL>(0xB124B57F571D8F18, gamerHandle); }
		public static unsafe BOOL NETWORK_CLAN_PLAYER_GET_DESC(Any* clanDesc, int bufferSize, Any* gamerHandle) { return Function.Call<BOOL>(0xEEE6EACBE8874FBA, clanDesc, bufferSize, gamerHandle); }
		public static int NETWORK_CLAN_GET_LOCAL_MEMBERSHIPS_COUNT() { return Function.Call<int>(0x1F471B79ACC90BEF); }
		public static unsafe BOOL NETWORK_CLAN_GET_MEMBERSHIP_DESC(Any* memberDesc, int p1) { return Function.Call<BOOL>(0x48DE78AF2C8885B8, memberDesc, p1); }
		public static BOOL _0x58D378AF2C8765B7(Any p0) { return Function.Call<BOOL>(0x58D378AF2C8765B7, p0); }
		public static BOOL _NETWORK_CLAN_INVITE_PLAYER(Any p0) { return Function.Call<BOOL>(0xC685B014CE3D988B, p0); }
		public static BOOL _NETWORK_ACCEPT_CLAN_INVITE(int p0) { return Function.Call<BOOL>(0x8E2143144B8E188D, p0); }
		public static BOOL NETWORK_CLAN_REQUEST_EMBLEM(Any p0) { return Function.Call<BOOL>(0x13518FF1C6B28938, p0); }
		public static unsafe BOOL NETWORK_CLAN_IS_EMBLEM_READY(Any p0, Any* p1) { return Function.Call<BOOL>(0xA134777FF7F33331, p0, p1); }
		public static void NETWORK_CLAN_RELEASE_EMBLEM(Any p0) { Function.Call(0x113E6E3E50E286B0, p0); }
		public static Any NETWORK_GET_PRIMARY_CLAN_DATA_CLEAR() { return Function.Call<Any>(0x9AA46BADAD0E27ED); }
		public static unsafe BOOL NETWORK_GET_PRIMARY_CLAN_DATA_START(Any* p0, Any p1) { return Function.Call<BOOL>(0xCE86D8191B762107, p0, p1); }
		public static Any NETWORK_GET_PRIMARY_CLAN_DATA_PENDING() { return Function.Call<Any>(0xB5074DB804E28CE7); }
		public static Any NETWORK_GET_PRIMARY_CLAN_DATA_SUCCESS() { return Function.Call<Any>(0x5B4F04F19376A0BA); }
		public static unsafe BOOL NETWORK_GET_PRIMARY_CLAN_DATA_NEW(Any* p0, Any* p1) { return Function.Call<BOOL>(0xC080FF658B2E41DA, p0, p1); }
		public static Any _NETWORK_CLAN_SET_ACTIVE(Any p0) { return Function.Call<Any>(0xC080FF658B2E51DA, p0); }
	}

	public static class DATABINDING
	{
		public static Any _DATABINDING_GET_DATA_CONTAINER_FROM_PATH(string p0) { return Function.Call<Any>(0x0C827D175F1292F2, p0); }
		public static Any _DATABINDING_GET_DATA_CONTAINER_FROM_CHILD_INDEX(Hash entryId, int p1) { return Function.Call<Any>(0x0C827D175F1292F3, entryId, p1); }
		public static Any _0xD7DB94AB78E8EBE4(string p0, Hash p1) { return Function.Call<Any>(0xD7DB94AB78E8EBE4, p0, p1); }
		public static Any _DATABINDING_ADD_DATA_CONTAINER_FROM_PATH(string p0, string p1) { return Function.Call<Any>(0x0C827D175F1292F4, p0, p1); }
		public static Any _DATABINDING_ADD_DATA_CONTAINER_BY_HASH(Any p0, Hash p1) { return Function.Call<Any>(0x98BB14345BB68257, p0, p1); }
		public static Hash _DATABINDING_ADD_DATA_CONTAINER(Hash entryId, string p1) { return Function.Call<Hash>(0xEB4F9A3537EEABCD, entryId, p1); }
		public static Any _DATABINDING_ADD_DATA_BOOL_FROM_PATH(string p0, string p1, BOOL p2) { return Function.Call<Any>(0x37BB86A751148A6A, p0, p1, p2); }
		public static Any _DATABINDING_ADD_DATA_BOOL_BY_HASH(Any p0, Hash p1, BOOL p2) { return Function.Call<Any>(0xBC95D3AE2ECA70D6, p0, p1, p2); }
		public static Any _DATABINDING_ADD_DATA_BOOL(Any p0, string p1, BOOL p2) { return Function.Call<Any>(0x58BAA5F635DA2FF4, p0, p1, p2); }
		public static Any _DATABINDING_ADD_DATA_INT_BY_HASH(Any p0, Hash p1, int p2) { return Function.Call<Any>(0x267F9527F4350ADE, p0, p1, p2); }
		public static Any _DATABINDING_ADD_DATA_INT(Any p0, string p1, Hash p2) { return Function.Call<Any>(0x307A3247C5457BDE, p0, p1, p2); }
		public static Any _DATABINDING_ADD_DATA_FLOAT(Any p0, string p1, float p2) { return Function.Call<Any>(0x5154228273ADB9A6, p0, p1, p2); }
		public static Any _DATABINDING_ADD_DATA_HASH_BY_HASH(Any p0, Hash p1, Hash p2) { return Function.Call<Any>(0x8E173DFB041993C6, p0, p1, p2); }
		public static Any _DATABINDING_ADD_DATA_HASH(Any p0, string p1, Hash p2) { return Function.Call<Any>(0x8538F1205D60ECA6, p0, p1, p2); }
		public static Any _DATABINDING_ADD_DATA_STRING_FROM_PATH(string p0, string p1, string p2) { return Function.Call<Any>(0xA381DE86EE170C4A, p0, p1, p2); }
		public static Any _DATABINDING_ADD_DATA_STRING_BY_HASH(Any p0, Hash p1, string p2) { return Function.Call<Any>(0xEAD09E76E22630C3, p0, p1, p2); }
		public static Any _DATABINDING_ADD_DATA_STRING(Any p0, string p1, string p2) { return Function.Call<Any>(0x617FCA1C5652BBAD, p0, p1, p2); }
		public static Any _DATABINDING_ADD_DATA_GANG_ID(Any p0, string p1, Any gangId) { return Function.Call<Any>(0x7D0F2014DB28DD00, p0, p1, gangId); }
		public static Any _DATABINDING_ADD_DATA_POSSE_ID(Any p0, string p1, Any posseId) { return Function.Call<Any>(0x7D0F2014DB28DD01, p0, p1, posseId); }
		public static Any _0x294AF5323F44B053(Any p0, string p1, Any p2) { return Function.Call<Any>(0x294AF5323F44B053, p0, p1, p2); }
		public static Any _DATABINDING_ADD_UI_ITEM_LIST_FROM_PATH(string p0, string p1) { return Function.Call<Any>(0xDB5B9A474148F699, p0, p1); }
		public static Any _DATABINDING_ADD_UI_ITEM_LIST_BY_HASH(Any p0, Hash p1) { return Function.Call<Any>(0x3C7799283325181B, p0, p1); }
		public static Any _DATABINDING_ADD_UI_ITEM_LIST(Any p0, string p1) { return Function.Call<Any>(0xFE74FA57E0CE6824, p0, p1); }
		public static void _DATABINDING_INSERT_UI_ITEM_TO_LIST_FROM_CONTEXT_STRING_ALIAS(Any p0, int index, string p2, Any p3) { Function.Call(0x5859E970794D92F3, p0, index, p2, p3); }
		public static void _DATABINDING_INSERT_UI_ITEM_TO_LIST_FROM_CONTEXT_HASH_ALIAS(Any p0, int index, Hash p2, Any p3) { Function.Call(0xEE97A05C05F16E41, p0, index, p2, p3); }
		public static void _DATABINDING_INSERT_UI_ITEM_TO_LIST_FROM_PATH_STRING_ALIAS(Any p0, Any p1, string p2, Any p3) { Function.Call(0x5740774F608E4FC8, p0, p1, p2, p3); }
		public static void _0x6318FB3BE37E11B3(Hash entryId, int index) { Function.Call(0x6318FB3BE37E11B3, entryId, index); }
		public static void _DATABINDING_REMOVE_BINDING_ARRAY_ITEM_BY_DATA_CONTEXT_ID(Any p0, Hash entryId) { Function.Call(0xF68B1726EAF7B285, p0, entryId); }
		public static void _DATABINDING_CLEAR_BINDING_ARRAY(Hash entryId) { Function.Call(0xA1F15C1D03DF802D, entryId); }
		public static Any _DATABINDING_GET_ITEM_CONTEXT_BY_INDEX(Any p0, int index) { return Function.Call<Any>(0xE96D7F9FEFCC105F, p0, index); }
		public static void _DATABINDING_SET_TEMPLATED_UI_ITEM_LIST_SIZE(Any p0, int p1) { Function.Call(0xFE74FA57E0CE6825, p0, p1); }
		public static void _DATABINDING_SET_TEMPLATED_UI_ITEM_HASH_ALIAS(Any p0, int p1, Hash p2) { Function.Call(0x0AE7138D0541F2DE, p0, p1, p2); }
		public static Any _0xD48993A61938C64D(Any p0, string p1) { return Function.Call<Any>(0xD48993A61938C64D, p0, p1); }
		public static Any _DATABINDING_ADD_HASH_ARRAY(Any p0, string p1) { return Function.Call<Any>(0x52F5F08278EA5D75, p0, p1); }
		public static Any _DATABINDING_ADD_STRING_ARRAY(Any p0, string p1) { return Function.Call<Any>(0x1B23E0627BDBFE85, p0, p1); }
		public static void _0x1919D59E60FD516E(Any p0, int p1, int p2) { Function.Call(0x1919D59E60FD516E, p0, p1, p2); }
		public static void _0x7FC60C94C83C5CD7(Any p0, Hash p1, int p2) { Function.Call(0x7FC60C94C83C5CD7, p0, p1, p2); }
		public static void _0xC900CEC8A172375B(Any p0, string p1, int p2) { Function.Call(0xC900CEC8A172375B, p0, p1, p2); }
		public static Any _0x02B21B6BEEDD83CC(Hash entryId, int p1) { return Function.Call<Any>(0x02B21B6BEEDD83CC, entryId, p1); }
		public static Any _0xF47E33F8D2523825(Any p0, int p1) { return Function.Call<Any>(0xF47E33F8D2523825, p0, p1); }
		public static void _0x3BF0767CF33FCC88(Hash entryId) { Function.Call(0x3BF0767CF33FCC88, entryId); }
		public static Any _DATABINDING_GET_ARRAY_COUNT(Hash entryId) { return Function.Call<Any>(0xD23F5DE04FE717E2, entryId); }
		public static void _DATABINDING_WRITE_DATA_SCRIPT_VARIABLES(int p0, int p1, params InputArgument[] args) { Function._Call(0xAB888B4B91046771, p0, p1, args); }
		public static void _DATABINDING_WRITE_DATA_BOOL(Any p0, BOOL p1) { Function.Call(0xAB888B4B91046770, p0, p1); }
		public static void _DATABINDING_WRITE_DATA_BOOL_FROM_PARENT(Any p0, string p1, BOOL p2) { Function.Call(0xBDFE546E4C2D0E21, p0, p1, p2); }
		public static void _0xBFC83DA249BEFCC9(Any p0, Hash p1, Any p2) { Function.Call(0xBFC83DA249BEFCC9, p0, p1, p2); }
		public static void _DATABINDING_WRITE_DATA_INT(Any p0, int p1) { Function.Call(0x335C3F6B3766B8D9, p0, p1); }
		public static void _DATABINDING_WRITE_DATA_INT_FROM_PARENT(Any p0, string p1, int p2) { Function.Call(0x9EFA98238BA08FC4, p0, p1, p2); }
		public static void _DATABINDING_WRITE_DATA_INT_FROM_PARENT_BY_HASH(Any p0, Hash p1, Any p2) { Function.Call(0x9D6E10A41D6ED6EC, p0, p1, p2); }
		public static void _DATABINDING_WRITE_DATA_FLOAT(Any p0, float p1) { Function.Call(0xDF504BECEB15DA93, p0, p1); }
		public static void _0x05AC9E1E02975AFB(Any p0, string p1, float p2) { Function.Call(0x05AC9E1E02975AFB, p0, p1, p2); }
		public static void _DATABINDING_WRITE_DATA_HASH_STRING(Any p0, Hash p1) { Function.Call(0xACDEF586BD71B1FD, p0, p1); }
		public static void _DATABINDING_WRITE_DATA_HASH_STRING_FROM_PARENT(Any p0, string p1, Hash p2) { Function.Call(0x0971F04E1EAA7AE8, p0, p1, p2); }
		public static void _DATABINDING_WRITE_DATA_HASH_STRING_FROM_PARENT_BY_HASH(Any p0, Hash p1, Any p2) { Function.Call(0x20209529689E0953, p0, p1, p2); }
		public static void _DATABINDING_WRITE_DATA_STRING(Any p0, string p1) { Function.Call(0xE1BD342F2872AEE9, p0, p1); }
		public static void DATABINDING_WRITE_STRING_FROM_PARENT(Any p0, string p1, string p2) { Function.Call(0x4FF713B2F17A391E, p0, p1, p2); }
		public static void _DATABINDING_WRITE_STRING_FROM_HASH(Any p0, Hash p1, string p2) { Function.Call(0xA3BD6FF95E713EE5, p0, p1, p2); }
		public static void _DATABINDING_WRITE_DATA_GANG_ID(Any p0, string p1, Any gangId) { Function.Call(0xC70041408E16BE2D, p0, p1, gangId); }
		public static void _DATABINDING_WRITE_DATA_POSSE_ID(Any p0, string p1, Any posseId) { Function.Call(0xC70041408E16BE2E, p0, p1, posseId); }
		public static unsafe void _0x422179C7F6AD9304(Any p0, Any* gamerHandle) { Function.Call(0x422179C7F6AD9304, p0, gamerHandle); }
		public static Any _DATABINDING_READ_DATA_BOOL(Any p0) { return Function.Call<Any>(0x5EEFBD4B6D7CD6EB, p0); }
		public static Any _DATABINDING_READ_DATA_BOOL_FROM_PARENT(Any p0, string p1) { return Function.Call<Any>(0xA8EDE09FE07BD77F, p0, p1); }
		public static Any _DATABINDING_READ_DATA_BOOL_FROM_PARENT_BY_HASH(Any p0, Hash p1) { return Function.Call<Any>(0x4CDC3FDDFAE07EB3, p0, p1); }
		public static int DATABINDING_READ_INT(Any p0) { return Function.Call<int>(0x570784D782597512, p0); }
		public static Any _DATABINDING_READ_DATA_INT_FROM_PARENT(Any p0, string p1) { return Function.Call<Any>(0xFFC566A4801F6B40, p0, p1); }
		public static Any _DATABINDING_READ_DATA_INT_FROM_PARENT_BY_HASH(Any p0, Hash p1) { return Function.Call<Any>(0xB5F668B648EC0970, p0, p1); }
		public static float _0x5FE444EB67C70AD4(Hash entryId) { return Function.Call<float>(0x5FE444EB67C70AD4, entryId); }
		public static Hash _0x81D7183E7A8ECA72(Hash entryId) { return Function.Call<Hash>(0x81D7183E7A8ECA72, entryId); }
		public static Any _DATABINDING_READ_DATA_HASH_STRING_FROM_PARENT(Any p0, string p1) { return Function.Call<Any>(0x9B535990B01B62DE, p0, p1); }
		public static Any _DATABINDING_READ_DATA_HASH_STRING_FROM_PARENT_BY_HASH(Any p0, Hash p1) { return Function.Call<Any>(0x1F43BC25A119B252, p0, p1); }
		public static Any _DATABINDING_READ_DATA_STRING(Any p0) { return Function.Call<Any>(0x3D290B5FFA7C5151, p0); }
		public static Any _DATABINDING_READ_DATA_STRING_FROM_PARENT(Any p0, string p1) { return Function.Call<Any>(0x6323AD277C4A2AFB, p0, p1); }
		public static Any _0x6329C34BEE5BFF4B(Any p0, Hash p1) { return Function.Call<Any>(0x6329C34BEE5BFF4B, p0, p1); }
		public static Any _0xE6AAB897120492D6(Any p0, string p1) { return Function.Call<Any>(0xE6AAB897120492D6, p0, p1); }
		public static void _0xE6AAB897120492D7(Any p0, string p1, Any p2) { Function.Call(0xE6AAB897120492D7, p0, p1, p2); }
		public static void _0xB138CA787F3DD858(Any p0, string p1, Any p2) { Function.Call(0xB138CA787F3DD858, p0, p1, p2); }
		public static BOOL DATABINDING_IS_ENTRY_VALID(Hash entryId) { return Function.Call<BOOL>(0x1E7130793AAAAB8D, entryId); }
		public static void _DATABINDING_REMOVE_DATA_ENTRY(Hash entryId) { Function.Call(0x0AE9938D0541F2DA, entryId); }
		public static void _VIRTUAL_COLLECTION_SET_SIZE(Any p0, int size) { Function.Call(0x9DCE9B01A93B58BC, p0, size); }
		public static void _VIRTUAL_COLLECTION_SET_INTEREST_INDEX(Any p0, int interestIndex) { Function.Call(0x49A8447533308BCF, p0, interestIndex); }
		public static void _VIRTUAL_COLLECTION_ITEM_ADD(Any p0, int index, Hash p2, Any p3) { Function.Call(0x6DCBF187221CF73D, p0, index, p2, p3); }
		public static void _VIRTUAL_COLLECTION_RESET(Any p0) { Function.Call(0x09D95666ED2B5F60, p0); }
		public static Any _VIRTUAL_COLLECTION_EXISTS(Any p0) { return Function.Call<Any>(0x37963B56755BFB35, p0); }
	}

	public static class DATAFILE
	{
		public static void DATAFILE_WATCH_REQUEST_ID(int id) { Function.Call(0xA5834834CA8FD7FC, id); }
		public static BOOL DATAFILE_HAS_LOADED_FILE_DATA(Any p0) { return Function.Call<BOOL>(0x17279C820464CEE0, p0); }
		public static BOOL DATAFILE_HAS_VALID_FILE_DATA(Any p0) { return Function.Call<BOOL>(0xE60100389E50EADE, p0); }
		public static BOOL DATAFILE_SELECT_ACTIVE_FILE(Any p0, Any p1) { return Function.Call<BOOL>(0x46102A0989AD80B5, p0, p1); }
		public static BOOL DATAFILE_DELETE_REQUESTED_FILE(Any p0) { return Function.Call<BOOL>(0x604B8ED1A482F9DF, p0); }
		public static Any UGC2_SET_PLAYER_DATA(Any p0, Any p1, Any p2, Any p3) { return Function.Call<Any>(0xE79C70E77E0973C7, p0, p1, p2, p3); }
		public static Any DATAFILE_UGC_SELECT_DATA(Any ugcRequestId, int index, Any p2) { return Function.Call<Any>(0x790EC421078F5C4E, ugcRequestId, index, p2); }
		public static void DATAFILE_CREATE(int index) { Function.Call(0x56B7291FB953DD51, index); }
		public static void DATAFILE_DELETE(int index) { Function.Call(0x9FB90EEDEA9F2D5C, index); }
		public static string DATAFILE_GET_FILE_DICT(int index) { return Function.Call<string>(0xBBD8CF823CAE557C, index); }
		public static BOOL DATADICT_IS_DICT_VALID(Any p0) { return Function.Call<BOOL>(0x4607D57C5F7D332A, p0); }
		public static BOOL DATADICT_IS_ARRAY_VALID(Any p0) { return Function.Call<BOOL>(0xB04B69CF277D15C0, p0); }
		public static unsafe void DATADICT_SET_INT(Any* _objectData, string key, int value) { Function.Call(0x26FDF5E99AA2F3E9, _objectData, key, value); }
		public static unsafe BOOL DATADICT_GET_BOOL(Any* _objectData, string key) { return Function.Call<BOOL>(0x175E915A486EE548, _objectData, key); }
		public static unsafe int DATADICT_GET_INT(Any* _objectData, string key) { return Function.Call<int>(0x9D896A3B87D96E2B, _objectData, key); }
		public static unsafe float DATADICT_GET_FLOAT(Any* _objectData, string key) { return Function.Call<float>(0x814643ECA258ADF5, _objectData, key); }
		public static unsafe string DATADICT_GET_STRING(Any* _objectData, string key) { return Function.Call<string>(0xE37B38C0B4E95DFA, _objectData, key); }
		public static unsafe Vector3 DATADICT_GET_VECTOR(Any* _objectData, string key) { return Function.Call<Vector3>(0xE459C941431E0FFA, _objectData, key); }
		public static unsafe int DATADICT_GET_TYPE(Any* _objectData, string key) { return Function.Call<int>(0x92E11E3CA4C7CDF0, _objectData, key); }
		public static void _0xBC0DF006A4952C68(Any p0, Any p1, Any p2) { Function.Call(0xBC0DF006A4952C68, p0, p1, p2); }
		public static void _0x9F130129EBC31B34(Any p0, Any p1, Any p2) { Function.Call(0x9F130129EBC31B34, p0, p1, p2); }
		public static void _0x277251C161B4C3F4(Any p0, Any p1, Any p2) { Function.Call(0x277251C161B4C3F4, p0, p1, p2); }
		public static void _0x1C65CC931C0F946F(Any p0, Any p1, Any p2) { Function.Call(0x1C65CC931C0F946F, p0, p1, p2); }
		public static void _0x7681B677400C7071(Any p0, Any p1, Any p2, Any p3, Any p4) { Function.Call(0x7681B677400C7071, p0, p1, p2, p3, p4); }
		public static unsafe BOOL DATAARRAY_GET_BOOL(Any* arrayData, int arrayIndex) { return Function.Call<BOOL>(0xAB1231D2DE52F2D3, arrayData, arrayIndex); }
		public static unsafe int DATAARRAY_GET_INT(Any* arrayData, int arrayIndex) { return Function.Call<int>(0x96DEA500B6EBBE53, arrayData, arrayIndex); }
		public static unsafe float DATAARRAY_GET_FLOAT(Any* arrayData, int arrayIndex) { return Function.Call<float>(0xA9D003CF419CB81E, arrayData, arrayIndex); }
		public static unsafe string DATAARRAY_GET_STRING(Any* arrayData, int arrayIndex) { return Function.Call<string>(0xB6790A8FF80F889F, arrayData, arrayIndex); }
		public static unsafe Vector3 DATAARRAY_GET_VECTOR(Any* arrayData, int arrayIndex) { return Function.Call<Vector3>(0x850DA2750DA14E9A, arrayData, arrayIndex); }
		public static unsafe int DATAARRAY_GET_COUNT(Any* arrayData) { return Function.Call<int>(0x6A885BF69239E539, arrayData); }
		public static unsafe int DATAARRAY_GET_TYPE(Any* arrayData, int arrayIndex) { return Function.Call<int>(0x151DAFE6B3B9888F, arrayData, arrayIndex); }
		public static Any _0x4F9E3ED7617123AC(Any p0) { return Function.Call<Any>(0x4F9E3ED7617123AC, p0); }
		public static Any _0xCA56DD6AB7A39F64(Any p0) { return Function.Call<Any>(0xCA56DD6AB7A39F64, p0); }
		public static Any _0xD97D8D905F1562F2(Any p0) { return Function.Call<Any>(0xD97D8D905F1562F2, p0); }
		public static void _PARSEDDATA_UNLOAD_FILE(Any p0) { Function.Call(0x129567F0C05F81B9, p0); }
		public static BOOL PARSEDDATA_IS_FILE_VALID(Any p0) { return Function.Call<BOOL>(0x7907969497EA92F5, p0); }
		public static BOOL PARSEDDATA_IS_FILE_LOADED(Any p0) { return Function.Call<BOOL>(0x603AC35FD4602C76, p0); }
		public static void _0x3168BA5D6DECE323() { Function.Call(0x3168BA5D6DECE323); }
		public static Any _PARSEDDATA_REGISTER_QUERY(Any p0, Any p1, Any p2) { return Function.Call<Any>(0xAE156A747C39A741, p0, p1, p2); }
		public static unsafe BOOL PARSEDDATA_RQ_FILLOUT_NODE(int* p0, Any* p1) { return Function.Call<BOOL>(0x83C3ED532B6E5D07, p0, p1); }
		public static Any _PARSEDDATA_RQ_GET_NUM_NODES(Any p0) { return Function.Call<Any>(0xDF01B1F7A886B42D, p0); }
		public static Any _0xE13634BB6BAF0734(Any p0, Any p1) { return Function.Call<Any>(0xE13634BB6BAF0734, p0, p1); }
		public static Any _PARSEDDATA_GET_NUM_CHILDREN(Any p0, Any p1) { return Function.Call<Any>(0x6BEB168D5195E7AB, p0, p1); }
		public static unsafe BOOL PARSEDDATA_RQ_FILLOUT_HASH(Hash* p0, Any* p1) { return Function.Call<BOOL>(0xFBFF3FF2F5E80C0B, p0, p1); }
		public static unsafe BOOL _PARSEDDATA_RQ_FILLOUT_STRING_63(string p0, Any* p1) { return Function.Call<BOOL>(0x08EAF8E9F2EB7B2E, p0, p1); }
		public static unsafe BOOL PARSEDDATA_RQ_FILLOUT_STRING_127(string p0, Any* p1) { return Function.Call<BOOL>(0x951327435DC5164B, p0, p1); }
		public static unsafe BOOL _PARSEDDATA_RQ_FILLOUT_VECTOR(Vector3* p0, Any* p1) { return Function.Call<BOOL>(0x06FBF89B12DA279C, p0, p1); }
		public static unsafe BOOL _PARSEDDATA_RQ_FILLOUT_FLOAT(float* p0, Any* p1) { return Function.Call<BOOL>(0x7F034FC3E891B57A, p0, p1); }
		public static unsafe BOOL _PARSEDDATA_RQ_FILLOUT_INT(int* p0, Any* p1) { return Function.Call<BOOL>(0xEF44ACC657352A35, p0, p1); }
		public static unsafe BOOL _PARSEDDATA_RQ_FILLOUT_BOOL(BOOL* p0, Any* p1) { return Function.Call<BOOL>(0x0D9138F3F8261DF7, p0, p1); }
		public static unsafe void _PARSEDDATA_GET_FILE(Any* p0) { Function.Call(0x91DED5DD64BB2691, p0); }
		public static unsafe BOOL _PARSEDDATA_GET_ENTRIES(Any* p0) { return Function.Call<BOOL>(0xED4413CEE1BF142C, p0); }
		public static unsafe BOOL _0xB2B42607F7867576(Any* p0, Any* p1, Hash p2) { return Function.Call<BOOL>(0xB2B42607F7867576, p0, p1, p2); }
		public static unsafe BOOL _0x52FC26D2D2FC2987(Any* p0, Any* p1, Hash p2) { return Function.Call<BOOL>(0x52FC26D2D2FC2987, p0, p1, p2); }
		public static unsafe BOOL _PARSEDDATA_GET_SECTION(Any* p0, Any* p1, Hash section) { return Function.Call<BOOL>(0x44B3A36933AC009C, p0, p1, section); }
		public static unsafe BOOL _0xA63CD20F19B961AB(Any* p0, Any* p1, Hash p2) { return Function.Call<BOOL>(0xA63CD20F19B961AB, p0, p1, p2); }
	}

	public static class DEBUG
	{
		public static Any _0xACF9CB705BEFA8CB() { return Function.Call<Any>(0xACF9CB705BEFA8CB); }
		public static Any _0xA8D970D8A72640A6() { return Function.Call<Any>(0xA8D970D8A72640A6); }
		public static string _GET_GAME_BUILD_STRING() { return Function.Call<string>(0x05A5F662AD35C573); }
	}

	public static class DECORATOR
	{
		public static BOOL DECOR_SET_BOOL(int entity, string propertyName, BOOL value) { return Function.Call<BOOL>(0xFE26E4609B1C3772, entity, propertyName, value); }
		public static BOOL DECOR_SET_FLOAT(int entity, string propertyName, float value) { return Function.Call<BOOL>(0x238F8B0C1C7FE834, entity, propertyName, value); }
		public static BOOL DECOR_SET_INT(int entity, string propertyName, int value) { return Function.Call<BOOL>(0xE88F4D7F52A6090F, entity, propertyName, value); }
		public static BOOL _DECOR_SET_UINT8(int entity, string propertyName, int value) { return Function.Call<BOOL>(0x4BDC83150D43772D, entity, propertyName, value); }
		public static BOOL _DECOR_SET_STRING(int entity, string propertyName, string value) { return Function.Call<BOOL>(0x0671C1A3FF7AFDFC, entity, propertyName, value); }
		public static BOOL DECOR_GET_BOOL(int entity, string propertyName) { return Function.Call<BOOL>(0xDEF3F1B071ABB197, entity, propertyName); }
		public static float DECOR_GET_FLOAT(int entity, string propertyName) { return Function.Call<float>(0xE5FF70CD842CA9D4, entity, propertyName); }
		public static int DECOR_GET_INT(int entity, string propertyName) { return Function.Call<int>(0x44DB62727762FD9B, entity, propertyName); }
		public static int _DECOR_GET_UINT8(int entity, string propertyName) { return Function.Call<int>(0xB1682B2443F0540B, entity, propertyName); }
		public static BOOL DECOR_EXIST_ON(int entity, string propertyName) { return Function.Call<BOOL>(0xD9D1CDBF3464DCDF, entity, propertyName); }
		public static BOOL DECOR_REMOVE(int entity, string propertyName) { return Function.Call<BOOL>(0x2BA7F5877A088A1D, entity, propertyName); }
		public static BOOL _DECOR_REMOVE_ALL(int entity) { return Function.Call<BOOL>(0x88942780E0ADEA42, entity); }
		public static void DECOR_REGISTER(string propertyName, int type) { Function.Call(0x0B253D644E3C36B3, propertyName, type); }
		public static void _DECOR_REGISTER_2(string propertyName, int type, BOOL p2) { Function.Call(0x4587374F88B7F6C2, propertyName, type, p2); }
		public static BOOL DECOR_IS_REGISTERED_AS_TYPE(string propertyName, int type) { return Function.Call<BOOL>(0x72355278C069F272, propertyName, type); }
	}

	public static class DLC
	{
		public static BOOL IS_DLC_PRESENT(Hash dlcHash) { return Function.Call<BOOL>(0x2763DC12BBE2BB6F, dlcHash); }
		public static BOOL GET_IS_LOADING_SCREEN_ACTIVE() { return Function.Call<BOOL>(0x71D4BF5890659B0C); }
		public static BOOL _GET_SPECIAL_EDITION_CORE_STATS_BONUS_ENABLED() { return Function.Call<BOOL>(0xA16B4FBA7887D7BA); }
		public static BOOL _GET_SPECIAL_EDITION_CASH_CAMP_BONUS_ENABLED() { return Function.Call<BOOL>(0x1DB9D61E505AE3FC); }
	}

	public static class ENTITY
	{
		public static BOOL DOES_ENTITY_EXIST(int entity) { return Function.Call<BOOL>(0xD42BD6EB2E0F1677, entity); }
		public static BOOL DOES_ENTITY_BELONG_TO_THIS_SCRIPT(int entity, BOOL p1) { return Function.Call<BOOL>(0x622B1980CBE13332, entity, p1); }
		public static BOOL DOES_ENTITY_HAVE_DRAWABLE(int entity) { return Function.Call<BOOL>(0x20487F0DA9AF164A, entity); }
		public static BOOL DOES_ENTITY_HAVE_PHYSICS(int entity) { return Function.Call<BOOL>(0xA512B3F1B2A0B51C, entity); }
		public static BOOL HAS_ENTITY_BEEN_DAMAGED_BY_ANY_OBJECT(int entity) { return Function.Call<BOOL>(0x73BB763880CD23A6, entity); }
		public static BOOL HAS_ENTITY_BEEN_DAMAGED_BY_ANY_PED(int entity) { return Function.Call<BOOL>(0x9934E9C42D52D87E, entity); }
		public static BOOL HAS_ENTITY_BEEN_DAMAGED_BY_ANY_VEHICLE(int entity) { return Function.Call<BOOL>(0x695D7C26DE65C423, entity); }
		public static BOOL HAS_ENTITY_BEEN_DAMAGED_BY_ENTITY(int entity1, int entity2, BOOL p2, BOOL p3) { return Function.Call<BOOL>(0x7B6E7BEC1143AC86, entity1, entity2, p2, p3); }
		public static BOOL _0x3EC28DA1FFAC9DDD(int entity1, int entity2, Any p2, Any p3) { return Function.Call<BOOL>(0x3EC28DA1FFAC9DDD, entity1, entity2, p2, p3); }
		public static int _0xAF72EC7E1B54539B(int entity) { return Function.Call<int>(0xAF72EC7E1B54539B, entity); }
		public static BOOL HAS_ENTITY_CLEAR_LOS_TO_ENTITY(int entity1, int entity2, int traceType) { return Function.Call<BOOL>(0xFCDFF7B72D23A1AC, entity1, entity2, traceType); }
		public static BOOL HAS_ENTITY_CLEAR_LOS_TO_COORD(int entity, float x, float y, float z, int flags) { return Function.Call<BOOL>(0x0C9DBF48C6BA6E4C, entity, x, y, z, flags); }
		public static BOOL HAS_ENTITY_CLEAR_LOS_TO_ENTITY_IN_FRONT(int entity1, int entity2, int traceType) { return Function.Call<BOOL>(0xE88F19660651D566, entity1, entity2, traceType); }
		public static BOOL HAS_ENTITY_COLLIDED_WITH_ANYTHING(int entity) { return Function.Call<BOOL>(0xDF18751EC74F90FF, entity); }
		public static float _0x6D58167F62238284(int vehicle) { return Function.Call<float>(0x6D58167F62238284, vehicle); }
		public static float _0xDFC2B226D56D85F6(Any p0, Any p1) { return Function.Call<float>(0xDFC2B226D56D85F6, p0, p1); }
		public static float GET_ANIM_DURATION(string animDict, string animName) { return Function.Call<float>(0x9FFAF4940A54CC09, animDict, animName); }
		public static int GET_ENTITY_ATTACHED_TO(int entity) { return Function.Call<int>(0x56D713888A566481, entity); }
		public static Vector3 GET_ENTITY_COORDS(int entity, BOOL alive, BOOL realCoords) { return Function.Call<Vector3>(0xA86D5F069399F44D, entity, alive, realCoords); }
		public static Vector3 GET_ENTITY_FORWARD_VECTOR(int entity) { return Function.Call<Vector3>(0x2412D9C05BB09B97, entity); }
		public static float GET_ENTITY_FORWARD_X(int entity) { return Function.Call<float>(0xDB0954E9960F6457, entity); }
		public static float GET_ENTITY_FORWARD_Y(int entity) { return Function.Call<float>(0x9A5C073ECBDA7EE7, entity); }
		public static Vector3 _0x935A30AA88FB1014(Any p0) { return Function.Call<Vector3>(0x935A30AA88FB1014, p0); }
		public static float GET_ENTITY_HEADING(int entity) { return Function.Call<float>(0xC230DD956E2F5507, entity); }
		public static int GET_ENTITY_HEALTH(int entity) { return Function.Call<int>(0x82368787EA73C0F7, entity); }
		public static float _GET_ENTITY_HEALTH_FLOAT(int entity) { return Function.Call<float>(0x96C638784DB4C815, entity); }
		public static BOOL _CHANGE_ENTITY_HEALTH(int entity, float amount, int entity2, Hash weaponHash) { return Function.Call<BOOL>(0x835F131E7DC8F97A, entity, amount, entity2, weaponHash); }
		public static int GET_ENTITY_MAX_HEALTH(int entity, BOOL p1) { return Function.Call<int>(0x15D757606D170C3C, entity, p1); }
		public static void SET_ENTITY_MAX_HEALTH(int entity, int value) { Function.Call(0x166E7CF68597D8B5, entity, value); }
		public static float GET_ENTITY_HEIGHT(int entity, float X, float Y, float Z, BOOL atTop, BOOL inWorldCoords) { return Function.Call<float>(0x296DEBC84474B375, entity, X, Y, Z, atTop, inWorldCoords); }
		public static float GET_ENTITY_HEIGHT_ABOVE_GROUND(int entity) { return Function.Call<float>(0x0D3B5BAEA08F63E9, entity); }
		public static unsafe void _GET_ENTITY_WORLD_POSITION_OF_DIMENSIONS(int entity, Vector3* minimum, Vector3* maximum) { Function.Call(0xF3FDA9A617A15145, entity, minimum, maximum); }
		public static unsafe void GET_ENTITY_MATRIX(int entity, Vector3* rightVector, Vector3* forwardVector, Vector3* upVector, Vector3* position) { Function.Call(0x3A9B1120AF13FBF2, entity, rightVector, forwardVector, upVector, position); }
		public static Hash GET_ENTITY_MODEL(int entity) { return Function.Call<Hash>(0xDA76A9F39210D365, entity); }
		public static Hash _GET_PED_ANIMAL_TYPE(int ped) { return Function.Call<Hash>(0x964000D355219FC0, ped); }
		public static BOOL GET_IS_ANIMAL(int entity) { return Function.Call<BOOL>(0x9A100F1CF4546629, entity); }
		public static BOOL _GET_IS_BIRD(int entity) { return Function.Call<BOOL>(0xC346A546612C49A9, entity); }
		public static BOOL _GET_IS_PREDATOR(int entity) { return Function.Call<BOOL>(0x5594AFE9DE0C01B7, entity); }
		public static Vector3 GET_OFFSET_FROM_ENTITY_GIVEN_WORLD_COORDS(int entity, float posX, float posY, float posZ) { return Function.Call<Vector3>(0x497C6B1A2C9AE69C, entity, posX, posY, posZ); }
		public static Vector3 GET_OFFSET_FROM_ENTITY_IN_WORLD_COORDS(int entity, float offsetX, float offsetY, float offsetZ) { return Function.Call<Vector3>(0x1899F328B0E12848, entity, offsetX, offsetY, offsetZ); }
		public static float GET_ENTITY_PITCH(int entity) { return Function.Call<float>(0xEF355ABEFF7F5005, entity); }
		public static float GET_ENTITY_ROLL(int entity) { return Function.Call<float>(0xBF966536FA8B6879, entity); }
		public static Vector3 GET_ENTITY_ROTATION(int entity, int rotationOrder) { return Function.Call<Vector3>(0xE09CAF86C32CB48F, entity, rotationOrder); }
		public static unsafe Hash _GET_ENTITY_SCRIPT(int entity, Any* argStruct) { return Function.Call<Hash>(0x2A08A32B6D49906F, entity, argStruct); }
		public static float GET_ENTITY_SPEED(int entity) { return Function.Call<float>(0xFB6BA510A533DF81, entity); }
		public static Vector3 GET_ENTITY_SPEED_VECTOR(int entity, BOOL relative) { return Function.Call<Vector3>(0xF2DB09816A419DC5, entity, relative); }
		public static float GET_ENTITY_UPRIGHT_VALUE(int entity) { return Function.Call<float>(0x56398BE65160C3BE, entity); }
		public static Vector3 GET_ENTITY_VELOCITY(int entity, int p1) { return Function.Call<Vector3>(0x4805D2B1D8CF94A9, entity, p1); }
		public static Object GET_OBJECT_INDEX_FROM_ENTITY_INDEX(int entity) { return Function.Call<Object>(0x280BBE5601EAA983, entity); }
		public static int GET_PED_INDEX_FROM_ENTITY_INDEX(int entity) { return Function.Call<int>(0x0F16D042BD640EA3, entity); }
		public static int GET_VEHICLE_INDEX_FROM_ENTITY_INDEX(int entity) { return Function.Call<int>(0xDF1E5AAC561AFC59, entity); }
		public static Vector3 GET_WORLD_POSITION_OF_ENTITY_BONE(int entity, int boneIndex) { return Function.Call<Vector3>(0x82CFA50E34681CA5, entity, boneIndex); }
		public static Vector3 _0x5E214112806591EA(int entity, int boneIndex) { return Function.Call<Vector3>(0x5E214112806591EA, entity, boneIndex); }
		public static Vector3 _0x3AB3A77672F6473F(Any p0, Any p1, Any p2, Any p3) { return Function.Call<Vector3>(0x3AB3A77672F6473F, p0, p1, p2, p3); }
		public static int GET_NEAREST_PLAYER_TO_ENTITY(int entity, int playerPedToIgnore, int flags) { return Function.Call<int>(0x990E294FC387FB88, entity, playerPedToIgnore, flags); }
		public static int GET_NEAREST_PLAYER_TO_ENTITY_ON_TEAM(int entity, int team, int playerPedToIgnore, int flags) { return Function.Call<int>(0xB2C30C3B4AFF718C, entity, team, playerPedToIgnore, flags); }
		public static int _GET_NEAREST_PARTICIPANT_TO_ENTITY(int entity) { return Function.Call<int>(0x6888A43C35A5F630, entity); }
		public static BOOL PLACE_ENTITY_ON_GROUND_PROPERLY(int entity, BOOL p1) { return Function.Call<BOOL>(0x9587913B9E772D29, entity, p1); }
		public static int GET_ENTITY_TYPE(int entity) { return Function.Call<int>(0x97F696ACA466B4E0, entity); }
		public static int GET_ENTITY_POPULATION_TYPE(int entity) { return Function.Call<int>(0xADE28862B6D7B85B, entity); }
		public static BOOL IS_AN_ENTITY(ScrHandle handle) { return Function.Call<BOOL>(0x27CFF3E5A286D3DF, handle); }
		public static BOOL IS_ENTITY_A_PED(int entity) { return Function.Call<BOOL>(0xCF8176912DDA4EA5, entity); }
		public static BOOL IS_ENTITY_A_MISSION_ENTITY(int entity) { return Function.Call<BOOL>(0x138190F64DB4BBD1, entity); }
		public static BOOL IS_ENTITY_A_VEHICLE(int entity) { return Function.Call<BOOL>(0xC3D96AF45FCCEC4C, entity); }
		public static BOOL IS_ENTITY_AN_OBJECT(int entity) { return Function.Call<BOOL>(0x0A27A546A375FDEF, entity); }
		public static BOOL IS_ENTITY_AT_COORD(int entity, float xPos, float yPos, float zPos, float xSize, float ySize, float zSize, BOOL p7, BOOL p8, int p9) { return Function.Call<BOOL>(0x5E58342602E94718, entity, xPos, yPos, zPos, xSize, ySize, zSize, p7, p8, p9); }
		public static BOOL IS_ENTITY_AT_ENTITY(int entity1, int entity2, float xSize, float ySize, float zSize, BOOL p5, BOOL p6, int p7) { return Function.Call<BOOL>(0xC057F02B837A27F6, entity1, entity2, xSize, ySize, zSize, p5, p6, p7); }
		public static BOOL IS_ENTITY_ATTACHED(int entity) { return Function.Call<BOOL>(0xEE6AD63ABF59C0B7, entity); }
		public static BOOL IS_ENTITY_ATTACHED_TO_ANY_OBJECT(int entity) { return Function.Call<BOOL>(0x306C1F6178F01AB3, entity); }
		public static BOOL IS_ENTITY_ATTACHED_TO_ANY_PED(int entity) { return Function.Call<BOOL>(0xC841153DED2CA89A, entity); }
		public static BOOL IS_ENTITY_ATTACHED_TO_ANY_VEHICLE(int entity) { return Function.Call<BOOL>(0x12DF6E0D2E736749, entity); }
		public static BOOL IS_ENTITY_ATTACHED_TO_ENTITY(int from, int to) { return Function.Call<BOOL>(0x154A3C529497053E, from, to); }
		public static BOOL _IS_ENTITY_OWNED_BY_PERSISTENCE_SYSTEM(int entity) { return Function.Call<BOOL>(0xA7E51B53309EAC97, entity); }
		public static BOOL IS_ENTITY_DEAD(int entity) { return Function.Call<BOOL>(0x7D5B1F88E7504BBA, entity); }
		public static BOOL IS_ENTITY_IN_AIR(int entity, Any p1) { return Function.Call<BOOL>(0x886E37EC497200B6, entity, p1); }
		public static BOOL IS_ENTITY_IN_ANGLED_AREA(int entity, float originX, float originY, float originZ, float edgeX, float edgeY, float edgeZ, float angle, BOOL p8, BOOL p9, Any p10) { return Function.Call<BOOL>(0xD3151E53134595E5, entity, originX, originY, originZ, edgeX, edgeY, edgeZ, angle, p8, p9, p10); }
		public static BOOL IS_ENTITY_IN_AREA(int entity, float x1, float y1, float z1, float x2, float y2, float z2, BOOL p7, BOOL p8, Any p9) { return Function.Call<BOOL>(0x0C2634C40A16193E, entity, x1, y1, z1, x2, y2, z2, p7, p8, p9); }
		public static BOOL IS_ENTITY_IN_VOLUME(int entity, ScrHandle volume, BOOL p2, int p3) { return Function.Call<BOOL>(0x5A5526BC09C06623, entity, volume, p2, p3); }
		public static BOOL IS_ENTITY_IN_WATER(int entity) { return Function.Call<BOOL>(0xDDE5C125AC446723, entity); }
		public static BOOL _IS_ENTITY_UNDERWATER(int entity, BOOL p1) { return Function.Call<BOOL>(0xD4E5C1E93C466127, entity, p1); }
		public static float GET_ENTITY_SUBMERGED_LEVEL(int entity) { return Function.Call<float>(0x4A77C3F73FD9E831, entity); }
		public static void _0x850C940EE3E7B8B5(int entity, BOOL toggle) { Function.Call(0x850C940EE3E7B8B5, entity, toggle); }
		public static void _0x7A49D40DE437BC8D(Any p0, Any p1) { Function.Call(0x7A49D40DE437BC8D, p0, p1); }
		public static void _0x978AA2323ED32209(Any p0, Any p1) { Function.Call(0x978AA2323ED32209, p0, p1); }
		public static void _0x002AAC783ED323ED(Any p0, Any p1) { Function.Call(0x002AAC783ED323ED, p0, p1); }
		public static void _0x007AAC783ED323ED(Any p0, Any p1, Any p2) { Function.Call(0x007AAC783ED323ED, p0, p1, p2); }
		public static BOOL IS_ENTITY_ON_SCREEN(int entity) { return Function.Call<BOOL>(0x613C15D5D8DB781F, entity); }
		public static BOOL IS_ENTITY_PLAYING_ANIM(int entity, string animDict, string animName, int taskFlag) { return Function.Call<BOOL>(0xDEE49D5CA6C49148, entity, animDict, animName, taskFlag); }
		public static Any _0x0B7CB1300CBFE19C(Any p0, Any p1) { return Function.Call<Any>(0x0B7CB1300CBFE19C, p0, p1); }
		public static BOOL IS_ENTITY_STATIC(int entity) { return Function.Call<BOOL>(0x86468ADFA0F6B861, entity); }
		public static BOOL IS_ENTITY_TOUCHING_ENTITY(int entity, int targetEntity) { return Function.Call<BOOL>(0x9A2304A64C3C8423, entity, targetEntity); }
		public static BOOL IS_ENTITY_TOUCHING_MODEL(int entity, Hash modelHash) { return Function.Call<BOOL>(0x2AE3EBC8DEB9768B, entity, modelHash); }
		public static BOOL IS_ENTITY_UPRIGHT(int entity, float angle) { return Function.Call<BOOL>(0xF6F6AFD8D4FB2658, entity, angle); }
		public static BOOL IS_ENTITY_UPSIDEDOWN(int entity) { return Function.Call<BOOL>(0x109DE3DA41AAD94A, entity); }
		public static BOOL IS_ENTITY_VISIBLE(int entity) { return Function.Call<BOOL>(0xFFC96ECB7FA404CA, entity); }
		public static void _0xFF9965C47FA404DA(int entity, BOOL toggle) { Function.Call(0xFF9965C47FA404DA, entity, toggle); }
		public static BOOL IS_ENTITY_VISIBLE_TO_SCRIPT(int entity) { return Function.Call<BOOL>(0xF213C724E77F321A, entity); }
		public static void _0x3F08C6163A4AB1D6(Any p0) { Function.Call(0x3F08C6163A4AB1D6, p0); }
		public static void _0x0DB41D59E0F1502B(Any p0) { Function.Call(0x0DB41D59E0F1502B, p0); }
		public static BOOL _IS_TRACKED_ENTITY_VISIBLE(int entity) { return Function.Call<BOOL>(0xC8CCDB712FBCBA92, entity); }
		public static BOOL IS_ENTITY_OCCLUDED(int entity) { return Function.Call<BOOL>(0x140188E884645624, entity); }
		public static BOOL WOULD_ENTITY_BE_OCCLUDED(Hash entityModelHash, float x, float y, float z, BOOL p4) { return Function.Call<BOOL>(0x3546FAB293FF2981, entityModelHash, x, y, z, p4); }
		public static BOOL IS_ENTITY_WAITING_FOR_WORLD_COLLISION(int entity) { return Function.Call<BOOL>(0x5E1CC2E8DC3111DD, entity); }
		public static BOOL _IS_ENTITY_ON_TRAIN_TRACK(int entity) { return Function.Call<BOOL>(0x857ACB0AB4BD0D55, entity); }
		public static void _0xCDB682BB47C02F0A(int entity, Hash p1) { Function.Call(0xCDB682BB47C02F0A, entity, p1); }
		public static void _0xE19035EB65AB2932(Any p0, Any p1) { Function.Call(0xE19035EB65AB2932, p0, p1); }
		public static BOOL _0x8C03CD6B5E0E85E8(int entity, Hash lootTable) { return Function.Call<BOOL>(0x8C03CD6B5E0E85E8, entity, lootTable); }
		public static unsafe BOOL _0x1E804EA9B12030A4(int entity, Hash* p1) { return Function.Call<BOOL>(0x1E804EA9B12030A4, entity, p1); }
		public static unsafe BOOL _0xA88E215CEB0435C0(int mount, Any* argStruct, Hash p2, int p3, int p4, BOOL p5) { return Function.Call<BOOL>(0xA88E215CEB0435C0, mount, argStruct, p2, p3, p4, p5); }
		public static Any _0xE31FC20319874CB3(Any p0, Any p1, Any p2) { return Function.Call<Any>(0xE31FC20319874CB3, p0, p1, p2); }
		public static Any _0x582F73ACFE969571(Any p0, Any p1, Any p2) { return Function.Call<Any>(0x582F73ACFE969571, p0, p1, p2); }
		public static Any _0xBA2A089E60ED1163(Any p0, Any p1, Any p2, Any p3, Any p4) { return Function.Call<Any>(0xBA2A089E60ED1163, p0, p1, p2, p3, p4); }
		public static int GET_CARRIABLE_ENTITY_STATE(int entity) { return Function.Call<int>(0x61914209C36EFDDB, entity); }
		public static Any _0xD46BF94C4C66FAB0(Any p0, Any p1, Any p2, Any p3) { return Function.Call<Any>(0xD46BF94C4C66FAB0, p0, p1, p2, p3); }
		public static Hash _GET_OPTIMAL_CARRY_CONFIG(int entity, int index) { return Function.Call<Hash>(0x34F008A7E48C496B, entity, index); }
		public static Any _0xD21C7418C590BB40(Any p0) { return Function.Call<Any>(0xD21C7418C590BB40, p0); }
		public static Hash _GET_ENTITY_CARRY_CONFIG(int entity) { return Function.Call<Hash>(0x0FD25587BB306C86, entity); }
		public static BOOL _0x5AFFA9DDC87846F8(Hash model) { return Function.Call<BOOL>(0x5AFFA9DDC87846F8, model); }
		public static Hash _GET_CARRIABLE_FROM_ENTITY(int entity) { return Function.Call<Hash>(0x31FEF6A20F00B963, entity); }
		public static void _SET_ENTITY_CARCASS_TYPE(int entity, Hash type) { Function.Call(0x399657ED871B3A6C, entity, type); }
		public static Any _0x2A77EF9BEC8518F4(Any p0) { return Function.Call<Any>(0x2A77EF9BEC8518F4, p0); }
		public static unsafe void _DELETE_CARRIABLE(int* entity) { Function.Call(0x0D0DB2B6AF19A987, entity); }
		public static BOOL _IS_ENTITY_FULLY_LOOTED(int entity) { return Function.Call<BOOL>(0x8DE41E9902E85756, entity); }
		public static void _0x6BCF5F3D8FFE988D(int entity, BOOL p1) { Function.Call(0x6BCF5F3D8FFE988D, entity, p1); }
		public static Any _0xEF2D9ED7CE684F08(Any p0) { return Function.Call<Any>(0xEF2D9ED7CE684F08, p0); }
		public static Any _0x0CCEFC6C2C95DA2A(Any p0, Any p1, Any p2, Any p3) { return Function.Call<Any>(0x0CCEFC6C2C95DA2A, p0, p1, p2, p3); }
		public static Any _0x383F64263F946E45(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5) { return Function.Call<Any>(0x383F64263F946E45, p0, p1, p2, p3, p4, p5); }
		public static Any _0x8E10DF0FFA63FB65(Any p0, Any p1, Any p2, Any p3, Any p4) { return Function.Call<Any>(0x8E10DF0FFA63FB65, p0, p1, p2, p3, p4); }
		public static BOOL _GET_ENTITY_CARRYING_FLAG(int entity, int flagId) { return Function.Call<BOOL>(0x808077647856DE62, entity, flagId); }
		public static void _SET_ENTITY_CARRYING_FLAG(int entity, int flagId, BOOL value) { Function.Call(0x18FF3110CF47115D, entity, flagId, value); }
		public static void _0xC3ABCFBC7D74AFA5(Any p0, Any p1, Any p2) { Function.Call(0xC3ABCFBC7D74AFA5, p0, p1, p2); }
		public static void _0x371D179701D9C082(int entity) { Function.Call(0x371D179701D9C082, entity); }
		public static void _0xA48E4801DEBDF7E4(int entity, BOOL p1) { Function.Call(0xA48E4801DEBDF7E4, entity, p1); }
		public static BOOL _GET_IS_CARRIABLE_PELT(int entity) { return Function.Call<BOOL>(0x255B6DB4E3AD3C3E, entity); }
		public static Any _0xF59FDE7B4D31A630(Any p0) { return Function.Call<Any>(0xF59FDE7B4D31A630, p0); }
		public static Any _0x120376C23F019C6C(Any p0, Any p1) { return Function.Call<Any>(0x120376C23F019C6C, p0, p1); }
		public static Any _0x5744562E973E33CD(Any p0, Any p1, Any p2, Any p3, Any p4) { return Function.Call<Any>(0x5744562E973E33CD, p0, p1, p2, p3, p4); }
		public static void _0xDD03FC2089AD093C(Any p0, Any p1, Any p2, Any p3) { Function.Call(0xDD03FC2089AD093C, p0, p1, p2, p3); }
		public static Any _0xB16C780C51E51E2B(Any p0) { return Function.Call<Any>(0xB16C780C51E51E2B, p0); }
		public static void _0xEF259AA1E097E0AD(int entity, Any p1) { Function.Call(0xEF259AA1E097E0AD, entity, p1); }
		public static void _0xBD94CECFB2D65119(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5) { Function.Call(0xBD94CECFB2D65119, p0, p1, p2, p3, p4, p5); }
		public static void _SET_ENTITY_CUSTOM_PICKUP_RADIUS(int entity, float radius) { Function.Call(0x482D17E45665DA44, entity, radius); }
		public static void _0xE75EEA8DB59A9F39(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5) { Function.Call(0xE75EEA8DB59A9F39, p0, p1, p2, p3, p4, p5); }
		public static Any _0x188736456D1DEDE6(Any p0, Any p1) { return Function.Call<Any>(0x188736456D1DEDE6, p0, p1); }
		public static void _0xC6A1A3D63F122DE7(Any p0, Any p1) { Function.Call(0xC6A1A3D63F122DE7, p0, p1); }
		public static void APPLY_FORCE_TO_ENTITY_CENTER_OF_MASS(int entity, int forceType, float x, float y, float z, BOOL p5, BOOL isDirectionRel, BOOL isForceRel, BOOL p8) { Function.Call(0x31DA7CEC5334DB37, entity, forceType, x, y, z, p5, isDirectionRel, isForceRel, p8); }
		public static void APPLY_FORCE_TO_ENTITY(int entity, int forceFlags, float x, float y, float z, float offX, float offY, float offZ, int boneIndex, BOOL isDirectionRel, BOOL ignoreUpVec, BOOL isForceRel, BOOL p12, BOOL p13) { Function.Call(0xF15E8F5D333F09C4, entity, forceFlags, x, y, z, offX, offY, offZ, boneIndex, isDirectionRel, ignoreUpVec, isForceRel, p12, p13); }
		public static void ATTACH_ENTITY_TO_ENTITY(int entity1, int entity2, int boneIndex, float xPos, float yPos, float zPos, float xRot, float yRot, float zRot, BOOL p9, BOOL useSoftPinning, BOOL collision, BOOL isPed, int vertexIndex, BOOL fixedRot, BOOL p15, BOOL p16) { Function.Call(0x6B9BBD38AB0796DF, entity1, entity2, boneIndex, xPos, yPos, zPos, xRot, yRot, zRot, p9, useSoftPinning, collision, isPed, vertexIndex, fixedRot, p15, p16); }
		public static void ATTACH_ENTITY_TO_ENTITY_PHYSICALLY(int entity1, int entity2, int p2, int boneIndex, float offsetX, float offsetY, float offsetZ, float p7, float p8, float p9, float p10, float p11, float p12, float p13, BOOL p14, BOOL p15, BOOL p16, BOOL p17, int p18, BOOL p19, float p20, float p21) { Function.Call(0xB629A43CA1643481, entity1, entity2, p2, boneIndex, offsetX, offsetY, offsetZ, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21); }
		public static void _0x445D7D8EA66E373E(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8, Any p9, Any p10, Any p11, Any p12, Any p13, Any p14, Any p15) { Function.Call(0x445D7D8EA66E373E, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15); }
		public static void _0x16908E859C3AB698(Any p0, Any p1, Any p2, Any p3, Any p4) { Function.Call(0x16908E859C3AB698, p0, p1, p2, p3, p4); }
		public static int GET_ENTITY_BONE_INDEX_BY_NAME(int entity, string boneName) { return Function.Call<int>(0xBACA8FE9C76C124E, entity, boneName); }
		public static void CLEAR_ENTITY_LAST_DAMAGE_ENTITY(int entity) { Function.Call(0xBB19AC7D4DCEFD0F, entity); }
		public static unsafe void DELETE_ENTITY(int* entity) { Function.Call(0x4CD38C78BD19A497, entity); }
		public static unsafe void _DELETE_ENTITY_2(int* entity) { Function.Call(0x5E94EA09E7207C16, entity); }
		public static void DETACH_ENTITY(int entity, BOOL p1, BOOL collision) { Function.Call(0x64CDE9D6BF8ECAD3, entity, p1, collision); }
		public static BOOL _IS_ENTITY_FROZEN(int entity) { return Function.Call<BOOL>(0x083D497D57B7400F, entity); }
		public static void FREEZE_ENTITY_POSITION(int entity, BOOL toggle) { Function.Call(0x7D9EFB7AD6B19754, entity, toggle); }
		public static void _SET_ENTITY_CLEANUP_BY_ENGINE(int entity, BOOL toggle) { Function.Call(0x740CB4F3F602C9F4, entity, toggle); }
		public static void SET_ENTITY_AS_MISSION_ENTITY(int entity, BOOL p1, BOOL p2) { Function.Call(0xDC19C288082E586E, entity, p1, p2); }
		public static unsafe void SET_ENTITY_AS_NO_LONGER_NEEDED(int* entity) { Function.Call(0x4971D2F8162B9674, entity); }
		public static unsafe void SET_PED_AS_NO_LONGER_NEEDED(int* ped) { Function.Call(0x2595DD4236549CE3, ped); }
		public static unsafe void SET_VEHICLE_AS_NO_LONGER_NEEDED(int* vehicle) { Function.Call(0x629BFA74418D6239, vehicle); }
		public static unsafe void SET_OBJECT_AS_NO_LONGER_NEEDED(Object* _object) { Function.Call(0x3AE22DEB5BA5A3E6, _object); }
		public static void _0x20FAEE47427A4497() { Function.Call(0x20FAEE47427A4497); }
		public static BOOL _DOES_THREAD_OWN_THIS_ENTITY(int entity) { return Function.Call<BOOL>(0x88AD6CC10D8D35B2, entity); }
		public static void _0x56E0735D6273B227(Any p0, Any p1) { Function.Call(0x56E0735D6273B227, p0, p1); }
		public static void _0xC0EDEF16D90661EE(int entity, float p1) { Function.Call(0xC0EDEF16D90661EE, entity, p1); }
		public static void _0x0FD7D7C232876E72(Any p0) { Function.Call(0x0FD7D7C232876E72, p0); }
		public static void _0x0939E773925C4719() { Function.Call(0x0939E773925C4719); }
		public static void SET_ENTITY_CAN_BE_DAMAGED(int entity, BOOL toggle) { Function.Call(0x0D06D522B90E861F, entity, toggle); }
		public static BOOL _GET_ENTITY_CAN_BE_DAMAGED(int entity) { return Function.Call<BOOL>(0x75DF9E73F2F005FD, entity); }
		public static void SET_ENTITY_CAN_BE_DAMAGED_BY_RELATIONSHIP_GROUP(int entity, BOOL bCanBeDamaged, Hash relGroup) { Function.Call(0x0EF1AFB18649E015, entity, bCanBeDamaged, relGroup); }
		public static void _0xFF83AF534156B399(Any p0, Any p1) { Function.Call(0xFF83AF534156B399, p0, p1); }
		public static void SET_ENTITY_CAN_BE_TARGETED_WITHOUT_LOS(int entity, BOOL toggle) { Function.Call(0x6D09F32E284D0FB7, entity, toggle); }
		public static BOOL GET_ENTITY_COLLISION_DISABLED(int entity) { return Function.Call<BOOL>(0xAA2FADD30F45A9DA, entity); }
		public static void SET_ENTITY_COLLISION(int entity, BOOL toggle, BOOL keepPhysics) { Function.Call(0xF66F820909453B8C, entity, toggle, keepPhysics); }
		public static void SET_ENTITY_COMPLETELY_DISABLE_COLLISION(int entity, BOOL toggle, BOOL keepPhysics) { Function.Call(0xE0580EC84813875A, entity, toggle, keepPhysics); }
		public static void SET_ENTITY_COORDS(int entity, float xPos, float yPos, float zPos, BOOL xAxis, BOOL yAxis, BOOL zAxis, BOOL clearArea) { Function.Call(0x06843DA7060A026B, entity, xPos, yPos, zPos, xAxis, yAxis, zAxis, clearArea); }
		public static void SET_ENTITY_COORDS_NO_OFFSET(int entity, float xPos, float yPos, float zPos, BOOL xAxis, BOOL yAxis, BOOL zAxis) { Function.Call(0x239A3351AC1DA385, entity, xPos, yPos, zPos, xAxis, yAxis, zAxis); }
		public static void SET_ENTITY_DYNAMIC(int entity, BOOL toggle) { Function.Call(0xFBFC4473F66CE344, entity, toggle); }
		public static void SET_ENTITY_HEADING(int entity, float heading) { Function.Call(0xCF2B9C0645C4651B, entity, heading); }
		public static void _SET_ENTITY_COORDS_AND_HEADING(int entity, float xPos, float yPos, float zPos, float heading, BOOL xAxis, BOOL yAxis, BOOL zAxis) { Function.Call(0x203BEFFDBE12E96A, entity, xPos, yPos, zPos, heading, xAxis, yAxis, zAxis); }
		public static void _SET_ENTITY_COORDS_AND_HEADING_NO_OFFSET(int entity, float xPos, float yPos, float zPos, float heading, BOOL p5, BOOL p6) { Function.Call(0x0918E3565C20F03C, entity, xPos, yPos, zPos, heading, p5, p6); }
		public static void SET_ENTITY_HEALTH(int entity, int healthAmount, int entityKilledBy) { Function.Call(0xAC2767ED8BDFAB15, entity, healthAmount, entityKilledBy); }
		public static void SET_ENTITY_INVINCIBLE(int entity, BOOL toggle) { Function.Call(0xA5C38736C426FCB8, entity, toggle); }
		public static void _0xAF7F3099B9FEB535(int entity, float p1, float p2, float p3) { Function.Call(0xAF7F3099B9FEB535, entity, p1, p2, p3); }
		public static void SET_ENTITY_IS_TARGET_PRIORITY(int entity, BOOL p1, float p2) { Function.Call(0x0A5D170C44CB2189, entity, p1, p2); }
		public static void _0xB38A29CCD5447783(Any p0, Any p1, Any p2) { Function.Call(0xB38A29CCD5447783, p0, p1, p2); }
		public static void _SET_ENTITY_THREAT_TIER(int entity, int tier, BOOL p2) { Function.Call(0x4B436BAC8CBE9B07, entity, tier, p2); }
		public static int _GET_ENTITY_THREAT_TIER(int entity) { return Function.Call<int>(0xE12F56CB25D9CE23, entity); }
		public static void _0x2D40BCBFE9305DEA(Any p0, Any p1) { Function.Call(0x2D40BCBFE9305DEA, p0, p1); }
		public static void _SET_ENTITY_LIGHTS_ENABLED(int entity, BOOL enabled) { Function.Call(0xEBDC12861D079ABA, entity, enabled); }
		public static void SET_ENTITY_LOAD_COLLISION_FLAG(int entity, BOOL toggle) { Function.Call(0x9B9EE31AED48072E, entity, toggle); }
		public static BOOL HAS_COLLISION_LOADED_AROUND_ENTITY(int entity) { return Function.Call<BOOL>(0xBEB1600952B9CF5C, entity); }
		public static BOOL HAS_COLLISION_LOADED_AROUND_POSITION(float xPos, float yPos, float zPos) { return Function.Call<BOOL>(0x6BFBDC46139C45AB, xPos, yPos, zPos); }
		public static void SET_ENTITY_ONLY_DAMAGED_BY_PLAYER(int entity, BOOL toggle) { Function.Call(0x473598683095D430, entity, toggle); }
		public static void SET_ENTITY_ONLY_DAMAGED_BY_RELATIONSHIP_GROUP(int entity, BOOL p1, Hash relationshipGroup) { Function.Call(0x6C1F6AA2F0ADD104, entity, p1, relationshipGroup); }
		public static void SET_ENTITY_PROOFS(int entity, int proofsBitset, BOOL specialFlag) { Function.Call(0xFAEE099C6F890BB8, entity, proofsBitset, specialFlag); }
		public static int _GET_ENTITY_PROOFS(int entity) { return Function.Call<int>(0x6CF0DAD7FA1088EA, entity); }
		public static void SET_ENTITY_QUATERNION(int entity, float x, float y, float z, float w) { Function.Call(0x100E7007D13E3687, entity, x, y, z, w); }
		public static void SET_ENTITY_ROTATION(int entity, float pitch, float roll, float yaw, int rotationOrder, BOOL p5) { Function.Call(0x9CC8314DFEDE441E, entity, pitch, roll, yaw, rotationOrder, p5); }
		public static void _0xD45BB89B53FC0CFD(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7) { Function.Call(0xD45BB89B53FC0CFD, p0, p1, p2, p3, p4, p5, p6, p7); }
		public static void SET_ENTITY_VISIBLE(int entity, BOOL toggle) { Function.Call(0x1794B4FCC84D812F, entity, toggle); }
		public static void _0x80FDEB3A9E9AA578(int entity, BOOL p1) { Function.Call(0x80FDEB3A9E9AA578, entity, p1); }
		public static void _0x9C6906EF8CB20C5F(int entity) { Function.Call(0x9C6906EF8CB20C5F, entity); }
		public static void SET_ENTITY_VELOCITY(int entity, float x, float y, float z) { Function.Call(0x1C99BB7B6E96D16F, entity, x, y, z); }
		public static void SET_ENTITY_HAS_GRAVITY(int entity, BOOL toggle) { Function.Call(0x0CEDB728A1083FA7, entity, toggle); }
		public static void SET_ENTITY_LOD_DIST(int entity, int value) { Function.Call(0x5FB407F0A7C877BF, entity, value); }
		public static int GET_ENTITY_LOD_DIST(int entity) { return Function.Call<int>(0xDF240D0C2A948683, entity); }
		public static void SET_ENTITY_ALPHA(int entity, int alphaLevel, BOOL skin) { Function.Call(0x0DF7692B1D9E7BA7, entity, alphaLevel, skin); }
		public static int GET_ENTITY_ALPHA(int entity) { return Function.Call<int>(0x1BB501624FAF2BEA, entity); }
		public static void RESET_ENTITY_ALPHA(int entity) { Function.Call(0x744B9EF44779D9AB, entity); }
		public static void _SET_ENTITY_FADE_IN(int entity) { Function.Call(0xA91E6CF94404E8C9, entity); }
		public static void SET_ENTITY_ALWAYS_PRERENDER(int entity, BOOL toggle) { Function.Call(0xACAD101E1FB66689, entity, toggle); }
		public static void SET_ENTITY_RENDER_SCORCHED(int entity, BOOL toggle) { Function.Call(0x85B8A7534E44BC23, entity, toggle); }
		public static Any _0x37B01666BAE8F7EF(int entity) { return Function.Call<Any>(0x37B01666BAE8F7EF, entity); }
		public static void _0xA9E6D8F2DDFC4DB9(Any p0, Any p1) { Function.Call(0xA9E6D8F2DDFC4DB9, p0, p1); }
		public static void CREATE_MODEL_SWAP(float x, float y, float z, float radius, Hash originalModel, Hash newModel, BOOL p6) { Function.Call(0x10B2218320B6F5AC, x, y, z, radius, originalModel, newModel, p6); }
		public static void REMOVE_MODEL_SWAP(float x, float y, float z, float radius, Hash originalModel, Hash newModel, BOOL p6) { Function.Call(0x824E1C26A14CB817, x, y, z, radius, originalModel, newModel, p6); }
		public static void CREATE_MODEL_HIDE(float x, float y, float z, float radius, Hash model, BOOL p5) { Function.Call(0x069848B3FB3C4426, x, y, z, radius, model, p5); }
		public static void CREATE_MODEL_HIDE_EXCLUDING_SCRIPT_OBJECTS(float x, float y, float z, float radius, Hash model, BOOL p5) { Function.Call(0xD136090A9AAAB17D, x, y, z, radius, model, p5); }
		public static void REMOVE_MODEL_HIDE(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5) { Function.Call(0x3F38A98576F6213A, p0, p1, p2, p3, p4, p5); }
		public static Any _0xD4636C2EDB0DEA8A(Any p0) { return Function.Call<Any>(0xD4636C2EDB0DEA8A, p0); }
		public static void CREATE_FORCED_OBJECT(float x, float y, float z, Any p3, Hash modelHash, BOOL p5) { Function.Call(0x0961A905AFBC34C7, x, y, z, p3, modelHash, p5); }
		public static void REMOVE_FORCED_OBJECT(Any p0, Any p1, Any p2, Any p3, Any p4) { Function.Call(0x553FA683F2BCD814, p0, p1, p2, p3, p4); }
		public static void SET_ENTITY_NO_COLLISION_ENTITY(int entity1, int entity2, BOOL thisFrameOnly) { Function.Call(0xE037BF068223C38D, entity1, entity2, thisFrameOnly); }
		public static void SET_ENTITY_MOTION_BLUR(int entity, BOOL toggle) { Function.Call(0x516C6ABD18322B63, entity, toggle); }
		public static void SET_CAN_AUTO_VAULT_ON_ENTITY(int entity, BOOL toggle) { Function.Call(0x80646744FA88F9D7, entity, toggle); }
		public static void SET_CAN_CLIMB_ON_ENTITY(int entity, BOOL toggle) { Function.Call(0x24AED2A608F93C4C, entity, toggle); }
		public static void _SET_ENTITY_DECALS_DISABLED(int entity, BOOL toggle) { Function.Call(0xC64E597783BE9A1D, entity, toggle); }
		public static int _GET_ENTITIES_NEAR_POINT(float x, float y, float z, float radius, ItemSet itemSet, int p5) { return Function.Call<int>(0x59B57C4B06531E1E, x, y, z, radius, itemSet, p5); }
		public static int GET_MATCHING_ENTITIES(Volume volume, ItemSet itemSet, int entityType, Any p3, Hash p4, string p5) { return Function.Call<int>(0x84CCF9A12942C83D, volume, itemSet, entityType, p3, p4, p5); }
		public static int _GET_ENTITIES_IN_VOLUME(Volume volume, ItemSet itemSet, int entityType) { return Function.Call<int>(0x886171A12F400B89, volume, itemSet, entityType); }
		public static int _SEARCH_BUILDING_POOL_FOR_ENTITY_WITH_THIS_MODEL(Hash modelHash) { return Function.Call<int>(0x66B2B83B94B22458, modelHash); }
		public static Any _0xC2E71D7E0A7B4C89(Any p0) { return Function.Call<Any>(0xC2E71D7E0A7B4C89, p0); }
		public static void _0x6C31B06E91518269(Any p0, Any p1) { Function.Call(0x6C31B06E91518269, p0, p1); }
		public static void _0x119A5714578F4E05(Any p0, Any p1) { Function.Call(0x119A5714578F4E05, p0, p1); }
		public static int _GET_ENTITY_BY_DOORHASH(Hash doorHash, int p1) { return Function.Call<int>(0xF7424890E4A094C0, doorHash, p1); }
		public static unsafe BOOL FIND_ANIM_EVENT_PHASE(string animDictionary, string animName, string p2, Any* p3, Any* p4) { return Function.Call<BOOL>(0x42718CC559BD7776, animDictionary, animName, p2, p3, p4); }
		public static void FORCE_ENTITY_AI_AND_ANIMATION_UPDATE(int entity, BOOL p1) { Function.Call(0x4C9E96473D4F1A88, entity, p1); }
		public static float _GET_ENTITY_ANIM_CURRENT_TIME(int entity, string animDict, string animName) { return Function.Call<float>(0x627520389E288A73, entity, animDict, animName); }
		public static float _0x8E46E18AA828334F(int entity, string animDict, string animClip) { return Function.Call<float>(0x8E46E18AA828334F, entity, animDict, animClip); }
		public static Any _0xDF8E49EA89A01DB1(Any p0, Any p1, Any p2) { return Function.Call<Any>(0xDF8E49EA89A01DB1, p0, p1, p2); }
		public static BOOL HAS_ANIM_EVENT_FIRED(int entity, Hash actionHash) { return Function.Call<BOOL>(0x5851CC48405F4A07, entity, actionHash); }
		public static BOOL HAS_ENTITY_ANIM_FINISHED(int entity, string animDict, string animName, int p3) { return Function.Call<BOOL>(0xAEB40615337EF1E3, entity, animDict, animName, p3); }
		public static BOOL PLAY_ENTITY_ANIM(int entity, string animName, string animDict, float p3, BOOL loop, BOOL stayInAnim, BOOL p6, float delta, Any bitset) { return Function.Call<BOOL>(0xDC6D22FAB76D4874, entity, animName, animDict, p3, loop, stayInAnim, p6, delta, bitset); }
		public static void _SET_ENTITY_ANIM_CURRENT_TIME(int entity, string animDict, string animName, float time) { Function.Call(0x11CDABDC7783B2BC, entity, animDict, animName, time); }
		public static void _SET_ENTITY_ANIM_SPEED(int entity, string animDict, string animName, float speedMultiplier) { Function.Call(0xEAA885BA3CEA4E4A, entity, animDict, animName, speedMultiplier); }
		public static Any STOP_ENTITY_ANIM(int entity, string animation, string animGroup, float p3) { return Function.Call<Any>(0x786591D986DE9159, entity, animation, animGroup, p3); }
		public static void _0x669655FFB29EF1A9(Any p0, Any p1, Any p2, Any p3) { Function.Call(0x669655FFB29EF1A9, p0, p1, p2, p3); }
		public static void _ADD_ENTITY_TRACKING_TRAILS(int entity) { Function.Call(0x1AD922AB5038DEF3, entity); }
		public static void _0x5826EFD6D73C4DE5(int entity) { Function.Call(0x5826EFD6D73C4DE5, entity); }
		public static void _PAUSE_ENTITY_TRACKING(int entity, BOOL pause) { Function.Call(0x36EB4D34D4A092C5, entity, pause); }
		public static Any _CREATE_FOOTPATH_TRAIL(Any p0, string waypointRecord, BOOL bUseSnowOffset, float p3, float p4, Any p5, Any p6, Any p7, Any p8, Any p9, Any p10, BOOL bInit) { return Function.Call<Any>(0x29BA9F78321E5A6C, p0, waypointRecord, bUseSnowOffset, p3, p4, p5, p6, p7, p8, p9, p10, bInit); }
		public static void _0xC76E94A78127412B(Any p0, Any p1, Any p2) { Function.Call(0xC76E94A78127412B, p0, p1, p2); }
		public static void _0x7F20092547B4DDEA(Any p0) { Function.Call(0x7F20092547B4DDEA, p0); }
		public static void _0xF41E2979D5BC5370(Any p0) { Function.Call(0xF41E2979D5BC5370, p0); }
		public static Any _0xAAACB74442C1BED3(Any p0) { return Function.Call<Any>(0xAAACB74442C1BED3, p0); }
		public static Any PIN_CLOSEST_MAP_ENTITY(Hash modelHash, float x, float y, float z, int flags) { return Function.Call<Any>(0x6F3068258A499E52, modelHash, x, y, z, flags); }
		public static void _UNPIN_MAP_ENTITY(int entity) { Function.Call(0xD2B9C78537ED5759, entity); }
		public static BOOL IS_MAP_ENTITY_PINNED(Any p0) { return Function.Call<BOOL>(0x1FF441D7954F8709, p0); }
		public static int _GET_PINNED_MAP_ENTITY(Any p0) { return Function.Call<int>(0x4735E2A4BB83D9DA, p0); }
		public static void _0xEAB3D91D30A344F1(Any p0) { Function.Call(0xEAB3D91D30A344F1, p0); }
		public static void _0x37CEB637BA3B1A47(Any p0) { Function.Call(0x37CEB637BA3B1A47, p0); }
		public static Any _0x350E9211074955AF(Any p0, Any p1) { return Function.Call<Any>(0x350E9211074955AF, p0, p1); }
		public static void _0x898586729DB5221D(int ped) { Function.Call(0x898586729DB5221D, ped); }
		public static void _0xE9E7A0BAC7F57746(Any p0, Any p1) { Function.Call(0xE9E7A0BAC7F57746, p0, p1); }
	}

	public static class EVENT
	{
		public static void SET_DECISION_MAKER(int ped, Hash name) { Function.Call(0x8AE2F981CDDB8FA4, ped, name); }
		public static void _SET_DECISION_MAKER_DEFAULT(int ped) { Function.Call(0x6B9C5C38838FB6E6, ped); }
		public static unsafe ScrHandle _CREATE_SHOCKING_EVENT(Any* args) { return Function.Call<ScrHandle>(0xCA1315C33B9A2847, args); }
		public static ScrHandle ADD_SHOCKING_EVENT_AT_POSITION(Hash _eventType, float x, float y, float z, float p4, float p5, float p6, float p7, float p8, int p9, int p10) { return Function.Call<ScrHandle>(0xD9F8455409B525E9, _eventType, x, y, z, p4, p5, p6, p7, p8, p9, p10); }
		public static ScrHandle ADD_SHOCKING_EVENT_FOR_ENTITY(Hash _eventType, int entity, float p2, float p3, float p4, float p5, float p6, float p7, BOOL p8, BOOL p9, int p10, int p11) { return Function.Call<ScrHandle>(0x7FD8F3BE76F89422, _eventType, entity, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11); }
		public static BOOL IS_SHOCKING_EVENT_IN_SPHERE(Hash _eventType, float x, float y, float z, float radius) { return Function.Call<BOOL>(0x9DB47E16060D6354, _eventType, x, y, z, radius); }
		public static BOOL REMOVE_SHOCKING_EVENT(ScrHandle _event) { return Function.Call<BOOL>(0xE8BB3CC253A34559, _event); }
		public static void REMOVE_ALL_SHOCKING_EVENTS(BOOL p0) { Function.Call(0xD47A168C2AB90DC4, p0); }
		public static void _REMOVE_ALL_SHOCKING_EVENTS_IN_AREA(float x, float y, float z, float radius, BOOL p4) { Function.Call(0xB4C71BA9CAB097BD, x, y, z, radius, p4); }
		public static void _REMOVE_ALL_SHOCKING_EVENTS_OF_TYPE_IN_AREA(Hash _eventType, float x, float y, float z, float radius, BOOL p5) { Function.Call(0x6A648D42BF271DC7, _eventType, x, y, z, radius, p5); }
		public static void _REMOVE_ALL_SHOCKING_EVENTS_OF_TYPE(Hash _eventType, BOOL p1) { Function.Call(0x118873DD538490B4, _eventType, p1); }
		public static void REMOVE_SHOCKING_EVENT_SPAWN_BLOCKING_AREAS() { Function.Call(0xDB249021652420C5); }
		public static Any _0x36D0F2BA2C0D9BDE(int entity, int p1) { return Function.Call<Any>(0x36D0F2BA2C0D9BDE, entity, p1); }
		public static void _0x7C511E91738A0828(int ped1, int ped2, int p2, Hash p3) { Function.Call(0x7C511E91738A0828, ped1, ped2, p2, p3); }
		public static void SUPPRESS_SHOCKING_EVENTS_NEXT_FRAME() { Function.Call(0x84994FAD4E4E4E69); }
		public static void _0xB6F4825153920582() { Function.Call(0xB6F4825153920582); }
		public static void _0x4B2B1A891D437CA7(Any p0) { Function.Call(0x4B2B1A891D437CA7, p0); }
		public static void _0x9520175B35E2268D(int ped, int p1) { Function.Call(0x9520175B35E2268D, ped, p1); }
		public static Any _0x18E93EBFC1FCFA48(Any p0, Any p1, Any p2) { return Function.Call<Any>(0x18E93EBFC1FCFA48, p0, p1, p2); }
		public static void _0x56B3410626A473E7(Any p0) { Function.Call(0x56B3410626A473E7, p0); }
		public static void _0x608AD36A644A97FE(Hash p0, BOOL p1, BOOL p2) { Function.Call(0x608AD36A644A97FE, p0, p1, p2); }
		public static void _0x4465C3D1475BD3FD(Any p0) { Function.Call(0x4465C3D1475BD3FD, p0); }
		public static Any _0x2DD42FAD06E6F19E(Any p0, Any p1, Any p2) { return Function.Call<Any>(0x2DD42FAD06E6F19E, p0, p1, p2); }
		public static void _0xA86B0EE9B39D15D6(Any p0) { Function.Call(0xA86B0EE9B39D15D6, p0); }
		public static Any _0x26054EB81AC0893B(Any p0) { return Function.Call<Any>(0x26054EB81AC0893B, p0); }
		public static void _SET_EVENT_TRACKER_FOR_PED(int ped, string _eventName, int p2) { Function.Call(0xBB1E41DD3D3C6250, ped, _eventName, p2); }
		public static Any _0xAD17A18215DD23D6(Any p0, Any p1, Any p2) { return Function.Call<Any>(0xAD17A18215DD23D6, p0, p1, p2); }
		public static Any _0xC6A7DC546E94FED5(Any p0, Any p1, Any p2, Any p3) { return Function.Call<Any>(0xC6A7DC546E94FED5, p0, p1, p2, p3); }
		public static Hash _0x796EECFF0C6D39BE(int ped, Any p1, Any p2) { return Function.Call<Hash>(0x796EECFF0C6D39BE, ped, p1, p2); }
		public static Any _0x797B3D4D92E56094(Any p0, Any p1) { return Function.Call<Any>(0x797B3D4D92E56094, p0, p1); }
		public static int _0x822A001BCEA5BD81(int ped, Hash _eventType, Any p2, Any p3) { return Function.Call<int>(0x822A001BCEA5BD81, ped, _eventType, p2, p3); }
		public static Any _0x38497F139981C5C9(Any p0, Any p1, Any p2, Any p3) { return Function.Call<Any>(0x38497F139981C5C9, p0, p1, p2, p3); }
		public static Any _0x1D1B448D719415AB(int ped) { return Function.Call<Any>(0x1D1B448D719415AB, ped); }
		public static Any _0x83D43F0FD5276E4D(Any p0, Any p1) { return Function.Call<Any>(0x83D43F0FD5276E4D, p0, p1); }
		public static void _0xE28D7FC9FD32ABEB(Any p0, Any p1, Any p2) { Function.Call(0xE28D7FC9FD32ABEB, p0, p1, p2); }
		public static void _0x1A5C5D350068A673(int ped, Any p1) { Function.Call(0x1A5C5D350068A673, ped, p1); }
		public static void _0xAD8F2424C6E1E3A8(int ped) { Function.Call(0xAD8F2424C6E1E3A8, ped); }
		public static void _0xE2C2FBB7825FFC66() { Function.Call(0xE2C2FBB7825FFC66); }
	}

	public static class FIRE
	{
		public static FireId START_SCRIPT_FIRE(float x, float y, float z, int p3, float p4, BOOL p5, string soundsetName, float p7, int p8) { return Function.Call<FireId>(0x6B83617E04503888, x, y, z, p3, p4, p5, soundsetName, p7, p8); }
		public static void REMOVE_SCRIPT_FIRE(FireId fireHandle) { Function.Call(0x790125C36E194069, fireHandle); }
		public static void START_ENTITY_FIRE(Any p0, Any p1, Any p2, Any p3) { Function.Call(0xC4DC7418A44D6822, p0, p1, p2, p3); }
		public static void STOP_ENTITY_FIRE(Any p0, Any p1) { Function.Call(0x8390751DC40C1E98, p0, p1); }
		public static BOOL IS_ENTITY_ON_FIRE(int entity) { return Function.Call<BOOL>(0x1BD7C371CE257C3E, entity); }
		public static void _0x754937C28271BC65(Any p0) { Function.Call(0x754937C28271BC65, p0); }
		public static int GET_NUMBER_OF_FIRES_IN_RANGE(float x, float y, float z, float radius) { return Function.Call<int>(0xF9617BC6FAE61E08, x, y, z, radius); }
		public static void STOP_FIRE_IN_RANGE(float x, float y, float z, float radius) { Function.Call(0xDB38F247BD421708, x, y, z, radius); }
		public static void _STOP_FIRE_IN_BOX(float posX, float posY, float posZ, float rotX, float rotY, float rotZ, float scaleX, float scaleY, float scaleZ) { Function.Call(0xB7C7BDC375AEA9A4, posX, posY, posZ, rotX, rotY, rotZ, scaleX, scaleY, scaleZ); }
		public static unsafe BOOL GET_CLOSEST_FIRE_POS(Vector3* _outPosition, float x, float y, float z) { return Function.Call<BOOL>(0xB646FB657F448261, _outPosition, x, y, z); }
		public static Any _0x559FC1D310813031(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8, Any p9) { return Function.Call<Any>(0x559FC1D310813031, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9); }
		public static Any _0x41B87A6495EE13DD(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8, Any p9) { return Function.Call<Any>(0x41B87A6495EE13DD, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9); }
		public static Any _0xA4454592DCF7C992(Any p0) { return Function.Call<Any>(0xA4454592DCF7C992, p0); }
		public static BOOL _IS_ENTITY_CONSUMED_BY_FIRE(int entity) { return Function.Call<BOOL>(0xCDC25355C0D65963, entity); }
		public static void ADD_EXPLOSION(float x, float y, float z, int explosionType, float damageScale, BOOL isAudible, BOOL isInvisible, float cameraShake) { Function.Call(0x7D6F58F69DA92530, x, y, z, explosionType, damageScale, isAudible, isInvisible, cameraShake); }
		public static void ADD_OWNED_EXPLOSION(int ped, float x, float y, float z, int explosionType, float damageScale, BOOL isAudible, BOOL isInvisible, float cameraShake) { Function.Call(0xD84A917A64D4D016, ped, x, y, z, explosionType, damageScale, isAudible, isInvisible, cameraShake); }
		public static void _0xB7DF150605EEDC9B(int entity, int p1, float x, float y, float z, int explosionType, float damageScale, BOOL isAudible, BOOL isInvisible, float cameraShake) { Function.Call(0xB7DF150605EEDC9B, entity, p1, x, y, z, explosionType, damageScale, isAudible, isInvisible, cameraShake); }
		public static void ADD_EXPLOSION_WITH_USER_VFX(float x, float y, float z, int explosionType, Hash explosionFx, float damageScale, BOOL isAudible, BOOL isInvisible, float cameraShake) { Function.Call(0x53BA259F3A67A99E, x, y, z, explosionType, explosionFx, damageScale, isAudible, isInvisible, cameraShake); }
		public static void _0x34AE85C7CA4857AA(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8, Any p9, Any p10) { Function.Call(0x34AE85C7CA4857AA, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10); }
		public static BOOL IS_EXPLOSION_IN_AREA(int explosionType, float x1, float y1, float z1, float x2, float y2, float z2) { return Function.Call<BOOL>(0x8391BA4313A25AD3, explosionType, x1, y1, z1, x2, y2, z2); }
		public static BOOL IS_EXPLOSION_ACTIVE_IN_AREA(int explosionType, float x1, float y1, float z1, float x2, float y2, float z2) { return Function.Call<BOOL>(0xD96E82AEBFFAAFF0, explosionType, x1, y1, z1, x2, y2, z2); }
		public static BOOL IS_EXPLOSION_IN_SPHERE(int explosionType, float x, float y, float z, float radius) { return Function.Call<BOOL>(0xD62DD846D82CBB90, explosionType, x, y, z, radius); }
		public static BOOL IS_EXPLOSION_IN_ANGLED_AREA(int explosionType, float x1, float y1, float z1, float x2, float y2, float z2, float angle) { return Function.Call<BOOL>(0x5AE661ECD18524C9, explosionType, x1, y1, z1, x2, y2, z2, angle); }
		public static BOOL _IS_EXPLOSION_IN_VOLUME(int explosionType, Volume volume) { return Function.Call<BOOL>(0xE24822A4CFC9107A, explosionType, volume); }
		public static int GET_OWNER_OF_EXPLOSION_IN_ANGLED_AREA(int explosionType, float x1, float y1, float z1, float x2, float y2, float z2, float radius) { return Function.Call<int>(0x8002DDAB58594D78, explosionType, x1, y1, z1, x2, y2, z2, radius); }
		public static void _0x68F6A75FDF5A70D6(Any p0, Any p1, Any p2, Any p3) { Function.Call(0x68F6A75FDF5A70D6, p0, p1, p2, p3); }
		public static void _0x24DB6B9F2B719043(Any p0) { Function.Call(0x24DB6B9F2B719043, p0); }
		public static BOOL _IS_PED_SHOCKING_EVENT_ACTIVE(int ped, int p1) { return Function.Call<BOOL>(0xAB7993BA61A4674F, ped, p1); }
	}

	public static class FLOCK
	{
		public static float GET_SPECIES_TUNING_FLOAT_PARAM(Hash p0, int p1, int p2) { return Function.Call<float>(0xE108489621422F91, p0, p1, p2); }
		public static void SET_SPECIES_TUNING_FLOAT_PARAM(Hash p0, int p1, int p2, float p3) { Function.Call(0x963240B6C252BA49, p0, p1, p2, p3); }
		public static void SET_SPECIES_TUNING_BOOL_PARAM(Hash p0, int p1, int p2, BOOL p3) { Function.Call(0x6D1D94C2459B42EE, p0, p1, p2, p3); }
		public static float GET_ANIMAL_TUNING_FLOAT_PARAM(int animal, int index) { return Function.Call<float>(0x4BC3ECFDA0297E27, animal, index); }
		public static void SET_ANIMAL_TUNING_FLOAT_PARAM(int animal, int index, float value) { Function.Call(0xCBDA22C87977244F, animal, index, value); }
		public static void RESET_ANIMAL_TUNING_FLOAT_PARAM(int animal, int index) { Function.Call(0xE776A195488FC520, animal, index); }
		public static BOOL GET_ANIMAL_TUNING_BOOL_PARAM(int animal, int index) { return Function.Call<BOOL>(0x1C1993824A396603, animal, index); }
		public static void SET_ANIMAL_TUNING_BOOL_PARAM(int animal, int index, BOOL value) { Function.Call(0x9FF1E042FA597187, animal, index, value); }
		public static void RESET_ANIMAL_TUNING_BOOL_PARAM(int animal, int index) { Function.Call(0x96AA1304D30E6BC3, animal, index); }
		public static Any _0x8049B17BEC937662(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6) { return Function.Call<Any>(0x8049B17BEC937662, p0, p1, p2, p3, p4, p5, p6); }
		public static Any _0xE93415B3307208E5(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8) { return Function.Call<Any>(0xE93415B3307208E5, p0, p1, p2, p3, p4, p5, p6, p7, p8); }
		public static Any _0x19870C40C7EE15BE(Any p0, Any p1) { return Function.Call<Any>(0x19870C40C7EE15BE, p0, p1); }
		public static void _0x0816C31480764AB0(Any p0, Any p1, Any p2, Any p3) { Function.Call(0x0816C31480764AB0, p0, p1, p2, p3); }
		public static void _0xC3D581A34BC0A1F0(Any p0, Any p1) { Function.Call(0xC3D581A34BC0A1F0, p0, p1); }
		public static void _0xF2CCA7B68CFAB2B9(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8, Any p9, Any p10, Any p11, Any p12, Any p13) { Function.Call(0xF2CCA7B68CFAB2B9, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13); }
		public static void _0xFB16F08F47B83B4C(Any p0) { Function.Call(0xFB16F08F47B83B4C, p0); }
		public static BOOL _GET_ANIMAL_IS_WILD(int ped) { return Function.Call<BOOL>(0x3B005FF0538ED2A9, ped); }
		public static void _SET_ANIMAL_IS_WILD(int ped, BOOL toggle) { Function.Call(0xAEB97D84CDF3C00B, ped, toggle); }
		public static int _GET_ANIMAL_RARITY(int ped) { return Function.Call<int>(0xF8B48A361DC388AE, ped); }
		public static void _SET_ANIMAL_RARITY(int ped, int rarityLevel) { Function.Call(0x8B6F0F59B1B99801, ped, rarityLevel); }
		public static void _0xFF1E339CE40EAAAF(Any p0, Any p1) { Function.Call(0xFF1E339CE40EAAAF, p0, p1); }
		public static Any _0x8D913E493BAFE0A3(Any p0) { return Function.Call<Any>(0x8D913E493BAFE0A3, p0); }
		public static ScrHandle _CREATE_HERD() { return Function.Call<ScrHandle>(0xCB4EF7EDAE2E16F1); }
		public static void _0xE0961AED72642B80(Any p0) { Function.Call(0xE0961AED72642B80, p0); }
		public static void _ADD_PED_TO_FLOCK(Any p0, int ped) { Function.Call(0x933E5D31A7D13069, p0, ped); }
		public static void _0x408D1149C5E39C1E(Any p0, Any p1) { Function.Call(0x408D1149C5E39C1E, p0, p1); }
		public static Any _0x9E13ACC38BA8F9C3(Any p0, Any p1) { return Function.Call<Any>(0x9E13ACC38BA8F9C3, p0, p1); }
		public static Any _0x34B9C4D86DF2C2F3(Any p0) { return Function.Call<Any>(0x34B9C4D86DF2C2F3, p0); }
		public static Vector3 _0x1DA6CB02071055D5(Any p0) { return Function.Call<Vector3>(0x1DA6CB02071055D5, p0); }
		public static void _0xC95611869E14F8AF(Any p0, Any p1, Any p2, Any p3) { Function.Call(0xC95611869E14F8AF, p0, p1, p2, p3); }
		public static Any _0x09EE00B8F858E0BE(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6) { return Function.Call<Any>(0x09EE00B8F858E0BE, p0, p1, p2, p3, p4, p5, p6); }
		public static void _0xE36D2CB540597EF7(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7) { Function.Call(0xE36D2CB540597EF7, p0, p1, p2, p3, p4, p5, p6, p7); }
		public static Any _0xD95F04A4E73BE85E(Any p0, Any p1) { return Function.Call<Any>(0xD95F04A4E73BE85E, p0, p1); }
		public static void _0x17E3E5C46ECCD308(Any p0, Any p1, Any p2) { Function.Call(0x17E3E5C46ECCD308, p0, p1, p2); }
		public static void _0xC72CE37081DAE625(Any p0, Any p1, Any p2, Any p3) { Function.Call(0xC72CE37081DAE625, p0, p1, p2, p3); }
		public static void _0x67A43EA3F6FE0076(Any p0) { Function.Call(0x67A43EA3F6FE0076, p0); }
		public static Any _0x36486AF7DA93A464(Any p0) { return Function.Call<Any>(0x36486AF7DA93A464, p0); }
		public static void _0x6C57BEA886A20C6B(Any p0, Any p1) { Function.Call(0x6C57BEA886A20C6B, p0, p1); }
		public static void _0x1520626FFAFFFA8F(Any p0, Any p1) { Function.Call(0x1520626FFAFFFA8F, p0, p1); }
		public static void _0xFA821997794F48E7(Any p0, Any p1, Any p2) { Function.Call(0xFA821997794F48E7, p0, p1, p2); }
		public static void _0xCC6B5AAFC87BFC7B(Any p0, Any p1, Any p2) { Function.Call(0xCC6B5AAFC87BFC7B, p0, p1, p2); }
		public static void _0xFDB008B3BCF5992F(Any p0, Any p1, Any p2) { Function.Call(0xFDB008B3BCF5992F, p0, p1, p2); }
		public static void _0x2DF3D457D86F8E57(Any p0, Any p1) { Function.Call(0x2DF3D457D86F8E57, p0, p1); }
		public static void _0x706B434FEFAD6A24(Any p0) { Function.Call(0x706B434FEFAD6A24, p0); }
		public static void _0xA881F5C77A560906(Any p0) { Function.Call(0xA881F5C77A560906, p0); }
		public static Any _0x53187E563F938E76(Any p0) { return Function.Call<Any>(0x53187E563F938E76, p0); }
	}

	public static class GRAPHICS
	{
		public static void FREE_MEMORY_FOR_MISSION_CREATOR_PHOTO() { Function.Call(0x7DFF8F94937D2659); }
		public static unsafe BOOL LOAD_MISSION_CREATOR_PHOTO(Any* p0, Any p1, Any p2, Any p3) { return Function.Call<BOOL>(0x84F0BA7462FF8D58, p0, p1, p2, p3); }
		public static unsafe int GET_STATUS_OF_LOAD_MISSION_CREATOR_PHOTO(Any* p0) { return Function.Call<int>(0xC71B50AE58D07369, p0); }
		public static BOOL BEGIN_TAKE_HIGH_QUALITY_PHOTO() { return Function.Call<BOOL>(0xA15BFFC0A01B34E1); }
		public static int GET_STATUS_OF_TAKE_HIGH_QUALITY_PHOTO() { return Function.Call<int>(0x4A3DA74C3CCB1725); }
		public static void FREE_MEMORY_FOR_HIGH_QUALITY_PHOTO() { Function.Call(0xD45547D8396F002A); }
		public static void _SET_PHOTO_SELF_STAT(BOOL p0) { Function.Call(0x2705D18C11B61046, p0); }
		public static void _SET_PHOTO_STUDIO_STAT(int p0) { Function.Call(0x8E6AFF353C09652E, p0); }
		public static void _SET_POSSE_ID_FOR_PHOTO(Any posseId) { Function.Call(0x564837D4A9EDE296, posseId); }
		public static void _0x9F6D859C80708B26(BOOL p0, BOOL p1) { Function.Call(0x9F6D859C80708B26, p0, p1); }
		public static BOOL IS_PHOTO_FRAME() { return Function.Call<BOOL>(0x86076AE35CBBE55F); }
		public static void _SET_PHOTO_IN_PHOTOMODE_STAT(BOOL p0) { Function.Call(0xFA91736933AB3D93, p0); }
		public static void _SET_PHOTO_OVERLAY_EFFECT_STAT(int p0) { Function.Call(0x8B3296278328B5EB, p0); }
		public static void _0x0D5B19C34068FEE7(Any p0) { Function.Call(0x0D5B19C34068FEE7, p0); }
		public static void _SET_PLAYER_APPEAR_IN_PHOTO(int player) { Function.Call(0x75D568607909333E, player); }
		public static void _SET_REGION_PHOTO_TAKEN_STAT(string p0) { Function.Call(0xD1031B83AC093BC7, p0); }
		public static void _SET_DISTRICT_PHOTO_TAKEN_STAT(string p0) { Function.Call(0x9937FACBBF267244, p0); }
		public static void _SET_STATE_PHOTO_TAKEN_STAT(string p0) { Function.Call(0x8952E857696B8A79, p0); }
		public static BOOL SAVE_HIGH_QUALITY_PHOTO(int unused) { return Function.Call<BOOL>(0x57639FD876B68A91, unused); }
		public static int GET_STATUS_OF_SAVE_HIGH_QUALITY_PHOTO() { return Function.Call<int>(0xD6663EC374092383); }
		public static BOOL _0x494A9874F17A7D50(Any p0) { return Function.Call<BOOL>(0x494A9874F17A7D50, p0); }
		public static int _GET_STATUS_OF_DRAW_LOW_QUALITY_PHOTO(Any p0) { return Function.Call<int>(0x13430D3D5A45F14B, p0); }
		public static void FREE_MEMORY_FOR_LOW_QUALITY_PHOTO() { Function.Call(0x614682E715ADBAAC); }
		public static void DRAW_LOW_QUALITY_PHOTO_TO_PHONE(BOOL p0, BOOL p1) { Function.Call(0xF1142E5D64B47802, p0, p1); }
		public static int _GET_MAX_NUMBER_OF_LOCAL_PHOTOS() { return Function.Call<int>(0x8E587FCD30E05592); }
		public static int _GET_CURRENT_NUMBER_OF_LOCAL_PHOTOS() { return Function.Call<int>(0x78C56B8A7B1D000C); }
		public static Any _0xA42EDF1E88734A7E() { return Function.Call<Any>(0xA42EDF1E88734A7E); }
		public static int GET_STATUS_OF_SORTED_LIST_OPERATION() { return Function.Call<int>(0xB28894CD7408BD0C); }
		public static void DRAW_LIGHT_WITH_RANGE(float posX, float posY, float posZ, int colorR, int colorG, int colorB, float range, float intensity) { Function.Call(0xD2D9E04C0DF927F4, posX, posY, posZ, colorR, colorG, colorB, range, intensity); }
		public static void UPDATE_LIGHTS_ON_ENTITY(int entity) { Function.Call(0xBDBACB52A03CC760, entity); }
		public static void _SET_LIGHTS_COLOR_FOR_ENTITY(int entity, int red, int green, int blue) { Function.Call(0x6EC2A67962296F49, entity, red, green, blue); }
		public static void _SET_LIGHTS_INTENSITY_FOR_ENTITY(int entity, float intensity) { Function.Call(0x07C0F87AAC57F2E4, entity, intensity); }
		public static void _SET_LIGHTS_TYPE_FOR_ENTITY(int entity, int type) { Function.Call(0xAB72C67163DC4DB4, entity, type); }
		public static void _DRAW_MARKER(Hash type, float posX, float posY, float posZ, float dirX, float dirY, float dirZ, float rotX, float rotY, float rotZ, float scaleX, float scaleY, float scaleZ, int red, int green, int blue, int alpha, BOOL bobUpAndDown, BOOL faceCamera, int p19, BOOL rotate, string textureDict, string textureName, BOOL drawOnEnts) { Function.Call(0x2A32FAA57B937173, type, posX, posY, posZ, dirX, dirY, dirZ, rotX, rotY, rotZ, scaleX, scaleY, scaleZ, red, green, blue, alpha, bobUpAndDown, faceCamera, p19, rotate, textureDict, textureName, drawOnEnts); }
		public static int CREATE_CHECKPOINT_WITH_NAMEHASH(Hash typeHash, float posX1, float posY1, float posZ1, float posX2, float posY2, float posZ2, float radius, int red, int green, int blue, int alpha, int reserved) { return Function.Call<int>(0x175668836B44CBB0, typeHash, posX1, posY1, posZ1, posX2, posY2, posZ2, radius, red, green, blue, alpha, reserved); }
		public static BOOL _DOES_CHECKPOINT_HAVE_FX(int checkpoint) { return Function.Call<BOOL>(0x4C11CCACB7C02B6E, checkpoint); }
		public static void SET_CHECKPOINT_RGBA(int checkpoint, int red, int green, int blue, int alpha) { Function.Call(0xCAAFC225E33B1D15, checkpoint, red, green, blue, alpha); }
		public static void SET_CHECKPOINT_RGBA2(int checkpoint, int red, int green, int blue, int alpha) { Function.Call(0x99AFF17222D4DEB4, checkpoint, red, green, blue, alpha); }
		public static void _0xCC3B787E73E64160(Any p0, Any p1, Any p2, Any p3, Any p4) { Function.Call(0xCC3B787E73E64160, p0, p1, p2, p3, p4); }
		public static void _0x171C18E994C1A395(Any p0, Any p1, Any p2, Any p3, Any p4) { Function.Call(0x171C18E994C1A395, p0, p1, p2, p3, p4); }
		public static void DELETE_CHECKPOINT(int checkpoint) { Function.Call(0x0DED5B0C8EBAAE12, checkpoint); }
		public static void DRAW_RECT(float x, float y, float width, float height, int red, int green, int blue, int alpha, BOOL p8, BOOL p9) { Function.Call(0x405224591DF02025, x, y, width, height, red, green, blue, alpha, p8, p9); }
		public static void SET_SCRIPT_GFX_DRAW_BEHIND_PAUSEMENU(BOOL toggle) { Function.Call(0x906B86E6D7896B9E, toggle); }
		public static void SET_SCRIPT_GFX_DRAW_ORDER(int drawOrder) { Function.Call(0xCFCC78391C8B3814, drawOrder); }
		public static void DRAW_SPRITE(string textureDict, string textureName, float screenX, float screenY, float width, float height, float heading, int red, int green, int blue, int alpha, BOOL p11) { Function.Call(0xC9884ECADE94CB34, textureDict, textureName, screenX, screenY, width, height, heading, red, green, blue, alpha, p11); }
		public static void ATTACH_TV_AUDIO_TO_ENTITY(int entity) { Function.Call(0x40866A418EB8EFDE, entity); }
		public static void SET_TV_AUDIO_FRONTEND(BOOL toggle) { Function.Call(0x64437C98FCC5F291, toggle); }
		public static unsafe void GET_SCREEN_RESOLUTION(int* x, int* y) { Function.Call(0x66773C92835D0909, x, y); }
		public static void _0xA04EF43030593ABC(Any p0, Any p1) { Function.Call(0xA04EF43030593ABC, p0, p1); }
		public static void _0xA21AF60C9F99CCC5() { Function.Call(0xA21AF60C9F99CCC5); }
		public static Any _0xC28F62AC9774FC1B() { return Function.Call<Any>(0xC28F62AC9774FC1B); }
		public static void _0xEB48CE48EEC41FD4(Any p0) { Function.Call(0xEB48CE48EEC41FD4, p0); }
		public static unsafe BOOL GET_SCREEN_COORD_FROM_WORLD_COORD(float worldX, float worldY, float worldZ, float* screenX, float* screenY) { return Function.Call<BOOL>(0xCB50D7AFCC8B0EC6, worldX, worldY, worldZ, screenX, screenY); }
		public static BOOL _IS_TEXTURE_IN_DICT(Hash txdHash, Hash dict) { return Function.Call<BOOL>(0xA2A51869BDED733B, txdHash, dict); }
		public static void SET_ARTIFICIAL_LIGHTS_STATE(BOOL state) { Function.Call(0xB2797619A7C7747B, state); }
		public static void _0x98A7CD5EA379A854() { Function.Call(0x98A7CD5EA379A854); }
		public static void _0x1A9F09AB458D49C6(BOOL p0) { Function.Call(0x1A9F09AB458D49C6, p0); }
		public static int CREATE_TRACKED_POINT() { return Function.Call<int>(0xFB405CB357C69CB9); }
		public static void SET_TRACKED_POINT_INFO(int point, float x, float y, float z, float radius) { Function.Call(0xF6FDA3D4404D4F2C, point, x, y, z, radius); }
		public static BOOL IS_TRACKED_POINT_VISIBLE(int point) { return Function.Call<BOOL>(0xCBB056BA159FB48D, point); }
		public static int _0xDFE332A5DA6FE7C9(int iTrackedPoint) { return Function.Call<int>(0xDFE332A5DA6FE7C9, iTrackedPoint); }
		public static void DESTROY_TRACKED_POINT(int point) { Function.Call(0x37A59922109F8F1C, point); }
		public static BOOL _IS_TRACKED_POINT_VALID(int point) { return Function.Call<BOOL>(0xF2FDDCC8C6BAE1B3, point); }
		public static Any _0x27219300C36A8D40(Any p0, Any p1, Any p2, Any p3, Any p4) { return Function.Call<Any>(0x27219300C36A8D40, p0, p1, p2, p3, p4); }
		public static void _0xAE7BF7CA9E4BA48D(Any p0) { Function.Call(0xAE7BF7CA9E4BA48D, p0); }
		public static int _ADD_VEG_MODIFIER_ZONE(Volume volume, int p1, int flags, int p3) { return Function.Call<int>(0xBD3324281E8B9933, volume, p1, flags, p3); }
		public static int ADD_VEG_MODIFIER_SPHERE(float x, float y, float z, float radius, int modType, int flags, int p6) { return Function.Call<int>(0xFA50F79257745E74, x, y, z, radius, modType, flags, p6); }
		public static void REMOVE_VEG_MODIFIER_SPHERE(int vegModifierHandle, int p1) { Function.Call(0x9CF1836C03FB67A2, vegModifierHandle, p1); }
		public static void _ENABLE_STATIC_VEG_MODIFIER(Hash p0) { Function.Call(0xDFEA23EC90113657, p0); }
		public static void _DISABLE_STATIC_VEG_MODIFIER(Hash p0) { Function.Call(0xDD0BC0EDCB2162F6, p0); }
		public static BOOL _IS_STATIC_VEG_MODIFIER_ENABLED(Hash p0) { return Function.Call<BOOL>(0xDE9BAD3292AA6D5E, p0); }
		public static void _0xEC3F7F24EEEB3BA3() { Function.Call(0xEC3F7F24EEEB3BA3); }
		public static void _0x9F158A49B0D84C3C(Any p0) { Function.Call(0x9F158A49B0D84C3C, p0); }
		public static void _0x910E260AEAD855DE() { Function.Call(0x910E260AEAD855DE); }
		public static BOOL _CREATE_SWATCH_TEXTURE_DICT(int slots) { return Function.Call<BOOL>(0x3D084D5568FB4028, slots); }
		public static void _DESTROY_SWATCH_TEXTURE_DICT() { Function.Call(0xDAD7FB8402651654); }
		public static void _GENERATE_SWATCH_TEXTURE_DIRECTLY(int slot, Any p1) { Function.Call(0x646ED1A1D28487DF, slot, p1); }
		public static void _GENERATE_SWATCH_TEXTURE(int slotId, Hash componentHash, int metapedType, BOOL p3) { Function.Call(0x160921255327C591, slotId, componentHash, metapedType, p3); }
		public static void CASCADE_SHADOWS_SET_CASCADE_BOUNDS(Any p0, BOOL p1, float p2, float p3, float p4, float p5, BOOL p6, float p7) { Function.Call(0xD9EDB2E4512D563E, p0, p1, p2, p3, p4, p5, p6, p7); }
		public static void CASCADE_SHADOWS_ENABLE_ENTITY_TRACKER(BOOL toggle) { Function.Call(0x8FBFD2AEB196B369, toggle); }
		public static void CASCADE_SHADOWS_SET_SHADOW_SAMPLE_TYPE(string type) { Function.Call(0xCE4774E0F9AD48D1, type); }
		public static void CASCADE_SHADOWS_CLEAR_SHADOW_SAMPLE_TYPE() { Function.Call(0xF7C29D7C12C36F03); }
		public static void _0x503941F65DBA24EC(Any p0) { Function.Call(0x503941F65DBA24EC, p0); }
		public static void _0x815653A42C5ABE76() { Function.Call(0x815653A42C5ABE76); }
		public static void _0xFF8018C778349234(Any p0) { Function.Call(0xFF8018C778349234, p0); }
		public static void _0x297B72E2AF094742(int unk) { Function.Call(0x297B72E2AF094742, unk); }
		public static void TOGGLE_PAUSED_RENDERPHASES(BOOL toggle) { Function.Call(0xEF9E1C45732F55FA, toggle); }
		public static BOOL GET_TOGGLE_PAUSED_RENDERPHASES_STATUS() { return Function.Call<BOOL>(0x86ED21BDB2791CE8); }
		public static void RESET_PAUSED_RENDERPHASES() { Function.Call(0xCCD9AAD85E1B559E); }
		public static void _SET_HIDOF_ENV_BLUR_PARAMS(BOOL p0, BOOL p1, float p2, float p3, float p4, float p5) { Function.Call(0xCC23AA1A7CBFE840, p0, p1, p2, p3, p4, p5); }
		public static void _0x21F00E08CBB5F37B(Any p0) { Function.Call(0x21F00E08CBB5F37B, p0); }
		public static void _0x5AC6E0FA028369DE() { Function.Call(0x5AC6E0FA028369DE); }
		public static BOOL _0xEC3D8C228FE553D7(BOOL p0) { return Function.Call<BOOL>(0xEC3D8C228FE553D7, p0); }
		public static void _0xF5793BB386E1FF9C(Any p0) { Function.Call(0xF5793BB386E1FF9C, p0); }
		public static void _0x5CD6A2CCE5087161(Any p0) { Function.Call(0x5CD6A2CCE5087161, p0); }
		public static void _0xC8D0611D9A0CF5D3(Any p0) { Function.Call(0xC8D0611D9A0CF5D3, p0); }
		public static float _GET_PHOTO_MODE_EXPOSURE() { return Function.Call<float>(0x06C0D8BB6B04A709); }
		public static void _0x62B9F9A1272AED80(Any p0) { Function.Call(0x62B9F9A1272AED80, p0); }
		public static float _GET_PHOTO_MODE_CONTRAST() { return Function.Call<float>(0x98F4154989B81EC6); }
		public static void _0x9229ED770975BD9E() { Function.Call(0x9229ED770975BD9E); }
		public static int START_PARTICLE_FX_NON_LOOPED_AT_COORD(string effectName, float xPos, float yPos, float zPos, float xRot, float yRot, float zRot, float scale, BOOL xAxis, BOOL yAxis, BOOL zAxis) { return Function.Call<int>(0x2E80BF72EF7C87AC, effectName, xPos, yPos, zPos, xRot, yRot, zRot, scale, xAxis, yAxis, zAxis); }
		public static BOOL START_NETWORKED_PARTICLE_FX_NON_LOOPED_AT_COORD(string effectName, float xPos, float yPos, float zPos, float xRot, float yRot, float zRot, float scale, BOOL xAxis, BOOL yAxis, BOOL zAxis) { return Function.Call<BOOL>(0xFB97618457994A62, effectName, xPos, yPos, zPos, xRot, yRot, zRot, scale, xAxis, yAxis, zAxis); }
		public static BOOL START_PARTICLE_FX_NON_LOOPED_ON_PED_BONE(string effectName, int ped, float offsetX, float offsetY, float offsetZ, float rotX, float rotY, float rotZ, int boneIndex, float scale, BOOL axisX, BOOL axisY, BOOL axisZ) { return Function.Call<BOOL>(0x3FAA72BD940C3AC0, effectName, ped, offsetX, offsetY, offsetZ, rotX, rotY, rotZ, boneIndex, scale, axisX, axisY, axisZ); }
		public static BOOL START_PARTICLE_FX_NON_LOOPED_ON_ENTITY(string effectName, int entity, float offsetX, float offsetY, float offsetZ, float rotX, float rotY, float rotZ, float scale, BOOL axisX, BOOL axisY, BOOL axisZ) { return Function.Call<BOOL>(0xFF4C64C513388C12, effectName, entity, offsetX, offsetY, offsetZ, rotX, rotY, rotZ, scale, axisX, axisY, axisZ); }
		public static BOOL START_NETWORKED_PARTICLE_FX_NON_LOOPED_ON_ENTITY(string effectName, int entity, float offsetX, float offsetY, float offsetZ, float rotX, float rotY, float rotZ, float scale, BOOL axisX, BOOL axisY, BOOL axisZ) { return Function.Call<BOOL>(0xE6CFE43937061143, effectName, entity, offsetX, offsetY, offsetZ, rotX, rotY, rotZ, scale, axisX, axisY, axisZ); }
		public static BOOL _START_PARTICLE_FX_NON_LOOPED_ON_PED_BONE_2(string effectName, int ped, float offsetX, float offsetY, float offsetZ, float rotX, float rotY, float rotZ, int boneIndex, float scale, BOOL axisX, BOOL axisY, BOOL axisZ) { return Function.Call<BOOL>(0xC695870B8A149B96, effectName, ped, offsetX, offsetY, offsetZ, rotX, rotY, rotZ, boneIndex, scale, axisX, axisY, axisZ); }
		public static void SET_PARTICLE_FX_NON_LOOPED_COLOUR(float r, float g, float b) { Function.Call(0x60B85BED6577A35B, r, g, b); }
		public static void SET_PARTICLE_FX_NON_LOOPED_ALPHA(float alpha) { Function.Call(0xE8A35938A7026CEA, alpha); }
		public static void _SET_PARTICLE_FX_NON_LOOPED_EMITTER_SCALE(float p0, float p1, float p2) { Function.Call(0x56C392C2BD78B024, p0, p1, p2); }
		public static int START_PARTICLE_FX_LOOPED_AT_COORD(string effectName, float x, float y, float z, float xRot, float yRot, float zRot, float scale, BOOL xAxis, BOOL yAxis, BOOL zAxis, BOOL p11) { return Function.Call<int>(0xBA32867E86125D3A, effectName, x, y, z, xRot, yRot, zRot, scale, xAxis, yAxis, zAxis, p11); }
		public static int START_PARTICLE_FX_LOOPED_ON_PED_BONE(string effectName, int ped, float xOffset, float yOffset, float zOffset, float xRot, float yRot, float zRot, int boneIndex, float scale, BOOL xAxis, BOOL yAxis, BOOL zAxis) { return Function.Call<int>(0xE689C1B1432BB8AF, effectName, ped, xOffset, yOffset, zOffset, xRot, yRot, zRot, boneIndex, scale, xAxis, yAxis, zAxis); }
		public static int START_PARTICLE_FX_LOOPED_ON_ENTITY(string effectName, int entity, float xOffset, float yOffset, float zOffset, float xRot, float yRot, float zRot, float scale, BOOL xAxis, BOOL yAxis, BOOL zAxis) { return Function.Call<int>(0xBD41E1440CE39800, effectName, entity, xOffset, yOffset, zOffset, xRot, yRot, zRot, scale, xAxis, yAxis, zAxis); }
		public static int START_PARTICLE_FX_LOOPED_ON_ENTITY_BONE(string effectName, int entity, float xOffset, float yOffset, float zOffset, float xRot, float yRot, float zRot, int boneIndex, float scale, BOOL xAxis, BOOL yAxis, BOOL zAxis) { return Function.Call<int>(0xD3BA6EC7F2FBD5E9, effectName, entity, xOffset, yOffset, zOffset, xRot, yRot, zRot, boneIndex, scale, xAxis, yAxis, zAxis); }
		public static int START_NETWORKED_PARTICLE_FX_LOOPED_ON_ENTITY(string effectName, int entity, float xOffset, float yOffset, float zOffset, float xRot, float yRot, float zRot, float scale, BOOL xAxis, BOOL yAxis, BOOL zAxis) { return Function.Call<int>(0x8F90AB32E1944BDE, effectName, entity, xOffset, yOffset, zOffset, xRot, yRot, zRot, scale, xAxis, yAxis, zAxis); }
		public static int START_NETWORKED_PARTICLE_FX_LOOPED_ON_ENTITY_BONE(string effectName, int entity, float xOffset, float yOffset, float zOffset, float xRot, float yRot, float zRot, int boneIndex, float scale, BOOL xAxis, BOOL yAxis, BOOL zAxis) { return Function.Call<int>(0x9C56621462FFE7A6, effectName, entity, xOffset, yOffset, zOffset, xRot, yRot, zRot, boneIndex, scale, xAxis, yAxis, zAxis); }
		public static void STOP_PARTICLE_FX_LOOPED(int ptfxHandle, BOOL p1) { Function.Call(0x22970F3A088B133B, ptfxHandle, p1); }
		public static BOOL DOES_PARTICLE_FX_LOOPED_EXIST(int ptfxHandle) { return Function.Call<BOOL>(0x9DD5AFF561E88F2A, ptfxHandle); }
		public static void SET_PARTICLE_FX_LOOPED_OFFSETS(int ptfxHandle, float x, float y, float z, float rotX, float rotY, float rotZ) { Function.Call(0xD3A4A95FC94FE83B, ptfxHandle, x, y, z, rotX, rotY, rotZ); }
		public static void SET_PARTICLE_FX_LOOPED_EVOLUTION(int ptfxHandle, string propertyName, float amount, BOOL noNetwork) { Function.Call(0x3674F389B0FACD80, ptfxHandle, propertyName, amount, noNetwork); }
		public static void SET_PARTICLE_FX_LOOPED_COLOUR(int ptfxHandle, float r, float g, float b, BOOL p4) { Function.Call(0x239879FC61C610CC, ptfxHandle, r, g, b, p4); }
		public static void SET_PARTICLE_FX_LOOPED_ALPHA(int ptfxHandle, float alpha) { Function.Call(0x88786E76234F7054, ptfxHandle, alpha); }
		public static void SET_PARTICLE_FX_LOOPED_SCALE(int ptfxHandle, float scale) { Function.Call(0x1A9E1C0D98D093B7, ptfxHandle, scale); }
		public static void SET_PARTICLE_FX_LOOPED_FAR_CLIP_DIST(int ptfxHandle, float range) { Function.Call(0x9B04D471DA0AD7AA, ptfxHandle, range); }
		public static void _SET_PARTICLE_FX_LOOPED_UPDATE_DISTANT_SMOKE(int ptfxHandle, float scalar) { Function.Call(0x9DDC222D85D5AF2A, ptfxHandle, scalar); }
		public static void REMOVE_PARTICLE_FX(int ptfxHandle, BOOL p1) { Function.Call(0x459598F579C98929, ptfxHandle, p1); }
		public static void REMOVE_PARTICLE_FX_FROM_ENTITY(int entity) { Function.Call(0x92884B4A49D81325, entity); }
		public static void REMOVE_PARTICLE_FX_IN_RANGE(float X, float Y, float Z, float radius) { Function.Call(0x87B5905ECA623B68, X, Y, Z, radius); }
		public static void USE_PARTICLE_FX_ASSET(string fxName) { Function.Call(0xA10DB07FC234DD12, fxName); }
		public static void SET_PARTICLE_FX_OVERRIDE(string oldAsset, string newAsset) { Function.Call(0xBE711A169E9C7E95, oldAsset, newAsset); }
		public static void RESET_PARTICLE_FX_OVERRIDE(string name) { Function.Call(0x274B3DABF7E72DEF, name); }
		public static void _0x4FB67D172C4476F3(int entity, string p1, string p2, float p3) { Function.Call(0x4FB67D172C4476F3, entity, p1, p2, p3); }
		public static void SET_PARTICLE_FX_AMBIENT_COLOUR(int entity, string p1, float r, float g, float b) { Function.Call(0x3C61B52B00848C26, entity, p1, r, g, b); }
		public static void _0xD1472AFF30C103D6(float p0) { Function.Call(0xD1472AFF30C103D6, p0); }
		public static void SET_PARTICLE_FX_BULLET_IMPACT_SCALE(float scale) { Function.Call(0xA53C8D7D0F8C74D0, scale); }
		public static void _0x8DCCC98DC0DBF9E4(float p0) { Function.Call(0x8DCCC98DC0DBF9E4, p0); }
		public static void _SET_SNIPER_GLINTS_ENABLED(BOOL enabled) { Function.Call(0x6E8EB45A4F4460EB, enabled); }
		public static void _0x2A1625858887D4E6(float p0) { Function.Call(0x2A1625858887D4E6, p0); }
		public static void _0x4046493D2EEACA0E() { Function.Call(0x4046493D2EEACA0E); }
		public static void SET_PICKUP_LIGHT(Object _object, BOOL toggle) { Function.Call(0x7DFB49BCDB73089A, _object, toggle); }
		public static void _BLOCK_PICKUP_OBJECT_LIGHT(Object pickupObject, BOOL toggle) { Function.Call(0x50C14328119E1DD1, pickupObject, toggle); }
		public static void BLOCK_PICKUP_PLACEMENT_LIGHT(int pickup, BOOL toggle) { Function.Call(0x0552AA3FFC5B87AA, pickup, toggle); }
		public static void ALLOW_PICKUP_LIGHT_SYNC(Object pickupObject, BOOL allow) { Function.Call(0x7C348310A6E2FB91, pickupObject, allow); }
		public static void _SET_PEARLESCENT_FX_ENABLED(Object _object, BOOL toggle) { Function.Call(0x72E30372E7CC4415, _object, toggle); }
		public static void REMOVE_DECALS_IN_RANGE(float x, float y, float z, float range) { Function.Call(0x86DE59FA02902B40, x, y, z, range); }
		public static void REMOVE_DECALS_FROM_OBJECT(Object obj) { Function.Call(0xFB8972BAE0013140, obj); }
		public static int ADD_DECAL(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8, Any p9, Any p10, Any p11, Any p12, Any p13, Any p14, Any p15, Any p16, Any p17, Any p18, Any p19, Any p20, Any p21) { return Function.Call<int>(0x57CB267624EF85C0, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21); }
		public static void _ADD_BLOOD_POOL(float x, float y, float z, BOOL unused) { Function.Call(0xFA2ECC78A6014D4F, x, y, z, unused); }
		public static void _ADD_BLOOD_POOL_2(float x, float y, float z, float p3, float size, float p5, BOOL permanent, float p7, BOOL p8) { Function.Call(0xF708298675ABDC6A, x, y, z, p3, size, p5, permanent, p7, p8); }
		public static void _ADD_BLOOD_POOLS_FOR_PED(int ped) { Function.Call(0xDFCE8CE9F3EBE93F, ped); }
		public static void _ADD_BLOOD_POOLS_FOR_PED_WITH_PARAMS(int ped, float p1, float size, float p3) { Function.Call(0xC349EE1E6EFA494B, ped, p1, size, p3); }
		public static void START_PETROL_TRAIL_DECALS(Any p0, Any p1) { Function.Call(0x46F246D6504F0031, p0, p1); }
		public static void ADD_PETROL_TRAIL_DECAL_INFO(float x, float y, float z, float p3) { Function.Call(0x73354FB6D03D2E8A, x, y, z, p3); }
		public static void END_PETROL_TRAIL_DECALS() { Function.Call(0x0E126AAE933F3B56); }
		public static Any _0xE63D68F455CA0B47(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6) { return Function.Call<Any>(0xE63D68F455CA0B47, p0, p1, p2, p3, p4, p5, p6); }
		public static void REMOVE_DECAL(int decal) { Function.Call(0x49A720552EB0BB88, decal); }
		public static BOOL IS_DECAL_ALIVE(int decal) { return Function.Call<BOOL>(0x3E4B4E5CF5D3EEB5, decal); }
		public static void _0x53ED07BF368EDA59() { Function.Call(0x53ED07BF368EDA59); }
		public static void _0xB032C085D9A03907() { Function.Call(0xB032C085D9A03907); }
		public static void _0xFB680A9B33D0EDBE(BOOL p0) { Function.Call(0xFB680A9B33D0EDBE, p0); }
		public static void _0x41F88A85A579A61D(float p0) { Function.Call(0x41F88A85A579A61D, p0); }
		public static void _BLOOD_TRAIL_FOR_WAYPOINT(string waypointRecording, float p1) { Function.Call(0xB9C92616929CC25D, waypointRecording, p1); }
		public static void _ADD_BLOOD_TRAIL_POINT(float x, float y, float z) { Function.Call(0xDD9DC1AB63D513CE, x, y, z); }
		public static void _0x812C1563185C6FB2() { Function.Call(0x812C1563185C6FB2); }
		public static void _0x4BD66B4E3427689B(string p0) { Function.Call(0x4BD66B4E3427689B, p0); }
		public static void _ADD_BLOOD_TRAIL_SPLAT(float x, float y, float z) { Function.Call(0xF5E45CB1CF965D2D, x, y, z); }
		public static void _0xF2F543D48F319A3A() { Function.Call(0xF2F543D48F319A3A); }
		public static void _0x1460B644397453EB() { Function.Call(0x1460B644397453EB); }
		public static void _DISABLE_FAR_ARTIFICIAL_LIGHTS(BOOL disable) { Function.Call(0xCD284E2F6AC27EE9, disable); }
		public static void _0x453D16D41FC51D3E(BOOL p0) { Function.Call(0x453D16D41FC51D3E, p0); }
		public static void _0xC06F2F45A73EABCD(int entity) { Function.Call(0xC06F2F45A73EABCD, entity); }
		public static void SET_TIMECYCLE_MODIFIER(string modifierName) { Function.Call(0xFA08722A5EA82DA7, modifierName); }
		public static void SET_TIMECYCLE_MODIFIER_STRENGTH(float strength) { Function.Call(0xFDB74C9CC54C3F37, strength); }
		public static void SET_TRANSITION_TIMECYCLE_MODIFIER(string modifierName, float transitionBlend) { Function.Call(0xFF927A09F481D80C, modifierName, transitionBlend); }
		public static void SET_TRANSITION_OUT_OF_TIMECYCLE_MODIFIER(float strength) { Function.Call(0xBB6C707F20D955D4, strength); }
		public static void CLEAR_TIMECYCLE_MODIFIER() { Function.Call(0x0E3F4AF2D63491FB); }
		public static int GET_TIMECYCLE_MODIFIER_INDEX() { return Function.Call<int>(0xA705394293E2B3D3); }
		public static int GET_TIMECYCLE_TRANSITION_MODIFIER_INDEX() { return Function.Call<int>(0x2DA67BA3C8A6755D); }
		public static void _0x67B0778C62E74423(Any p0) { Function.Call(0x67B0778C62E74423, p0); }
		public static void _0x6C03118E9E5C1A14(Any p0) { Function.Call(0x6C03118E9E5C1A14, p0); }
		public static float _GET_MODIFIED_VISIBILITY_DISTANCE() { return Function.Call<float>(0x25CA89B2A39DCC69); }
		public static void _ENABLE_EXTRA_TIMECYCLE_MODIFIER_STRENGTH(float strength) { Function.Call(0x6FE93BCC7BF12B63, strength); }
		public static void SET_TV_CHANNEL(int channel) { Function.Call(0x593FAF7FC9401A56, channel); }
		public static int GET_TV_CHANNEL() { return Function.Call<int>(0xF90FBFD68F3C59AE); }
		public static void SET_TV_VOLUME(float volume) { Function.Call(0x73A97068787D7231, volume); }
		public static void DRAW_TV_CHANNEL(float xPos, float yPos, float xScale, float yScale, float rotation, int red, int green, int blue, int alpha) { Function.Call(0xC0A145540254A840, xPos, yPos, xScale, yScale, rotation, red, green, blue, alpha); }
		public static void SET_TV_CHANNEL_PLAYLIST(int tvChannel, string playlistName, BOOL restart) { Function.Call(0xDEC6B25F5DC8925B, tvChannel, playlistName, restart); }
		public static BOOL _IS_TV_PLAYLIST_ITEM_PLAYING(Hash videoCliphash) { return Function.Call<BOOL>(0x4D562223E0EB65F3, videoCliphash); }
		public static Any _0x5C674EB487891F6B() { return Function.Call<Any>(0x5C674EB487891F6B); }
		public static void ENABLE_MOVIE_SUBTITLES(BOOL toggle) { Function.Call(0x6FC9B065229C0787, toggle); }
		public static void _0x32DE2BFFDA43E62A() { Function.Call(0x32DE2BFFDA43E62A); }
		public static void _0xD543487A1F12828F(Any p0, Any p1, Any p2, Any p3) { Function.Call(0xD543487A1F12828F, p0, p1, p2, p3); }
		public static void _0xD9BC98B55BCFAA9B(Any p0) { Function.Call(0xD9BC98B55BCFAA9B, p0); }
		public static void _0x48FE0DB54045B975(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6) { Function.Call(0x48FE0DB54045B975, p0, p1, p2, p3, p4, p5, p6); }
		public static void _0x735762E8D7573E42(Any p0, Any p1, Any p2) { Function.Call(0x735762E8D7573E42, p0, p1, p2); }
		public static void _0x981C7D863980FA51() { Function.Call(0x981C7D863980FA51); }
		public static void _ANIMPOSTFX_PRELOAD_POSTFX(string effectName) { Function.Call(0x5199405EABFBD7F0, effectName); }
		public static BOOL _ANIMPOSTFX_HAS_LOADED(string effectName) { return Function.Call<BOOL>(0xBF2DD155B2ADCD0A, effectName); }
		public static void _ANIMPOSTFX_SET_TO_UNLOAD(string effectName) { Function.Call(0x37D7BDBA89F13959, effectName); }
		public static void ANIMPOSTFX_PLAY(string effectName) { Function.Call(0x4102732DF6B4005F, effectName); }
		public static void _ANIMPOSTFX_PLAY_TIMED(string effectName, int duration) { Function.Call(0x3A9A281FF71249E9, effectName, duration); }
		public static void ANIMPOSTFX_STOP(string effectName) { Function.Call(0xB4FD7446BAB2F394, effectName); }
		public static void _0x26DD2FB0A88CC412(string effectName, string effectName2, Any p2, Any p3) { Function.Call(0x26DD2FB0A88CC412, effectName, effectName2, p2, p3); }
		public static void _ANIMPOSTFX_CLEAR_EFFECT(string effectName) { Function.Call(0xC5CB91D65852ED7E, effectName); }
		public static BOOL ANIMPOSTFX_IS_RUNNING(string effectName) { return Function.Call<BOOL>(0x4A123E85D7C4CA0B, effectName); }
		public static BOOL _0x2D4F9C852CE8A253(string effectName) { return Function.Call<BOOL>(0x2D4F9C852CE8A253, effectName); }
		public static void ANIMPOSTFX_STOP_ALL() { Function.Call(0x66560A0D4C64FD21); }
		public static void _0xAD74C22A541AB987(string effectName) { Function.Call(0xAD74C22A541AB987, effectName); }
		public static void _ANIMPOSTFX_SET_STRENGTH(string effectName, float strength) { Function.Call(0xCAB4DD2D5B2B7246, effectName, strength); }
		public static void _ANIMPOSTFX_SET_POTENCY(string effectName, int p1, float potency) { Function.Call(0xF972F0AB16DC5260, effectName, p1, potency); }
		public static void _ANIMPOSTFX_SET_POSTFX_COLOR(string effectName, int p1, int red, int green, int blue, int alpha) { Function.Call(0x63011D0C7C6519E0, effectName, p1, red, green, blue, alpha); }
		public static BOOL _0xB958D97A0DFAA0C2(string effectName) { return Function.Call<BOOL>(0xB958D97A0DFAA0C2, effectName); }
		public static void _0xA201A3D0AC087C37(string effectName) { Function.Call(0xA201A3D0AC087C37, effectName); }
		public static unsafe BOOL _0xFBF161FCFEC8589E(string effectName, int p1, BOOL p2, BOOL* p3) { return Function.Call<BOOL>(0xFBF161FCFEC8589E, effectName, p1, p2, p3); }
		public static Hash _ANIMPOSTFX_GET_STACKHASH(string effectName) { return Function.Call<Hash>(0x842CCC9491FFCD9B, effectName); }
		public static void _ANIMPOSTFX_PRELOAD_POSTFX_BY_STACKHASH(Hash effectNameHash) { Function.Call(0xF3E039322BFBD4D8, effectNameHash); }
		public static BOOL ANIMPOSTFX_IS_PRELOADING_BY_STACKHASH(Hash effectNameHash) { return Function.Call<BOOL>(0x59EA80079B86D8C7, effectNameHash); }
		public static void _0x38D9D50F2085E9B3(Hash effectNameHash) { Function.Call(0x38D9D50F2085E9B3, effectNameHash); }
		public static void _ANIMPOSTFX_PLAY_TAG(Hash effectNameHash) { Function.Call(0x9B8D5D4CB8AF58B3, effectNameHash); }
		public static void _0xC76FC4C2FC5F4405(Hash effectNameHash) { Function.Call(0xC76FC4C2FC5F4405, effectNameHash); }
		public static void _ANIMPOSTFX_STOP_STACKHASH_POSTFX(Hash effectNameHash) { Function.Call(0xEDA5CBECF56E1386, effectNameHash); }
		public static BOOL _ANIMPOSTFX_IS_TAG_PLAYING(Hash effectNameHash) { return Function.Call<BOOL>(0xEEF83A759AE06A27, effectNameHash); }
		public static BOOL _0xE75CDDEBF618C8FF(Hash effectNameHash) { return Function.Call<BOOL>(0xE75CDDEBF618C8FF, effectNameHash); }
		public static void _0x71845905BCCDE781(Hash effectNameHash) { Function.Call(0x71845905BCCDE781, effectNameHash); }
		public static unsafe BOOL ANIMPOSTFX_HAS_EVENT_TRIGGERED_BY_STACKHASH(Hash effectNameHash, int p1, BOOL p2, BOOL* p3) { return Function.Call<BOOL>(0x9AB192A9EF980EED, effectNameHash, p1, p2, p3); }
		public static BOOL _0xFF584F097C17FA8F() { return Function.Call<BOOL>(0xFF584F097C17FA8F); }
		public static BOOL _0x3DA7A10583A4BEC0() { return Function.Call<BOOL>(0x3DA7A10583A4BEC0); }
		public static Any _0xC37792A3F9C90771() { return Function.Call<Any>(0xC37792A3F9C90771); }
		public static void _0xA0F4D12D6042F6D5(Any p0, Any p1) { Function.Call(0xA0F4D12D6042F6D5, p0, p1); }
		public static void _0x8996FA6AD9FE4E90(Any p0) { Function.Call(0x8996FA6AD9FE4E90, p0); }
		public static void _0xC38B4952B728397A(int vehicle, BOOL toggle) { Function.Call(0xC38B4952B728397A, vehicle, toggle); }
		public static BOOL PEDSHOT_IS_AVAILABLE() { return Function.Call<BOOL>(0xAF6E67D073D2DCE2); }
		public static BOOL _0xFD05B1DDE83749FA(string p0) { return Function.Call<BOOL>(0xFD05B1DDE83749FA, p0); }
		public static void _0xC2B8164C3BE871A4() { Function.Call(0xC2B8164C3BE871A4); }
		public static void _0x3E2FDDBE435A8787() { Function.Call(0x3E2FDDBE435A8787); }
		public static void _0x55285F885F662169() { Function.Call(0x55285F885F662169); }
		public static BOOL _0xD9C24F53631F2372(string texture, int ped, int playerSlot) { return Function.Call<BOOL>(0xD9C24F53631F2372, texture, ped, playerSlot); }
		public static void _0x196D3ACBEBA4A44B(int personaPhotoLocalCacheType) { Function.Call(0x196D3ACBEBA4A44B, personaPhotoLocalCacheType); }
		public static void _0xA1A86055792FB249(int personaPhotoLocalCacheType) { Function.Call(0xA1A86055792FB249, personaPhotoLocalCacheType); }
		public static BOOL _0x402E1A61D2587FCD(Any p0, float x, float y, float z, float p4, float p5, float heading) { return Function.Call<BOOL>(0x402E1A61D2587FCD, p0, x, y, z, p4, p5, heading); }
		public static Any _0x5C9C3A466B3296A8(Any p0) { return Function.Call<Any>(0x5C9C3A466B3296A8, p0); }
		public static Any _0xA15CCAB8AD038291(Any p0, Any p1, Any p2, Any p3) { return Function.Call<Any>(0xA15CCAB8AD038291, p0, p1, p2, p3); }
		public static Any _0x285438C26C732F9D() { return Function.Call<Any>(0x285438C26C732F9D); }
		public static void _SET_PROXY_INTERIOR_INDEX_ARTIFICIAL_LIGHTS_STATE(int proxyInteriorIndex, BOOL state) { Function.Call(0xBFCB17895BB99E4E, proxyInteriorIndex, state); }
		public static BOOL _IS_PROXY_INTERIOR_INDEX_ARTIFICIAL_LIGHTS_ENABLED(int proxyInteriorIndex) { return Function.Call<BOOL>(0x113857D66A9CABE6, proxyInteriorIndex); }
		public static int _GET_PROXY_INTERIOR_INDEX(int interiorId) { return Function.Call<int>(0x5D1C5D8E62E8EE1C, interiorId); }
		public static void _0x9D1B0B5066205692() { Function.Call(0x9D1B0B5066205692); }
		public static void _0xC489FE31AC726512(Any p0, Any p1) { Function.Call(0xC489FE31AC726512, p0, p1); }
		public static void _SET_CLOUD_LAYER(float x, float y, int p2) { Function.Call(0xB8C984C0D47F4F07, x, y, p2); }
		public static void _SET_CLOUD_NOISE(float x, float y, float z) { Function.Call(0xFE7966DF01452F32, x, y, z); }
		public static void _SET_CLOUD_POSITION(float x, float y, float z) { Function.Call(0x10C1767B93257480, x, y, z); }
		public static void _SET_CLOUD_HEIGHT(float height) { Function.Call(0xC332C91388F5580B, height); }
		public static void _0x085C5B61A0114F32(Any p0, Any p1) { Function.Call(0x085C5B61A0114F32, p0, p1); }
		public static void _0x1FF8731BE1DFC0C0(Any p0, Any p1) { Function.Call(0x1FF8731BE1DFC0C0, p0, p1); }
		public static Any _0xFC9B53C072F418E0() { return Function.Call<Any>(0xFC9B53C072F418E0); }
		public static void _0x94B261F1F35293E1(Any p0) { Function.Call(0x94B261F1F35293E1, p0); }
		public static void ENABLE_ENTITYMASK() { Function.Call(0xFAAD23DE7A54FC14); }
		public static void DISABLE_ENTITYMASK() { Function.Call(0x5C9978A2A3DC3D0D); }
		public static void _ADD_ENTITY_TO_ENTITY_MASK(int entity, int mask) { Function.Call(0xC6F81FCD15350323, entity, mask); }
		public static void _ADD_ENTITY_TO_ENTITY_MASK_WITH_INTENSITY(int entity, int mask, float intensity) { Function.Call(0x958DEBD9353C0935, entity, mask, intensity); }
		public static void _REMOVE_ENTITY_FROM_ENTITY_MASK(int entity) { Function.Call(0x56A786E87FF53478, entity); }
		public static Any _0xE8A8378BF651079C(Any p0, Any p1, Any p2, Any p3, Any p4) { return Function.Call<Any>(0xE8A8378BF651079C, p0, p1, p2, p3, p4); }
		public static void _0xE92012611461A42A(Any p0, Any p1, Any p2, Any p3, Any p4) { Function.Call(0xE92012611461A42A, p0, p1, p2, p3, p4); }
		public static void _0x249CD6B7285536F2(Any p0, Any p1, Any p2) { Function.Call(0x249CD6B7285536F2, p0, p1, p2); }
		public static void _0xAF4D239B8903FCBE() { Function.Call(0xAF4D239B8903FCBE); }
		public static void _SET_SNOW_COVERAGE_TYPE(int type) { Function.Call(0xF02A9C330BBFC5C7, type); }
		public static void _0x519928DF02EB5101(Any p0) { Function.Call(0x519928DF02EB5101, p0); }
		public static void _0x1C6306E5BC25C29C() { Function.Call(0x1C6306E5BC25C29C); }
	}

	public static class GANG
	{
		public static BOOL NETWORK_IS_GANG_ID_VALID(Any gangId) { return Function.Call<BOOL>(0xD6F6ACF4392187FB, gangId); }
		public static BOOL NETWORK_IS_GANG_IN_SESSION(Any gangId) { return Function.Call<BOOL>(0x93A91A351A07360E, gangId); }
		public static BOOL NETWORK_IS_GANG_ACTIVE(Any gangId) { return Function.Call<BOOL>(0x0F99F6436528A089, gangId); }
		public static BOOL _NETWORK_IS_GANG_OPEN(Any gangId) { return Function.Call<BOOL>(0xFCF96CCBD81B24C8, gangId); }
		public static Any _0x9970AE8C3D706139() { return Function.Call<Any>(0x9970AE8C3D706139); }
		public static void _0xD1A226F2E05E58FC(Any p0, Any p1) { Function.Call(0xD1A226F2E05E58FC, p0, p1); }
		public static Any _0xC5BF29F4035277C2(Any p0) { return Function.Call<Any>(0xC5BF29F4035277C2, p0); }
		public static void _NETWORK_LEAVE_GANG(BOOL disband) { Function.Call(0x0A04A07BC3074EDB, disband); }
		public static void _NETWORK_KICK_GANG_MEMBER(int player, int banTimeSeconds) { Function.Call(0xCD9E2D9BC52FD80F, player, banTimeSeconds); }
		public static Any _0xC0474C8BCF6787AD(Any p0) { return Function.Call<Any>(0xC0474C8BCF6787AD, p0); }
		public static BOOL NETWORK_IS_GANG_LEADER(int player) { return Function.Call<BOOL>(0x424B17A7DC5C90BC, player); }
		public static BOOL _NETWORK_IS_GANG_MEMBER(Any gangId, int player) { return Function.Call<BOOL>(0x9BE7DCB22D32CCBE, gangId, player); }
		public static BOOL NETWORK_IS_IN_SAME_GANG(int player1, int player2) { return Function.Call<BOOL>(0x3F59FE6F37869576, player1, player2); }
		public static BOOL _NETWORK_IS_IN_MY_GANG(int player) { return Function.Call<BOOL>(0x81FB74C83C2ED69F, player); }
		public static int NETWORK_GET_NUM_GANG_MEMBERS(Any gangId) { return Function.Call<int>(0x149A2751AB66AC02, gangId); }
		public static int _NETWORK_GET_GANG_SIZE(Any gangId) { return Function.Call<int>(0x853B0FA4D8732C57, gangId); }
		public static Any _0x833D8268D51B4522(Any p0) { return Function.Call<Any>(0x833D8268D51B4522, p0); }
		public static Any NETWORK_GET_GANG_ID(int player) { return Function.Call<Any>(0x901E0DC25080C8B9, player); }
		public static unsafe int _NETWORK_GET_GANG_MEMBERS(Any gangId, Any* memberHandles) { return Function.Call<int>(0xD1BF325C8252A982, gangId, memberHandles); }
		public static Any _0xDA801F7F6A5278D3(Any p0) { return Function.Call<Any>(0xDA801F7F6A5278D3, p0); }
		public static Any _0x2F7EB8B6F6AFE79C(Any p0) { return Function.Call<Any>(0x2F7EB8B6F6AFE79C, p0); }
		public static Any _0x53A94294FDDCF98C(Any p0, Any p1) { return Function.Call<Any>(0x53A94294FDDCF98C, p0, p1); }
		public static int NETWORK_GET_GANG_LEADER(Any gangId) { return Function.Call<int>(0x4BE6C13A45CCA8EC, gangId); }
		public static unsafe BOOL _NETWORK_GET_GANG_LEADER_HANDLE(Any gangId, Any* gamerHandle) { return Function.Call<BOOL>(0xCE88A261DCBBA0D9, gangId, gamerHandle); }
		public static BOOL _0x6102830F764B3DE1(int player) { return Function.Call<BOOL>(0x6102830F764B3DE1, player); }
		public static void _0xB38C256498748413() { Function.Call(0xB38C256498748413); }
		public static Any _0xE4C64CD37CB176AA(Any p0) { return Function.Call<Any>(0xE4C64CD37CB176AA, p0); }
		public static Any _0x7BAA30C9BBE8AEE7(Any p0, Any p1) { return Function.Call<Any>(0x7BAA30C9BBE8AEE7, p0, p1); }
		public static Any _0x0E5C9FB9ED5DFF1C(Any p0) { return Function.Call<Any>(0x0E5C9FB9ED5DFF1C, p0); }
		public static void _0xB22B1D9F74095382(Any p0) { Function.Call(0xB22B1D9F74095382, p0); }
		public static void _0xEE4F20004D0288B7() { Function.Call(0xEE4F20004D0288B7); }
		public static void _0xAD22AB64FA428DF3(Any p0) { Function.Call(0xAD22AB64FA428DF3, p0); }
		public static Any _0x48D82C83987E18E4(Any p0) { return Function.Call<Any>(0x48D82C83987E18E4, p0); }
		public static void _0xA9CEAE8D6637FBAD(Any p0) { Function.Call(0xA9CEAE8D6637FBAD, p0); }
		public static Any _0x51C5EF47086AA0D7() { return Function.Call<Any>(0x51C5EF47086AA0D7); }
		public static Any _0x644E02F24F9D4E98(Any p0, Any p1) { return Function.Call<Any>(0x644E02F24F9D4E98, p0, p1); }
		public static Any _0x3ADC71A66356D706() { return Function.Call<Any>(0x3ADC71A66356D706); }
		public static Any _0xFA7C5B7E087A4CEB() { return Function.Call<Any>(0xFA7C5B7E087A4CEB); }
		public static Any _0x1F11702DDBD915C6(Any p0, Any p1) { return Function.Call<Any>(0x1F11702DDBD915C6, p0, p1); }
		public static Any _0x7933754F260B428A(int player) { return Function.Call<Any>(0x7933754F260B428A, player); }
		public static Any _0xAFD3599A3CC5637D() { return Function.Call<Any>(0xAFD3599A3CC5637D); }
		public static void _0xC81A9E2C8EFD28D5(Any p0) { Function.Call(0xC81A9E2C8EFD28D5, p0); }
	}

	public static class GOOGLE_ANALYTICS
	{
		public static void _GOOGLE_ANALYTICS_PUSH_PAGE(string pageName) { Function.Call(0xD43A616AE3AC4EF6, pageName); }
		public static void _GOOGLE_ANALYTICS_POP_PAGE(string pageName) { Function.Call(0xC6DE040378364798, pageName); }
		public static BOOL _GOOGLE_ANALYTICS_START_EVENT(string _eventCategory, string _eventAction, string _eventLabel, int _eventValue) { return Function.Call<BOOL>(0x1C54F031D7C0F7AC, _eventCategory, _eventAction, _eventLabel, _eventValue); }
		public static BOOL _GOOGLE_ANALYTICS_END_EVENT() { return Function.Call<BOOL>(0x87BBCC4360A9BDE3); }
	}

	public static class HUD
	{
		public static void _ENABLE_REDUCED_MENU_TIME_SCALE() { Function.Call(0x26F6BBEA2CE3E3DC); }
		public static void _DISABLE_REDUCED_MENU_TIME_SCALE() { Function.Call(0xC5C7A2F6567FCCBC); }
		public static void _ENABLE_HUD_CONTEXT_THIS_FRAME(Hash component) { Function.Call(0xC9CAEAEEC1256E54, component); }
		public static void _ENABLE_HUD_CONTEXT(Hash component) { Function.Call(0x4CC5F2FC1332577F, component); }
		public static void _DISABLE_HUD_CONTEXT(Hash component) { Function.Call(0x8BC7C1F929D07BF3, component); }
		public static Any _0x7EC0D68233E391AC(Any p0) { return Function.Call<Any>(0x7EC0D68233E391AC, p0); }
		public static void _BUSYSPINNER_SET_TEXT(string text) { Function.Call(0x7F78CD75CC4539E4, text); }
		public static void BUSYSPINNER_OFF() { Function.Call(0x58F441B90EA84D06); }
		public static BOOL BUSYSPINNER_IS_ON() { return Function.Call<BOOL>(0x823BF7B1DF613A21); }
		public static string _GET_TEXT_SUBSTRING(string text, int position, int length) { return Function.Call<string>(0x9D7E12EC6A1EE4E5, text, position, length); }
		public static string _GET_LABEL_TEXT(string labelName) { return Function.Call<string>(0xCFEDCCAD3C5BA90D, labelName); }
		public static void CLEAR_ALL_HELP_MESSAGES() { Function.Call(0x916ED8321F087059); }
		public static BOOL TEXT_BLOCK_IS_LOADED(string textBlock) { return Function.Call<BOOL>(0xD0976CC34002DB57, textBlock); }
		public static BOOL _TEXT_BLOCK_IS_STREAMED(string textBlock) { return Function.Call<BOOL>(0x3CF96E16265B7DC8, textBlock); }
		public static void TEXT_BLOCK_REQUEST(string textBlock) { Function.Call(0xF66090013DE648D5, textBlock); }
		public static void _TEXT_BLOCK_DELETE(string textBlock) { Function.Call(0xAA03F130A637D923, textBlock); }
		public static BOOL _DOES_TEXT_BLOCK_EXIST(string textDatabase) { return Function.Call<BOOL>(0x2C729F2B94CEA911, textDatabase); }
		public static BOOL DOES_TEXT_LABEL_EXIST(string label) { return Function.Call<BOOL>(0x73C258C68D6F55B6, label); }
		public static string _GET_LABEL_TEXT_2(string label) { return Function.Call<string>(0x3429670F9B9EF2D3, label); }
		public static string _GET_TEXT_SUBSTRING_2(string text, int length) { return Function.Call<string>(0xD8402B858F4DDD88, text, length); }
		public static Any _0x806862E5D266CF38(Any p0, Any p1, Any p2) { return Function.Call<Any>(0x806862E5D266CF38, p0, p1, p2); }
		public static int GET_LENGTH_OF_LITERAL_STRING(string _string) { return Function.Call<int>(0x481FBF588B0B76DB, _string); }
		public static int GET_LENGTH_OF_LITERAL_STRING_IN_BYTES(string _string) { return Function.Call<int>(0xDC5AD6B7AB8184F5, _string); }
		public static string GET_STRING_FROM_HASH_KEY(Hash labelHash) { return Function.Call<string>(0xBD5DD5EAE2B6CE14, labelHash); }
		public static BOOL IS_RADAR_PREFERENCE_SWITCHED_ON() { return Function.Call<BOOL>(0x81E47F0EE1F2B21E); }
		public static BOOL IS_SUBTITLE_PREFERENCE_SWITCHED_ON() { return Function.Call<BOOL>(0x7C4AC9573587F2DF); }
		public static void DISPLAY_HUD(BOOL toggle) { Function.Call(0xD63FE3AF9FB3D53F, toggle); }
		public static BOOL IS_HUD_HIDDEN() { return Function.Call<BOOL>(0x71B72B478F8189DC); }
		public static BOOL IS_RADAR_HIDDEN() { return Function.Call<BOOL>(0x1B82FD5FFA4D666E); }
		public static BOOL IS_RADAR_HIDDEN_BY_SCRIPT() { return Function.Call<BOOL>(0x66F35DD9D2B58579); }
		public static unsafe void _GET_COLOR_FROM_NAME(Hash colorNameHash, int* red, int* green, int* blue, int* alpha) { Function.Call(0xB981DD2DFAF9B1C9, colorNameHash, red, green, blue, alpha); }
		public static void _DISPLAY_TEXT(string text, float xPos, float yPos) { Function.Call(0xD79334A4BB99BAD1, text, xPos, yPos); }
		public static void _SET_TEXT_COLOR(int r, int g, int b, int a) { Function.Call(0x50A41AD966910F03, r, g, b, a); }
		public static void SET_TEXT_RENDER_ID(int renderId) { Function.Call(0xE550CDE128D56757, renderId); }
		public static BOOL REGISTER_NAMED_RENDERTARGET(string name, BOOL p1) { return Function.Call<BOOL>(0x98AF2BB6F62BD588, name, p1); }
		public static BOOL IS_NAMED_RENDERTARGET_REGISTERED(string name) { return Function.Call<BOOL>(0x3EE32F7964C40FE6, name); }
		public static BOOL RELEASE_NAMED_RENDERTARGET(string name) { return Function.Call<BOOL>(0x0E692EE61761361F, name); }
		public static void LINK_NAMED_RENDERTARGET(Hash modelHash) { Function.Call(0x2F506B8556242DDB, modelHash); }
		public static int GET_NAMED_RENDERTARGET_RENDER_ID(string name) { return Function.Call<int>(0xB6762A85EE29AA60, name); }
		public static BOOL IS_NAMED_RENDERTARGET_LINKED(Hash modelHash) { return Function.Call<BOOL>(0x707032835FF09AE7, modelHash); }
		public static void _0x9D37EB5003E0F2CF(Any p0, Any p1) { Function.Call(0x9D37EB5003E0F2CF, p0, p1); }
		public static void HIDE_LOADING_ON_FADE_THIS_FRAME() { Function.Call(0xEA600AABAF4B9084); }
		public static void _0x052D4AC0922AF91A(Any p0, Any p1) { Function.Call(0x052D4AC0922AF91A, p0, p1); }
		public static void HIDE_HUD_AND_RADAR_THIS_FRAME() { Function.Call(0x36CDD81627A6FCD2); }
		public static void _0x8A59D44189AF2BC5(Any p0, Any p1) { Function.Call(0x8A59D44189AF2BC5, p0, p1); }
		public static void _0x160825DADF1B04B3() { Function.Call(0x160825DADF1B04B3); }
		public static Any _0x9C409BBC492CB5B1() { return Function.Call<Any>(0x9C409BBC492CB5B1); }
		public static Any _0x0501D52D24EA8934(Any p0) { return Function.Call<Any>(0x0501D52D24EA8934, p0); }
		public static Any _0x100157D6D7FE32CA(Any p0, Any p1) { return Function.Call<Any>(0x100157D6D7FE32CA, p0, p1); }
		public static Any _0x28AE29D909C8FDCE(Any p0) { return Function.Call<Any>(0x28AE29D909C8FDCE, p0); }
		public static void _0x2F7BB105144ACF30() { Function.Call(0x2F7BB105144ACF30); }
		public static void _0xBFFF81E12A745A5F() { Function.Call(0xBFFF81E12A745A5F); }
		public static void SET_MISSION_NAME(BOOL p0, string name) { Function.Call(0x402669A4BDAA72DA, p0, name); }
		public static void SET_MISSION_NAME_FOR_UGC_MISSION(BOOL p0, string name) { Function.Call(0xD98630CE73C61E98, p0, name); }
		public static void _0xCE0D2F5586627CCE(Any p0, Any p1, Any p2, Any p3, Any p4) { Function.Call(0xCE0D2F5586627CCE, p0, p1, p2, p3, p4); }
		public static unsafe BOOL GET_HUD_SCREEN_POSITION_FROM_WORLD_POSITION(float worldX, float worldY, float worldZ, float* screenX, float* screenY) { return Function.Call<BOOL>(0xB39C81628EF10B42, worldX, worldY, worldZ, screenX, screenY); }
		public static void _HIDE_HUD_THIS_FRAME() { Function.Call(0xBF4F34A85CA2970D); }
		public static void DISABLE_FRONTEND_THIS_FRAME() { Function.Call(0x56CE42A528156A67); }
		public static void _0x5651516D947ABC53() { Function.Call(0x5651516D947ABC53); }
		public static void _ALLOW_PAUSE_MENU_WHEN_DEAD_THIS_FRAME() { Function.Call(0x30996422DF1EE561); }
		public static void SET_FRONTEND_ACTIVE(BOOL active) { Function.Call(0xCE47C21C0687EBC2, active); }
		public static BOOL IS_PAUSE_MENU_ACTIVE() { return Function.Call<BOOL>(0x535384D6067BA42E); }
		public static void _SHOW_PLAYER_CORES(BOOL state) { Function.Call(0x50C803A4CD5932C5, state); }
		public static void _SHOW_HORSE_CORES(BOOL state) { Function.Call(0xD4EE21B7CC7FD350, state); }
		public static void _0x3FE4FB41EF7D2196(Any p0) { Function.Call(0x3FE4FB41EF7D2196, p0); }
		public static void _JOURNAL_WRITE_ENTRY(Any p0) { Function.Call(0x6DFDD665E416B093, p0); }
		public static Any _JOURNAL_CAN_WRITE_ENTRY(Any p0) { return Function.Call<Any>(0xCF782691D91F270E, p0); }
		public static Any _JOURNAL_GET_ENTRY_COUNT() { return Function.Call<Any>(0xE65B5DE53351BE22); }
		public static Any _JOURNAL_GET_ENTRY_AT_INDEX(Any p0) { return Function.Call<Any>(0x3D16ABD7A1FD8C96, p0); }
		public static Any _JOURNAL_GET_GRIME_AT_INDEX(Any p0) { return Function.Call<Any>(0xCB5945E1B855852F, p0); }
		public static Any _JOURNAL_GET_ENTRY_INFO(Any p0, Any p1) { return Function.Call<Any>(0x5514C3E60673530F, p0, p1); }
		public static Any _JOURNAL_GET_TEXTURE_WITH_LAYOUT(Any p0, Any p1, Any p2) { return Function.Call<Any>(0x62CC549B3B8EA2AA, p0, p1, p2); }
		public static void _JOURNAL_MARK_READ(Any p0) { Function.Call(0xE4509BABE59BD24E, p0); }
		public static void _JOURNAL_CLEAR_ALL_PROGRESS() { Function.Call(0xF402978DE6F88D6E); }
		public static Any UI_REQUEST_SCENE(Any p0, Any p1) { return Function.Call<Any>(0xB6857100F8FD433C, p0, p1); }
		public static void _0xF1E6979C0B779985(int uiscene) { Function.Call(0xF1E6979C0B779985, uiscene); }
		public static Any UI_GET_SCENE_UIOBJECT(Any p0) { return Function.Call<Any>(0xBE1067CD1C9570F6, p0); }
		public static void UI_MOVIEVIEW_SET_RENDER_TARGET(Any p0, Any p1) { Function.Call(0x51DE09A2196BD951, p0, p1); }
		public static Prompt _UI_PROMPT_CREATE(Hash inputHash, string labelName, Any p2, Any p3, Any p4, int p5) { return Function.Call<Prompt>(0x29FA7910726C3889, inputHash, labelName, p2, p3, p4, p5); }
		public static Prompt _UI_PROMPT_REGISTER_BEGIN() { return Function.Call<Prompt>(0x04F97DE45A519419); }
		public static void _UI_PROMPT_REGISTER_END(Prompt prompt) { Function.Call(0xF7AA2696A22AD8B9, prompt); }
		public static void _UI_PROMPT_SET_PRIORITY(Prompt prompt, int priority) { Function.Call(0xCA24F528D0D16289, prompt, priority); }
		public static Any _UI_PROMPT_SET_CONTROL_ACTION(Prompt prompt, Hash control) { return Function.Call<Any>(0xB5352B7494A08258, prompt, control); }
		public static void _UI_PROMPT_SET_ALLOWED_ACTION(Prompt prompt, Hash control) { Function.Call(0x565C1CE183CB0EAF, prompt, control); }
		public static void _UI_PROMPT_SET_STANDARD_MODE(Prompt prompt, BOOL releaseMode) { Function.Call(0xCC6656799977741B, prompt, releaseMode); }
		public static BOOL _UI_PROMPT_HAS_STANDARD_MODE_COMPLETED(Prompt prompt, int p1) { return Function.Call<BOOL>(0xC92AC953F0A982AE, prompt, p1); }
		public static void _UI_PROMPT_SET_PRESSED_TIMED_MODE(Prompt prompt, int depletionTimeMs) { Function.Call(0x1473D3AF51D54276, prompt, depletionTimeMs); }
		public static BOOL _UI_PROMPT_HAS_PRESSED_TIMED_MODE_COMPLETED(Prompt prompt) { return Function.Call<BOOL>(0x3CE854D250A88DAF, prompt); }
		public static BOOL _UI_PROMPT_HAS_PRESSED_TIMED_MODE_FAILED(Prompt prompt) { return Function.Call<BOOL>(0x1A17B9ECFF617562, prompt); }
		public static void _UI_PROMPT_SET_HOLD_MODE(Prompt prompt, int holdTimeMs) { Function.Call(0x94073D5CA3F16B7B, prompt, holdTimeMs); }
		public static void _UI_PROMPT_SET_STANDARDIZED_HOLD_MODE(Prompt prompt, Hash timedEventHash) { Function.Call(0x74C7D7B72ED0D3CF, prompt, timedEventHash); }
		public static void _UI_PROMPT_SET_HOLD_INDEFINITELY_MODE(Prompt prompt) { Function.Call(0xEA5CCF4EEB2F82D1, prompt); }
		public static void _UI_PROMPT_SET_HOLD_AUTO_FILL_MODE(Prompt prompt, int autoFillTimeMs, int holdTimeMs) { Function.Call(0x3CE932E737C145D6, prompt, autoFillTimeMs, holdTimeMs); }
		public static void _UI_PROMPT_SET_HOLD_AUTO_FILL_WITH_DECAY_MODE(Prompt prompt, int autoFillTimeMs, int holdTimeMs) { Function.Call(0xA3F2149AA24F3D8E, prompt, autoFillTimeMs, holdTimeMs); }
		public static BOOL _UI_PROMPT_HAS_HOLD_AUTO_FILL_MODE(Prompt prompt) { return Function.Call<BOOL>(0x8010BEBD0D5ED5BC, prompt); }
		public static BOOL _UI_PROMPT_HAS_HOLD_MODE(Prompt prompt) { return Function.Call<BOOL>(0xB60C9F9ED47ABB76, prompt); }
		public static BOOL _UI_PROMPT_IS_HOLD_MODE_RUNNING(Prompt prompt) { return Function.Call<BOOL>(0xC7D70EAEF92EFF48, prompt); }
		public static BOOL _UI_PROMPT_HAS_HOLD_MODE_COMPLETED(Prompt prompt) { return Function.Call<BOOL>(0xE0F65F0640EF0617, prompt); }
		public static Any _0x81801291806DBC50(Any p0) { return Function.Call<Any>(0x81801291806DBC50, p0); }
		public static void _UI_PROMPT_SET_MASH_MODE(Prompt prompt, int mashes) { Function.Call(0xDF6423BF071C7F71, prompt, mashes); }
		public static void _UI_PROMPT_SET_MASH_INDEFINITELY_MODE(Prompt prompt) { Function.Call(0x7B66E89312727274, prompt); }
		public static void _UI_PROMPT_SET_MASH_WITH_RESISTANCE_MODE(Prompt prompt, int mashes, float p2, float p3) { Function.Call(0xCD1BDFF15EFA79F5, prompt, mashes, p2, p3); }
		public static void _UI_PROMPT_SET_MASH_WITH_RESISTANCE_CAN_FAIL_MODE(Prompt prompt, int mashes, float p2, float p3) { Function.Call(0xDC0CB602DEADBA53, prompt, mashes, p2, p3); }
		public static void _UI_PROMPT_SET_MASH_AUTO_FILL_MODE(Prompt prompt, int autoFillTimeMs, int mashes) { Function.Call(0x6C39587D7CC66801, prompt, autoFillTimeMs, mashes); }
		public static void _UI_PROMPT_SET_MASH_MANUAL_MODE(Prompt prompt, float p1, float p2, float p3, Any p4) { Function.Call(0x32DF729D8BD3C1C6, prompt, p1, p2, p3, p4); }
		public static void _UI_PROMPT_SET_MASH_MANUAL_CAN_FAIL_MODE(Prompt prompt, float p1, float p2, float p3, Any p4) { Function.Call(0x179DCF71F705DA20, prompt, p1, p2, p3, p4); }
		public static BOOL _UI_PROMPT_HAS_MANUAL_MASH_MODE(Prompt prompt) { return Function.Call<BOOL>(0xA6C6A4ADB3BAC409, prompt); }
		public static BOOL _UI_PROMPT_HAS_MASH_MODE(Prompt prompt) { return Function.Call<BOOL>(0xCD072523791DDC1B, prompt); }
		public static Any _0xB0E8599243B3F568(Any p0) { return Function.Call<Any>(0xB0E8599243B3F568, p0); }
		public static BOOL _UI_PROMPT_HAS_MASH_MODE_COMPLETED(Prompt prompt) { return Function.Call<BOOL>(0x845CE958416DC473, prompt); }
		public static BOOL _UI_PROMPT_HAS_MASH_MODE_FAILED(Prompt prompt) { return Function.Call<BOOL>(0x25B18E530CF39D6F, prompt); }
		public static float _UI_PROMPT_GET_MASH_MODE_PROGRESS(Prompt prompt) { return Function.Call<float>(0x8A9585293863B8A5, prompt); }
		public static void _UI_PROMPT_SET_MASH_MANUAL_MODE_INCREASE_PER_PRESS(Prompt prompt, float rate) { Function.Call(0xA0D1D79C6036A855, prompt, rate); }
		public static void _UI_PROMPT_SET_MASH_MANUAL_MODE_DECAY_SPEED(Prompt prompt, float speed) { Function.Call(0x7D393C247FB9B431, prompt, speed); }
		public static void _UI_PROMPT_SET_MASH_MANUAL_MODE_PRESSED_GROWTH_SPEED(Prompt prompt, float speed) { Function.Call(0x56DBB26F98582C29, prompt, speed); }
		public static void _UI_PROMPT_SET_ROTATE_MODE(Prompt prompt, float p1, BOOL counterclockwise) { Function.Call(0x7ABE7095FB3D2581, prompt, p1, counterclockwise); }
		public static void _UI_PROMPT_SET_TARGET_MODE(Prompt prompt, float p1, float p2, Any p3) { Function.Call(0x5F6503D9CD2754EB, prompt, p1, p2, p3); }
		public static void _UI_PROMPT_SET_TARGET_MODE_TARGET(Prompt prompt, float p1, float p2) { Function.Call(0x5E019C45DD3B6A14, prompt, p1, p2); }
		public static void _UI_PROMPT_SET_TARGET_MODE_PROGRESS(Prompt prompt, float progress) { Function.Call(0x00123054BEC8A30F, prompt, progress); }
		public static void _UI_PROMPT_SET_BEAT_MODE(Prompt prompt, BOOL toggle) { Function.Call(0xF957A1654C6322FE, prompt, toggle); }
		public static BOOL _UI_PROMPT_WAS_BEAT_MODE_PRESSED_IN_TIME_WINDOW(Prompt prompt) { return Function.Call<BOOL>(0x1FE4788AB1430C55, prompt); }
		public static void _UI_PROMPT_SET_BEAT_MODE_GRAYED_OUT(Prompt prompt, Any p1) { Function.Call(0xB487A4936FBF40AC, prompt, p1); }
		public static void _UI_PROMPT_RESTART_MODES(Prompt prompt) { Function.Call(0xDC6C55DFA2C24EE5, prompt); }
		public static void _UI_PROMPT_SET_SPINNER_SPEED(Prompt prompt, Any p1) { Function.Call(0xAC6586A7FDCD4B68, prompt, p1); }
		public static void _UI_PROMPT_SET_SPINNER_POSITION(Prompt prompt, Any p1) { Function.Call(0x832CB510DE546282, prompt, p1); }
		public static void _UI_PROMPT_SET_URGENT_PULSING_ENABLED(Prompt prompt, BOOL toggle) { Function.Call(0xC5F428EE08FA7F2C, prompt, toggle); }
		public static BOOL _UI_PROMPT_GET_URGENT_PULSING_ENABLED(Prompt prompt) { return Function.Call<BOOL>(0x1FBA0DABECDDB52B, prompt); }
		public static void _UI_PROMPT_SET_TAG(Prompt prompt, Any p1) { Function.Call(0xDEC85C174751292B, prompt, p1); }
		public static int _UI_PROMPT_GET_GROUP_ID_FOR_TARGET_ENTITY(int entity) { return Function.Call<int>(0xB796970BD125FCE8, entity); }
		public static int _UI_PROMPT_GET_GROUP_ID_FOR_SCENARIO_POINT(Any p0, int p1) { return Function.Call<int>(0xCB73D7521E7103F0, p0, p1); }
		public static void _UI_PROMPT_SET_GROUP(Prompt prompt, int groupId, int tabIndex) { Function.Call(0x2F11D3A254169EA4, prompt, groupId, tabIndex); }
		public static void _UI_PROMPT_REMOVE_GROUP(Prompt prompt, Any p1) { Function.Call(0x4E52C800A28F7BE8, prompt, p1); }
		public static Any _UI_PROMPT_SET_ACTIVE_GROUP_THIS_FRAME(Hash hash, string name, int tabAmount, int tabDefaultIndex, int p4, Prompt prompt) { return Function.Call<Any>(0xC65A45D4453C2627, hash, name, tabAmount, tabDefaultIndex, p4, prompt); }
		public static int _UI_PROMPT_GET_GROUP_ACTIVE_PAGE(Hash hash) { return Function.Call<int>(0xC1FCC36C3F7286C8, hash); }
		public static Any _UI_PROMPT_SET_AMBIENT_GROUP_THIS_FRAME(int entity, float p1, int p2, int p3, Hash p4, string name, int p6) { return Function.Call<Any>(0x315C81D760609108, entity, p1, p2, p3, p4, name, p6); }
		public static Any _0x8B55B324A9123F6B(int groupId, Volume volume, string p2, Any p3, Any p4, Any p5) { return Function.Call<Any>(0x8B55B324A9123F6B, groupId, volume, p2, p3, p4, p5); }
		public static BOOL _UI_PROMPT_DOES_AMBIENT_GROUP_EXIST(Hash hash) { return Function.Call<BOOL>(0xEB550B927B34A1BB, hash); }
		public static void _UI_PROMPT_ADD_GROUP_LINK(Any p0, Prompt prompt, Any p2) { Function.Call(0x684C96CC7C66E8EF, p0, prompt, p2); }
		public static void _UI_PROMPT_ADD_GROUP_RETURN_LINK(Any p0, Prompt prompt) { Function.Call(0x837972ED28159536, p0, prompt); }
		public static void _UI_PROMPT_SET_TRANSPORT_MODE(Prompt prompt, int mode) { Function.Call(0x876E4A35C73A6655, prompt, mode); }
		public static void _UI_PROMPT_DISABLE_PROMPTS_THIS_FRAME() { Function.Call(0xF1622CE88A1946FB); }
		public static void _UI_PROMPT_DELETE(Prompt prompt) { Function.Call(0x00EDE88D4D13CF59, prompt); }
		public static BOOL _UI_PROMPT_IS_VALID(Prompt prompt) { return Function.Call<BOOL>(0x347469FBDD1589A9, prompt); }
		public static BOOL _UI_PROMPT_IS_ACTIVE(Prompt prompt) { return Function.Call<BOOL>(0x546E342E01DE71CF, prompt); }
		public static void _UI_PROMPT_SET_VISIBLE(Prompt prompt, BOOL toggle) { Function.Call(0x71215ACCFDE075EE, prompt, toggle); }
		public static void _UI_PROMPT_SET_ENABLED(Prompt prompt, BOOL toggle) { Function.Call(0x8A0FB4D03A630D21, prompt, toggle); }
		public static void _UI_PROMPT_SET_TEXT(Prompt prompt, string text) { Function.Call(0x5DD02A8318420DD7, prompt, text); }
		public static void _UI_PROMPT_SET_ATTRIBUTE(Prompt prompt, int attribute, BOOL enabled) { Function.Call(0x560E76D5E2E1803F, prompt, attribute, enabled); }
		public static void _UI_PROMPT_SET_TYPE(Prompt prompt, int type) { Function.Call(0xF4A5C4509BF923B1, prompt, type); }
		public static void _0x53CE46C01A089DA1(Prompt prompt, Any p1) { Function.Call(0x53CE46C01A089DA1, prompt, p1); }
		public static void _UI_PROMPT_SET_MANUAL_RESOLVED(Prompt prompt, Any p1) { Function.Call(0xA520C7B05FA4EB2A, prompt, p1); }
		public static void _UI_PROMPT_CONTEXT_SET_VOLUME(Prompt prompt, Volume volume) { Function.Call(0x4D107406667423BE, prompt, volume); }
		public static void _UI_PROMPT_CONTEXT_SET_POINT(Prompt prompt, float x, float y, float z) { Function.Call(0xAE84C5EE2C384FB3, prompt, x, y, z); }
		public static void _UI_PROMPT_CONTEXT_SET_RADIUS(Prompt prompt, float radius) { Function.Call(0x0C718001B77CA468, prompt, radius); }
		public static BOOL _UI_PROMPT_IS_PRESSED(Prompt prompt) { return Function.Call<BOOL>(0x21E60E230086697F, prompt); }
		public static BOOL _UI_PROMPT_IS_JUST_PRESSED(Prompt prompt) { return Function.Call<BOOL>(0x2787CC611D3FACC5, prompt); }
		public static BOOL _UI_PROMPT_IS_JUST_RELEASED(Prompt prompt) { return Function.Call<BOOL>(0x635CC82FA297A827, prompt); }
		public static BOOL _UI_PROMPT_IS_RELEASED(Prompt prompt) { return Function.Call<BOOL>(0xAFC887BA7A7756D6, prompt); }
		public static void _UI_PROMPT_ENABLE_PROMPT_TYPE_THIS_FRAME(int p0) { Function.Call(0x06565032897BA861, p0); }
		public static void _UI_PROMPT_DISABLE_PROMPT_TYPE_THIS_FRAME(int p0) { Function.Call(0xFC094EF26DD153FA, p0); }
		public static void _UI_PROMPT_FILTER_CLEAR() { Function.Call(0x6A2F820452017EA2); }
		public static void _UI_PROMPT_SET_PROMPT_PRIORITY_PREFERENCE(int ped) { Function.Call(0x530A428705BE5DEF, ped); }
		public static void _UI_PROMPT_CLEAR_PROMPT_PRIORITY_PREFERENCE() { Function.Call(0x51259AE5C72D4A1B); }
		public static BOOL _UI_PROMPT_IS_ENABLED(Prompt prompt) { return Function.Call<BOOL>(0x0D00EDDFB58B7F28, prompt); }
		public static BOOL UI_PROMPT_IS_CONTROL_ACTION_ACTIVE(Hash control) { return Function.Call<BOOL>(0x1BE19185B8AFE299, control); }
		public static Any _0xD6BD313CFA41E57A(Any p0) { return Function.Call<Any>(0xD6BD313CFA41E57A, p0); }
		public static int _UI_PROMPT_SET_REGISTER_HORIZONTAL_ORIENTATION() { return Function.Call<int>(0xD9459157EB22C895); }
		public static void _UI_PROMPT_CLEAR_HORIZONTAL_ORIENTATION(int id) { Function.Call(0x6095358C4142932A, id); }
		public static void _UI_PROMPT_SET_ORDERING_AS_INPUT_TYPE(Prompt prompt, Any p1) { Function.Call(0x2F385ECC5200938D, prompt, p1); }
		public static Any _0x066725A9D52B3641() { return Function.Call<Any>(0x066725A9D52B3641); }
		public static void _0x958278B97C4AFFD8(Any p0, Any p1) { Function.Call(0x958278B97C4AFFD8, p0, p1); }
		public static int _CREATE_MP_GAMER_TAG(int player, string username, BOOL pointedClanTag, BOOL isRockstarClan, string clanTag, int clanFlag) { return Function.Call<int>(0xD877AF112AD2B41B, player, username, pointedClanTag, isRockstarClan, clanTag, clanFlag); }
		public static int CREATE_FAKE_MP_GAMER_TAG(int ped, string username, BOOL pointedClanTag, BOOL isRockstarClan, string clanTag, int clanFlag) { return Function.Call<int>(0x53CB4B502E1C57EA, ped, username, pointedClanTag, isRockstarClan, clanTag, clanFlag); }
		public static int _CREATE_MP_GAMER_TAG_ON_ENTITY(int entity, string text) { return Function.Call<int>(0xE961BF23EAB76B12, entity, text); }
		public static void REMOVE_MP_GAMER_TAG(int gamerTagId) { Function.Call(0x839BFD7D7E49FE09, gamerTagId); }
		public static BOOL IS_MP_GAMER_TAG_ACTIVE(int gamerTagId) { return Function.Call<BOOL>(0x6E1C31E14C7A5F97, gamerTagId); }
		public static BOOL _IS_MP_GAMER_TAG_ACTIVE_ON_ENTITY(int gamerTagId, int entity) { return Function.Call<BOOL>(0x502E1591A504F843, gamerTagId, entity); }
		public static void _SET_MP_GAMER_TAG_VISIBILITY(int gamerTagId, int visibility) { Function.Call(0x93171DDDAB274EB8, gamerTagId, visibility); }
		public static void _SET_MP_GAMER_TAG_TYPE(int gamerTagId, Hash type) { Function.Call(0x25B9C78A25105C35, gamerTagId, type); }
		public static void _SET_MP_GAMER_TAG_COLOUR(int gamerTagId, Hash colour) { Function.Call(0x84BD27DDF9575816, gamerTagId, colour); }
		public static void _0xEF7AB1A0E8C86170(int gamerTagId, BOOL allow) { Function.Call(0xEF7AB1A0E8C86170, gamerTagId, allow); }
		public static void SET_MP_GAMER_TAG_NAME(int gamerTagId, string _string) { Function.Call(0xEA6F4B8D4B4B5B3E, gamerTagId, _string); }
		public static void _SET_MP_GAMER_TAG_NAME_POSSE(int gamerTagId, string text) { Function.Call(0x1EA716E0628A6F44, gamerTagId, text); }
		public static void SET_MP_GAMER_TAG_BIG_TEXT(int gamerTagId, string _string) { Function.Call(0xA0D7CE5F83259663, gamerTagId, _string); }
		public static void _SET_MP_GAMER_TAG_TOP_ICON(int gamerTagId, Hash icon) { Function.Call(0x5F57522BC1EB9D9D, gamerTagId, icon); }
		public static void _SET_MP_GAMER_TAG_SECONDARY_ICON(int gamerTagId, Hash icon) { Function.Call(0x95384C6CE1526EFF, gamerTagId, icon); }
		public static void _MP_GAMER_TAG_ENABLE_REVIVE_TOP_ICON(int gamerTagId) { Function.Call(0xFFF6579CF0139FCE, gamerTagId); }
		public static void _MP_GAMER_TAG_DISABLE_REVIVE_TOP_ICON(int gamerTagId) { Function.Call(0x1F9A64C2804B3471, gamerTagId); }
	}

	public static class IK
	{
		public static unsafe void _INVERSE_KINEMATICS_REQUEST_LOOK_AT(int ped, Any* args) { Function.Call(0x66F9EB44342BB4C5, ped, args); }
		public static unsafe void _0x0B9F7A01EC50448D(int ped, Any* args) { Function.Call(0x0B9F7A01EC50448D, ped, args); }
		public static void _INVERSE_KINEMATICS_SET_DISABLED_FOR_PED(int ped, int p1, BOOL p2) { Function.Call(0x0EABF182FBB63D72, ped, p1, p2); }
		public static BOOL _0x6098139150DCC745(int ped, int p1) { return Function.Call<BOOL>(0x6098139150DCC745, ped, p1); }
		public static void _0x873C792E07A32C8B(int ped1, int ped2) { Function.Call(0x873C792E07A32C8B, ped1, ped2); }
	}

	public static class _NAMESPACE30
	{
		public static void _SET_MOUSE_CURSOR_ACTIVE_THIS_FRAME() { Function.Call(0xF12E4CCAF249DC10); }
		public static void _SET_MOUSE_CURSOR_SPRITE(int spriteId) { Function.Call(0x7F5858AAB5A58CCE, spriteId); }
		public static void _0x0546B117BB17548B() { Function.Call(0x0546B117BB17548B); }
		public static BOOL _0x2B8B605F2A9E64BF() { return Function.Call<BOOL>(0x2B8B605F2A9E64BF); }
		public static BOOL _0x61CAE9D1FD055E44() { return Function.Call<BOOL>(0x61CAE9D1FD055E44); }
		public static BOOL _0xF7F51A57349739F2() { return Function.Call<BOOL>(0xF7F51A57349739F2); }
	}

	public static class INTERIOR
	{
		public static BOOL IS_VALID_INTERIOR(Interior interior) { return Function.Call<BOOL>(0x017C1B3159F79F6C, interior); }
		public static unsafe void GET_INTERIOR_LOCATION_AND_NAMEHASH(Interior interior, Vector3* position, Hash* nameHash) { Function.Call(0x8451E87D3C2B0286, interior, position, nameHash); }
		public static Hash _GET_INTERIOR_MINIMAP_HASH(Interior interior) { return Function.Call<Hash>(0x3039BE60B3749716, interior); }
		public static Vector3 _GET_INTERIOR_POSITION(Interior interior) { return Function.Call<Vector3>(0x2C9746D0CA15BE1C, interior); }
		public static BOOL IS_INTERIOR_SCENE() { return Function.Call<BOOL>(0x4200F14D6F840A9A); }
		public static void CLEAR_ROOM_FOR_ENTITY(int entity) { Function.Call(0xA1762D5BBFCA13A8, entity); }
		public static void FORCE_ROOM_FOR_ENTITY(int entity, Interior interior, Hash roomHashKey) { Function.Call(0xBC29A9894C976945, entity, interior, roomHashKey); }
		public static Hash GET_ROOM_KEY_FROM_ENTITY(int entity) { return Function.Call<Hash>(0x076E46E0EB52AFC6, entity); }
		public static Hash GET_KEY_FOR_ENTITY_IN_ROOM(int entity) { return Function.Call<Hash>(0x27D7B6F79E1F4603, entity); }
		public static Interior GET_INTERIOR_FROM_ENTITY(int entity) { return Function.Call<Interior>(0xB417689857646F61, entity); }
		public static void RETAIN_ENTITY_IN_INTERIOR(int entity, Interior interior) { Function.Call(0x5BD616735F16BF5C, entity, interior); }
		public static void FORCE_ROOM_FOR_GAME_VIEWPORT(int interiorID, Hash roomHashKey) { Function.Call(0x115B4AA8FB28AB43, interiorID, roomHashKey); }
		public static void CLEAR_ROOM_FOR_GAME_VIEWPORT() { Function.Call(0x951A049765E0D450); }
		public static Interior GET_INTERIOR_FROM_PRIMARY_VIEW() { return Function.Call<Interior>(0xBC8A281FF125C655); }
		public static Interior GET_INTERIOR_AT_COORDS(float x, float y, float z) { return Function.Call<Interior>(0xCDD36C9E5C469070, x, y, z); }
		public static void PIN_INTERIOR_IN_MEMORY(Interior interior) { Function.Call(0xBD3D33EABF680168, interior); }
		public static void UNPIN_INTERIOR(Interior interior) { Function.Call(0x07FD1A0B814F6055, interior); }
		public static BOOL IS_INTERIOR_READY(Interior interior) { return Function.Call<BOOL>(0x941560D2D45DBFC8, interior); }
		public static Any _0xB5EF6FEF2DC9EBED(Interior interior) { return Function.Call<Any>(0xB5EF6FEF2DC9EBED, interior); }
		public static Interior GET_INTERIOR_AT_COORDS_WITH_TYPE(float x, float y, float z, string interiorType) { return Function.Call<Interior>(0xAAD6170AA33B13C0, x, y, z, interiorType); }
		public static Interior GET_INTERIOR_AT_COORDS_WITH_TYPEHASH(float x, float y, float z, Hash typeHash) { return Function.Call<Interior>(0x3543AEA1816D1D2B, x, y, z, typeHash); }
		public static BOOL IS_COLLISION_MARKED_OUTSIDE(float x, float y, float z) { return Function.Call<BOOL>(0xF291396B517E25B2, x, y, z); }
		public static int GET_INTERIOR_FROM_COLLISION(float x, float y, float z) { return Function.Call<int>(0x5054D1A5218FA696, x, y, z); }
		public static void ACTIVATE_INTERIOR_ENTITY_SET(Interior interior, string entitySetName, int p2) { Function.Call(0x174D0AAB11CED739, interior, entitySetName, p2); }
		public static void DEACTIVATE_INTERIOR_ENTITY_SET(Interior interior, string entitySetName, BOOL p2) { Function.Call(0x33B81A2C07A51FFF, interior, entitySetName, p2); }
		public static BOOL IS_INTERIOR_ENTITY_SET_ACTIVE(Interior interior, string entitySetName) { return Function.Call<BOOL>(0x32810CA2125F5842, interior, entitySetName); }
		public static BOOL _IS_INTERIOR_ENTITY_SET_VALID(Interior interior, string entitySetName) { return Function.Call<BOOL>(0xD56FF170710FC826, interior, entitySetName); }
		public static void DISABLE_INTERIOR(Interior interior, BOOL toggle) { Function.Call(0x3C2B92A1A07D4FCE, interior, toggle); }
		public static void _0x2533F2AB0EB9C6F9(Any p0, Any p1) { Function.Call(0x2533F2AB0EB9C6F9, p0, p1); }
		public static void _0xFE2B3D5500B1B2E4(Any p0, Any p1) { Function.Call(0xFE2B3D5500B1B2E4, p0, p1); }
	}

	public static class INVENTORY
	{
		public static int _INVENTORY_GET_INVENTORY_ID_FROM_PED(int ped) { return Function.Call<int>(0x13D234A2A3F66E63, ped); }
		public static int _GET_ITEM_ROLE_MAX_LEVEL_COUNT(int inventoryId, Hash eRoleMaxLevel) { return Function.Call<int>(0xADDD1E7C0ECF7D95, inventoryId, eRoleMaxLevel); }
		public static int _GET_ITEM_SLOT_MAX_COUNT(Hash provision, Hash slotId) { return Function.Call<int>(0xE80E50BEE276A54A, provision, slotId); }
		public static unsafe BOOL _0x112BCA290D2EB53C(int inventoryId, Hash p1, int* year, int* month, int* day, int* hour, int* minute, int* second) { return Function.Call<BOOL>(0x112BCA290D2EB53C, inventoryId, p1, year, month, day, hour, minute, second); }
		public static void _0x46743BBFEDBC859E(int inventoryId, Hash eInventoryItem, BOOL p2) { Function.Call(0x46743BBFEDBC859E, inventoryId, eInventoryItem, p2); }
		public static unsafe void _INVENTORY_SET_INVENTORY_ITEM_IN_USE(int inventoryId, Any* guid, BOOL inUse) { Function.Call(0x65A5F70F4A292EBE, inventoryId, guid, inUse); }
		public static unsafe BOOL _INVENTORY_GET_INVENTORY_ITEM_IN_USE(int inventoryId, Any* guid) { return Function.Call<BOOL>(0x70E3A884ED000A01, inventoryId, guid); }
		public static unsafe void _INVENTORY_SET_INVENTORY_ITEM_HIDDEN(int inventoryId, Any* guid, BOOL hidden) { Function.Call(0x9A113C660AEA3832, inventoryId, guid, hidden); }
		public static unsafe void _INVENTORY_SET_INVENTORY_ITEM_HIDDEN_2(int inventoryId, Any* guid, BOOL hidden) { Function.Call(0xD740F11FBC8AEF43, inventoryId, guid, hidden); }
		public static unsafe BOOL _INVENTORY_GET_INVENTORY_ITEM_HIDDEN(int inventoryId, Any* guid) { return Function.Call<BOOL>(0xF9933164965533B7, inventoryId, guid); }
		public static BOOL _INVENTORY_GET_INVENTORY_ITEM_IS_ANIMAL_PELT(Hash item) { return Function.Call<BOOL>(0x4AEF1FB5B9011D75, item); }
		public static Hash _INVENTORY_GET_INVENTORY_ITEM_DESCRIPTION_HASH(Hash item) { return Function.Call<Hash>(0xA4550FE9C512E3DD, item); }
		public static BOOL _INVENTORY_IS_INVENTORY_ITEM_FLAG_ENABLED(Hash item, int flag) { return Function.Call<BOOL>(0x245D07651B1D183B, item, flag); }
		public static BOOL _INVENTORY_GET_IS_INVENTORY_ITEM_SOUND_VALID(Hash item, int soundType) { return Function.Call<BOOL>(0x2BAE4880DCDD560B, item, soundType); }
		public static Hash _INVENTORY_GET_INVENTORY_ITEM_SOUND(Hash item, int soundType) { return Function.Call<Hash>(0x2E1CDC1FF3B8473E, item, soundType); }
		public static unsafe BOOL _INVENTORY_GET_INVENTORY_ITEM_INSPECTION_INFO(Hash item, Any* info) { return Function.Call<BOOL>(0x0C093C1787F18519, item, info); }
		public static unsafe int _INVENTORY_GET_INVENTORY_ITEM_WEAPON_COPY_ID(int inventoryId, Any* guid) { return Function.Call<int>(0xAB5F12746A099A0E, inventoryId, guid); }
		public static BOOL _INVENTORY_ARE_LOCAL_CHANGES_ALLOWED(int inventoryId) { return Function.Call<BOOL>(0x0FBBFFC891A97C81, inventoryId); }
		public static unsafe BOOL _INVENTORY_IS_GUID_VALID(Any* guid) { return Function.Call<BOOL>(0xB881CA836CC4B6D4, guid); }
		public static unsafe BOOL _INVENTORY_COMPARE_GUIDS(Any* guid1, Any* guid2) { return Function.Call<BOOL>(0x4C543D5DFCD2DAFD, guid1, guid2); }
		public static unsafe BOOL INVENTORY_GET_GUID_FROM_ITEMID(int inventoryId, Any* guid, Hash p2, Hash slotId, Any* _outGuid) { return Function.Call<BOOL>(0x886DFD3E185C8A89, inventoryId, guid, p2, slotId, _outGuid); }
		public static BOOL _0x5D6182F3BCE1333B(int inventoryId, Hash removeReason) { return Function.Call<BOOL>(0x5D6182F3BCE1333B, inventoryId, removeReason); }
		public static unsafe BOOL INVENTORY_GET_INVENTORY_ITEM(int inventoryId, Any* inData, Any* _outData, BOOL p3) { return Function.Call<BOOL>(0x9700E8EFC4AB9089, inventoryId, inData, _outData, p3); }
		public static unsafe BOOL _INVENTORY_GET_FULL_INVENTORY_ITEM_DATA(int inventoryId, Any* guid, Any* p2, int p3, int p4) { return Function.Call<BOOL>(0x025A1B1FB03FBF61, inventoryId, guid, p2, p3, p4); }
		public static unsafe BOOL _INVENTORY_GET_INVENTORY_ITEM_CHILD(int inventoryId, Any* parentGuid, Any childIndex, Any* _outInventoryItem) { return Function.Call<BOOL>(0xCD9A485F2B383B44, inventoryId, parentGuid, childIndex, _outInventoryItem); }
		public static unsafe BOOL _INVENTORY_ADD_ITEM_WITH_GUID(int inventoryId, Any* guid1, Any* guid2, Hash item, Hash inventoryItemSlot, int p5, Hash addReason) { return Function.Call<BOOL>(0xCB5D11F9508A928D, inventoryId, guid1, guid2, item, inventoryItemSlot, p5, addReason); }
		public static unsafe BOOL _INVENTORY_UPDATE_INVENTORY_ITEM(int inventoryId, Any* guid1, Any* guid2, int p3) { return Function.Call<BOOL>(0xD80A8854DB5CFBA5, inventoryId, guid1, guid2, p3); }
		public static unsafe BOOL _INVENTORY_REMOVE_INVENTORY_ITEM_WITH_GUID(int inventoryId, Any* guid, int quantity, Hash removeReason) { return Function.Call<BOOL>(0x3E4E811480B3AE79, inventoryId, guid, quantity, removeReason); }
		public static BOOL _INVENTORY_REMOVE_INVENTORY_ITEM_WITH_ITEMID(int inventoryId, Hash item, int quantity, Hash removeReason) { return Function.Call<BOOL>(0xB4158C8C9A3B5DCE, inventoryId, item, quantity, removeReason); }
		public static unsafe BOOL _INVENTORY_MOVE_INVENTORY_ITEM(int inventoryId, Any* guid1, Any* guid2, Hash slotId, int quantity, Any* _outGuid) { return Function.Call<BOOL>(0xDCCAA7C3BFD88862, inventoryId, guid1, guid2, slotId, quantity, _outGuid); }
		public static unsafe BOOL _INVENTORY_SWAP_INVENTORY_ITEM(int inventoryId, Any* guid1, Any* guid2) { return Function.Call<BOOL>(0xF2753D691BCDA314, inventoryId, guid1, guid2); }
		public static unsafe int _INVENTORY_CREATE_ITEM_COLLECTION(int inventoryId, string filterName, Hash slotId, int* size) { return Function.Call<int>(0x80D78BDC9D88EF07, inventoryId, filterName, slotId, size); }
		public static unsafe int _INVENTORY_CREATE_ITEM_COLLECTION_WITH_FILTER(int inventoryId, Any* filter, int* numInCollection) { return Function.Call<int>(0x640F890C3E5A3FFD, inventoryId, filter, numInCollection); }
		public static unsafe BOOL _INVENTORY_GET_ITEM_FROM_COLLECTION_INDEX(int collectionId, int itemIndex, Any* itemData) { return Function.Call<BOOL>(0x82FA24C3D3FCD9B7, collectionId, itemIndex, itemData); }
		public static BOOL _INVENTORY_RELEASE_ITEM_COLLECTION(int collectionId) { return Function.Call<BOOL>(0x42A2F33A1942E865, collectionId); }
		public static unsafe BOOL _INVENTORY_EQUIP_ITEM_WITH_GUID(int inventoryId, Any* guid, BOOL bEquipped) { return Function.Call<BOOL>(0x734311E2852760D0, inventoryId, guid, bEquipped); }
		public static unsafe BOOL _INVENTORY_GET_INVENTORY_ITEM_EQUIPPED_IN_SLOT_BY_REF(int inventoryId, Any* guid, Hash slotId, Any* _outGuid) { return Function.Call<BOOL>(0x22E590F108289A9D, inventoryId, guid, slotId, _outGuid); }
		public static unsafe BOOL _INVENTORY_DOES_ITEM_OWN_EQUIPMENT(int inventoryId, Any* guid, Hash item) { return Function.Call<BOOL>(0x88B58B83A43A8CAB, inventoryId, guid, item); }
		public static unsafe BOOL _0xD08685BA892DBFAB(int inventoryId, Any* guid, int* p2, int* p3) { return Function.Call<BOOL>(0xD08685BA892DBFAB, inventoryId, guid, p2, p3); }
		public static unsafe void _0x0349404A22736740(BOOL p0, int inventoryId, Any* guid) { Function.Call(0x0349404A22736740, p0, inventoryId, guid); }
		public static unsafe void _INVENTORY_SET_INVENTORY_ITEM_WEATHER_EFFECTIVENESS(int inventoryId, Any* guid, int weatherEffectiveness) { Function.Call(0x6D2F987736A42D4C, inventoryId, guid, weatherEffectiveness); }
		public static void _INVENTORY_DISABLE_ITEM(int inventoryId, Hash item, Hash gtxReason) { Function.Call(0x766315A564594401, inventoryId, item, gtxReason); }
		public static void _INVENTORY_ENABLE_ITEM(int inventoryId, Hash item) { Function.Call(0x6A564540FAC12211, inventoryId, item); }
		public static BOOL _INVENTORY_IS_INVENTORY_ITEM_EQUIPPED(int inventoryId, Hash item, BOOL p2) { return Function.Call<BOOL>(0x3D10D7179D7034AF, inventoryId, item, p2); }
		public static unsafe BOOL _INVENTORY_SET_INVENTORY_ITEM_INSPECTION_ENABLED(int inventoryId, Any* p1, BOOL enabled) { return Function.Call<BOOL>(0x227522FD59DDB7E8, inventoryId, p1, enabled); }
		public static unsafe BOOL _INVENTORY_IS_ITEM_EXPIRED(Any* itemGUID) { return Function.Call<BOOL>(0x0137C77A2EC64536, itemGUID); }
		public static unsafe int _INVENTORY_GET_ITEM_EXPIRY_TIME(Any* itemGUID) { return Function.Call<int>(0x4A606C17276E1BCC, itemGUID); }
		public static unsafe int _INVENTORY_GET_INVENTORY_ITEM_COUNT_WITH_GUID(int inventoryId, Any* guid, BOOL p2) { return Function.Call<int>(0xC97E0D2302382211, inventoryId, guid, p2); }
		public static int _INVENTORY_GET_INVENTORY_ITEM_COUNT_WITH_ITEMID(int inventoryId, Hash eInventoryItem, BOOL p2) { return Function.Call<int>(0xE787F05DFC977BDE, inventoryId, eInventoryItem, p2); }
		public static unsafe BOOL _0xB1DD74A1F5536622(int inventoryId, Any* itemGUID) { return Function.Call<BOOL>(0xB1DD74A1F5536622, inventoryId, itemGUID); }
		public static unsafe int _INVENTORY_GET_CHILDREN_COUNT(int inventoryId, Any* parentGuid) { return Function.Call<int>(0xE843D21A8E2498AA, inventoryId, parentGuid); }
		public static unsafe int INVENTORY_GET_CHILDREN_IN_SLOT_COUNT(int inventoryId, Any* guid, Hash slotId) { return Function.Call<int>(0x033EE4B89F3AC545, inventoryId, guid, slotId); }
		public static unsafe int _INVENTORY_GET_INVENTORY_ITEM_EQUIPPED_IN_SLOT(int inventoryId, Any* guid, Hash slotId, int p3, Any* p4) { return Function.Call<int>(0xBE012571B25F5ACA, inventoryId, guid, slotId, p3, p4); }
		public static BOOL _INVENTORY_FITS_SLOT_ID(Hash item, Hash slotId) { return Function.Call<BOOL>(0x780C5B9AE2819807, item, slotId); }
		public static Hash _GET_DEFAULT_ITEM_SLOT_INFO(Hash item, Hash p1) { return Function.Call<Hash>(0x6452B1D357D81742, item, p1); }
		public static unsafe BOOL _INVENTORY_GET_INVENTORY_ITEM_FIT_SLOT(Hash p0, Any* p1, int p2) { return Function.Call<BOOL>(0xB991FE166FAF84FD, p0, p1, p2); }
		public static unsafe BOOL _0x9AC53CB6907B4428(Hash item, Any* p1, Any* p2) { return Function.Call<BOOL>(0x9AC53CB6907B4428, item, p1, p2); }
		public static Hash _0x9D21B185ABC2DBC4(Any data, string effects, BOOL p2, BOOL p3) { return Function.Call<Hash>(0x9D21B185ABC2DBC4, data, effects, p2, p3); }
		public static void _0x75CFAC49301E134F(Hash databindingEntryId, BOOL p1, BOOL p2) { Function.Call(0x75CFAC49301E134F, databindingEntryId, p1, p2); }
		public static Hash _0x9D21B185ABC2DBC5(Any data, string stats, int p2, int p3) { return Function.Call<Hash>(0x9D21B185ABC2DBC5, data, stats, p2, p3); }
		public static void _0x75CFAC49301E134E(Any data, BOOL p1, int ped) { Function.Call(0x75CFAC49301E134E, data, p1, ped); }
		public static unsafe Hash _0x46DB71883EE9D5AF(Any data, string stats, Any* guid, int ped) { return Function.Call<Hash>(0x46DB71883EE9D5AF, data, stats, guid, ped); }
		public static unsafe void _0x951847CEF3D829FF(Any p0, Any* _outGuid, int ped) { Function.Call(0x951847CEF3D829FF, p0, _outGuid, ped); }
		public static unsafe BOOL _0x6862E4D93F64CF01(int inventoryId, Any* guid, Hash p2, Any* p3) { return Function.Call<BOOL>(0x6862E4D93F64CF01, inventoryId, guid, p2, p3); }
		public static void _INVENTORY_ENABLE_MISSION_INVENTORY(BOOL toggle) { Function.Call(0x597F571DDEE3FFAC, toggle); }
		public static void INVENTORY_DISABLE_MISSION_INVENTORY_PICKUPS() { Function.Call(0xE1F389F03DC83673); }
		public static void _INVENTORY_USE_MISSION_INVENTORY(BOOL enable, BOOL mirrorTransactions) { Function.Call(0xA6AA9F56BC6CFF58, enable, mirrorTransactions); }
		public static void INVENTORY_COPY_MP_INVENTORY_TO_MISSION_INVENTORY(BOOL p0, BOOL p1, BOOL bCopySatchelItems, BOOL bCopyEmotes, BOOL bCopyHorse, BOOL p5) { Function.Call(0x644CCB76A76CFBD6, p0, p1, bCopySatchelItems, bCopyEmotes, bCopyHorse, p5); }
		public static unsafe void _INVENTORY_COPY_ITEM_TO_MISSION_INVENTORY(Any* guid, BOOL p1) { Function.Call(0x3112ADB9D5F3426B, guid, p1); }
		public static void _0xE36D4A38D28D9CFB(BOOL p0) { Function.Call(0xE36D4A38D28D9CFB, p0); }
		public static BOOL _INVENTORY_USE_SP_BACKUP() { return Function.Call<BOOL>(0x7C7E4AB748EA3B07); }
		public static BOOL _INVENTORY_IS_PLAYER_INVENTORY_MIRRORING_TRANSACTIONS() { return Function.Call<BOOL>(0xFC7563F482781A3D); }
		public static unsafe void _INVENTORY_COPY_ITEM_TO_INVENTORY(int inventoryId, int inventoryIdCloned, Any* p2, Any p3) { Function.Call(0xC04F47D488EF9EBA, inventoryId, inventoryIdCloned, p2, p3); }
		public static void _0x9E58207B194488AC(int ped, int p1) { Function.Call(0x9E58207B194488AC, ped, p1); }
		public static unsafe void _INVENTORY_HANDLE_ITEM_PROMPT_INFO_REQUEST(Any* p0) { Function.Call(0xFD41D1D4350F6413, p0); }
		public static void _0x9B4E793B1CB6550A() { Function.Call(0x9B4E793B1CB6550A); }
		public static unsafe void _INVENTORY_SET_CARRIABLE_CARRY_ACTION_PROMPT_OVERRIDE(Any* data) { Function.Call(0xF666EF30F4F0AC4E, data); }
		public static void _INVENTORY_ENABLE_WEAPONS(int inventoryId) { Function.Call(0xD5D72F1624F3BA7C, inventoryId); }
		public static void _INVENTORY_DISABLE_WEAPONS(int inventoryId, Any p1) { Function.Call(0xE3A46370F70F3607, inventoryId, p1); }
		public static void _0xE1F45A67A9F0DCBC(int inventoryId) { Function.Call(0xE1F45A67A9F0DCBC, inventoryId); }
		public static void _0x6968CE7AC32F6788(int inventoryId) { Function.Call(0x6968CE7AC32F6788, inventoryId); }
		public static unsafe int _INVENTORY_CREATE_ITEM_COLLECTION(Any* p0) { return Function.Call<int>(0x97A3646645727F42, p0); }
		public static unsafe int _INVENTORY_CREATE_SORTED_COLLECTION(int inventoryId, int p1, int* size) { return Function.Call<int>(0xBB7F968675B34B0C, inventoryId, p1, size); }
	}

	public static class ITEMDATABASE
	{
		public static Any _ITEMDATABASE_CAN_EQUIP_ITEM_ON_CATEGORY(Any p0, Any p1, Any p2) { return Function.Call<Any>(0x856FF92C57742AE5, p0, p1, p2); }
		public static Any _ITEMDATABASE_GET_FITS_SLOT_COUNT(Any p0) { return Function.Call<Any>(0x2970D1D6BFCF9B46, p0); }
		public static Any _ITEMDATABASE_GET_FITS_SLOT_INFO(Any p0, Any p1, Any p2) { return Function.Call<Any>(0x77210C146CED5261, p0, p1, p2); }
		public static Any _ITEMDATABASE_GET_HAS_SLOT_COUNT(Any p0) { return Function.Call<Any>(0x44915068579D7710, p0); }
		public static Any _ITEMDATABASE_GET_HAS_SLOT_INFO(Any p0, Any p1, Any p2) { return Function.Call<Any>(0x8A9BD0DB7E8376CF, p0, p1, p2); }
		public static Any ITEMDATABASE_FILLOUT_ITEM_BY_NAME(Any p0, Any p1) { return Function.Call<Any>(0x2A610BEE7D341CC4, p0, p1); }
		public static unsafe BOOL ITEMDATABASE_FILLOUT_ITEM_INFO(Hash p0, Any* p1) { return Function.Call<BOOL>(0xFE90ABBCBFDC13B2, p0, p1); }
		public static Any _ITEMDATABASE_FILLOUT_ACQUIRE_COST(Any p0, Any p1, Any p2) { return Function.Call<Any>(0x74F7928816E4E181, p0, p1, p2); }
		public static Any _ITEMDATABASE_FILLOUT_SELL_PRICE(Any p0, Any p1, Any p2) { return Function.Call<Any>(0x7A62A2EEDE1C3766, p0, p1, p2); }
		public static Any _ITEMDATABASE_FILLOUT_SATCHEL_DATA(Any p0, Any p1) { return Function.Call<Any>(0x4776EFD78F75C23F, p0, p1); }
		public static Any _ITEMDATABASE_FILLOUT_UI_DATA(Any p0, Any p1) { return Function.Call<Any>(0xB86F7CC2DC67AC60, p0, p1); }
		public static Any _0x74C3B1093728D263(Any p0, Any p1) { return Function.Call<Any>(0x74C3B1093728D263, p0, p1); }
		public static Any _ITEMDATABASE_FILLOUT_ITEM_EFFECT_IDS(Any p0, Any p1) { return Function.Call<Any>(0x9379BE60DC55BBE6, p0, p1); }
		public static Any ITEMDATABASE_FILLOUT_ITEM_EFFECT_ID_INFO(Any p0, Any p1) { return Function.Call<Any>(0xCF2D360D27FD1ABF, p0, p1); }
		public static Any _ITEMDATABASE_FILLOUT_TAG_DATA(Any p0, Any p1, Any p2, Any p3) { return Function.Call<Any>(0x5A11D6EEA17165B0, p0, p1, p2, p3); }
		public static Any _ITEMDATABASE_GET_ACQUIRE_COSTS_COUNT(Any p0) { return Function.Call<Any>(0x01FDDAD392D04144, p0); }
		public static Any _ITEMDATABASE_GET_ACQUIRE_COST(Any p0, Any p1, Any p2) { return Function.Call<Any>(0x6772A83C67A25775, p0, p1, p2); }
		public static Any _0xDEE7B3C76ED664BE(Any p0, Any p1) { return Function.Call<Any>(0xDEE7B3C76ED664BE, p0, p1); }
		public static Any _ITEMDATABASE_FILLOUT_ITEM(Any p0, Any p1, Any p2, Any p3) { return Function.Call<Any>(0xAD73B614DF26CF8A, p0, p1, p2, p3); }
		public static Any _0x12DF9C58201DD19A(Any p0) { return Function.Call<Any>(0x12DF9C58201DD19A, p0); }
		public static Any _0x1FC25AEB5F76B38D(Any p0, Any p1, Any p2) { return Function.Call<Any>(0x1FC25AEB5F76B38D, p0, p1, p2); }
		public static Any _0xF540239F9937033B(Any p0, Any p1) { return Function.Call<Any>(0xF540239F9937033B, p0, p1); }
		public static Any _0xF27F01BBF5ACD3F3(Any p0, Any p1, Any p2, Any p3) { return Function.Call<Any>(0xF27F01BBF5ACD3F3, p0, p1, p2, p3); }
		public static unsafe int _ITEMDATABASE_CREATE_ITEM_COLLECTION(Any* p0, int* size, int comparisonType) { return Function.Call<int>(0x71EFA7999AE79408, p0, size, comparisonType); }
		public static Any _0xD389A2549C4EFB30(Any p0) { return Function.Call<Any>(0xD389A2549C4EFB30, p0); }
		public static unsafe BOOL _ITEMDATABASE_GET_COMPONENT_ITEM(int collectionId, int index, Hash* p2) { return Function.Call<BOOL>(0x8750F69A720C2E41, collectionId, index, p2); }
		public static BOOL _ITEMDATABASE_RELEASE_ITEM_COLLECTION(int collectionId) { return Function.Call<BOOL>(0xCBB7B6EDFA933ADE, collectionId); }
		public static Any _ITEMDATABASE_IS_INTRINSIC_ITEM(Any p0) { return Function.Call<Any>(0x337F88E3A063995E, p0); }
		public static Any _ITEMDATABASE_IS_OVERPOWERED_ITEM(Any p0) { return Function.Call<Any>(0x337F88E3A063995F, p0); }
		public static Any _ITEMDATABASE_IS_KEY_VALID(Any p0, Any p1) { return Function.Call<Any>(0x6D5D51B188333FD1, p0, p1); }
		public static BOOL _0x537A0555F62CA01A(Hash p0, Any p1) { return Function.Call<BOOL>(0x537A0555F62CA01A, p0, p1); }
		public static Any _ITEMDATABASE_GET_BUNDLE_ID(Any p0) { return Function.Call<Any>(0x891A45960B6B768A, p0); }
		public static Any _ITEMDATABASE_GET_BUNDLE_ITEM_COUNT(Any p0, Any p1) { return Function.Call<Any>(0x3332695B01015DF9, p0, p1); }
		public static Any _ITEMDATABASE_GET_BUNDLE_ITEM_INFO(Any p0, Any p1, Any p2, Any p3) { return Function.Call<Any>(0x5D48A77E4B668B57, p0, p1, p2, p3); }
		public static BOOL _ITEMDATABASE_IS_BUNDLE_VALID(Any p0, Any p1) { return Function.Call<BOOL>(0x4308812A6E9CA62E, p0, p1); }
		public static Any _0x799FCD53358ED5FA(Any p0, Any p1) { return Function.Call<Any>(0x799FCD53358ED5FA, p0, p1); }
		public static Any _0xC4146375D8A0B374(Any p0, Any p1, Any p2, Any p3) { return Function.Call<Any>(0xC4146375D8A0B374, p0, p1, p2, p3); }
		public static Any _0xA97EE5E4589FCF5A(Any p0, Any p1) { return Function.Call<Any>(0xA97EE5E4589FCF5A, p0, p1); }
		public static Any _0x7A35A72A692BE9DB(Any p0) { return Function.Call<Any>(0x7A35A72A692BE9DB, p0); }
		public static Any _0x3A0B667ABFF87F6E(Any p0, Any p1, Any p2) { return Function.Call<Any>(0x3A0B667ABFF87F6E, p0, p1, p2); }
		public static Any _0x388088BFF3681189(Any p0, Any p1) { return Function.Call<Any>(0x388088BFF3681189, p0, p1); }
		public static Any _ITEMDATABASE_FILLOUT_BUNDLE(Any p0, Any p1, Any p2, Any p3) { return Function.Call<Any>(0xB542632693D53408, p0, p1, p2, p3); }
		public static Any _ITEMDATABASE_IS_SHOP_KEY_VALID(Any p0) { return Function.Call<Any>(0x00B9507D8E1D8716, p0); }
		public static Any _ITEMDATABASE_GET_SHOP_INVENTORIES_ITEMS_COUNT(Any p0) { return Function.Call<Any>(0xC568B1A0F17C7025, p0); }
		public static Any _ITEMDATABASE_GET_SHOP_INVENTORIES_ITEM_INFO(Any p0, Any p1, Any p2) { return Function.Call<Any>(0x4A79B41B4EB91F4E, p0, p1, p2); }
		public static Any _ITEMDATABASE_GET_SHOP_INVENTORIES_ITEM_INFO_BY_KEY(Any p0, Any p1, Any p2) { return Function.Call<Any>(0xCFB06801F5099B25, p0, p1, p2); }
		public static Any _ITEMDATABASE_GET_SHOP_INVENTORIES_REQUIREMENT_GROUP_INFO(Any p0, Any p1, Any p2, Any p3) { return Function.Call<Any>(0x76C752D788A76813, p0, p1, p2, p3); }
		public static Any _ITEMDATABASE_GET_SHOP_INVENTORIES_REQUIREMENT_INFO(Any p0, Any p1, Any p2, Any p3, Any p4) { return Function.Call<Any>(0xE0EA5C031AE5539F, p0, p1, p2, p3, p4); }
		public static Any _0x17721003A66C72BF(Any p0, Any p1, Any p2) { return Function.Call<Any>(0x17721003A66C72BF, p0, p1, p2); }
		public static Any _ITEMDATABASE_IS_SHOP_LAYOUT_KEY_VALID(Any p0) { return Function.Call<Any>(0x3AFE5182C45A84F6, p0); }
		public static Any _ITEMDATABASE_GET_SHOP_LAYOUT_INFO(Any p0, Any p1) { return Function.Call<Any>(0x66A6D76B6BB999B4, p0, p1); }
		public static Any _ITEMDATABASE_GET_SHOP_LAYOUT_ROOT_MENU_INFO(Any p0, Any p1, Any p2) { return Function.Call<Any>(0x86FCB565CCA0CFA7, p0, p1, p2); }
		public static Any _ITEMDATABASE_GET_SHOP_LAYOUT_MENU_INFO_BY_ID(Any p0, Any p1, Any p2) { return Function.Call<Any>(0xD66114469978B55B, p0, p1, p2); }
		public static Any _ITEMDATABASE_GET_SHOP_LAYOUT_MENU_INFO_BY_INDEX(Any p0, Any p1, Any p2, Any p3) { return Function.Call<Any>(0xF04247092F193B75, p0, p1, p2, p3); }
		public static Any _ITEMDATABASE_GET_SHOP_LAYOUT_MENU_PAGE_KEY(Any p0, Any p1, Any p2, Any p3) { return Function.Call<Any>(0x9A60570657A7B635, p0, p1, p2, p3); }
		public static Any _0xDBEADA0DF5F9AB9F(Any p0, Any p1, Any p2) { return Function.Call<Any>(0xDBEADA0DF5F9AB9F, p0, p1, p2); }
		public static Any _ITEMDATABASE_GET_SHOP_LAYOUT_PAGE_INFO_BY_KEY(Any p0, Any p1, Any p2) { return Function.Call<Any>(0xB347C100DF0C9B7F, p0, p1, p2); }
		public static Any _ITEMDATABASE_GET_SHOP_LAYOUT_PAGE_ITEM_KEY(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5) { return Function.Call<Any>(0xF32BEF578B3DBAE8, p0, p1, p2, p3, p4, p5); }
		public static Any ITEMDATABASE_IS_BUYABLE_AWARD_VALID(Any p0) { return Function.Call<Any>(0x4CE753203FA42214, p0); }
		public static Any _ITEMDATABASE_FILLOUT_BUY_AWARD_ACQUIRE_COSTS(Any p0, Any p1, Any p2, Any p3) { return Function.Call<Any>(0xB52E20F6767A09A2, p0, p1, p2, p3); }
		public static Any _0xF8D09EF8CE61D7BF(Any p0, Any p1) { return Function.Call<Any>(0xF8D09EF8CE61D7BF, p0, p1); }
		public static Any _ITEMDATABASE_GET_ITEM_PRICE_MODIFIERS(Any p0, Any p1) { return Function.Call<Any>(0x4EB37AAB79AB0C48, p0, p1); }
		public static Any _ITEMDATABASE_FILLOUT_PRICE_MODIFIER_BY_KEY(Any p0, Any p1) { return Function.Call<Any>(0x40C5D95818823C94, p0, p1); }
		public static Any _ITEMDATABASE_GET_NUMBER_OF_MODIFIED_PRICES(Any p0) { return Function.Call<Any>(0x5AAAF40E9B224F5E, p0); }
		public static Any _ITEMDATABASE_GET_MODIFIED_PRICE(Any p0, Any p1) { return Function.Call<Any>(0xCB92EC9C004732B4, p0, p1); }
		public static Any _ITEMDATABASE_GET_NUMBER_OF_MODIFIERS(Any p0) { return Function.Call<Any>(0x1289D8315235856D, p0); }
		public static Any _ITEMDATABASE_FILLOUT_MODIFIER(Any p0, Any p1, Any p2) { return Function.Call<Any>(0x60614A0AB580A2B5, p0, p1, p2); }
		public static BOOL _0xEF254F1A4C08B7E6(Hash p0) { return Function.Call<BOOL>(0xEF254F1A4C08B7E6, p0); }
		public static int _0x3FAA928A79591761(Hash p0) { return Function.Call<int>(0x3FAA928A79591761, p0); }
		public static int _0x48229CE0C7938237(Hash p0) { return Function.Call<int>(0x48229CE0C7938237, p0); }
		public static BOOL _0x121D2005DD64496B(Hash p0, int index, Any p2) { return Function.Call<BOOL>(0x121D2005DD64496B, p0, index, p2); }
		public static Any _0x8D029948CA29409B(Hash p0, Any p1, Any p2) { return Function.Call<Any>(0x8D029948CA29409B, p0, p1, p2); }
		public static Any _0xE81D0378A384E755(Any p0, Any p1) { return Function.Call<Any>(0xE81D0378A384E755, p0, p1); }
		public static Any _0xD076DB9B96FAADF1(Any p0, Any p1) { return Function.Call<Any>(0xD076DB9B96FAADF1, p0, p1); }
		public static BOOL _ITEMDATABASE_DOES_ITEM_HAVE_TAG(Hash item, Hash tag, Hash tagType) { return Function.Call<BOOL>(0xFF5FB5605AD56856, item, tag, tagType); }
		public static BOOL _ITEMDATABASE_DOES_BUNDLE_HAVE_TAG(Hash bundle, Hash tag, Hash tagType) { return Function.Call<BOOL>(0x99C6EA66DFE73757, bundle, tag, tagType); }
		public static Hash _ITEMDATABASE_GET_ITEM_TAG_TYPE(Hash item, Hash tag) { return Function.Call<Hash>(0x6111B8F9413F413A, item, tag); }
		public static Any _0x8870895BA5ED9385(Any p0, Hash tagType, Any p2) { return Function.Call<Any>(0x8870895BA5ED9385, p0, tagType, p2); }
		public static Any _ITEMDATABASE_LOCALIZATION_GET_NUM_LABEL_TYPES(Any p0) { return Function.Call<Any>(0xCEC6A41E8910486A, p0); }
		public static Any _ITEMDATABASE_LOCALIZATION_GET_NUM_VALUES(Any p0, Any p1) { return Function.Call<Any>(0x49885D82A13EEAEA, p0, p1); }
		public static Any _ITEMDATABASE_LOCALIZATION_GET_TYPE(Any p0, Any p1) { return Function.Call<Any>(0xCABF5D41D0073D4A, p0, p1); }
		public static Any _ITEMDATABASE_LOCALIZATION_GET_VALUE(Any p0, Any p1, Any p2) { return Function.Call<Any>(0x9AE5610FDCED6EA7, p0, p1, p2); }
		public static int _ITEMDATABASE_GET_ITEM_PATHSET(int item, int p1) { return Function.Call<int>(0xF4452CE83118C738, item, p1); }
		public static Hash _0xAA29A5F13B2C20B2(Any p0, Hash p1) { return Function.Call<Hash>(0xAA29A5F13B2C20B2, p0, p1); }
	}

	public static class ITEMSET
	{
		public static ItemSet CREATE_ITEMSET(BOOL p0) { return Function.Call<ItemSet>(0xA1AF16083320065A, p0); }
		public static void DESTROY_ITEMSET(ItemSet itemset) { Function.Call(0x712BC69F10549B92, itemset); }
		public static BOOL IS_ITEMSET_VALID(ItemSet itemset) { return Function.Call<BOOL>(0xD30765D153EF5C76, itemset); }
		public static BOOL ADD_TO_ITEMSET(int entity, ItemSet itemset) { return Function.Call<BOOL>(0xABE74510883C7950, entity, itemset); }
		public static void REMOVE_FROM_ITEMSET(int entity, ItemSet itemset) { Function.Call(0xC5BAA432B429DC24, entity, itemset); }
		public static int GET_ITEMSET_SIZE(ItemSet itemset) { return Function.Call<int>(0x55F2E375AC6018A9, itemset); }
		public static ScrHandle GET_INDEXED_ITEM_IN_ITEMSET(int index, ItemSet itemset) { return Function.Call<ScrHandle>(0x275A2E2C0FAB7612, index, itemset); }
		public static Any GET_INDEXED_SCENARIO_POINT_INDEX_IN_ITEMSET(int index, ItemSet itemset) { return Function.Call<Any>(0x9FC3CDB5CE815901, index, itemset); }
		public static BOOL IS_IN_ITEMSET(int entity, ItemSet itemset) { return Function.Call<BOOL>(0xD1503C2EE2FE688C, entity, itemset); }
		public static void CLEAN_ITEMSET(ItemSet itemset) { Function.Call(0x85F3A86CA9021FB0, itemset); }
		public static void _CLEAR_ITEMSET(ItemSet itemset) { Function.Call(0x20A4BF0E09BEE146, itemset); }
	}

	public static class LAW
	{
		public static void _REPORT_CRIME(int player, Hash crimeType, int bounty, int entity, BOOL isKnownSuspect) { Function.Call(0xF60386770878A98F, player, crimeType, bounty, entity, isKnownSuspect); }
		public static void SUPPRESS_CRIME_THIS_FRAME(int player, Hash crimeType, int p2, int p3, int p4) { Function.Call(0x785177E4D57D7389, player, crimeType, p2, p3, p4); }
		public static int NUM_CRIMES_SUPPRESSED(int player, Hash crimeType) { return Function.Call<int>(0xC08E804C91F47C80, player, crimeType); }
		public static Any _0xFFEBE5AA96BC2E4E(int ped, Hash crimeType, BOOL p2) { return Function.Call<Any>(0xFFEBE5AA96BC2E4E, ped, crimeType, p2); }
		public static void _0x15ABD5004CAD2D99(int p0) { Function.Call(0x15ABD5004CAD2D99, p0); }
		public static void _0xF611DE44AEB36A1D(Hash crimeType, BOOL p1) { Function.Call(0xF611DE44AEB36A1D, crimeType, p1); }
		public static BOOL _0x3D2674828A4E6B3C() { return Function.Call<BOOL>(0x3D2674828A4E6B3C); }
		public static void _0xC5EB2755FA25F1E9(BOOL p0) { Function.Call(0xC5EB2755FA25F1E9, p0); }
		public static int GET_BOUNTY(int player) { return Function.Call<int>(0x54310AAB97B92816, player); }
		public static void ADD_BOUNTY(int player, int itemValueAmount) { Function.Call(0x0E3BDEED21BEB945, player, itemValueAmount); }
		public static void SET_BOUNTY(int player, int amount) { Function.Call(0x093A9D1F72DF0D19, player, amount); }
		public static void CLEAR_BOUNTY(int player) { Function.Call(0xC76F252371150D9A, player); }
		public static int GET_WANTED_SCORE(int player) { return Function.Call<int>(0xDD5FD601481F648B, player); }
		public static void SET_WANTED_SCORE(int player, int intensity) { Function.Call(0xA80FF73F772ACF6A, player, intensity); }
		public static void CLEAR_WANTED_SCORE(int player) { Function.Call(0x062B4A4A3396351D, player); }
		public static void _0x331D349E0380B097(Any p0) { Function.Call(0x331D349E0380B097, p0); }
		public static void _0x292AD61A33A7A485() { Function.Call(0x292AD61A33A7A485); }
		public static void _0x07E8B8B20570271C(int player) { Function.Call(0x07E8B8B20570271C, player); }
		public static void _0x22741652985C84D0(int player, Hash lawRegionHash) { Function.Call(0x22741652985C84D0, player, lawRegionHash); }
		public static void _REPORT_PLAYER_LAW_DISPATCH_RESPONSE_OVERRIDE(int player, Hash dispatchResponseHash) { Function.Call(0x9C4352134B2835FB, player, dispatchResponseHash); }
		public static BOOL _0x9EF07CFBB19A9733() { return Function.Call<BOOL>(0x9EF07CFBB19A9733); }
		public static void _SET_LAW_DISABLED(BOOL toggle) { Function.Call(0x8DE82BC774F3B862, toggle); }
		public static void _FORCE_LAW_ON_LOCAL_PLAYER_IMMEDIATELY() { Function.Call(0x956510F8C36B5C64); }
		public static void _SET_LAW_REGION(int player, Hash lawRegionHash, Hash stateHash) { Function.Call(0x4752F68EB7F2D280, player, lawRegionHash, stateHash); }
		public static void _0x5E6F375CA101C108(int player, BOOL p1) { Function.Call(0x5E6F375CA101C108, player, p1); }
		public static void _SET_LAW_RBS_VOLUME(int player, Hash p1) { Function.Call(0x9BBDCB8DF789EBC1, player, p1); }
		public static BOOL IS_LAW_INCIDENT_ACTIVE(int player) { return Function.Call<BOOL>(0xAD401C63158ACBAA, player); }
		public static Hash _0x148E7AC8141C9E64(int player) { return Function.Call<Hash>(0x148E7AC8141C9E64, player); }
		public static void _0xEDFC6C1FD1C964F5(int player, Hash crimeType, int bounty, float p3, float p4, BOOL p5, float p6, float p7, Any p8) { Function.Call(0xEDFC6C1FD1C964F5, player, crimeType, bounty, p3, p4, p5, p6, p7, p8); }
		public static BOOL _LAW_WITNESS_RESPONSE_TASK(int pedGroup1, int ped, int pedGroup2, float x, float y, float z, Hash crimeType) { return Function.Call<BOOL>(0xF0B67BAD53C35BD9, pedGroup1, ped, pedGroup2, x, y, z, crimeType); }
		public static unsafe Any _0x018F30D762E62DF8(int ped, Any* p1) { return Function.Call<Any>(0x018F30D762E62DF8, ped, p1); }
		public static unsafe Any _0x318F0F9A4426CFA2(int ped, Any* p1) { return Function.Call<Any>(0x318F0F9A4426CFA2, ped, p1); }
		public static Any _0x95878B13E272EF1F(int entity, int ped, BOOL p2, float x, float y, float z, Hash crimeType) { return Function.Call<Any>(0x95878B13E272EF1F, entity, ped, p2, x, y, z, crimeType); }
		public static void _ADD_WITNESS_RESPONSE(int player, Hash crimeType, int pedGroup) { Function.Call(0x10827B5A0AAC56A7, player, crimeType, pedGroup); }
		public static void _0xD7494DED50C6EF52(int player, Hash crimeType, int p2) { Function.Call(0xD7494DED50C6EF52, player, crimeType, p2); }
		public static BOOL ARE_WITNESSES_ACTIVE(int player) { return Function.Call<BOOL>(0x69E181772886F48B, player); }
		public static BOOL _ARE_WITNESSES_PENDING(int player) { return Function.Call<BOOL>(0x0BB6DE7D23C60626, player); }
		public static BOOL _ARE_INVESTIGATORS_ACTIVE(int player, BOOL areInvestigatorsActive, Any p2) { return Function.Call<BOOL>(0xF0FBFB9AB15F7734, player, areInvestigatorsActive, p2); }
		public static void _0x522F74636DF10201(int player, ItemSet itemSet) { Function.Call(0x522F74636DF10201, player, itemSet); }
		public static void _0xDA1A9ADC4E3D4B16(ItemSet itemSet, Any p1, Any p2) { Function.Call(0xDA1A9ADC4E3D4B16, itemSet, p1, p2); }
		public static void _ENABLE_DISPATCH_LAW(BOOL toggle) { Function.Call(0xC805EB785824F712, toggle); }
		public static void _ENABLE_DISPATCH_LAW_2(BOOL toggle) { Function.Call(0x710448D44A64C213, toggle); }
		public static BOOL _0xECE3C34B270428D5() { return Function.Call<BOOL>(0xECE3C34B270428D5); }
		public static BOOL _ARE_LAW_PEDS_ENABLED_FOR_TRAIN() { return Function.Call<BOOL>(0xA22C46F16359471C); }
		public static void _0x82F11E1296996574(int p0) { Function.Call(0x82F11E1296996574, p0); }
		public static void _0x3852237A3D9DF145(int p0) { Function.Call(0x3852237A3D9DF145, p0); }
		public static BOOL _0x0EAF918F751F27BA(int ped) { return Function.Call<BOOL>(0x0EAF918F751F27BA, ped); }
		public static BOOL _0xC0DF161950FB101E(int ped) { return Function.Call<BOOL>(0xC0DF161950FB101E, ped); }
		public static Any _0xE4D6E45F491A66CB(int player, int p1) { return Function.Call<Any>(0xE4D6E45F491A66CB, player, p1); }
		public static int _0xE9EB79CBF9C0F58A(int player) { return Function.Call<int>(0xE9EB79CBF9C0F58A, player); }
		public static unsafe void _0x21213B833EF4DAE7(int player, int ped, Vector3* _outCoords) { Function.Call(0x21213B833EF4DAE7, player, ped, _outCoords); }
		public static void _0x61B98367D93F012F(int player) { Function.Call(0x61B98367D93F012F, player); }
		public static unsafe void _0x6ABC50979655BEE7(int player, Hash* crimeType, Any p2) { Function.Call(0x6ABC50979655BEE7, player, crimeType, p2); }
		public static void _0x390710D2DAFA6BFF(int player, BOOL p1) { Function.Call(0x390710D2DAFA6BFF, player, p1); }
		public static int _GET_CRIME_BOUNTY_AMOUNT_BY_TYPE(Hash crimeType) { return Function.Call<int>(0x35E5E21F9159849C, crimeType); }
		public static int _0xDAEFDFDB2AEECE37(Hash crimeType, Any p1) { return Function.Call<int>(0xDAEFDFDB2AEECE37, crimeType, p1); }
		public static Hash _GET_HUD_PLAYER_CRIME_TYPE(int player) { return Function.Call<Hash>(0x259CE340A8738814, player); }
		public static int _0xE083BEDA81709891(int player) { return Function.Call<int>(0xE083BEDA81709891, player); }
		public static BOOL _0x89E005B1662F6E48(int player, int p1, int p2) { return Function.Call<BOOL>(0x89E005B1662F6E48, player, p1, p2); }
		public static BOOL _0x3738B784DDD35CC6(int player, int p1, int p2) { return Function.Call<BOOL>(0x3738B784DDD35CC6, player, p1, p2); }
		public static int _0x0BDFEBCF40A5F7E3(Hash crimeType) { return Function.Call<int>(0x0BDFEBCF40A5F7E3, crimeType); }
		public static void _SET_CUSTOM_LAW_DISPATCH_RESPONSE(Hash dispatchResponseHash) { Function.Call(0x009CF9A29972C298, dispatchResponseHash); }
		public static Any _CREATE_LAW_DISPATCH_RESPONSE_FOR_COORDS(float x, float y, float z, Hash dispatchResponseHash) { return Function.Call<Any>(0x75CBF20BA47E4F89, x, y, z, dispatchResponseHash); }
		public static void _SET_BOUNTY_HUNTER_PURSUIT_CLEARED() { Function.Call(0x55F37F5F3F2475E1); }
		public static void _0xBD944A3D36E992DE() { Function.Call(0xBD944A3D36E992DE); }
		public static void _0x987BE590FB9D41E5(BOOL p0) { Function.Call(0x987BE590FB9D41E5, p0); }
		public static void _0xDCF12B89624AAC96(BOOL p0) { Function.Call(0xDCF12B89624AAC96, p0); }
		public static void _0xDDCE8E960D1DE240(BOOL p0) { Function.Call(0xDDCE8E960D1DE240, p0); }
		public static void _0xDEA083C16BB91345() { Function.Call(0xDEA083C16BB91345); }
		public static void _0x9C8A2BF37E966464(int player, ItemSet itemSet) { Function.Call(0x9C8A2BF37E966464, player, itemSet); }
		public static BOOL _0x9D5C9A5A3321B128(int player) { return Function.Call<BOOL>(0x9D5C9A5A3321B128, player); }
		public static BOOL _0x0F230DE0DDBE3649(int player) { return Function.Call<BOOL>(0x0F230DE0DDBE3649, player); }
		public static BOOL _0x9945A3E2528A02E8(int player) { return Function.Call<BOOL>(0x9945A3E2528A02E8, player); }
		public static float _0x717DA2281DF90855(int player) { return Function.Call<float>(0x717DA2281DF90855, player); }
		public static void _0x9B4C564BFA7CFF37(float p0) { Function.Call(0x9B4C564BFA7CFF37, p0); }
		public static void _SET_ALLOW_DISABLED_LAW_RESPONSES(BOOL toggle) { Function.Call(0x4B52BF96E225D230, toggle); }
		public static void RESET_WANTED_FOR_NEW_INCIDENT(int player) { Function.Call(0x2728C77FBC4B9796, player); }
		public static BOOL _0x856CE8FDE2416602(int ped) { return Function.Call<BOOL>(0x856CE8FDE2416602, ped); }
		public static BOOL _0x7351DA734F989F4E(int entity) { return Function.Call<BOOL>(0x7351DA734F989F4E, entity); }
		public static int _GET_BOUNTY_HUNTER_GLOBAL_COOLDOWN(Hash p0) { return Function.Call<int>(0x76CF93D4B416B288, p0); }
		public static void _SET_BOUNTY_HUNTER_GLOBAL_COOLDOWN(Hash p0, int p1) { Function.Call(0xF19706B1F8FFA88F, p0, p1); }
		public static void _0x2001687F9562FD9D(Any p0) { Function.Call(0x2001687F9562FD9D, p0); }
		public static void _PAUSE_BOUNTY_HUNTER_COOLDOWN(Hash p0, BOOL p1, Any p2) { Function.Call(0xC61EDEBF16CD9668, p0, p1, p2); }
		public static void _0xE9AC8466ABE484BB(BOOL p0, Any p1) { Function.Call(0xE9AC8466ABE484BB, p0, p1); }
		public static BOOL _0x40851BCC33ACD9AB(int ped) { return Function.Call<BOOL>(0x40851BCC33ACD9AB, ped); }
		public static BOOL _0xF46108C50A22B029() { return Function.Call<BOOL>(0xF46108C50A22B029); }
		public static void _0x7803436E68C32B26() { Function.Call(0x7803436E68C32B26); }
		public static void _0xC310239ACCCF5579() { Function.Call(0xC310239ACCCF5579); }
		public static void _0x29CD4896ECB66C12() { Function.Call(0x29CD4896ECB66C12); }
		public static void _0xE94B5E938619712E() { Function.Call(0xE94B5E938619712E); }
		public static int _0x7FC667F6DDFBCDCC(int player) { return Function.Call<int>(0x7FC667F6DDFBCDCC, player); }
		public static unsafe void _0x9C5BD8C562565CE6(Hash* crimeType) { Function.Call(0x9C5BD8C562565CE6, crimeType); }
		public static void _0xCBFB4951F2E3934C(int player, Any p1) { Function.Call(0xCBFB4951F2E3934C, player, p1); }
		public static void _SET_PED_LAW_BEHAVIOUR(int ped, int behaviour) { Function.Call(0x819ADD5EF1742F47, ped, behaviour); }
		public static void _0x00DB0BC05E3FAA4E(int ped, int bitset) { Function.Call(0x00DB0BC05E3FAA4E, ped, bitset); }
		public static void _0x0C392DB374655176(float x, float y, float z, float p3, ItemSet itemSet) { Function.Call(0x0C392DB374655176, x, y, z, p3, itemSet); }
		public static unsafe Any _0xC687A23E166DCF68(Any* p0) { return Function.Call<Any>(0xC687A23E166DCF68, p0); }
		public static void _SET_DISPATCH_MULTIPLIER_OVERRIDE(float multiplier) { Function.Call(0x002BABE0B7D53136, multiplier); }
		public static BOOL _0x26934083D3F2579C(int player) { return Function.Call<BOOL>(0x26934083D3F2579C, player); }
		public static unsafe BOOL GET_PLAYER_REGISTERED_CRIME(int player, int p1, Hash* crimeType) { return Function.Call<BOOL>(0x532C5FDDB986EE5C, player, p1, crimeType); }
		public static unsafe BOOL _0xB527099D1E1EED49(int player, int p1, Hash* crimeType) { return Function.Call<BOOL>(0xB527099D1E1EED49, player, p1, crimeType); }
		public static void CLEAR_PLAYER_PAST_CRIMES(int player) { Function.Call(0xBCC6DC59E32A2BDC, player); }
		public static void SET_PLAYER_ARRESTED_IN_REGION(int player, Hash lawRegionHash) { Function.Call(0xE0FA74AA3CCE650B, player, lawRegionHash); }
		public static void SET_PLAYER_TURNED_IN_BOUNTY_IN_REGION(int player, Hash lawRegionHash) { Function.Call(0x73BAD7B2F2DB50DE, player, lawRegionHash); }
		public static void _0xD6C0A8C7C0B2F82C(int player, BOOL p1) { Function.Call(0xD6C0A8C7C0B2F82C, player, p1); }
		public static void SET_LAW_SENSE_RANGE_MODIFIER(int player, float range) { Function.Call(0xFEC85339AACA2A35, player, range); }
		public static void _0x7EF2A2FE38D74456(int flag, BOOL p1) { Function.Call(0x7EF2A2FE38D74456, flag, p1); }
		public static BOOL _0xC7DC5A0A7DF608CB(int flag) { return Function.Call<BOOL>(0xC7DC5A0A7DF608CB, flag); }
		public static void SET_DISABLE_DISTURBANCE_CRIMES(int player, BOOL p1) { Function.Call(0xDE5FAA741A781F73, player, p1); }
		public static void SET_POSTPONE_DISTURBANCE_CRIMES_DURING_COMBAT(int player, BOOL p1) { Function.Call(0x362086B911657B1A, player, p1); }
		public static void _CREATE_GUARD_ZONE(string name) { Function.Call(0x8F9DE75680275C9F, name); }
		public static void _REMOVE_GUARD_ZONE(string name) { Function.Call(0x67EBDD958835956C, name); }
		public static void _0x9772395CC73E8D1F(int ped, string name) { Function.Call(0x9772395CC73E8D1F, ped, name); }
		public static void _DISABLE_GUARD_ZONE(string name) { Function.Call(0x26D558692B25DD95, name); }
		public static BOOL _0x0DBACA9C38C9A686(string name) { return Function.Call<BOOL>(0x0DBACA9C38C9A686, name); }
		public static BOOL _IS_GUARD_PED_INVESTIGATING(int ped) { return Function.Call<BOOL>(0xD743C4293F47AFAD, ped); }
		public static BOOL _CREATE_GUARD_ZONE_FOR_ENTITY(string guardZoneName, int entity, float x, float y, float z) { return Function.Call<BOOL>(0x0D4B77E862475ED3, guardZoneName, entity, x, y, z); }
		public static void _SET_GUARD_ZONE_VOLUME_REGISTRATION_START(string name, Volume volume) { Function.Call(0x8C598A930F471938, name, volume); }
		public static void _SET_GUARD_ZONE_VOLUME_RESTRICTED(string name, Volume volume) { Function.Call(0x35815F372D43E1E5, name, volume); }
		public static void _SET_GUARD_ZONE_VOLUME_THREAT(string name, Volume volume) { Function.Call(0xA1B0E6301E2E02A6, name, volume); }
		public static void _SET_GUARD_ZONE_VOLUME_WARNING(string name, Volume volume) { Function.Call(0xAD3E07C37A7C1ADC, name, volume); }
		public static void _SET_GUARD_ZONE_VOLUME_REGISTRATION_END(string name, Volume volume) { Function.Call(0xA8A74AA79FB67159, name, volume); }
		public static void _SET_GUARD_ZONE_POSITION(string name, float x, float y, float z) { Function.Call(0x7E7BF59F89FC6C6D, name, x, y, z); }
		public static void _SET_GUARD_ZONE_POSITION_2(string name, float x, float y, float z) { Function.Call(0x2F9005E2EA4E5EE4, name, x, y, z); }
	}

	public static class LOCALIZATION
	{
		public static int _LOCALIZATION_GET_SYSTEM_LANGUAGE() { return Function.Call<int>(0x3C1A05F86AE6ACB5); }
		public static int GET_CURRENT_LANGUAGE() { return Function.Call<int>(0xDB917DA5C6835FCC); }
		public static BOOL _0x45D50415E4D885FF() { return Function.Call<BOOL>(0x45D50415E4D885FF); }
		public static int _LOCALIZATION_GET_SYSTEM_DATE_FORMAT() { return Function.Call<int>(0x76E30B799EBEEA0F); }
	}

	public static class MAP
	{
		public static int GET_BLIP_FROM_ENTITY(int entity) { return Function.Call<int>(0x6D2C41A8BD6D6FD0, entity); }
		public static int GET_MAIN_PLAYER_BLIP_ID() { return Function.Call<int>(0x5CD2889B2B381D45); }
		public static int _BLIP_ADD_FOR_STYLE(Hash styleHash) { return Function.Call<int>(0x3E593DF9C2962EC6, styleHash); }
		public static int BLIP_ADD_FOR_COORDS(Hash blipHash, float x, float y, float z) { return Function.Call<int>(0x554D9D53F696D002, blipHash, x, y, z); }
		public static int BLIP_ADD_FOR_ENTITY(Hash blipHash, int entity) { return Function.Call<int>(0x23F74C2FDA6E7C61, blipHash, entity); }
		public static int BLIP_ADD_FOR_PICKUP_PLACEMENT(Hash blipHash, int pickup) { return Function.Call<int>(0xA486008892065FB9, blipHash, pickup); }
		public static int BLIP_ADD_FOR_RADIUS(Hash blipHash, float x, float y, float z, float radius) { return Function.Call<int>(0x45F13B7E0A15C880, blipHash, x, y, z, radius); }
		public static int _BLIP_ADD_FOR_AREA(Hash blipHash, float x, float y, float z, float scaleX, float scaleY, float scaleZ, int p7) { return Function.Call<int>(0xEC174ADBCB611ECC, blipHash, x, y, z, scaleX, scaleY, scaleZ, p7); }
		public static int _BLIP_ADD_FOR_VOLUME(Hash blipHash, Volume volume) { return Function.Call<int>(0xA6EF0C54A3443E70, blipHash, volume); }
		public static BOOL _BLIP_SET_STYLE(int blip, Hash styleHash) { return Function.Call<BOOL>(0xEDD964B7984AC291, blip, styleHash); }
		public static BOOL _BLIP_ADD_STYLE(int blip, Hash styleHash) { return Function.Call<BOOL>(0xBD62D98799A3DAF0, blip, styleHash); }
		public static BOOL BLIP_ADD_MODIFIER(int blip, Hash modifierHash) { return Function.Call<BOOL>(0x662D364ABF16DE2F, blip, modifierHash); }
		public static BOOL BLIP_REMOVE_MODIFIER(int blip, Hash modifierHash) { return Function.Call<BOOL>(0xB059D7BD3D78C16F, blip, modifierHash); }
		public static void _0x250C75EB1728CC0D(int blip) { Function.Call(0x250C75EB1728CC0D, blip); }
		public static void SET_BLIP_FLASH_TIMER(int blip, int blipType, Hash blipHash) { Function.Call(0x02FF4CF43B7209D1, blip, blipType, blipHash); }
		public static unsafe BOOL SET_BLIP_FLASHES(int blip, int* p1, Hash* p2) { return Function.Call<BOOL>(0x0DF2B55F717DDB10, blip, p1, p2); }
		public static void TRIGGER_SONAR_BLIP(Hash typeHash, float x, float y, float z) { Function.Call(0x72DD432F3CDFC0EE, typeHash, x, y, z); }
		public static void _TRIGGER_SONAR_BLIP_ON_ENTITY(Hash typeHash, int entity) { Function.Call(0x0C7A2289A5C4D7C9, typeHash, entity); }
		public static void ALLOW_SONAR_BLIPS(BOOL toggle) { Function.Call(0x6E6E64788C07D2E0, toggle); }
		public static void SET_BLIP_COORDS(int blip, float posX, float posY, float posZ) { Function.Call(0x4FF674F5E23D49CE, blip, posX, posY, posZ); }
		public static Vector3 GET_BLIP_COORDS(int blip) { return Function.Call<Vector3>(0x201C319797BDA603, blip); }
		public static void SET_BLIP_SPRITE(int blip, Hash hash, BOOL p2) { Function.Call(0x74F74D3207ED525C, blip, hash, p2); }
		public static Any _0x01B928CA2E198B01(Any p0) { return Function.Call<Any>(0x01B928CA2E198B01, p0); }
		public static void SET_BLIP_NAME_FROM_TEXT_FILE(int blip, string textLabel) { Function.Call(0x0A062D6D7C0B2C2C, blip, textLabel); }
		public static void _SET_BLIP_NAME_FROM_PLAYER_STRING(int blip, string playerString) { Function.Call(0x9CB1A1623062F402, blip, playerString); }
		public static void SET_BLIP_NAME_TO_PLAYER_NAME(int blip, int player) { Function.Call(0x093DD5A31BC2B459, blip, player); }
		public static void SET_BLIP_ROTATION(int blip, int rotation) { Function.Call(0x6049966A94FBE706, blip, rotation); }
		public static void SET_BLIP_SCALE(int blip, float scale) { Function.Call(0xD38744167B2FA257, blip, scale); }
		public static unsafe void REMOVE_BLIP(int* blip) { Function.Call(0xF2C3C9DA47AAA54A, blip); }
		public static BOOL DOES_BLIP_EXIST(int blip) { return Function.Call<BOOL>(0xCD82FA174080B3B1, blip); }
		public static BOOL _DOES_ENTITY_HAVE_BLIP(int entity) { return Function.Call<BOOL>(0x9FA00E2FC134A9D0, entity); }
		public static void SET_RADAR_ZOOM(int zoomLevel) { Function.Call(0xCAF6489DA2C8DD9E, zoomLevel); }
		public static void _ABANDON_BLIP(int blip) { Function.Call(0xDEEDE7C41742E011, blip); }
		public static BOOL _IS_BLIP_ATTACHED_TO_ANY_ENTITY(int blip) { return Function.Call<BOOL>(0xE9F676788F8D5E1E, blip); }
		public static BOOL IS_BLIP_ON_MINIMAP(int blip) { return Function.Call<BOOL>(0x46534526B9CD2D17, blip); }
		public static Any FORCE_SONAR_BLIPS_THIS_FRAME() { return Function.Call<Any>(0xEE1C7BA69BB74B08); }
		public static void SET_GPS_FLAGS(int p0, float p1) { Function.Call(0x5DE61C90DDECFA2D, p0, p1); }
		public static void CLEAR_GPS_FLAGS() { Function.Call(0x4D3771237C79FF41); }
		public static void SET_GPS_CUSTOM_ROUTE_RENDER(BOOL p0, int p1, int p2) { Function.Call(0xF6CEF599FC470B33, p0, p1, p2); }
		public static void CLEAR_GPS_CUSTOM_ROUTE() { Function.Call(0x1EAA5674B4D181C5); }
		public static void START_GPS_MULTI_ROUTE(Hash colorNameHash, BOOL onFoot, BOOL inVehicle) { Function.Call(0x3D3D15AF7BCAAF83, colorNameHash, onFoot, inVehicle); }
		public static void ADD_POINT_TO_GPS_MULTI_ROUTE(float x, float y, float z, BOOL p3) { Function.Call(0x64C59DD6834FA942, x, y, z, p3); }
		public static void SET_GPS_MULTI_ROUTE_RENDER(BOOL toggle) { Function.Call(0x4426D65E029A4DC0, toggle); }
		public static void CLEAR_GPS_MULTI_ROUTE() { Function.Call(0x9E0AB9AAEE87CE28); }
		public static void _START_GPS_CUSTOM_ROUTE_FROM_WAYPOINT_RECORDING_ROUTE(string waypointRecording, int point, int numPoints, Hash colorNameHash, BOOL p4, BOOL p5) { Function.Call(0x6B44F13D888F770D, waypointRecording, point, numPoints, colorNameHash, p4, p5); }
		public static void CLEAR_GPS_PLAYER_WAYPOINT() { Function.Call(0x08FDC6F796E350D1); }
		public static void _0xD3F58E9316B7FC2A(Any p0) { Function.Call(0xD3F58E9316B7FC2A, p0); }
		public static void SET_WAYPOINT_OFF() { Function.Call(0xFA8C41E8020D3439); }
		public static BOOL IS_WAYPOINT_ACTIVE() { return Function.Call<BOOL>(0x202B1BBFC6AB5EE4); }
		public static Vector3 _GET_WAYPOINT_COORDS() { return Function.Call<Vector3>(0x29B30D07C3F7873B); }
		public static Any _0xF08E42BFA46BDFF8(Any p0, Any p1) { return Function.Call<Any>(0xF08E42BFA46BDFF8, p0, p1); }
		public static void _HIDE_ACTIVE_POINTS_OF_INTEREST() { Function.Call(0xA1B4052C2A3DCC1E); }
		public static void _SHOW_ACTIVE_POINTS_OF_INTEREST() { Function.Call(0x3FBB838AEA30C1D8); }
		public static Any _0xF47A1EB2A538A3A3() { return Function.Call<Any>(0xF47A1EB2A538A3A3); }
		public static unsafe BOOL _FIND_CLOSEST_GPS_POSITION(float x, float y, float z, Vector3* _outPosition) { return Function.Call<BOOL>(0x3FDA2B79AEEE351C, x, y, z, _outPosition); }
		public static void DISPLAY_RADAR(BOOL toggle) { Function.Call(0x1B3DA717B9AFF828, toggle); }
		public static void _SET_RADAR_CONFIG_TYPE(Hash configHash, Hash p1) { Function.Call(0x9C113883487FD53C, configHash, p1); }
		public static void _ADD_PROP_TO_MINIMAP(Hash minimapProp, float x, float y, float rotation, int p4) { Function.Call(0x1392105DA88BBFFB, minimapProp, x, y, rotation, p4); }
		public static void _REMOVE_PROP_FROM_MINIMAP(Hash minimapProp) { Function.Call(0xE057FEA9A22EB3EE, minimapProp); }
		public static void SET_RADAR_AS_EXTERIOR_THIS_FRAME() { Function.Call(0xA8EBBAE986FB5457); }
		public static void SET_MINIMAP_HIDE_FOW(BOOL toggle) { Function.Call(0x4B8F743A4A6D2FF8, toggle); }
		public static void _SET_FOW_UPDATE_PLAYER_OVERRIDE(BOOL toggle, Hash p1) { Function.Call(0x63E7279D04160477, toggle, p1); }
		public static void _SET_MINIMAP_FOW_OVERRIDE_REVEAL_SCALE(float scale, Hash p1) { Function.Call(0xE5A7F70B7C0F3271, scale, p1); }
		public static void _SET_MINIMAP_FOW_SHOULD_UPDATE(BOOL toggle, Hash p1) { Function.Call(0x632AA10BF7EA53D3, toggle, p1); }
		public static void SET_MINIMAP_FOW_REVEAL_COORDINATE(float x, float y, float z, Hash p3) { Function.Call(0x73348402566ECB6E, x, y, z, p3); }
		public static void SET_MINIMAP_FOW_REVEAL_VOLUME(Volume volume, Hash p1) { Function.Call(0x63CBBD6CA6F321F9, volume, p1); }
		public static void RESET_MINIMAP_FOW(Hash hash) { Function.Call(0xEB3CB3386C775D72, hash); }
		public static void _REVEAL_MINIMAP_FOW(Hash hash) { Function.Call(0xF8096DF9B87246E3, hash); }
		public static void _SET_MINIMAP_ZONE(Hash zone) { Function.Call(0xA657EC9DBC6CC900, zone); }
		public static void LOCK_MINIMAP_ANGLE(int angle) { Function.Call(0x0BFD145EF819FB3A, angle); }
		public static void UNLOCK_MINIMAP_ANGLE() { Function.Call(0x5373DE8E179BC2A0); }
		public static void _MAP_ENABLE_REGION_BLIP(Hash regionHash, Hash styleHash) { Function.Call(0x563FCB6620523917, regionHash, styleHash); }
		public static void _MAP_DISABLE_REGION_BLIP(Hash regionHash) { Function.Call(0x6786D7AFAC3162B3, regionHash); }
		public static BOOL _MAP_IS_REGION_HIGHLIGHTED_WITH_STYLE(Hash regionHash, Hash styleHash) { return Function.Call<BOOL>(0xE38450DBCBC70E3D, regionHash, styleHash); }
		public static void _MAP_DISCOVER_REGION(Hash discoveryHash) { Function.Call(0xD8C7162AB2E2AF45, discoveryHash); }
		public static void _MAP_DISCOVERY_SET_ENABLED(Hash discoveryHash) { Function.Call(0xDA98246C7A3C2189, discoveryHash); }
		public static BOOL _MAP_IS_DISCOVERY_ACTIVE(Hash discoveryHash) { return Function.Call<BOOL>(0x3F81EA4275D39D6F, discoveryHash); }
		public static void _SET_PAUSEMAP_COORDS_WITH_RADIUS(float x, float y, float z, float radius) { Function.Call(0xE0884C184728C75B, x, y, z, radius); }
		public static void _0x7C9F4CDF402CA82A() { Function.Call(0x7C9F4CDF402CA82A); }
		public static void _0x44813684F72B563C(int entity, Any p1) { Function.Call(0x44813684F72B563C, entity, p1); }
		public static void _0x97F6F158CC5B5CA2(int entity, Any p1) { Function.Call(0x97F6F158CC5B5CA2, entity, p1); }
		public static void _0xBB68D4D3CA3DE402(Any p0, Any p1) { Function.Call(0xBB68D4D3CA3DE402, p0, p1); }
		public static Any _0x3CB8859F04763C78(Any p0, Any p1) { return Function.Call<Any>(0x3CB8859F04763C78, p0, p1); }
		public static void _0x7563CBCA99253D1A(int entity, Hash blip) { Function.Call(0x7563CBCA99253D1A, entity, blip); }
		public static void _0x1726963E6049DB53(Any p0) { Function.Call(0x1726963E6049DB53, p0); }
	}

	public static class MINIGAME
	{
		public static void _0x6480723D3BE535B6(Any p0) { Function.Call(0x6480723D3BE535B6, p0); }
		public static void _0x3DF7EE3A76185108() { Function.Call(0x3DF7EE3A76185108); }
		public static Any _0xE1F365C4C8F259D8(Any p0, Any p1, Any p2) { return Function.Call<Any>(0xE1F365C4C8F259D8, p0, p1, p2); }
		public static Any _0xE53A308AC35877A8() { return Function.Call<Any>(0xE53A308AC35877A8); }
		public static Any _0x580F34C726387226(Any p0, Any p1) { return Function.Call<Any>(0x580F34C726387226, p0, p1); }
		public static void _0x0876326238914A3F() { Function.Call(0x0876326238914A3F); }
		public static Any _0x3FFE60DD8A936551(Any p0, Any p1) { return Function.Call<Any>(0x3FFE60DD8A936551, p0, p1); }
		public static void _0x18A0D48DF9211C07() { Function.Call(0x18A0D48DF9211C07); }
		public static Any _MINIGAME_IS_CONNECTED_TO_SERVER(Any p0) { return Function.Call<Any>(0x2A0C4736AC5AF0CE, p0); }
		public static Any _0x39654E1F68B78287() { return Function.Call<Any>(0x39654E1F68B78287); }
		public static Any _0x3EECAADAB0D9FE29() { return Function.Call<Any>(0x3EECAADAB0D9FE29); }
		public static Any _0xD39D32EB3B52DD83(Any p0) { return Function.Call<Any>(0xD39D32EB3B52DD83, p0); }
		public static BOOL _MINIGAME_IS_SEAT_OCCUPIED(Any p0) { return Function.Call<BOOL>(0x8593A8CB0ED2C3B4, p0); }
		public static unsafe BOOL _MINIGAME_REQUEST_SEAT_AT_TABLE(Any* data) { return Function.Call<BOOL>(0xF6AC6085D8D6C004, data); }
		public static Any _MINIGAME_LEAVE_TABLE(Any p0) { return Function.Call<Any>(0xF5446E47941E654C, p0); }
		public static Any _MINIGAME_GET_NEXT_EVENT_TYPE() { return Function.Call<Any>(0x578907F59BA01B6C); }
		public static Any _MINIGAME_GET_NEXT_EVENT(Any p0, Any p1) { return Function.Call<Any>(0xDF728C5AE137FC13, p0, p1); }
		public static void _MINIGAME_POP_NEXT_EVENT() { Function.Call(0x833E03BAEBADC4B0); }
		public static Any _0x3B31732FADE5BAF3() { return Function.Call<Any>(0x3B31732FADE5BAF3); }
		public static Any _0x578907F59BA01B6D(Any p0) { return Function.Call<Any>(0x578907F59BA01B6D, p0); }
		public static Any _0xDF728C5AE137FC14(Any p0, Any p1, Any p2) { return Function.Call<Any>(0xDF728C5AE137FC14, p0, p1, p2); }
		public static Any _MINIGAME_IS_REQUEST_PENDING(Any p0) { return Function.Call<Any>(0x9105A4A2556FA937, p0); }
		public static Any _0x644439B5387EE57E(Any p0, Any p1) { return Function.Call<Any>(0x644439B5387EE57E, p0, p1); }
		public static Any _0x15E90B6A993017AA() { return Function.Call<Any>(0x15E90B6A993017AA); }
		public static Any _0x10342CC82E8356E9(Any p0, Any p1) { return Function.Call<Any>(0x10342CC82E8356E9, p0, p1); }
		public static Any _0x32A7C216344D623B(Any p0, Any p1, Any p2) { return Function.Call<Any>(0x32A7C216344D623B, p0, p1, p2); }
		public static Any _0xEC819D612038EF4B(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7) { return Function.Call<Any>(0xEC819D612038EF4B, p0, p1, p2, p3, p4, p5, p6, p7); }
		public static Any _POKER_GET_GAME_SETTINGS_FOR_ID(Any p0) { return Function.Call<Any>(0x2D20E12E1990D584, p0); }
		public static Any _POKER_BUY_IN(Any p0, Any p1) { return Function.Call<Any>(0xB4D610EA5A1FDE74, p0, p1); }
		public static Any _POKER_CALL(Any p0, Any p1) { return Function.Call<Any>(0x8DED681B161EBD78, p0, p1); }
		public static Any _POKER_CHECK(Any p0, Any p1) { return Function.Call<Any>(0x49A045628D9B1B86, p0, p1); }
		public static Any _POKER_FOLD(Any p0) { return Function.Call<Any>(0x3DFAB7D9BB45B5BE, p0); }
		public static Any _POKER_RAISE(Any p0, Any p1) { return Function.Call<Any>(0xECCF45A79A17BB96, p0, p1); }
		public static Any _POKER_REVEAL(Any p0) { return Function.Call<Any>(0x2F2131DB0A8B02DC, p0); }
		public static void _0x58521E6DCDE97D74(Any p0, Any p1, Any p2) { Function.Call(0x58521E6DCDE97D74, p0, p1, p2); }
		public static void _0xF6DE98516FD3AC9B() { Function.Call(0xF6DE98516FD3AC9B); }
		public static Any _0x3F4FD4BED07AB8C4(Any p0) { return Function.Call<Any>(0x3F4FD4BED07AB8C4, p0); }
		public static Any _0x3AE451860F03CA8A(Any p0, Any p1) { return Function.Call<Any>(0x3AE451860F03CA8A, p0, p1); }
		public static Any _0x012027C28F421F46(Any p0, Any p1) { return Function.Call<Any>(0x012027C28F421F46, p0, p1); }
		public static void _0x455ECCA0715C507F() { Function.Call(0x455ECCA0715C507F); }
		public static Any _DOMINOES_BUY_IN(Any p0) { return Function.Call<Any>(0x399E6CD12FC8CA89, p0); }
		public static Any _DOMINOES_PLACE_DOMINO(Any p0, Any p1) { return Function.Call<Any>(0xB79A29B33BF29BA5, p0, p1); }
		public static Any _DOMINOES_REQUEST_VALID_PLACEMENTS(Any p0) { return Function.Call<Any>(0xE26AEE7E67D9E21D, p0); }
		public static Any _0xA2DB3C6270C122E3(Any p0, Any p1) { return Function.Call<Any>(0xA2DB3C6270C122E3, p0, p1); }
		public static Any _0x398066F893149856(Any p0, Any p1, Any p2) { return Function.Call<Any>(0x398066F893149856, p0, p1, p2); }
		public static Any _0xBEA7D3CB47E1479C() { return Function.Call<Any>(0xBEA7D3CB47E1479C); }
		public static Any _0x910B088E51A511AC() { return Function.Call<Any>(0x910B088E51A511AC); }
		public static Any _0x9DD95B405AB4983E(Any p0, Any p1) { return Function.Call<Any>(0x9DD95B405AB4983E, p0, p1); }
	}

	public static class MISC
	{
		public static int GET_NUMBER_OF_FREE_STACKS_OF_THIS_SIZE(int stackSize) { return Function.Call<int>(0x40DC2907A9697EF7, stackSize); }
		public static int _GET_NUMBER_OF_INSTRUCTIONS() { return Function.Call<int>(0x72904D3D62AF5839); }
		public static int _GET_MAX_NUM_INSTRUCTIONS() { return Function.Call<int>(0xC43CD2668B204419); }
		public static BOOL IS_MAG_DEMO_1_ACTIVE() { return Function.Call<BOOL>(0x5FC9357C26DAEFCE); }
		public static void SET_RANDOM_SEED(int seed) { Function.Call(0x5CD7A49104AFCB6B, seed); }
		public static void SET_TIME_SCALE(float timeScale) { Function.Call(0x9682AF6050854856, timeScale); }
		public static void SET_MISSION_FLAG(BOOL toggle) { Function.Call(0x36694B456BE80D0A, toggle); }
		public static BOOL GET_MISSION_FLAG() { return Function.Call<BOOL>(0xB15CD1CF58771DE1); }
		public static void _0x5801BE2DF2AF07EC(Any p0) { Function.Call(0x5801BE2DF2AF07EC, p0); }
		public static void SET_RANDOM_EVENT_FLAG(BOOL toggle) { Function.Call(0xB1ADCCC4150C6473, toggle); }
		public static BOOL GET_RANDOM_EVENT_FLAG() { return Function.Call<BOOL>(0x924D54E5698AE3E0); }
		public static void _0x9BF2C0C568C61641(Any p0) { Function.Call(0x9BF2C0C568C61641, p0); }
		public static void _0xCC7FC854B956A128(string p0, string p1) { Function.Call(0xCC7FC854B956A128, p0, p1); }
		public static void _0x9935F76407C32539(string p0) { Function.Call(0x9935F76407C32539, p0); }
		public static void _0xFF252E2BAFB7330F(Any p0) { Function.Call(0xFF252E2BAFB7330F, p0); }
		public static void _0x91D657230BC208D2(string p0, string p1) { Function.Call(0x91D657230BC208D2, p0, p1); }
		public static void _0x1694A053DFB61A34(string p0) { Function.Call(0x1694A053DFB61A34, p0); }
		public static Any _0xAF530E56505D1BD6(Any p0) { return Function.Call<Any>(0xAF530E56505D1BD6, p0); }
		public static void _0xB16FC7B364D86585() { Function.Call(0xB16FC7B364D86585); }
		public static string _0xF81C53561D15F330() { return Function.Call<string>(0xF81C53561D15F330); }
		public static void _0x1096603B519C905F(string name) { Function.Call(0x1096603B519C905F, name); }
		public static void _0xCC3EDC5614B03F61(int p0) { Function.Call(0xCC3EDC5614B03F61, p0); }
		public static void _0x708DF841B8F27AA2(string p0) { Function.Call(0x708DF841B8F27AA2, p0); }
		public static void _0xDA4D8EB04E8E2928(Any p0) { Function.Call(0xDA4D8EB04E8E2928, p0); }
		public static void _0xB08C4FA25BC29DB9(Any p0) { Function.Call(0xB08C4FA25BC29DB9, p0); }
		public static Hash _GET_PREV_WEATHER_TYPE_HASH_NAME() { return Function.Call<Hash>(0x4BEB42AEBCA732E9); }
		public static Hash _GET_NEXT_WEATHER_TYPE_HASH_NAME() { return Function.Call<Hash>(0x51021D36F62AAA83); }
		public static void _0x0730E518486DEEC3(Any p0) { Function.Call(0x0730E518486DEEC3, p0); }
		public static void SET_WEATHER_TYPE(Hash weatherType, BOOL p1, BOOL p2, BOOL transition, float transitionTime, BOOL p5) { Function.Call(0x59174F1AFE095B5A, weatherType, p1, p2, transition, transitionTime, p5); }
		public static void _SET_WEATHER_TYPE_2(Hash weatherType, int p1, int p2, int p3, BOOL p4) { Function.Call(0x2C6A07AF9AEDABD8, weatherType, p1, p2, p3, p4); }
		public static int _GET_RANDOM_WEATHER_TYPE_INDEX() { return Function.Call<int>(0x7F4CE164D9A11DFE); }
		public static Hash _GET_RANDOM_WEATHER_TYPE() { return Function.Call<Hash>(0x1359C181BC625503); }
		public static void SET_RANDOM_WEATHER_TYPE(BOOL p0, BOOL p1) { Function.Call(0x6E5A7FBEECAB3C72, p0, p1); }
		public static void CLEAR_WEATHER_TYPE_PERSIST() { Function.Call(0xD85DFE5C131E4AE9); }
		public static void _CLEAR_WEATHER_TYPE_PERSIST_OVERTIME(int milliseconds) { Function.Call(0xCE7690C0A0D1C36D, milliseconds); }
		public static unsafe void _GET_WEATHER_TYPE_TRANSITION(Hash* weatherType1, Hash* weatherType2, float* percentWeather2) { Function.Call(0x0AC679B2342F14F2, weatherType1, weatherType2, percentWeather2); }
		public static void _SET_WEATHER_TYPE_TRANSITION(Hash weatherType1, Hash weatherType2, float percentWeather2, BOOL enabled) { Function.Call(0xFA3E3CA8A1DE6D5D, weatherType1, weatherType2, percentWeather2, enabled); }
		public static void _SET_WEATHER_TYPE_FROZEN(BOOL toggle) { Function.Call(0xD74ACDF7DB8114AF, toggle); }
		public static unsafe void _GET_FORCED_WEATHER(Hash* weather, Hash* p1) { Function.Call(0xDD560ABEF5D3784C, weather, p1); }
		public static void _0x2916B30DC6C41179(Hash weatherType) { Function.Call(0x2916B30DC6C41179, weatherType); }
		public static void _0xD3F943B88F55376A(Hash weatherType) { Function.Call(0xD3F943B88F55376A, weatherType); }
		public static void _0x243CEDE8F916B994() { Function.Call(0x243CEDE8F916B994); }
		public static void _SET_OVERRIDE_WEATHER(Hash weatherType) { Function.Call(0xBE83CAE8ED77A94F, weatherType); }
		public static void CLEAR_OVERRIDE_WEATHER() { Function.Call(0x80A398F16FFE3CC3); }
		public static void _SET_WEATHER_VARIATION(string weatherType, string variation) { Function.Call(0x3373779BAF7CAF48, weatherType, variation); }
		public static void _CLEAR_WEATHER_VARIATION(string weatherType, BOOL p1) { Function.Call(0x0E71C80FA4EC8147, weatherType, p1); }
		public static void WATER_OVERRIDE_SET_SHOREWAVEAMPLITUDE(float amplitude) { Function.Call(0x55123D5A7D9D3C42, amplitude); }
		public static void WATER_OVERRIDE_SET_OCEANWAVEMAXAMPLITUDE(float maxAmplitude) { Function.Call(0xF06C5B66DE20B2B8, maxAmplitude); }
		public static float _GET_TEMPERATURE_AT_COORDS(float x, float y, float z) { return Function.Call<float>(0xB98B78C3768AF6E0, x, y, z); }
		public static void SET_WIND_SPEED(float speed) { Function.Call(0xD00C2D82DC04A99F, speed); }
		public static float GET_WIND_SPEED() { return Function.Call<float>(0xFFB7E74E041150A4); }
		public static void SET_WIND_DIRECTION(float direction) { Function.Call(0xB56C4F5F57A45600, direction); }
		public static Vector3 GET_WIND_DIRECTION() { return Function.Call<Vector3>(0xF703E82F3FE14A5F); }
		public static void _SET_RAIN_LEVEL(float intensity) { Function.Call(0x193DFC0526830FD6, intensity); }
		public static float GET_RAIN_LEVEL() { return Function.Call<float>(0x931B5F4CC130224B); }
		public static void _0x745808BB01CEC6B9(float p0) { Function.Call(0x745808BB01CEC6B9, p0); }
		public static void _SET_SNOW_LEVEL(float level) { Function.Call(0xF6BEE7E80EC5CA40, level); }
		public static float GET_SNOW_LEVEL() { return Function.Call<float>(0x1E5D727041BE1709); }
		public static void FORCE_LIGHTNING_FLASH() { Function.Call(0x369DB5B2510FA080); }
		public static void _FORCE_LIGHTNING_FLASH_AT_COORDS(float x, float y, float z, float p3) { Function.Call(0x67943537D179597C, x, y, z, p3); }
		public static void _0xA9342743B634A462(Any p0) { Function.Call(0xA9342743B634A462, p0); }
		public static int GET_GAME_TIMER() { return Function.Call<int>(0x4F67E8ECA7D3F667); }
		public static int _GET_GAME_TIMER_NON_SCALED_CLIPPED() { return Function.Call<int>(0x483B8C542103AD72); }
		public static int GET_SYSTEM_TIME() { return Function.Call<int>(0xBE7F225417E35A7C); }
		public static int _GET_NUMBER_OF_MICROSECONDS_SINCE_LAST_CALL() { return Function.Call<int>(0xB0CE5E5ED8BB3581); }
		public static int _GET_SCRIPT_TIME_WITHIN_FRAME_IN_MICROSECONDS() { return Function.Call<int>(0x63219768C586667C); }
		public static void _RESET_SCRIPT_TIME_WITHIN_FRAME() { Function.Call(0x1411A7CBC3A6EB7B); }
		public static float GET_FRAME_TIME() { return Function.Call<float>(0x5E72022914CE3C38); }
		public static float _GET_BENCHMARK_TIME() { return Function.Call<float>(0x3F3172FEAE3AFE1C); }
		public static int GET_FRAME_COUNT() { return Function.Call<int>(0x77DFA958FCF100C1); }
		public static unsafe void _0x6BED40493A1AFDB8(Any* p0, float p1) { Function.Call(0x6BED40493A1AFDB8, p0, p1); }
		public static float _READ_INT_AS_FLOAT(int value) { return Function.Call<float>(0xD2C9126410DFA1B2, value); }
		public static float GET_RANDOM_FLOAT_IN_RANGE(float startRange, float endRange) { return Function.Call<float>(0xE29F927A961F8AAA, startRange, endRange); }
		public static int GET_RANDOM_INT_IN_RANGE(int startRange, int endRange) { return Function.Call<int>(0xD53343AA4FB7DD28, startRange, endRange); }
		public static unsafe BOOL GET_GROUND_Z_FOR_3D_COORD(float x, float y, float z, float* groundZ, BOOL p4) { return Function.Call<BOOL>(0x24FA4267BB8D2431, x, y, z, groundZ, p4); }
		public static unsafe BOOL GET_GROUND_Z_AND_NORMAL_FOR_3D_COORD(float x, float y, float z, float* groundZ, Vector3* normal) { return Function.Call<BOOL>(0x2A29CA9A6319E6AB, x, y, z, groundZ, normal); }
		public static Any _0xBBE5B63EFFB08E68(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6) { return Function.Call<Any>(0xBBE5B63EFFB08E68, p0, p1, p2, p3, p4, p5, p6); }
		public static float ASIN(float p0) { return Function.Call<float>(0x6E3C15D296C15583, p0); }
		public static float ACOS(float p0) { return Function.Call<float>(0x586690F0176DC575, p0); }
		public static float TAN(float p0) { return Function.Call<float>(0x8C13DB96497B7ABF, p0); }
		public static float ATAN(float p0) { return Function.Call<float>(0x503054DED0B78027, p0); }
		public static float ATAN2(float p0, float p1) { return Function.Call<float>(0x965B220A066E3F07, p0, p1); }
		public static float GET_DISTANCE_BETWEEN_COORDS(float x1, float y1, float z1, float x2, float y2, float z2, BOOL useZ) { return Function.Call<float>(0x0BE7F4E3CDBAFB28, x1, y1, z1, x2, y2, z2, useZ); }
		public static float GET_ANGLE_BETWEEN_2D_VECTORS(float x1, float y1, float x2, float y2) { return Function.Call<float>(0xD0DFE1C486097BBB, x1, y1, x2, y2); }
		public static float GET_HEADING_FROM_VECTOR_2D(float dx, float dy) { return Function.Call<float>(0x38D5202FF9271C62, dx, dy); }
		public static Vector3 GET_CLOSEST_POINT_ON_LINE(float p0, float p1, float p2, float p3, float p4, float p5, float p6, float p7, float p8, BOOL p9) { return Function.Call<Vector3>(0x83ACC65D9ACEC5EF, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9); }
		public static unsafe BOOL _0xAB6A04CEC428258B(float p0, float p1, float p2, float p3, float p4, float p5, float p6, float p7, float p8, float p9, float p10, float p11, float* p12) { return Function.Call<BOOL>(0xAB6A04CEC428258B, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12); }
		public static unsafe void SET_BIT(int* address, int offset) { Function.Call(0xF73FBE4845C43B5B, address, offset); }
		public static unsafe void CLEAR_BIT(int* address, int offset) { Function.Call(0x7D1D4A3602B6AD4E, address, offset); }
		public static unsafe BOOL _IS_BIT_FLAG_SET(Any* bitFlags, int flag) { return Function.Call<BOOL>(0x8F4F050054005C27, bitFlags, flag); }
		public static unsafe BOOL _IS_ANY_BIT_FLAG_SET(Any* bitFlags) { return Function.Call<BOOL>(0x80E9C316EF84DD81, bitFlags); }
		public static unsafe int _COUNT_BIT_FLAGS(Any* bitFlags) { return Function.Call<int>(0xE704838F36F93B7B, bitFlags); }
		public static unsafe void _SET_BIT_FLAG(Any* bitFlags, int flag) { Function.Call(0xE84AAC1B22A73E99, bitFlags, flag); }
		public static unsafe void _CLEAR_BIT_FLAG(Any* bitFlags, int flag) { Function.Call(0xB909149F2BB5F6DA, bitFlags, flag); }
		public static unsafe void _CLEAR_ALL_BIT_FLAGS(Any* bitFlags) { Function.Call(0xD2D74F89DF844A50, bitFlags); }
		public static Hash GET_HASH_KEY(string _string) { return Function.Call<Hash>(0xFD340785ADF8CFB7, _string); }
		public static float _GET_EASING_CURVE_VALUE(float t, float b, float d, int easingCurveType) { return Function.Call<float>(0xEF50E344A8F93784, t, b, d, easingCurveType); }
		public static BOOL IS_POSITION_OCCUPIED(float x, float y, float z, float range, BOOL p4, BOOL p5, BOOL p6, BOOL p7, BOOL p8, Any p9, BOOL p10) { return Function.Call<BOOL>(0x825CA3ED43831015, x, y, z, range, p4, p5, p6, p7, p8, p9, p10); }
		public static void CLEAR_AREA(float x, float y, float z, float radius, int flag) { Function.Call(0x3B882A96EA77D5B1, x, y, z, radius, flag); }
		public static void _CLEAR_VOLUME_AREA(Volume volume, int flag) { Function.Call(0x2FCD528A397E5C88, volume, flag); }
		public static void CLEAR_ANGLED_AREA_OF_VEHICLES(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7) { Function.Call(0xA4D83115C1E02F8A, p0, p1, p2, p3, p4, p5, p6, p7); }
		public static void SET_CREDITS_ACTIVE(BOOL toggle) { Function.Call(0xD37BECF862DA726F, toggle); }
		public static void NETWORK_SET_SCRIPT_IS_SAFE_FOR_NETWORK_GAME() { Function.Call(0x3D0EAC6385DD6100); }
		public static void PAUSE_DEATH_ARREST_RESTART(BOOL toggle) { Function.Call(0x66AB6B6C7E72F393, toggle); }
		public static void IGNORE_NEXT_RESTART(BOOL toggle) { Function.Call(0x6C9FF40FF1B69F8F, toggle); }
		public static void SET_FADE_IN_AFTER_DEATH_ARREST(BOOL toggle) { Function.Call(0xDF3B5846DE5904AF, toggle); }
		public static void SET_FADE_IN_AFTER_LOAD(BOOL toggle) { Function.Call(0xAC806C4CAB973517, toggle); }
		public static BOOL OVERRIDE_SAVE_HOUSE(BOOL p0, float p1, float p2, float p3, float p4, BOOL p5, float p6, float p7) { return Function.Call<BOOL>(0xB2C69E11A37B5AF0, p0, p1, p2, p3, p4, p5, p6, p7); }
		public static void SHOOT_SINGLE_BULLET_BETWEEN_COORDS(float x1, float y1, float z1, float x2, float y2, float z2, int damage, BOOL p7, Hash weaponHash, int ownerPed, BOOL isAudible, BOOL isInvisible, float speed, BOOL p13) { Function.Call(0x867654CBC7606F2C, x1, y1, z1, x2, y2, z2, damage, p7, weaponHash, ownerPed, isAudible, isInvisible, speed, p13); }
		public static unsafe void FIRE_SINGLE_BULLET(Any* args) { Function.Call(0xCBC9A21F6A2A679C, args); }
		public static unsafe void GET_MODEL_DIMENSIONS(Hash modelHash, Vector3* minimum, Vector3* maximum) { Function.Call(0xDCB8DDD5D054A7E7, modelHash, minimum, maximum); }
		public static BOOL IS_BIT_SET(int address, int offset) { return Function.Call<BOOL>(0x4ED6CFDFE8D4131A, address, offset); }
		public static void _0x0A487CC74A517FB5(Any p0) { Function.Call(0x0A487CC74A517FB5, p0); }
		public static BOOL IS_MINIGAME_IN_PROGRESS() { return Function.Call<BOOL>(0xF4D8BCD052E7EA1B); }
		public static BOOL SHOULD_USE_METRIC_MEASUREMENTS() { return Function.Call<BOOL>(0x4FB556ACEFA93098); }
		public static BOOL _SHOULD_USE_METRIC_MEASUREMENTS_2() { return Function.Call<BOOL>(0x58BCDC75BA52110A); }
		public static BOOL _SHOULD_USE_METRIC_TEMPERATURE() { return Function.Call<BOOL>(0xFF4AAF3275BAAB4F); }
		public static BOOL _SHOULD_USE_METRIC_WEIGHT() { return Function.Call<BOOL>(0x8F24157FEDB85EA2); }
		public static BOOL _SHOULD_USE_24_HOUR_CLOCK() { return Function.Call<BOOL>(0x0177CF20345F44DD); }
		public static int COMPARE_STRINGS(string str1, string str2, BOOL matchCase, int maxLength) { return Function.Call<int>(0xBFBB74A15EFC149B, str1, str2, matchCase, maxLength); }
		public static int ABSI(int value) { return Function.Call<int>(0x0C214D5B8A38C828, value); }
		public static float ABSF(float value) { return Function.Call<float>(0x134549B388167CBF, value); }
		public static BOOL IS_PROJECTILE_IN_AREA(float x1, float y1, float z1, float x2, float y2, float z2, BOOL ownedByPlayer) { return Function.Call<BOOL>(0x05B0061EFDFC8941, x1, y1, z1, x2, y2, z2, ownedByPlayer); }
		public static BOOL IS_PROJECTILE_TYPE_IN_AREA(float x1, float y1, float z1, float x2, float y2, float z2, int type, BOOL p7) { return Function.Call<BOOL>(0x04965FB9E14235C7, x1, y1, z1, x2, y2, z2, type, p7); }
		public static BOOL IS_PROJECTILE_TYPE_IN_ANGLED_AREA(float p0, float p1, float p2, float p3, float p4, float p5, float p6, Any p7, BOOL p8) { return Function.Call<BOOL>(0x928431F4133CD3D4, p0, p1, p2, p3, p4, p5, p6, p7, p8); }
		public static BOOL IS_PROJECTILE_TYPE_WITHIN_DISTANCE(float p0, float p1, float p2, Any p3, float p4, BOOL p5) { return Function.Call<BOOL>(0xF51C9BAAD9ED64C4, p0, p1, p2, p3, p4, p5); }
		public static unsafe BOOL GET_COORDS_OF_PROJECTILE_TYPE_WITHIN_DISTANCE(int ped, Hash weaponHash, float distance, Vector3* _outCoords, BOOL p4, BOOL mustBeOwnedByThisPed) { return Function.Call<BOOL>(0xD73C960A681052DF, ped, weaponHash, distance, _outCoords, p4, mustBeOwnedByThisPed); }
		public static unsafe BOOL GET_PROJECTILE_OF_PROJECTILE_TYPE_WITHIN_DISTANCE(int ped, Hash weaponHash, float distance, Vector3* _outCoords, Object* _outProjectile, BOOL p5, BOOL mustBeOwnedByThisPed) { return Function.Call<BOOL>(0x9578986A6105A6AD, ped, weaponHash, distance, _outCoords, _outProjectile, p5, mustBeOwnedByThisPed); }
		public static BOOL IS_BULLET_IN_ANGLED_AREA(float p0, float p1, float p2, float p3, float p4, float p5, float p6, BOOL p7) { return Function.Call<BOOL>(0x9D09D8493747CF02, p0, p1, p2, p3, p4, p5, p6, p7); }
		public static BOOL IS_BULLET_IN_AREA(float p0, float p1, float p2, float p3, BOOL p4) { return Function.Call<BOOL>(0xC652FD308772D79E, p0, p1, p2, p3, p4); }
		public static BOOL IS_BULLET_IN_BOX(float p0, float p1, float p2, float p3, float p4, float p5, BOOL p6) { return Function.Call<BOOL>(0xC128137C52152741, p0, p1, p2, p3, p4, p5, p6); }
		public static BOOL HAS_BULLET_IMPACTED_IN_AREA(float x, float y, float z, float p3, BOOL p4, BOOL p5) { return Function.Call<BOOL>(0xC153E5BCCF411814, x, y, z, p3, p4, p5); }
		public static BOOL HAS_BULLET_IMPACTED_IN_BOX(float p0, float p1, float p2, float p3, float p4, float p5, BOOL p6, BOOL p7) { return Function.Call<BOOL>(0x3B6A4C05FB2B33AC, p0, p1, p2, p3, p4, p5, p6, p7); }
		public static Any _0x7A76104CC2CC69E8(int entity, int p1, int p2) { return Function.Call<Any>(0x7A76104CC2CC69E8, entity, p1, p2); }
		public static Any _0xDC416CA762BC4F43(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5) { return Function.Call<Any>(0xDC416CA762BC4F43, p0, p1, p2, p3, p4, p5); }
		public static Any _0x970339EFA4FDE518(Any p0, Any p1, Any p2) { return Function.Call<Any>(0x970339EFA4FDE518, p0, p1, p2); }
		public static BOOL IS_ORBIS_VERSION() { return Function.Call<BOOL>(0x88CFAE250D3E0C71); }
		public static BOOL IS_DURANGO_VERSION() { return Function.Call<BOOL>(0xD1CCC2A2639D325F); }
		public static BOOL IS_PC_VERSION() { return Function.Call<BOOL>(0xB0FB6CFAA5A1C833); }
		public static BOOL IS_STADIA_VERSION() { return Function.Call<BOOL>(0x268AB8420A9E4ED7); }
		public static BOOL IS_STRING_NULL(string _string) { return Function.Call<BOOL>(0x602102324604D96B, _string); }
		public static BOOL IS_STRING_NULL_OR_EMPTY(string _string) { return Function.Call<BOOL>(0x2CF12F9ACF18F048, _string); }
		public static BOOL IS_STRING_NULL_OR_EMPTY_OR_SPACES(string _string) { return Function.Call<BOOL>(0x375F5870A7B8BEC1, _string); }
		public static BOOL ARE_STRINGS_EQUAL(string _string1, string _string2) { return Function.Call<BOOL>(0xD3852F22AB713A1F, _string1, _string2); }
		public static BOOL _DOES_STRING_EXIST_IN_STRING(string _string1, string _string2) { return Function.Call<BOOL>(0x9382D5D43D2AA6FF, _string1, _string2); }
		public static void _0x3C3C7B1B5EC08764() { Function.Call(0x3C3C7B1B5EC08764); }
		public static Any _0x94E8CA3DEE952789(Any p0, Any p1) { return Function.Call<Any>(0x94E8CA3DEE952789, p0, p1); }
		public static Any _0x5B4A8121A47D844D(Any p0) { return Function.Call<Any>(0x5B4A8121A47D844D, p0); }
		public static unsafe BOOL STRING_TO_INT(string _string, int* _outInteger) { return Function.Call<BOOL>(0xF2DD2298B3AF23E2, _string, _outInteger); }
		public static void _INT_TO_STRING(int value, string format, string buffer) { Function.Call(0xCF11C0CEB40C401B, value, format, buffer); }
		public static void _0x74ACA66484CEBAF0(Any p0) { Function.Call(0x74ACA66484CEBAF0, p0); }
		public static void _0x49C44FE78A135A1D(Any p0) { Function.Call(0x49C44FE78A135A1D, p0); }
		public static void _0xF650DCF5D6F312C1(Any p0) { Function.Call(0xF650DCF5D6F312C1, p0); }
		public static string _GET_STRING_FROM_FLOAT(float value, int digits) { return Function.Call<string>(0x2B6846401D68E563, value, digits); }
		public static string _GET_STRING_FROM_VECTOR(float x, float y, float z) { return Function.Call<string>(0x6C4DBF553885F9EB, x, y, z); }
		public static string _GET_STRING_FROM_BOOL(BOOL value) { return Function.Call<string>(0xF216F74101968DB0, value); }
		public static string VAR_STRING(int flags, params InputArgument[] args) { return Function._Call<string>(0xFA925AC00EB830B9, flags, args); }
		public static string _CREATE_COLOR_STRING(int rgb) { return Function.Call<string>(0xBCC2CFADEA1AEA6C, rgb); }
		public static unsafe void SET_BITS_IN_RANGE(int* var, int rangeStart, int rangeEnd, int p3) { Function.Call(0x324DC1CEF57F31E6, var, rangeStart, rangeEnd, p3); }
		public static int GET_BITS_IN_RANGE(int var, int rangeStart, int rangeEnd) { return Function.Call<int>(0x68E1352AF48F905D, var, rangeStart, rangeEnd); }
		public static void SET_GAME_PAUSED(BOOL toggle) { Function.Call(0xFAEC088D28B1DE4A, toggle); }
		public static void SET_THIS_SCRIPT_CAN_BE_PAUSED(BOOL toggle) { Function.Call(0x3215376E79F6EA18, toggle); }
		public static void SET_THIS_SCRIPT_CAN_REMOVE_BLIPS_CREATED_BY_ANY_SCRIPT(BOOL toggle) { Function.Call(0x8ABD939C2E5D00ED, toggle); }
		public static void SET_CHEAT_ACTIVE(int cheatId) { Function.Call(0xD4958E8CF0DE0DD0, cheatId); }
		public static void _0xB711EB4BC8D06013() { Function.Call(0xB711EB4BC8D06013); }
		public static void POPULATE_NOW() { Function.Call(0xEA6DC3A8ADD2005F); }
		public static BOOL IS_GAME_SESSION_STATE_MACHINE_IDLE() { return Function.Call<BOOL>(0xF9E7DBB39080640B); }
		public static BOOL _QUEUE_SAVEGAME_OPERATION(int p0) { return Function.Call<BOOL>(0x279B0696DA4657EB, p0); }
		public static int _GET_STATUS_OF_SAVEGAME_OPERATION(int p0) { return Function.Call<int>(0x1B065A2BF7953815, p0); }
		public static Any _0x6C7B68D3CE60E8DE(Any p0) { return Function.Call<Any>(0x6C7B68D3CE60E8DE, p0); }
		public static Any _0x627B68D9CE6EE8DE(Any p0) { return Function.Call<Any>(0x627B68D9CE6EE8DE, p0); }
		public static Any _0x7CF96F1250EF3221(Any p0) { return Function.Call<Any>(0x7CF96F1250EF3221, p0); }
		public static unsafe void _COPY_MEMORY(Any* dst, Any* src, int size) { Function.Call(0xF7AC7DC0DEE7C9BE, dst, src, size); }
		public static void ENABLE_DISPATCH_SERVICE(int dispatchService, BOOL toggle) { Function.Call(0x50E52637EF70EF77, dispatchService, toggle); }
		public static void BLOCK_DISPATCH_SERVICE_RESOURCE_CREATION(int dispatchService, BOOL toggle) { Function.Call(0x66947E61A44DE2C6, dispatchService, toggle); }
		public static unsafe BOOL CREATE_INCIDENT(int dispatchService, float x, float y, float z, int numUnits, float radius, int* _outIncidentID, Any p7, Any p8) { return Function.Call<BOOL>(0x3F892CAF67444AE7, dispatchService, x, y, z, numUnits, radius, _outIncidentID, p7, p8); }
		public static unsafe BOOL _CREATE_INCIDENT_WITH_ENTITIES(int dispatchService, float x, float y, float z, ItemSet itemSet, float radius, int* _outIncidentID) { return Function.Call<BOOL>(0xAB3D3F45436DB1D8, dispatchService, x, y, z, itemSet, radius, _outIncidentID); }
		public static void DELETE_INCIDENT(int incidentId) { Function.Call(0x5CFD0F0D6AAE0AEE, incidentId); }
		public static BOOL IS_INCIDENT_VALID(int incidentId) { return Function.Call<BOOL>(0x39F2B1BAD412246A, incidentId); }
		public static void _SET_INCIDENT_UNK(int incidentId) { Function.Call(0x9617B6E5F6537B63, incidentId); }
		public static int ADD_POP_MULTIPLIER_AREA(float x1, float y1, float z1, float x2, float y2, float z2, float pedDensity, float trafficDensity, BOOL p8, BOOL p9) { return Function.Call<int>(0x5EBDA1A3B8CB5EF7, x1, y1, z1, x2, y2, z2, pedDensity, trafficDensity, p8, p9); }
		public static BOOL DOES_POP_MULTIPLIER_AREA_EXIST(int id) { return Function.Call<BOOL>(0x03BA619C81A646B3, id); }
		public static void REMOVE_POP_MULTIPLIER_AREA(int id, BOOL p1) { Function.Call(0x88CB484364EFB37A, id, p1); }
		public static Any _0x3233C4EC0514C7EC(Volume volume, float pedDensity, float vehicleDensity, int p3, int p4) { return Function.Call<Any>(0x3233C4EC0514C7EC, volume, pedDensity, vehicleDensity, p3, p4); }
		public static BOOL _DOES_POP_MULTIPLIER_AREA_EXIST_FOR_VOLUME(Volume volume) { return Function.Call<BOOL>(0x39D6DACE323A20B6, volume); }
		public static void _REMOVE_POP_MULTIPLIER_AREA_FOR_VOLUME(Volume volume, int p1) { Function.Call(0xBD090F5B1DB82189, volume, p1); }
		public static void _0xF569E33FB72ED28E() { Function.Call(0xF569E33FB72ED28E); }
		public static void RESET_DISPATCH_IDEAL_SPAWN_DISTANCE() { Function.Call(0xC7817264BC4B6377); }
		public static void SET_DISPATCH_IDEAL_SPAWN_DISTANCE(float fIdealSpawnDistance) { Function.Call(0xEAB6823B82FBD283, fIdealSpawnDistance); }
		public static void _RESET_DISPATCH_MIN_SPAWN_DISTANCE() { Function.Call(0x96498D922D8D0D0A); }
		public static void _SET_DISPATCH_MIN_SPAWN_DISTANCE(float minSpawnDistance) { Function.Call(0x27A1B170AA8AF84C, minSpawnDistance); }
		public static void _RESET_DISPATCH_MAX_SPAWN_DISTANCE() { Function.Call(0x54EC7B6BC72BAD69); }
		public static void _SET_DISPATCH_MAX_SPAWN_DISTANCE(float maxSpawnDistance) { Function.Call(0x89314FB3463E28DE, maxSpawnDistance); }
		public static void _0x4B0501A468B749F8() { Function.Call(0x4B0501A468B749F8); }
		public static void _0x6BCF7B5CD338281A(Any p0, Any p1, Any p2) { Function.Call(0x6BCF7B5CD338281A, p0, p1, p2); }
		public static Any _ADD_DISPATCH_SPAWN_BLOCKING_AREA(Volume volume) { return Function.Call<Any>(0xA2D5A26208421426, volume); }
		public static void REMOVE_DISPATCH_SPAWN_BLOCKING_AREA(Any p0) { Function.Call(0x49F751F6868DDC5B, p0); }
		public static void _0xEF42F56F69877125() { Function.Call(0xEF42F56F69877125); }
		public static void ADD_TACTICAL_NAV_MESH_POINT(float x, float y, float z, int p3) { Function.Call(0xE4EE55E63FA9AF45, x, y, z, p3); }
		public static void CLEAR_TACTICAL_NAV_MESH_POINTS() { Function.Call(0xD93B6516C6878267); }
		public static void DISPLAY_ONSCREEN_KEYBOARD(int textType, string windowTitle, string p2, string defaultText, string defaultConcat1, string defaultConcat2, string defaultConcat3, int maxInputLength) { Function.Call(0x044131118D8DB3CD, textType, windowTitle, p2, defaultText, defaultConcat1, defaultConcat2, defaultConcat3, maxInputLength); }
		public static int UPDATE_ONSCREEN_KEYBOARD() { return Function.Call<int>(0x37DF360F235A3893); }
		public static string GET_ONSCREEN_KEYBOARD_RESULT() { return Function.Call<string>(0xAFB4CF58A4A292B1); }
		public static void _CANCEL_ONSCREEN_KEYBOARD() { Function.Call(0x58A39BE597CE99CD); }
		public static void NEXT_ONSCREEN_KEYBOARD_RESULT_WILL_DISPLAY_USING_THESE_FONTS(int p0) { Function.Call(0x5CB71EAA1429A358, p0); }
		public static void ACTION_MANAGER_ENABLE_ACTION(Hash hash, BOOL enable) { Function.Call(0x7ACF124C12A2B045, hash, enable); }
		public static Any _0xFD0759658268FD8E(Any p0) { return Function.Call<Any>(0xFD0759658268FD8E, p0); }
		public static int _GET_REAL_GAME_TIMER_IN_SECONDS() { return Function.Call<int>(0x2E036F0480B8BF02); }
		public static void SET_SUPER_JUMP_THIS_FRAME(int player) { Function.Call(0xB3E9BE963F10C445, player); }
		public static void SCRIPT_RACE_INIT(int numCheckpoints, int numLaps, int numPlayers, Any p3) { Function.Call(0x8AE059F47158417E, numCheckpoints, numLaps, numPlayers, p3); }
		public static void SCRIPT_RACE_SHUTDOWN() { Function.Call(0x334CE0DA4FAF330C); }
		public static void _0xBA62B4D80FA66BD6(Any iPart, Any iCheckpoint, Any iLap, Any iTime) { Function.Call(0xBA62B4D80FA66BD6, iPart, iCheckpoint, iLap, iTime); }
		public static unsafe BOOL SCRIPT_RACE_GET_PLAYER_SPLIT_TIME(Any p0, Any* p1, Any* p2) { return Function.Call<BOOL>(0x769E848C66E3C2BB, p0, p1, p2); }
		public static void _START_BENCHMARK_RECORDING() { Function.Call(0x29D1F6DF864A094E); }
		public static void _STOP_BENCHMARK_RECORDING() { Function.Call(0xB89AEC71AFF2B599); }
		public static void _RESET_BENCHMARK_RECORDING() { Function.Call(0xECBABD0307FB216F); }
		public static void _SAVE_BENCHMARK_RECORDING() { Function.Call(0xF4743E2ECC02B3DA); }
		public static BOOL _UI_IS_SINGLEPLAYER_PAUSE_MENU_ACTIVE() { return Function.Call<BOOL>(0x4FFA0386A6216113); }
		public static int _GET_BENCHMARK_ITERATIONS_FROM_COMMAND_LINE() { return Function.Call<int>(0x22FC52CF470CC98D); }
		public static int _GET_BENCHMARK_PASS_FROM_COMMAND_LINE() { return Function.Call<int>(0x9297DACF3A2CDFF7); }
		public static Any _0xDC057B86FC157031() { return Function.Call<Any>(0xDC057B86FC157031); }
		public static void _0x9A252AA23D7098F2() { Function.Call(0x9A252AA23D7098F2); }
		public static BOOL _DOES_ITEM_HAVE_VALID_BASE(ScrHandle item) { return Function.Call<BOOL>(0xBDC6E364C9C78178, item); }
		public static int _GET_ITEM_TYPE(ScrHandle handle) { return Function.Call<int>(0xDC8D2FF478DF9553, handle); }
		public static BOOL _IS_BASE_A_PERSISTENT_CHARACTER(ScrHandle handle) { return Function.Call<BOOL>(0x716F17F8A0419F95, handle); }
		public static BOOL _IS_BASE_A_COVER_POINT(ScrHandle handle) { return Function.Call<BOOL>(0xFEC1D4B5C82C176F, handle); }
		public static void _0x553D67295DDD2309(int entity) { Function.Call(0x553D67295DDD2309, entity); }
		public static Any _0xF18AF483DF70BBDE(Any p0) { return Function.Call<Any>(0xF18AF483DF70BBDE, p0); }
		public static int _GET_ENTITY_FROM_ITEM(ScrHandle item) { return Function.Call<int>(0xEE04C0AFD4EFAF0E, item); }
		public static int _GET_PED_FROM_INDEXED_ITEM(ScrHandle item) { return Function.Call<int>(0x3FFB15534067DCD4, item); }
		public static int _GET_VEHICLE_FROM_INDEXED_ITEM(ScrHandle item) { return Function.Call<int>(0xE578C8AE173719B3, item); }
		public static Object _GET_OBJECT_FROM_INDEXED_ITEM(ScrHandle item) { return Function.Call<Object>(0x18013392501CE5DC, item); }
		public static Any _0x33982467B1E349EF(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6) { return Function.Call<Any>(0x33982467B1E349EF, p0, p1, p2, p3, p4, p5, p6); }
		public static Any _0x8314FC2013ECE2DA(Any p0, Any p1, Any p2) { return Function.Call<Any>(0x8314FC2013ECE2DA, p0, p1, p2); }
		public static void _0x4D5C9CC7E7E23E09() { Function.Call(0x4D5C9CC7E7E23E09); }
		public static BOOL REGISTER_INTERACTION_LOCKON_PROMPT(int entity, string text, float radius, float p3, int flag, float p5, float p6, Prompt prompt, BOOL p8, int p9) { return Function.Call<BOOL>(0x870708A6E147A9AD, entity, text, radius, p3, flag, p5, p6, prompt, p8, p9); }
		public static BOOL UNREGISTER_INTERACTION_LOCKON_PROMPT(int entity) { return Function.Call<BOOL>(0xE98D55C5983F2509, entity); }
		public static void _0xFC6ECB9170145ECE() { Function.Call(0xFC6ECB9170145ECE); }
		public static Any _0x35165C658077CD0B() { return Function.Call<Any>(0x35165C658077CD0B); }
		public static BOOL _0x4B101DBCC9482F2D(int ped) { return Function.Call<BOOL>(0x4B101DBCC9482F2D, ped); }
		public static BOOL _IS_MISSION_CREATOR_ACTIVE() { return Function.Call<BOOL>(0xF236C84C6ADFCB2F); }
		public static void _0xA3A8926951471C82() { Function.Call(0xA3A8926951471C82); }
		public static unsafe void _CREATE_AI_MEMORY(Any* args, int aiMemoryType) { Function.Call(0x88BC5F4AEF77FC4E, args, aiMemoryType); }
		public static unsafe BOOL _GET_AI_PED_DOES_HAVE_EVENT_MEMORY(Any* args, int p1) { return Function.Call<BOOL>(0xFDF38E2B711BF78E, args, p1); }
		public static void _0xEB946B9E579729AD(int ped, Any p1) { Function.Call(0xEB946B9E579729AD, ped, p1); }
		public static void _0x6AC4AF46A6B8DFB2(Any p0) { Function.Call(0x6AC4AF46A6B8DFB2, p0); }
		public static Any _0x8DB104CCEBCD58C5(Any p0, Any p1) { return Function.Call<Any>(0x8DB104CCEBCD58C5, p0, p1); }
		public static void _0x68319452C5064ABA(Any p0, Any p1) { Function.Call(0x68319452C5064ABA, p0, p1); }
		public static void _0xDE2C3B74D2B3705C(Any p0, Any p1) { Function.Call(0xDE2C3B74D2B3705C, p0, p1); }
		public static void _0x49F3241C28EBBFBC(Any p0) { Function.Call(0x49F3241C28EBBFBC, p0); }
		public static void _0x183672FE838A661B(Any p0) { Function.Call(0x183672FE838A661B, p0); }
		public static void _0x38C0C9CAE1544500(Any p0) { Function.Call(0x38C0C9CAE1544500, p0); }
		public static void _0x154340E87D8CC178(Any p0) { Function.Call(0x154340E87D8CC178, p0); }
		public static void _0x94FCADCF9F0C368E(Any p0) { Function.Call(0x94FCADCF9F0C368E, p0); }
		public static Any _0x0D0AE5081F88CFE1(Any p0) { return Function.Call<Any>(0x0D0AE5081F88CFE1, p0); }
		public static void _0xAF3A84C7DE6A1DC5(Any p0, Any p1) { Function.Call(0xAF3A84C7DE6A1DC5, p0, p1); }
		public static unsafe void _0x48E4D50F87A96AA5(int ped, BOOL p1, BOOL p2, Hash p3, Any* p4, Any p5) { Function.Call(0x48E4D50F87A96AA5, ped, p1, p2, p3, p4, p5); }
		public static Any _0xB1F6665AA54DCD5C(Any p0) { return Function.Call<Any>(0xB1F6665AA54DCD5C, p0); }
		public static Any _0x8BB99B85444544D9(Any p0, Any p1) { return Function.Call<Any>(0x8BB99B85444544D9, p0, p1); }
		public static Any _0x6F02B5E50511721E(Any p0) { return Function.Call<Any>(0x6F02B5E50511721E, p0); }
		public static Any _0xCC1BAF72D571DB8D(Any p0, Any p1, Any p2) { return Function.Call<Any>(0xCC1BAF72D571DB8D, p0, p1, p2); }
		public static BOOL _IS_PED_DECOMPOSED(int ped) { return Function.Call<BOOL>(0x5170DDA6D63ACAAA, ped); }
		public static void SET_PED_DECOMPOSED(int ped, BOOL toggle) { Function.Call(0x674B90BE1115846D, ped, toggle); }
		public static void _0xAB26DEEE120FD3FD(Any p0, Any p1) { Function.Call(0xAB26DEEE120FD3FD, p0, p1); }
		public static void _0x082C043C7AFC3747(int compositeId, BOOL p1) { Function.Call(0x082C043C7AFC3747, compositeId, p1); }
		public static void DISABLE_LOOTING_COMPOSITE_LOOTABLE_THIS_FRAME(int compositeId, BOOL p1) { Function.Call(0x40D72189F46D2E15, compositeId, p1); }
		public static void _0xBB282CF5D2333FB8(Any p0, Any p1) { Function.Call(0xBB282CF5D2333FB8, p0, p1); }
		public static void _0xAD44856A1CD29635(Any p0, Any p1, Any p2) { Function.Call(0xAD44856A1CD29635, p0, p1, p2); }
		public static Any _0x38C2BF94D15F464D(Any p0) { return Function.Call<Any>(0x38C2BF94D15F464D, p0); }
		public static void _0x3A87FDA8F1B6CDFB(Any p0, Any p1, Any p2) { Function.Call(0x3A87FDA8F1B6CDFB, p0, p1, p2); }
		public static void _0x4647842FE8F31C1E(Any p0, Any p1) { Function.Call(0x4647842FE8F31C1E, p0, p1); }
		public static BOOL _GET_LOOTING_EVENT_HAS_FIRED(int ped, string _eventName) { return Function.Call<BOOL>(0xF9B91C5129EABC08, ped, _eventName); }
		public static void _0x9B47971234169990(int ped, Any item) { Function.Call(0x9B47971234169990, ped, item); }
		public static void _0x96282005C5C6801F(Any p0, Any p1) { Function.Call(0x96282005C5C6801F, p0, p1); }
		public static void _0xF63FA29D4A9ACA86(Any p0, Any p1) { Function.Call(0xF63FA29D4A9ACA86, p0, p1); }
		public static void _0x8C0F6A3D7236DEEB(Any p0, Any p1) { Function.Call(0x8C0F6A3D7236DEEB, p0, p1); }
		public static void _0x7FA58CED69405F9A(Any p0, Any p1) { Function.Call(0x7FA58CED69405F9A, p0, p1); }
		public static void _0xA08111B053D84B4D(Any p0) { Function.Call(0xA08111B053D84B4D, p0); }
		public static BOOL _IS_GLOBAL_BLOCK_VALID(int index) { return Function.Call<BOOL>(0xACB7E1418A8B6E32, index); }
		public static void _SET_GLOBAL_BLOCK_IS_LOADED(int index, BOOL toggle) { Function.Call(0xE97240065406CB80, index, toggle); }
		public static BOOL GAME_FRAMEWORK_MANAGER_INIT(Hash transitionMode) { return Function.Call<BOOL>(0x4CABE596D632E4B0, transitionMode); }
		public static void _GAME_FRAMEWORK_MANAGER_SHUTDOWN() { Function.Call(0xAFF2FD8ADD927585); }
		public static Hash _GAME_FRAMEWORK_MANAGER_GET_MODE() { return Function.Call<Hash>(0xFAED234C7F53ABEB); }
		public static BOOL _0x36040772DF5E59A0() { return Function.Call<BOOL>(0x36040772DF5E59A0); }
		public static Any _0x0358B8A41916C613(Any p0, Any p1, Any p2, Any p3) { return Function.Call<Any>(0x0358B8A41916C613, p0, p1, p2, p3); }
		public static void _SET_GAME_LOGIC_PAUSED() { Function.Call(0x550F05CFFBD63C8C); }
		public static void STOP_CURRENT_LOADING_PROGRESS_TIMER() { Function.Call(0xA565FAC215CBC77D); }
		public static void _0xDBDA48EC456ED908() { Function.Call(0xDBDA48EC456ED908); }
	}

	public static class MISSIONDATA
	{
		public static BOOL MISSIONDATA_IS_VALID(Any p0) { return Function.Call<BOOL>(0xE54DC27571D5EDC5, p0); }
		public static Hash MISSIONDATA_GET_CATAGORY(Hash missionId) { return Function.Call<Hash>(0x57E798B65C45EE17, missionId); }
		public static Hash MISSIONDATA_GET_TEXTURE_NAME(Hash missionId) { return Function.Call<Hash>(0x57E798B56C45EE15, missionId); }
		public static Hash MISSIONDATA_GET_TEXTURE_TXD(Hash missionId) { return Function.Call<Hash>(0x57E798B57C45EE16, missionId); }
		public static BOOL MISSIONDATA_WAS_COMPLETED(Hash missionId) { return Function.Call<BOOL>(0xE54DC27571D5EDC4, missionId); }
		public static int MISSIONDATA_GET_RATING(Hash missionId) { return Function.Call<int>(0x57E798B54C45EE1A, missionId); }
		public static void _MISSIONDATA_SET_MISSION_RATING(Hash missionId, int rating) { Function.Call(0xE824CE7D13FCB300, missionId, rating); }
		public static BOOL MISSIONDATA_IS_REQUIRED_STORY_MISSION(Hash missionId) { return Function.Call<BOOL>(0xE824CE7D13FCB35E, missionId); }
		public static void _MISSIONDATA_SET_REPLAY_STATE_LOCKED(Hash missionId, int replayState) { Function.Call(0xE4E2C581F127A11C, missionId, replayState); }
		public static int MISSIONDATA_GET_REPLAY_STATE(Any p0) { return Function.Call<int>(0x8C32D86E9556ED86, p0); }
		public static void MISSIONDATA_SET_RATING_SCORES(Hash missionId, int bronzeScore, int silverScore, int goldScore) { Function.Call(0x12F65317708749A5, missionId, bronzeScore, silverScore, goldScore); }
		public static void MISSIONDATA_SET_HIGH_SCORE(Hash missionId, int score) { Function.Call(0x3A04F0169DA87A9D, missionId, score); }
		public static int MISSIONDATA_GET_HIGH_SCORE(Hash missionId) { return Function.Call<int>(0x9AABABF8313C3516, missionId); }
		public static BOOL _MISSIONDATA_IS_REPLAY_CATEGORY_LOCKED(Hash category) { return Function.Call<BOOL>(0xE145864DECC34219, category); }
		public static void MISSIONDATA_SET_REPLAY_LOCKED_FOR_CATEGORY(Hash category, BOOL locked) { Function.Call(0x957A830C9B4B99EA, category, locked); }
		public static void _MISSIONDATA_TIMECYCLE_BOX_SET_MODIFIER(string timecycleName) { Function.Call(0x25855B1574BF8CD5, timecycleName); }
		public static void _MISSIONDATA_TIMECYCLE_BOX_DELETE() { Function.Call(0x7F89E15A8FB8DE97); }
		public static BOOL _MISSIONDATA_TIMECYCLE_BOX_EXISTS() { return Function.Call<BOOL>(0x7E8F86A4FA33033C); }
	}

	public static class MONEY
	{
		public static int _MONEY_GET_CASH_BALANCE() { return Function.Call<int>(0x0C02DABFA3B98176); }
		public static BOOL _MONEY_DECREMENT_CASH_BALANCE(int amount) { return Function.Call<BOOL>(0x466BC8769CF26A7A, amount); }
		public static BOOL _MONEY_INCREMENT_CASH_BALANCE(int amount, Hash p1) { return Function.Call<BOOL>(0xBC3422DC91667621, amount, p1); }
		public static string _NETWORK_GET_STRING_CASH_BALANCE() { return Function.Call<string>(0x282D36FF103D78DF); }
		public static BOOL _NETWORK_IS_MONEY_BALANCE_NOT_LESS_THAN(int cashBalance, int goldBarBalance) { return Function.Call<BOOL>(0xAEC5F0119867E457, cashBalance, goldBarBalance); }
		public static string _0xA46FD001D1BE896C() { return Function.Call<string>(0xA46FD001D1BE896C); }
		public static BOOL _0x07AD9E43FD478527(Any p0, Any p1) { return Function.Call<BOOL>(0x07AD9E43FD478527, p0, p1); }
		public static int _NETWORK_GET_CASH_BALANCE() { return Function.Call<int>(0x8A67120DBC299525); }
	}

	public static class NETSHOPPING
	{
		public static unsafe BOOL CASHINVENTORY_INIT_SESSION_STATUS(int* p0, int* p1) { return Function.Call<BOOL>(0xC019112F8995DC1C, p0, p1); }
		public static BOOL _CASHINVENTORY_IS_SESSION_READY() { return Function.Call<BOOL>(0xFCC24220FDDAC929); }
		public static BOOL CASHINVENTORY_IS_CONNECTION_FAULTED() { return Function.Call<BOOL>(0x6CE9FB6332B5E46E); }
		public static BOOL _CASHINVENTORY_INIT_SESSION_IS_FAULTED() { return Function.Call<BOOL>(0xD1CE92D1D9BE170A); }
		public static unsafe BOOL _CASHINVENTORY_TRANSACTION_FIRE_AND_FORGET_ITEM(Hash actionHash, int* id, Any* item, int p3) { return Function.Call<BOOL>(0xFFEA09CCEC4AF32F, actionHash, id, item, p3); }
		public static unsafe BOOL _CASHINVENTORY_TRANSACTION_START(int* id, Hash type, Hash actionHash) { return Function.Call<BOOL>(0xF039EC27F4490E96, id, type, actionHash); }
		public static BOOL _CASHINVENTORY_TRANSACTION_GET_BASKET_IS_VALID(int id) { return Function.Call<BOOL>(0x52A226ADF4A270D2, id); }
		public static BOOL _CASHINVENTORY_TRANSACTION_DELETE(int id) { return Function.Call<BOOL>(0x59EF5D516E2D96B9, id); }
		public static unsafe int _CASHINVENTORY_TRANSACTION_VALIDATE_ITEM(Hash p0, Any* p1) { return Function.Call<int>(0x6C9F12700BCE69F4, p0, p1); }
		public static int _0x38640A8C2DEF011B(int p0) { return Function.Call<int>(0x38640A8C2DEF011B, p0); }
		public static unsafe BOOL _0xA3B8D31C13CB4239(int p0, Hash p1, Any* p2, int p3, Any* p4, int p5) { return Function.Call<BOOL>(0xA3B8D31C13CB4239, p0, p1, p2, p3, p4, p5); }
		public static unsafe BOOL _CASHINVENTORY_TRANSACTION_ADD_AWARD(int id, Hash hash, Any* p2, Any* p3) { return Function.Call<BOOL>(0x52BDE32F21BA3B6D, id, hash, p2, p3); }
		public static unsafe BOOL _CASHINVENTORY_TRANSACTION_GET_ITEM_INFO(int id, int index, Any* itemInfo) { return Function.Call<BOOL>(0x7616B5F0895C2D99, id, index, itemInfo); }
		public static int _CASHINVENTORY_TRANSACTION_GET_NUM_OF_ITEMS(int id) { return Function.Call<int>(0xCF2D04D076847478, id); }
		public static Hash _CASHINVENTORY_TRANSACTION_GET_ACTION(int id) { return Function.Call<Hash>(0xBD2D520C51CCFF52, id); }
		public static BOOL _CASHINVENTORY_TRANSACTION_CHECKOUT(int id) { return Function.Call<BOOL>(0x592BC00BF6629BE7, id); }
		public static unsafe BOOL _CASHINVENTORY_TRANSACTION_CHECKOUT_STATUS(int id, int* status) { return Function.Call<BOOL>(0x26C008791D066F37, id, status); }
		public static int _0xB6F4557060EF0FB4(int p0, int p1) { return Function.Call<int>(0xB6F4557060EF0FB4, p0, p1); }
		public static unsafe BOOL _CASHINVENTORY_TRANSACTION_RESPONSE_GET_ITEM_INFO(int id, int index, Any* itemInfo) { return Function.Call<BOOL>(0x98412398BBE73F61, id, index, itemInfo); }
		public static BOOL _0xCE54C9ABE6FBC6DB(Hash p0) { return Function.Call<BOOL>(0xCE54C9ABE6FBC6DB, p0); }
		public static BOOL _0xA0B7094629724974(Hash p0, Any p1) { return Function.Call<BOOL>(0xA0B7094629724974, p0, p1); }
		public static unsafe BOOL _0x92A32BA29622763F(int id, int index, Any* p2) { return Function.Call<BOOL>(0x92A32BA29622763F, id, index, p2); }
		public static BOOL _0x3FA09DD57B93C0DE(Hash p0, int p1, int p2, Any p3, int p4) { return Function.Call<BOOL>(0x3FA09DD57B93C0DE, p0, p1, p2, p3, p4); }
		public static BOOL _0xD1555FBC96C88444(Hash p0, int p1, int p2, Any p3, int p4) { return Function.Call<BOOL>(0xD1555FBC96C88444, p0, p1, p2, p3, p4); }
	}

	public static class NETWORK
	{
		public static BOOL NETWORK_IS_SIGNED_ONLINE() { return Function.Call<BOOL>(0x1077788E268557C2); }
		public static int _0x74FB3E29E6D10FA9() { return Function.Call<int>(0x74FB3E29E6D10FA9); }
		public static BOOL NETWORK_HAS_VALID_ROS_CREDENTIALS() { return Function.Call<BOOL>(0x85443FF4C328F53B); }
		public static BOOL NETWORK_IS_CLOUD_AVAILABLE() { return Function.Call<BOOL>(0x9A4CF4F48AD77302); }
		public static BOOL NETWORK_HAS_SOCIAL_CLUB_ACCOUNT() { return Function.Call<BOOL>(0x67A5589628E0CFF6); }
		public static BOOL NETWORK_IS_HOST() { return Function.Call<BOOL>(0x8DB296B814EDDA07); }
		public static BOOL NETWORK_HAVE_ONLINE_PRIVILEGES() { return Function.Call<BOOL>(0x25CB5A9F37BFD063); }
		public static BOOL NETWORK_CHECK_USER_CONTENT_PRIVILEGES(int p0) { return Function.Call<BOOL>(0x595F028698072DD9, p0); }
		public static BOOL NETWORK_CHECK_COMMUNICATION_PRIVILEGES(int p0) { return Function.Call<BOOL>(0x83F28CE49FBBFFBA, p0); }
		public static unsafe BOOL NETWORK_CAN_VIEW_GAMER_USER_CONTENT(Any* gamerHandle) { return Function.Call<BOOL>(0x246545C37C27A717, gamerHandle); }
		public static unsafe BOOL _0xF23A6D6C11D8EC15(Any* gamerHandle) { return Function.Call<BOOL>(0xF23A6D6C11D8EC15, gamerHandle); }
		public static int _0x3E8CCE6769DB5F34(int p0) { return Function.Call<int>(0x3E8CCE6769DB5F34, p0); }
		public static void _0x83FE8D7229593017() { Function.Call(0x83FE8D7229593017); }
		public static BOOL NETWORK_IS_PROMOTION_ENABLED() { return Function.Call<BOOL>(0x8FF6059DA26E688A); }
		public static BOOL NETWORK_IS_CUSTOM_UPSELL_ENABLED() { return Function.Call<BOOL>(0x78A9535AF83715C6); }
		public static BOOL NETWORK_SHOULD_SHOW_PROMOTION_DLG() { return Function.Call<BOOL>(0xDA4B1A479C414FB2); }
		public static void _0xFC6FCF4C03F1BBF6() { Function.Call(0xFC6FCF4C03F1BBF6); }
		public static Any _0x160F0CE6D76A39C9() { return Function.Call<Any>(0x160F0CE6D76A39C9); }
		public static int NETWORK_GET_PROMOTION_DLG_SEEN_COUNT() { return Function.Call<int>(0x2FB53C631A49BE92); }
		public static void _0xE5FF65CFF5160752() { Function.Call(0xE5FF65CFF5160752); }
		public static unsafe BOOL NETWORK_CAN_ACCESS_MULTIPLAYER(int* loadingState) { return Function.Call<BOOL>(0xAF50DA1A3F8B1BA4, loadingState); }
		public static BOOL NETWORK_CHECK_ACCESS_AND_ALERT_IF_FAIL() { return Function.Call<BOOL>(0x2A8112A974DE1EF6); }
		public static int _NETWORK_GET_GLOBAL_ENTITY_FLAGS(int entity) { return Function.Call<int>(0xDD7806FD0543BC3D, entity); }
		public static void _0xA95470DA137587F5(BOOL p0) { Function.Call(0xA95470DA137587F5, p0); }
		public static Any _0xBB697756309D77EE(BOOL p0) { return Function.Call<Any>(0xBB697756309D77EE, p0); }
		public static BOOL _NETWORK_HAS_COMPLETED_MP_INTRO_FLOW_ON_CURRENT_SLOT() { return Function.Call<BOOL>(0xDD73C9838CE7181D); }
		public static BOOL NETWORK_SET_COMPLETED_MP_INTRO_FLOW_ON_CURRENT_SLOT(BOOL completed) { return Function.Call<BOOL>(0x2C5BD9A43987AA27, completed); }
		public static BOOL _0xD7D0DF27CB1765B5(int p0) { return Function.Call<BOOL>(0xD7D0DF27CB1765B5, p0); }
		public static BOOL NETWORK_SET_MP_MISSION_FLAG_ON_CURRENT_SLOT(BOOL enabled, int flagIndex) { return Function.Call<BOOL>(0x86FD10251A7118A4, enabled, flagIndex); }
		public static void _0x3E74A687A73979C6(BOOL p0) { Function.Call(0x3E74A687A73979C6, p0); }
		public static BOOL NETWORK_SESSION_IS_PRIVATE() { return Function.Call<BOOL>(0xCEF70AA5B3F89BA1); }
		public static unsafe void _NETWORK_SESSION_GET_SESSION_ID(Any* sessionId) { Function.Call(0xE9B356C330C0A806, sessionId); }
		public static unsafe BOOL _NETWORK_SESSION_ARE_SESSION_IDS_EQUAL(Any* sessionId1, Any* sessionId2) { return Function.Call<BOOL>(0x4DEC5000F7B508F0, sessionId1, sessionId2); }
		public static unsafe BOOL NETWORK_REQUEST_SESSION_SEAMLESS(int flags, int seamlessType, Any* sessionRequestId) { return Function.Call<BOOL>(0x04019AE4956D4393, flags, seamlessType, sessionRequestId); }
		public static unsafe BOOL NETWORK_SESSION_REQUEST_SESSION_SEAMLESS(int flags, int seamlessType, int userHash, Any* sessionRequestId) { return Function.Call<BOOL>(0x2989E131FDE37E97, flags, seamlessType, userHash, sessionRequestId); }
		public static unsafe BOOL NETWORK_SESSION_REQUEST_SESSION_COMPETITIVE(int flags, int matchType, int userHash, int p3, Any* sessionRequestId) { return Function.Call<BOOL>(0x309BBEBEA8A3986C, flags, matchType, userHash, p3, sessionRequestId); }
		public static unsafe BOOL NETWORK_SESSION_REQUEST_SESSION_PRIVATE(int flags, int numPlayers, int userHash, Any* sessionRequestId) { return Function.Call<BOOL>(0x39A8EF7AF29A192C, flags, numPlayers, userHash, sessionRequestId); }
		public static unsafe BOOL _NETWORK_SESSION_REQUEST_SESSION_ON_CALL(int flags, int category, Any* p2, int userHash, Any* sessionRequestId) { return Function.Call<BOOL>(0x23D9C1F2E4098EDC, flags, category, p2, userHash, sessionRequestId); }
		public static unsafe BOOL _NETWORK_SESSION_REQUEST_SESSION_NOMINATED(int flags, int userHash, int p2, Any* sessionRequestId) { return Function.Call<BOOL>(0x4F4672457FF597D1, flags, userHash, p2, sessionRequestId); }
		public static unsafe BOOL NETWORK_SESSION_IS_SESSION_REQUEST_ID_VALID(Any* sessionRequestId) { return Function.Call<BOOL>(0x2F54B146D3EDCE4D, sessionRequestId); }
		public static int NETWORK_SESSION_GET_SESSION_TYPE() { return Function.Call<int>(0xF0C0C94B404206FA); }
		public static int _0x1413B6BF27AB7A95() { return Function.Call<int>(0x1413B6BF27AB7A95); }
		public static BOOL NETWORK_SESSION_IS_ANY_REQUEST_IN_PROGRESS() { return Function.Call<BOOL>(0xBAFFDE5F953720D9); }
		public static unsafe BOOL _0xAFA14F98327791CE(Any* sessionRequestId) { return Function.Call<BOOL>(0xAFA14F98327791CE, sessionRequestId); }
		public static unsafe BOOL NETWORK_SESSION_IS_REQUEST_IN_PROGRESS(Any* sessionRequestId) { return Function.Call<BOOL>(0x8FB7C254CFCBF78E, sessionRequestId); }
		public static BOOL _NETWORK_SESSION_IS_REQUEST_IN_PROGRESS_BY_QUEUE_GROUP(int queueGroup) { return Function.Call<BOOL>(0x9E762A595CF88E4A, queueGroup); }
		public static unsafe BOOL _NETWORK_SESSION_CANCEL_REQUEST(Any* sessionRequestId) { return Function.Call<BOOL>(0xE72E5C1289BD1F40, sessionRequestId); }
		public static void _0xA6F1BAABFF6AD7B9(Any p0) { Function.Call(0xA6F1BAABFF6AD7B9, p0); }
		public static unsafe int _NETWORK_SESSION_GET_SESSION_REQUEST_RESULT(Any* sessionRequestId, int* p1) { return Function.Call<int>(0x0DD051B1BF4B8BD6, sessionRequestId, p1); }
		public static unsafe BOOL NETWORK_SESSION_IS_REQUEST_PENDING_TRANSITION(Any* sessionRequestId) { return Function.Call<BOOL>(0xCCF878D50F8AB10D, sessionRequestId); }
		public static unsafe BOOL _NETWORK_SESSION_TRANSITION_TO_SESSION(Any* sessionRequestId) { return Function.Call<BOOL>(0xF20B18A330E6DB5C, sessionRequestId); }
		public static unsafe BOOL _0x0F44A5C78D114922(Any* sessionRequestId) { return Function.Call<BOOL>(0x0F44A5C78D114922, sessionRequestId); }
		public static unsafe BOOL NETWORK_SESSION_LEFT_QUEUE_OR_REQUESTED_SESSION(Any* sessionRequestId) { return Function.Call<BOOL>(0xECE6A0C1B59CD8BE, sessionRequestId); }
		public static BOOL NETWORK_SESSION_LEAVE_SESSION() { return Function.Call<BOOL>(0x17C21B7319A05047); }
		public static BOOL NETWORK_SESSION_IS_TRANSITIONING() { return Function.Call<BOOL>(0xF2CBC969C4F090C7); }
		public static void _0xFD4272A137703449() { Function.Call(0xFD4272A137703449); }
		public static void _NETWORK_SESSION_PLAYLIST_GO_TO_NEXT_CONTENT() { Function.Call(0xBDE605F925B07127); }
		public static void _NETWORK_SESSION_PLAYLIST_GET_UPCOMING_CONTENT() { Function.Call(0x8F9DB6CD03B42B58); }
		public static void NETWORK_DISABLE_REALTIME_MULTIPLAYER() { Function.Call(0x236905C700FDB54D); }
		public static void _0x71FA2D1880C48032(BOOL p0) { Function.Call(0x71FA2D1880C48032, p0); }
		public static unsafe void NETWORK_GET_GLOBAL_MULTIPLAYER_CLOCK(int* hours, int* minutes, int* seconds) { Function.Call(0x6D03BFBD643B2A02, hours, minutes, seconds); }
		public static void NETWORK_CLEAR_CLOCK_TIME_OVERRIDE() { Function.Call(0xD972DF67326F966E); }
		public static BOOL NETWORK_IS_CLOCK_TIME_OVERRIDDEN() { return Function.Call<BOOL>(0xD7C95D322FF57522); }
		public static unsafe BOOL NETWORK_GET_GLOBAL_CLOCK(int* hour, int* minute, int* second) { return Function.Call<BOOL>(0x11A7ADCD629E170F, hour, minute, second); }
		public static void _NETWORK_CLOCK_TIME_OVERRIDE(int hour, int minute, int second, int transitionTime, BOOL pauseClock) { Function.Call(0x669E223E64B1903C, hour, minute, second, transitionTime, pauseClock); }
		public static void _NETWORK_CLOCK_TIME_OVERRIDE_2(int hour, int minute, int second, int transitionTime, BOOL pauseClock, BOOL clockwise) { Function.Call(0xE28C13ECC36FF14E, hour, minute, second, transitionTime, pauseClock, clockwise); }
		public static void _NETWORK_CLEAR_CLOCK_OVERRIDE_OVERTIME(int milliseconds) { Function.Call(0x65F040D91001ED4B, milliseconds); }
		public static BOOL _0x0E54D4DA6018FF8E() { return Function.Call<BOOL>(0x0E54D4DA6018FF8E); }
		public static BOOL NETWORK_IS_FINDING_GAMERS() { return Function.Call<BOOL>(0xDDDF64C91BFCF0AA); }
		public static BOOL NETWORK_DID_FIND_GAMERS_SUCCEED() { return Function.Call<BOOL>(0xF9B83B77929D8863); }
		public static int _0x7BCA0A3972708436(Any p0, int p1) { return Function.Call<int>(0x7BCA0A3972708436, p0, p1); }
		public static void NETWORK_CLEAR_FOUND_GAMERS() { Function.Call(0x6D14CCEE1B40381A); }
		public static unsafe BOOL _NETWORK_GET_GAMER_SESSION_FROM_HANDLE(Any* data, int count) { return Function.Call<BOOL>(0xFBDFE1C1356E12E8, data, count); }
		public static BOOL _0x25189F9908E9CD65() { return Function.Call<BOOL>(0x25189F9908E9CD65); }
		public static BOOL NETWORK_DID_GET_GAMER_STATUS_SUCCEED() { return Function.Call<BOOL>(0x5AE17C6B0134B7F1); }
		public static unsafe int _NETWORK_GET_GAMER_STATUS(Any* gamerHandle, int p1) { return Function.Call<int>(0xDDAEB478E58F8DEA, gamerHandle, p1); }
		public static void NETWORK_CLEAR_GET_GAMER_STATUS() { Function.Call(0x86E0660E4F5C956D); }
		public static void NETWORK_SET_SCRIPT_READY_FOR_EVENTS(BOOL toggle) { Function.Call(0x7AC752103856FB20, toggle); }
		public static BOOL _0x316FD416C432C761() { return Function.Call<BOOL>(0x316FD416C432C761); }
		public static BOOL _0x062842D61D0D53FD() { return Function.Call<BOOL>(0x062842D61D0D53FD); }
		public static BOOL NETWORK_IS_GAME_IN_PROGRESS() { return Function.Call<BOOL>(0x10FAB35428CCC9D7); }
		public static BOOL NETWORK_IS_SESSION_ACTIVE() { return Function.Call<BOOL>(0xD83C2B94E7508980); }
		public static BOOL NETWORK_IS_IN_SESSION() { return Function.Call<BOOL>(0xCA97246103B63917); }
		public static BOOL _NETWORK_IS_IN_SESSION_LOBBY() { return Function.Call<BOOL>(0xC5196C42DE19F646); }
		public static BOOL NETWORK_IS_SESSION_STARTED() { return Function.Call<BOOL>(0x9DE624D2FC4B603F); }
		public static BOOL NETWORK_CAN_SESSION_END() { return Function.Call<BOOL>(0x4EEBC3694E49C572); }
		public static int _0x225640E09EFFDC3F() { return Function.Call<int>(0x225640E09EFFDC3F); }
		public static BOOL _NETWORK_SESSION_ADD_SESSION_FLAGS(int flags) { return Function.Call<BOOL>(0xE546BDA1B3E288EE, flags); }
		public static BOOL NETWORK_SESSION_REMOVE_SESSION_FLAGS(int flags) { return Function.Call<BOOL>(0x78335E12DB0BF961, flags); }
		public static int NETWORK_SESSION_GET_SESSION_FLAGS() { return Function.Call<int>(0x51F33DBC1A41CBFD); }
		public static BOOL _NETWORK_SESSION_SET_PLAYER_FLAGS(int flags) { return Function.Call<BOOL>(0x0AE241A4A9ADEEEC, flags); }
		public static BOOL _NETWORK_SESSION_REMOVE_PLAYER_FLAGS(int flags) { return Function.Call<BOOL>(0x3215BBE34D3418C5, flags); }
		public static int _NETWORK_GET_SESSION_HOST() { return Function.Call<int>(0x8DC9AA3B508B1A85); }
		public static Any _0xD3A3C8B9F3BDEF81() { return Function.Call<Any>(0xD3A3C8B9F3BDEF81); }
		public static BOOL _0x18B94666CF610AEB() { return Function.Call<BOOL>(0x18B94666CF610AEB); }
		public static BOOL _0x981146E5C9CE9250(int p0) { return Function.Call<BOOL>(0x981146E5C9CE9250, p0); }
		public static int _0xBF8276E51761F9DA() { return Function.Call<int>(0xBF8276E51761F9DA); }
		public static BOOL _0xDCA4A74135E1DEA5(Any p0) { return Function.Call<BOOL>(0xDCA4A74135E1DEA5, p0); }
		public static BOOL NETWORK_HAS_PENDING_INVITE_FAILURE() { return Function.Call<BOOL>(0xD0498AD30E16B6BD); }
		public static unsafe BOOL _NETWORK_CAN_RECEIVE_INVITE_FROM_HANDLE(Any* gamerHandle) { return Function.Call<BOOL>(0xF23D6475640D29EB, gamerHandle); }
		public static void _0x704F92B3AF20D857(BOOL setting) { Function.Call(0x704F92B3AF20D857, setting); }
		public static void _0xF342F6BD0A8287D5(Any p0) { Function.Call(0xF342F6BD0A8287D5, p0); }
		public static void _0xD39A72AE5EBD57E5() { Function.Call(0xD39A72AE5EBD57E5); }
		public static unsafe BOOL _NETWORK_SEND_SESSION_INVITE(Any* gamerHandle, string contentId, Any* data, int dataSize, int p4, int flags) { return Function.Call<BOOL>(0xE47001B7CB8B98AE, gamerHandle, contentId, data, dataSize, p4, flags); }
		public static BOOL _0xD1FFB246F4E088AC(int p0) { return Function.Call<BOOL>(0xD1FFB246F4E088AC, p0); }
		public static int _0x27B1AE4D8C652F08(int p0) { return Function.Call<int>(0x27B1AE4D8C652F08, p0); }
		public static int _0x6C27442A225A241A(int p0) { return Function.Call<int>(0x6C27442A225A241A, p0); }
		public static string _0xE59F4924BD3A718D(int p0) { return Function.Call<string>(0xE59F4924BD3A718D, p0); }
		public static int _DELAY_ACTUAL_CONTENT_AND_CALL_IT_A_DAY_L_STAR(int p0) { return Function.Call<int>(0x78271BC02AE9AF83, p0); }
		public static unsafe BOOL _0x16EFB123C4451032(int p0, Any* gamerHandle) { return Function.Call<BOOL>(0x16EFB123C4451032, p0, gamerHandle); }
		public static string _0xE79BA3BC265895DA(int p0) { return Function.Call<string>(0xE79BA3BC265895DA, p0); }
		public static Any _0xC0CFFDA87C2C163D(int p0, Any p1, int p2) { return Function.Call<Any>(0xC0CFFDA87C2C163D, p0, p1, p2); }
		public static Any _0x5ED39DA62BEB1330(int p0) { return Function.Call<Any>(0x5ED39DA62BEB1330, p0); }
		public static BOOL NETWORK_ACCEPT_RS_INVITE(int p0) { return Function.Call<BOOL>(0xB2CEA5105AAC8DDE, p0); }
		public static BOOL _0x3AA0CDC63696166D(int p0) { return Function.Call<BOOL>(0x3AA0CDC63696166D, p0); }
		public static int NETWORK_REQUEST_JOIN(Any p0) { return Function.Call<int>(0xE483BB6BE686F632, p0); }
		public static int _0xE8E633215471BB5D(Any p0) { return Function.Call<int>(0xE8E633215471BB5D, p0); }
		public static BOOL _0xA2837A5E21FB5A58(Any p0) { return Function.Call<BOOL>(0xA2837A5E21FB5A58, p0); }
		public static BOOL _0xE39600E50D608693(Any p0, Any p1) { return Function.Call<BOOL>(0xE39600E50D608693, p0, p1); }
		public static BOOL _0xD7BAD4062074B9C1(Any p0) { return Function.Call<BOOL>(0xD7BAD4062074B9C1, p0); }
		public static int _0xCA58D4FD20D70F24(Any p0) { return Function.Call<int>(0xCA58D4FD20D70F24, p0); }
		public static BOOL _0xC028B3F52C707C49(Any p0) { return Function.Call<BOOL>(0xC028B3F52C707C49, p0); }
		public static BOOL NETWORK_IS_PLATFORM_INVITE_PENDING() { return Function.Call<BOOL>(0xFC4165C9165C166F); }
		public static void _0x5B9C6AC118FD4774() { Function.Call(0x5B9C6AC118FD4774); }
		public static int _NETWORK_GET_PLATFORM_INVITE_ID() { return Function.Call<int>(0x9BCF28FB5D65A9BE); }
		public static BOOL NETWORK_ACTION_PLATFORM_INVITE() { return Function.Call<BOOL>(0x3B82ACC3F4B6240C); }
		public static void NETWORK_CLEAR_PLATFORM_INVITE() { Function.Call(0xA4484173759749B1); }
		public static void _0x603469298A4308AF(BOOL p0) { Function.Call(0x603469298A4308AF, p0); }
		public static BOOL _NETWORK_ARE_ONLINE_NOTIFICATIONS_SHOWN_IN_STORY_MODE() { return Function.Call<BOOL>(0xF5C5929E07512F80); }
		public static BOOL NETWORK_IS_IN_PLATFORM_PARTY() { return Function.Call<BOOL>(0x2FC5650B0271CB57); }
		public static Any _0x11820D1AE80DEA39(Any p0, Any p1) { return Function.Call<Any>(0x11820D1AE80DEA39, p0, p1); }
		public static BOOL NETWORK_IS_IN_PLATFORM_PARTY_CHAT() { return Function.Call<BOOL>(0xFD8B834A8BA05048); }
		public static void NETWORK_SEED_RANDOM_NUMBER_GENERATOR(int seed) { Function.Call(0xF1B84178F8674195, seed); }
		public static int NETWORK_GET_RANDOM_INT_RANGED(int rangeStart, int rangeEnd) { return Function.Call<int>(0xE30CF56F1EFA5F43, rangeStart, rangeEnd); }
		public static void NETWORK_SET_THIS_SCRIPT_IS_NETWORK_SCRIPT(int maxNumMissionParticipants, BOOL p1, int instanceId) { Function.Call(0x1CA59E306ECB80A5, maxNumMissionParticipants, p1, instanceId); }
		public static BOOL NETWORK_GET_THIS_SCRIPT_IS_NETWORK_SCRIPT() { return Function.Call<BOOL>(0x2910669969E9535E); }
		public static int NETWORK_GET_MAX_NUM_PARTICIPANTS() { return Function.Call<int>(0xA6C90FBC38E395EE); }
		public static int NETWORK_GET_NUM_PARTICIPANTS() { return Function.Call<int>(0x18D0456E86604654); }
		public static int NETWORK_GET_SCRIPT_STATUS() { return Function.Call<int>(0x57D158647A6BFABF); }
		public static void NETWORK_REGISTER_HOST_BROADCAST_VARIABLES(Any p0, Any p1, Any p2) { Function.Call(0x3E9B2F01C50DF595, p0, p1, p2); }
		public static unsafe int _NETWORK_GET_SIZE_OF_HOST_BROADCAST_DATA_STORAGE(int* p0) { return Function.Call<int>(0xBA24095EA96DFE17, p0); }
		public static void NETWORK_REGISTER_PLAYER_BROADCAST_VARIABLES(Any p0, Any p1, Any p2) { Function.Call(0x3364AA97340CA215, p0, p1, p2); }
		public static unsafe int _NETWORK_GET_SIZE_OF_PLAYER_BROADCAST_DATA_STORAGE(int* p0) { return Function.Call<int>(0x690806BC83BC8CA2, p0); }
		public static BOOL NETWORK_HAS_RECEIVED_HOST_BROADCAST_DATA() { return Function.Call<BOOL>(0x5D10B3795F3FC886); }
		public static int NETWORK_GET_PLAYER_INDEX(int player) { return Function.Call<int>(0x24FB80D107371267, player); }
		public static int NETWORK_GET_PARTICIPANT_INDEX(int index) { return Function.Call<int>(0x1B84DF6AF2A46938, index); }
		public static int NETWORK_GET_PLAYER_INDEX_FROM_PED(int ped) { return Function.Call<int>(0x6C0E2E0125610278, ped); }
		public static int NETWORK_GET_NUM_CONNECTED_PLAYERS() { return Function.Call<int>(0xA4A79DD2D9600654); }
		public static BOOL NETWORK_IS_PLAYER_CONNECTED(int player) { return Function.Call<BOOL>(0x93DC1BE4E1ABE9D1, player); }
		public static int NETWORK_GET_TOTAL_NUM_PLAYERS() { return Function.Call<int>(0xCF61D4B4702EE9EB); }
		public static BOOL NETWORK_IS_PARTICIPANT_ACTIVE(int p0) { return Function.Call<BOOL>(0x6FF8FF40B6357D45, p0); }
		public static BOOL NETWORK_IS_PLAYER_ACTIVE(int player) { return Function.Call<BOOL>(0xB8DFD30D6973E135, player); }
		public static BOOL NETWORK_IS_PLAYER_A_PARTICIPANT(int player) { return Function.Call<BOOL>(0x3CA58F6CB7CBD784, player); }
		public static BOOL NETWORK_IS_HOST_OF_THIS_SCRIPT() { return Function.Call<BOOL>(0x83CD99A1E6061AB5); }
		public static int NETWORK_GET_HOST_OF_THIS_SCRIPT() { return Function.Call<int>(0xC7B4D79B01FA7A5C); }
		public static int NETWORK_GET_HOST_OF_SCRIPT(string scriptName, int p1, int p2) { return Function.Call<int>(0x1D6A14F1F9A736FC, scriptName, p1, p2); }
		public static int _NETWORK_GET_HOST_OF_THREAD(int threadId) { return Function.Call<int>(0xB4A25351D79B444C, threadId); }
		public static void NETWORK_SET_MISSION_FINISHED() { Function.Call(0x3B3D11CD9FFCDFC9); }
		public static BOOL NETWORK_IS_SCRIPT_ACTIVE(string scriptName, int p1, BOOL p2, int p3) { return Function.Call<BOOL>(0x9D40DF90FAD26098, scriptName, p1, p2, p3); }
		public static BOOL NETWORK_IS_SCRIPT_ACTIVE_BY_HASH(Hash scriptHash, int p1, BOOL p2, int p3) { return Function.Call<BOOL>(0x1B89BC43B6E69107, scriptHash, p1, p2, p3); }
		public static BOOL _NETWORK_IS_THREAD_ACTIVE(int threadId) { return Function.Call<BOOL>(0x31DAD2CD6D49546E, threadId); }
		public static int _NETWORK_GET_INSTANCE_ID_OF_THREAD(int threadId) { return Function.Call<int>(0xFB9ECED5B68F3B78, threadId); }
		public static int NETWORK_GET_NUM_SCRIPT_PARTICIPANTS(string scriptName, int instanceId, Hash position) { return Function.Call<int>(0x3658E8CD94FC121A, scriptName, instanceId, position); }
		public static int NETWORK_GET_INSTANCE_ID_OF_THIS_SCRIPT() { return Function.Call<int>(0x638A3A81733086DB); }
		public static unsafe BOOL NETWORK_IS_PLAYER_A_PARTICIPANT_ON_SCRIPT(int p0, Any* p1, Any p2) { return Function.Call<BOOL>(0x1AD5B71586B94820, p0, p1, p2); }
		public static void NETWORK_PREVENT_SCRIPT_HOST_MIGRATION() { Function.Call(0x2302C0264EA58D31); }
		public static BOOL NETWORK_IS_FEATURE_SUPPORTED(int featureId) { return Function.Call<BOOL>(0x9C725D149622BFDE, featureId); }
		public static int PARTICIPANT_ID() { return Function.Call<int>(0x90986E8876CE0A83); }
		public static int PARTICIPANT_ID_TO_INT() { return Function.Call<int>(0x57A3BDDAD8E5AA0A); }
		public static unsafe int NETWORK_GET_DESTROYER_OF_NETWORK_ID(int netId, Hash* weaponHash) { return Function.Call<int>(0x7A1ADEEF01740A24, netId, weaponHash); }
		public static unsafe int _0x6CF82A7F65A5AD5F(int ped, Any* p1) { return Function.Call<int>(0x6CF82A7F65A5AD5F, ped, p1); }
		public static unsafe BOOL _0x236321F1178A5446(int player, int ped, Any* p2) { return Function.Call<BOOL>(0x236321F1178A5446, player, ped, p2); }
		public static unsafe BOOL NETWORK_GET_ASSISTED_DAMAGE_OF_ENTITY(int player, int entity, int* p2) { return Function.Call<BOOL>(0x4CACA84440FA26F6, player, entity, p2); }
		public static unsafe int NETWORK_GET_ENTITY_KILLER_OF_PLAYER(int player, Hash* weaponHash) { return Function.Call<int>(0x42B2DAA6B596F5F8, player, weaponHash); }
		public static void NETWORK_RESURRECT_LOCAL_PLAYER(float x, float y, float z, float heading, int p4, BOOL p5, Any p6, BOOL p7) { Function.Call(0xEA23C49EAA83ACFB, x, y, z, heading, p4, p5, p6, p7); }
		public static unsafe void _NETWORK_RESURRECT_LOCAL_PLAYER_2(Any* args) { Function.Call(0x4154B7D8C75E5DCF, args); }
		public static void NETWORK_SET_LOCAL_PLAYER_INVINCIBLE_TIME(int time) { Function.Call(0x2D95C7E2D7E07307, time); }
		public static void NETWORK_SET_LOCAL_PLAYER_SYNC_LOOK_AT(BOOL toggle) { Function.Call(0x524FF0AEFF9C3973, toggle); }
		public static BOOL NETWORK_HAS_ENTITY_BEEN_REGISTERED_WITH_THIS_THREAD(int entity) { return Function.Call<BOOL>(0xB07D3185E11657A5, entity); }
		public static int NETWORK_GET_NETWORK_ID_FROM_ENTITY(int entity) { return Function.Call<int>(0xA11700682F3AD45C, entity); }
		public static int NETWORK_GET_ENTITY_FROM_NETWORK_ID(int netId) { return Function.Call<int>(0xCE4E5D9B0A4FF560, netId); }
		public static BOOL NETWORK_GET_ENTITY_IS_NETWORKED(int entity) { return Function.Call<BOOL>(0xC7827959479DCC78, entity); }
		public static void NETWORK_REGISTER_ENTITY_AS_NETWORKED(int entity) { Function.Call(0x06FAACD625D80CAA, entity); }
		public static BOOL NETWORK_DOES_NETWORK_ID_EXIST(int netID) { return Function.Call<BOOL>(0x38CE16C96BD11344, netID); }
		public static Any _0x950ACD8F05B7B9DF(Any p0) { return Function.Call<Any>(0x950ACD8F05B7B9DF, p0); }
		public static BOOL NETWORK_REQUEST_CONTROL_OF_NETWORK_ID(int netId) { return Function.Call<BOOL>(0xA670B3662FAFFBD0, netId); }
		public static BOOL NETWORK_HAS_CONTROL_OF_NETWORK_ID(int netId) { return Function.Call<BOOL>(0x4D36070FE0215186, netId); }
		public static BOOL NETWORK_REQUEST_CONTROL_OF_ENTITY(int entity) { return Function.Call<BOOL>(0xB69317BF5E782347, entity); }
		public static BOOL _NETWORK_REQUEST_CONTROL_OF_ANIM_SCENE(AnimScene animScene) { return Function.Call<BOOL>(0xAAA92B631B13F614, animScene); }
		public static BOOL NETWORK_REQUEST_CONTROL_OF_PICKUP_PLACEMENT(Any p0) { return Function.Call<BOOL>(0x56ED2C48558DAB78, p0); }
		public static BOOL NETWORK_HAS_CONTROL_OF_ENTITY(int entity) { return Function.Call<BOOL>(0x01BF60A500E28887, entity); }
		public static BOOL NETWORK_HAS_CONTROL_OF_PICKUP(int pickup) { return Function.Call<BOOL>(0x5BC9495F0B3B6FA6, pickup); }
		public static BOOL _NETWORK_HAS_CONTROL_OF_ANIM_SCENE(AnimScene animScene) { return Function.Call<BOOL>(0x26A5C12FACFF8724, animScene); }
		public static BOOL NETWORK_HAS_CONTROL_OF_PICKUP_PLACEMENT(Any p0) { return Function.Call<BOOL>(0x51EABCF2786515AB, p0); }
		public static int _0xF260AF6F43953316(ScrHandle handle) { return Function.Call<int>(0xF260AF6F43953316, handle); }
		public static int VEH_TO_NET(int vehicle) { return Function.Call<int>(0xB4C94523F023419C, vehicle); }
		public static int PED_TO_NET(int ped) { return Function.Call<int>(0x0EDEC3C276198689, ped); }
		public static int OBJ_TO_NET(Object _object) { return Function.Call<int>(0x99BFDC94A603E541, _object); }
		public static int _ANIM_SCENE_TO_NET(AnimScene animScene) { return Function.Call<int>(0xE0D73CDDEA79DDCD, animScene); }
		public static int NET_TO_VEH(int netHandle) { return Function.Call<int>(0x367B936610BA360C, netHandle); }
		public static int NET_TO_PED(int netHandle) { return Function.Call<int>(0xBDCD95FC216A8B3E, netHandle); }
		public static Object NET_TO_OBJ(int netHandle) { return Function.Call<Object>(0xD8515F5FEA14CB3F, netHandle); }
		public static int NET_TO_ENT(int netHandle) { return Function.Call<int>(0xBFFEAB45A9A9094A, netHandle); }
		public static AnimScene _NET_TO_ANIM_SCENE(int netId) { return Function.Call<AnimScene>(0xD7F6781A0ABAF6FB, netId); }
		public static int _PROPSET_TO_NET(PropSet propSet) { return Function.Call<int>(0x74F99EF7EF503398, propSet); }
		public static PropSet _NET_TO_PROPSET(int netId) { return Function.Call<PropSet>(0xD08066E00D26C448, netId); }
		public static void _0x0CC28C08613BA9E5(Any p0) { Function.Call(0x0CC28C08613BA9E5, p0); }
		public static unsafe void NETWORK_GET_LOCAL_HANDLE(Any* gamerHandle) { Function.Call(0xE86051786B66CD8E, gamerHandle); }
		public static unsafe void NETWORK_HANDLE_FROM_PLAYER(int player, Any* gamerHandle) { Function.Call(0x388EB2B86C73B6B3, player, gamerHandle); }
		public static Hash NETWORK_HASH_FROM_PLAYER_HANDLE(int player) { return Function.Call<Hash>(0xBC1D768F2F5D6C05, player); }
		public static unsafe void NETWORK_HANDLE_FROM_FRIEND(int friendIndex, Any* gamerHandle) { Function.Call(0xD45CB817D7E177D2, friendIndex, gamerHandle); }
		public static unsafe string NETWORK_GET_GAMERTAG_FROM_HANDLE(Any* gamerHandle) { return Function.Call<string>(0x426141162EBE5CDB, gamerHandle); }
		public static unsafe int NETWORK_DISPLAYNAMES_FROM_HANDLES_START(Any* p0, Any p1) { return Function.Call<int>(0xD66C9E72B3CC4982, p0, p1); }
		public static int NETWORK_GET_DISPLAYNAMES_FROM_HANDLES(Any p0, Any p1, Any p2) { return Function.Call<int>(0x58CC181719256197, p0, p1, p2); }
		public static unsafe BOOL _NETWORK_GET_DISPLAY_NAME_FROM_HANDLE(Any* gamerHandle, string displayName) { return Function.Call<BOOL>(0x7FEE4F07C54B6B3C, gamerHandle, displayName); }
		public static unsafe BOOL NETWORK_ARE_HANDLES_THE_SAME(Any* gamerHandle1, Any* gamerHandle2) { return Function.Call<BOOL>(0x57DBA049E110F217, gamerHandle1, gamerHandle2); }
		public static unsafe BOOL NETWORK_IS_HANDLE_VALID(Any* gamerHandle) { return Function.Call<BOOL>(0x6F79B93B0A8E4133, gamerHandle); }
		public static unsafe int NETWORK_GET_PLAYER_FROM_GAMER_HANDLE(Any* gamerHandle) { return Function.Call<int>(0xCE5F689CF5A0A49D, gamerHandle); }
		public static unsafe BOOL NETWORK_IS_GAMER_IN_MY_SESSION(Any* gamerHandle) { return Function.Call<BOOL>(0x0F10B05DDF8D16E9, gamerHandle); }
		public static unsafe void NETWORK_SHOW_PROFILE_UI(Any* gamerHandle) { Function.Call(0x859ED1CEA343FCA8, gamerHandle); }
		public static unsafe void _0x5759160AC17C13CE(Any* gamerHandle, string message) { Function.Call(0x5759160AC17C13CE, gamerHandle, message); }
		public static int _0xF302AB9D978352EE(int entity) { return Function.Call<int>(0xF302AB9D978352EE, entity); }
		public static int _0x4538EE7C321590BC(int networkId) { return Function.Call<int>(0x4538EE7C321590BC, networkId); }
		public static BOOL _0xA47D48D06AA5A188() { return Function.Call<BOOL>(0xA47D48D06AA5A188); }
		public static int NETWORK_GET_TOTAL_NUM_FRIENDS() { return Function.Call<int>(0xDB7ABDD203FA3704); }
		public static int _0xA94ECE191D90637A() { return Function.Call<int>(0xA94ECE191D90637A); }
		public static void _0x5CB8B0C846D0F30B(Any p0) { Function.Call(0x5CB8B0C846D0F30B, p0); }
		public static void _0xFF36F36B07E69059(Any p0) { Function.Call(0xFF36F36B07E69059, p0); }
		public static unsafe BOOL _NETWORK_GET_CURRENT_FRIEND_PAGE_DATA(Any* p0) { return Function.Call<BOOL>(0xA3EEC0A5AFF3FC5B, p0); }
		public static int _0xB389289F031F059A() { return Function.Call<int>(0xB389289F031F059A); }
		public static BOOL NETWORK_CAN_REFRESH_FRIEND_PAGE() { return Function.Call<BOOL>(0x1AF5E28E64A76A9F); }
		public static BOOL NETWORK_REFRESH_CURRENT_FRIEND_PAGE() { return Function.Call<BOOL>(0x1F51F367B710A832); }
		public static BOOL _0xDA1BFED8582F61F0() { return Function.Call<BOOL>(0xDA1BFED8582F61F0); }
		public static BOOL _0x232E1EB23CDB313C() { return Function.Call<BOOL>(0x232E1EB23CDB313C); }
		public static BOOL _0x3E4A16BC669E71B3() { return Function.Call<BOOL>(0x3E4A16BC669E71B3); }
		public static unsafe BOOL _0xE348D1404BD80146(Any* gamerHandle) { return Function.Call<BOOL>(0xE348D1404BD80146, gamerHandle); }
		public static unsafe BOOL _0x665161D250850A9F(Any* gamerHandle) { return Function.Call<BOOL>(0x665161D250850A9F, gamerHandle); }
		public static unsafe string _NETWORK_GET_GAMERTAG_FROM_FRIEND(Any* gamerHandle) { return Function.Call<string>(0x5659D87BE674AB17, gamerHandle); }
		public static unsafe BOOL NETWORK_IS_FRIEND(Any* gamerHandle) { return Function.Call<BOOL>(0x1A24A179F9B31654, gamerHandle); }
		public static unsafe BOOL NETWORK_IS_PENDING_FRIEND(Any* gamerHandle) { return Function.Call<BOOL>(0x0BE73DA6984A6E33, gamerHandle); }
		public static unsafe BOOL NETWORK_ADD_FRIEND(Any* gamerHandle, string message) { return Function.Call<BOOL>(0x8E02D73914064223, gamerHandle, message); }
		public static unsafe BOOL _NETWORK_REMOVE_FRIEND(Any* gamerHandle) { return Function.Call<BOOL>(0x55F618F68AB854D3, gamerHandle); }
		public static unsafe BOOL _NETWORK_CAN_ADD_FRIEND(Any* gamerHandle) { return Function.Call<BOOL>(0x99ABE9BF9DADA162, gamerHandle); }
		public static void NETWORK_SET_PLAYER_IS_PASSIVE(BOOL toggle) { Function.Call(0x9C25E8EC4C535FBD, toggle); }
		public static void NETWORK_SET_FRIENDLY_FIRE_OPTION(BOOL toggle) { Function.Call(0xF808475FA571D823, toggle); }
		public static unsafe void NETWORK_SET_RICH_PRESENCE(int p0, Any* p1, int p2, int p3) { Function.Call(0x1DCCACDCFC569362, p0, p1, p2, p3); }
		public static int NETWORK_GET_TIMEOUT_TIME() { return Function.Call<int>(0x5ED0356A0CE3A34F); }
		public static void _0xBC7D36946D19E60E(BOOL p0) { Function.Call(0xBC7D36946D19E60E, p0); }
		public static unsafe BOOL _0x880A7202301E282B(Any* p0, Any* p1, float x, float y, float z, float p5, Any p6) { return Function.Call<BOOL>(0x880A7202301E282B, p0, p1, x, y, z, p5, p6); }
		public static Any _0xC964FCD3D1720697() { return Function.Call<Any>(0xC964FCD3D1720697); }
		public static Any _0xEC089F84A9C16C62() { return Function.Call<Any>(0xEC089F84A9C16C62); }
		public static void PREVENT_NETWORK_ID_MIGRATION(int netId) { Function.Call(0x7182EDDA1EE7DB5A, netId); }
		public static void KEEP_NETWORK_ID_IN_FAST_INSTANCE(int netId, BOOL p1, int p2) { Function.Call(0xE1BC73D6815BA361, netId, p1, p2); }
		public static void _0x02C4C6C2900D84DF(int player, Any p1) { Function.Call(0x02C4C6C2900D84DF, player, p1); }
		public static void _0xD78A26024BB13E08(int player) { Function.Call(0xD78A26024BB13E08, player); }
		public static void SET_NETWORK_ID_EXISTS_ON_ALL_MACHINES(int netId, BOOL toggle) { Function.Call(0xE05E81A888FA63C8, netId, toggle); }
		public static void SET_NETWORK_ID_ALWAYS_EXISTS_FOR_PLAYER(int netId, int player, BOOL toggle) { Function.Call(0xA8A024587329F36A, netId, player, toggle); }
		public static void _0x9ED3108D6847760A(int netHandle, Any p1) { Function.Call(0x9ED3108D6847760A, netHandle, p1); }
		public static void _0xD785864798258032(int entity, BOOL toggle) { Function.Call(0xD785864798258032, entity, toggle); }
		public static void _NETWORK_SET_ENTITY_INVISIBLE_TO_NETWORK(int entity, BOOL toggle) { Function.Call(0xF1CA12B18AEF5298, entity, toggle); }
		public static void _0xE31A04513237DC89(int entity) { Function.Call(0xE31A04513237DC89, entity); }
		public static void SET_NETWORK_ID_VISIBLE_IN_CUTSCENE(Any p0, Any p1, Any p2, Any p3) { Function.Call(0xA6928482543022B4, p0, p1, p2, p3); }
		public static BOOL IS_NETWORK_ID_OWNED_BY_PARTICIPANT(int netId) { return Function.Call<BOOL>(0xA1607996431332DF, netId); }
		public static int _NETWORK_GET_PLAYER_OWNER_OF_NETWORK_ID(int netId) { return Function.Call<int>(0xA6C0787443C9583E, netId); }
		public static void SET_LOCAL_PLAYER_VISIBLE_IN_CUTSCENE(BOOL local, BOOL remote, int instanceId) { Function.Call(0xD1065D68947E7B6E, local, remote, instanceId); }
		public static void PREVENT_MIGRATION_OF_ENTITIES_IN_FAST_INSTANCE_FOR_LOCAL_PLAYER(BOOL toggle) { Function.Call(0x89D803CD48622150, toggle); }
		public static void SET_LOCAL_PLAYER_INVISIBLE_LOCALLY(BOOL p0) { Function.Call(0xE5F773C1A1D9D168, p0); }
		public static void SET_PLAYER_INVISIBLE_LOCALLY(int player, BOOL toggle) { Function.Call(0x12B37D54667DB0B8, player, toggle); }
		public static void SET_PLAYER_VISIBLE_LOCALLY(int player, BOOL toggle) { Function.Call(0xFAA10F1FAFB11AF2, player, toggle); }
		public static void SET_ENTITY_VISIBLE_IN_CUTSCENE(int entity, BOOL p1, BOOL p2, int p3) { Function.Call(0xE0031D3C8F36AB82, entity, p1, p2, p3); }
		public static void _SET_DOOR_NETWORKED(Hash doorHash) { Function.Call(0x51D99497ABF3F451, doorHash); }
		public static void _SET_DOOR_UNNETWORKED(Any p0, BOOL toggle) { Function.Call(0xC1E1A3D5ED7617B8, p0, toggle); }
		public static BOOL IS_DAMAGE_TRACKER_ACTIVE_ON_NETWORK_ID(int netID) { return Function.Call<BOOL>(0x6E192E33AD436366, netID); }
		public static void ACTIVATE_DAMAGE_TRACKER_ON_NETWORK_ID(int netID, BOOL toggle) { Function.Call(0xD45B1FFCCD52FF19, netID, toggle); }
		public static BOOL IS_SPHERE_VISIBLE_TO_ANOTHER_MACHINE(Any p0, Any p1, Any p2, Any p3, Any p4) { return Function.Call<BOOL>(0xD82CF8E64C8729D8, p0, p1, p2, p3, p4); }
		public static BOOL IS_SPHERE_VISIBLE_TO_PLAYER(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5) { return Function.Call<BOOL>(0xDC3A310219E5DA62, p0, p1, p2, p3, p4, p5); }
		public static void _0xD42C543F73233041(BOOL p0) { Function.Call(0xD42C543F73233041, p0); }
		public static void RESERVE_NETWORK_MISSION_OBJECTS(int amount) { Function.Call(0x4E5C93BD0C32FBF8, amount); }
		public static void RESERVE_NETWORK_CLIENT_MISSION_OBJECTS(int amount) { Function.Call(0xE7DDA8BD3BCF751C, amount); }
		public static void RESERVE_NETWORK_MISSION_PEDS(int amount) { Function.Call(0xB60FEBA45333D36F, amount); }
		public static void RESERVE_NETWORK_CLIENT_MISSION_PEDS(int amount) { Function.Call(0x807E119F80231732, amount); }
		public static void RESERVE_NETWORK_MISSION_VEHICLES(int amount) { Function.Call(0x76B02E21ED27A469, amount); }
		public static void RESERVE_NETWORK_MISSION_PICKUPS(int amount) { Function.Call(0x4D40E7D749BC6E6D, amount); }
		public static BOOL CAN_REGISTER_MISSION_OBJECTS(int amount) { return Function.Call<BOOL>(0x800DD4721A8B008B, amount); }
		public static BOOL CAN_REGISTER_MISSION_PEDS(int amount) { return Function.Call<BOOL>(0xBCBF4FEF9FA5D781, amount); }
		public static BOOL CAN_REGISTER_MISSION_VEHICLES(int amount) { return Function.Call<BOOL>(0x7277F1F2E085EE74, amount); }
		public static BOOL CAN_REGISTER_MISSION_PICKUPS(int amount) { return Function.Call<BOOL>(0xF0460C7BF80011EA, amount); }
		public static BOOL CAN_REGISTER_MISSION_ENTITIES(int ped_amt, int vehicle_amt, int _object_amt, int pickup_amt) { return Function.Call<BOOL>(0x69778E7564BADE6D, ped_amt, vehicle_amt, _object_amt, pickup_amt); }
		public static int GET_NUM_RESERVED_MISSION_OBJECTS(BOOL p0) { return Function.Call<int>(0xAA81B5F10BC43AC2, p0); }
		public static int GET_NUM_RESERVED_MISSION_PEDS(BOOL p0) { return Function.Call<int>(0x1F13D5AE5CB17E17, p0); }
		public static int GET_NUM_RESERVED_MISSION_VEHICLES(BOOL p0) { return Function.Call<int>(0xCF3A965906452031, p0); }
		public static int _GET_NUM_RESERVED_MISSION_PICKUPS(BOOL p0) { return Function.Call<int>(0x62BE3ECC79FBD004, p0); }
		public static int GET_NUM_CREATED_MISSION_OBJECTS(BOOL p0) { return Function.Call<int>(0x12B6281B6C6706C0, p0); }
		public static int GET_NUM_CREATED_MISSION_PEDS(BOOL p0) { return Function.Call<int>(0xCB215C4B56A7FAE7, p0); }
		public static int GET_NUM_CREATED_MISSION_VEHICLES(BOOL p0) { return Function.Call<int>(0x0CD9AB83489430EA, p0); }
		public static int _GET_NUM_CREATED_MISSION_PICKUPS(BOOL p0) { return Function.Call<int>(0xD2BA051B94CA9BCC, p0); }
		public static unsafe void _GET_RESERVATIONS_FOR_SLOT_WORLD_POSITION(float x, float y, float z, BOOL p3, int* peds, int* vehicles, int* _objects, int* pickups) { Function.Call(0x5E71E72A94985214, x, y, z, p3, peds, vehicles, _objects, pickups); }
		public static BOOL _0x5F328FC909F0E0FF(int p0, int p1, int p2, int p3) { return Function.Call<BOOL>(0x5F328FC909F0E0FF, p0, p1, p2, p3); }
		public static int GET_MAX_NUM_NETWORK_OBJECTS() { return Function.Call<int>(0xC7BE335216B5EC7C); }
		public static int GET_MAX_NUM_NETWORK_PEDS() { return Function.Call<int>(0x0C1F7D49C39D2289); }
		public static int GET_MAX_NUM_NETWORK_VEHICLES() { return Function.Call<int>(0x0AFCE529F69B21FF); }
		public static int GET_MAX_NUM_NETWORK_PICKUPS() { return Function.Call<int>(0xA72835064DD63E4C); }
		public static unsafe BOOL _0x75FC34A2BA345BD1(int entity, int player, Any* p2) { return Function.Call<BOOL>(0x75FC34A2BA345BD1, entity, player, p2); }
		public static void _0x979765465A6F25FC(int entity, BOOL p1) { Function.Call(0x979765465A6F25FC, entity, p1); }
		public static int _0x5133CF81924F1129() { return Function.Call<int>(0x5133CF81924F1129); }
		public static int _0x1E4E097D71D449FB(BOOL p0) { return Function.Call<int>(0x1E4E097D71D449FB, p0); }
		public static int _0x982D7AD755B8F62C(BOOL p0) { return Function.Call<int>(0x982D7AD755B8F62C, p0); }
		public static int _0x917AD74BDCF8B6E9(BOOL p0) { return Function.Call<int>(0x917AD74BDCF8B6E9, p0); }
		public static int _0xF8DC69DC1AD19072(BOOL p0) { return Function.Call<int>(0xF8DC69DC1AD19072, p0); }
		public static int _0x744BFBB0CA908161(BOOL p0) { return Function.Call<int>(0x744BFBB0CA908161, p0); }
		public static int _0x106CBDD5077DEDE1(BOOL p0) { return Function.Call<int>(0x106CBDD5077DEDE1, p0); }
		public static int _0xBAF7E2979442B29F(BOOL p0) { return Function.Call<int>(0xBAF7E2979442B29F, p0); }
		public static int _0x039B692B3318FAB6(BOOL p0) { return Function.Call<int>(0x039B692B3318FAB6, p0); }
		public static int _0x4835413EA6F9C9CD(BOOL p0) { return Function.Call<int>(0x4835413EA6F9C9CD, p0); }
		public static int GET_NETWORK_TIME() { return Function.Call<int>(0x7A5487FE9FAA6B48); }
		public static int GET_NETWORK_TIME_ACCURATE() { return Function.Call<int>(0x89023FBBF9200E9F); }
		public static BOOL HAS_NETWORK_TIME_STARTED() { return Function.Call<BOOL>(0x46718ACEEDEAFC84); }
		public static int GET_TIME_OFFSET(int timeA, int timeB) { return Function.Call<int>(0x017008CCDAD48503, timeA, timeB); }
		public static BOOL IS_TIME_LESS_THAN(int timeA, int timeB) { return Function.Call<BOOL>(0xCB2CF5148012C8D0, timeA, timeB); }
		public static BOOL IS_TIME_MORE_THAN(int timeA, int timeB) { return Function.Call<BOOL>(0xDE350F8651E4346C, timeA, timeB); }
		public static int GET_TIME_DIFFERENCE(int timeA, int timeB) { return Function.Call<int>(0xA2C6FC031D46FFF0, timeA, timeB); }
		public static int GET_CLOUD_TIME_AS_INT() { return Function.Call<int>(0x9A73240B49945C76); }
		public static unsafe void CONVERT_POSIX_TIME(int posixTime, Any* timeStructure) { Function.Call(0xAC97AF97FA68E5D5, posixTime, timeStructure); }
		public static void NETWORK_SET_IN_SPECTATOR_MODE(BOOL toggle, int playerPed) { Function.Call(0x423DE3854BB50894, toggle, playerPed); }
		public static void _NETWORK_SET_IN_STATIC_SPECTATOR_MODE(BOOL toggle, float x, float y, float z) { Function.Call(0xFBF1ECFB39A77B5F, toggle, x, y, z); }
		public static BOOL NETWORK_IS_IN_SPECTATOR_MODE() { return Function.Call<BOOL>(0x048746E388762E11); }
		public static BOOL _NETWORK_IS_PLAYER_IN_SPECTATOR_MODE(int player) { return Function.Call<BOOL>(0x5B709519997ECF0F, player); }
		public static void NETWORK_SET_IN_MP_CUTSCENE(BOOL p0, BOOL p1, int p2, BOOL p3) { Function.Call(0x9CA5DE655269FEC4, p0, p1, p2, p3); }
		public static BOOL NETWORK_IS_IN_MP_CUTSCENE() { return Function.Call<BOOL>(0x6CC27C9FA2040220); }
		public static BOOL NETWORK_IS_PLAYER_IN_MP_CUTSCENE(int player) { return Function.Call<BOOL>(0x63F9EE203C3619F2, player); }
		public static void _0x34BC1E79546BA543(BOOL p0) { Function.Call(0x34BC1E79546BA543, p0); }
		public static void _SET_NETWORK_RESPOT_TIMER(int entity, int timer, BOOL p2) { Function.Call(0x442B4347B6EC36E8, entity, timer, p2); }
		public static BOOL _0x26A867C0B7A456D1(int entity) { return Function.Call<BOOL>(0x26A867C0B7A456D1, entity); }
		public static void _SET_LOCAL_PLAYER_AS_GHOST(BOOL toggle) { Function.Call(0x5FFE9B4144F9712F, toggle); }
		public static BOOL _IS_ENTITY_GHOSTED_TO_LOCAL_PLAYER(int entity) { return Function.Call<BOOL>(0x21D04D7BC538C146, entity); }
		public static void _0xDCA6ABDB9288FBE4(int player, BOOL disabled) { Function.Call(0xDCA6ABDB9288FBE4, player, disabled); }
		public static void _SET_ENTITY_GHOSTED_TO_LOCAL_PLAYER(int entity, BOOL toggle) { Function.Call(0xEE5AE9956743BA20, entity, toggle); }
		public static BOOL _IS_OBJECT_REASSIGNMENT_IN_PROGRESS() { return Function.Call<BOOL>(0x8FE9EB11EC9CC23A); }
		public static int _0x039AD6B57D5179FF() { return Function.Call<int>(0x039AD6B57D5179FF); }
		public static int _0x02B3CDD652B3CDD6() { return Function.Call<int>(0x02B3CDD652B3CDD6); }
		public static int _GET_NUM_PEER_NEGOTIATION_RESPONSES() { return Function.Call<int>(0x4FE932E84FE932E8); }
		public static unsafe void _NETWORK_DEBUG_REQUEST_ENTITY_POSITION(Any* p0) { Function.Call(0xFA38B52F91B59075, p0); }
		public static int _NETWORK_GET_NETWORK_ID_FROM_ROPE(int ropeId) { return Function.Call<int>(0x42871327315EDAE8, ropeId); }
		public static int _NETWORK_GET_ROPE_FROM_NETWORK_ID(int netId) { return Function.Call<int>(0xEB1A4DD8352EC828, netId); }
		public static void _NETWORK_SPAWN_CONFIG_ADD_SPAWN_POINT(float x, float y, float z, float heading) { Function.Call(0xFD1AC0B3858F224C, x, y, z, heading); }
		public static void _0xA63E4F050F20021F() { Function.Call(0xA63E4F050F20021F); }
		public static void _NETWORK_SPAWN_CONFIG_ADD_EXCLUSION_VOLUME(Volume volume) { Function.Call(0xEEB7818B1D307212, volume); }
		public static void _NETWORK_SPAWN_CONFIG_REMOVE_EXCLUSION_VOLUME(Volume volume) { Function.Call(0xA35E7BF20FA269E0, volume); }
		public static void _0x0BF90CBB6B72977B() { Function.Call(0x0BF90CBB6B72977B); }
		public static void _0x7B3FF2D193628126(int player) { Function.Call(0x7B3FF2D193628126, player); }
		public static void _0x19B52C20B5C4757C() { Function.Call(0x19B52C20B5C4757C); }
		public static void NETWORK_SPAWN_CONFIG_SET_FLAGS(int flags) { Function.Call(0xF94A0D5B254375DF, flags); }
		public static void _0x6CEE2E30021DAEC6() { Function.Call(0x6CEE2E30021DAEC6); }
		public static void _NETWORK_SPAWN_CONFIG_ADD_PROPERTY_SCRIPTED(int configProperty, BOOL include) { Function.Call(0x44D59EC597BBF348, configProperty, include); }
		public static void _0xB131E686BD97B3F8() { Function.Call(0xB131E686BD97B3F8); }
		public static void _NETWORK_SPAWN_CONFIG_ADD_PROPERTY_PREFERENCE(int configProperty, BOOL include, float weight) { Function.Call(0xEB6027FD1B4600D5, configProperty, include, weight); }
		public static void _0x405DDEFB1F531B18(Volume volume, BOOL p1, Any p2, Any p3) { Function.Call(0x405DDEFB1F531B18, volume, p1, p2, p3); }
		public static void _0x43CF999205084B4B() { Function.Call(0x43CF999205084B4B); }
		public static void _0x13F592FC3BF0EA84(Volume volume, BOOL p1, float originalWeight, Any p3, Any p4) { Function.Call(0x13F592FC3BF0EA84, volume, p1, originalWeight, p3, p4); }
		public static void _0xCF23AB5BD47B384D(Any p0) { Function.Call(0xCF23AB5BD47B384D, p0); }
		public static void _0xE5634491A58C2703(float p0) { Function.Call(0xE5634491A58C2703, p0); }
		public static void NETWORK_SPAWN_CONFIG_SET_GROUND_TO_ROOT_OFFSET(float offset) { Function.Call(0x59577799F6AE2F34, offset); }
		public static void _NETWORK_SPAWN_CONFIG_SET_LEVEL_WATER_DEPTH(int waterDepthLevel) { Function.Call(0xBDCC671B911040F9, waterDepthLevel); }
		public static void NETWORK_SPAWN_CONFIG_SET_TUNING_FLOAT(Hash p0, float p1) { Function.Call(0x0608326F7B98C08D, p0, p1); }
		public static void _0x5D3C528B7A7DF836(Hash p0) { Function.Call(0x5D3C528B7A7DF836, p0); }
		public static void _0x2686BD9566B65EDA(float x, float y, float z) { Function.Call(0x2686BD9566B65EDA, x, y, z); }
		public static void _0xBB1EC8C2EEF33BAA(int entity) { Function.Call(0xBB1EC8C2EEF33BAA, entity); }
		public static BOOL _0x67CCDF74C4DF7169() { return Function.Call<BOOL>(0x67CCDF74C4DF7169); }
		public static void _0xC8B6D18E22484643() { Function.Call(0xC8B6D18E22484643); }
		public static void _0x97BCE4C4B3191228() { Function.Call(0x97BCE4C4B3191228); }
		public static int _0x41452E8A3B9C0C4B() { return Function.Call<int>(0x41452E8A3B9C0C4B); }
		public static BOOL _NETWORK_SPAWN_CONFIG_SEARCH_IN_PROGRESS() { return Function.Call<BOOL>(0x89EC2FC89ECB1005); }
		public static void _0x61BFBAA795E712AD() { Function.Call(0x61BFBAA795E712AD); }
		public static void _NETWORK_SPAWN_CONFIG_SET_CANCEL_SEARCH() { Function.Call(0x765E60A1DCB8B1CE); }
		public static unsafe void _0x691E4DE5309EAEFC(Any p0, Any* p1) { Function.Call(0x691E4DE5309EAEFC, p0, p1); }
		public static void NETWORK_START_SOLO_TUTORIAL_SESSION() { Function.Call(0x17E0198B3882C2CB); }
		public static void NETWORK_END_TUTORIAL_SESSION() { Function.Call(0xD0AFAFF5A51D72F7); }
		public static BOOL NETWORK_IS_IN_TUTORIAL_SESSION() { return Function.Call<BOOL>(0xADA24309FE08DACF); }
		public static BOOL NETWORK_IS_TUTORIAL_SESSION_CHANGE_PENDING() { return Function.Call<BOOL>(0x35F0B98A8387274D); }
		public static BOOL _NETWORK_IS_PLAYER_EQUAL_TO_INDEX(int player, int index) { return Function.Call<BOOL>(0x9DE986FC9A87C474, player, index); }
		public static void NETWORK_ALLOW_ALL_ENTITY_FADING_FOR_INSTANCES(BOOL toggle) { Function.Call(0x4B05B97BA46F419D, toggle); }
		public static void NETWORK_ALLOW_ENTITY_FADING_FOR_INSTANCES(int entity, BOOL toggle) { Function.Call(0xF3354D6CA46F419D, entity, toggle); }
		public static void _0xDC6AD5C046F33AB4(BOOL p0, BOOL p1) { Function.Call(0xDC6AD5C046F33AB4, p0, p1); }
		public static void _0x6C7E04E9DE451789() { Function.Call(0x6C7E04E9DE451789); }
		public static void NETWORK_SET_LOCAL_PLAYER_PENDING_FAST_INSTANCE_ID(int instanceId) { Function.Call(0x007FF852DCF49DA4, instanceId); }
		public static int _NETWORK_GET_PLAYER_FAST_INSTANCE_ID(int player) { return Function.Call<int>(0xD9267375834C5EAB, player); }
		public static void NETWORK_CONCEAL_PLAYER(int player, BOOL toggle) { Function.Call(0xBBDF066252829606, player, toggle); }
		public static BOOL NETWORK_IS_PLAYER_CONCEALED(int player) { return Function.Call<BOOL>(0x919B3C98ED8292F9, player); }
		public static void _0x40FEDB13870042F1() { Function.Call(0x40FEDB13870042F1); }
		public static void _0x422F9D6D6C7BC290(int p0) { Function.Call(0x422F9D6D6C7BC290, p0); }
		public static void NETWORK_REQUEST_CLOUD_TUNABLES() { Function.Call(0x42FB3B532D526E6C); }
		public static BOOL NETWORK_IS_TUNABLE_CLOUD_REQUEST_PENDING() { return Function.Call<BOOL>(0x0467C11ED88B7D28); }
		public static int NETWORK_GET_TUNABLE_CLOUD_CRC() { return Function.Call<int>(0x10BD227A753B0D84); }
		public static BOOL NETWORK_DOES_TUNABLE_EXIST(Hash tunableContext, Hash tunableName) { return Function.Call<BOOL>(0x85E5F8B9B898B20A, tunableContext, tunableName); }
		public static unsafe BOOL NETWORK_ACCESS_TUNABLE_INT(Hash tunableContext, Hash tunableName, int* value) { return Function.Call<BOOL>(0x8BE1146DFD5D4468, tunableContext, tunableName, value); }
		public static BOOL NETWORK_ACCESS_TUNABLE_BOOL(Hash tunableContext, Hash tunableName) { return Function.Call<BOOL>(0xAA6A47A573ABB75A, tunableContext, tunableName); }
		public static int _NETWORK_TRY_ACCESS_TUNABLE_INT(Hash tunableContext, Hash tunableName, int defaultValue) { return Function.Call<int>(0xA25E006B36719774, tunableContext, tunableName, defaultValue); }
		public static float _NETWORK_TRY_ACCESS_TUNABLE_FLOAT(Hash tunableContext, Hash tunableName, float defaultValue) { return Function.Call<float>(0xA18393089C05E49C, tunableContext, tunableName, defaultValue); }
		public static BOOL _NETWORK_TRY_ACCESS_TUNABLE_BOOL(Hash tunableContext, Hash tunableName, BOOL defaultValue) { return Function.Call<BOOL>(0xB2AD5D29A99D4B26, tunableContext, tunableName, defaultValue); }
		public static void _0x894B5ECAB45D2342(int netHandle, Any p1) { Function.Call(0x894B5ECAB45D2342, netHandle, p1); }
		public static void NETWORK_DISABLE_PROXIMITY_MIGRATION(int netID) { Function.Call(0x407091CF6037118E, netID); }
		public static Any _0xCE5E79D9E303628E() { return Function.Call<Any>(0xCE5E79D9E303628E); }
		public static BOOL _0xDBC754CB6CCB9378() { return Function.Call<BOOL>(0xDBC754CB6CCB9378); }
		public static BOOL CLOUD_HAS_REQUEST_COMPLETED(int id) { return Function.Call<BOOL>(0x4C61B39930D045DA, id); }
		public static BOOL CLOUD_DID_REQUEST_SUCCEED(int id) { return Function.Call<BOOL>(0x3A3D5568AF297CD5, id); }
		public static BOOL _GET_LAUNCH_PARAM_EXISTS(string paramName) { return Function.Call<BOOL>(0x02E97CE283648CD9, paramName); }
		public static string _GET_LAUNCH_PARAM_VALUE(string paramName) { return Function.Call<string>(0x65E65CA6A0FE59D4, paramName); }
		public static void _SET_LAUNCH_PARAM_VALUE(string paramName, string value) { Function.Call(0x668AF6E4933AC13F, paramName, value); }
		public static void _CLEAR_LAUNCH_PARAM(string paramName) { Function.Call(0x782C94DB6469634D, paramName); }
		public static string _GET_LAUNCH_PARAM_STRING() { return Function.Call<string>(0xC59AB6A04333C502); }
		public static void _SET_LAUNCH_PARAM_STRING(string _params) { Function.Call(0xDFFC15AA63D04AAB, _params); }
		public static void _CLEAR_LAUNCH_PARAMS() { Function.Call(0x966DD84FB6A46017); }
		public static BOOL UGC_IS_REQUEST_PENDING(int ugcRequestId) { return Function.Call<BOOL>(0xF4AC4FA844FD559A, ugcRequestId); }
		public static BOOL UGC_HAS_REQUEST_FINISHED(int ugcRequestId) { return Function.Call<BOOL>(0xA9EB4D606076615D, ugcRequestId); }
		public static BOOL UGC_DID_REQUEST_SUCCEED(int ugcRequestId) { return Function.Call<BOOL>(0x0B6009A90B8495F1, ugcRequestId); }
		public static Any _0xCD53E6CBF609C012(Any p0) { return Function.Call<Any>(0xCD53E6CBF609C012, p0); }
		public static Any _0xF40EF49B3099E98E(Any p0, int maxGet, string contentTypeName, Any p3, Any p4, Any p5) { return Function.Call<Any>(0xF40EF49B3099E98E, p0, maxGet, contentTypeName, p3, p4, p5); }
		public static Any _0x8C109958C9BB559D(int categoryType, Any p1, int maxGet, string contentTypeName, int p4, Any p5) { return Function.Call<Any>(0x8C109958C9BB559D, categoryType, p1, maxGet, contentTypeName, p4, p5); }
		public static BOOL _UGC_QUERY_BY_CONTENT_ID(string contentId, BOOL latestVersion, string contentTypeName) { return Function.Call<BOOL>(0x69D22E183580113F, contentId, latestVersion, contentTypeName); }
		public static BOOL _UGC_IS_BOOK_MARKED(string contentId) { return Function.Call<BOOL>(0xE42D1042F09865FE, contentId); }
		public static void UGC_CLEAR_QUERY_RESULTS(int ugcRequestId) { Function.Call(0xE931354FEA710038, ugcRequestId); }
		public static BOOL UGC_QUERY_WAS_FORCE_CANCELLED(int ugcRequestId) { return Function.Call<BOOL>(0xF8F0705E77A0E705, ugcRequestId); }
		public static int UGC_QUERY_GET_CONTENT_NUM(int ugcRequestId) { return Function.Call<int>(0x76160E0396142765, ugcRequestId); }
		public static unsafe Any _UGC_QUERY_GET_CREATOR_HANDLE(Any p0, int index, Any* gamerHandle) { return Function.Call<Any>(0xADB56322EEDFBDC9, p0, index, gamerHandle); }
		public static string _UGC_QUERY_GET_OWNER_ID(Any p0, int index) { return Function.Call<string>(0xF9F0B3028431967B, p0, index); }
		public static string _UGC_QUERY_GET_NAME(Any p0, int index) { return Function.Call<string>(0x2D053EA815702DD1, p0, index); }
		public static string _UGC_QUERY_GET_ROOT_CONTENT_ID(Any p0, int index) { return Function.Call<string>(0x566CEB0542EF5ECF, p0, index); }
		public static string _UGC_QUERY_GET_PLAYLIST_NAME(Any p0, int index) { return Function.Call<string>(0xCAF50048C8D0FBA0, p0, index); }
		public static Hash _UGC_QUERY_GET_MISSION_DESC_HASH(Any p0, int index) { return Function.Call<Hash>(0xA6BF569956C60A60, p0, index); }
		public static Any _UGC_QUERY_GET_CREATOR_PHOTO(Any p0, int p1, Any p2) { return Function.Call<Any>(0x409FE0CA6A4D1D49, p0, p1, p2); }
		public static unsafe void _UGC_QUERY_GET_DATE(Any p0, int index, Any* p2) { Function.Call(0xE0CB4AB15CB32710, p0, index, p2); }
		public static int _UGC_QUERY_GET_POSIX_UPDATED_DATE(Any p0, Any p1) { return Function.Call<int>(0x21A99A72B00D8002, p0, p1); }
		public static int _UGC_QUERY_GET_POSIX_PUBLISHED_DATE(Any p0, Any p1) { return Function.Call<int>(0x104080CA9E519B00, p0, p1); }
		public static int _UGC_QUERY_GET_VERSION(Any p0, int index, int p2) { return Function.Call<int>(0x63E9DCBC8B0931ED, p0, index, p2); }
		public static int _UGC_QUERY_GET_LANGUAGE(Any p0, int index) { return Function.Call<int>(0x97764E8AC6487A9A, p0, index); }
		public static BOOL _UGC_QUERY_GET_PUBLISHED(Any p0, Any p1) { return Function.Call<BOOL>(0x9993F1E11944A3DD, p0, p1); }
		public static float _UGC_QUERY_GET_RATING(Any p0, int index, int p2) { return Function.Call<float>(0x24CD8FAEA1368379, p0, index, p2); }
		public static Any _0x5F0E99071582DECA(Any p0, int index, int p2) { return Function.Call<Any>(0x5F0E99071582DECA, p0, index, p2); }
		public static BOOL UGC_QUERY_GET_CONTENT_HAS_PLAYER_RECORD(Any p0, int index) { return Function.Call<BOOL>(0xF794765390A6DCA5, p0, index); }
		public static BOOL _UGC_QUERY_GET_BOOK_MARKED(Any p0, int index) { return Function.Call<BOOL>(0x98539FC453AEA639, p0, index); }
		public static BOOL _UGC_HAS_PRIVILEGE() { return Function.Call<BOOL>(0x6506BFA755FB209C); }
		public static int UGC_REQUEST_CONTENT_DATA_FROM_PARAMS(string contentTypeName, string contentId, int fileId, int fileVersion, int languageId) { return Function.Call<int>(0x7FD2990AF016795E, contentTypeName, contentId, fileId, fileVersion, languageId); }
		public static int UGC_REQUEST_CACHED_DESCRIPTION(Hash description) { return Function.Call<int>(0x5E0165278F6339EE, description); }
		public static BOOL UGC_IS_DESCRIPTION_REQUEST_IN_PROGRESS(Hash description) { return Function.Call<BOOL>(0x2D5DC831176D0114, description); }
		public static BOOL UGC_HAS_DESCRIPTION_REQUEST_FINISHED(Hash description) { return Function.Call<BOOL>(0xEBFA8D50ADDC54C4, description); }
		public static BOOL UGC_DID_DESCRIPTION_REQUEST_SUCCEED(Hash description) { return Function.Call<BOOL>(0x162C23CA83ED0A62, description); }
		public static string UGC_GET_CACHED_DESCRIPTION(Hash description, int length) { return Function.Call<string>(0x40F7E66472DF3E5C, description, length); }
		public static BOOL UGC_RELEASE_CACHED_DESCRIPTION(Hash description) { return Function.Call<BOOL>(0x5A34CD9C3C5BEC44, description); }
		public static void UGC_RELEASE_ALL_CACHED_DESCRIPTIONS() { Function.Call(0x68103E2247887242); }
		public static void UGC_SET_QUERY_DATA_FROM_OFFLINE(BOOL p0) { Function.Call(0xF98DDE0A8ED09323, p0); }
		public static BOOL UGC_IS_LANGUAGE_SUPPORTED(int languageId) { return Function.Call<BOOL>(0xF53E48461B71EECB, languageId); }
		public static Any _0xD4022C7286B0DFA2(string p0, int p1, int p2) { return Function.Call<Any>(0xD4022C7286B0DFA2, p0, p1, p2); }
		public static BOOL _NETWORK_PERSONA_PHOTO_WRITE_SC_PROFILE(string texture, int personaPhotoType, int formatIndex) { return Function.Call<BOOL>(0xB72999D3120599DF, texture, personaPhotoType, formatIndex); }
		public static BOOL _NETWORK_PERSONA_PHOTO_WRITE_LOCAL(string texture, int playerSlot, int p2, int personaPhotoLocalCacheType) { return Function.Call<BOOL>(0x2A48D9567940598F, texture, playerSlot, p2, personaPhotoLocalCacheType); }
		public static BOOL _NETWORK_IS_PREVIOUS_UPLOAD_PENDING() { return Function.Call<BOOL>(0xA21E3BAD0A42D199); }
		public static Any _0xCC4E72C339461ED1() { return Function.Call<Any>(0xCC4E72C339461ED1); }
		public static string _0x356F9FB0698C1FEB(int player, int personaPhotoLocalCacheType) { return Function.Call<string>(0x356F9FB0698C1FEB, player, personaPhotoLocalCacheType); }
		public static unsafe string _0xCAF4CA2F87779F8F(Any* gamerHandle, int p1) { return Function.Call<string>(0xCAF4CA2F87779F8F, gamerHandle, p1); }
		public static unsafe string _0xB5C4B18B12A2AF23(Any* gamerHandle, int p1) { return Function.Call<string>(0xB5C4B18B12A2AF23, gamerHandle, p1); }
		public static BOOL _0xE2C3CEC3C0903A00(string name) { return Function.Call<BOOL>(0xE2C3CEC3C0903A00, name); }
		public static unsafe int TEXTURE_DOWNLOAD_REQUEST(Any* gamerHandle, string filePath, string name, BOOL p3) { return Function.Call<int>(0x16160DA74A8E74A2, gamerHandle, filePath, name, p3); }
		public static unsafe int _MUGSHOT_TEXTURE_DOWNLOAD_REQUEST(Any* gamerHandle, int p1, string name, BOOL p3) { return Function.Call<int>(0x9B5DB6CEAFAA10BB, gamerHandle, p1, name, p3); }
		public static unsafe int UGC_TEXTURE_DOWNLOAD_REQUEST(Any* p0, Any p1, Any p2, Any p3, Any* p4, BOOL p5) { return Function.Call<int>(0x308F96458B7087CC, p0, p1, p2, p3, p4, p5); }
		public static int _LOCAL_PLAYER_PEDSHOT_TEXTURE_DOWNLOAD_REQUEST(int playerSlot, int personaPhotoLocalCacheType) { return Function.Call<int>(0x6E2FD8CF7EB10E53, playerSlot, personaPhotoLocalCacheType); }
		public static void TEXTURE_DOWNLOAD_RELEASE(int textureDownloadId) { Function.Call(0x487EB90B98E9FB19, textureDownloadId); }
		public static void _TEXTURE_DOWNLOAD_RELEASE_BY_NAME(string name) { Function.Call(0x7A17B7981560FFA5, name); }
		public static string TEXTURE_DOWNLOAD_GET_NAME(int textureDownloadId) { return Function.Call<string>(0x3448505B6E35262D, textureDownloadId); }
		public static int GET_STATUS_OF_TEXTURE_DOWNLOAD(int textureDownloadId) { return Function.Call<int>(0x8BD6C6DEA20E82C6, textureDownloadId); }
		public static int _0xCBAC13F065C47596() { return Function.Call<int>(0xCBAC13F065C47596); }
		public static BOOL _0xCD954F330693F5F2() { return Function.Call<BOOL>(0xCD954F330693F5F2); }
		public static Any _0xFBC30B70B3CDB87E() { return Function.Call<Any>(0xFBC30B70B3CDB87E); }
		public static void _0x814729078AED6D30() { Function.Call(0x814729078AED6D30); }
		public static BOOL NETWORK_HAVE_ROS_BANNED_PRIV() { return Function.Call<BOOL>(0x8020A73847E0CA7D); }
		public static BOOL NETWORK_HAS_ROS_PRIVILEGE(int index) { return Function.Call<BOOL>(0xA699957E60D80214, index); }
		public static unsafe int NETWORK_START_USER_CONTENT_PERMISSIONS_CHECK(Any* gamerHandle) { return Function.Call<int>(0xDEB2B99A1AF1A2A6, gamerHandle); }
		public static void _NETWORK_AUTO_SESSION_SET_ALLOWED_TO_SPLIT(BOOL toggle) { Function.Call(0x0A428058079EE65C, toggle); }
		public static BOOL NETWORK_AUTO_SESSION_IS_ALLOWED_TO_MERGE() { return Function.Call<BOOL>(0xAADED99A6B268A27); }
		public static unsafe void _NETWORK_AUTO_SESSION_SET_ALLOWED_TO_MERGE(BOOL toggle, Any* p1, int p2) { Function.Call(0x63246A24F5747510, toggle, p1, p2); }
		public static BOOL _0xE258570E0C116A66() { return Function.Call<BOOL>(0xE258570E0C116A66); }
		public static void _0x4440FEE3EFE78F54(BOOL toggle) { Function.Call(0x4440FEE3EFE78F54, toggle); }
		public static unsafe BOOL NETWORK_AUTO_SESSION_CAN_SPLIT_SESSION(int* p0) { return Function.Call<BOOL>(0xE404BFF0ABA23CDC, p0); }
		public static BOOL NETWORK_AUTO_SESSION_SPLIT_SESSION(int playersToTake, int maxInstancePlayers, int sessionFlags, int bucketId) { return Function.Call<BOOL>(0xC223D299C670413D, playersToTake, maxInstancePlayers, sessionFlags, bucketId); }
		public static BOOL _0xA021095C983F20D8() { return Function.Call<BOOL>(0xA021095C983F20D8); }
		public static BOOL _0x6D87BA8EF15226CD() { return Function.Call<BOOL>(0x6D87BA8EF15226CD); }
		public static BOOL _0x277865A734918AE6() { return Function.Call<BOOL>(0x277865A734918AE6); }
		public static void NETWORK_AUTO_SESSION_FINISH_INSTANCE() { Function.Call(0xBB51299166B844F3); }
		public static void _0xFD8112109A96877C() { Function.Call(0xFD8112109A96877C); }
		public static void _0x5A91BCEF74944E93(int player, float p1) { Function.Call(0x5A91BCEF74944E93, player, p1); }
		public static int _0xFB3205788F8AFA3F() { return Function.Call<int>(0xFB3205788F8AFA3F); }
		public static void _0x335AF56613CA0F49(int p0) { Function.Call(0x335AF56613CA0F49, p0); }
		public static BOOL _0x9E5A47744C0F0376(int p0) { return Function.Call<BOOL>(0x9E5A47744C0F0376, p0); }
		public static void _0xD3B6EBC6C3D77D44(int p0) { Function.Call(0xD3B6EBC6C3D77D44, p0); }
		public static void _0xA7670F7991099680(int p0) { Function.Call(0xA7670F7991099680, p0); }
		public static void _0x7673C0D2C5CDAC55() { Function.Call(0x7673C0D2C5CDAC55); }
		public static void _0x3CBD6565D9C3B133(int p0, int p1, float p2) { Function.Call(0x3CBD6565D9C3B133, p0, p1, p2); }
		public static void _0x0D183D8490EE4366(int p0, int p1) { Function.Call(0x0D183D8490EE4366, p0, p1); }
		public static void _0xC1968045EEB563B7(int p0) { Function.Call(0xC1968045EEB563B7, p0); }
		public static BOOL NETWORK_AUTO_SESSION_IS_OBJECT_CREATION_PAUSED() { return Function.Call<BOOL>(0x0E2C3AEE6CE603B7); }
		public static BOOL _0x0B6B4507AC5EA8B8() { return Function.Call<BOOL>(0x0B6B4507AC5EA8B8); }
		public static BOOL NETWORK_IS_RESETTING_POPULATION() { return Function.Call<BOOL>(0x1BB50CD340A996E6); }
		public static BOOL NETWORK_RESET_POPULATION(BOOL p0, int p1) { return Function.Call<BOOL>(0x101F538C25ABB39A, p0, p1); }
		public static void NETWORK_DISABLE_LEAVE_REMOTE_PED_BEHIND(BOOL toggle) { Function.Call(0xC505036A35AFD01B, toggle); }
		public static void _0x3034C77C79A58880(BOOL p0) { Function.Call(0x3034C77C79A58880, p0); }
		public static void _NETWORK_ALLOW_LOCAL_ENTITY_ATTACHMENT(int entity, BOOL toggle) { Function.Call(0x267C78C60E806B9A, entity, toggle); }
		public static void _0x6BFF5F84102DF80A(int player) { Function.Call(0x6BFF5F84102DF80A, player); }
		public static void _0x5C497525F803486B() { Function.Call(0x5C497525F803486B); }
		public static BOOL _NETWORK_IS_CONNECTION_ENDPOINT_RELAY_SERVER(int player) { return Function.Call<BOOL>(0x16D3D49902F697BB, player); }
		public static float _NETWORK_GET_AVERAGE_LATENCY_FOR_PLAYER(int player) { return Function.Call<float>(0xD414BE129BB81B32, player); }
		public static float _NETWORK_GET_AVERAGE_LATENCY_FOR_PLAYER_2(int player) { return Function.Call<float>(0x0E3A041ED6AC2B45, player); }
		public static float _NETWORK_GET_AVERAGE_PACKET_LOSS_FOR_PLAYER(int player) { return Function.Call<float>(0x350C23949E43686C, player); }
		public static int _NETWORK_GET_NUM_UNACKED_FOR_PLAYER(int player) { return Function.Call<int>(0xFF8FCF9FFC458A1C, player); }
		public static int _NETWORK_GET_UNRELIABLE_RESEND_COUNT_FOR_PLAYER(int player) { return Function.Call<int>(0x3765C3A3E8192E10, player); }
		public static int _NETWORK_GET_OLDEST_RESEND_COUNT_FOR_PLAYER(int player) { return Function.Call<int>(0x52C1EADAF7B10302, player); }
		public static Any _0xAEDF1BC1C133D6E3() { return Function.Call<Any>(0xAEDF1BC1C133D6E3); }
		public static Any _0x6FD992C4A1C1B986() { return Function.Call<Any>(0x6FD992C4A1C1B986); }
		public static BOOL NETWORK_IS_PLAYER_INDEX_VALID(int player) { return Function.Call<BOOL>(0x255A5EF65EDA9167, player); }
		public static BOOL _GET_PLAYER_WAYPOINT_IS_ACTIVE(int player) { return Function.Call<BOOL>(0xDCC4B7F7112E8AB7, player); }
		public static void _0x455156F47DC6B78C(BOOL p0) { Function.Call(0x455156F47DC6B78C, p0); }
		public static void _SET_LOCAL_PLAYER_DAMAGE_MULTIPLIER_FOR_PLAYER(int player, float damageMultiplier) { Function.Call(0xD041A32992A55F84, player, damageMultiplier); }
		public static void _NETWORK_SET_VEHICLE_WHEELS_DESTRUCTIBLE(int entity, BOOL p1) { Function.Call(0x0C8BC052AE87D744, entity, p1); }
		public static void _0x5CD3AAD8FF9ED121(Any p0) { Function.Call(0x5CD3AAD8FF9ED121, p0); }
		public static void _0x51951DE06C0D1C40(int player, int type) { Function.Call(0x51951DE06C0D1C40, player, type); }
		public static void _0xE3AB5EEFCB6671A2(int setting) { Function.Call(0xE3AB5EEFCB6671A2, setting); }
		public static void _0x9B39B0555CC692B5() { Function.Call(0x9B39B0555CC692B5); }
		public static int _0xFE53B1F8D43F19BF(int player1, int player2) { return Function.Call<int>(0xFE53B1F8D43F19BF, player1, player2); }
		public static BOOL _0x862C5040F4888741(int player1, int player2) { return Function.Call<BOOL>(0x862C5040F4888741, player1, player2); }
		public static void _0x2CD41AC000E6F611() { Function.Call(0x2CD41AC000E6F611); }
		public static void _0xACC44768AF229042() { Function.Call(0xACC44768AF229042); }
		public static void _0x7E300B5B86AB1D1A(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8, Any p9, Any p10, Any p11, Any p12, Any p13, Any p14) { Function.Call(0x7E300B5B86AB1D1A, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14); }
		public static int GET_UNIQUE_INT_FOR_PLAYER(int player) { return Function.Call<int>(0x07F723401B9D921C, player); }
		public static void _0x780A13F780A13F1B(BOOL toggle) { Function.Call(0x780A13F780A13F1B, toggle); }
		public static BOOL _NETWORK_IS_TRACKED_PLAYER_VISIBLE(int player, int trackedPlayer) { return Function.Call<BOOL>(0xE525878A35B9EEBD, player, trackedPlayer); }
		public static BOOL NETWORK_IS_AIM_CAM_ACTIVE(int player) { return Function.Call<BOOL>(0x8E7CE19219669AEB, player); }
		public static void _NETWORK_ALERT(Hash ctx, Hash lh, int ec, int h) { Function.Call(0x1BAA028F52EED310, ctx, lh, ec, h); }
		public static void _0x19447FCAE97704DC(Hash ctx, int ec, BOOL ex, BOOL ro) { Function.Call(0x19447FCAE97704DC, ctx, ec, ex, ro); }
		public static void _0x2C4E98DDA475364F(string p0) { Function.Call(0x2C4E98DDA475364F, p0); }
		public static void _0x3F0ABAE38A0515AD(int p0, int p1) { Function.Call(0x3F0ABAE38A0515AD, p0, p1); }
		public static int _0x3F2EE18A3E294801(int p0) { return Function.Call<int>(0x3F2EE18A3E294801, p0); }
		public static void _SET_SOCIAL_MATCHMAKING_ALLOWED(BOOL toggle) { Function.Call(0x777D0571A466B520, toggle); }
		public static BOOL _GET_SOCIAL_MATCHMAKING_ALLOWED() { return Function.Call<BOOL>(0xD0541EF28E9C4783); }
		public static BOOL NETWORK_AWARD_HAS_REACHED_MAXCLAIM(Any p0) { return Function.Call<BOOL>(0xFBE782B3165AC8EC, p0); }
		public static Any _0x271F95E55C663B8B(Any p0, Any p1) { return Function.Call<Any>(0x271F95E55C663B8B, p0, p1); }
		public static Any _0x64A36BA85CE01A81(Any p0, Any p1, Any p2, Any p3) { return Function.Call<Any>(0x64A36BA85CE01A81, p0, p1, p2, p3); }
		public static Any _0xE10F2D7715ABABEC(Any p0) { return Function.Call<Any>(0xE10F2D7715ABABEC, p0); }
		public static Any _0x7A8E8DF782B47EB0(Any p0, Any p1, Any p2) { return Function.Call<Any>(0x7A8E8DF782B47EB0, p0, p1, p2); }
		public static Any _0x77B299E8799B1332(Any p0, Any p1, Any p2) { return Function.Call<Any>(0x77B299E8799B1332, p0, p1, p2); }
		public static Any _0x923346025512DFB7(Any p0) { return Function.Call<Any>(0x923346025512DFB7, p0); }
		public static int _NETWORK_GET_XP() { return Function.Call<int>(0xDB438CC9BC6F4022); }
		public static int _NETWORK_GET_RANK() { return Function.Call<int>(0x32C90CDFAF40514C); }
		public static void NETWORK_SET_RECENT_GAMERS_ENABLED(BOOL toggle) { Function.Call(0x29FE035D35B8589C, toggle); }
		public static BOOL _0x273E04A3A7AD1F2D() { return Function.Call<BOOL>(0x273E04A3A7AD1F2D); }
		public static void _NETWORK_ADD_PLAYER_TO_RECENT_GAMERS_LIST(int player, int p1) { Function.Call(0x157D8F3DE12B307F, player, p1); }
		public static BOOL NETWORK_REQUEST_RECENT_GAMER_NAMES(int p0, int playerCount) { return Function.Call<BOOL>(0x6D206D383BB5F6B1, p0, playerCount); }
		public static BOOL _NETWORK_IS_RECENT_GAMER_NAMES_REQUEST_IN_PROGRESS() { return Function.Call<BOOL>(0x4664D213A0CCAF40); }
		public static BOOL _NETWORK_DID_RECENT_GAMER_NAMES_REQUEST_SUCCEED() { return Function.Call<BOOL>(0x12AEB56B489415C5); }
		public static int _NETWORK_GET_NUM_RECENT_GAMERS() { return Function.Call<int>(0x37A834AEC6A4F74A); }
		public static unsafe BOOL NETWORK_GET_RECENT_GAMER_NAMES(int p0, int p1, Any* _outData, int dataSize) { return Function.Call<BOOL>(0xFEFCC345CE357453, p0, p1, _outData, dataSize); }
		public static void _0x49CF17A564918E8D() { Function.Call(0x49CF17A564918E8D); }
		public static void _0xD637D327080CD86E(int p0) { Function.Call(0xD637D327080CD86E, p0); }
		public static void _0x564552C6AF1EEAB1() { Function.Call(0x564552C6AF1EEAB1); }
		public static void NETWORK_ACTIVITY_RESET_TO_IDLE() { Function.Call(0x3FE141FDB990E3D1); }
		public static void NETWORK_ACTIVITY_SET_CURRENT(int p0) { Function.Call(0x9ADAC065D9F6706F, p0); }
		public static string _NETWORK_GET_ROS_TITLE_NAME() { return Function.Call<string>(0xAC6153A0722F524C); }
		public static void _REPORT_PLAYER(int player, int reportType, string description, string horseName) { Function.Call(0xA197C35F73AC0F12, player, reportType, description, horseName); }
	}

	public static class OBJECT
	{
		public static Object CREATE_OBJECT(Hash modelHash, float x, float y, float z, BOOL isNetwork, BOOL bScriptHostObj, BOOL dynamic, BOOL p7, BOOL p8) { return Function.Call<Object>(0x509D5878EB39E842, modelHash, x, y, z, isNetwork, bScriptHostObj, dynamic, p7, p8); }
		public static Object CREATE_OBJECT_NO_OFFSET(Hash modelHash, float x, float y, float z, BOOL isNetwork, BOOL bScriptHostObj, BOOL dynamic, BOOL p7) { return Function.Call<Object>(0x9A294B2138ABB884, modelHash, x, y, z, isNetwork, bScriptHostObj, dynamic, p7); }
		public static unsafe void DELETE_OBJECT(Object* _object) { Function.Call(0x931914268722C263, _object); }
		public static BOOL PLACE_OBJECT_ON_GROUND_PROPERLY(Object _object, BOOL p1) { return Function.Call<BOOL>(0x58A850EAEE20FAA3, _object, p1); }
		public static BOOL SLIDE_OBJECT(Object _object, float toX, float toY, float toZ, float speedX, float speedY, float speedZ, BOOL collision) { return Function.Call<BOOL>(0x2FDFF4107B8C1147, _object, toX, toY, toZ, speedX, speedY, speedZ, collision); }
		public static void SET_OBJECT_TARGETTABLE(Object _object, BOOL targettable) { Function.Call(0x8A7391690F5AFD81, _object, targettable); }
		public static void _SET_OBJECT_TARGETTABLE_2(Object _object, BOOL targettable) { Function.Call(0x581EDBE56E8D62C9, _object, targettable); }
		public static void _SET_OBJECT_TARGETTABLE_FOCUS(Object _object, BOOL p1, BOOL p2) { Function.Call(0xA22712E8471AA08E, _object, p1, p2); }
		public static void _0xF6E88489B4E6EBE5(Any p0, Any p1) { Function.Call(0xF6E88489B4E6EBE5, p0, p1); }
		public static void _0xE157A8A336C7F04A(Any p0, Any p1) { Function.Call(0xE157A8A336C7F04A, p0, p1); }
		public static void _0x46CBCF0E98A4E156(Any p0, Any p1) { Function.Call(0x46CBCF0E98A4E156, p0, p1); }
		public static Object GET_CLOSEST_OBJECT_OF_TYPE(float x, float y, float z, float radius, Hash modelHash, BOOL isMission, BOOL p6, BOOL p7) { return Function.Call<Object>(0xE143FA2249364369, x, y, z, radius, modelHash, isMission, p6, p7); }
		public static BOOL HAS_OBJECT_BEEN_BROKEN(Any p0) { return Function.Call<BOOL>(0x8ABFB70C49CC43E2, p0); }
		public static BOOL HAS_CLOSEST_OBJECT_OF_TYPE_BEEN_BROKEN(float p0, float p1, float p2, float p3, Hash modelHash, Any p5) { return Function.Call<BOOL>(0x761B0E69AC4D007E, p0, p1, p2, p3, modelHash, p5); }
		public static Vector3 _GET_OBJECT_OFFSET_FROM_COORDS(float xPos, float yPos, float zPos, float heading, float xOffset, float yOffset, float zOffset) { return Function.Call<Vector3>(0x163E252DE035A133, xPos, yPos, zPos, heading, xOffset, yOffset, zOffset); }
		public static void _ADD_DOOR_TO_SYSTEM_NEW(Hash doorHash, BOOL p1, BOOL p2, BOOL p3, int threadId, int p5, BOOL p6) { Function.Call(0xD99229FE93B46286, doorHash, p1, p2, p3, threadId, p5, p6); }
		public static BOOL _IS_DOOR_REGISTERED_WITH_NETWORK(Hash doorHash) { return Function.Call<BOOL>(0xB5DED7B65C604FDF, doorHash); }
		public static void REMOVE_DOOR_FROM_SYSTEM(Hash doorHash) { Function.Call(0x464D8E1427156FE4, doorHash); }
		public static void DOOR_SYSTEM_SET_DOOR_STATE(Hash doorHash, int state) { Function.Call(0x6BAB9442830C7F53, doorHash, state); }
		public static int DOOR_SYSTEM_GET_DOOR_STATE(Hash doorHash) { return Function.Call<int>(0x160AA1B32F6139B8, doorHash); }
		public static void DOOR_SYSTEM_SET_AUTOMATIC_RATE(Hash doorHash, float rate) { Function.Call(0x03C27E13B42A0E82, doorHash, rate); }
		public static void DOOR_SYSTEM_SET_AUTOMATIC_DISTANCE(Hash doorHash, float distance) { Function.Call(0x9BA001CB45CBF627, doorHash, distance); }
		public static void _0xB3B1546D23DF8DE1(Any p0, Any p1, Any p2, Any p3, Any p4) { Function.Call(0xB3B1546D23DF8DE1, p0, p1, p2, p3, p4); }
		public static void DOOR_SYSTEM_SET_OPEN_RATIO(Hash doorHash, float ajar, BOOL forceUpdate) { Function.Call(0xB6E6FBA95C7324AC, doorHash, ajar, forceUpdate); }
		public static void _0x3A77DAE8B4FD7586(Any p0, Any p1) { Function.Call(0x3A77DAE8B4FD7586, p0, p1); }
		public static void _DOOR_SYSTEM_SET_ABLE_TO_CHANGE_OPEN_RATIO_WHILE_LOCKED(Hash doorHash, BOOL p1) { Function.Call(0x1F1FABFE9B2A1254, doorHash, p1); }
		public static BOOL _IS_DOOR_REGISTERED_WITH_OWNER(Hash doorHash) { return Function.Call<BOOL>(0x4F89DAD4156BA145, doorHash); }
		public static void _DOOR_SYSTEM_CHANGE_SCRIPT_OWNER(Hash doorHash) { Function.Call(0x985767F5FA45BC44, doorHash); }
		public static float _DOOR_SYSTEM_GET_AUTOMATIC_RATE(Hash doorHash) { return Function.Call<float>(0x8433E1954BE323FC, doorHash); }
		public static Any _0x6E2AA80BB0C03728(Any p0, Any p1) { return Function.Call<Any>(0x6E2AA80BB0C03728, p0, p1); }
		public static void _0x1BC47A9DEDC8DF5D(Any p0, Any p1) { Function.Call(0x1BC47A9DEDC8DF5D, p0, p1); }
		public static float DOOR_SYSTEM_GET_OPEN_RATIO(Hash doorHash) { return Function.Call<float>(0x65499865FCA6E5EC, doorHash); }
		public static void _0x7F458B543006C8FE(Any p0, Any p1) { Function.Call(0x7F458B543006C8FE, p0, p1); }
		public static Any _0xACD4F9831DFAD7F5(Any p0) { return Function.Call<Any>(0xACD4F9831DFAD7F5, p0); }
		public static void _0x0C0A373D181BF900(Any p0) { Function.Call(0x0C0A373D181BF900, p0); }
		public static void _0xA93F925F1942E434(Any p0, Any p1) { Function.Call(0xA93F925F1942E434, p0, p1); }
		public static Any _0x4D8611DFE1126478(Any p0) { return Function.Call<Any>(0x4D8611DFE1126478, p0); }
		public static void _0x57C242543B7B8FB9(Any p0, Any p1) { Function.Call(0x57C242543B7B8FB9, p0, p1); }
		public static void _0x4AE07EBA3462C5D5(Any p0, Any p1) { Function.Call(0x4AE07EBA3462C5D5, p0, p1); }
		public static void _0x22031584496CFB70(Any p0, Any p1) { Function.Call(0x22031584496CFB70, p0, p1); }
		public static void _0xC07B91B996C1DE89(Any p0, Any p1) { Function.Call(0xC07B91B996C1DE89, p0, p1); }
		public static BOOL IS_DOOR_REGISTERED_WITH_SYSTEM(Hash doorHash) { return Function.Call<BOOL>(0xC153C43EA202C8C1, doorHash); }
		public static BOOL IS_DOOR_CLOSED(Hash doorHash) { return Function.Call<BOOL>(0xC531EE8A1145A149, doorHash); }
		public static Any _0x0943113E02322164(Object _object, int p1) { return Function.Call<Any>(0x0943113E02322164, _object, p1); }
		public static Any _0x614D0B4533F842D3(Any p0) { return Function.Call<Any>(0x614D0B4533F842D3, p0); }
		public static void _DOOR_SYSTEM_FORCE_SHUT(Hash doorHash, BOOL p1) { Function.Call(0x276AAF0F1C7F2494, doorHash, p1); }
		public static Any _0xEBA314768FB35D58(Any p0) { return Function.Call<Any>(0xEBA314768FB35D58, p0); }
		public static void _0x5230BF34EB0EC645(Any p0) { Function.Call(0x5230BF34EB0EC645, p0); }
		public static BOOL DOES_OBJECT_OF_TYPE_EXIST_AT_COORDS(float x, float y, float z, float radius, Hash hash, BOOL p5) { return Function.Call<BOOL>(0xBFA48E2FF417213F, x, y, z, radius, hash, p5); }
		public static BOOL IS_POINT_IN_ANGLED_AREA(float p0, float p1, float p2, float p3, float p4, float p5, float p6, float p7, float p8, float p9, BOOL p10, BOOL p11) { return Function.Call<BOOL>(0x2A70BAE8883E4C81, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11); }
		public static void SET_OBJECT_ALLOW_LOW_LOD_BUOYANCY(Object _object, BOOL toggle) { Function.Call(0x4D89D607CB3DD1D2, _object, toggle); }
		public static void SET_OBJECT_PHYSICS_PARAMS(Object _object, float weight, float p2, float p3, float p4, float p5, float gravity, float p7, float p8, float p9, float p10, float buoyancy) { Function.Call(0xF6DF6E90DE7DF90F, _object, weight, p2, p3, p4, p5, gravity, p7, p8, p9, p10, buoyancy); }
		public static float GET_OBJECT_FRAGMENT_DAMAGE_HEALTH(Any p0, BOOL p1) { return Function.Call<float>(0xB6FBFD079B8D0596, p0, p1); }
		public static Any _0x235C863DA77BD88D(Any p0, Any p1, Any p2) { return Function.Call<Any>(0x235C863DA77BD88D, p0, p1, p2); }
		public static void SET_ACTIVATE_OBJECT_PHYSICS_AS_SOON_AS_IT_IS_UNFROZEN(Object _object, BOOL toggle) { Function.Call(0x406137F8EF90EAF5, _object, toggle); }
		public static void BREAK_OBJECT_FRAGMENT_CHILD(Object _object, Any p1, BOOL p2) { Function.Call(0xE7E4C198B0185900, _object, p1, p2); }
		public static void BREAK_ALL_OBJECT_FRAGMENT_BONES(Object _object) { Function.Call(0x8462BE2341A55B6F, _object); }
		public static void _0xAAACF33CBF9B990A(Any p0, Any p1) { Function.Call(0xAAACF33CBF9B990A, p0, p1); }
		public static void _DAMAGE_BONE_ON_PROP(Object _object, int bone) { Function.Call(0xE4EFB315BCD2A838, _object, bone); }
		public static void _0xF9C1681347C8BD15(Object _object) { Function.Call(0xF9C1681347C8BD15, _object); }
		public static Any _0x58DE624FA7FB0E7F(Any p0) { return Function.Call<Any>(0x58DE624FA7FB0E7F, p0); }
		public static void _0x491439AEF410A2FC(Any p0) { Function.Call(0x491439AEF410A2FC, p0); }
		public static void _SET_OBJECT_BREAK_SCALE(Object _object, float scale) { Function.Call(0xFFB99FFD17F65889, _object, scale); }
		public static void _0xCEAB54F4632C6EF6(Any p0, Any p1) { Function.Call(0xCEAB54F4632C6EF6, p0, p1); }
		public static void TRACK_OBJECT_VISIBILITY(Object _object) { Function.Call(0xB252BC036B525623, _object); }
		public static BOOL IS_OBJECT_VISIBLE(Object _object) { return Function.Call<BOOL>(0x8B32ACE6326A7546, _object); }
		public static void _0xEB6F1A9B5510A5D2(Any p0, BOOL p1) { Function.Call(0xEB6F1A9B5510A5D2, p0, p1); }
		public static void ALLOW_DAMAGE_EVENTS_FOR_NON_NETWORKED_OBJECTS(BOOL enabled) { Function.Call(0xE2B3B852B537C398, enabled); }
		public static void _0x6579860A5558524A(Any p0, Any p1) { Function.Call(0x6579860A5558524A, p0, p1); }
		public static void _0xDFA1237F5228263F(Any p0, Any p1) { Function.Call(0xDFA1237F5228263F, p0, p1); }
		public static float _GET_LIGHT_INTENSITY_FROM_OBJECT(Object _object) { return Function.Call<float>(0xFA3B61EC249B4674, _object); }
		public static void _SET_LIGHT_INTENSITY_FOR_OBJECT(Object _object, float lightIntensity) { Function.Call(0xF49574E2332A8F06, _object, lightIntensity); }
		public static void _SET_LIGHT_TRANSLUCENCY_FOR_OBJECT(Object _object, float value) { Function.Call(0x63E39F09310F481F, _object, value); }
		public static void _SET_LIGHT_SCATTERING_DISABLED_FOR_OBJECT(Object _object, BOOL disable) { Function.Call(0x04D1D4E411CE52D0, _object, disable); }
		public static void _0x7FCD49388BC9B775(Any p0, Any p1) { Function.Call(0x7FCD49388BC9B775, p0, p1); }
		public static Any _0xFA99E8E575F2FEF8(Any p0) { return Function.Call<Any>(0xFA99E8E575F2FEF8, p0); }
		public static Object GET_RAYFIRE_MAP_OBJECT(float x, float y, float z, float radius, string name) { return Function.Call<Object>(0xB48FCED898292E52, x, y, z, radius, name); }
		public static void SET_STATE_OF_RAYFIRE_MAP_OBJECT(Object _object, int state) { Function.Call(0x5C29F698D404C5E1, _object, state); }
		public static int GET_STATE_OF_RAYFIRE_MAP_OBJECT(Object _object) { return Function.Call<int>(0x899BA936634A322E, _object); }
		public static BOOL DOES_RAYFIRE_MAP_OBJECT_EXIST(Object _object) { return Function.Call<BOOL>(0x52AF537A0C5B8AAD, _object); }
		public static float GET_RAYFIRE_MAP_OBJECT_ANIM_PHASE(Object _object) { return Function.Call<float>(0x260EE4FDBDF4DB01, _object); }
		public static int CREATE_PICKUP(Hash pickupHash, float x, float y, float z, int flags, int p5, BOOL p6, Hash modelHash, int p8, float p9, Any p10) { return Function.Call<int>(0xFBA08C503DD5FA58, pickupHash, x, y, z, flags, p5, p6, modelHash, p8, p9, p10); }
		public static int CREATE_PICKUP_ROTATE(Hash pickupHash, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, int flags, int p8, int p9, BOOL p10, Hash modelHash, int p12, float p13, Any p14) { return Function.Call<int>(0x891804727E0A98B7, pickupHash, posX, posY, posZ, rotX, rotY, rotZ, flags, p8, p9, p10, modelHash, p12, p13, p14); }
		public static Object CREATE_AMBIENT_PICKUP(Hash pickupHash, float x, float y, float z, int flags, int value, Hash modelHash, BOOL p7, BOOL p8, int p9, float p10) { return Function.Call<Object>(0x673966A0C0FD7171, pickupHash, x, y, z, flags, value, modelHash, p7, p8, p9, p10); }
		public static Object CREATE_PORTABLE_PICKUP(Hash pickupHash, float x, float y, float z, BOOL placeOnGround, Hash modelHash) { return Function.Call<Object>(0x2EAF1FDB2FB55698, pickupHash, x, y, z, placeOnGround, modelHash); }
		public static void ATTACH_PORTABLE_PICKUP_TO_PED(Object pickupObject, int ped) { Function.Call(0x8DC39368BDD57755, pickupObject, ped); }
		public static void DETACH_PORTABLE_PICKUP_FROM_PED(Object pickupObject) { Function.Call(0xCF463D1E9A0AECB1, pickupObject); }
		public static void _HIDE_PICKUP_OBJECT(Object pickupObject, BOOL toggle) { Function.Call(0x2777150CC7D9365E, pickupObject, toggle); }
		public static void SET_MAX_NUM_PORTABLE_PICKUPS_CARRIED_BY_PLAYER(Hash modelHash, int p1) { Function.Call(0x0BF3B3BD47D79C08, modelHash, p1); }
		public static Any _0x3E2616E7EA539480(Any p0) { return Function.Call<Any>(0x3E2616E7EA539480, p0); }
		public static void SET_LOCAL_PLAYER_CAN_COLLECT_PORTABLE_PICKUPS(BOOL toggle) { Function.Call(0x78857FC65CADB909, toggle); }
		public static Vector3 GET_SAFE_PICKUP_COORDS(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5) { return Function.Call<Vector3>(0x6E16BC2503FF1FF0, p0, p1, p2, p3, p4, p5); }
		public static Vector3 GET_PICKUP_COORDS(int pickup) { return Function.Call<Vector3>(0x225B8B35C88029B3, pickup); }
		public static void REMOVE_ALL_PICKUPS_OF_TYPE(Hash pickupHash) { Function.Call(0x27F9D613092159CF, pickupHash); }
		public static BOOL HAS_PICKUP_BEEN_COLLECTED(int pickup) { return Function.Call<BOOL>(0x80EC48E6679313F9, pickup); }
		public static void REMOVE_PICKUP(int pickup) { Function.Call(0x3288D8ACAECD2AB2, pickup); }
		public static void SET_PICKUP_DO_NOT_AUTO_PLACE_ON_GROUND(Object pickupObject) { Function.Call(0x634C19521485AB25, pickupObject); }
		public static BOOL DOES_PICKUP_EXIST(int pickup) { return Function.Call<BOOL>(0xAFC1CA75AD4074D1, pickup); }
		public static BOOL DOES_PICKUP_OBJECT_EXIST(Object pickupObject) { return Function.Call<BOOL>(0xD9EFB6DBF7DAAEA3, pickupObject); }
		public static Object GET_PICKUP_OBJECT(int pickup) { return Function.Call<Object>(0x5099BC55630B25AE, pickup); }
		public static BOOL IS_OBJECT_A_PORTABLE_PICKUP(Object _object) { return Function.Call<BOOL>(0x0378C08504160D0D, _object); }
		public static BOOL _IS_PICKUP_TYPE_VALID(Hash pickupHash) { return Function.Call<BOOL>(0x007BD043587F7C82, pickupHash); }
		public static BOOL DOES_PICKUP_OF_TYPE_EXIST_IN_AREA(Hash pickupHash, float x, float y, float z, float radius) { return Function.Call<BOOL>(0xF9C36251F6E48E33, pickupHash, x, y, z, radius); }
		public static void SET_PICKUP_REGENERATION_TIME(int pickup, int duration) { Function.Call(0x78015C9B4B3ECC9D, pickup, duration); }
		public static void FORCE_PICKUP_REGENERATE(Any p0) { Function.Call(0x758A5C1B3B1E1990, p0); }
		public static void _0x94F3D956BFAEAE18(Any p0, Any p1, Any p2) { Function.Call(0x94F3D956BFAEAE18, p0, p1, p2); }
		public static void _SET_LOCAL_PLAYER_CAN_USE_PICKUPS_WITH_THIS_MODEL(Hash modelHash, BOOL toggle) { Function.Call(0x88EAEC617CD26926, modelHash, toggle); }
		public static void BLOCK_PICKUP_FROM_PLAYER_COLLECTION(Any p0, Any p1) { Function.Call(0xB8F5062070BB6DBD, p0, p1); }
		public static void SET_PICKUP_NOT_LOOTABLE(Any p0, Any p1) { Function.Call(0x92E87F60F21A0C3A, p0, p1); }
		public static void _0x1F5E07E14A86FAFC(Any p0) { Function.Call(0x1F5E07E14A86FAFC, p0); }
		public static void SET_TEAM_PICKUP_OBJECT(Object _object, Any p1, BOOL p2) { Function.Call(0x53E0DF1A2A3CF0CA, _object, p1, p2); }
		public static Any _0x9F52AD67D1A91BAD(Any p0, Any p1) { return Function.Call<Any>(0x9F52AD67D1A91BAD, p0, p1); }
		public static void PREVENT_COLLECTION_OF_PORTABLE_PICKUP(Object _object, BOOL p1, BOOL p2) { Function.Call(0x92AEFB5F6E294023, _object, p1, p2); }
		public static void SET_PICKUP_GENERATION_RANGE_MULTIPLIER(float multiplier) { Function.Call(0x318516E02DE3ECE2, multiplier); }
		public static void SET_PICKUP_UNCOLLECTABLE(Any p0, Any p1) { Function.Call(0x4A8CB328CD6F1C9B, p0, p1); }
		public static void SET_PICKUP_HIDDEN_WHEN_UNCOLLECTABLE(Any p0, Any p1) { Function.Call(0x81218CE01B672219, p0, p1); }
		public static void _SET_AMBIENT_PICKUP_LIFETIME(int lifetime) { Function.Call(0xAC9AE68F0A463752, lifetime); }
		public static void SET_PICKUP_PARTICLE_FX_SPAWN(Any p0, Any p1) { Function.Call(0xEB9740A38FD6D634, p0, p1); }
		public static void SET_PICKUP_PARTICLE_FX_HIGHLIGHT(Any p0, Any p1) { Function.Call(0x1607C7D9B3021DF5, p0, p1); }
		public static void SUPPRESS_PICKUP_REWARD_TYPE(int rewardType, BOOL suppress) { Function.Call(0xF92099527DB8E2A7, rewardType, suppress); }
		public static Any _0x20135AF9C10D2A3D(Any p0) { return Function.Call<Any>(0x20135AF9C10D2A3D, p0); }
		public static void _SET_PICKUP_COLLECTABLE_ON_MOUNT(Object _object) { Function.Call(0x00EE08603EADEE92, _object); }
		public static void _0xDE116ECFFDD4B997(Any p0, Any p1) { Function.Call(0xDE116ECFFDD4B997, p0, p1); }
		public static Hash GET_WEAPON_TYPE_FROM_PICKUP_TYPE(Hash pickupHash) { return Function.Call<Hash>(0x08F96CA6C551AD51, pickupHash); }
		public static Hash _GET_AMMO_TYPE_FROM_PICKUP_TYPE(Hash pickupHash) { return Function.Call<Hash>(0x44B09A23D728045A, pickupHash); }
		public static void _SET_OBJECT_TEXTURE_VARIATION(Object _object, int textureVariation) { Function.Call(0x971DA0055324D033, _object, textureVariation); }
		public static Any _0x3397CD4E0353DFBA(Any p0) { return Function.Call<Any>(0x3397CD4E0353DFBA, p0); }
		public static void _SET_OBJECT_BURN_OPACITY(Object _object, float opacity) { Function.Call(0x7D7285EFEAB5AF15, _object, opacity); }
		public static void _SET_OBJECT_BURN_INTENSITY(Object _object, float intensity) { Function.Call(0xC8E21C1677DC5E6F, _object, intensity); }
		public static void _SET_OBJECT_BURN_LEVEL(Object _object, float burnLevel, BOOL affectAsh) { Function.Call(0x2797C633DCDBBAC5, _object, burnLevel, affectAsh); }
		public static void _0x9A74A9CADFA8A598(Any p0) { Function.Call(0x9A74A9CADFA8A598, p0); }
		public static void _RESET_OBJECT_VELOCITY(Object _object) { Function.Call(0xF40AB58D83C35027, _object); }
		public static void _SET_OBJECT_BURN_SPEED(Object _object, float speed, float p2) { Function.Call(0x646564A3B7DF68F8, _object, speed, p2); }
		public static void _0xCBFBD38F2E0A263B(Any p0, Any p1) { Function.Call(0xCBFBD38F2E0A263B, p0, p1); }
		public static Hash _GET_PICKUP_HASH(Hash pickupHash) { return Function.Call<Hash>(0x5EAAD83F8CFB4575, pickupHash); }
		public static void SET_FORCE_OBJECT_THIS_FRAME(float x, float y, float z, float p3) { Function.Call(0xF538081986E49E9D, x, y, z, p3); }
		public static Any _0xD91E55B6C005EB09(Any p0, Any p1) { return Function.Call<Any>(0xD91E55B6C005EB09, p0, p1); }
		public static void _MARK_OBJECT_FOR_DELETION(Object _object) { Function.Call(0xADBE4809F19F927A, _object); }
		public static void _0xCAAF2BCCFEF37F77(Object _object, Any p1) { Function.Call(0xCAAF2BCCFEF37F77, _object, p1); }
		public static Any _0x08C5825A2932EA7B(Any p0) { return Function.Call<Any>(0x08C5825A2932EA7B, p0); }
		public static Any _0x7D4411D6736CD295(Any p0, Any p1) { return Function.Call<Any>(0x7D4411D6736CD295, p0, p1); }
		public static Any _0x250EBB11E81A10BE(Any p0) { return Function.Call<Any>(0x250EBB11E81A10BE, p0); }
		public static Any _0x2BF1953C0C21AC88(Any p0) { return Function.Call<Any>(0x2BF1953C0C21AC88, p0); }
		public static BOOL CREATE_OBJECT_SKELETON(Object _object) { return Function.Call<BOOL>(0xB6CBD40F8EA69E8A, _object); }
		public static void _MAKE_ITEM_CARRIABLE(Object _object) { Function.Call(0x1461DF6DB886BE3F, _object); }
		public static void _0xF65EDE5D02A7A760(Any p0, Any p1) { Function.Call(0xF65EDE5D02A7A760, p0, p1); }
		public static void _SET_AUTO_JUMPABLE_BY_HORSE(Object _object, BOOL p1) { Function.Call(0x98D2D9C053A1F449, _object, p1); }
		public static void _SET_NOT_JUMPABLE_BY_HORSE(Object _object, BOOL p1) { Function.Call(0xE1C708BA4885796B, _object, p1); }
		public static void _SET_OBJECT_KICKABLE(Object _object, BOOL kickable) { Function.Call(0xB7017DA4D498269F, _object, kickable); }
		public static void SET_CUSTOM_TEXTURES_ON_OBJECT(Object _object, Hash txdHash, Any p2, Any p3) { Function.Call(0xE124889AE0521FCF, _object, txdHash, p2, p3); }
		public static void _0xD503D6F0986D58BC(Any p0, Any p1) { Function.Call(0xD503D6F0986D58BC, p0, p1); }
		public static void _0xAEE6C800E124CFE1(Any p0, Any p1) { Function.Call(0xAEE6C800E124CFE1, p0, p1); }
		public static void _0x3DF1A0A58498E209(Object _object, Any p1) { Function.Call(0x3DF1A0A58498E209, _object, p1); }
	}

	public static class PAD
	{
		public static void _SET_CONTROL_CONTEXT(int p0, Hash context) { Function.Call(0x2804658EB7D8A50B, p0, context); }
		public static Any _0xDDCEB0F26C89C00F(int p0) { return Function.Call<Any>(0xDDCEB0F26C89C00F, p0); }
		public static BOOL _IS_CONTROL_ACTION_VALID(Hash control, int padIndex) { return Function.Call<BOOL>(0xBC0884BC590951C7, control, padIndex); }
		public static BOOL IS_CONTROL_ENABLED(int padIndex, Hash control) { return Function.Call<BOOL>(0x1CEA6BFDF248E5D9, padIndex, control); }
		public static BOOL IS_CONTROL_PRESSED(int padIndex, Hash control) { return Function.Call<BOOL>(0xF3A21BCD95725A4A, padIndex, control); }
		public static BOOL IS_CONTROL_RELEASED(int padIndex, Hash control) { return Function.Call<BOOL>(0x648EE3E7F38877DD, padIndex, control); }
		public static BOOL IS_CONTROL_JUST_PRESSED(int padIndex, Hash control) { return Function.Call<BOOL>(0x580417101DDB492F, padIndex, control); }
		public static BOOL IS_CONTROL_JUST_RELEASED(int padIndex, Hash control) { return Function.Call<BOOL>(0x50F940259D3841E6, padIndex, control); }
		public static int GET_CONTROL_VALUE(int padIndex, Hash control) { return Function.Call<int>(0xD95E79E8686D2C27, padIndex, control); }
		public static float GET_CONTROL_NORMAL(int padIndex, Hash control) { return Function.Call<float>(0xEC3C9B8D5327B563, padIndex, control); }
		public static float GET_CONTROL_UNBOUND_NORMAL(int padIndex, Hash control) { return Function.Call<float>(0x5B84D09CEC5209C5, padIndex, control); }
		public static BOOL _SET_CONTROL_NORMAL(int padIndex, Hash control, float amount) { return Function.Call<BOOL>(0xE8A25867FBA3B05E, padIndex, control, amount); }
		public static BOOL IS_DISABLED_CONTROL_PRESSED(int padIndex, Hash control) { return Function.Call<BOOL>(0xE2587F8CBBD87B1D, padIndex, control); }
		public static BOOL IS_DISABLED_CONTROL_JUST_PRESSED(int padIndex, Hash control) { return Function.Call<BOOL>(0x91AEF906BCA88877, padIndex, control); }
		public static BOOL IS_DISABLED_CONTROL_JUST_RELEASED(int padIndex, Hash control) { return Function.Call<BOOL>(0x305C8DCD79DA8B0F, padIndex, control); }
		public static float GET_DISABLED_CONTROL_NORMAL(int padIndex, Hash control) { return Function.Call<float>(0x11E65974A982637C, padIndex, control); }
		public static float GET_DISABLED_CONTROL_UNBOUND_NORMAL(int padIndex, Hash control) { return Function.Call<float>(0x4F8A26A890FD62FB, padIndex, control); }
		public static int GET_CONTROL_HOW_LONG_AGO(int p0) { return Function.Call<int>(0xD7D22F5592AED8BA, p0); }
		public static int _GET_DISABLED_CONTROL_HOW_LONG_AGO(int padIndex) { return Function.Call<int>(0x771DFCB24D19C2F6, padIndex); }
		public static BOOL _IS_USING_KEYBOARD(int padIndex) { return Function.Call<BOOL>(0xA571D46727E2B718, padIndex); }
		public static Any _0x43F35DDB2905D945(Any p0, Any p1) { return Function.Call<Any>(0x43F35DDB2905D945, p0, p1); }
		public static Any _0xBD629C1C4F501C80(Any p0) { return Function.Call<Any>(0xBD629C1C4F501C80, p0); }
		public static BOOL _0x6CD79468A1E595C6(int padIndex) { return Function.Call<BOOL>(0x6CD79468A1E595C6, padIndex); }
		public static void SET_CONTROL_LIGHT_EFFECT_COLOR(int padIndex, int red, int green, int blue) { Function.Call(0x8290252FFF36ACB5, padIndex, red, green, blue); }
		public static void _0xCB0360EFEFB2580D(int padIndex) { Function.Call(0xCB0360EFEFB2580D, padIndex); }
		public static void SET_CONTROL_LIGHT_EFFECT_FLASHING_COLOR(Any p0, Any p1, Any p2, Any p3) { Function.Call(0xA45884DB10EC7EE3, p0, p1, p2, p3); }
		public static void SET_PAD_SHAKE(int padIndex, int duration, int frequency) { Function.Call(0x48B3886C1358D0D5, padIndex, duration, frequency); }
		public static void _0x14D29BB12D47F68C(Any p0, Any p1, Any p2, Any p3, Any p4) { Function.Call(0x14D29BB12D47F68C, p0, p1, p2, p3, p4); }
		public static void STOP_PAD_SHAKE(int padIndex) { Function.Call(0x38C16A305E8CDC8D, padIndex); }
		public static void SET_PAD_SHAKE_SUPPRESSED_ID(int padIndex, int p1) { Function.Call(0xF239400E16C23E08, padIndex, p1); }
		public static void _CLEAR_SUPPRESSED_PAD_RUMBLE(int p0) { Function.Call(0xA0CEFCEA390AAB9B, p0); }
		public static BOOL IS_LOOK_INVERTED() { return Function.Call<BOOL>(0x77B612531280010D); }
		public static void SET_INPUT_EXCLUSIVE(int padIndex, Hash control) { Function.Call(0xEDE476E5EE29EDB1, padIndex, control); }
		public static void DISABLE_CONTROL_ACTION(int padIndex, Hash control, BOOL disable) { Function.Call(0xFE99B66D079CF6BC, padIndex, control, disable); }
		public static void ENABLE_CONTROL_ACTION(int padIndex, Hash control, BOOL enable) { Function.Call(0x351220255D64C155, padIndex, control, enable); }
		public static void DISABLE_ALL_CONTROL_ACTIONS(int padIndex) { Function.Call(0x5F4B6931816E599B, padIndex); }
		public static void _0x5F217BC1190503D8(string rumbleCurve, float p1) { Function.Call(0x5F217BC1190503D8, rumbleCurve, p1); }
		public static void _0x709BA8C08C5C008D() { Function.Call(0x709BA8C08C5C008D); }
		public static BOOL _0x1252C029FC8EBB4D() { return Function.Call<BOOL>(0x1252C029FC8EBB4D); }
		public static void _0x52C68E92D6E23ADD(Any p0) { Function.Call(0x52C68E92D6E23ADD, p0); }
	}

	public static class PATHFIND
	{
		public static void SET_ROADS_IN_AREA(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8) { Function.Call(0xBF1A602B5BA52FEE, p0, p1, p2, p3, p4, p5, p6, p7, p8); }
		public static void SET_ROADS_IN_ANGLED_AREA(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8, Any p9, Any p10) { Function.Call(0x1A5AA1208AF5DB59, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10); }
		public static void SET_ROADS_IN_VOLUME(Volume volume, BOOL p1, BOOL p2, BOOL p3) { Function.Call(0xC1799FAFD2FDF52B, volume, p1, p2, p3); }
		public static void RESET_ROADS_IN_VOLUME(Volume volume, BOOL p1) { Function.Call(0xD17672447692478E, volume, p1); }
		public static void SET_ROADS_BACK_TO_ORIGINAL(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7) { Function.Call(0x1EE7063B80FFC77C, p0, p1, p2, p3, p4, p5, p6, p7); }
		public static void SET_ROADS_BACK_TO_ORIGINAL_IN_ANGLED_AREA(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8) { Function.Call(0x0027501B9F3B407E, p0, p1, p2, p3, p4, p5, p6, p7, p8); }
		public static void _0xAFE2AE66F6251C66(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7) { Function.Call(0xAFE2AE66F6251C66, p0, p1, p2, p3, p4, p5, p6, p7); }
		public static void _0x4358BCF14C91761C(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8, Any p9) { Function.Call(0x4358BCF14C91761C, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9); }
		public static void _0xB03944057FD735BA(Any p0, Any p1, Any p2) { Function.Call(0xB03944057FD735BA, p0, p1, p2); }
		public static void _0x6C3F12ECEB6D2E2A(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7) { Function.Call(0x6C3F12ECEB6D2E2A, p0, p1, p2, p3, p4, p5, p6, p7); }
		public static void _0x5A4E1A41E3A02AD0(Any p0, Any p1, Any p2) { Function.Call(0x5A4E1A41E3A02AD0, p0, p1, p2); }
		public static unsafe BOOL GET_CLOSEST_VEHICLE_NODE(float x, float y, float z, Vector3* _outPosition, int nodeType, float p5, float p6) { return Function.Call<BOOL>(0x240A18690AE96513, x, y, z, _outPosition, nodeType, p5, p6); }
		public static Any _0xCA27A86CAA4E98ED(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6) { return Function.Call<Any>(0xCA27A86CAA4E98ED, p0, p1, p2, p3, p4, p5, p6); }
		public static unsafe BOOL GET_CLOSEST_VEHICLE_NODE_WITH_HEADING(float x, float y, float z, Vector3* _outPosition, float* _outHeading, int nodeType, float p6, int p7) { return Function.Call<BOOL>(0x23CFFD4CCB243354, x, y, z, _outPosition, _outHeading, nodeType, p6, p7); }
		public static unsafe BOOL GET_NTH_CLOSEST_VEHICLE_NODE(float x, float y, float z, int nthClosest, Vector3* _outPosition, int unknown1, float unknown2, Any unknown3) { return Function.Call<BOOL>(0x5A6D8DF6FBC5D0C4, x, y, z, nthClosest, _outPosition, unknown1, unknown2, unknown3); }
		public static int GET_NTH_CLOSEST_VEHICLE_NODE_ID(float x, float y, float z, int nth, int nodetype, float p5, float p6) { return Function.Call<int>(0x116443008E5CEFC3, x, y, z, nth, nodetype, p5, p6); }
		public static unsafe BOOL GET_NTH_CLOSEST_VEHICLE_NODE_WITH_HEADING(float x, float y, float z, int nthClosest, Vector3* _outPosition, float* heading, Any* unknown1, int unknown2, float unknown3, float unknown4) { return Function.Call<BOOL>(0x591B40D4390DB54A, x, y, z, nthClosest, _outPosition, heading, unknown1, unknown2, unknown3, unknown4); }
		public static unsafe BOOL GET_NTH_CLOSEST_VEHICLE_NODE_ID_WITH_HEADING(float x, float y, float z, int nthClosest, Vector3* _outPosition, float _outHeading, Any p6, float p7, float p8) { return Function.Call<BOOL>(0x4114EAA8A7F7766D, x, y, z, nthClosest, _outPosition, _outHeading, p6, p7, p8); }
		public static unsafe BOOL GET_NTH_CLOSEST_VEHICLE_NODE_FAVOUR_DIRECTION(float x, float y, float z, float desiredX, float desiredY, float desiredZ, int nthClosest, Vector3* _outPosition, float* _outHeading, int nodetype, Any p10, Any p11) { return Function.Call<BOOL>(0x2FAC235A6062F14A, x, y, z, desiredX, desiredY, desiredZ, nthClosest, _outPosition, _outHeading, nodetype, p10, p11); }
		public static BOOL IS_VEHICLE_NODE_ID_VALID(int vehicleNodeId) { return Function.Call<BOOL>(0x5829A02AF4F0B3CB, vehicleNodeId); }
		public static unsafe void GET_VEHICLE_NODE_POSITION(int nodeId, Vector3* _outPosition) { Function.Call(0x8E8D72FF24DEE1FB, nodeId, _outPosition); }
		public static BOOL GET_VEHICLE_NODE_IS_SWITCHED_OFF(int nodeID) { return Function.Call<BOOL>(0x28533DBDDF7C2C97, nodeID); }
		public static unsafe Any GET_CLOSEST_ROAD(float x, float y, float z, float p3, int p4, Vector3* p5, Vector3* p6, Any* p7, Any* p8, float* p9, BOOL p10) { return Function.Call<Any>(0x132F52BBA570FE92, x, y, z, p3, p4, p5, p6, p7, p8, p9, p10); }
		public static BOOL ARE_NODES_LOADED_FOR_AREA(float x1, float y1, float x2, float y2) { return Function.Call<BOOL>(0xF7B79A50B905A30D, x1, y1, x2, y2); }
		public static BOOL REQUEST_PATHS_PREFER_ACCURATE_BOUNDINGSTRUCT(float x1, float y1, float x2, float y2) { return Function.Call<BOOL>(0x07FB139B592FA687, x1, y1, x2, y2); }
		public static unsafe BOOL GET_RANDOM_VEHICLE_NODE(float x, float y, float z, float radius, BOOL p4, BOOL p5, BOOL p6, Vector3* _outPosition, int* nodeId) { return Function.Call<BOOL>(0x93E0DB8440B73A7D, x, y, z, radius, p4, p5, p6, _outPosition, nodeId); }
		public static unsafe void _GET_SPAWN_DATA_FOR_ROAD_NODE(int nodeId, float x, float y, float z, Vector3* _outCoords, float* heading) { Function.Call(0xA3791B915B8B84C6, nodeId, x, y, z, _outCoords, heading); }
		public static BOOL IS_POINT_ON_ROAD(float x, float y, float z, int vehicle) { return Function.Call<BOOL>(0x125BF4ABFC536B09, x, y, z, vehicle); }
		public static void SET_PED_PATHS_IN_AREA(float x1, float y1, float z1, float x2, float y2, float z2, BOOL unknown, Any p7) { Function.Call(0x34F060F4BF92E018, x1, y1, z1, x2, y2, z2, unknown, p7); }
		public static void _0xE5EF9DE716FF737E(Any p0, Any p1, Any p2) { Function.Call(0xE5EF9DE716FF737E, p0, p1, p2); }
		public static unsafe BOOL GET_SAFE_COORD_FOR_PED(float x, float y, float z, BOOL onGround, Vector3* _outPosition, int flags) { return Function.Call<BOOL>(0xB61C8E878A4199CA, x, y, z, onGround, _outPosition, flags); }
		public static void SET_PED_PATHS_BACK_TO_ORIGINAL(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6) { Function.Call(0xE04B48F2CC926253, p0, p1, p2, p3, p4, p5, p6); }
		public static void _0xCF213A5FC3ABFC08(Any p0, Any p1, Any p2) { Function.Call(0xCF213A5FC3ABFC08, p0, p1, p2); }
		public static void ADD_NAVMESH_REQUIRED_REGION(float x, float y, float radius) { Function.Call(0x387EAD7EE42F6685, x, y, radius); }
		public static BOOL IS_NAVMESH_LOADED_IN_AREA(float x1, float y1, float z1, float x2, float y2, float z2) { return Function.Call<BOOL>(0xF813C7E63F9062A5, x1, y1, z1, x2, y2, z2); }
		public static int GET_NUM_NAVMESHES_EXISTING_IN_AREA(float p0, float p1, float p2, float p3, float p4, float p5) { return Function.Call<int>(0x01708E8DD3FF8C65, p0, p1, p2, p3, p4, p5); }
		public static BOOL _NAVMESH_ACTIVATE_SWAP(string name) { return Function.Call<BOOL>(0x7C334FF4D9215912, name); }
		public static BOOL _NAVMESH_DEACTIVATE_SWAP(string name) { return Function.Call<BOOL>(0x527B97C203BB8606, name); }
		public static BOOL _NAVMESH_IS_SWAP_ACTIVE(string name) { return Function.Call<BOOL>(0x5AC0944C156E5F44, name); }
		public static BOOL _NAVMESH_DOES_SWAP_EXIST(string name) { return Function.Call<BOOL>(0x495CFAB2924237C7, name); }
		public static int _0x5A3B54ADDF5472A3(string p0) { return Function.Call<int>(0x5A3B54ADDF5472A3, p0); }
		public static BOOL _NAVMESH_ASSIGN_NAVMESH_TO_VEHICLE(int vehicle, string navMeshName) { return Function.Call<BOOL>(0x44026E3DB3CED602, vehicle, navMeshName); }
		public static Any ADD_NAVMESH_BLOCKING_OBJECT(float p0, float p1, float p2, float p3, float p4, float p5, float p6, BOOL p7, Any p8) { return Function.Call<Any>(0xFCD5C8E06E502F5A, p0, p1, p2, p3, p4, p5, p6, p7, p8); }
		public static void REMOVE_NAVMESH_BLOCKING_OBJECT(Any p0) { Function.Call(0x46399A7895957C0E, p0); }
		public static BOOL DOES_NAVMESH_BLOCKING_OBJECT_EXIST(Any p0) { return Function.Call<BOOL>(0x0EAEB0DB4B132399, p0); }
		public static BOOL _ADD_NAVMESH_BLOCKING_VOLUME(Volume volume, int flags) { return Function.Call<BOOL>(0x19C7567D2F2287D6, volume, flags); }
		public static void _REMOVE_NAVMESH_BLOCKING_VOLUME(Volume volume) { Function.Call(0x2C87C3E1C7B96EE2, volume); }
		public static BOOL _DOES_NAVMESH_BLOCKING_VOLUME_EXIST(Volume volume) { return Function.Call<BOOL>(0xDE0EA444735C1368, volume); }
		public static void _0x6DAD6630AE4A74CB(Any p0, Any p1) { Function.Call(0x6DAD6630AE4A74CB, p0, p1); }
		public static Any NAVMESH_REQUEST_PATH(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7) { return Function.Call<Any>(0x348F211CA2404039, p0, p1, p2, p3, p4, p5, p6, p7); }
		public static Any _0x661BB1E1FF77742D(Any p0) { return Function.Call<Any>(0x661BB1E1FF77742D, p0); }
		public static int _NAVMESH_QUERY_STATUS(Any p0) { return Function.Call<int>(0x3A0F82F6EE2291C8, p0); }
		public static Any _0x8800776E410EB669(Any p0) { return Function.Call<Any>(0x8800776E410EB669, p0); }
		public static Any _0xF61CFEDEAB627BFA(Any p0) { return Function.Call<Any>(0xF61CFEDEAB627BFA, p0); }
		public static Any _0xD470725E0703D22F(Any p0) { return Function.Call<Any>(0xD470725E0703D22F, p0); }
		public static Vector3 _0x430F8319AE56C8A9(Any p0, Any p1) { return Function.Call<Vector3>(0x430F8319AE56C8A9, p0, p1); }
		public static float GET_APPROX_FLOOR_FOR_POINT(float x, float y) { return Function.Call<float>(0x336511A34F2E5185, x, y); }
		public static void SET_AMBIENT_PED_RANGE_MULTIPLIER_THIS_FRAME(float multiplier) { Function.Call(0x0B919E1FB47CC4E0, multiplier); }
		public static void SET_IGNORE_NO_GPS_FLAG(BOOL toggle) { Function.Call(0x72751156E7678833, toggle); }
		public static int GET_GPS_BLIP_ROUTE_LENGTH() { return Function.Call<int>(0xBBB45C3CF5C8AA85); }
		public static Any _0xEFC535C9FAF563B3(Any p0) { return Function.Call<Any>(0xEFC535C9FAF563B3, p0); }
		public static Any _0x665B21666351CB37(Any p0, Any p1, Any p2) { return Function.Call<Any>(0x665B21666351CB37, p0, p1, p2); }
		public static BOOL GET_GPS_BLIP_ROUTE_FOUND() { return Function.Call<BOOL>(0x869DAACBBE9FA006); }
		public static Any _0x54F4D7B6670FBB5A(Any p0, Any p1, Any p2, Any p3, Any p4) { return Function.Call<Any>(0x54F4D7B6670FBB5A, p0, p1, p2, p3, p4); }
		public static void _0x34C9AF25649172D0(Any p0) { Function.Call(0x34C9AF25649172D0, p0); }
		public static void _0xF2A2177AC848B3A8(Volume volume, int p1, int p2) { Function.Call(0xF2A2177AC848B3A8, volume, p1, p2); }
		public static void _0x4BDEBEA5702B97A9(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5) { Function.Call(0x4BDEBEA5702B97A9, p0, p1, p2, p3, p4, p5); }
		public static void _0x264E9A5CD78C338F(Any p0) { Function.Call(0x264E9A5CD78C338F, p0); }
		public static void _0x869A7015BD4606E9(Any p0) { Function.Call(0x869A7015BD4606E9, p0); }
		public static Any _SIMULATED_ROUTE_CREATE(float x1, float y1, float z1, float x2, float y2, float z2, int p6) { return Function.Call<Any>(0xFD5BB35AAB83FD48, x1, y1, z1, x2, y2, z2, p6); }
		public static void _SIMULATED_ROUTE_DELETE(Any p0) { Function.Call(0x4907D0E4FB26EE65, p0); }
		public static BOOL _SIMULATED_ROUTE_EXISTS(Any p0) { return Function.Call<BOOL>(0x65A8196B8D7F5E0B, p0); }
		public static BOOL SIMULATED_ROUTE_IS_LOADED(Any p0) { return Function.Call<BOOL>(0x240915043CB799D7, p0); }
		public static void SIMULATED_ROUTE_TRAVEL_TO_POINT(Any p0, float p1, float p2) { Function.Call(0xA1A3DE1C215C7394, p0, p1, p2); }
		public static float SIMULATED_ROUTE_GET_ETA(Any p0) { return Function.Call<float>(0x2DD5F78D73B24172, p0); }
	}

	public static class PED
	{
		public static int CREATE_PED(Hash modelHash, float x, float y, float z, float heading, BOOL isNetwork, BOOL bScriptHostPed, BOOL p7, BOOL p8) { return Function.Call<int>(0xD49F9B0955C367DE, modelHash, x, y, z, heading, isNetwork, bScriptHostPed, p7, p8); }
		public static unsafe void DELETE_PED(int* ped) { Function.Call(0xCC0EF140F99365C5, ped); }
		public static void _SET_REMOVE_PED_NETWORKED(int ped, int p1) { Function.Call(0x39A2FC5AF55A52B1, ped, p1); }
		public static void _0x7C08E7CB8D951B70(int ped, float p1) { Function.Call(0x7C08E7CB8D951B70, ped, p1); }
		public static void _SET_PED_TO_BE_REMOVED(int ped, float p1, float p2, int p3, Any p4) { Function.Call(0x36E4B61DC56DE77C, ped, p1, p2, p3, p4); }
		public static int CLONE_PED(int ped, BOOL isNetwork, BOOL bScriptHostPed, BOOL copyHeadBlendFlag) { return Function.Call<int>(0xEF29A16337FACADB, ped, isNetwork, bScriptHostPed, copyHeadBlendFlag); }
		public static void CLONE_PED_TO_TARGET(int ped, int targetPed) { Function.Call(0xE952D6431689AD9A, ped, targetPed); }
		public static BOOL IS_PED_IN_VEHICLE(int ped, int vehicle, BOOL atGetIn) { return Function.Call<BOOL>(0xA3EE4A07279BB9DB, ped, vehicle, atGetIn); }
		public static BOOL IS_PED_IN_MODEL(int ped, Hash modelHash) { return Function.Call<BOOL>(0x796D90EFB19AA332, ped, modelHash); }
		public static BOOL IS_PED_IN_ANY_VEHICLE(int ped, BOOL atGetIn) { return Function.Call<BOOL>(0x997ABD671D25CA0B, ped, atGetIn); }
		public static void _0x9851DE7AEC10B4E1(float x, float y, float z, float p3, int p4, Any p5) { Function.Call(0x9851DE7AEC10B4E1, x, y, z, p3, p4, p5); }
		public static BOOL IS_PED_INJURED(int ped) { return Function.Call<BOOL>(0x84A2DD9AC37C35C1, ped); }
		public static BOOL IS_PED_FATALLY_INJURED(int ped) { return Function.Call<BOOL>(0xD839450756ED5A80, ped); }
		public static BOOL IS_PED_DEAD_OR_DYING(int ped, BOOL p1) { return Function.Call<BOOL>(0x3317DEDB88C95038, ped, p1); }
		public static void _SET_PED_BLEEDOUT_PROFILE(int ped, Hash bleedoutProfile) { Function.Call(0x66C047719B0E80E1, ped, bleedoutProfile); }
		public static BOOL IS_PED_AIMING_FROM_COVER(int ped) { return Function.Call<BOOL>(0x3998B1276A3300E5, ped); }
		public static BOOL IS_PED_RELOADING(int ped) { return Function.Call<BOOL>(0x24B100C68C645951, ped); }
		public static BOOL IS_PED_A_PLAYER(int ped) { return Function.Call<BOOL>(0x12534C348C6CB68B, ped); }
		public static BOOL _IS_ANIMAL_CONTROLLED_BY_A_PLAYER(int ped) { return Function.Call<BOOL>(0x0E2F43516F998269, ped); }
		public static int CREATE_PED_INSIDE_VEHICLE(int vehicle, Hash modelHash, int seatIndex, BOOL p3, BOOL p4, BOOL p5) { return Function.Call<int>(0x7DD959874C1FD534, vehicle, modelHash, seatIndex, p3, p4, p5); }
		public static void SET_PED_DESIRED_HEADING(int ped, float heading) { Function.Call(0xAA5A7ECE2AA8FE70, ped, heading); }
		public static void _FREEZE_PED_CAMERA_ROTATION(int ped) { Function.Call(0xFF287323B0E2C69A, ped); }
		public static BOOL IS_PED_FACING_PED(int ped, int otherPed, float angle) { return Function.Call<BOOL>(0xD71649DB0A545AA3, ped, otherPed, angle); }
		public static BOOL IS_PED_IN_MELEE_COMBAT(int ped) { return Function.Call<BOOL>(0x4E209B2C1EAD5159, ped); }
		public static Any _0x6DB875AFC584FA32(int ped, int p1) { return Function.Call<Any>(0x6DB875AFC584FA32, ped, p1); }
		public static BOOL IS_PED_STOPPED(int ped) { return Function.Call<BOOL>(0x530944F6F4B8A214, ped); }
		public static BOOL IS_PED_SITTING(int ped) { return Function.Call<BOOL>(0x84D0BF2B21862059, ped); }
		public static BOOL _0x09D7AFD3716DA8E1(int ped, int p1) { return Function.Call<BOOL>(0x09D7AFD3716DA8E1, ped, p1); }
		public static BOOL _0x9C81338B2E62CE0A(int player, int ped, int shotNearRecentlyTime) { return Function.Call<BOOL>(0x9C81338B2E62CE0A, player, ped, shotNearRecentlyTime); }
		public static BOOL _0xB7DBB2986B87E230(int ped, float p1) { return Function.Call<BOOL>(0xB7DBB2986B87E230, ped, p1); }
		public static BOOL _0xD355E2F1BB41087E(int ped, float p1) { return Function.Call<BOOL>(0xD355E2F1BB41087E, ped, p1); }
		public static BOOL IS_ANY_PED_SHOOTING_IN_AREA(float x1, float y1, float z1, float x2, float y2, float z2, BOOL p6, BOOL p7) { return Function.Call<BOOL>(0xA0D3D71EA1086C55, x1, y1, z1, x2, y2, z2, p6, p7); }
		public static BOOL IS_PED_SHOOTING(int ped) { return Function.Call<BOOL>(0x34616828CD07F1A1, ped); }
		public static float TIME_SINCE_PED_LAST_SHOT(int ped) { return Function.Call<float>(0x285D36C5C72B0569, ped); }
		public static void SET_PED_ACCURACY(int ped, int accuracy) { Function.Call(0x7AEFB85C1D49DEB6, ped, accuracy); }
		public static int GET_PED_ACCURACY(int ped) { return Function.Call<int>(0x37F4AD56ECBC0CD6, ped); }
		public static BOOL IS_PED_MODEL(int ped, Hash modelHash) { return Function.Call<BOOL>(0xC9D55B1A358A5BF7, ped, modelHash); }
		public static void EXPLODE_PED_HEAD(int ped, Hash weaponHash) { Function.Call(0x2D05CED3A38D0F3A, ped, weaponHash); }
		public static void ADD_ARMOUR_TO_PED(int ped, int amount) { Function.Call(0x5BA652A0CD14DF2F, ped, amount); }
		public static void _0x5CA20FBE49891BBD(int ped, int p1) { Function.Call(0x5CA20FBE49891BBD, ped, p1); }
		public static void SET_PED_INTO_VEHICLE(int ped, int vehicle, int seatIndex) { Function.Call(0xF75B0D629E1C063D, ped, vehicle, seatIndex); }
		public static void SET_PED_MOVE_ANIMS_BLEND_OUT(int ped) { Function.Call(0x9E8C908F41584ECD, ped); }
		public static void _0x606D529DADA3C940(int ped, Any p1) { Function.Call(0x606D529DADA3C940, ped, p1); }
		public static BOOL IS_PED_MALE(int ped) { return Function.Call<BOOL>(0x6D9F5FAA7488BA46, ped); }
		public static BOOL IS_PED_HUMAN(int ped) { return Function.Call<BOOL>(0xB980061DA992779D, ped); }
		public static int GET_VEHICLE_PED_IS_IN(int ped, BOOL lastVehicle) { return Function.Call<int>(0x9A9112A0FE9A4713, ped, lastVehicle); }
		public static void RESET_PED_LAST_VEHICLE(int ped) { Function.Call(0xBB8DE8CF6A8DD8BB, ped); }
		public static void _0xC6136B40FFFB778B(BOOL p0) { Function.Call(0xC6136B40FFFB778B, p0); }
		public static void _0x6E8B87139854022D(int ped, string clipset) { Function.Call(0x6E8B87139854022D, ped, clipset); }
		public static int _GET_NUM_FREE_SLOTS_IN_PED_POOL() { return Function.Call<int>(0x313778EDCA9158E2); }
		public static void _RESERVE_AMBIENT_PEDS(int numPeds) { Function.Call(0xED9582B3DA8F02B4, numPeds); }
		public static void _RESERVE_AMBIENT_PEDS_TOTAL(int numPeds) { Function.Call(0xF008E0BA1FE1D644, numPeds); }
		public static void _UNRESERVE_AMBIENT_PEDS(int numPeds) { Function.Call(0x7D4E70A67A651C71, numPeds); }
		public static int _GET_NUM_RESERVED_AMBIENT_PEDS_DESIRED() { return Function.Call<int>(0x62DE46F061CAA468); }
		public static int _GET_NUM_RESERVED_AMBIENT_PEDS_READY() { return Function.Call<int>(0x5C16855277819BBF); }
		public static BOOL _ARE_ALL_AMBIENT_PED_RESERVATIONS_READY() { return Function.Call<BOOL>(0x5E420FF293EE5472); }
		public static void _SET_SCENARIO_PED_RANGE_MULTIPLIER_THIS_FRAME(float multiplier) { Function.Call(0xA77FA7BE9312F8C0, multiplier); }
		public static void _0x9E3842E5DAD69F80(Volume volume) { Function.Call(0x9E3842E5DAD69F80, volume); }
		public static void _SET_AMBIENT_PED_DENSITY_MULTIPLIER_THIS_FRAME(float multiplier) { Function.Call(0xAB0D553FE20A6E25, multiplier); }
		public static void SET_SCENARIO_PED_DENSITY_MULTIPLIER_THIS_FRAME(float multiplier) { Function.Call(0x7A556143A1C03898, multiplier); }
		public static void _SET_AMBIENT_ANIMAL_DENSITY_MULTIPLIER_THIS_FRAME(float multiplier) { Function.Call(0xC0258742B034DFAF, multiplier); }
		public static void _SET_AMBIENT_HUMAN_DENSITY_MULTIPLIER_THIS_FRAME(float multiplier) { Function.Call(0xBA0980B5C0A11924, multiplier); }
		public static void _SET_SCENARIO_ANIMAL_DENSITY_MULTIPLIER_THIS_FRAME(float multiplier) { Function.Call(0xDB48E99F8E064E56, multiplier); }
		public static void _SET_SCENARIO_HUMAN_DENSITY_MULTIPLIER_THIS_FRAME(float multiplier) { Function.Call(0x28CB6391ACEDD9DB, multiplier); }
		public static void _SET_SCENARIO_PED_DENSITY_THIS_FRAME(Hash configHash) { Function.Call(0x95423627A9CA598E, configHash); }
		public static void INSTANTLY_FILL_PED_POPULATION() { Function.Call(0x4759CC730F947C81); }
		public static void _0xBFA6B7731C3BAF02() { Function.Call(0xBFA6B7731C3BAF02); }
		public static BOOL IS_INSTANTLY_FILL_PED_POPULATION_FINISHED() { return Function.Call<BOOL>(0x0EE3F0D7FECCC54F); }
		public static void SET_PED_NON_CREATION_AREA(float x1, float y1, float z1, float x2, float y2, float z2) { Function.Call(0xEE01041D559983EA, x1, y1, z1, x2, y2, z2); }
		public static void CLEAR_PED_NON_CREATION_AREA() { Function.Call(0x2E05208086BA0651); }
		public static void _ATTACH_VOLUME_TO_ENTITY(Volume volume, int entity, float offsetX, float offsetY, float offsetZ, float rotX, float rotY, float rotZ, int p8, BOOL p9) { Function.Call(0x7C00CFC48A782DC0, volume, entity, offsetX, offsetY, offsetZ, rotX, rotY, rotZ, p8, p9); }
		public static void _DETACH_VOLUME_FROM_ENTITY(Volume volume, int entity) { Function.Call(0x19C975B81BE53C28, volume, entity); }
		public static void SET_PED_ONTO_MOUNT(int ped, int mount, int seatIndex, BOOL p3) { Function.Call(0x028F76B6E78246EB, ped, mount, seatIndex, p3); }
		public static void _REMOVE_PED_FROM_MOUNT(int ped, BOOL p1, BOOL p2) { Function.Call(0x5337B721C51883A9, ped, p1, p2); }
		public static int CREATE_PED_ON_MOUNT(int mount, Hash modelHash, int index, BOOL p3, BOOL p4, BOOL p5, BOOL p6) { return Function.Call<int>(0xF89AA2BD01FC06B7, mount, modelHash, index, p3, p4, p5, p6); }
		public static BOOL _IS_MOUNT_SEAT_FREE(int mount, int seat) { return Function.Call<BOOL>(0xAAB0FE202E9FC9F0, mount, seat); }
		public static BOOL IS_PED_ON_MOUNT(int ped) { return Function.Call<BOOL>(0x460BC76A0E10655E, ped); }
		public static BOOL IS_PED_FULLY_ON_MOUNT(int ped, BOOL p1) { return Function.Call<BOOL>(0x95CBC65780DE7EB1, ped, p1); }
		public static int GET_MOUNT(int ped) { return Function.Call<int>(0xE7E11B8DCBED1058, ped); }
		public static int _GET_LAST_LED_MOUNT(int ped) { return Function.Call<int>(0x693126B5D0457D0D, ped); }
		public static int _GET_LAST_MOUNT(int ped) { return Function.Call<int>(0x4C8B59171957BCF7, ped); }
		public static void _0xED1C764997A86D5A(int ped1, int ped2) { Function.Call(0xED1C764997A86D5A, ped1, ped2); }
		public static void _0xB8AB265426CFE6DD(int ped, BOOL p1) { Function.Call(0xB8AB265426CFE6DD, ped, p1); }
		public static int _0xE8D1CCB9375C101B(int mount, int player) { return Function.Call<int>(0xE8D1CCB9375C101B, mount, player); }
		public static void _0xA691C10054275290(int mount, int player, int dismountedTimestamp) { Function.Call(0xA691C10054275290, mount, player, dismountedTimestamp); }
		public static void _0x6734F0A6A52C371C(int player, int horseSlot) { Function.Call(0x6734F0A6A52C371C, player, horseSlot); }
		public static void _0x024EC9B649111915(int ped, BOOL p1) { Function.Call(0x024EC9B649111915, ped, p1); }
		public static void SET_PED_OWNS_ANIMAL(int ped, int animal, BOOL p2) { Function.Call(0x931B241409216C1F, ped, animal, p2); }
		public static int _GET_ACTIVE_ANIMAL_OWNER(int animal) { return Function.Call<int>(0xF103823FFE72BB49, animal); }
		public static void _0xBCC76708E5677E1D(int ped, BOOL p1) { Function.Call(0xBCC76708E5677E1D, ped, p1); }
		public static int _GET_HORSE_TAMING_STATE(int horse) { return Function.Call<int>(0x454AD4DA6C41B5BD, horse); }
		public static void _0x54D3CD482742C482(int animal, float p2) { Function.Call(0x54D3CD482742C482, animal, p2); }
		public static void _0x5CB2EBB467BE3ED6(int animal, float p2) { Function.Call(0x5CB2EBB467BE3ED6, animal, p2); }
		public static void _0x9F0F28B42C4EE80A(int animal, float p2) { Function.Call(0x9F0F28B42C4EE80A, animal, p2); }
		public static void _SET_MOUNT_BONDING_LEVEL(int ped, int bondingLevel) { Function.Call(0xA69899995997A63B, ped, bondingLevel); }
		public static void _SET_MOUNT_SECURITY_ENABLED(int ped, BOOL toggle) { Function.Call(0x11E6B9629C46D6EC, ped, toggle); }
		public static void _0x9B65444C07B782BF(int ped, string p1) { Function.Call(0x9B65444C07B782BF, ped, p1); }
		public static BOOL IS_ANIMAL_INTERACTION_POSSIBLE(int ped, int animal) { return Function.Call<BOOL>(0xD543D3A8FDE4F185, ped, animal); }
		public static BOOL _IS_ANIMAL_INTERACTION_RUNNING(int ped) { return Function.Call<BOOL>(0x7FC84E85D98F063D, ped); }
		public static int _0x8BE24D74D74C6E9B(int ped) { return Function.Call<int>(0x8BE24D74D74C6E9B, ped); }
		public static BOOL _0x77243ED4F7CAAA55(int ped) { return Function.Call<BOOL>(0x77243ED4F7CAAA55, ped); }
		public static BOOL IS_PED_ON_VEHICLE(int ped, BOOL p1) { return Function.Call<BOOL>(0x67722AEB798E5FAB, ped, p1); }
		public static BOOL IS_PED_ON_SPECIFIC_VEHICLE(int ped, int vehicle) { return Function.Call<BOOL>(0xEC5F66E459AF3BB2, ped, vehicle); }
		public static void _WARP_PED_OUT_OF_VEHICLE(int ped) { Function.Call(0xE0B61ED8BB37712F, ped); }
		public static void SET_PED_MONEY(int ped, int amount) { Function.Call(0xA9C8960E8684C1B5, ped, amount); }
		public static int GET_PED_MONEY(int ped) { return Function.Call<int>(0x3F69145BBA87BAE7, ped); }
		public static void _0x9911F4A24485F653(BOOL p0) { Function.Call(0x9911F4A24485F653, p0); }
		public static unsafe void _0x34EDDD59364AD74A(int ped, Any* p1) { Function.Call(0x34EDDD59364AD74A, ped, p1); }
		public static void _0x2D976DBDC731DF80(int ped) { Function.Call(0x2D976DBDC731DF80, ped); }
		public static BOOL IS_PED_SITTING_IN_VEHICLE(int ped, int vehicle) { return Function.Call<BOOL>(0xA808AA1D79230FC2, ped, vehicle); }
		public static BOOL IS_PED_SITTING_IN_ANY_VEHICLE(int ped) { return Function.Call<BOOL>(0x826AA586EDB9FEF8, ped); }
		public static BOOL IS_PED_ON_FOOT(int ped) { return Function.Call<BOOL>(0x01FEE67DB37F59B2, ped); }
		public static BOOL IS_PED_PLANTING_BOMB(int ped) { return Function.Call<BOOL>(0xC70B5FAE151982D8, ped); }
		public static Vector3 GET_DEAD_PED_PICKUP_COORDS(int ped, float p1, float p2) { return Function.Call<Vector3>(0xCD5003B097200F36, ped, p1, p2); }
		public static BOOL IS_PED_IN_ANY_BOAT(int ped) { return Function.Call<BOOL>(0x2E0E1C2B4F6CB339, ped); }
		public static BOOL IS_PED_IN_ANY_HELI(int ped) { return Function.Call<BOOL>(0x298B91AE825E5705, ped); }
		public static BOOL IS_PED_IN_ANY_PLANE(int ped) { return Function.Call<BOOL>(0x5FFF4CFC74D8FB80, ped); }
		public static BOOL IS_PED_IN_FLYING_VEHICLE(int ped) { return Function.Call<BOOL>(0x9134873537FA419C, ped); }
		public static BOOL _0x256EDD55C6BE1482(int ped) { return Function.Call<BOOL>(0x256EDD55C6BE1482, ped); }
		public static unsafe BOOL GET_PED_LAST_DAMAGE_BONE(int ped, int* _outBone) { return Function.Call<BOOL>(0xD75960F6BD9EA49C, ped, _outBone); }
		public static void CLEAR_PED_LAST_DAMAGE_BONE(int ped) { Function.Call(0x8EF6B7AC68E2F01B, ped); }
		public static int _GET_PED_DAMAGE_CLEANLINESS(int ped) { return Function.Call<int>(0x88EFFED5FE8B0B4A, ped); }
		public static void _SET_PED_DAMAGE_CLEANLINESS(int ped, int damageCleanliness) { Function.Call(0x7528720101A807A5, ped, damageCleanliness); }
		public static BOOL _GET_PED_DAMAGED(int ped) { return Function.Call<BOOL>(0x6CFC373008A1EDAF, ped); }
		public static void _SET_PED_DAMAGED(int ped, BOOL damaged) { Function.Call(0xDACE03C65C6666DB, ped, damaged); }
		public static Any _SET_PLAYER_CURRENT_ANIMAL_DAMAGE_MODIFIER(int player, float modifier, int p2, int p3) { return Function.Call<Any>(0x9EFF3C91DF38304F, player, modifier, p2, p3); }
		public static void _UPDATE_ANIMAL_DAMAGE_MODIFIER(int player) { Function.Call(0x0F9E754EBE8FDBFA, player); }
		public static float _GET_PLAYER_CURRENT_ANIMAL_DAMAGE_MODIFIER(int player) { return Function.Call<float>(0xEE2D5C819A65BF26, player); }
		public static unsafe Any _0xB29C553BA582D09E(Any* p0, Hash model, int damageCleanliness, int p3) { return Function.Call<Any>(0xB29C553BA582D09E, p0, model, damageCleanliness, p3); }
		public static unsafe BOOL _0x101B45C5F56D970F(Any* p0, int ped, int damageCleanliness, int p3) { return Function.Call<BOOL>(0x101B45C5F56D970F, p0, ped, damageCleanliness, p3); }
		public static unsafe int _COMPUTE_SATCHEL_ITEM_FOR_PED_CARCASS(Any* _outInventoryItemArray, int ped, int damageCleanliness, int skinningQuality) { return Function.Call<int>(0x6B89FAA36FC909A3, _outInventoryItemArray, ped, damageCleanliness, skinningQuality); }
		public static BOOL COMPUTE_SATCHEL_ITEM_FOR_PED_DAMAGE(Any p0, int pedAttached, int damageCleanliness) { return Function.Call<BOOL>(0x9E7738B291706746, p0, pedAttached, damageCleanliness); }
		public static void SET_AI_WEAPON_DAMAGE_MODIFIER(float value) { Function.Call(0x1B1E2A40A65B8521, value); }
		public static void RESET_AI_WEAPON_DAMAGE_MODIFIER() { Function.Call(0xEA16670E7BA4743C); }
		public static void _SET_TOTAL_PED_DAMAGE_FROM_AI(int ped, float totalDamage) { Function.Call(0x73B6F907B913C860, ped, totalDamage); }
		public static void _0xA6D6F03095C88F59(int ped) { Function.Call(0xA6D6F03095C88F59, ped); }
		public static float _GET_TOTAL_PED_DAMAGE_FROM_AI(int ped) { return Function.Call<float>(0x92C8EACA29F6BED6, ped); }
		public static void SET_PED_TO_PLAYER_WEAPON_DAMAGE_MODIFIER(int ped, float damageModifier) { Function.Call(0xD77AE48611B7B10A, ped, damageModifier); }
		public static float GET_PED_TO_PLAYER_WEAPON_DAMAGE_MODIFIER(int ped) { return Function.Call<float>(0x936E7CAD0AE2EE14, ped); }
		public static void _SET_CURRENT_DEFENSE_AGAINST_PLAYERS_MODIFIER(int horse, float modifier) { Function.Call(0x069EDDF1FD4DEB0A, horse, modifier); }
		public static float _0x763FA8A9D76EE3A7(int ped) { return Function.Call<float>(0x763FA8A9D76EE3A7, ped); }
		public static void SET_AI_MELEE_WEAPON_DAMAGE_MODIFIER(float modifier) { Function.Call(0x66460DEDDD417254, modifier); }
		public static void _SET_ACCURACY_AGAINST_LOCAL_PLAYER_MODIFIER(int ped, float modifier) { Function.Call(0xC2266AA617668AD3, ped, modifier); }
		public static float _0xDC9273D95976BA22(int ped) { return Function.Call<float>(0xDC9273D95976BA22, ped); }
		public static void _SET_PED_HEADSHOT_DAMAGE_MULTIPLIER(int ped, float multiplier) { Function.Call(0x2BA918C823B8BA56, ped, multiplier); }
		public static void _0xDEE8D30AA5C2E28D(int ped, Hash p1, BOOL p2) { Function.Call(0xDEE8D30AA5C2E28D, ped, p1, p2); }
		public static void _0xE1B3BE07D3AADDED(int ped, int p1, BOOL p2) { Function.Call(0xE1B3BE07D3AADDED, ped, p1, p2); }
		public static void _0x32CEDA9A0AB4CEF7(int ped, Hash p1, BOOL p2) { Function.Call(0x32CEDA9A0AB4CEF7, ped, p1, p2); }
		public static void _0x52A24D8A1DA89658(int ped, int p1, BOOL p2) { Function.Call(0x52A24D8A1DA89658, ped, p1, p2); }
		public static void _0x34B5CEAC180A5D6E(int ped, Hash p1, BOOL p2) { Function.Call(0x34B5CEAC180A5D6E, ped, p1, p2); }
		public static void _0x4F27603E44A8E4C0(int ped, int p1, BOOL p2) { Function.Call(0x4F27603E44A8E4C0, ped, p1, p2); }
		public static void _0x3FDCC1F8C17E303E(int ped, int p1, float p2) { Function.Call(0x3FDCC1F8C17E303E, ped, p1, p2); }
		public static void _0xE50C9816B3F22D8B(int ped, Hash p1, float p2) { Function.Call(0xE50C9816B3F22D8B, ped, p1, p2); }
		public static void _SET_DEFENSE_MODIFIER_FOR_PED(int ped, float modifier) { Function.Call(0x9B6808EC46BE849B, ped, modifier); }
		public static void _0x7883AA809DF43D98(int ped, float healthLimit) { Function.Call(0x7883AA809DF43D98, ped, healthLimit); }
		public static void _0xC5B78E41DCF8227C(int ped, BOOL p1) { Function.Call(0xC5B78E41DCF8227C, ped, p1); }
		public static void SET_PED_CAN_BE_TARGETTED(int ped, BOOL toggle) { Function.Call(0x63F58F7C80513AAD, ped, toggle); }
		public static void SET_PED_CAN_BE_TARGETTED_BY_TEAM(int ped, int team, BOOL toggle) { Function.Call(0xBF1CA77833E58F2C, ped, team, toggle); }
		public static void SET_PED_CAN_BE_TARGETTED_BY_PLAYER(int ped, int player, BOOL toggle) { Function.Call(0x66B57B72E0836A76, ped, player, toggle); }
		public static void _SET_INTERACTION_LOCKON_FLAG(int ped, int player, int flag, BOOL enable) { Function.Call(0xFECA2081F61ED2CD, ped, player, flag, enable); }
		public static BOOL IS_PED_FALLING(int ped) { return Function.Call<BOOL>(0xFB92A102F1C4DFA3, ped); }
		public static BOOL _IS_PED_SLIDING(int ped) { return Function.Call<BOOL>(0xD6740E14E4CEFC0B, ped); }
		public static BOOL IS_PED_JUMPING(int ped) { return Function.Call<BOOL>(0xCEDABC5900A0BF97, ped); }
		public static BOOL IS_PED_CLIMBING(int ped) { return Function.Call<BOOL>(0x53E8CB4F48BFE623, ped); }
		public static BOOL _IS_PED_CLIMBING_LADDER(int ped) { return Function.Call<BOOL>(0x59643424B68D52B5, ped); }
		public static BOOL _0x577C60BA06D0EA64(int ped) { return Function.Call<BOOL>(0x577C60BA06D0EA64, ped); }
		public static BOOL IS_PED_VAULTING(int ped) { return Function.Call<BOOL>(0x117C70D1F5730B5E, ped); }
		public static BOOL IS_PED_DIVING(int ped) { return Function.Call<BOOL>(0x5527B8246FEF9B11, ped); }
		public static BOOL _IS_PED_OPENING_A_DOOR(int ped) { return Function.Call<BOOL>(0x26AF0E8E30BD2A2C, ped); }
		public static BOOL _0x5C6C7C70CA302801(int ped) { return Function.Call<BOOL>(0x5C6C7C70CA302801, ped); }
		public static BOOL _0xB91AB3BE7F655D49(int ped) { return Function.Call<BOOL>(0xB91AB3BE7F655D49, ped); }
		public static BOOL IS_PED_IN_ANY_TAXI(int ped) { return Function.Call<BOOL>(0x6E575D6A898AB852, ped); }
		public static void SET_PED_ID_RANGE(int ped, float value) { Function.Call(0xF107E836A70DCE05, ped, value); }
		public static float _GET_PED_ID_RANGE(int ped) { return Function.Call<float>(0x31167ED4324B758D, ped); }
		public static void SET_PED_HIGHLY_PERCEPTIVE(int ped, BOOL toggle) { Function.Call(0x52D59AB61DDC05DD, ped, toggle); }
		public static void SET_PED_INJURED_ON_GROUND_BEHAVIOUR(int ped, float unk) { Function.Call(0xEC4B4B3B9908052A, ped, unk); }
		public static void DISABLE_PED_INJURED_ON_GROUND_BEHAVIOUR(int ped) { Function.Call(0x733C87D4CE22BEA2, ped); }
		public static void _0x028E7B3BBA0BD2FC(int ped) { Function.Call(0x028E7B3BBA0BD2FC, ped); }
		public static BOOL _0xFA8C10DCE0706D43(int ped) { return Function.Call<BOOL>(0xFA8C10DCE0706D43, ped); }
		public static void _SET_PED_ANIMAL_DETECTION_MODIFIER(int ped, float modifier) { Function.Call(0x43CA928E892CFDB8, ped, modifier); }
		public static float _0x2BA9D7BF629F920C(int ped) { return Function.Call<float>(0x2BA9D7BF629F920C, ped); }
		public static void SET_PED_SEEING_RANGE(int ped, float value) { Function.Call(0xF29CF591C4BF6CEE, ped, value); }
		public static float _0x900CA00CE703E1E2(int ped) { return Function.Call<float>(0x900CA00CE703E1E2, ped); }
		public static void SET_PED_HEARING_RANGE(int ped, float value) { Function.Call(0x33A8F7F7D5F7F33C, ped, value); }
		public static void SET_PED_VISUAL_FIELD_MIN_ANGLE(int ped, float value) { Function.Call(0x2DB492222FB21E26, ped, value); }
		public static void SET_PED_VISUAL_FIELD_MAX_ANGLE(int ped, float value) { Function.Call(0x70793BDCA1E854D4, ped, value); }
		public static void SET_PED_VISUAL_FIELD_PERIPHERAL_RANGE(int ped, float range) { Function.Call(0x9C74B0BC831B753A, ped, range); }
		public static void SET_PED_VISUAL_FIELD_CENTER_ANGLE(int ped, float angle) { Function.Call(0x3B6405E8AB34A907, ped, angle); }
		public static void _0x9AB33CB5834885B3(int ped, float p1, float p2, float p3, float p4) { Function.Call(0x9AB33CB5834885B3, ped, p1, p2, p3, p4); }
		public static void _0x899DFA0009AC93DE(int ped, float p1) { Function.Call(0x899DFA0009AC93DE, ped, p1); }
		public static void _0x3A5697B80FED5EBE(int ped, float p1, float p2, float p3, float p4) { Function.Call(0x3A5697B80FED5EBE, ped, p1, p2, p3, p4); }
		public static void SET_PED_STEALTH_MOVEMENT(int ped, Any p1, Any p2, Any p3) { Function.Call(0x88CBB5CEB96B7BD2, ped, p1, p2, p3); }
		public static BOOL GET_PED_STEALTH_MOVEMENT(int ped) { return Function.Call<BOOL>(0x7C2AC9CA66575FBF, ped); }
		public static void _SET_PED_CROUCH_MOVEMENT(int ped, BOOL state, int p2, BOOL immediately) { Function.Call(0x7DE9692C6F64CFE8, ped, state, p2, immediately); }
		public static BOOL GET_PED_CROUCH_MOVEMENT(int ped) { return Function.Call<BOOL>(0xD5FE956C70FF370B, ped); }
		public static BOOL GET_PED_IS_DOING_COMBAT_ROLL(int ped) { return Function.Call<BOOL>(0xC48A9EB0D499B3E5, ped); }
		public static int CREATE_GROUP(int taskAllocator) { return Function.Call<int>(0x90370EBE0FEE1A3D, taskAllocator); }
		public static void SET_PED_AS_GROUP_LEADER(int ped, int groupId, BOOL p2) { Function.Call(0x2A7819605465FBCE, ped, groupId, p2); }
		public static void SET_PED_AS_GROUP_MEMBER(int ped, int groupId) { Function.Call(0x9F3480FE65DB31B5, ped, groupId); }
		public static void SET_PED_CAN_TELEPORT_TO_GROUP_LEADER(int pedHandle, int groupId, BOOL toggle) { Function.Call(0x2E2F4240B3F24647, pedHandle, groupId, toggle); }
		public static void REMOVE_GROUP(int groupId) { Function.Call(0x8EB2F69076AF7053, groupId); }
		public static void REMOVE_PED_FROM_GROUP(int ped) { Function.Call(0xED74007FFB146BC2, ped); }
		public static BOOL IS_PED_GROUP_MEMBER(int ped, int groupId, BOOL p2) { return Function.Call<BOOL>(0x9BB01E3834671191, ped, groupId, p2); }
		public static BOOL _IS_PED_GROUP_LEADER(int ped, int groupId) { return Function.Call<BOOL>(0x878B68960C1C2A35, ped, groupId); }
		public static BOOL IS_PED_HANGING_ON_TO_VEHICLE(int ped) { return Function.Call<BOOL>(0x1C86D8AEF8254B78, ped); }
		public static void SET_GROUP_SEPARATION_RANGE(int groupId, float separationRange) { Function.Call(0x4102C7858CFEE4E4, groupId, separationRange); }
		public static void _0x89E59DBD15E21177(int groupId, int p1) { Function.Call(0x89E59DBD15E21177, groupId, p1); }
		public static BOOL IS_PED_PRONE(int ped) { return Function.Call<BOOL>(0xD6A86331A537A7B9, ped); }
		public static BOOL _0x7583A9D35248B83F(int ped) { return Function.Call<BOOL>(0x7583A9D35248B83F, ped); }
		public static BOOL IS_PED_IN_COMBAT(int ped, int target) { return Function.Call<BOOL>(0x4859F1FC66A6278E, ped, target); }
		public static BOOL CAN_PED_IN_COMBAT_SEE_TARGET(int ped, int target) { return Function.Call<BOOL>(0xEAD42DE3610D0721, ped, target); }
		public static BOOL IS_PED_JACKING(int ped) { return Function.Call<BOOL>(0x4AE4FF911DFB61DA, ped); }
		public static BOOL IS_PED_BEING_JACKED(int ped) { return Function.Call<BOOL>(0x9A497FE2DF198913, ped); }
		public static BOOL IS_PED_BEING_STUNNED(int ped, int p1) { return Function.Call<BOOL>(0x4FBACCE3B4138EE8, ped, p1); }
		public static int GET_PEDS_JACKER(int ped) { return Function.Call<int>(0x9B128DC36C1E04CF, ped); }
		public static int GET_JACK_TARGET(int ped) { return Function.Call<int>(0x5486A79D9FBD342D, ped); }
		public static BOOL IS_PED_FLEEING(int ped) { return Function.Call<BOOL>(0xBBCCE00B381F8482, ped); }
		public static BOOL IS_PED_IN_COVER(int ped, BOOL p1, BOOL p2) { return Function.Call<BOOL>(0x60DFD0691A170B88, ped, p1, p2); }
		public static BOOL _0x2DD4E0E26DFAD97D(int ped1, int ped2, float p2) { return Function.Call<BOOL>(0x2DD4E0E26DFAD97D, ped1, ped2, p2); }
		public static BOOL _0x06FA94C835787C64(int ped) { return Function.Call<BOOL>(0x06FA94C835787C64, ped); }
		public static BOOL _PED_DUELING_DID_PLAYER_HEADSHOT_OPPONENT(int ped) { return Function.Call<BOOL>(0xBD6B242B8BD5543A, ped); }
		public static BOOL IS_PED_IN_COVER_FACING_LEFT(int ped) { return Function.Call<BOOL>(0x845333B3150583AB, ped); }
		public static BOOL IS_PED_GOING_INTO_COVER(int ped) { return Function.Call<BOOL>(0x9F65DBC537E59AD5, ped); }
		public static BOOL IS_PED_RESPONDING_TO_THREAT(int ped) { return Function.Call<BOOL>(0x77525BBF433F2CD6, ped); }
		public static Hash _GET_ACTIVE_DYNAMIC_SCENARIO_2(int ped) { return Function.Call<Hash>(0xC22AA08A8ADB87D4, ped); }
		public static Hash _GET_ACTIVE_DYNAMIC_SCENARIO(int ped) { return Function.Call<Hash>(0x569F1E1237508DEB, ped); }
		public static BOOL _GIVE_PED_SCENARIO_PROP(int ped, Object _object, string conditionalAnim, string p3, string p4, BOOL p5) { return Function.Call<BOOL>(0x3BBDD6143FF16F98, ped, _object, conditionalAnim, p3, p4, p5); }
		public static BOOL GIVE_PED_HASH_SCENARIO_PROP(int ped, Object _object, string conditionalAnim, Hash scenarioType, Hash p4, BOOL p5) { return Function.Call<BOOL>(0x2B02DB082258625F, ped, _object, conditionalAnim, scenarioType, p4, p5); }
		public static BOOL _GIVE_PED_SCENARIO_PROP_DYNAMIC(int ped, Object _object, string p2, string p3, BOOL p4) { return Function.Call<BOOL>(0xA0774E388CE4A679, ped, _object, p2, p3, p4); }
		public static Any _REQUEST_PROP_SCENARIO_PED(int ped, Object _object, string p2, string p3, string p4, BOOL p5) { return Function.Call<Any>(0xBEC65C6049B3219D, ped, _object, p2, p3, p4, p5); }
		public static Any _REQUEST_PED_FOR_SCENARIO_TYPE(int ped, Object _object, string p2, Hash scenarioType, string p4, BOOL p5) { return Function.Call<Any>(0xBDED916A9F9B0604, ped, _object, p2, scenarioType, p4, p5); }
		public static int _GET_PED_REGISTER_PROP(int ped, string p1, BOOL p2) { return Function.Call<int>(0x4D0D2E3D8BC000EB, ped, p1, p2); }
		public static int GET_SEAT_PED_IS_TRYING_TO_ENTER(int ped) { return Function.Call<int>(0x6F4C85ACD641BCD2, ped); }
		public static int GET_PED_SOURCE_OF_DEATH(int ped) { return Function.Call<int>(0x93C8B64DEB84728C, ped); }
		public static Hash GET_PED_CAUSE_OF_DEATH(int ped) { return Function.Call<Hash>(0x16FFE42AB2D2DC59, ped); }
		public static int GET_PED_TIME_OF_DEATH(int ped) { return Function.Call<int>(0x1E98817B311AE98A, ped); }
		public static int COUNT_PEDS_IN_COMBAT_WITH_TARGET(int ped, int flag) { return Function.Call<int>(0x5407B7288D0478B7, ped, flag); }
		public static int _GET_PEDS_IN_COMBAT_WITH_TARGET(int ped, ItemSet itemset, int flag) { return Function.Call<int>(0x7BE607DAFF382FD2, ped, itemset, flag); }
		public static int COUNT_PEDS_IN_COMBAT_WITH_TARGET_WITHIN_RADIUS(int ped, float x, float y, float z, float radius, int flag) { return Function.Call<int>(0x336B3D200AB007CB, ped, x, y, z, radius, flag); }
		public static int GET_CURRENT_TARGET_FOR_PED(int ped) { return Function.Call<int>(0xCD66FEA29400A0B5, ped); }
		public static void SET_PED_RELATIONSHIP_GROUP_DEFAULT_HASH(int ped, Hash hash) { Function.Call(0xADB3F206518799E8, ped, hash); }
		public static Hash _GET_DEFAULT_RELATIONSHIP_GROUP_HASH(Hash modelHash) { return Function.Call<Hash>(0x3CC4A718C258BDD0, modelHash); }
		public static void SET_PED_RELATIONSHIP_GROUP_HASH(int ped, Hash relationshipGroup) { Function.Call(0xC80A74AC829DDD92, ped, relationshipGroup); }
		public static void SET_RELATIONSHIP_BETWEEN_GROUPS(int relationship, Hash group1, Hash group2) { Function.Call(0xBF25EB89375A37AD, relationship, group1, group2); }
		public static void CLEAR_RELATIONSHIP_BETWEEN_GROUPS(int relationship, Hash group1, Hash group2) { Function.Call(0x5E29243FB56FC6D4, relationship, group1, group2); }
		public static unsafe BOOL ADD_RELATIONSHIP_GROUP(string name, Hash* groupHash) { return Function.Call<BOOL>(0xF372BC22FCB88606, name, groupHash); }
		public static void REMOVE_RELATIONSHIP_GROUP(Hash groupHash) { Function.Call(0xB6BA2444AB393DA2, groupHash); }
		public static int GET_RELATIONSHIP_BETWEEN_PEDS(int ped1, int ped2) { return Function.Call<int>(0xEBA5AD3A0EAF7121, ped1, ped2); }
		public static Hash GET_PED_RELATIONSHIP_GROUP_DEFAULT_HASH(int ped) { return Function.Call<Hash>(0x42FDD0F017B1E38E, ped); }
		public static Hash GET_PED_RELATIONSHIP_GROUP_HASH(int ped) { return Function.Call<Hash>(0x7DBDD04862D95F04, ped); }
		public static int GET_RELATIONSHIP_BETWEEN_GROUPS(Hash group1, Hash group2) { return Function.Call<int>(0x9E6B70061662AE5C, group1, group2); }
		public static void _0xDC91F22F09BC6C2F(Hash group, BOOL p1) { Function.Call(0xDC91F22F09BC6C2F, group, p1); }
		public static void _0x9629FAF6460D35CB(Hash group, BOOL p1) { Function.Call(0x9629FAF6460D35CB, group, p1); }
		public static void _0x4E68C7EF706DF35D(int ped, float x, float y, float z, float p4, Hash relationshipGroup) { Function.Call(0x4E68C7EF706DF35D, ped, x, y, z, p4, relationshipGroup); }
		public static int _0x3ACCE14DFA6BA8C2(int ped, int p1, float x, float y, float z, float p5, ItemSet itemset) { return Function.Call<int>(0x3ACCE14DFA6BA8C2, ped, p1, x, y, z, p5, itemset); }
		public static void SET_PED_TO_INFORM_RESPECTED_FRIENDS(int ped, float radius, int maxFriends) { Function.Call(0x112942C6E708F70B, ped, radius, maxFriends); }
		public static BOOL _0x40C9155AF8BC13F3(int ped) { return Function.Call<BOOL>(0x40C9155AF8BC13F3, ped); }
		public static unsafe int _0xF4860514AD354226(ScrHandle shockingEvent, float x, float y, float z, float p4, int* p5) { return Function.Call<int>(0xF4860514AD354226, shockingEvent, x, y, z, p4, p5); }
		public static BOOL IS_PED_RESPONDING_TO_EVENT(int ped, Hash _eventType) { return Function.Call<BOOL>(0x625B774D75C87068, ped, _eventType); }
		public static int _0x5E9FAF6C513347B4(int ped, Hash _eventType) { return Function.Call<int>(0x5E9FAF6C513347B4, ped, _eventType); }
		public static Any _0x326F7951EF0D7F75(int ped, Hash _eventType) { return Function.Call<Any>(0x326F7951EF0D7F75, ped, _eventType); }
		public static int _0xE76687023D8C8505(Hash perscharModel, int p1) { return Function.Call<int>(0xE76687023D8C8505, perscharModel, p1); }
		public static unsafe BOOL _0xCB8F4C9343EBE240(int ped, Hash _eventType, Vector3* coords) { return Function.Call<BOOL>(0xCB8F4C9343EBE240, ped, _eventType, coords); }
		public static void SET_PED_FIRING_PATTERN(int ped, Hash patternHash) { Function.Call(0x9AC577F5A12AD8A9, ped, patternHash); }
		public static void _SET_PED_FIRING_PATTERN_2(int ped, Hash patternHash) { Function.Call(0x20E54854DEF6A54A, ped, patternHash); }
		public static void _SET_PED_FIRING_PATTERN_3(int ped, Hash patternHash) { Function.Call(0x244E8C282188E40F, ped, patternHash); }
		public static void SET_PED_SHOOT_RATE(int ped, int shootRate) { Function.Call(0x614DA022990752DC, ped, shootRate); }
		public static void _0x3C529A827998F9B3(int ped, int p1, int p2) { Function.Call(0x3C529A827998F9B3, ped, p1, p2); }
		public static void _0x1F44B7E283C09EDE(int ped, float p1, int p2) { Function.Call(0x1F44B7E283C09EDE, ped, p1, p2); }
		public static void SET_COMBAT_FLOAT(int ped, int combatType, float newValue) { Function.Call(0xFF41B4B141ED981C, ped, combatType, newValue); }
		public static float GET_COMBAT_FLOAT(int ped, int combatType) { return Function.Call<float>(0x52DFF8A10508090A, ped, combatType); }
		public static unsafe void GET_GROUP_SIZE(int groupId, BOOL* hasLeader, int* numberOfFollowers) { Function.Call(0x8DE69FE35CA09A45, groupId, hasLeader, numberOfFollowers); }
		public static BOOL DOES_GROUP_EXIST(int groupId) { return Function.Call<BOOL>(0x7C6B0C22F9F40BBE, groupId); }
		public static BOOL _0x0455546F23FF08E4(int groupId) { return Function.Call<BOOL>(0x0455546F23FF08E4, groupId); }
		public static BOOL IS_GROUP_LOCALLY_CONTROLLED(int groupId) { return Function.Call<BOOL>(0x909AD9E9A92A10DF, groupId); }
		public static int GET_PED_GROUP_INDEX(int ped) { return Function.Call<int>(0xF162E133B4E7A675, ped); }
		public static BOOL IS_PED_IN_GROUP(int ped) { return Function.Call<BOOL>(0x5891CAC5D4ACFF74, ped); }
		public static BOOL _0x917760CFE7A0E0F1(int ped) { return Function.Call<BOOL>(0x917760CFE7A0E0F1, ped); }
		public static int GET_PLAYER_PED_IS_FOLLOWING(int ped) { return Function.Call<int>(0x6A3975DEA89F9A17, ped); }
		public static void SET_GROUP_FORMATION(int groupId, int formationType) { Function.Call(0xCE2F5FC3AF7E8C1E, groupId, formationType); }
		public static int _GET_GROUP_FORMATION(int groupId) { return Function.Call<int>(0x13A1B061007C906B, groupId); }
		public static void SET_GROUP_FORMATION_SPACING(int groupId, float p1, float p2, float p3) { Function.Call(0x1D9D45004C28C916, groupId, p1, p2, p3); }
		public static void RESET_GROUP_FORMATION_DEFAULT_SPACING(int groupId) { Function.Call(0x63DAB4CCB3273205, groupId); }
		public static BOOL _0xB05CC690CDE8A4A9(int groupId, float p1) { return Function.Call<BOOL>(0xB05CC690CDE8A4A9, groupId, p1); }
		public static void ADD_CUSTOM_FORMATION_LOCATION(int groupId, float x, float y, float z, int position) { Function.Call(0x4E23CD07BD161E06, groupId, x, y, z, position); }
		public static BOOL ADD_FORMATION_LOCATION(int groupId, float p1, float p2, float p3) { return Function.Call<BOOL>(0xB05945C1E9E60D91, groupId, p1, p2, p3); }
		public static BOOL SET_FORMATION_POSITIONS_TARGET_RADIUS(int groupId, float radius) { return Function.Call<BOOL>(0x7CC7D3B7AF7FB71F, groupId, radius); }
		public static void _SET_FORMATION_AUTO_ASSIGN_POSITION(int groupId, BOOL toggle) { Function.Call(0x478F6B9920446CE2, groupId, toggle); }
		public static void _SET_PED_FORMATION_POSITION(int ped, int position, BOOL toggle) { Function.Call(0x0E9E95FDEDCC9D35, ped, position, toggle); }
		public static int _0x8AF8E647D6B2A649(int groupId, int ped) { return Function.Call<int>(0x8AF8E647D6B2A649, groupId, ped); }
		public static void _0x87C2724A56F66020(int ped) { Function.Call(0x87C2724A56F66020, ped); }
		public static void _0xD5BD1B5318A81994(int groupId, BOOL p1) { Function.Call(0xD5BD1B5318A81994, groupId, p1); }
		public static void _0x9BBEAF8B0C007F1E(int ped, BOOL p1) { Function.Call(0x9BBEAF8B0C007F1E, ped, p1); }
		public static void _0xC99F104BDF8C7F5A(int ped, BOOL p1) { Function.Call(0xC99F104BDF8C7F5A, ped, p1); }
		public static void _0x02E741E19E39628C(int ped, float p1) { Function.Call(0x02E741E19E39628C, ped, p1); }
		public static void _0x97C475212B327666(int groupId, BOOL p1) { Function.Call(0x97C475212B327666, groupId, p1); }
		public static void _0x154B7E841AC7412F(int groupId, BOOL p1) { Function.Call(0x154B7E841AC7412F, groupId, p1); }
		public static void _0x8AFCCC0F18D70018(int groupId, BOOL p1) { Function.Call(0x8AFCCC0F18D70018, groupId, p1); }
		public static void _0xE1103300F3456DE7(int groupId, float p1, float p2) { Function.Call(0xE1103300F3456DE7, groupId, p1, p2); }
		public static void _0xA8A95CECB1906EA2(int groupId, BOOL p1) { Function.Call(0xA8A95CECB1906EA2, groupId, p1); }
		public static void _0xDDFAD4DEAA7FA362(int groupId, float p1, float p2, float p3, float p4) { Function.Call(0xDDFAD4DEAA7FA362, groupId, p1, p2, p3, p4); }
		public static void _0x966DE09688A1DE39(int groupId, float p1, float p2, float p3, float p4) { Function.Call(0x966DE09688A1DE39, groupId, p1, p2, p3, p4); }
		public static void _0x7E5185B979706210(int groupId, int p1) { Function.Call(0x7E5185B979706210, groupId, p1); }
		public static void _0x40C3524D4ED83554(int groupId, BOOL p1) { Function.Call(0x40C3524D4ED83554, groupId, p1); }
		public static void _0x86FAFC18E3D4380C(int groupId, BOOL p1) { Function.Call(0x86FAFC18E3D4380C, groupId, p1); }
		public static void _0x07EA5B053FA60AC7(int groupId, BOOL p1) { Function.Call(0x07EA5B053FA60AC7, groupId, p1); }
		public static void _0xF9CBD46433E36713(int ped, int targetEntity, float p2, float p3, float p4, float p5, float p6, float p7, float p8, string p9) { Function.Call(0xF9CBD46433E36713, ped, targetEntity, p2, p3, p4, p5, p6, p7, p8, p9); }
		public static int GET_VEHICLE_PED_IS_USING(int ped) { return Function.Call<int>(0x6094AD011A2EA87D, ped); }
		public static int GET_VEHICLE_PED_IS_ENTERING(int ped) { return Function.Call<int>(0xF92691AED837A5FC, ped); }
		public static int _GET_VEHICLE_DRAFT_HORSE_IS_ATTACHED_TO(int horse) { return Function.Call<int>(0xE4770DA1B8FF4FD1, horse); }
		public static int _GET_LAST_VEHICLE_DRAFT_HORSE_WAS_ATTACHED_TO(int horse) { return Function.Call<int>(0x5064DB5083C29921, horse); }
		public static int GET_SEAT_PED_IS_USING(int ped) { return Function.Call<int>(0x4E76CB57222A00E5, ped); }
		public static int _GET_TRANSPORT_PED_IS_SEATED_ON(int ped) { return Function.Call<int>(0x849BD6C6314793D0, ped); }
		public static BOOL IS_PED_ENTERING_ANY_TRANSPORT(int ped) { return Function.Call<BOOL>(0x1D46B417F926D34D, ped); }
		public static void SET_PED_GRAVITY(int ped, BOOL toggle) { Function.Call(0x9FF447B6B6AD960A, ped, toggle); }
		public static void _0x96595B36D6A2279B(int animal, BOOL toggle) { Function.Call(0x96595B36D6A2279B, animal, toggle); }
		public static void _SET_PED_IMMERSION_FLAG(int ped, BOOL toggle) { Function.Call(0x7FB0088E8769CDDB, ped, toggle); }
		public static void _0xA90684ED185CCB4B(int animal, BOOL p1, float p2, float p3) { Function.Call(0xA90684ED185CCB4B, animal, p1, p2, p3); }
		public static void _FAKE_SET_PED_LOCO_INJURED(int ped, BOOL enabled) { Function.Call(0x8B3CB08158E98481, ped, enabled); }
		public static void _FORCE_PED_DEATH(int ped, int pedKiller, Hash weapon) { Function.Call(0x1CE875505D45338A, ped, pedKiller, weapon); }
		public static void APPLY_DAMAGE_TO_PED(int ped, int damageAmount, int p2, int boneId, int pedKiller) { Function.Call(0x697157CED63F18D4, ped, damageAmount, p2, boneId, pedKiller); }
		public static void _0xBAD2A311667A50D7(int ped, BOOL p1) { Function.Call(0xBAD2A311667A50D7, ped, p1); }
		public static int GET_PED_TYPE(int ped) { return Function.Call<int>(0xFF059E1E4C01E63C, ped); }
		public static void SET_PED_AS_COP(int ped, BOOL toggle) { Function.Call(0xBB03C38DD3FB7FFD, ped, toggle); }
		public static void _0x405180B14DA5A935(int ped, BOOL p1) { Function.Call(0x405180B14DA5A935, ped, p1); }
		public static void _SET_PED_INTERACTION_PERSONALITY(int ped, Hash personality) { Function.Call(0x24C82EF607105FAA, ped, personality); }
		public static Hash _GET_PED_INTERACTION_PERSONALITY(int ped) { return Function.Call<Hash>(0xD7AD3C7EBAF88C92, ped); }
		public static void _0xB8B6430EAD2D2437(int ped, Hash p1) { Function.Call(0xB8B6430EAD2D2437, ped, p1); }
		public static void _0x329772C47DBB2FBC(int ped) { Function.Call(0x329772C47DBB2FBC, ped); }
		public static BOOL _GET_IS_PED_IN_DISPUTE_WITH_PED(int ped, int pedInDisputeWith) { return Function.Call<BOOL>(0x331550B212014B92, ped, pedInDisputeWith); }
		public static BOOL _0x94132D7C8D3575C4(int ped) { return Function.Call<BOOL>(0x94132D7C8D3575C4, ped); }
		public static void _0x8AF46E5159A5B620(int ped, Hash speechParams) { Function.Call(0x8AF46E5159A5B620, ped, speechParams); }
		public static void _0x45FEA6D5539BD474(int ped, string p1) { Function.Call(0x45FEA6D5539BD474, ped, p1); }
		public static void _0x20C5459379D75C1C(int ped, string p1) { Function.Call(0x20C5459379D75C1C, ped, p1); }
		public static void _0xE37ACEE15AC50C7E(int ped, string p1) { Function.Call(0xE37ACEE15AC50C7E, ped, p1); }
		public static void _0xA3C53CDE922BC78B(int ped, string p1) { Function.Call(0xA3C53CDE922BC78B, ped, p1); }
		public static void _0x41C23A8E6B344867(int ped, string p1) { Function.Call(0x41C23A8E6B344867, ped, p1); }
		public static BOOL GET_IS_PED_RESPONDING_TO_POSITIVE_INTERACTION(int ped, int player) { return Function.Call<BOOL>(0x9337183FDA2E9035, ped, player); }
		public static BOOL GET_IS_PED_RESPONDING_TO_NEGATIVE_INTERACTION(int ped, int player) { return Function.Call<BOOL>(0xA454D234E45BB6E5, ped, player); }
		public static void _0xA7DC9266ED6A4E51(int ped) { Function.Call(0xA7DC9266ED6A4E51, ped); }
		public static Any _0x89816B58C3466262(int ped) { return Function.Call<Any>(0x89816B58C3466262, ped); }
		public static void _0x97B06669AC569003(int ped1, int ped2) { Function.Call(0x97B06669AC569003, ped1, ped2); }
		public static void _0x85F500F4E24CA43E(int ped, float p1) { Function.Call(0x85F500F4E24CA43E, ped, p1); }
		public static void _0x9B9B9FA0EA283E3D(int ped, float p1) { Function.Call(0x9B9B9FA0EA283E3D, ped, p1); }
		public static void _0xEC60D1D225BC50AA(int ped, float p1) { Function.Call(0xEC60D1D225BC50AA, ped, p1); }
		public static void _0x12F2D161BF4031FC(int ped, float p1) { Function.Call(0x12F2D161BF4031FC, ped, p1); }
		public static void _0x0ADA3EC589E1736E() { Function.Call(0x0ADA3EC589E1736E); }
		public static BOOL _GET_IS_PED_BEING_ROBBED(int ped, int player, BOOL trueUntilPlayerPocketsItem) { return Function.Call<BOOL>(0xE33F98BD76490ABC, ped, player, trueUntilPlayerPocketsItem); }
		public static BOOL _0xD55DB4466D00A258(int legendaryAnimal) { return Function.Call<BOOL>(0xD55DB4466D00A258, legendaryAnimal); }
		public static void SET_PED_MAX_HEALTH(int ped, int value) { Function.Call(0xF5F6378C4F3419D3, ped, value); }
		public static int GET_PED_MAX_HEALTH(int ped) { return Function.Call<int>(0x4700A416E8324EF3, ped); }
		public static void _SET_PED_HEALTH_CONFIG(int ped, Hash configHash) { Function.Call(0xF6B82FCE03B43A37, ped, configHash); }
		public static void INIT_PED_DEFAULT_HEALTH(int ped) { Function.Call(0x7DD7FB3480D8083E, ped); }
		public static void SET_PED_MAX_TIME_IN_WATER(int ped, float value) { Function.Call(0x43C851690662113D, ped, value); }
		public static void SET_PED_MAX_TIME_UNDERWATER(int ped, float value) { Function.Call(0x6BA428C528D9E522, ped, value); }
		public static void _0xAF041C10756C30FB(int ped, BOOL p1, BOOL p2, BOOL p3) { Function.Call(0xAF041C10756C30FB, ped, p1, p2, p3); }
		public static void _0x5AF24CA9C974E51A(int ped1, int ped2) { Function.Call(0x5AF24CA9C974E51A, ped1, ped2); }
		public static void SET_PED_CAN_BE_KNOCKED_OFF_VEHICLE(int ped, int state) { Function.Call(0x7A6535691B477C48, ped, state); }
		public static BOOL CAN_KNOCK_PED_OFF_VEHICLE(int ped) { return Function.Call<BOOL>(0x51AC07A44D4F5B8A, ped); }
		public static void KNOCK_PED_OFF_VEHICLE(int ped) { Function.Call(0x45BBCBA77C29A841, ped); }
		public static int GET_PED_AS_GROUP_MEMBER(int groupID, int memberNumber) { return Function.Call<int>(0x51455483CF23ED97, groupID, memberNumber); }
		public static int GET_PED_AS_GROUP_LEADER(int groupID) { return Function.Call<int>(0x5CCE68DBD5FE93EC, groupID); }
		public static void SET_PED_KEEP_TASK(int ped, BOOL toggle) { Function.Call(0x971D38760FBC02EF, ped, toggle); }
		public static BOOL IS_PED_SWIMMING(int ped) { return Function.Call<BOOL>(0x9DE327631295B4C2, ped); }
		public static BOOL IS_PED_SWIMMING_UNDER_WATER(int ped) { return Function.Call<BOOL>(0xC024869A53992F34, ped); }
		public static BOOL _0xDC88D06719070C39(int ped) { return Function.Call<BOOL>(0xDC88D06719070C39, ped); }
		public static void SET_CREATE_RANDOM_COPS(BOOL toggle) { Function.Call(0x102E68B2024D536D, toggle); }
		public static BOOL IS_PED_IN_ANY_TRAIN(int ped) { return Function.Call<BOOL>(0x6F972C1AB75A1ED0, ped); }
		public static BOOL IS_PED_GETTING_INTO_A_VEHICLE(int ped) { return Function.Call<BOOL>(0xBB062B2B5722478E, ped); }
		public static BOOL _0x550CB89DD7F4FA3D(int ped1, int ped2) { return Function.Call<BOOL>(0x550CB89DD7F4FA3D, ped1, ped2); }
		public static void SET_ENABLE_HANDCUFFS(int ped, BOOL p1, BOOL p2) { Function.Call(0xDF1AF8B5D56542FA, ped, p1, p2); }
		public static void SET_ENABLE_BOUND_ANKLES(int ped, BOOL toggle) { Function.Call(0xC52E0F855C58FC2E, ped, toggle); }
		public static BOOL _0x8822F139408B8D0A(int ped) { return Function.Call<BOOL>(0x8822F139408B8D0A, ped); }
		public static void _0x8822F124788B8D0A(int ped, BOOL p1) { Function.Call(0x8822F124788B8D0A, ped, p1); }
		public static void RESET_PED_WEAPON_MOVEMENT_CLIPSET(int ped) { Function.Call(0x97B0DB5B4AA74E77, ped); }
		public static void _SET_PED_GETUP_ANIMATION(int ped, string animName, BOOL p2) { Function.Call(0x3AE3552E7C207CC5, ped, animName, p2); }
		public static void _0x88A95BB640FC186F(int ped) { Function.Call(0x88A95BB640FC186F, ped); }
		public static void RESET_PED_IN_VEHICLE_CONTEXT(int ped) { Function.Call(0x22EF8FF8778030EB, ped); }
		public static void _0x878E8104FA27CDAE(int vehicle, Hash p1) { Function.Call(0x878E8104FA27CDAE, vehicle, p1); }
		public static void SET_PED_GESTURE_GROUP(int ped, string gesture, int p2) { Function.Call(0xDDF803377F94AAA8, ped, gesture, p2); }
		public static void _SET_PED_DESIRED_LOCO_FOR_MODEL(int ped, string locomotionArchetype) { Function.Call(0x923583741DC87BCE, ped, locomotionArchetype); }
		public static void _CLEAR_PED_DESIRED_LOCO_FOR_MODEL(int ped) { Function.Call(0x4FD80C3DD84B817B, ped); }
		public static void _SET_PED_DESIRED_LOCO_MOTION_TYPE(int ped, string locoMotionType) { Function.Call(0x89F5E7ADECCCB49C, ped, locoMotionType); }
		public static void _CLEAR_PED_DESIRED_LOCO_MOTION_TYPE(int ped) { Function.Call(0x58F7DB5BD8FA2288, ped); }
		public static void _0x2371C39D4F91C288(int ped) { Function.Call(0x2371C39D4F91C288, ped); }
		public static void _REQUEST_PED_GETUP_ANIMATION(int ped, string getUpType) { Function.Call(0xEAA8242C8479C27D, ped, getUpType); }
		public static void PED_COWER_IN_PLACE(int ped, int ped2) { Function.Call(0xF6E1E9F47A7686F8, ped, ped2); }
		public static void PED_COWER_MOVE_TO_POINT(int ped, float p1, float p2, float p3, int ped2, float p5) { Function.Call(0x1E4C940233FC0C6F, ped, p1, p2, p3, ped2, p5); }
		public static void _0x16F798A05BB9E3B5(int ped) { Function.Call(0x16F798A05BB9E3B5, ped); }
		public static void _PED_EMOTIONAL_PRESET_LOCO_MOTION(int ped, string presetName, int targetPed, int duration, int flag) { Function.Call(0xAAB050DA48B57978, ped, presetName, targetPed, duration, flag); }
		public static void _PED_CLEAR_LOCO_MOTION(int ped) { Function.Call(0x935CF6E42BAF7F4D, ped); }
		public static void _0x32CCAD8A981B53D3(int ped) { Function.Call(0x32CCAD8A981B53D3, ped); }
		public static void _SET_PED_DRUNKNESS(int ped, BOOL enabled, float drunknessLevel) { Function.Call(0x406CCF555B04FAD3, ped, enabled, drunknessLevel); }
		public static BOOL _IS_PED_DRUNK(int ped) { return Function.Call<BOOL>(0x50F124E6EF188B22, ped); }
		public static float _GET_PED_DRUNKNESS(int ped) { return Function.Call<float>(0x6FB76442469ABD68, ped); }
		public static Vector3 GET_ANIM_INITIAL_OFFSET_POSITION(string animDict, string animName, float x, float y, float z, float xRot, float yRot, float zRot, float p8, int p9) { return Function.Call<Vector3>(0xBE22B26DD764C040, animDict, animName, x, y, z, xRot, yRot, zRot, p8, p9); }
		public static Vector3 GET_ANIM_INITIAL_OFFSET_ROTATION(string animDict, string animName, float x, float y, float z, float xRot, float yRot, float zRot, float p8, int p9) { return Function.Call<Vector3>(0x4B805E6046EE9E47, animDict, animName, x, y, z, xRot, yRot, zRot, p8, p9); }
		public static void SET_PED_RANDOM_COMPONENT_VARIATION(int ped, int p1) { Function.Call(0xC8A9481A01E63C28, ped, p1); }
		public static void KNOCK_OFF_PED_PROP(int ped, BOOL p1, BOOL p2, BOOL p3, BOOL p4) { Function.Call(0x6FD7816A36615F48, ped, p1, p2, p3, p4); }
		public static void SET_BLOCKING_OF_NON_TEMPORARY_EVENTS(int ped, BOOL toggle) { Function.Call(0x9F8AA94D6D97DBF4, ped, toggle); }
		public static BOOL _GET_BLOCKING_OF_NON_TEMPORARY_EVENTS(int ped) { return Function.Call<BOOL>(0x268B3AEBF032A88D, ped); }
		public static void _0xC17A94CC8FC3C61A(int entity, int flag, float p2, float p3, float p4) { Function.Call(0xC17A94CC8FC3C61A, entity, flag, p2, p3, p4); }
		public static void _SET_PED_SCALE(int ped, float scale) { Function.Call(0x25ACFC650B65C538, ped, scale); }
		public static float _0x134775B093AD5C38(int ped) { return Function.Call<float>(0x134775B093AD5C38, ped); }
		public static float _GET_PED_HEIGHT(int ped) { return Function.Call<float>(0x1D491CCF7211FB74, ped); }
		public static int _GET_PED_MODEL_SIZE_FROM_HASH(Hash modelHash) { return Function.Call<int>(0xA65AA1ACE81E5A77, modelHash); }
		public static void REGISTER_TARGET(int ped, int targetPed, BOOL p2) { Function.Call(0x2F25D9AEFA34FBA2, ped, targetPed, p2); }
		public static void _0xD8736EFDA38EDC5C(int ped, float x, float y, float z, float p4) { Function.Call(0xD8736EFDA38EDC5C, ped, x, y, z, p4); }
		public static void REGISTER_HATED_TARGETS_AROUND_PED(int ped, float radius) { Function.Call(0x9222F300BF8354FE, ped, radius); }
		public static BOOL _IS_TARGET(int ped, int targetPed) { return Function.Call<BOOL>(0x6E5CBCB3941D7D08, ped, targetPed); }
		public static void _REMOVE_TARGET(int ped, int targetPed) { Function.Call(0x4707E9C23D8CA3FE, ped, targetPed); }
		public static unsafe BOOL GET_CLOSEST_PED(float x, float y, float z, float radius, BOOL p4, BOOL p5, int* _outPed, BOOL p7, BOOL p8, BOOL p9, int pedType) { return Function.Call<BOOL>(0xC33AB876A77F8164, x, y, z, radius, p4, p5, _outPed, p7, p8, p9, pedType); }
		public static BOOL CAN_PED_RAGDOLL(int ped) { return Function.Call<BOOL>(0x128F79EDCECE4FD5, ped); }
		public static BOOL SET_PED_TO_RAGDOLL(int ped, int timeMin, int timeMax, int ragdollType, BOOL p4, BOOL p5, BOOL p6) { return Function.Call<BOOL>(0xAE99FB955581844A, ped, timeMin, timeMax, ragdollType, p4, p5, p6); }
		public static BOOL SET_PED_TO_RAGDOLL_WITH_FALL(int ped, int timeMin, int timeMax, int ragdollType, float falldirX, float falldirY, float falldirZ, float p7, float p8, float p9, float p10, float p11, float p12, float p13) { return Function.Call<BOOL>(0xD76632D99E4966C8, ped, timeMin, timeMax, ragdollType, falldirX, falldirY, falldirZ, p7, p8, p9, p10, p11, p12, p13); }
		public static void SET_PED_RAGDOLL_ON_COLLISION(int ped, BOOL toggle, BOOL p2) { Function.Call(0xF0A4F1BBF4FA7497, ped, toggle, p2); }
		public static void _SET_PED_TO_DISABLE_RAGDOLL(int ped, BOOL toggle) { Function.Call(0x221F4D9912B7FE86, ped, toggle); }
		public static BOOL IS_PED_RAGDOLL(int ped) { return Function.Call<BOOL>(0x47E4E977581C5B55, ped); }
		public static BOOL IS_PED_RUNNING_RAGDOLL_TASK(int ped) { return Function.Call<BOOL>(0xE3B6097CC25AA69E, ped); }
		public static void SET_PED_RAGDOLL_FORCE_FALL(int ped) { Function.Call(0x01F6594B923B9251, ped); }
		public static void _0x8CB2553C559102C1(int ped, int p1, BOOL p2) { Function.Call(0x8CB2553C559102C1, ped, p1, p2); }
		public static void _0xFD3C31A2E45671E7(int ped, int p1) { Function.Call(0xFD3C31A2E45671E7, ped, p1); }
		public static void RESET_PED_RAGDOLL_TIMER(int ped) { Function.Call(0x9FA4664CF62E47E8, ped); }
		public static void SET_PED_CAN_RAGDOLL(int ped, BOOL toggle) { Function.Call(0xB128377056A54E2A, ped, toggle); }
		public static BOOL _0x3AEC4A410ECAF30D(int ped) { return Function.Call<BOOL>(0x3AEC4A410ECAF30D, ped); }
		public static BOOL IS_PED_RUNNING_MOBILE_PHONE_TASK(int ped) { return Function.Call<BOOL>(0x2AFE52F782F25775, ped); }
		public static void SET_RAGDOLL_BLOCKING_FLAGS(int ped, int flags) { Function.Call(0x26695EC767728D84, ped, flags); }
		public static void CLEAR_RAGDOLL_BLOCKING_FLAGS(int ped, int flags) { Function.Call(0xD86D101FCFD00A4B, ped, flags); }
		public static void _0x9F933E0985E12C51(int ped, float p1, float p2, float p3) { Function.Call(0x9F933E0985E12C51, ped, p1, p2, p3); }
		public static void _0x88B2026A3B0BE33D(int ped, float p1) { Function.Call(0x88B2026A3B0BE33D, ped, p1); }
		public static void SET_PED_DEFENSIVE_AREA_VOLUME(int ped, Volume volume, BOOL p2, BOOL p3, BOOL p4) { Function.Call(0xFC3DB99C8144CD81, ped, volume, p2, p3, p4); }
		public static void SET_PED_SPHERE_DEFENSIVE_AREA(int ped, float x, float y, float z, float radius, BOOL p5, BOOL p6, BOOL p7) { Function.Call(0x9D3151A373974804, ped, x, y, z, radius, p5, p6, p7); }
		public static void _SET_PED_DEFENSIVE_SPHERE_ATTACHED_TO_ENTITY(int ped, int entity, float x, float y, float z, float radius, int p6, BOOL p7) { Function.Call(0x1854217C640B39EC, ped, entity, x, y, z, radius, p6, p7); }
		public static void _SET_PED_DEFENSIVE_AREA_TO_ANGLED_AREA(int ped, float x1, float y1, float z1, float x2, float y2, float z2, Any p7, BOOL p8, BOOL p9, int entity, BOOL p11) { Function.Call(0xEB2BFE5D009F0331, ped, x1, y1, z1, x2, y2, z2, p7, p8, p9, entity, p11); }
		public static void SET_PED_DEFENSIVE_AREA_DIRECTION(int ped, float p1, float p2, float p3, BOOL p4) { Function.Call(0x413C6C763A4AFFAD, ped, p1, p2, p3, p4); }
		public static void REMOVE_PED_DEFENSIVE_AREA(int ped, BOOL toggle) { Function.Call(0x74D4E028107450A9, ped, toggle); }
		public static Vector3 GET_PED_DEFENSIVE_AREA_POSITION(int ped, BOOL p1) { return Function.Call<Vector3>(0x3C06B8786DD94CD1, ped, p1); }
		public static BOOL IS_PED_DEFENSIVE_AREA_ACTIVE(int ped, BOOL p1) { return Function.Call<BOOL>(0xBA63D9FE45412247, ped, p1); }
		public static Volume _GET_PED_DEFENSIVE_VOLUME(int ped, Any p1) { return Function.Call<Volume>(0xEF2E6F870783369B, ped, p1); }
		public static void _0x4EC4EA2F72B36358(int ped, BOOL p1) { Function.Call(0x4EC4EA2F72B36358, ped, p1); }
		public static void _0xCF0B19806473D324(int ped, float x, float y, float z) { Function.Call(0xCF0B19806473D324, ped, x, y, z); }
		public static void _0xB4B7C92FCE7347B7(int ped) { Function.Call(0xB4B7C92FCE7347B7, ped); }
		public static void REVIVE_INJURED_PED(int ped) { Function.Call(0x8D8ACD8388CD99CE, ped); }
		public static void RESURRECT_PED(int ped) { Function.Call(0x71BC8E838B9C6035, ped); }
		public static void SET_PED_NAME_DEBUG(int ped, string name) { Function.Call(0x98EFA132A4117BE1, ped, name); }
		public static void _0xF9ACF4A08098EA25(int ped, BOOL p1) { Function.Call(0xF9ACF4A08098EA25, ped, p1); }
		public static BOOL _0x7020839C7302D8AC(int ped) { return Function.Call<BOOL>(0x7020839C7302D8AC, ped); }
		public static void _0xE1AADD0055D76603(int ped, int entity, int boneIndex1, int boneIndex2, float x, float y, float z, float p7, BOOL p8, BOOL p9, int p10) { Function.Call(0xE1AADD0055D76603, ped, entity, boneIndex1, boneIndex2, x, y, z, p7, p8, p9, p10); }
		public static void _0x5A1A929C8B729B4A(int ped) { Function.Call(0x5A1A929C8B729B4A, ped); }
		public static void _0x97A38B65EBDA3D50(int ped, BOOL p1) { Function.Call(0x97A38B65EBDA3D50, ped, p1); }
		public static BOOL _0x06A10B4D7F50B0C3(int ped) { return Function.Call<BOOL>(0x06A10B4D7F50B0C3, ped); }
		public static BOOL _0x88A5564B19C15391(int ped) { return Function.Call<BOOL>(0x88A5564B19C15391, ped); }
		public static int _0x354CA4DDDEEC397A(int ped) { return Function.Call<int>(0x354CA4DDDEEC397A, ped); }
		public static void _0xFEA6126C34DF2532(int ped, BOOL p1) { Function.Call(0xFEA6126C34DF2532, ped, p1); }
		public static void _0xA967D6A8ED2D713B(int ped, BOOL p1) { Function.Call(0xA967D6A8ED2D713B, ped, p1); }
		public static unsafe void APPLY_PED_BLOOD_SPECIFIC(int ped, Any p1, float p2, float p3, float p4, float p5, Any p6, float p7, Any* p8) { Function.Call(0xEF0D582CBF2D9B0F, ped, p1, p2, p3, p4, p5, p6, p7, p8); }
		public static void _0x58D32261AE0F0843(int ped, int boneId, float p2, float p3, float p4, float p5, float p6, float p7, string p8) { Function.Call(0x58D32261AE0F0843, ped, boneId, p2, p3, p4, p5, p6, p7, p8); }
		public static void _0x735662994E60A710(int ped, BOOL p1) { Function.Call(0x735662994E60A710, ped, p1); }
		public static void _0x91BAB9E064F036CD(Any p0, Any p1) { Function.Call(0x91BAB9E064F036CD, p0, p1); }
		public static void _0x897934E868EDDD6C(int ped, int p1, float p2, float p3, float p4) { Function.Call(0x897934E868EDDD6C, ped, p1, p2, p3, p4); }
		public static void _SET_PED_ACTIVATE_WOUND_EFFECT(int ped, int p1, int boneId, float moveWoundLeftRight, float bloodFountainPressure, float yaw, float bloodFountainDirection, float bloodFountainPulse, float p8, float p9) { Function.Call(0xFFD54D9FE71B966A, ped, p1, boneId, moveWoundLeftRight, bloodFountainPressure, yaw, bloodFountainDirection, bloodFountainPulse, p8, p9); }
		public static void _UPDATE_PED_WOUND_EFFECT(int ped, float value) { Function.Call(0x66B1CB778D911F49, ped, value); }
		public static void APPLY_PED_DAMAGE_PACK(int ped, string damagePack, float damage, float mult) { Function.Call(0x46DF918788CB093F, ped, damagePack, damage, mult); }
		public static void CLEAR_PED_BLOOD_DAMAGE(int ped) { Function.Call(0x8FE22675A5A45817, ped); }
		public static void CLEAR_PED_BLOOD_DAMAGE_BY_ZONE(int ped, int p1) { Function.Call(0x56E3B78C5408D9F4, ped, p1); }
		public static void CLEAR_PED_DAMAGE_DECAL_BY_ZONE(int ped, int p1, string p2) { Function.Call(0x523C79AEEFCC4A2A, ped, p1, p2); }
		public static void _CLEAR_PED_BLOOD_DAMAGE_FACIAL(int ped, int p1) { Function.Call(0x7F5D88333EE8A86F, ped, p1); }
		public static void _0x34C11114887150FD(Any p0, Any p1) { Function.Call(0x34C11114887150FD, p0, p1); }
		public static void _0xD8544F6260F5F01E(int ped, int p1) { Function.Call(0xD8544F6260F5F01E, ped, p1); }
		public static void _0xEB8886E1065654CD(int ped, int p1, string p2, float p3) { Function.Call(0xEB8886E1065654CD, ped, p1, p2, p3); }
		public static unsafe void FADE_AND_DESTROY_PED(int* ped) { Function.Call(0x7043D0681285BA2D, ped); }
		public static BOOL _IS_PED_QUEUED_FOR_DELETION(int ped) { return Function.Call<BOOL>(0x8D9BFCE3352DE47F, ped); }
		public static void CLEAR_PED_WETNESS(int ped) { Function.Call(0x9C720776DAA43E7E, ped); }
		public static void SET_PED_WETNESS_HEIGHT(int ped, float height) { Function.Call(0x44CB6447D2571AA0, ped, height); }
		public static void _0xF9CFF5BB70E8A2CB(int ped, float p1) { Function.Call(0xF9CFF5BB70E8A2CB, ped, p1); }
		public static void SET_PED_WETNESS_ENABLED_THIS_FRAME(int ped) { Function.Call(0xB5485E4907B53019, ped); }
		public static void _0xA7A806677F8DE138(int ped) { Function.Call(0xA7A806677F8DE138, ped); }
		public static void _0xA064BBABB064446F(Any p0) { Function.Call(0xA064BBABB064446F, p0); }
		public static void CLEAR_PED_ENV_DIRT(int ped) { Function.Call(0x6585D955A68452A5, ped); }
		public static void SET_PED_SWEAT(int ped, float sweat) { Function.Call(0x27B0405F59637D1F, ped, sweat); }
		public static void CLEAR_PED_DECORATIONS(int ped) { Function.Call(0x0E5173C163976E38, ped); }
		public static BOOL WAS_PED_SKELETON_UPDATED(int ped) { return Function.Call<BOOL>(0x11B499C1E0FF8559, ped); }
		public static Vector3 GET_PED_BONE_COORDS(int ped, int boneId, float offsetX, float offsetY, float offsetZ) { return Function.Call<Vector3>(0x17C07FC640E86B4E, ped, boneId, offsetX, offsetY, offsetZ); }
		public static int ADD_SCENARIO_BLOCKING_AREA(float x1, float y1, float z1, float x2, float y2, float z2, BOOL p6, int blockingFlags) { return Function.Call<int>(0x1B5C85C612E5256E, x1, y1, z1, x2, y2, z2, p6, blockingFlags); }
		public static void REMOVE_SCENARIO_BLOCKING_AREAS() { Function.Call(0xD37401D78A929A49); }
		public static void REMOVE_SCENARIO_BLOCKING_AREA(Any p0, BOOL p1) { Function.Call(0x31D16B74C6E29D66, p0, p1); }
		public static Any _ADD_SCENARIO_BLOCKING_VOLUME(Volume volume, BOOL p1, int flag) { return Function.Call<Any>(0x4C39C95AE5DB1329, volume, p1, flag); }
		public static Any _0x6F46F8ACB44C4FC1(Any p0) { return Function.Call<Any>(0x6F46F8ACB44C4FC1, p0); }
		public static BOOL _IS_SCENARIO_BLOCKING_AREA_VALID(Any p0) { return Function.Call<BOOL>(0x91A5F9CBEBB9D936, p0); }
		public static BOOL IS_PED_USING_SCENARIO_HASH(int ped, Hash scenarioHash) { return Function.Call<BOOL>(0x34D6AC1157C8226C, ped, scenarioHash); }
		public static BOOL IS_PED_USING_ANY_SCENARIO(int ped) { return Function.Call<BOOL>(0x57AB4A3080F85143, ped); }
		public static BOOL IS_PED_USING_THIS_SCENARIO(int ped, int scenario) { return Function.Call<BOOL>(0x9C54041BB66BCF9E, ped, scenario); }
		public static BOOL _CAN_PED_USE_SCENARIO_POINT(int ped, int scenario, Any p2, Any p3, Any p4) { return Function.Call<BOOL>(0xAB643407D0B26F07, ped, scenario, p2, p3, p4); }
		public static BOOL _0x1148F706CF4EBDDA(int ped, Hash p1, int p2) { return Function.Call<BOOL>(0x1148F706CF4EBDDA, ped, p1, p2); }
		public static BOOL SET_PED_PANIC_EXIT_SCENARIO(int ped, float x, float y, float z) { return Function.Call<BOOL>(0xFE07FF6495D52E2A, ped, x, y, z); }
		public static void _SET_PED_SCARED_WHEN_USING_SCENARIO(int ped, BOOL toggle) { Function.Call(0x9A77DFD295E29B09, ped, toggle); }
		public static void _0xD8CEEED54C672B5D(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6) { Function.Call(0xD8CEEED54C672B5D, p0, p1, p2, p3, p4, p5, p6); }
		public static BOOL _SET_PED_SHOULD_PLAY_DIRECTED_SCENARIO_EXIT(int ped, float x, float y, float z) { return Function.Call<BOOL>(0xEC6935EBE0847B90, ped, x, y, z); }
		public static void SET_PED_SHOULD_PLAY_NORMAL_SCENARIO_EXIT(int ped) { Function.Call(0xA3A9299C4F2ADB98, ped); }
		public static void SET_PED_SHOULD_PLAY_IMMEDIATE_SCENARIO_EXIT(int ped) { Function.Call(0xF1C03A5352243A30, ped); }
		public static BOOL SET_PED_SHOULD_PLAY_FLEE_SCENARIO_EXIT(int ped, float x, float y, float z, int lookIntensity) { return Function.Call<BOOL>(0xEEED8FAFEC331A70, ped, x, y, z, lookIntensity); }
		public static BOOL SET_PED_SHOULD_PLAY_COMBAT_SCENARIO_EXIT(int ped, float x, float y, float z, int lookIntensity) { return Function.Call<BOOL>(0x802092B07E3B1EEA, ped, x, y, z, lookIntensity); }
		public static BOOL SET_PED_SHOULD_PLAY_EMOTIONAL_SCENARIO_EXIT(int ped, float x, float y, float z, int lookIntensity, BOOL p5) { return Function.Call<BOOL>(0x62FDAD5E01D2DD47, ped, x, y, z, lookIntensity, p5); }
		public static BOOL SET_PED_SHOULD_PLAY_QUICK_SCENARIO_EXIT(int ped, float x, float y, float z, int lookIntensity, BOOL p5) { return Function.Call<BOOL>(0x463803429297117C, ped, x, y, z, lookIntensity, p5); }
		public static BOOL _0xF9331B3A314EB49D(int ped) { return Function.Call<BOOL>(0xF9331B3A314EB49D, ped); }
		public static void _0xE735A7DA22E88359(Any p0) { Function.Call(0xE735A7DA22E88359, p0); }
		public static Any _0x82CB0F3F0C7785E5(Any p0) { return Function.Call<Any>(0x82CB0F3F0C7785E5, p0); }
		public static void _0xCA95C156C14B2054(Any p0, Any p1) { Function.Call(0xCA95C156C14B2054, p0, p1); }
		public static void SET_FACIAL_IDLE_ANIM_OVERRIDE(int ped, string animName, string animDict) { Function.Call(0xFFC24B988B938B38, ped, animName, animDict); }
		public static void CLEAR_FACIAL_IDLE_ANIM_OVERRIDE(int ped) { Function.Call(0x726256CC1EEB182F, ped); }
		public static void _REQUEST_PED_FACIAL_MOOD_THIS_FRAME(int ped, Hash mood, int p2) { Function.Call(0x8B3B71C80A29A4BB, ped, mood, p2); }
		public static void _0xD2F0FE8805D91647(Any p0, Any p1) { Function.Call(0xD2F0FE8805D91647, p0, p1); }
		public static void SET_PED_CAN_PLAY_GESTURE_ANIMS(int ped, Any p1, Any p2) { Function.Call(0xBAF20C5432058024, ped, p1, p2); }
		public static void _0x7EDB3C766B0D073F(int ped) { Function.Call(0x7EDB3C766B0D073F, ped); }
		public static void SET_PED_CAN_PLAY_AMBIENT_ANIMS(int ped, BOOL toggle) { Function.Call(0x6373D1349925A70E, ped, toggle); }
		public static void SET_PED_CAN_PLAY_AMBIENT_BASE_ANIMS(int ped, BOOL toggle) { Function.Call(0x0EB0585D15254740, ped, toggle); }
		public static void _0x4F63433CE3C08230(int ped, BOOL p1) { Function.Call(0x4F63433CE3C08230, ped, p1); }
		public static void SET_PED_CAN_ARM_IK(int ped, BOOL toggle) { Function.Call(0x6C3B4D6D13B4C841, ped, toggle); }
		public static void _SET_PED_CAN_UNK_BODYPART_IK(int ped, BOOL toggle) { Function.Call(0xEE9DF765990E8D1D, ped, toggle); }
		public static void SET_PED_CAN_HEAD_IK(int ped, BOOL toggle) { Function.Call(0xC11C18092C5530DC, ped, toggle); }
		public static void SET_PED_CAN_LEG_IK(int ped, BOOL toggle) { Function.Call(0x73518ECE2485412B, ped, toggle); }
		public static void SET_PED_CAN_TORSO_IK(int ped, BOOL toggle) { Function.Call(0xF2B7106D37947CE0, ped, toggle); }
		public static void SET_PED_CAN_TORSO_REACT_IK(int ped, BOOL toggle) { Function.Call(0xF5846EDB26A98A24, ped, toggle); }
		public static void SET_PED_CAN_TORSO_VEHICLE_IK(int ped, BOOL toggle) { Function.Call(0x6647C5F6F5792496, ped, toggle); }
		public static void SET_PED_CAN_USE_AUTO_CONVERSATION_LOOKAT(int ped, BOOL toggle) { Function.Call(0xEC4686EC06434678, ped, toggle); }
		public static BOOL IS_PED_HEADTRACKING_PED(int ped1, int ped2) { return Function.Call<BOOL>(0x5CD3CB88A7F8850D, ped1, ped2); }
		public static BOOL IS_PED_HEADTRACKING_ENTITY(int ped, int entity) { return Function.Call<BOOL>(0x813A0A7C9D2E831F, ped, entity); }
		public static void _DISABLE_AMBIENT_LOOK_AT_REQUESTS(Any p0, Any p1) { Function.Call(0x80038740C96AD17F, p0, p1); }
		public static void _DISABLE_ALL_LOOK_AT_REQUESTS(int ped, int p1) { Function.Call(0xE1965A380342BE1F, ped, p1); }
		public static void _0xCD9E5F94A2F38683(int ped, BOOL p1) { Function.Call(0xCD9E5F94A2F38683, ped, p1); }
		public static void SET_PED_CLOTH_PACKAGE_INDEX(int ped, BOOL p1) { Function.Call(0x78C4E9961DB3EB5B, ped, p1); }
		public static void _0x1D4636C90BBEFACB(int ped, int p1) { Function.Call(0x1D4636C90BBEFACB, ped, p1); }
		public static void _0xEF371232BC6053E1(int ped) { Function.Call(0xEF371232BC6053E1, ped); }
		public static void _0x86F0B6730C32AC14(int ped, BOOL p1) { Function.Call(0x86F0B6730C32AC14, ped, p1); }
		public static void _0x8101BA1C0B462412(int ped, int ropeId) { Function.Call(0x8101BA1C0B462412, ped, ropeId); }
		public static void SET_PED_CONFIG_FLAG(int ped, int flagId, BOOL value) { Function.Call(0x1913FE4CBF41C463, ped, flagId, value); }
		public static void SET_PED_RESET_FLAG(int ped, int flagId, BOOL doReset) { Function.Call(0xC1E8A365BF3B29F2, ped, flagId, doReset); }
		public static BOOL GET_PED_CONFIG_FLAG(int ped, int flagId, BOOL p2) { return Function.Call<BOOL>(0x7EE53118C892B513, ped, flagId, p2); }
		public static BOOL GET_PED_RESET_FLAG(int ped, int flagId) { return Function.Call<BOOL>(0xAF9E59B1B1FBF2A0, ped, flagId); }
		public static void _0xC6981AFF6D2A71C2(Any p0) { Function.Call(0xC6981AFF6D2A71C2, p0); }
		public static void _0xE0FE107AB174D64A(Any p0, Any p1) { Function.Call(0xE0FE107AB174D64A, p0, p1); }
		public static void SET_PED_GROUP_MEMBER_PASSENGER_INDEX(int ped, int index) { Function.Call(0x0BDDB8D9EC6BCF3C, ped, index); }
		public static unsafe BOOL IS_PED_EVASIVE_DIVING(int ped, int* evadingEntity) { return Function.Call<BOOL>(0x414641C26E105898, ped, evadingEntity); }
		public static Any _SHOOT_TRIGGER_AT_COORDS(int ped, float x, float y, float z, int p4, float p5, int p6, float p7) { return Function.Call<Any>(0x4C57F27D1554E6B0, ped, x, y, z, p4, p5, p6, p7); }
		public static BOOL _IS_THIS_MODEL_A_HORSE(Hash model) { return Function.Call<BOOL>(0x772A1969F649E902, model); }
		public static void SET_PED_MODEL_IS_SUPPRESSED(int ped, BOOL toggle) { Function.Call(0xE163A4BCE4DE6F11, ped, toggle); }
		public static BOOL _IS_PED_MODEL_SUPPRESSED(Hash model) { return Function.Call<BOOL>(0xAA9F048DCF69B6DC, model); }
		public static void _0x7ABBD9E449E0DB00(Any p0, Any p1) { Function.Call(0x7ABBD9E449E0DB00, p0, p1); }
		public static void _SET_PED_DISABLE_KICK_MOVE(int ped, BOOL disable) { Function.Call(0xADD31A5C7A5FAA73, ped, disable); }
		public static void SET_PED_CAN_RAGDOLL_FROM_PLAYER_IMPACT(int ped, BOOL toggle) { Function.Call(0xDF993EE5E90ABA25, ped, toggle); }
		public static void _0xE6CB36F43A95D75F(Any p0) { Function.Call(0xE6CB36F43A95D75F, p0); }
		public static void SET_PED_LEG_IK_MODE(int ped, int mode) { Function.Call(0xC396F5B86FF9FEBD, ped, mode); }
		public static BOOL _0x078076AB50FB117F(int ped, float x, float y, float z, float p4, BOOL p5) { return Function.Call<BOOL>(0x078076AB50FB117F, ped, x, y, z, p4, p5); }
		public static void _SET_PED_CAN_BE_LASSOED(int ped, BOOL toggle) { Function.Call(0xFD6943B6DF77E449, ped, toggle); }
		public static void SET_PED_COMBAT_MOVEMENT(int ped, int combatMovement) { Function.Call(0x4D9CA1009AFBD057, ped, combatMovement); }
		public static int GET_PED_COMBAT_MOVEMENT(int ped) { return Function.Call<int>(0xDEA92412FCAEB3F5, ped); }
		public static void _0x815C0074A1BC0D93(int ped, int p1) { Function.Call(0x815C0074A1BC0D93, ped, p1); }
		public static int _0xFFDE295662405B25(int ped) { return Function.Call<int>(0xFFDE295662405B25, ped); }
		public static void SET_PED_COMBAT_ABILITY(int ped, int abilityLevel) { Function.Call(0xC7622C0D36B2FDA8, ped, abilityLevel); }
		public static void SET_PED_COMBAT_RANGE(int ped, int range) { Function.Call(0x3C606747B23E497B, ped, range); }
		public static void SET_PED_COMBAT_ATTRIBUTES(int ped, int attributeIndex, BOOL enabled) { Function.Call(0x9F7794730795E019, ped, attributeIndex, enabled); }
		public static BOOL _GET_PED_COMBAT_ATTRIBUTE(int ped, int attributeIndex) { return Function.Call<BOOL>(0xCC2B20596E29E4E3, ped, attributeIndex); }
		public static void _SET_PED_COMBAT_ATTRIBUTE_HASH(int ped, Hash p1) { Function.Call(0xBD75500141E4725C, ped, p1); }
		public static void SET_PED_TARGET_LOSS_RESPONSE(int ped, int responseType) { Function.Call(0x0703B9079823DA4A, ped, responseType); }
		public static void _0x0A4618FFD517E24D(Any p0, Any p1) { Function.Call(0x0A4618FFD517E24D, p0, p1); }
		public static void _0x712B2C2B2471B493(int ped, Hash p1) { Function.Call(0x712B2C2B2471B493, ped, p1); }
		public static void _0x00B380FF2DF6AB7A(Any p0, Any p1) { Function.Call(0x00B380FF2DF6AB7A, p0, p1); }
		public static void _SET_PED_COMBAT_STYLE(int ped, Hash combatStyleHash, int p2, float duration) { Function.Call(0x8ACC0506743A8A5C, ped, combatStyleHash, p2, duration); }
		public static void _CLEAR_PED_COMBAT_STYLE(int ped, int p1) { Function.Call(0x78815FC52832B690, ped, p1); }
		public static void _SET_PED_COMBAT_STYLE_MOD(int ped, Hash combatStyleModHash, float duration) { Function.Call(0x8B1E8E35A6E814EA, ped, combatStyleModHash, duration); }
		public static void _0x1FA132CBCD7CB239(int ped, Hash p1) { Function.Call(0x1FA132CBCD7CB239, ped, p1); }
		public static BOOL _0x5BF0B9D9A8E227A0(int ped) { return Function.Call<BOOL>(0x5BF0B9D9A8E227A0, ped); }
		public static void _0x642720D8D69328B6(int ped, Hash p1) { Function.Call(0x642720D8D69328B6, ped, p1); }
		public static BOOL IS_PED_PERFORMING_MELEE_ACTION(int ped, int p1, Hash p2) { return Function.Call<BOOL>(0xDCCA191DF9980FD7, ped, p1, p2); }
		public static BOOL _0x99DF2639DA76C1DC(int ped1, int ped2, int p2) { return Function.Call<BOOL>(0x99DF2639DA76C1DC, ped1, ped2, p2); }
		public static float _GET_PED_MELEE_ACTION_PHASE(int ped) { return Function.Call<float>(0x6127F25ED21C533C, ped); }
		public static BOOL IS_PED_BEING_STEALTH_KILLED(int ped) { return Function.Call<BOOL>(0x863B23EFDE9C5DF2, ped); }
		public static int GET_MELEE_TARGET_FOR_PED(int ped) { return Function.Call<int>(0x18A3E9EE1297FD39, ped); }
		public static void _0xDEDBED3020DA49DC(Any p0) { Function.Call(0xDEDBED3020DA49DC, p0); }
		public static void _0xA405BF9F01960C16(Any p0) { Function.Call(0xA405BF9F01960C16, p0); }
		public static Hash _GET_PED_BRAWLING_STYLE(int ped) { return Function.Call<Hash>(0xEC6B59BE445FEC51, ped); }
		public static void _SET_PED_BRAWLING_STYLE(int ped, Hash brawlingStyle) { Function.Call(0x8BA83CC4288CD56D, ped, brawlingStyle); }
		public static void _0x9D8DFE2DE9CB4DFC(int ped) { Function.Call(0x9D8DFE2DE9CB4DFC, ped); }
		public static Any _0xC48AF420371C7407(Any p0, Any p1) { return Function.Call<Any>(0xC48AF420371C7407, p0, p1); }
		public static Any _0x5EFA8A3D8A60D662(Any p0, Any p1) { return Function.Call<Any>(0x5EFA8A3D8A60D662, p0, p1); }
		public static Any _0x242EDF85D4E87B65(Any p0) { return Function.Call<Any>(0x242EDF85D4E87B65, p0); }
		public static void _SET_PED_COMBAT_BEHAVIOUR(int ped, Hash behaviour) { Function.Call(0x9238A3D970BBB0A9, ped, behaviour); }
		public static void _0x9A4AC116CC1EEE14(Any p0) { Function.Call(0x9A4AC116CC1EEE14, p0); }
		public static void _0xE20027B414BFE6C7(Any p0, Any p1) { Function.Call(0xE20027B414BFE6C7, p0, p1); }
		public static void _SET_PED_BEAT_MULTIPLIER(int ped, float p1) { Function.Call(0x6DBF2D78709AD70B, ped, p1); }
		public static void _SET_PED_ACTION_DISABLE_FLAG(int ped, int actionDisableFlag) { Function.Call(0xB8DE69D9473B7593, ped, actionDisableFlag); }
		public static void _CLEAR_PED_ACTION_DISABLE_FLAG(int ped, int actionDisableFlag) { Function.Call(0x949B2F9ED2917F5D, ped, actionDisableFlag); }
		public static BOOL _IS_PED_ACTION_DISABLE_FLAG_ENABLED(int ped, int actionDisableFlag) { return Function.Call<BOOL>(0xB346C85D49CC998E, ped, actionDisableFlag); }
		public static void _SET_PED_TARGET_ACTION_DISABLE_FLAG(int ped, int actionDisableFlag) { Function.Call(0xC163DAC52AC975D3, ped, actionDisableFlag); }
		public static void _CLEAR_PED_TARGET_ACTION_DISABLE_FLAG(int ped, int actionDisableFlag) { Function.Call(0xBBF6D1D07C02D00A, ped, actionDisableFlag); }
		public static BOOL _IS_PED_TARGET_ACTION_DISABLE_FLAG_ENABLED(int ped, int actionDisableFlag) { return Function.Call<BOOL>(0x02AA2096FE00F3E1, ped, actionDisableFlag); }
		public static void _0x57F35552E771BE9D(int ped, int p1) { Function.Call(0x57F35552E771BE9D, ped, p1); }
		public static void _0x7C10221CE718AA72(int ped, int p1) { Function.Call(0x7C10221CE718AA72, ped, p1); }
		public static BOOL _0x0D3B1568917EBDA0(int ped, int p1) { return Function.Call<BOOL>(0x0D3B1568917EBDA0, ped, p1); }
		public static void _0x29F3539189D3E277(Any p0, Any p1) { Function.Call(0x29F3539189D3E277, p0, p1); }
		public static void _0xE9E06EA514A69061(Any p0, Any p1) { Function.Call(0xE9E06EA514A69061, p0, p1); }
		public static void _SET_PED_WRITHING_DURATION(int ped, float writhingDuration1, float writhingDuration2, int p3) { Function.Call(0x4DB9D03AC4E1FA84, ped, writhingDuration1, writhingDuration2, p3); }
		public static float _GET_PED_REMAINING_REVIVAL_TIME(int ped, BOOL normalized) { return Function.Call<float>(0xEBE89623EB861271, ped, normalized); }
		public static void SET_PAUSE_PED_WRITHE_BLEEDOUT(int ped, BOOL toggle) { Function.Call(0x925A160133003AC6, ped, toggle); }
		public static BOOL _0x12EB4E31F092C9B3(int ped) { return Function.Call<BOOL>(0x12EB4E31F092C9B3, ped); }
		public static BOOL GET_PED_IS_GRAPPLING(int ped) { return Function.Call<BOOL>(0x0E99E3BF11BB6367, ped); }
		public static BOOL GET_PED_IS_BEING_GRAPPLED(int ped) { return Function.Call<BOOL>(0x3BDFCF25B58B0415, ped); }
		public static int _GET_PED_GRAPPLER(int ped) { return Function.Call<int>(0xD0B7AEB56229D317, ped); }
		public static int GET_PED_GRAPPLE_STATE(int ped) { return Function.Call<int>(0x2311F15D971AA680, ped); }
		public static Hash _GET_PED_GRAPPLE_STYLE(int ped) { return Function.Call<Hash>(0x753B15AD0FD6F3E3, ped); }
		public static Any _SET_PED_GRAPPLE_STYLE(int ped, Hash style) { return Function.Call<Any>(0x630E7B01F091A197, ped, style); }
		public static void _SET_PED_GRAPPLE_SEQUENCE(int ped, string grappleSequence) { Function.Call(0x604190F0CF0DF158, ped, grappleSequence); }
		public static void _SET_PED_GRAPPLE_FLAG(int ped, int flag, BOOL enable) { Function.Call(0x789DABD18E9024DB, ped, flag, enable); }
		public static void _CLEAR_PED_GRAPPLE_FLAG(int ped, int flag) { Function.Call(0xEAE3B5B019C8D23F, ped, flag); }
		public static int _GET_PED_GRAPPLE_FLAG(int ped) { return Function.Call<int>(0xF3C873ED0C595109, ped); }
		public static void _SET_PED_GRAPPLE_ACTION(int ped, Hash grappleAction) { Function.Call(0x8301D87B1B89E219, ped, grappleAction); }
		public static Any _SET_PED_GRAPPLE_EFFECT_MULTIPLIER(int ped, float multiplier) { return Function.Call<Any>(0x99A6E246C315BF60, ped, multiplier); }
		public static void _SET_PED_GRAPPLE_ANIMATION(int ped, Hash grappleAnim) { Function.Call(0x56E9C26CD29D1ED6, ped, grappleAnim); }
		public static void SET_PED_FLEE_ATTRIBUTES(int ped, int attributeFlags, BOOL enable) { Function.Call(0x70A2D1137C8ED7C9, ped, attributeFlags, enable); }
		public static BOOL _IS_PED_COWERING(int ped) { return Function.Call<BOOL>(0xB086C8C0F5701D14, ped); }
		public static BOOL IS_ANY_PED_NEAR_POINT(float x, float y, float z, float radius) { return Function.Call<BOOL>(0x083961498679DC9F, x, y, z, radius); }
		public static void FORCE_PED_AI_AND_ANIMATION_UPDATE(int ped, BOOL p1, BOOL p2) { Function.Call(0x2208438012482A1A, ped, p1, p2); }
		public static void _0xC2722B252C79E641(int ped, Any p1, Any p2, BOOL p3) { Function.Call(0xC2722B252C79E641, ped, p1, p2, p3); }
		public static BOOL _IS_PED_DOING_SCENARIO_TRANSITION(int ped) { return Function.Call<BOOL>(0xC488B8C0E52560D8, ped); }
		public static BOOL _0x2DC0E8DCBD3546E9(int ped) { return Function.Call<BOOL>(0x2DC0E8DCBD3546E9, ped); }
		public static void _ADD_SCENARIO_TRANSITION(int ped) { Function.Call(0x6D07B371E9439019, ped); }
		public static void _GIVE_PED_HASH_COMMAND(int ped, Hash commandHash, float activationDuration) { Function.Call(0xD65FDC686A031C83, ped, commandHash, activationDuration); }
		public static BOOL _GET_IS_PED_COMMAND_HASH_PRESENT(int ped, Hash commandHash) { return Function.Call<BOOL>(0x68821369A2CEADD5, ped, commandHash); }
		public static BOOL IS_PED_HEADING_TOWARDS_POSITION(int ped, float x, float y, float z, float p4) { return Function.Call<BOOL>(0xFCF37A457CB96DC0, ped, x, y, z, p4); }
		public static void _0x600BBDD29820370C(int ped) { Function.Call(0x600BBDD29820370C, ped); }
		public static void REQUEST_PED_VISIBILITY_TRACKING(int ped) { Function.Call(0x7D7A2E43E74E2EB8, ped); }
		public static void RELEASE_PED_VISIBILITY_TRACKING(int ped) { Function.Call(0x3088634CF8C819CF, ped); }
		public static void REQUEST_PED_VEHICLE_VISIBILITY_TRACKING(int ped, BOOL p1) { Function.Call(0x2BC338A7B21F4608, ped, p1); }
		public static void _0x75BA1CB3B7D40CAF(int ped, BOOL p1) { Function.Call(0x75BA1CB3B7D40CAF, ped, p1); }
		public static int GET_TRACKED_PED_PIXELCOUNT(int ped) { return Function.Call<int>(0x511F1A683387C7E2, ped); }
		public static BOOL IS_TRACKED_PED_VISIBLE(int ped) { return Function.Call<BOOL>(0x91C8E617F64188AC, ped); }
		public static BOOL _IS_TRACKED_PED_VISIBILITY_PERCENTAGE_NOT_LESS_THAN(int ped, float percent) { return Function.Call<BOOL>(0x164CECC59E70DF86, ped, percent); }
		public static BOOL _IS_PED_VISIBILITY_TRACKED(int ped) { return Function.Call<BOOL>(0x5102307CE88798EB, ped); }
		public static BOOL CAN_PED_BE_MOUNTED(int ped) { return Function.Call<BOOL>(0x2D64376CF437363E, ped); }
		public static BOOL _IS_METAPED_FISH(int ped) { return Function.Call<BOOL>(0x118D476A6F1A13F1, ped); }
		public static BOOL IS_EVENT_IN_QUEUE(int ped, Hash _eventType) { return Function.Call<BOOL>(0xC8D523BF5BBD3808, ped, _eventType); }
		public static int CAN_PED_SEE_ENTITY(int ped, int targetEntity, BOOL p2, BOOL p3) { return Function.Call<int>(0x7F9B9791D4CB71F6, ped, targetEntity, p2, p3); }
		public static int CAN_PED_SEE_PED_CACHED(int ped, int targetPed, BOOL p2) { return Function.Call<int>(0x9D9473CB82D83A30, ped, targetPed, p2); }
		public static float _0x0EA9EACBA3B01601(int ped1, int ped2, BOOL p2) { return Function.Call<float>(0x0EA9EACBA3B01601, ped1, ped2, p2); }
		public static int GET_PED_BONE_INDEX(int ped, int boneId) { return Function.Call<int>(0x3F428D08BE5AAE31, ped, boneId); }
		public static int _0xC5303F460A40D21D(int ped, int p1) { return Function.Call<int>(0xC5303F460A40D21D, ped, p1); }
		public static void _0xE29D8CD66553DBAA(int horse) { Function.Call(0xE29D8CD66553DBAA, horse); }
		public static void _0xB06F5F1DEF417216(Any p0, Any p1, Any p2, Any p3) { Function.Call(0xB06F5F1DEF417216, p0, p1, p2, p3); }
		public static void _0xFC23348F0F4E245F(Any p0, Any p1, Any p2, Any p3) { Function.Call(0xFC23348F0F4E245F, p0, p1, p2, p3); }
		public static void _0x9184788BFF1EDAD7(Any p0, Any p1) { Function.Call(0x9184788BFF1EDAD7, p0, p1); }
		public static void _SET_PED_DIRT_CLEANED(int ped, float p1, int p2, BOOL p3, BOOL p4) { Function.Call(0xE3144B932DFDFF65, ped, p1, p2, p3, p4); }
		public static Any _0x0105FEE8F9091255(Any p0, Any p1) { return Function.Call<Any>(0x0105FEE8F9091255, p0, p1); }
		public static void _0xD049920CD29F6CC8(Any p0, Any p1, Any p2, Any p3, Any p4) { Function.Call(0xD049920CD29F6CC8, p0, p1, p2, p3, p4); }
		public static Any _0xBB3E5370EBB6BE28(Any p0, Any p1) { return Function.Call<Any>(0xBB3E5370EBB6BE28, p0, p1); }
		public static void _0x2FA568BFA725F8D6(Any p0, Any p1, Any p2, Any p3) { Function.Call(0x2FA568BFA725F8D6, p0, p1, p2, p3); }
		public static Any _0x56E4BAD93D33453C(Any p0, Any p1) { return Function.Call<Any>(0x56E4BAD93D33453C, p0, p1); }
		public static void _0x75A082563B4452E5(Any p0, Any p1, Any p2, Any p3) { Function.Call(0x75A082563B4452E5, p0, p1, p2, p3); }
		public static void _0x16802C32B2FCA06B(Any p0, Any p1, Any p2, Any p3) { Function.Call(0x16802C32B2FCA06B, p0, p1, p2, p3); }
		public static void _0x8BA0C65AC15A7D33(Any p0, Any p1, Any p2, Any p3) { Function.Call(0x8BA0C65AC15A7D33, p0, p1, p2, p3); }
		public static void _0x0FFDF937E5C11382(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5) { Function.Call(0x0FFDF937E5C11382, p0, p1, p2, p3, p4, p5); }
		public static void _0x5FCF25D584065BFD(Any p0, Any p1, Any p2, Any p3) { Function.Call(0x5FCF25D584065BFD, p0, p1, p2, p3); }
		public static void _0xA2116C1E4ED85C24(int ped, BOOL inverted) { Function.Call(0xA2116C1E4ED85C24, ped, inverted); }
		public static BOOL FORCE_PED_MOTION_STATE(int ped, Hash motionStateHash, BOOL p2, int p3, BOOL p4) { return Function.Call<BOOL>(0xF28965D04F570DCA, ped, motionStateHash, p2, p3, p4); }
		public static void _0x75D3333409CD33CE(Any p0, Any p1, Any p2) { Function.Call(0x75D3333409CD33CE, p0, p1, p2); }
		public static unsafe BOOL _GET_PED_CURRENT_MOVEMENT_SPEED(int ped, float* speedX, float* speedY) { return Function.Call<BOOL>(0xF60165E1D2C5370B, ped, speedX, speedY); }
		public static void SET_PED_MAX_MOVE_BLEND_RATIO(int ped, float value) { Function.Call(0x433083750C5E064A, ped, value); }
		public static void SET_PED_MIN_MOVE_BLEND_RATIO(int ped, float value) { Function.Call(0x01A898D26E2333DD, ped, value); }
		public static void _0xBC1DC48270468444(Any p0) { Function.Call(0xBC1DC48270468444, p0); }
		public static float _0x46BF2A810679D6E6(int ped, float maxMoveBlendRatio) { return Function.Call<float>(0x46BF2A810679D6E6, ped, maxMoveBlendRatio); }
		public static float _0xCA95924C893A0C91(int ped, float p1) { return Function.Call<float>(0xCA95924C893A0C91, ped, p1); }
		public static void _HORSE_AGITATE(int mount, BOOL kickOffRider) { Function.Call(0xBAE08F00021BFFB2, mount, kickOffRider); }
		public static void _0x413697EC260AABBF(Any p0, Any p1, Any p2) { Function.Call(0x413697EC260AABBF, p0, p1, p2); }
		public static void _0xCAC43D060099EA72(int ped) { Function.Call(0xCAC43D060099EA72, ped); }
		public static void _0xC9151483CC06A414(int ped) { Function.Call(0xC9151483CC06A414, ped); }
		public static void _0xAD3330E3C3E98007(Any p0, Any p1) { Function.Call(0xAD3330E3C3E98007, p0, p1); }
		public static Any _0xB8E2D655E1D5BD39(Any p0) { return Function.Call<Any>(0xB8E2D655E1D5BD39, p0); }
		public static Any _0x7BB810E8B343AC7B(Any p0) { return Function.Call<Any>(0x7BB810E8B343AC7B, p0); }
		public static void SET_PED_MOVE_RATE_OVERRIDE(int ped, float value) { Function.Call(0x085BF80FA50A39D1, ped, value); }
		public static unsafe int GET_PED_NEARBY_VEHICLES(int ped, Any* sizeAndVehs) { return Function.Call<int>(0xCFF869CBFA210D82, ped, sizeAndVehs); }
		public static unsafe int GET_PED_NEARBY_PEDS(int ped, Any* sizeAndPeds, int ignoredPedType, int p3) { return Function.Call<int>(0x23F8F5FC7E8C4A6B, ped, sizeAndPeds, ignoredPedType, p3); }
		public static BOOL IS_PED_READY_TO_RENDER(int ped) { return Function.Call<BOOL>(0xA0BC8FAED8CFEB3C, ped); }
		public static void _0x6A489892E813951A(Any p0) { Function.Call(0x6A489892E813951A, p0); }
		public static BOOL IS_PED_USING_ACTION_MODE(int ped) { return Function.Call<BOOL>(0x00E73468D085F745, ped); }
		public static BOOL _IS_PED_USING_ACTION_MODE_2(int ped) { return Function.Call<BOOL>(0xEBB208D6AE712C03, ped); }
		public static void SET_PED_USING_ACTION_MODE(int ped, BOOL bActionModeEnabled, int p2, string action) { Function.Call(0xD75ACCF5E0FB5367, ped, bActionModeEnabled, p2, action); }
		public static void SET_PED_CAPSULE(int ped, float value) { Function.Call(0x364DF566EC833DE2, ped, value); }
		public static int _GET_RIDER_OF_MOUNT(int mount, BOOL p1) { return Function.Call<int>(0xB676EFDA03DADA52, mount, p1); }
		public static void SPAWNPOINTS_START_SEARCH(float x, float y, float z, float width, float p4, int spawnpointsFlag, float p6, int duration, float p8) { Function.Call(0x2DF9038C90AD5264, x, y, z, width, p4, spawnpointsFlag, p6, duration, p8); }
		public static void SPAWNPOINTS_START_SEARCH_IN_ANGLED_AREA(float x1, float y1, float z1, float x2, float y2, float z2, float width, int spawnpointsFlag, float p8, int duration, float p10) { Function.Call(0xB2AFF10216DEFA2F, x1, y1, z1, x2, y2, z2, width, spawnpointsFlag, p8, duration, p10); }
		public static void _SPAWNPOINTS_START_SEARCH_WITH_VOLUME(Volume volume, int spawnpointsFlag, float p2, int duration, float p4) { Function.Call(0x83ED1FC9DF3411F5, volume, spawnpointsFlag, p2, duration, p4); }
		public static void SPAWNPOINTS_CANCEL_SEARCH() { Function.Call(0xFEE4A5459472A9F8); }
		public static BOOL SPAWNPOINTS_IS_SEARCH_ACTIVE() { return Function.Call<BOOL>(0x3C67506996001F5E); }
		public static BOOL SPAWNPOINTS_IS_SEARCH_COMPLETE() { return Function.Call<BOOL>(0xA586FBEB32A53DBB); }
		public static BOOL SPAWNPOINTS_IS_SEARCH_FAILED() { return Function.Call<BOOL>(0xF445DE8DA80A1792); }
		public static int SPAWNPOINTS_GET_NUM_SEARCH_RESULTS() { return Function.Call<int>(0xA635C11B8C44AFC2); }
		public static unsafe void SPAWNPOINTS_GET_SEARCH_RESULT(int randomInt, float* x, Any* y, float* z) { Function.Call(0x280C7E3AC7F56E90, randomInt, x, y, z); }
		public static unsafe void SPAWNPOINTS_GET_SEARCH_RESULT_FLAGS(Any p0, Any* p1) { Function.Call(0xB782F8238512BAD5, p0, p1); }
		public static void SET_IK_TARGET(int ped, int ikIndex, int entityLookAt, int boneLookAt, float offsetX, float offsetY, float offsetZ, Any p7, int blendInDuration, int blendOutDuration) { Function.Call(0xC32779C16FCEECD9, ped, ikIndex, entityLookAt, boneLookAt, offsetX, offsetY, offsetZ, p7, blendInDuration, blendOutDuration); }
		public static void _REQUEST_PED_EMOTIONAL_PRESET(int ped, string name) { Function.Call(0x5C3C55EAAD19915F, ped, name); }
		public static BOOL _HAS_PED_EMOTIONAL_PRESET_LOADED(int ped, string name) { return Function.Call<BOOL>(0xDE3904B22695D9F9, ped, name); }
		public static void _REMOVE_PED_EMOTIONAL_PRESET(int ped, string name) { Function.Call(0xFC3BAB1801A8255A, ped, name); }
		public static void _REQUEST_MOTION_TYPE_ASSET(Hash nameHash, int ped) { Function.Call(0xF7EA250B9A919E03, nameHash, ped); }
		public static BOOL HAS_MOTION_TYPE_ASSET_LOADED(Hash nameHash, int ped) { return Function.Call<BOOL>(0x854BC9B1A1CCD034, nameHash, ped); }
		public static void _REMOVE_MOTION_TYPE_ASSET(Hash nameHash, int ped) { Function.Call(0xDE7B2B4144906CDF, nameHash, ped); }
		public static BOOL _0x290B2E6CCDE532E1(int ped) { return Function.Call<BOOL>(0x290B2E6CCDE532E1, ped); }
		public static BOOL _0x0EEF7A81C17679DB(int ped) { return Function.Call<BOOL>(0x0EEF7A81C17679DB, ped); }
		public static void SET_PED_LOD_MULTIPLIER(int ped, float multiplier) { Function.Call(0xDC2C5C242AAC342B, ped, multiplier); }
		public static float _GET_PED_LOD_MULTIPLIER(int ped) { return Function.Call<float>(0x1B710E6F4AB69341, ped); }
		public static Any _0xA218D2BBCAA7388C(Any p0, Any p1) { return Function.Call<Any>(0xA218D2BBCAA7388C, p0, p1); }
		public static BOOL IS_ANY_HOSTILE_PED_NEAR_POINT(int ped, float x, float y, float z, float radius) { return Function.Call<BOOL>(0x68772DB2B2526F9F, ped, x, y, z, radius); }
		public static void _0xCBDE59C48F2B06F5(Any p0, Any p1, Any p2) { Function.Call(0xCBDE59C48F2B06F5, p0, p1, p2); }
		public static void _0x6A190B94C2541A99(Any p0) { Function.Call(0x6A190B94C2541A99, p0); }
		public static BOOL IS_TARGET_PED_IN_PERCEPTION_AREA(int ped, int targetPed, float p2, float customDistance, float p4, float p5) { return Function.Call<BOOL>(0x06087579E7AA85A9, ped, targetPed, p2, customDistance, p4, p5); }
		public static void SET_POP_CONTROL_SPHERE_THIS_FRAME(Any p0, Any p1, Any p2, Any p3, Any p4) { Function.Call(0xD8C3BE3EE94CAF2D, p0, p1, p2, p3, p4); }
		public static BOOL IS_PED_HOGTIED(int ped) { return Function.Call<BOOL>(0x3AA24CCC0D451379, ped); }
		public static BOOL IS_PED_BEING_HOGTIED(int ped) { return Function.Call<BOOL>(0xD453BB601D4A606E, ped); }
		public static int _0x3D9F958834AB9C30(int ped) { return Function.Call<int>(0x3D9F958834AB9C30, ped); }
		public static BOOL _0x913D04A5176F84C9(int ped) { return Function.Call<BOOL>(0x913D04A5176F84C9, ped); }
		public static BOOL IS_PED_HOGTYING(int ped) { return Function.Call<BOOL>(0x42429C674B61238B, ped); }
		public static BOOL _GET_PED_LASSO_HOGTIE_FLAG(int ped, int flagId) { return Function.Call<BOOL>(0x2C76FA0E01681F8D, ped, flagId); }
		public static void SET_PED_LASSO_HOGTIE_FLAG(int ped, int flagId, BOOL value) { Function.Call(0xAE6004120C18DF97, ped, flagId, value); }
		public static unsafe Any _0x4642182A298187D0(int ped, int p1, Any* p2, int p3, int p4) { return Function.Call<Any>(0x4642182A298187D0, ped, p1, p2, p3, p4); }
		public static unsafe void _0x6B67320E0D57856A(int ped, Any* p1, int p2, BOOL p3) { Function.Call(0x6B67320E0D57856A, ped, p1, p2, p3); }
		public static int _GET_FIRST_ENTITY_PED_IS_CARRYING(int ped) { return Function.Call<int>(0xD806CD2A4F2C2996, ped); }
		public static void _0xAA6C49AE90A32299(int ped, Hash p1) { Function.Call(0xAA6C49AE90A32299, ped, p1); }
		public static int _GET_CARRIER_AS_PED(int entity) { return Function.Call<int>(0x09B83E68DE004CD4, entity); }
		public static int _GET_CARRIER_AS_MOUNT(int entity) { return Function.Call<int>(0xA033D7E4BBF9844D, entity); }
		public static int _GET_CARRIER_AS_HUMAN(int entity) { return Function.Call<int>(0x79443D56C8DF45EE, entity); }
		public static Any GET_CARRIED_ATTACHED_INFO_FOR_SLOT(Any p0, Any p1, Any p2, Any p3) { return Function.Call<Any>(0x608BC6A6AACD5036, p0, p1, p2, p3); }
		public static void DETACH_CARRIABLE_ENTITY(int entity, BOOL p1, BOOL p2) { Function.Call(0xED00D72F81CF7278, entity, p1, p2); }
		public static void FIND_ALL_ATTACHED_CARRIABLE_ENTITIES(int ped, ItemSet itemset) { Function.Call(0xB5ACE8B23A438EC0, ped, itemset); }
		public static BOOL IS_PED_CARRYING_SOMETHING(int ped) { return Function.Call<BOOL>(0xA911EE21EDF69DAF, ped); }
		public static BOOL _0xB65927F861E7AE39(int ped, int p1) { return Function.Call<BOOL>(0xB65927F861E7AE39, ped, p1); }
		public static BOOL _0xA1FBAC56D38563E2(Volume volume) { return Function.Call<BOOL>(0xA1FBAC56D38563E2, volume); }
		public static unsafe Any _0x6F43C351A5D51E2F(int ped, Any* p1) { return Function.Call<Any>(0x6F43C351A5D51E2F, ped, p1); }
		public static BOOL IS_PED_LASSOED(int ped) { return Function.Call<BOOL>(0x9682F850056C9ADE, ped); }
		public static int _GET_LASSOER_OF_PED(int ped) { return Function.Call<int>(0x833F0053340EF413, ped); }
		public static int _GET_LASSO_TARGET(int ped) { return Function.Call<int>(0xB65A4DAB460A19BD, ped); }
		public static int _GET_LASSOED_LASSOER(int ped) { return Function.Call<int>(0x0C31C51168E80365, ped); }
		public static void SET_LOOTING_FLAG(int ped, int lootFlag, BOOL enabled) { Function.Call(0x6569F31A01B4C097, ped, lootFlag, enabled); }
		public static BOOL _GET_LOOTING_FLAG(int ped, int lootFlag) { return Function.Call<BOOL>(0xE4C11F104620DDCE, ped, lootFlag); }
		public static int _0x5463C962BC7777C3(int ped, int p1, Any p2, int p3, int p4) { return Function.Call<int>(0x5463C962BC7777C3, ped, p1, p2, p3, p4); }
		public static int GET_PED_LOOT_STATUS_MP(int ped) { return Function.Call<int>(0xC737697C41628340, ped); }
		public static int _0x4B19F171450E0D4F(int ped) { return Function.Call<int>(0x4B19F171450E0D4F, ped); }
		public static BOOL _0x758F081DB204DDDE(int ped) { return Function.Call<BOOL>(0x758F081DB204DDDE, ped); }
		public static int GET_LOOTING_PICKUP_TARGET_ENTITY(int ped) { return Function.Call<int>(0x14169FA823679E41, ped); }
		public static Any _0x7B5C293238EE4F20(Any p0) { return Function.Call<Any>(0x7B5C293238EE4F20, p0); }
		public static void _0xAE6B68A83ABBE7C0(Any p0) { Function.Call(0xAE6B68A83ABBE7C0, p0); }
		public static BOOL _0xA4B6432E3880F2F9(int ped) { return Function.Call<BOOL>(0xA4B6432E3880F2F9, ped); }
		public static BOOL _ADD_PED_SUBSCRIBE_TO_LEGENDARY_BLIPS(int ped) { return Function.Call<BOOL>(0xE37287EE358939C3, ped); }
		public static BOOL _REMOVE_PED_SUBSCRIBE_TO_LEGENDARY_BLIPS(int ped) { return Function.Call<BOOL>(0x011A42FD923D41CA, ped); }
		public static BOOL IS_PED_INCAPACITATED(int ped) { return Function.Call<BOOL>(0xB655DB7582AEC805, ped); }
		public static void _SET_PED_INCAPACITATION_MODIFIERS(int ped, BOOL canBeIncapacitated, int threshold, int bleedoutTime, int p4) { Function.Call(0x39ED303390DDEAC7, ped, canBeIncapacitated, threshold, bleedoutTime, p4); }
		public static BOOL _GET_PED_CAN_BE_INCAPACITATED_THIS_FRAME(int ped) { return Function.Call<BOOL>(0x7A4E00364B5D727B, ped); }
		public static void SET_PED_CAN_BE_INCAPACITATED(int ped, BOOL toggle) { Function.Call(0x5240864E847C691C, ped, toggle); }
		public static int _GET_PED_INCAPACITATION_HEALTH(int ped) { return Function.Call<int>(0x89BFDF6D53145545, ped); }
		public static void _SET_PED_INCAPACITATION_TOTAL_BLEED_OUT_DURATION(int ped, float duration) { Function.Call(0x2890418B39BC8FFF, ped, duration); }
		public static void _RESET_PED_INCAPACITATION_BLEED_OUT_DURATION(int ped) { Function.Call(0x4B9668DB91DC39B8, ped); }
		public static void _SET_PED_INCAPACITATION_FLAGS(int ped, int flags) { Function.Call(0xD67B6F3BCF81BA47, ped, flags); }
		public static void _0x92A1B55A59720395(Any p0, Any p1) { Function.Call(0x92A1B55A59720395, p0, p1); }
		public static void _INCAPACITATED_REVIVE(int ped, int ped2) { Function.Call(0xF6262491C7704A63, ped, ped2); }
		public static int _GET_INCAPACITATION_TIME_REMAINING(int ped) { return Function.Call<int>(0x88D9D76D78065487, ped); }
		public static void _SET_PED_KNOCKED_BY_ONE_HIT(int ped, float p1) { Function.Call(0x5BCF0B79D4F5DBA3, ped, p1); }
		public static void _0x2E5B5D1F1453E08E(int ped, int p1) { Function.Call(0x2E5B5D1F1453E08E, ped, p1); }
		public static void _0x29924EB8EE9DB926(int ped, float p1) { Function.Call(0x29924EB8EE9DB926, ped, p1); }
		public static void _0xB285AD0EC870B2DF(Any p0, Any p1) { Function.Call(0xB285AD0EC870B2DF, p0, p1); }
		public static Any _0xCB86D3E3E3708901(Any p0, Any p1, Any p2, Any p3, Any p4) { return Function.Call<Any>(0xCB86D3E3E3708901, p0, p1, p2, p3, p4); }
		public static void _0x633F83B301C87994(Any p0, Any p1) { Function.Call(0x633F83B301C87994, p0, p1); }
		public static BOOL _0x5203038FF8BAE577(int ped, int p1, int p2) { return Function.Call<BOOL>(0x5203038FF8BAE577, ped, p1, p2); }
		public static BOOL _0x7F090958AE95B61B(int ped, int p1) { return Function.Call<BOOL>(0x7F090958AE95B61B, ped, p1); }
		public static void _0xC494C76A34266E82(int ped, int p1) { Function.Call(0xC494C76A34266E82, ped, p1); }
		public static BOOL _0xC3995D396F1D97B6(int ped, int p1, int p2) { return Function.Call<BOOL>(0xC3995D396F1D97B6, ped, p1, p2); }
		public static void _0x15F4732C357B1D6D(Any p0, Any p1, Any p2) { Function.Call(0x15F4732C357B1D6D, p0, p1, p2); }
		public static BOOL _0x947E43F544B6AB34(int ped, int player, int flag, int ms) { return Function.Call<BOOL>(0x947E43F544B6AB34, ped, player, flag, ms); }
		public static Any _0x32417CB860A3BDC4(Any p0, Any p1) { return Function.Call<Any>(0x32417CB860A3BDC4, p0, p1); }
		public static void _0xE737D5F14304A2EC(int ped, int player, int p2) { Function.Call(0xE737D5F14304A2EC, ped, player, p2); }
		public static void _0xEBD49472BCCF7642(Any p0, Any p1) { Function.Call(0xEBD49472BCCF7642, p0, p1); }
		public static void _0x19173C3F15367B54(Any p0, Any p1, Any p2) { Function.Call(0x19173C3F15367B54, p0, p1, p2); }
		public static void _0x5708EDD71B50C008(Any p0, Any p1, Any p2) { Function.Call(0x5708EDD71B50C008, p0, p1, p2); }
		public static void _0xB9BDFAE609DFB7C5(Any p0, Any p1, Any p2) { Function.Call(0xB9BDFAE609DFB7C5, p0, p1, p2); }
		public static Any _0xF7327ACC7A89AEF1(Any p0, Any p1, Any p2) { return Function.Call<Any>(0xF7327ACC7A89AEF1, p0, p1, p2); }
		public static int _GET_PED_ATTITUDE(int ped, int player) { return Function.Call<int>(0x7CC2186C32D3540A, ped, player); }
		public static BOOL _0x1E017404784AA6A3(int ped, Hash p1) { return Function.Call<BOOL>(0x1E017404784AA6A3, ped, p1); }
		public static void _0x2B4CE170DE09F346(Any p0, Any p1) { Function.Call(0x2B4CE170DE09F346, p0, p1); }
		public static Any _0x7C8AA850617651D9(Any p0, Any p1) { return Function.Call<Any>(0x7C8AA850617651D9, p0, p1); }
		public static float _GET_PED_MOTIVATION(int ped, int motivationState, int targetPed) { return Function.Call<float>(0x42688E94E96FD9B4, ped, motivationState, targetPed); }
		public static void _SET_PED_MOTIVATION(int ped, int motivationState, float threshold, int targetPed) { Function.Call(0x06D26A96CA1BCA75, ped, motivationState, threshold, targetPed); }
		public static void _0x23BDE06596A22CEC(int ped, int p1, float p2, Any p3) { Function.Call(0x23BDE06596A22CEC, ped, p1, p2, p3); }
		public static void _0xCDFB8C04D4C95D9B(Any p0, Any p1, Any p2, Any p3) { Function.Call(0xCDFB8C04D4C95D9B, p0, p1, p2, p3); }
		public static BOOL _GET_IS_PED_MOTIVATION_STATE_ENABLED(int ped, int motivationState) { return Function.Call<BOOL>(0x33FA048675821DA7, ped, motivationState); }
		public static void _SET_PED_MOTIVATION_STATE_OVERRIDE(int ped, int motivationState, BOOL enabled) { Function.Call(0x2EB75FB86C41F026, ped, motivationState, enabled); }
		public static void _SET_PED_MOTIVATION_MODIFIER(int ped, int motivationState, float modifier) { Function.Call(0xA1EB5D029E0191D3, ped, motivationState, modifier); }
		public static void _0xFD8E853F0BC2E942(Any p0, Any p1) { Function.Call(0xFD8E853F0BC2E942, p0, p1); }
		public static void _SET_PED_SCENT(int ped, float scent) { Function.Call(0x01B21B81865E2A1F, ped, scent); }
		public static void _SET_PED_LADDER_MOVEMENT_SPEED_MODIFIER(int ped, float p1) { Function.Call(0x05CE6AF4DF071D23, ped, p1); }
		public static void _RESET_PED_LADDER_MOVEMENT_SPEED_MODIFIER(int ped) { Function.Call(0x801917E7D7BCE418, ped); }
		public static void _0xC6C4E15CF7D52FEA(Any p0, Any p1) { Function.Call(0xC6C4E15CF7D52FEA, p0, p1); }
		public static void _SET_PED_VOICE_VOLUME(int ped, float volume) { Function.Call(0xD05AD61F242C626B, ped, volume); }
		public static void _0x0F967019CC853BCC(Any p0, Any p1) { Function.Call(0x0F967019CC853BCC, p0, p1); }
		public static BOOL _IS_PED_DRAGGING(int ped) { return Function.Call<BOOL>(0x226CF9B159E38F42, ped); }
		public static BOOL IS_PED_BEING_DRAGGED(int ped) { return Function.Call<BOOL>(0xEF3A8772F085B4AA, ped); }
		public static void _0x070A3841406C43D5(Any p0, Any p1) { Function.Call(0x070A3841406C43D5, p0, p1); }
		public static BOOL _ADD_PED_STAY_OUT_VOLUME(int ped, Volume volume) { return Function.Call<BOOL>(0xE9B168527B337BF0, ped, volume); }
		public static BOOL _REMOVE_PED_STAY_OUT_VOLUME(int ped, Volume volume) { return Function.Call<BOOL>(0x0CAB404CD2DB41F5, ped, volume); }
		public static void _0x9E66708B2B41F14A(Any p0, Any p1) { Function.Call(0x9E66708B2B41F14A, p0, p1); }
		public static void _0xF634E2892220EF34(int ped, Any p1) { Function.Call(0xF634E2892220EF34, ped, p1); }
		public static void _0xAAC0EE3B4999ABB5(int ped, int targetPed) { Function.Call(0xAAC0EE3B4999ABB5, ped, targetPed); }
		public static int GET_PED_MOTION_FOCUS_ENTITY(int ped) { return Function.Call<int>(0x243E1B4607040057, ped); }
		public static void _SET_PED_FACE_FEATURE(int ped, int index, float value) { Function.Call(0x5653AB26C82938CF, ped, index, value); }
		public static float _GET_PED_FACE_FEATURE(int ped, int index) { return Function.Call<float>(0xFD1BA1EEF7985BB8, ped, index); }
		public static void _0x5BB04BC74A474B47(Any p0, Any p1) { Function.Call(0x5BB04BC74A474B47, p0, p1); }
		public static void _0x9078FB0557364099(Any p0) { Function.Call(0x9078FB0557364099, p0); }
		public static BOOL IS_PED_FALLING_OVER(int ped) { return Function.Call<BOOL>(0x3E592D0486DEC0F6, ped); }
		public static BOOL _HAS_PED_BEEN_SHOVED_RECENTLY(int ped, int ms) { return Function.Call<BOOL>(0x29FCE825613FEFCA, ped, ms); }
		public static int _GET_PED_TRANQUILIZER(int ped) { return Function.Call<int>(0x65C75FDCCAC86464, ped); }
		public static void _0x0D497AA69059FE40(Any p0, Any p1) { Function.Call(0x0D497AA69059FE40, p0, p1); }
		public static void _0xD7D2F45C56A4F4DF(Any p0, Any p1, Any p2) { Function.Call(0xD7D2F45C56A4F4DF, p0, p1, p2); }
		public static void _SET_PED_CULL_RANGE(int ped, float p1, float p2) { Function.Call(0x8AC1D721B2097B6E, ped, p1, p2); }
		public static void _0x1D23D3F70606D788(Any p0, Any p1) { Function.Call(0x1D23D3F70606D788, p0, p1); }
		public static int _GET_META_PED_TYPE(int ped) { return Function.Call<int>(0xEC9A1261BF0CE510, ped); }
		public static BOOL _IS_METAPED_USING_COMPONENT(int ped, Hash component) { return Function.Call<BOOL>(0xFB4891BD7578CDC1, ped, component); }
		public static BOOL _0xBD0E4F52F6D95242(int ped) { return Function.Call<BOOL>(0xBD0E4F52F6D95242, ped); }
		public static BOOL _IS_PED_CHILD(int ped) { return Function.Call<BOOL>(0x137772000DAF42C5, ped); }
		public static void _0xFFA1594703ED27CA(int ped, int p1) { Function.Call(0xFFA1594703ED27CA, ped, p1); }
		public static void _SET_META_PED_TAG(int ped, Hash drawable, Hash albedo, Hash normal, Hash material, Hash palette, int tint0, int tint1, int tint2) { Function.Call(0xBC6DF00D7A4A6819, ped, drawable, albedo, normal, material, palette, tint0, tint1, tint2); }
		public static void REMOVE_TAG_FROM_META_PED(int ped, Hash component, int p2) { Function.Call(0xD710A5007C2AC539, ped, component, p2); }
		public static void _0xA2B8E47442C76CEC(Any p0, Any p1) { Function.Call(0xA2B8E47442C76CEC, p0, p1); }
		public static int _GET_NUM_COMPONENT_CATEGORIES_IN_PED(int ped) { return Function.Call<int>(0xA622E66EEE92A08D, ped); }
		public static Hash _GET_PED_COMPONENT_CATEGORY_BY_INDEX(int ped, int index) { return Function.Call<Hash>(0xCCB97B51893C662F, ped, index); }
		public static int _GET_NUM_COMPONENTS_IN_PED(int ped) { return Function.Call<int>(0x90403E8107B60E81, ped); }
		public static Any _0x9B90842304C938A7(Any p0, Any p1, Any p2) { return Function.Call<Any>(0x9B90842304C938A7, p0, p1, p2); }
		public static void _UPDATE_PED_VARIATION(int ped, BOOL p1, BOOL p2, BOOL p3, BOOL p4, BOOL p5) { Function.Call(0xCC8CA3E88256E58F, ped, p1, p2, p3, p4, p5); }
		public static void _0xCB1A3864C524F784(Any p0, Any p1) { Function.Call(0xCB1A3864C524F784, p0, p1); }
		public static void _0xFA0D206B489A6846(Any p0, Any p1, Any p2, Any p3, Any p4) { Function.Call(0xFA0D206B489A6846, p0, p1, p2, p3, p4); }
		public static Any _0xA4AC05B1A364EBC5(Any p0, Any p1, Any p2) { return Function.Call<Any>(0xA4AC05B1A364EBC5, p0, p1, p2); }
		public static void _0x1298B3D8E4C2409F(Any p0) { Function.Call(0x1298B3D8E4C2409F, p0); }
		public static Any _0xA274F51EF7E34B95(Any p0, Any p1) { return Function.Call<Any>(0xA274F51EF7E34B95, p0, p1); }
		public static Any _0xC2EF407645BEECDC(Any p0) { return Function.Call<Any>(0xC2EF407645BEECDC, p0); }
		public static void _EQUIP_META_PED_OUTFIT(int ped, Hash hash) { Function.Call(0x1902C4CFCC5BE57C, ped, hash); }
		public static void _0xFA742B82D093D848(Any p0, Any p1, Any p2) { Function.Call(0xFA742B82D093D848, p0, p1, p2); }
		public static Hash _GET_PED_META_OUTFIT_HASH(int ped) { return Function.Call<Hash>(0x30569F348D126A5A, ped); }
		public static void _0xA2F8B3B5FEDFC100(Any p0, Any p1) { Function.Call(0xA2F8B3B5FEDFC100, p0, p1); }
		public static void _EQUIP_META_PED_SUBOUTFIT(int ped, Hash suboutfit, int p2) { Function.Call(0x66FF395445A88A6E, ped, suboutfit, p2); }
		public static BOOL _DOES_METAPED_OUTFIT_EXIST_FOR_PED_MODEL(Hash _outfit, Hash model) { return Function.Call<BOOL>(0xC0E880B7A441164D, _outfit, model); }
		public static BOOL _DOES_METAPED_SUBOUTFIT_EXIST_FOR_PED_MODEL(Hash _outfit, Hash suboutfit, Hash model) { return Function.Call<BOOL>(0x4FF3C2B4E6A196C1, _outfit, suboutfit, model); }
		public static Any _0x62FDF4E678E40CC6(int entity, Any p1) { return Function.Call<Any>(0x62FDF4E678E40CC6, entity, p1); }
		public static void _RESET_PED_COMPONENTS(int ped) { Function.Call(0x0BFA1BD465CDFEFD, ped); }
		public static void _0x370A973252741AC4(int ped, BOOL p1) { Function.Call(0x370A973252741AC4, ped, p1); }
		public static void _SET_RANDOM_OUTFIT_VARIATION(int ped, BOOL p1) { Function.Call(0x283978A15512B2FE, ped, p1); }
		public static int GET_NUM_META_PED_OUTFITS(int ped) { return Function.Call<int>(0x10C70A515BC03707, ped); }
		public static void _EQUIP_META_PED_OUTFIT_PRESET(int ped, int presetId, BOOL p2) { Function.Call(0x77FF8D35EEC6BBC4, ped, presetId, p2); }
		public static void _EQUIP_META_PED_OUTFIT_EXTRA(int ped, int component, Any p2, Any p3) { Function.Call(0xA5BAE410B03E7371, ped, component, p2, p3); }
		public static BOOL _IS_META_PED_OUTFIT_EQUIPPED(int ped, Hash _outfit) { return Function.Call<BOOL>(0x98082246107A6ACF, ped, _outfit); }
		public static void _0x851966E1E35AF491(Any p0, Any p1) { Function.Call(0x851966E1E35AF491, p0, p1); }
		public static void _0x4EFC1F8FF1AD94DE(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5) { Function.Call(0x4EFC1F8FF1AD94DE, p0, p1, p2, p3, p4, p5); }
		public static int _REQUEST_METAPED_PED(Hash model, int p1) { return Function.Call<int>(0xF97C34C33487D569, model, p1); }
		public static BOOL _HAS_METAPED_PED_REQUEST_LOADED(int requestId) { return Function.Call<BOOL>(0xC0940AC858C1E126, requestId); }
		public static BOOL _IS_METAPED_PED_REQUEST_VALID(int requestId) { return Function.Call<BOOL>(0x43E4DA469541A9C9, requestId); }
		public static int _CREATE_METAPED_PED(int requestId, float x, float y, float z, float heading, BOOL p5, BOOL p6, BOOL p7, BOOL p8, BOOL p9) { return Function.Call<int>(0x0BCD4091C8EABA42, requestId, x, y, z, heading, p5, p6, p7, p8, p9); }
		public static void _RELEASE_METAPED_PED_REQUEST(int requestId) { Function.Call(0x3972F78A78B5D9DF, requestId); }
		public static int _REQUEST_METAPED_OUTFIT(Hash model, Hash _outfit) { return Function.Call<int>(0x13154A76CE0CF9AB, model, _outfit); }
		public static Any _0x27E8A84C12B0B7D1(Any p0, Any p1, Any p2) { return Function.Call<Any>(0x27E8A84C12B0B7D1, p0, p1, p2); }
		public static Any _0x273915CE30780986(Any p0, Any p1) { return Function.Call<Any>(0x273915CE30780986, p0, p1); }
		public static void _RELEASE_METAPED_OUTFIT_REQUEST(int requestId) { Function.Call(0x4592B8B9B0EF5F48, requestId); }
		public static int _0x3FCBB5FCFD968698(Hash drawable, Hash albedo, Hash normal, Hash material, Any p4) { return Function.Call<int>(0x3FCBB5FCFD968698, drawable, albedo, normal, material, p4); }
		public static int _REQUEST_METAPED_ASSET_BUNDLE(Hash asset, int p1) { return Function.Call<int>(0x91FE941F9FCFB702, asset, p1); }
		public static Any _REQUEST_METAPED_COMPONENT(int metaPedType, Any p1, int p2, int p3, int p4) { return Function.Call<Any>(0xF6D9E1F3560CBF8E, metaPedType, p1, p2, p3, p4); }
		public static void _RELEASE_METAPED_ASSET_REQUEST(int requestId) { Function.Call(0x13E7320C762F0477, requestId); }
		public static BOOL _HAS_METAPED_ASSET_LOADED(int requestId) { return Function.Call<BOOL>(0xB0B2C6D170B0E8E5, requestId); }
		public static BOOL _IS_METAPED_ASSET_VALID(int requestId) { return Function.Call<BOOL>(0x93FFD92F05EC32FD, requestId); }
		public static int _CREATE_METAPED_ASSET(Hash asset, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, BOOL p7, BOOL p8, BOOL p9) { return Function.Call<int>(0x9641A9A20310F6B8, asset, posX, posY, posZ, rotX, rotY, rotZ, p7, p8, p9); }
		public static BOOL _HAS_METAPED_OUTFIT_LOADED(int requestId) { return Function.Call<BOOL>(0x610438375E5D1801, requestId); }
		public static BOOL _IS_METAPED_OUTFIT_REQUEST_VALID(int requestId) { return Function.Call<BOOL>(0xB25E57FC8E37114D, requestId); }
		public static int _CREATE_METAPED_OUTFIT_PED(int requestId, float x, float y, float z, float heading, BOOL p5, BOOL p6, BOOL p7, BOOL p8) { return Function.Call<int>(0xEAF682A14F8E5F53, requestId, x, y, z, heading, p5, p6, p7, p8); }
		public static BOOL _APPLY_PED_METAPED_OUTFIT(int requestId, int ped, BOOL p2, BOOL p3) { return Function.Call<BOOL>(0x74F512E29CB717E2, requestId, ped, p2, p3); }
		public static void _SET_METAPED_WEARINESS(int ped, float weariness) { Function.Call(0x314C5465195F3B30, ped, weariness); }
		public static void _0xF47D54B986F0A346(int ped, int danceIntensity) { Function.Call(0xF47D54B986F0A346, ped, danceIntensity); }
		public static void _0x3EFED081B4834BA1(Any p0) { Function.Call(0x3EFED081B4834BA1, p0); }
		public static void _0x0FB1BA7FF73B41E1(Any p0, Any p1, Any p2) { Function.Call(0x0FB1BA7FF73B41E1, p0, p1, p2); }
		public static Any _0xB292203008EBBAAC(Any p0) { return Function.Call<Any>(0xB292203008EBBAAC, p0); }
		public static Any _0xD4D403EA031F351C(Any p0) { return Function.Call<Any>(0xD4D403EA031F351C, p0); }
		public static int _GET_PELT_FROM_HORSE(int horse, int index) { return Function.Call<int>(0x0CEEB6F4780B1F2F, horse, index); }
		public static void _SET_PELT_FOR_HORSE(int horse, int peltId) { Function.Call(0xA73F50E8796150D5, horse, peltId); }
		public static void _0xC412AA1C73111FE0(Any p0, Any p1, Any p2, Any p3, Any p4) { Function.Call(0xC412AA1C73111FE0, p0, p1, p2, p3, p4); }
		public static void _CLEAR_PELT_FROM_HORSE(int horse, int peltId) { Function.Call(0x627F7F3A0C4C51FF, horse, peltId); }
		public static void _SET_PED_LIGHTS(int ped, BOOL toggle) { Function.Call(0x13A210949FCBD92B, ped, toggle); }
		public static void _0xD049FDAF089FDDB0(Any p0, Any p1, Any p2) { Function.Call(0xD049FDAF089FDDB0, p0, p1, p2); }
		public static void _0xDD9540E7B1C9714F(Any p0, Any p1, Any p2, Any p3, Any p4) { Function.Call(0xDD9540E7B1C9714F, p0, p1, p2, p3, p4); }
		public static void _0x55546004A244302A(Any p0, Any p1) { Function.Call(0x55546004A244302A, p0, p1); }
		public static void _SET_HEALTH_RECHARGE_MULTIPLIER(int ped, int multiplier) { Function.Call(0xDE1B1907A83A1550, ped, multiplier); }
		public static float _GET_HEALTH_RECHARGE_MULTIPLIER(int ped) { return Function.Call<float>(0x95B8E397B8F4360F, ped); }
		public static void _SET_STAMINA_DEPLETION_MULTIPLIER(int ped, int multiplier) { Function.Call(0xEF5A3D2285D8924B, ped, multiplier); }
		public static float _GET_STAMINA_DEPLETION_MULTIPLIER(int ped) { return Function.Call<float>(0x825F6DD559A0895B, ped); }
		public static void _SET_STAMINA_RECHARGE_MULTIPLIER(int ped, int multiplier) { Function.Call(0x345C9F993A8AB4A4, ped, multiplier); }
		public static float _GET_STAMINA_RECHARGE_MULTIPLIER(int ped) { return Function.Call<float>(0xE7687EB2F634ABF0, ped); }
		public static BOOL _CHANGE_PED_STAMINA(int ped, float amount) { return Function.Call<BOOL>(0xC3D4B754C0E86B9E, ped, amount); }
		public static float _GET_PED_STAMINA(int ped) { return Function.Call<float>(0x775A1CA7893AA8B5, ped); }
		public static float _GET_PED_STAMINA_NORMALIZED(int ped) { return Function.Call<float>(0x22F2A386D43048A9, ped); }
		public static float _GET_PED_MAX_STAMINA(int ped) { return Function.Call<float>(0xCB42AFE2B613EE55, ped); }
		public static void _0x36513AFFC703C60D(Any p0) { Function.Call(0x36513AFFC703C60D, p0); }
		public static void _RESTORE_PED_STAMINA(int ped, float stamina) { Function.Call(0x675680D089BFA21F, ped, stamina); }
		public static Any _0xFC3B580C4380B5B7(Any p0) { return Function.Call<Any>(0xFC3B580C4380B5B7, p0); }
		public static void _0xEA8763E505AFD49A(Any p0, Any p1, Any p2) { Function.Call(0xEA8763E505AFD49A, p0, p1, p2); }
		public static void _0xE4EF4382E22C780C(Any p0) { Function.Call(0xE4EF4382E22C780C, p0); }
		public static void _0xD61FCF9FCFD515B7(Any p0, Any p1, Any p2) { Function.Call(0xD61FCF9FCFD515B7, p0, p1, p2); }
		public static void _0x8D9DB115FBA8E23D(Any p0) { Function.Call(0x8D9DB115FBA8E23D, p0); }
		public static Any _GET_NUM_RESERVED_HEALTH(int ped) { return Function.Call<Any>(0x16F2C8C084AB2092, ped); }
		public static Any _0xD97BC27AC039F681(Any p0, Any p1, Any p2, Any p3) { return Function.Call<Any>(0xD97BC27AC039F681, p0, p1, p2, p3); }
		public static Any _0xF6A8C4B4A11AE89C(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5) { return Function.Call<Any>(0xF6A8C4B4A11AE89C, p0, p1, p2, p3, p4, p5); }
		public static void _0xE4C95E0AE31C6512(int ped, Any p1) { Function.Call(0xE4C95E0AE31C6512, ped, p1); }
		public static Object _GET_PED_LAST_DROPPED_HAT(int ped) { return Function.Call<Object>(0x1F714E7A9DADFC42, ped); }
		public static void _0x5D4CD22A8C82A81A(int ped, BOOL p1) { Function.Call(0x5D4CD22A8C82A81A, ped, p1); }
		public static void _0xBF567DF2BEF211A6(Any p0, Any p1) { Function.Call(0xBF567DF2BEF211A6, p0, p1); }
		public static int _CREATE_GRAVITY_WELL(float xPos, float yPos, float zPos, float heading, float radius, float p5, float p6, float p7, BOOL stopAtDestination) { return Function.Call<int>(0x4F5EBE70081E5A20, xPos, yPos, zPos, heading, radius, p5, p6, p7, stopAtDestination); }
		public static void _REMOVE_GRAVITY_WELL(int handle) { Function.Call(0x87247BC60B60BED8, handle); }
		public static BOOL _IS_PED_INTIMIDATED(int ped) { return Function.Call<BOOL>(0x57779B55B83E2BEA, ped); }
		public static BOOL _0x7EE3A8660F38797E(int ped) { return Function.Call<BOOL>(0x7EE3A8660F38797E, ped); }
		public static Any _0xA180FBD502A03125(Any p0, Any p1, Any p2) { return Function.Call<Any>(0xA180FBD502A03125, p0, p1, p2); }
		public static int _REQUEST_TEXTURE(Hash albedoHash, Hash normalHash, Hash materialHash) { return Function.Call<int>(0xC5E7204F322E49EB, albedoHash, normalHash, materialHash); }
		public static void _APPLY_TEXTURE_ON_PED(int ped, Hash componentHash, int textureId) { Function.Call(0x0B46E25761519058, ped, componentHash, textureId); }
		public static void _RELEASE_TEXTURE(int textureId) { Function.Call(0x6BEFAA907B076859, textureId); }
		public static void _UPDATE_PED_TEXTURE(int textureId) { Function.Call(0x92DAABA2C1C10B0E, textureId); }
		public static void _RESET_PED_TEXTURE(int textureId) { Function.Call(0x8472A1789478F82F, textureId); }
		public static BOOL _IS_TEXTURE_VALID(int textureId) { return Function.Call<BOOL>(0x31DC8D3F216D8509, textureId); }
		public static int _ADD_TEXTURE_LAYER(int textureId, Hash albedoHash, Hash normalHash, Hash materialHash, int blendType, float texAlpha, int sheetGridIndex) { return Function.Call<int>(0x86BB5FF45F193A02, textureId, albedoHash, normalHash, materialHash, blendType, texAlpha, sheetGridIndex); }
		public static void _REMOVE_PED_OVERLAY(int textureId, int overlayId) { Function.Call(0x96C349DE04C49011, textureId, overlayId); }
		public static void _SET_TEXTURE_LAYER_SHEET_GRID_INDEX(int textureId, int layerId, int sheetGridIndex) { Function.Call(0x3329AAE2882FC8E4, textureId, layerId, sheetGridIndex); }
		public static void _SET_TEXTURE_LAYER_ALPHA(int textureId, int layerId, float texAlpha) { Function.Call(0x6C76BC24F8BB709A, textureId, layerId, texAlpha); }
		public static void _SET_TEXTURE_LAYER_ROUGHNESS(int textureId, int layerId, float texRough) { Function.Call(0x057C4F092E2298BE, textureId, layerId, texRough); }
		public static void _SET_TEXTURE_LAYER_PALLETE(int textureId, int layerId, Hash paletteHash) { Function.Call(0x1ED8588524AC9BE1, textureId, layerId, paletteHash); }
		public static void _SET_TEXTURE_LAYER_TINT(int textureId, int layerId, int tint0, int tint1, int tint2) { Function.Call(0x2DF59FFE6FFD6044, textureId, layerId, tint0, tint1, tint2); }
		public static void _SET_TEXTURE_LAYER_MOD(int textureId, int layerId, Hash modTextureHash, float modAlpha, int modChannel) { Function.Call(0xF2EA041F1146D75B, textureId, layerId, modTextureHash, modAlpha, modChannel); }
		public static void _SET_TEXTURE_LAYER_TEXTURE_MAP(int textureId, int layerId, Hash albedoHash, Hash normalHash, Hash materialHash) { Function.Call(0x253A63B5BADBC398, textureId, layerId, albedoHash, normalHash, materialHash); }
		public static void _CLEAR_PED_TEXTURE(int textureId) { Function.Call(0xB63B9178D0F58D82, textureId); }
		public static void _0xC991EF46FE323867(int ped, Any p1) { Function.Call(0xC991EF46FE323867, ped, p1); }
		public static void _0x1F8215D0E446F593(Any p0, Any p1, Any p2) { Function.Call(0x1F8215D0E446F593, p0, p1, p2); }
		public static BOOL IS_LOCATION_SPAWN_SAFE(int ped, float p1) { return Function.Call<BOOL>(0xFB1E7998B8595825, ped, p1); }
		public static void _0x53BA7D96B9A421D9(Any p0, Any p1) { Function.Call(0x53BA7D96B9A421D9, p0, p1); }
		public static void _0x96C7B659854DE629(Any p0, Any p1) { Function.Call(0x96C7B659854DE629, p0, p1); }
		public static void SET_HORSE_AVOIDANCE_LEVEL(int horse, int avoidanceLevel) { Function.Call(0xDDCF6FEA5D7ACC17, horse, avoidanceLevel); }
		public static void RESET_HORSE_AVOIDANCE_LEVEL_TO_DEFAULT(int horse) { Function.Call(0x2A5AFD2B8381A6E1, horse); }
		public static Any _SET_PED_USE_HORSE_MAP_COLLISION(int ped, BOOL toggle) { return Function.Call<Any>(0xEB72453B6F5B45B0, ped, toggle); }
		public static void _0x5B73975B4F12F7F3(Any p0, Any p1, Any p2, Any p3, Any p4) { Function.Call(0x5B73975B4F12F7F3, p0, p1, p2, p3, p4); }
		public static unsafe BOOL GET_META_PED_ASSET_GUIDS(int ped, int index, Hash* drawable, Hash* albedo, Hash* normal, Hash* material) { return Function.Call<BOOL>(0xA9C28516A6DC9D56, ped, index, drawable, albedo, normal, material); }
		public static unsafe BOOL GET_META_PED_ASSET_TINT(int ped, int index, Hash* pallete, int* tint0, int* tint1, int* tint2) { return Function.Call<BOOL>(0xE7998FEC53A33BBE, ped, index, pallete, tint0, tint1, tint2); }
		public static void _SET_PED_BLACKBOARD_INT(int ped, string variableName, int value, int removeTimer) { Function.Call(0x5F53010C4C3F6BAF, ped, variableName, value, removeTimer); }
		public static void _SET_PED_BLACKBOARD_BOOL(int ped, string variableName, BOOL value, int removeTimer) { Function.Call(0xCB9401F918CB0F75, ped, variableName, value, removeTimer); }
		public static void _SET_PED_BLACKBOARD_FLOAT(int ped, string variableName, float value, int removeTimer) { Function.Call(0x437C08DB4FEBE2BD, ped, variableName, value, removeTimer); }
		public static void _SET_PED_BLACKBOARD_HASH(int ped, string variableName, string value, int removeTimer) { Function.Call(0xA762C9D6CF165E0D, ped, variableName, value, removeTimer); }
		public static void _REMOVE_PED_BLACKBOARD_INT(int ped, string variableName) { Function.Call(0x81B75428A7813E67, ped, variableName); }
		public static void _REMOVE_PED_BLACKBOARD_BOOL(int ped, string variableName) { Function.Call(0xA6F67BEC53379A32, ped, variableName); }
		public static void _REMOVE_PED_BLACKBOARD_FLOAT(int ped, string variableName) { Function.Call(0x411189E51B8020BA, ped, variableName); }
		public static void _REMOVE_PED_BLACKBOARD_HASH(int ped, string variableName) { Function.Call(0x0E17378642156790, ped, variableName); }
		public static BOOL _GET_PED_BLACKBOARD_BOOL(int ped, string variableName) { return Function.Call<BOOL>(0x498F2E77982D6945, ped, variableName); }
		public static float _GET_PED_BLACKBOARD_FLOAT(int ped, string variableName) { return Function.Call<float>(0x56E58D4D118FB45E, ped, variableName); }
		public static Hash _GET_PED_BLACKBOARD_HASH(int ped, string variableName) { return Function.Call<Hash>(0xBF5E791BBBF90A3C, ped, variableName); }
		public static int GET_PED_BLACKBOARD_SCRIPT_INT(int ped, string variableName) { return Function.Call<int>(0xB71B91B398F8F067, ped, variableName); }
		public static BOOL GET_PED_BLACKBOARD_SCRIPT_BOOL(int ped, string variableName) { return Function.Call<BOOL>(0x4912DFE492DB98CD, ped, variableName); }
		public static float GET_PED_BLACKBOARD_SCRIPT_FLOAT(int ped, string variableName) { return Function.Call<float>(0xA29FD00D45311EB7, ped, variableName); }
		public static void _SET_TANK_ATTRIBUTE_SIZE(int ped, int attributeIndex, float size) { Function.Call(0x7FF72DE061DF55E2, ped, attributeIndex, size); }
		public static Any _0xA31D350D66FA1855(Any p0) { return Function.Call<Any>(0xA31D350D66FA1855, p0); }
		public static BOOL _IS_USING_SLIPSTREAM(int ped) { return Function.Call<BOOL>(0xAF61B3CD8C3B82C3, ped); }
		public static void _0xEEDC9B29314B2733(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8, Any p9) { Function.Call(0xEEDC9B29314B2733, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9); }
		public static void _0x5C90E20C25E6D83C(Any p0) { Function.Call(0x5C90E20C25E6D83C, p0); }
		public static void _0x10F96086123B939F(int legendaryPed, int preyPed, float p2) { Function.Call(0x10F96086123B939F, legendaryPed, preyPed, p2); }
		public static void _0x3FDBB99EFD8CE4AF(Any p0, Any p1, Any p2) { Function.Call(0x3FDBB99EFD8CE4AF, p0, p1, p2); }
		public static void _0x7E8F9949B7AABBF0(Any p0, Any p1, Any p2) { Function.Call(0x7E8F9949B7AABBF0, p0, p1, p2); }
		public static Any _0x5DA36CCCB63C0895(Any p0, Any p1, Any p2) { return Function.Call<Any>(0x5DA36CCCB63C0895, p0, p1, p2); }
		public static void _0x56076667E7C2DCD6(Any p0, Any p1) { Function.Call(0x56076667E7C2DCD6, p0, p1); }
		public static void _APPLY_SHOP_ITEM_TO_PED(int ped, Hash componentHash, BOOL immediately, BOOL isMp, BOOL p4) { Function.Call(0xD3A7B003ED343FD9, ped, componentHash, immediately, isMp, p4); }
		public static void _REMOVE_SHOP_ITEM_FROM_PED(int ped, Hash componentHash, int p2, BOOL p3) { Function.Call(0x0D7FFA1B2F69ED82, ped, componentHash, p2, p3); }
		public static void REMOVE_SHOP_ITEM_FROM_PED_BY_CATEGORY(int ped, Hash componentCategory, int p2, BOOL p3) { Function.Call(0xDF631E4BCE1B1FC4, ped, componentCategory, p2, p3); }
		public static void _UPDATE_SHOP_ITEM_WEARABLE_STATE(int ped, Hash componentHash, Hash wearableState, int p3, BOOL p4, int p5) { Function.Call(0x66B957AAC2EAAEAB, ped, componentHash, wearableState, p3, p4, p5); }
		public static unsafe Hash _GET_SHOP_PED_COMPONENT_AT_INDEX(int ped, int index, BOOL p2, Any* argStruct, Any* argStruct2) { return Function.Call<Hash>(0x77BA37622E22023B, ped, index, p2, argStruct, argStruct2); }
		public static Any _0xFFCC2DB2D9953401(Any p0, Any p1, Any p2) { return Function.Call<Any>(0xFFCC2DB2D9953401, p0, p1, p2); }
		public static Any _0x6243635AF2F1B826(Any p0, Any p1, Any p2, Any p3) { return Function.Call<Any>(0x6243635AF2F1B826, p0, p1, p2, p3); }
		public static Hash _GET_SHOP_PED_COMPONENT_CATEGORY(Hash componentHash, int metapedType, BOOL isMP) { return Function.Call<Hash>(0x5FF9A878C3D115B8, componentHash, metapedType, isMP); }
		public static Any _0x31B2E7F2E3C58B89(Any p0, Any p1, Any p2, Any p3) { return Function.Call<Any>(0x31B2E7F2E3C58B89, p0, p1, p2, p3); }
		public static unsafe BOOL _GET_SHOP_PED_BASE_LAYERS(Hash shopItem, Any p1, int ped, int metapedType, BOOL p4, Hash* drawable, Hash* albedo, Hash* normal, Hash* material, Hash* p9, Hash* p10, Hash* p11, Hash* p12) { return Function.Call<BOOL>(0x63342C50EC115CE8, shopItem, p1, ped, metapedType, p4, drawable, albedo, normal, material, p9, p10, p11, p12); }
		public static Any _0xAAB86462966168CE(int ped, BOOL isMP) { return Function.Call<Any>(0xAAB86462966168CE, ped, isMP); }
		public static Any _GET_SHOP_PED_HAT_COMPONENT(int ped, int metapedType, BOOL p2) { return Function.Call<Any>(0x7E02E4218D916B94, ped, metapedType, p2); }
		public static void _REFRESH_META_PED_SHOP_ITEMS(int ped, int p1) { Function.Call(0x59BD177A1A48600A, ped, p1); }
		public static void _0xD103F6DBB5442BE8(Any p0, Any p1) { Function.Call(0xD103F6DBB5442BE8, p0, p1); }
		public static void _SET_PED_PROMPT_NAME_FROM_GXT_ENTRY(int ped, Hash gxtEntryHash) { Function.Call(0xFCA8FB9E15FA80D3, ped, gxtEntryHash); }
		public static void _SET_PED_PROMPT_NAME(int ped, string name) { Function.Call(0x4A48B6E03BABB4AC, ped, name); }
		public static void _0xC2745D9261664901(Any p0, Any p1) { Function.Call(0xC2745D9261664901, p0, p1); }
		public static void _0x19B14E04B009E28B(Any p0, Any p1) { Function.Call(0x19B14E04B009E28B, p0, p1); }
		public static void _0xF917F92BF22ECBAB(Any p0) { Function.Call(0xF917F92BF22ECBAB, p0); }
		public static void _0x49DADFC4CD808B0A(Any p0, Any p1, Any p2) { Function.Call(0x49DADFC4CD808B0A, p0, p1, p2); }
		public static BOOL _HAS_PED_TAKEN_GORE_DAMAGE(int ped, int limb) { return Function.Call<BOOL>(0xBA208A8D6399A3AC, ped, limb); }
		public static void _0x704C908E9C405136(int ped) { Function.Call(0x704C908E9C405136, ped); }
		public static void _0x7406C71F4AC2FFCC(Any p0) { Function.Call(0x7406C71F4AC2FFCC, p0); }
		public static void _0x28508173C6A7CC18(Any p0) { Function.Call(0x28508173C6A7CC18, p0); }
		public static Any _0x52250B92EA70BE3D(Any p0) { return Function.Call<Any>(0x52250B92EA70BE3D, p0); }
		public static void _SET_PED_QUALITY(int ped, int quality) { Function.Call(0xCE6B874286D640BB, ped, quality); }
		public static int _GET_PED_QUALITY(int ped) { return Function.Call<int>(0x7BCC6087D130312A, ped); }
		public static void _0xCE7A6C1D5CDE1F9D(int ped, Object _object, string propName, string animName) { Function.Call(0xCE7A6C1D5CDE1F9D, ped, _object, propName, animName); }
		public static void _0x604E1010E3162E86(Any p0, Any p1, Any p2) { Function.Call(0x604E1010E3162E86, p0, p1, p2); }
		public static void _0xE8ABE3B73FC7FE17(Any p0, Any p1, Any p2, Any p3) { Function.Call(0xE8ABE3B73FC7FE17, p0, p1, p2, p3); }
		public static void _REMOVE_PED_PROP(int ped, string propName) { Function.Call(0x3A50753042B6891B, ped, propName); }
		public static void _SET_TOTAL_PED_DAMAGE_FALLOFF_BONUS(int ped, float bonus) { Function.Call(0x932786CE3C76477C, ped, bonus); }
		public static Any _0x095C2277FED731DB(Any p0) { return Function.Call<Any>(0x095C2277FED731DB, p0); }
		public static void _0x09171A6F8FDE5DC1(Any p0, Any p1, Any p2, Any p3, Any p4) { Function.Call(0x09171A6F8FDE5DC1, p0, p1, p2, p3, p4); }
		public static void _0x09E378C52B1433B5(Any p0, Any p1, Any p2, Any p3, Any p4) { Function.Call(0x09E378C52B1433B5, p0, p1, p2, p3, p4); }
		public static BOOL _0x6507AC3BD7C99009(float x, float y, float z, float p3) { return Function.Call<BOOL>(0x6507AC3BD7C99009, x, y, z, p3); }
		public static float _GET_PLAYER_PED_WATER_DEPTH(int ped) { return Function.Call<float>(0x2942457417A5FD24, ped); }
		public static void _SET_PED_TRAIL_EFFECT(int ped, BOOL p1, float duration) { Function.Call(0xA5950E16B8F31052, ped, p1, duration); }
		public static BOOL _0xEBAAC9A750E7563B(int ped) { return Function.Call<BOOL>(0xEBAAC9A750E7563B, ped); }
		public static void _0x992187D975635DF5(Any p0, Any p1) { Function.Call(0x992187D975635DF5, p0, p1); }
		public static void _0x0B787A37EEDD226F(Any p0, Any p1) { Function.Call(0x0B787A37EEDD226F, p0, p1); }
	}

	public static class PERSCHAR
	{
		public static void _0x63AA2B8EB087886A(Any p0, Any p1) { Function.Call(0x63AA2B8EB087886A, p0, p1); }
		public static Hash _GET_PERSCHAR_MODEL_NAME(Hash persCharHash) { return Function.Call<Hash>(0xA00DF706C60173D1, persCharHash); }
		public static void _0x8BC555034A5A5E8C(Any p0, Any p1) { Function.Call(0x8BC555034A5A5E8C, p0, p1); }
		public static void _0x70605812ABC9FF0F(Any p0, Any p1) { Function.Call(0x70605812ABC9FF0F, p0, p1); }
		public static Any _0xDC9655D47DEC0353(Any p0) { return Function.Call<Any>(0xDC9655D47DEC0353, p0); }
		public static void _0x2DF89CD2ED1D0BDE(Any p0, Any p1) { Function.Call(0x2DF89CD2ED1D0BDE, p0, p1); }
		public static void _0x535A66AAD2BF68F9(Any p0, Any p1) { Function.Call(0x535A66AAD2BF68F9, p0, p1); }
		public static Any _0xCEB40B678E403759(Any p0) { return Function.Call<Any>(0xCEB40B678E403759, p0); }
		public static void _SET_PERSCHAR_SCHEDULE(Hash persCharHash, string schedule) { Function.Call(0x187D65F3AEC5D679, persCharHash, schedule); }
		public static void _0x8B44273A92CD406C(Any p0) { Function.Call(0x8B44273A92CD406C, p0); }
		public static void _0xE0E65E0D261F7507(Any p0) { Function.Call(0xE0E65E0D261F7507, p0); }
		public static Any _0x112DDF56300BC6E5(Any p0) { return Function.Call<Any>(0x112DDF56300BC6E5, p0); }
		public static PersChar _CREATE_PERSISTENT_CHARACTER(Hash hash) { return Function.Call<PersChar>(0x4F76E3676583D951, hash); }
		public static BOOL _IS_PERSISTENT_CHARACTER_VALID(PersChar persChar) { return Function.Call<BOOL>(0x800DF3FC913355F3, persChar); }
		public static void _DELETE_PERSCHAR(PersChar persChar) { Function.Call(0xFC77C5B44D5FF7C0, persChar); }
		public static Vector3 _0x5EE6FCCC9C832CA2(Any p0) { return Function.Call<Vector3>(0x5EE6FCCC9C832CA2, p0); }
		public static void _0x59C7AD6FEA2AC449(Any p0, Any p1, Any p2, Any p3) { Function.Call(0x59C7AD6FEA2AC449, p0, p1, p2, p3); }
		public static void _0xBB68908CD11AEBDC(Any p0) { Function.Call(0xBB68908CD11AEBDC, p0); }
		public static Vector3 _0x94995829ED15A598(Any p0) { return Function.Call<Vector3>(0x94995829ED15A598, p0); }
		public static int _GET_PERSCHAR_PED_INDEX(PersChar persChar) { return Function.Call<int>(0x31C70A716CAE1FEE, persChar); }
		public static PersChar _GET_PERSCHAR_INDEX_FROM_PED_INDEX(int ped) { return Function.Call<PersChar>(0x32A1E3B83D501096, ped); }
		public static Any _0xF8DE7154F7D1458F(Any p0) { return Function.Call<Any>(0xF8DE7154F7D1458F, p0); }
		public static void _0x669C25840C6F7AE2(Any p0, Any p1) { Function.Call(0x669C25840C6F7AE2, p0, p1); }
		public static void _RETASK_PERSISTENT_CHARACTER(PersChar persChar) { Function.Call(0x631CD2D77FDC0316, persChar); }
		public static void _0x0B3A99AB6713AA52(Any p0) { Function.Call(0x0B3A99AB6713AA52, p0); }
		public static BOOL _IS_PERSISTENT_CHARACTER_DEAD(PersChar persChar) { return Function.Call<BOOL>(0xEB98B38CA60742D7, persChar); }
		public static BOOL _REVIVE_PERSCHAR(PersChar persChar) { return Function.Call<BOOL>(0x49A8C2CD97815215, persChar); }
		public static void _0xD4B614179BCD0654(Any p0) { Function.Call(0xD4B614179BCD0654, p0); }
		public static void _0x406808610220405B(Any p0) { Function.Call(0x406808610220405B, p0); }
		public static void _0xA2B18FF8D39F6D87(Any p0) { Function.Call(0xA2B18FF8D39F6D87, p0); }
		public static Any _0xE4C51A8A3BD1664C(Any p0) { return Function.Call<Any>(0xE4C51A8A3BD1664C, p0); }
		public static void _0x8AE4EFA464DAE42D(Any p0, Any p1) { Function.Call(0x8AE4EFA464DAE42D, p0, p1); }
		public static void _0xA4DCB3F0DD7488BD(Any p0, Any p1, Any p2, Any p3, Any p4) { Function.Call(0xA4DCB3F0DD7488BD, p0, p1, p2, p3, p4); }
		public static void _0xD95D777F828B2BBB(Any p0) { Function.Call(0xD95D777F828B2BBB, p0); }
		public static void _0x92690B0822493CE0() { Function.Call(0x92690B0822493CE0); }
		public static void _0xEFC5C6670E0B99BA() { Function.Call(0xEFC5C6670E0B99BA); }
		public static void _0x2E957AA81F2C61C9() { Function.Call(0x2E957AA81F2C61C9); }
		public static void _0xB173599D61FAEB31() { Function.Call(0xB173599D61FAEB31); }
		public static int _0x08FC896D2CB31FCC(Any p0, BOOL p1) { return Function.Call<int>(0x08FC896D2CB31FCC, p0, p1); }
		public static int _FORCE_SPAWN_PERSCHAR(PersChar persChar, BOOL p1) { return Function.Call<int>(0x0CADC3A977997472, persChar, p1); }
		public static void _FORCE_DESPAWN_PERSCHAR(PersChar persChar) { Function.Call(0x7B204F88F6C3D287, persChar); }
		public static void _0xFCC6DB8DBE709BC8(Any p0) { Function.Call(0xFCC6DB8DBE709BC8, p0); }
		public static void _0xA8C406C2A56EDC16(Any p0) { Function.Call(0xA8C406C2A56EDC16, p0); }
		public static void _0x4F81EAD1DE8FA19B(Any p0) { Function.Call(0x4F81EAD1DE8FA19B, p0); }
		public static void _0x6759BEE6762E140B(Any p0) { Function.Call(0x6759BEE6762E140B, p0); }
		public static void _0xB65E7F733956CF25(Any p0) { Function.Call(0xB65E7F733956CF25, p0); }
		public static Any _0x4AFC7288C77238B3(Any p0) { return Function.Call<Any>(0x4AFC7288C77238B3, p0); }
		public static Any _0xA8120EBEAF290C7A(Any p0) { return Function.Call<Any>(0xA8120EBEAF290C7A, p0); }
		public static Any _0x69786495C92A3044(Any p0) { return Function.Call<Any>(0x69786495C92A3044, p0); }
		public static Any _0xEC254C2C9B0F08F1(Any p0, Any p1) { return Function.Call<Any>(0xEC254C2C9B0F08F1, p0, p1); }
		public static Any _0x9C7F95946E304778(Any p0, Any p1) { return Function.Call<Any>(0x9C7F95946E304778, p0, p1); }
	}

	public static class PERSISTENCE
	{
		public static void _0x7A1BD123E5CDB6E5() { Function.Call(0x7A1BD123E5CDB6E5); }
		public static void PERSISTENCE_REMOVE_ALL_ENTITIES_IN_AREA(float x, float y, float z, float radius) { Function.Call(0x9D16896F0DBE78A2, x, y, z, radius); }
		public static void _0x065887B694359799(Any p0) { Function.Call(0x065887B694359799, p0); }
		public static void _0xFC9806DA9A460093(float x1, float y1, float z1, float x2, float y2, float z2) { Function.Call(0xFC9806DA9A460093, x1, y1, z1, x2, y2, z2); }
		public static void _0xB03140014ACA6C40(Any p0, Any p1) { Function.Call(0xB03140014ACA6C40, p0, p1); }
		public static void _0xE225CEF1901F6108(Any p0, Any p1) { Function.Call(0xE225CEF1901F6108, p0, p1); }
		public static void _0x8DE104BEC243A73B(Any p0) { Function.Call(0x8DE104BEC243A73B, p0); }
		public static void _PERSISTENCE_REFRESH_TOWN_VOLUME(Volume volume) { Function.Call(0xEFB5F34CC0953B27, volume); }
		public static Any _0xBA2C49EA6A8D24FF(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6) { return Function.Call<Any>(0xBA2C49EA6A8D24FF, p0, p1, p2, p3, p4, p5, p6); }
		public static Any _0x2E545965DF98D476(Any p0) { return Function.Call<Any>(0x2E545965DF98D476, p0); }
		public static void _0xF5622FA6ACFCA7DB(Any p0, Any p1) { Function.Call(0xF5622FA6ACFCA7DB, p0, p1); }
		public static void _0x3CA5E58C9731A16B(Any p0, Any p1) { Function.Call(0x3CA5E58C9731A16B, p0, p1); }
		public static void _0xDC0A1F0ECEC9F0C0(Any p0, Any p1) { Function.Call(0xDC0A1F0ECEC9F0C0, p0, p1); }
		public static Any _0x5A79220F6D38D7C3(Any p0) { return Function.Call<Any>(0x5A79220F6D38D7C3, p0); }
		public static Any _0xCFDA2518F322D836(Any p0) { return Function.Call<Any>(0xCFDA2518F322D836, p0); }
		public static Any _0x1F56FB3FDB4EAF65(Any p0) { return Function.Call<Any>(0x1F56FB3FDB4EAF65, p0); }
		public static void _0x291CC21D1FB6790E(Any p0) { Function.Call(0x291CC21D1FB6790E, p0); }
		public static void PERSISTENCE_ADD_SCENARIO_LOOTED(int scenario) { Function.Call(0x8245C1F3262F4AC2, scenario); }
		public static BOOL _PERSISTENCE_IS_SCENARIO_MARKED_AS_LOOTED(int scenario) { return Function.Call<BOOL>(0xFB7CF1DE938A3E22, scenario); }
		public static BOOL _PERSISTENCE_IS_SCENARIO_MARKED_AS_LOOTED_AT_COORDS(float x, float y, float z) { return Function.Call<BOOL>(0xB6E1A185C2B9319A, x, y, z); }
		public static BOOL _PERSISTENCE_IS_SCENARIO_MARKED_AS_LOOTED_AT_COORDS_WITH_MODEL(float x, float y, float z, Hash model) { return Function.Call<BOOL>(0x188313616D184213, x, y, z, model); }
		public static void _0x66DAA3A9274E8E82() { Function.Call(0x66DAA3A9274E8E82); }
	}

	public static class PHYSICS
	{
		public static unsafe int ADD_ROPE(float x, float y, float z, float rotX, float rotY, float rotZ, float length, int ropeType, float maxLength, float minLength, float p10, BOOL p11, BOOL p12, BOOL rigid, float p14, BOOL breakWhenShot, Any* unkPtr, BOOL p17) { return Function.Call<int>(0xE832D760399EB220, x, y, z, rotX, rotY, rotZ, length, ropeType, maxLength, minLength, p10, p11, p12, rigid, p14, breakWhenShot, unkPtr, p17); }
		public static int _ADD_ROPE_2(float x, float y, float z, float rotX, float rotY, float rotZ, float length, int ropeType, BOOL isNetworked, int p9, float p10) { return Function.Call<int>(0xE9C59F6809373A99, x, y, z, rotX, rotY, rotZ, length, ropeType, isNetworked, p9, p10); }
		public static unsafe void DELETE_ROPE(int* ropeId) { Function.Call(0x52B4829281364649, ropeId); }
		public static void _RELEASE_ROPE(int ropeId) { Function.Call(0x6076213101A47B3B, ropeId); }
		public static void DELETE_CHILD_ROPE(int ropeId) { Function.Call(0xAA5D6B1888E4DB20, ropeId); }
		public static unsafe void _BREAK_ROPE(int* ropeId, int* ropeTop, int* ropeBottom, float offsetX, float offsetY, float offsetZ, int p6) { Function.Call(0x4CFA2B7FAE115ECB, ropeId, ropeTop, ropeBottom, offsetX, offsetY, offsetZ, p6); }
		public static BOOL DOES_ROPE_EXIST(int ropeId) { return Function.Call<BOOL>(0xFD5448BE3111ED96, ropeId); }
		public static BOOL _IS_ROPE_BROKEN(int ropeId) { return Function.Call<BOOL>(0x79C2BEC82CFD7F7F, ropeId); }
		public static unsafe void _0x7A54D82227A139DB(int* ropeId, Any p1) { Function.Call(0x7A54D82227A139DB, ropeId, p1); }
		public static unsafe void ROPE_DRAW_SHADOW_ENABLED(int* ropeId, BOOL toggle) { Function.Call(0xF159A63806BB5BA8, ropeId, toggle); }
		public static int GET_ROPE_VERTEX_COUNT(int ropeId) { return Function.Call<int>(0x3655F544CD30F0B5, ropeId); }
		public static void _0xE54BF2CE6C7D23A9(Any p0, Any p1, Any p2, Any p3, Any p4) { Function.Call(0xE54BF2CE6C7D23A9, p0, p1, p2, p3, p4); }
		public static void _0x9C24846D0A4A2776(Any p0) { Function.Call(0x9C24846D0A4A2776, p0); }
		public static void _0x0CB16D05E03FB525(Any p0) { Function.Call(0x0CB16D05E03FB525, p0); }
		public static void _0xF27F1A8DE4F50A1B(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6) { Function.Call(0xF27F1A8DE4F50A1B, p0, p1, p2, p3, p4, p5, p6); }
		public static void _0x21D0890D88DFB0B0(int ropeId, BOOL p1, float p2, float p3, float p4, float p5, float p6, float p7, float p8, float p9, int p10) { Function.Call(0x21D0890D88DFB0B0, ropeId, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10); }
		public static void ATTACH_ENTITIES_TO_ROPE(int ropeId, int entity1, int entity2, float ent1X, float ent1Y, float ent1Z, float ent2X, float ent2Y, float ent2Z, float length, int alwaysZero1, int alwaysZero2, string boneName1, string boneName2, BOOL p14, int boneId1, int boneId2, int alwaysZero3, int alwaysZero4, BOOL p19, BOOL p20) { Function.Call(0x3D95EC8B6D940AC3, ropeId, entity1, entity2, ent1X, ent1Y, ent1Z, ent2X, ent2Y, ent2Z, length, alwaysZero1, alwaysZero2, boneName1, boneName2, p14, boneId1, boneId2, alwaysZero3, alwaysZero4, p19, p20); }
		public static void _ATTACH_ENTITIES_TO_ROPE_2(int ropeId, int entity1, int entity2, float ent1X, float ent1Y, float ent1Z, float ent2X, float ent2Y, float ent2Z, string boneName1, string boneName2) { Function.Call(0x462FF2A432733A44, ropeId, entity1, entity2, ent1X, ent1Y, ent1Z, ent2X, ent2Y, ent2Z, boneName1, boneName2); }
		public static void _ATTACH_ENTITES_TO_ROPE_3(int ropeId, int entity1, int entity2, float p3, float p4, float p5, float p6, float p7, float p8, Any p9, Any p10) { Function.Call(0xE9CD9A67834985A7, ropeId, entity1, entity2, p3, p4, p5, p6, p7, p8, p9, p10); }
		public static void _0x69C810B72291D831(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6) { Function.Call(0x69C810B72291D831, p0, p1, p2, p3, p4, p5, p6); }
		public static void _0xB7469CB9AC3C0FD4(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7) { Function.Call(0xB7469CB9AC3C0FD4, p0, p1, p2, p3, p4, p5, p6, p7); }
		public static void _0xC64E7A62632AD2FE(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7) { Function.Call(0xC64E7A62632AD2FE, p0, p1, p2, p3, p4, p5, p6, p7); }
		public static BOOL _IS_ROPE_ATTACHED_TO_ENTITY(int ropeId, int entity) { return Function.Call<BOOL>(0x9B4F7E3E4F9C77B3, ropeId, entity); }
		public static void DETACH_ROPE_FROM_ENTITY(int ropeId, int entity) { Function.Call(0xBCF3026912A8647D, ropeId, entity); }
		public static void _HITCH_HORSE(int horse, float x, float y, float z) { Function.Call(0x06AADE17334F7A40, horse, x, y, z); }
		public static void _UNHITCH_HORSE(int horse) { Function.Call(0x0348469DAA17576C, horse); }
		public static void _0x6EA0E93CFFA472CC(Any p0) { Function.Call(0x6EA0E93CFFA472CC, p0); }
		public static void _0xBDDA142759307528(Any p0) { Function.Call(0xBDDA142759307528, p0); }
		public static void _0x32F4DBFDFCCCC735(Any p0, Any p1, Any p2) { Function.Call(0x32F4DBFDFCCCC735, p0, p1, p2); }
		public static void _0xF8CA39D5C0D1D9A1(Any p0, Any p1) { Function.Call(0xF8CA39D5C0D1D9A1, p0, p1); }
		public static void _0xEAF529446488EB18(Any p0) { Function.Call(0xEAF529446488EB18, p0); }
		public static void _0x31160EC47E7C9549(Any p0, Any p1) { Function.Call(0x31160EC47E7C9549, p0, p1); }
		public static void _0x5E981C764DF33117(Any p0, Any p1) { Function.Call(0x5E981C764DF33117, p0, p1); }
		public static void ROPE_SET_UPDATE_ORDER(int ropeId, Any p1) { Function.Call(0xDC57A637A20006ED, ropeId, p1); }
		public static void _0xFB9153A54AC713E8(int ropeId, BOOL p1) { Function.Call(0xFB9153A54AC713E8, ropeId, p1); }
		public static void _0xD699E688B49C0FD2(int ropeId, float p1, float p2, float p3, BOOL p4) { Function.Call(0xD699E688B49C0FD2, ropeId, p1, p2, p3, p4); }
		public static void _0xBB3E9B073E66C3C9(int ropeId, BOOL p1, BOOL p2, BOOL p3, BOOL p4) { Function.Call(0xBB3E9B073E66C3C9, ropeId, p1, p2, p3, p4); }
		public static void _0x522FA3F490E2F7AC(int ropeId, Any p1, Any p2) { Function.Call(0x522FA3F490E2F7AC, ropeId, p1, p2); }
		public static void _0x3900491C0D61ED4B(Any p0, Any p1) { Function.Call(0x3900491C0D61ED4B, p0, p1); }
		public static void _0xC89E7410A93AC19A(int ropeId, float p1) { Function.Call(0xC89E7410A93AC19A, ropeId, p1); }
		public static void _0x1D97DA8ACB5D2582(int ropeId, int p1) { Function.Call(0x1D97DA8ACB5D2582, ropeId, p1); }
		public static void _0x3C6490D940FF5D0B(int ropeId, Any p1, string ropeModelType, float length, BOOL p4) { Function.Call(0x3C6490D940FF5D0B, ropeId, p1, ropeModelType, length, p4); }
		public static Vector3 GET_ROPE_LAST_VERTEX_COORD(int ropeId) { return Function.Call<Vector3>(0x21BB0FBD3E217C2D, ropeId); }
		public static Vector3 GET_ROPE_VERTEX_COORD(int ropeId, int vertex) { return Function.Call<Vector3>(0xEA61CA8E80F09E4D, ropeId, vertex); }
		public static void START_ROPE_WINDING(int ropeId) { Function.Call(0x1461C72C889E343E, ropeId); }
		public static void STOP_ROPE_WINDING(int ropeId) { Function.Call(0xCB2D4AB84A19AA7C, ropeId); }
		public static void START_ROPE_UNWINDING_FRONT(int ropeId) { Function.Call(0x538D1179EC1AA9A9, ropeId); }
		public static void STOP_ROPE_UNWINDING_FRONT(int ropeId) { Function.Call(0xFFF3A50779EFBBB3, ropeId); }
		public static void _START_ROPE_UNWINDING_BACK(int ropeId) { Function.Call(0x00F611A794A3C36E, ropeId); }
		public static void _STOP_ROPE_UNWINDING_BACK(int ropeId) { Function.Call(0x10DAA76CB8A201A1, ropeId); }
		public static void _0x461FCBDEB4D06717(int ropeId, BOOL p1) { Function.Call(0x461FCBDEB4D06717, ropeId, p1); }
		public static void _0x423C6B1F3786D28B(Any p0, Any p1) { Function.Call(0x423C6B1F3786D28B, p0, p1); }
		public static void _0x76BAD9D538BCA1AA(int ropeId, float p1) { Function.Call(0x76BAD9D538BCA1AA, ropeId, p1); }
		public static void _0xB40EA9E0D2E2F7F3(int ropeId, float p1) { Function.Call(0xB40EA9E0D2E2F7F3, ropeId, p1); }
		public static Any _0x3D69537039F8D824(Any p0) { return Function.Call<Any>(0x3D69537039F8D824, p0); }
		public static void _0x751DF00EEFF122E3(Any p0) { Function.Call(0x751DF00EEFF122E3, p0); }
		public static void ROPE_FORCE_LENGTH(int ropeId, float length) { Function.Call(0xD009F759A723DB1B, ropeId, length); }
		public static void _0x8D59079C37C21D78(int ropeId, float p1) { Function.Call(0x8D59079C37C21D78, ropeId, p1); }
		public static void _0x814D453FCFDF119F(Any p0, Any p1, Any p2) { Function.Call(0x814D453FCFDF119F, p0, p1, p2); }
		public static void _0x1FC92BDBA1106BD2(Any p0, Any p1) { Function.Call(0x1FC92BDBA1106BD2, p0, p1); }
		public static void _0xDEDE679ED29DD4E7(int ropeId, BOOL p1) { Function.Call(0xDEDE679ED29DD4E7, ropeId, p1); }
		public static void _0xF1EA2A881EB7F2CD(int ropeId, BOOL p1) { Function.Call(0xF1EA2A881EB7F2CD, ropeId, p1); }
		public static void _0x5A989B7EE3672A56(Any p0, Any p1) { Function.Call(0x5A989B7EE3672A56, p0, p1); }
		public static void _0x483D4E917B0D35A9(Any p0, Any p1) { Function.Call(0x483D4E917B0D35A9, p0, p1); }
		public static int _0xEE360CFC80C8B2BC(int ropeId) { return Function.Call<int>(0xEE360CFC80C8B2BC, ropeId); }
		public static void SET_DAMPING(int entity, int vertex, float value) { Function.Call(0xEEA3B200A6FEB65B, entity, vertex, value); }
		public static void ACTIVATE_PHYSICS(int entity) { Function.Call(0x710311ADF0E20730, entity); }
		public static void BREAK_ENTITY_GLASS(int entity, float p1, float p2, float p3, float p4, float p5, float p6, float p7, float p8, Any p9, BOOL p10) { Function.Call(0x2E648D16F6E308F3, entity, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10); }
		public static void _0x8EEDFD8921389928(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8, Any p9) { Function.Call(0x8EEDFD8921389928, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9); }
		public static void SET_DISABLE_BREAKING(Object _object, BOOL toggle) { Function.Call(0x5CEC1A84620E7D5B, _object, toggle); }
		public static void SET_DISABLE_FRAG_DAMAGE(Object _object, BOOL toggle) { Function.Call(0x01BA3AED21C16CFB, _object, toggle); }
		public static void _0x5BD7457221CC5FF4(Any p0, Any p1) { Function.Call(0x5BD7457221CC5FF4, p0, p1); }
	}

	public static class PLAYER
	{
		public static int GET_PLAYER_PED(int player) { return Function.Call<int>(0x275F255ED201B937, player); }
		public static int _GET_PLAYER_PED_2(int player) { return Function.Call<int>(0x5EBE38A20BC51C27, player); }
		public static void _0x325434C68358D282(BOOL toggle) { Function.Call(0x325434C68358D282, toggle); }
		public static int GET_PLAYER_PED_SCRIPT_INDEX(int player) { return Function.Call<int>(0x5C880F9056D784C8, player); }
		public static void SET_PLAYER_MODEL(int player, Hash modelHash, BOOL p2) { Function.Call(0xED40380076A31506, player, modelHash, p2); }
		public static BOOL _NETWORK_HAS_PLAYER_VALID_PED(int player) { return Function.Call<BOOL>(0x0760D6F70EBCC05C, player); }
		public static int GET_PLAYER_TEAM(int player) { return Function.Call<int>(0xB464EB6A40C7975B, player); }
		public static void SET_PLAYER_TEAM(int player, int team, BOOL bRestrictToThisScript) { Function.Call(0xE8DD8536F01DE600, player, team, bRestrictToThisScript); }
		public static string GET_PLAYER_NAME(int player) { return Function.Call<string>(0x7124FD9AC0E01BA0, player); }
		public static string _FORMAT_PLAYER_NAME_STRING(string _string) { return Function.Call<string>(0x5B6193813E03E4E9, _string); }
		public static float GET_WANTED_LEVEL_RADIUS(int p0) { return Function.Call<float>(0x80B00EB26D9521C7, p0); }
		public static int GET_WANTED_LEVEL_THRESHOLD(int wantedLevel) { return Function.Call<int>(0x1B1A3B358F7D8F07, wantedLevel); }
		public static void SET_PLAYER_WANTED_LEVEL(int player, int wantedLevel, BOOL disableNoMission) { Function.Call(0x384D4765395E006C, player, wantedLevel, disableNoMission); }
		public static BOOL IS_PLAYER_WANTED_LEVEL_GREATER(int player, int wantedLevel) { return Function.Call<BOOL>(0xE1C0AD4C24324C36, player, wantedLevel); }
		public static void CLEAR_PLAYER_WANTED_LEVEL(int player) { Function.Call(0x4E4B996C928C7AA6, player); }
		public static BOOL IS_PLAYER_DEAD(int player) { return Function.Call<BOOL>(0x2E9C3FCB6798F397, player); }
		public static void SET_PLAYER_CONTROL(int player, BOOL toggle, int flags, BOOL bPreventHeadingChange) { Function.Call(0x4D51E59243281D80, player, toggle, flags, bPreventHeadingChange); }
		public static int GET_PLAYER_WANTED_LEVEL(int player) { return Function.Call<int>(0xABC532F9098BFD9D, player); }
		public static void SET_MAX_WANTED_LEVEL(int maxWantedLevel) { Function.Call(0x28A4BD2CEE236E19, maxWantedLevel); }
		public static void _SET_MAX_WANTED_LEVEL_2(int maxWantedLevel) { Function.Call(0xEA6DE0CD15AECBE2, maxWantedLevel); }
		public static void SET_POLICE_RADAR_BLIPS(BOOL toggle) { Function.Call(0x6FD7DD6B63F2820E, toggle); }
		public static BOOL IS_PLAYER_PLAYING(int player) { return Function.Call<BOOL>(0xBFFB35986CAAE58C, player); }
		public static void SET_EVERYONE_IGNORE_PLAYER(int player, BOOL toggle) { Function.Call(0x34630A768925B852, player, toggle); }
		public static BOOL GET_IS_PLAYER_UI_PROMPT_ACTIVE(int player, int p1) { return Function.Call<BOOL>(0x51BEA356B1C60225, player, p1); }
		public static void _MODIFY_PLAYER_UI_PROMPT(int player, int promptType, int promptMode, BOOL disabled) { Function.Call(0x0751D461F06E41CE, player, promptType, promptMode, disabled); }
		public static BOOL _GET_PLAYER_UI_PROMPT_IS_DISABLED(int player, int promptType, int promptMode) { return Function.Call<BOOL>(0x6614F9039BD31931, player, promptType, promptMode); }
		public static void _MODIFY_PLAYER_UI_PROMPT_FOR_PED(int player, int ped, int promptType, int promptMode, BOOL enabled) { Function.Call(0xA3DB37EDF9A74635, player, ped, promptType, promptMode, enabled); }
		public static BOOL _GET_PLAYER_UI_PROMPT_FOR_PED_IS_ENABLED(int player, int ped, int promptType, int promptMode) { return Function.Call<BOOL>(0xEA8F168A76A0B9BC, player, ped, promptType, promptMode); }
		public static void _0x93624B36E8851B42(int player) { Function.Call(0x93624B36E8851B42, player); }
		public static void _0x9073EC5456651A90(Any p0, Any p1) { Function.Call(0x9073EC5456651A90, p0, p1); }
		public static void _0x2E67707BEC52CA4B(Any p0) { Function.Call(0x2E67707BEC52CA4B, p0); }
		public static void SET_ALL_RANDOM_PEDS_FLEE(int player, BOOL toggle) { Function.Call(0xE705309B8C6445A4, player, toggle); }
		public static void SET_ALL_RANDOM_PEDS_FLEE_THIS_FRAME(int player) { Function.Call(0xD5C198A62F1DEB0A, player); }
		public static void _0x16752DAA7E6D3F72(int player) { Function.Call(0x16752DAA7E6D3F72, player); }
		public static void _0x1D256EED194F5B58(Any p0) { Function.Call(0x1D256EED194F5B58, p0); }
		public static Any _0x5B7B97E99F84138B(Any p0) { return Function.Call<Any>(0x5B7B97E99F84138B, p0); }
		public static void _SET_DISABLE_PLAYER_WANTED_LEVEL(int player, BOOL disable) { Function.Call(0x8674D138391FFB1B, player, disable); }
		public static Any _0xA82964B9D8D6A983() { return Function.Call<Any>(0xA82964B9D8D6A983); }
		public static void SET_WANTED_LEVEL_MULTIPLIER(float multiplier) { Function.Call(0xD7FA719CB54866C2, multiplier); }
		public static void RESET_WANTED_LEVEL_DIFFICULTY(int player) { Function.Call(0x062D14F18E8B0CAE, player); }
		public static void _0xD0B0B044112BF424(int player) { Function.Call(0xD0B0B044112BF424, player); }
		public static void _0x96722257E5381E00(int player) { Function.Call(0x96722257E5381E00, player); }
		public static void REPORT_POLICE_SPOTTED_PLAYER(int player) { Function.Call(0xCBCCF73FFA69CC6B, player); }
		public static void _0xD2DFC9CCA5596A11(float p0) { Function.Call(0xD2DFC9CCA5596A11, p0); }
		public static void _0x5CE5CACC01D0F985() { Function.Call(0x5CE5CACC01D0F985); }
		public static BOOL CAN_PLAYER_START_MISSION(int player) { return Function.Call<BOOL>(0x2DF170B1185AF777, player); }
		public static BOOL IS_PLAYER_READY_FOR_CUTSCENE(int player) { return Function.Call<BOOL>(0xAA67BCB0097F2FA3, player); }
		public static BOOL IS_PLAYER_TARGETTING_ENTITY(int player, int entity, BOOL p2) { return Function.Call<BOOL>(0x27F89FDC16688A7A, player, entity, p2); }
		public static unsafe BOOL GET_PLAYER_TARGET_ENTITY(int player, int* entity) { return Function.Call<BOOL>(0xAE663DDD99C8A670, player, entity); }
		public static BOOL _0x927861B2C08DBEA5(int player) { return Function.Call<BOOL>(0x927861B2C08DBEA5, player); }
		public static BOOL _IS_PLAYER_FREE_FOCUSING(int player) { return Function.Call<BOOL>(0x1A51BFE60708E482, player); }
		public static unsafe BOOL GET_PLAYER_INTERACTION_TARGET_ENTITY(int player, int* _outEntity, BOOL p2, BOOL p3) { return Function.Call<BOOL>(0x3EE1F7A8C32F24E1, player, _outEntity, p2, p3); }
		public static Any _0xBEA3A6E5F5F79A6F(Any p0, Any p1) { return Function.Call<Any>(0xBEA3A6E5F5F79A6F, p0, p1); }
		public static BOOL _IS_PLAYER_IN_SCOPE(int player) { return Function.Call<BOOL>(0x04D7F33640662FA2, player); }
		public static BOOL IS_PLAYER_FREE_AIMING(int player) { return Function.Call<BOOL>(0x936F967D4BE1CE9D, player); }
		public static BOOL IS_PLAYER_FREE_AIMING_AT_ENTITY(int player, int entity) { return Function.Call<BOOL>(0x8C67C11C68713D25, player, entity); }
		public static unsafe BOOL GET_ENTITY_PLAYER_IS_FREE_AIMING_AT(int player, int* entity) { return Function.Call<BOOL>(0xA6817C110B830EAD, player, entity); }
		public static void _0x3DAABE78A23694BC(Any p0, Any p1) { Function.Call(0x3DAABE78A23694BC, p0, p1); }
		public static unsafe BOOL _0x7AE93C45EC14A166(int player, int* ped) { return Function.Call<BOOL>(0x7AE93C45EC14A166, player, ped); }
		public static void SET_PLAYER_LOCKON_RANGE_OVERRIDE(int player, float range) { Function.Call(0x3A3CD06597388322, player, range); }
		public static void SET_PLAYER_CAN_BE_HASSLED_BY_GANGS(int player, BOOL toggle) { Function.Call(0xC7FE774412046825, player, toggle); }
		public static void SET_PLAYER_CAN_USE_COVER(int player, BOOL toggle) { Function.Call(0x5EDA520F7A3BAF4E, player, toggle); }
		public static void _0xD1A70C1E8D1031FE(Any p0, Any p1) { Function.Call(0xD1A70C1E8D1031FE, p0, p1); }
		public static void _0xACA45DDCEF6071C4(int player, BOOL p1) { Function.Call(0xACA45DDCEF6071C4, player, p1); }
		public static void _0xA0C683284DF027C7(int player, int p1, BOOL enable) { Function.Call(0xA0C683284DF027C7, player, p1, enable); }
		public static void _SET_PLAYER_CAN_MERCY_KILL(int player, BOOL toggle) { Function.Call(0x39363DFD04E91496, player, toggle); }
		public static void _0x4EC8BE63B8A5D4EF(int player, int p1) { Function.Call(0x4EC8BE63B8A5D4EF, player, p1); }
		public static int GET_MAX_WANTED_LEVEL() { return Function.Call<int>(0xD04CFAD1E2B7984A); }
		public static BOOL IS_PLAYER_TARGETTING_ANYTHING(int player) { return Function.Call<BOOL>(0x4605C66E0F935F83, player); }
		public static void RESTORE_PLAYER_STAMINA(int player, float p1) { Function.Call(0xC41F4B6E23FE6A4A, player, p1); }
		public static void _0x8591EE69CC3ED257(int player, BOOL toggle) { Function.Call(0x8591EE69CC3ED257, player, toggle); }
		public static int GET_PLAYER_GROUP(int player) { return Function.Call<int>(0x9BAB31815159ABCF, player); }
		public static void _0x3D9DA5C9EFD20D88(Any p0, Any p1) { Function.Call(0x3D9DA5C9EFD20D88, p0, p1); }
		public static void _0x2BEED53B912537D0(Any p0, Any p1, Any p2) { Function.Call(0x2BEED53B912537D0, p0, p1, p2); }
		public static void _0x908D4B72854C8F62(Any p0) { Function.Call(0x908D4B72854C8F62, p0); }
		public static Any _0xD1F6B912785BFD35(Any p0) { return Function.Call<Any>(0xD1F6B912785BFD35, p0); }
		public static void _0xC4873B053054C04B(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7) { Function.Call(0xC4873B053054C04B, p0, p1, p2, p3, p4, p5, p6, p7); }
		public static void _0xCA59808E51FD67C4(Any p0, Any p1) { Function.Call(0xCA59808E51FD67C4, p0, p1); }
		public static void _0xBA5CA1FEB5DE0DF6(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5) { Function.Call(0xBA5CA1FEB5DE0DF6, p0, p1, p2, p3, p4, p5); }
		public static void _0x0869D499A7848309(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7) { Function.Call(0x0869D499A7848309, p0, p1, p2, p3, p4, p5, p6, p7); }
		public static unsafe BOOL _0xB331D8A73F9D2BDF(int player, Any* p1) { return Function.Call<BOOL>(0xB331D8A73F9D2BDF, player, p1); }
		public static void _0xAC22AA6DF4D1C1DE(int player, int ped, float p2, float p3, Any followMode, Any followPriority, Any p6) { Function.Call(0xAC22AA6DF4D1C1DE, player, ped, p2, p3, followMode, followPriority, p6); }
		public static void _REMOVE_PLAYER_AS_FOLLOW_TARGET(int player, int ped) { Function.Call(0x0C6B89876262A99D, player, ped); }
		public static void _0x12E09E278C6C29B7(Any p0) { Function.Call(0x12E09E278C6C29B7, p0); }
		public static void _0xDD33A82352C4652F(int player, int ped, Any p2) { Function.Call(0xDD33A82352C4652F, player, ped, p2); }
		public static void _0x1FDA57E8908F2609(int player, int ped, BOOL useSteerassist) { Function.Call(0x1FDA57E8908F2609, player, ped, useSteerassist); }
		public static void _0x84481018E668E1B8(int player, int ped, Any p2) { Function.Call(0x84481018E668E1B8, player, ped, p2); }
		public static BOOL _0x2009F8AB7A5E9D6D(int player) { return Function.Call<BOOL>(0x2009F8AB7A5E9D6D, player); }
		public static BOOL _IS_PLAYER_FOLLOWING_TARGET(int player, int ped) { return Function.Call<BOOL>(0xE24C64D9ADED2EF5, player, ped); }
		public static BOOL _0xE7F8707269544B29(int player, int ped) { return Function.Call<BOOL>(0xE7F8707269544B29, player, ped); }
		public static Any _0xE631EAF35828FA67(Any p0) { return Function.Call<Any>(0xE631EAF35828FA67, p0); }
		public static void _0x086549F3B0381CB1(Any p0, Any p1) { Function.Call(0x086549F3B0381CB1, p0, p1); }
		public static BOOL IS_PLAYER_CONTROL_ON(int player) { return Function.Call<BOOL>(0x7964097FCE4C244B, player); }
		public static BOOL IS_PLAYER_SCRIPT_CONTROL_ON(int player) { return Function.Call<BOOL>(0xB78350754157C00F, player); }
		public static BOOL IS_PLAYER_CLIMBING(int player) { return Function.Call<BOOL>(0xB8A70C22FD48197A, player); }
		public static void _0xEBB6E27AC2FF32DA(Any p0, Any p1, Any p2, Any p3, Any p4) { Function.Call(0xEBB6E27AC2FF32DA, p0, p1, p2, p3, p4); }
		public static Any _0xB15CD2F9932C9AB5(Any p0) { return Function.Call<Any>(0xB15CD2F9932C9AB5, p0); }
		public static BOOL _0x621D1B289CAF5978(int player) { return Function.Call<BOOL>(0x621D1B289CAF5978, player); }
		public static BOOL IS_PLAYER_BEING_ARRESTED(int player, BOOL atArresting) { return Function.Call<BOOL>(0xC8183AE963C58374, player, atArresting); }
		public static void RESET_PLAYER_ARREST_STATE(int player) { Function.Call(0x12917931C31F1750, player); }
		public static void _0xCBB54CC7FFFFAB86(Any p0, Any p1, Any p2, Any p3) { Function.Call(0xCBB54CC7FFFFAB86, p0, p1, p2, p3); }
		public static void _0xBED386157F65942C(Any p0, Any p1) { Function.Call(0xBED386157F65942C, p0, p1); }
		public static Any _0xDAB6A2FC56B7DE65(Any p0) { return Function.Call<Any>(0xDAB6A2FC56B7DE65, p0); }
		public static Any _0x0F4EAF69DA41AF43(Any p0) { return Function.Call<Any>(0x0F4EAF69DA41AF43, p0); }
		public static void _SET_BOUNTY_TARGET(int player, int target) { Function.Call(0x6ADF821FBF21920E, player, target); }
		public static void _CLEAR_BOUNTY_TARGET(int player) { Function.Call(0x8F2A81C09DA9124A, player); }
		public static int GET_PLAYERS_LAST_VEHICLE() { return Function.Call<int>(0x2F96E7720B0B19EA); }
		public static int GET_PLAYER_INDEX() { return Function.Call<int>(0x47E385B0D957C8D4); }
		public static int INT_TO_PLAYERINDEX(int value) { return Function.Call<int>(0x748B3A65C2604C33, value); }
		public static int INT_TO_PARTICIPANTINDEX(int value) { return Function.Call<int>(0x58FF971FC8F2702C, value); }
		public static int PLAYER_ID() { return Function.Call<int>(0x217E9DC48139933D); }
		public static int PLAYER_PED_ID() { return Function.Call<int>(0x096275889B8E0EE0); }
		public static int NETWORK_PLAYER_ID_TO_INT() { return Function.Call<int>(0x8A9386F0749A17FA); }
		public static BOOL HAS_FORCE_CLEANUP_OCCURRED(int cleanupFlags) { return Function.Call<BOOL>(0xC11469DCA6FC3BB5, cleanupFlags); }
		public static void FORCE_CLEANUP(int cleanupFlags) { Function.Call(0x768C017FB878E4F4, cleanupFlags); }
		public static void FORCE_CLEANUP_FOR_ALL_THREADS_WITH_THIS_NAME(string name, int cleanupFlags) { Function.Call(0xDAACAF8B687F2353, name, cleanupFlags); }
		public static void FORCE_CLEANUP_FOR_THREAD_WITH_THIS_ID(int id, int cleanupFlags) { Function.Call(0xF4C9512A2F0A3031, id, cleanupFlags); }
		public static int GET_CAUSE_OF_MOST_RECENT_FORCE_CLEANUP() { return Function.Call<int>(0x84E8E29EBD4A46D2); }
		public static void _0x39BED552DB46FFA9(Any p0, Any p1) { Function.Call(0x39BED552DB46FFA9, p0, p1); }
		public static int _0x054473164C012699(int player) { return Function.Call<int>(0x054473164C012699, player); }
		public static void SET_PLAYER_MAY_ONLY_ENTER_THIS_VEHICLE(int player, int vehicle) { Function.Call(0xDA35A134038557EC, player, vehicle); }
		public static void _0xC71D07C96946E263(Any p0, Any p1) { Function.Call(0xC71D07C96946E263, p0, p1); }
		public static void SET_PLAYER_MAY_NOT_ENTER_ANY_VEHICLE(int player) { Function.Call(0xBEC463B3A11C909E, player); }
		public static BOOL IS_SYSTEM_UI_BEING_DISPLAYED() { return Function.Call<BOOL>(0x908258B6209E71F7); }
		public static void _0xD48227263E3D06AE(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8, Any p9) { Function.Call(0xD48227263E3D06AE, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9); }
		public static void _0x3946FC742AC305CD(int player, int ped, string p2, float x, float y, float z, int targetEntity, string p7) { Function.Call(0x3946FC742AC305CD, player, ped, p2, x, y, z, targetEntity, p7); }
		public static void _0xA28056CD1B04B250(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8, Any p9, Any p10) { Function.Call(0xA28056CD1B04B250, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10); }
		public static void _0xC67A4910425F11F1(int player, string name) { Function.Call(0xC67A4910425F11F1, player, name); }
		public static void SET_PLAYER_INVINCIBLE(int player, BOOL toggle) { Function.Call(0xFEBEEBC9CBDF4B12, player, toggle); }
		public static BOOL GET_PLAYER_INVINCIBLE(int player) { return Function.Call<BOOL>(0x0CBBCB2CCFA7DC4E, player); }
		public static void SET_PLAYER_LOCKON(int player, BOOL toggle) { Function.Call(0x462AA1973CBBA75E, player, toggle); }
		public static void SET_LOCKON_TO_FRIENDLY_PLAYERS(int player, BOOL toggle) { Function.Call(0x4A056257802DD3E5, player, toggle); }
		public static void SET_PLAYER_TARGETING_MODE(int targetMode) { Function.Call(0xD66A941F401E7302, targetMode); }
		public static void _SET_PLAYER_IN_VEHICLE_TARGETING_MODE(int targetMode) { Function.Call(0x19B4F71703902238, targetMode); }
		public static Any _0x747257807B8721CE(Any p0, Any p1) { return Function.Call<Any>(0x747257807B8721CE, p0, p1); }
		public static Any _0x8702D9150D9FBB3D(Any p0, Any p1) { return Function.Call<Any>(0x8702D9150D9FBB3D, p0, p1); }
		public static void _0xCB0B9506BC91E441(Any p0, Any p1) { Function.Call(0xCB0B9506BC91E441, p0, p1); }
		public static void CLEAR_PLAYER_HAS_DAMAGED_AT_LEAST_ONE_PED(int player) { Function.Call(0x270B63A641BE32F2, player); }
		public static BOOL HAS_PLAYER_DAMAGED_AT_LEAST_ONE_PED(int player) { return Function.Call<BOOL>(0xDA4A4B9B96E20092, player); }
		public static void CLEAR_PLAYER_HAS_DAMAGED_AT_LEAST_ONE_NON_ANIMAL_PED(int player) { Function.Call(0x0361096D6CE4372C, player); }
		public static BOOL HAS_PLAYER_DAMAGED_AT_LEAST_ONE_NON_ANIMAL_PED(int player) { return Function.Call<BOOL>(0x16C8D205DD5A2E90, player); }
		public static void _0xEACEBAAE0A33FB3F(Any p0) { Function.Call(0xEACEBAAE0A33FB3F, p0); }
		public static BOOL _0x72AD59F7B7FB6E24(int player, int p1) { return Function.Call<BOOL>(0x72AD59F7B7FB6E24, player, p1); }
		public static unsafe BOOL _0x1A6E84F13C952094(int player, int p1, Any* p2) { return Function.Call<BOOL>(0x1A6E84F13C952094, player, p1, p2); }
		public static void _SET_PLAYER_DAMAGE_INFO_OVERRIDE(int player, string damageInfo) { Function.Call(0x78B3D19AF6391A55, player, damageInfo); }
		public static void _0x1F488807BC8E0630(Any p0) { Function.Call(0x1F488807BC8E0630, p0); }
		public static void SET_AIR_DRAG_MULTIPLIER_FOR_PLAYERS_VEHICLE(int player, float multiplier) { Function.Call(0x5DA6500FE849DA16, player, multiplier); }
		public static void SET_SWIM_MULTIPLIER_FOR_PLAYER(int player, float multiplier) { Function.Call(0xBFCEABDE34DA5085, player, multiplier); }
		public static BOOL _0x73EB2EF2E92D23BF() { return Function.Call<BOOL>(0x73EB2EF2E92D23BF); }
		public static void SET_PLAYER_FORCED_AIM(int player, BOOL toggle, int ped, int p3, BOOL p4) { Function.Call(0xD5FCC166AEB2FD0F, player, toggle, ped, p3, p4); }
		public static void _0x310CE349E0C0EC4B(int player, int ped, int p2) { Function.Call(0x310CE349E0C0EC4B, player, ped, p2); }
		public static void DISABLE_PLAYER_FIRING(int player, BOOL toggle) { Function.Call(0x2970929FD5F9FC89, player, toggle); }
		public static void _0xEBFF94328FF7A18A(Any p0, Any p1) { Function.Call(0xEBFF94328FF7A18A, p0, p1); }
		public static void _0xF993373285053D77(Any p0, Any p1, Any p2) { Function.Call(0xF993373285053D77, p0, p1, p2); }
		public static Any _0xE956C2340A76272E(Any p0) { return Function.Call<Any>(0xE956C2340A76272E, p0); }
		public static void _ENABLE_CUSTOM_DEADEYE_ABILITY(int player, BOOL enable) { Function.Call(0x95EE1DEE1DCD9070, player, enable); }
		public static Any _0xDE6C85975F9D4894(Any p0) { return Function.Call<Any>(0xDE6C85975F9D4894, p0); }
		public static void _0xBBA140062B15A8AC(int player) { Function.Call(0xBBA140062B15A8AC, player); }
		public static void _SPECIAL_ABILITY_SET_DISABLED(int player, BOOL disabled) { Function.Call(0xAE637BB8EF017875, player, disabled); }
		public static BOOL _IS_SPECIAL_ABILITY_ACTIVE(int player) { return Function.Call<BOOL>(0xB16223CB7DA965F0, player); }
		public static void _MODIFY_INFINITE_TRAIL_VISION(int ped, BOOL toggle) { Function.Call(0x28A13BF6B05C3D83, ped, toggle); }
		public static void _SPECIAL_ABILITY_SET_EAGLE_EYE_DISABLED(int ped) { Function.Call(0xC0B21F235C02139C, ped); }
		public static void _SPECIAL_ABILITY_RESTORE_BY_AMOUNT(int player, float amount, int p2, int p3, int p4) { Function.Call(0x51345AE20F22C261, player, amount, p2, p3, p4); }
		public static void _0xFA437FA0738C370C(int player, float p1, int p2, int p3, int p4) { Function.Call(0xFA437FA0738C370C, player, p1, p2, p3, p4); }
		public static void _SPECIAL_ABILITY_RESTORE_OUTER_RING(int player, float amount) { Function.Call(0x2498035289B5688F, player, amount); }
		public static float _GET_PLAYER_REQUIRED_DEAD_EYE_AMOUNT(int player) { return Function.Call<float>(0x811A748B1BE231BA, player); }
		public static float _SPECIAL_ABILITY_GET_AMOUNT_CACHED(int player) { return Function.Call<float>(0x029884FB65821B07, player); }
		public static void _SPECIAL_ABILITY_DRAIN_BY_AMOUNT(int player, float amount, Any p2) { Function.Call(0x200114E99552462B, player, amount, p2); }
		public static void _SPECIAL_ABILITY_START_RESTORE(int player, int p1, BOOL p2) { Function.Call(0x1D77B47AFA584E90, player, p1, p2); }
		public static void _SET_SPECIAL_ABILITY_MULTIPLIER(int player, float multiplier) { Function.Call(0x5A498FCA232F71E1, player, multiplier); }
		public static float _GET_PLAYER_SPECIAL_ABILITY_MULTIPLIER(int player) { return Function.Call<float>(0xAB3773E7AA1E9DCC, player); }
		public static void _0x00BA333DA05ADC23(Any p0, Any p1) { Function.Call(0x00BA333DA05ADC23, p0, p1); }
		public static void _0x22B3CABEDDB538B2(int player, float p1) { Function.Call(0x22B3CABEDDB538B2, player, p1); }
		public static void _SET_SPECIAL_ABILITY_DURATION_COST(int player, float durationCost) { Function.Call(0xB783F75940B23014, player, durationCost); }
		public static void _SET_SPECIAL_ABILITY_DISABLE_TIMER(int player, float timer) { Function.Call(0xC0B1C05B313693D1, player, timer); }
		public static Any _0x57D9991DC1334151(Any p0) { return Function.Call<Any>(0x57D9991DC1334151, p0); }
		public static Any _0x21091B4BEB6376EE(Any p0) { return Function.Call<Any>(0x21091B4BEB6376EE, p0); }
		public static void _SET_SPECIAL_ABILITY_ACTIVATION_COST(int player, float activationCost, int p2) { Function.Call(0xAE4BCC79C587EBBF, player, activationCost, p2); }
		public static void _0x4D1699543B1C023C(int player, float p1) { Function.Call(0x4D1699543B1C023C, player, p1); }
		public static float _GET_PLAYER_DEAD_EYE_METER_LEVEL(int player, BOOL p1) { return Function.Call<float>(0x3A6AE4EEE30370FE, player, p1); }
		public static float _GET_PLAYER_DEAD_EYE(int player) { return Function.Call<float>(0xA81D24AE0AF99A5E, player); }
		public static float _GET_PLAYER_CACHED_DEAD_EYE_AMOUNT(int player) { return Function.Call<float>(0xDF66A37936D5F3D9, player); }
		public static float _GET_PLAYER_MAX_DEAD_EYE(int player, Any p1) { return Function.Call<float>(0x592F58BC4D2A2CF3, player, p1); }
		public static float _GET_PLAYER_HEALTH(int player) { return Function.Call<float>(0x0317C947D062854E, player); }
		public static float _GET_PLAYER_STAMINA(int player) { return Function.Call<float>(0x0FF421E467373FCF, player); }
		public static void _SET_PLAYER_STAT_FLAG_HASH(int player, Hash p1) { Function.Call(0x768E81AE285A4B67, player, p1); }
		public static void _0x0E1DB1F8F5B561DC(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5) { Function.Call(0x0E1DB1F8F5B561DC, p0, p1, p2, p3, p4, p5); }
		public static void _0x08E22898A6AF4905(Any p0, Any p1) { Function.Call(0x08E22898A6AF4905, p0, p1); }
		public static Any _0xBEFED69CE8317F91(Any p0) { return Function.Call<Any>(0xBEFED69CE8317F91, p0); }
		public static void _ENABLE_EAGLEEYE(int player, BOOL enable) { Function.Call(0xA63FCAD3A6FEC6D2, player, enable); }
		public static Any _0xE022CC1B545F1D9F(Any p0) { return Function.Call<Any>(0xE022CC1B545F1D9F, p0); }
		public static void _SECONDARY_SPECIAL_ABILITY_SET_ACTIVE(int player) { Function.Call(0x1710BC33CFB83634, player); }
		public static void _SECONDARY_SPECIAL_ABILITY_SET_DISABLED(int player, BOOL disabled) { Function.Call(0x64FF4BF9AF59E139, player, disabled); }
		public static BOOL _IS_SECONDARY_SPECIAL_ABILITY_ACTIVE(int player) { return Function.Call<BOOL>(0x45AB66D02B601FA7, player); }
		public static void _0x107F2A66E1C4C83A(Any p0) { Function.Call(0x107F2A66E1C4C83A, p0); }
		public static void START_PLAYER_TELEPORT(int player, float x, float y, float z, float heading, BOOL p5, BOOL p6, BOOL p7, BOOL p8) { Function.Call(0xDF8822C55EDDA65B, player, x, y, z, heading, p5, p6, p7, p8); }
		public static void _0x2C2D287748E8E9B7(BOOL p0) { Function.Call(0x2C2D287748E8E9B7, p0); }
		public static BOOL UPDATE_PLAYER_TELEPORT(int player) { return Function.Call<BOOL>(0xC39DCE4672CBFBC1, player); }
		public static void STOP_PLAYER_TELEPORT() { Function.Call(0x0858B86146601BE8); }
		public static BOOL IS_PLAYER_TELEPORT_ACTIVE() { return Function.Call<BOOL>(0x085EEAEB8783FEB5); }
		public static float GET_PLAYER_CURRENT_STEALTH_NOISE(int player) { return Function.Call<float>(0xD7ECC25E176ECBA5, player); }
		public static void SET_PLAYER_HEALTH_RECHARGE_MULTIPLIER(int player, float regenRate) { Function.Call(0x8899C244EBCF70DE, player, regenRate); }
		public static float _GET_PLAYER_HEALTH_RECHARGE_MULTIPLIER(int player) { return Function.Call<float>(0x22CD23BB0C45E0CD, player); }
		public static void _SET_PLAYER_HEALTH_RECHARGE_TIME_MODIFIER(int player, float modifier) { Function.Call(0x535ED4605F89AB6E, player, modifier); }
		public static void SET_PLAYER_STAMINA_RECHARGE_MULTIPLIER(int player, float multiplier) { Function.Call(0xFECA17CF3343694B, player, multiplier); }
		public static float _GET_PLAYER_STAMINA_RECHARGE_MULTIPLIER(int player) { return Function.Call<float>(0x617D3494AD58200F, player); }
		public static void _SET_PLAYER_STAMINA_SPRINT_DEPLETION_MULTIPLIER(int player, float multiplier) { Function.Call(0xBBADFB5E5E5766FB, player, multiplier); }
		public static float _GET_PLAYER_STAMINA_DEPLETION_MULTIPLIER(int player) { return Function.Call<float>(0x68A0389E0718AC8F, player); }
		public static void _SET_PED_ACTIVE_PLAYER_HORSE(int player, int horse) { Function.Call(0x8FBF9EDB378CCB8C, player, horse); }
		public static int _GET_ACTIVE_HORSE_FOR_PLAYER(int player) { return Function.Call<int>(0x46FA0AE18F4C7FA9, player); }
		public static void _SET_PED_AS_SADDLE_HORSE_FOR_PLAYER(int player, int mount) { Function.Call(0xD2CB0FB0FDCB473D, player, mount); }
		public static int _GET_SADDLE_HORSE_FOR_PLAYER(int player) { return Function.Call<int>(0xB48050D326E9A2F3, player); }
		public static BOOL SET_PED_AS_TEMP_PLAYER_HORSE(int player, int horse) { return Function.Call<BOOL>(0x227B06324234FB09, player, horse); }
		public static int _GET_TEMP_PLAYER_HORSE(int player) { return Function.Call<int>(0xD3F7445CEA2E5035, player); }
		public static void _0x77B0B6D17A3AC9AA(Any p0, Any p1) { Function.Call(0x77B0B6D17A3AC9AA, p0, p1); }
		public static void _0xDF93973251FB2CA5(Any p0, Any p1) { Function.Call(0xDF93973251FB2CA5, p0, p1); }
		public static void _0x694FFA4308060CD1(Any p0, Any p1) { Function.Call(0x694FFA4308060CD1, p0, p1); }
		public static void BOOST_PLAYER_HORSE_SPEED_FOR_TIME(int player, float speedBoost, int duration) { Function.Call(0x09C28F828EE674FA, player, speedBoost, duration); }
		public static void SET_PLAYER_WEAPON_DAMAGE_MODIFIER(int player, float modifier) { Function.Call(0x94D529F7B73D7A85, player, modifier); }
		public static void SET_PLAYER_WEAPON_DEFENSE_MODIFIER(int player, float modifier) { Function.Call(0xD15CC2D493160BE3, player, modifier); }
		public static void _0x818241B3EDA84191(Any p0, Any p1) { Function.Call(0x818241B3EDA84191, p0, p1); }
		public static void SET_PLAYER_MELEE_WEAPON_DAMAGE_MODIFIER(int player, float modifier) { Function.Call(0xE4CB5A3F18170381, player, modifier); }
		public static void _SET_PLAYER_EXPLOSIVE_WEAPON_DAMAGE_MODIFIER(int player, float modifier) { Function.Call(0x2D3ACE3DE0A2B622, player, modifier); }
		public static void _0x83C989D5B5B5B466(Any p0, Any p1) { Function.Call(0x83C989D5B5B5B466, p0, p1); }
		public static Any _0x03B4B759A8990505(Any p0) { return Function.Call<Any>(0x03B4B759A8990505, p0); }
		public static void _0x67659A8F248E0141(Any p0, Any p1) { Function.Call(0x67659A8F248E0141, p0, p1); }
		public static void _SET_RECEIVED_HORSEBACK_DAMAGE_DECREASE(int player, float damageDecrease) { Function.Call(0xB427911EA6DFFEF3, player, damageDecrease); }
		public static void _SET_AI_PLAYER_DEFENSE_MODIFIER_AGAINST_AI(int player, float modifier) { Function.Call(0x914071FF93AF2692, player, modifier); }
		public static float _GET_AI_PLAYER_DEFENSE_MODIFIER_AGAINST_AI(int player) { return Function.Call<float>(0x2E78D822208E740A, player); }
		public static Any _0x19B2C7A6C34FAD54(Any p0, Any p1) { return Function.Call<Any>(0x19B2C7A6C34FAD54, p0, p1); }
		public static Any _0x9422743A5BA50E10(Any p0) { return Function.Call<Any>(0x9422743A5BA50E10, p0); }
		public static void _SET_PLAYER_DEFENSE_MODIFIER(int player, float weaponDefenseMod, float meleeDefenseMod) { Function.Call(0x497A6539BB0E8787, player, weaponDefenseMod, meleeDefenseMod); }
		public static void _SET_PLAYER_DEFENSE_TYPE_MODIFIER(int player, int type, float defenseModifier) { Function.Call(0x93F499CAE53FCD05, player, type, defenseModifier); }
		public static void SET_PLAYER_WEAPON_TYPE_DAMAGE_MODIFIER(int player, Hash weaponHash, float damageModifier) { Function.Call(0xD04AD186CE8BB129, player, weaponHash, damageModifier); }
		public static float _GET_PLAYER_WEAPON_DAMAGE(int player, Hash weaponHash) { return Function.Call<float>(0xFE0304050261442C, player, weaponHash); }
		public static void _0x5C2E5E3CAEEB1F58(Any p0, Any p1, Any p2) { Function.Call(0x5C2E5E3CAEEB1F58, p0, p1, p2); }
		public static void _SET_PLAYER_WEAPON_GROUP_DAMAGE_MODIFIER(int player, Hash weaponGroup, float modifier) { Function.Call(0xFC79DCC94D0A5897, player, weaponGroup, modifier); }
		public static void _SET_PLAYER_WEAPON_GROUP_AS_INSTANT_KILL(int player, Hash weaponGroup, BOOL toggle) { Function.Call(0x59F0AFF3E0A1B019, player, weaponGroup, toggle); }
		public static void _SET_PLAYER_TRAMPLE_DAMAGE_MODIFIER(int player, float modifier) { Function.Call(0xAF341032E97FB061, player, modifier); }
		public static void _SET_PLAYER_LASSO_DAMAGE_PER_SECOND(int player, float damage) { Function.Call(0x43F50A7CD2482156, player, damage); }
		public static void _SET_PLAYER_TOTAL_ACCURACY_MODIFIER(int player, float accuracy) { Function.Call(0x967FF5BC0CFE6D26, player, accuracy); }
		public static void _SET_PLAYER_LOCAL_ACCURACY_FLOOR_MODIFIER(int player, float accuracy) { Function.Call(0x4EA69188FBCE6A7D, player, accuracy); }
		public static void _SET_PLAYER_REMOTE_ACCURACY_FLOOR_MODIFIER(int player, float accuracy) { Function.Call(0xDEE80FEDFDD43C9B, player, accuracy); }
		public static void _0x3AD212429E095EFB(Any p0, Any p1) { Function.Call(0x3AD212429E095EFB, p0, p1); }
		public static void SET_PLAYER_NOISE_MULTIPLIER(int player, float multiplier) { Function.Call(0xB5EC6BDAEBCA454C, player, multiplier); }
		public static void _0x113EF458AB6CDA67(Any p0, Any p1) { Function.Call(0x113EF458AB6CDA67, p0, p1); }
		public static void SET_PLAYER_SNEAKING_NOISE_MULTIPLIER(int player, float multiplier) { Function.Call(0x4DE44FA389DCA565, player, multiplier); }
		public static void SIMULATE_PLAYER_INPUT_GAIT(int player, float amount, int gaitType, float speed, BOOL p4, BOOL p5) { Function.Call(0xFA0C063C422C4355, player, amount, gaitType, speed, p4, p5); }
		public static void RESET_PLAYER_INPUT_GAIT(int player) { Function.Call(0x61A2EECAB274829B, player); }
		public static void SET_PLAYER_SIMULATE_AIMING(int player, BOOL toggle) { Function.Call(0xE0447DEF81CCDFD2, player, toggle); }
		public static void SET_PLAYER_CLOTH_PIN_FRAMES(int ped, int p1) { Function.Call(0xD0D9317DFEEF9A66, ped, p1); }
		public static BOOL HAS_PLAYER_BEEN_SPOTTED_IN_STOLEN_VEHICLE(int player) { return Function.Call<BOOL>(0xC932F57F31EA9152, player); }
		public static BOOL _0xFB6EB8785F808551(int player, int p1, BOOL p2) { return Function.Call<BOOL>(0xFB6EB8785F808551, player, p1, p2); }
		public static void _SET_MOUNT_PROMPT_DISABLED(BOOL disabled) { Function.Call(0x5B9813ECF7633FE8, disabled); }
		public static BOOL IS_PLAYER_RIDING_TRAIN(int player) { return Function.Call<BOOL>(0x2FB0ACADA6A238DD, player); }
		public static void _0x9AFCF9FE1884BF62(Any p0, Any p1) { Function.Call(0x9AFCF9FE1884BF62, p0, p1); }
		public static Any _0x1E8099F449ABB0BA(Any p0) { return Function.Call<Any>(0x1E8099F449ABB0BA, p0); }
		public static int _GET_DEADEYE_ABILITY_LEVEL(int player) { return Function.Call<int>(0xCCE7C695C164C35F, player); }
		public static void _SET_DEADEYE_ABILITY_LEVEL(int player, int level) { Function.Call(0xF0FE8E790BFEB5BB, player, level); }
		public static BOOL _IS_DEADEYE_ABILITY_LOCKED(int player, int abilityType) { return Function.Call<BOOL>(0x8A0643B0B4CA276B, player, abilityType); }
		public static void _SET_DEADEYE_ABILITY_LOCKED(int player, int abilityType, BOOL toggle) { Function.Call(0x2797B8D66DD0EBB8, player, abilityType, toggle); }
		public static void _SET_DEADEYE_TAGGING_ENABLED(int player, BOOL toggle) { Function.Call(0x6B5DDFB967E5073D, player, toggle); }
		public static BOOL _GET_IS_DEADEYE_TAGGING_ENABLED(int player) { return Function.Call<BOOL>(0x32348719DCED2969, player); }
		public static void _0x3C4AE8506638C7E2(Any p0, Any p1) { Function.Call(0x3C4AE8506638C7E2, p0, p1); }
		public static Any _0x51139D8C17B16FBC(Any p0) { return Function.Call<Any>(0x51139D8C17B16FBC, p0); }
		public static void _0x8F44EBB3BA8F6D44(Any p0, Any p1) { Function.Call(0x8F44EBB3BA8F6D44, p0, p1); }
		public static void _SET_DEADEYE_TAGGING_CONFIG(int player, int filter) { Function.Call(0x83FCD6921FC8FD05, player, filter); }
		public static Any _0xE92261BD28C0878F(Any p0) { return Function.Call<Any>(0xE92261BD28C0878F, p0); }
		public static void _SET_DEADEYE_ABILITY_DEPLETION_DELAY(int player, float delay) { Function.Call(0x870634493CB4372C, player, delay); }
		public static Any _0xA54000D4BFD90BDE(Any p0) { return Function.Call<Any>(0xA54000D4BFD90BDE, p0); }
		public static void _0x6EDB5D08CB03E763(Any p0, Any p1) { Function.Call(0x6EDB5D08CB03E763, p0, p1); }
		public static Any _0x27AD7162D3FED01E(Any p0, Any p1) { return Function.Call<Any>(0x27AD7162D3FED01E, p0, p1); }
		public static int _GET_NUM_MARKED_DEADEYE_TARGETS(int player) { return Function.Call<int>(0xCCD9B77F70D31C9D, player); }
		public static Any _0xC93A9A45430D484E(Any p0) { return Function.Call<Any>(0xC93A9A45430D484E, p0); }
		public static void _0x570A13A4CA2799BB(int player, BOOL p1) { Function.Call(0x570A13A4CA2799BB, player, p1); }
		public static void _0x3ACAC8832E77BC93(int player, BOOL p1) { Function.Call(0x3ACAC8832E77BC93, player, p1); }
		public static void _0x2B12B6FC8B8772AB(int player, int p1) { Function.Call(0x2B12B6FC8B8772AB, player, p1); }
		public static void _0xE910932F4B30BE23(int player) { Function.Call(0xE910932F4B30BE23, player); }
		public static void _0x131E294EF60160DF(int player, float p1, float p2, float p3, float p4, Any p5) { Function.Call(0x131E294EF60160DF, player, p1, p2, p3, p4, p5); }
		public static void _0x0E9057A9DA78D0F8(int player, int bitflag) { Function.Call(0x0E9057A9DA78D0F8, player, bitflag); }
		public static void _0x263D69767F76059C(int player, int p1) { Function.Call(0x263D69767F76059C, player, p1); }
		public static void _REGISTER_EAGLE_EYE_FOR_ENTITY(int player, int entity, BOOL p2) { Function.Call(0x543DFE14BE720027, player, entity, p2); }
		public static void _REGISTER_EAGLE_EYE_TRAILS_FOR_ENTITY(int player, int entity, Any p2) { Function.Call(0xAC67098A1E54ABB0, player, entity, p2); }
		public static void _UNREGISTER_EAGLE_EYE_FOR_ENTITY(int player, int entity) { Function.Call(0x9DAE1380CC5C6451, player, entity); }
		public static void _UNREGISTER_EAGLE_EYE_TRAILS_FOR_ENTITY(int player, int entity, Any p2) { Function.Call(0x9A957912CE2EABD1, player, entity, p2); }
		public static void _0xE5D3EB37ABC1EB03(Any p0) { Function.Call(0xE5D3EB37ABC1EB03, p0); }
		public static BOOL _IS_EAGLE_EYE_REGISTERED_FOR_ENTITY(int player, int entity) { return Function.Call<BOOL>(0x0E6846476906C9DD, player, entity); }
		public static Any _0x6852288340B43239(Any p0, Any p1) { return Function.Call<Any>(0x6852288340B43239, p0, p1); }
		public static Any _0xE50A67C33514A390(Any p0, Any p1) { return Function.Call<Any>(0xE50A67C33514A390, p0, p1); }
		public static void _0xD288E02E364972D2(Any p0, Any p1, Any p2) { Function.Call(0xD288E02E364972D2, p0, p1, p2); }
		public static void _EAGLE_EYE_DISABLE_TRACKING_TRAIL(int entity, string trail, Any p2, Any p3) { Function.Call(0x40AB73092C95B5F5, entity, trail, p2, p3); }
		public static void _0x6ECFC621A168424C(int entity1, int entity2, Any p2, float p3) { Function.Call(0x6ECFC621A168424C, entity1, entity2, p2, p3); }
		public static void _0xDC5E09D012D759C4(int entity1, int entity2, Any p2) { Function.Call(0xDC5E09D012D759C4, entity1, entity2, p2); }
		public static void _0x00B156AFEBCC5AE0(Any p0) { Function.Call(0x00B156AFEBCC5AE0, p0); }
		public static void _0xC58CE6824E604DEC(Any p0) { Function.Call(0xC58CE6824E604DEC, p0); }
		public static void _0x330CA55A3647FA1C(Any p0, Any p1) { Function.Call(0x330CA55A3647FA1C, p0, p1); }
		public static Any _0xA62BBAAE67A05BB0(Any p0) { return Function.Call<Any>(0xA62BBAAE67A05BB0, p0); }
		public static unsafe void _EAGLE_EYE_SET_COLOR(int player, BOOL p1, Any* p2) { Function.Call(0x2C41D93F550D5E37, player, p1, p2); }
		public static void _0x22C8B10802301381(Any p0, Any p1) { Function.Call(0x22C8B10802301381, p0, p1); }
		public static void _EAGLE_EYE_SET_DRAIN_RATE_MODIFIER(int player, float modifier) { Function.Call(0xE0D6C2A146A5C993, player, modifier); }
		public static void _0x06E1FB78B1E59CA5(int ped, BOOL p1) { Function.Call(0x06E1FB78B1E59CA5, ped, p1); }
		public static void _EAGLE_EYE_SET_PLUS_FLAG_DISABLED(int ped, BOOL disabled) { Function.Call(0xCE285A4413B00B7F, ped, disabled); }
		public static Any _0x3813E11A378958A5(Any p0) { return Function.Call<Any>(0x3813E11A378958A5, p0); }
		public static void _EAGLE_EYE_SET_FOCUS_ON_ASSOCIATED_CLUE_TRAIL(int player, int linkedWaypointPed) { Function.Call(0x2AF423D6ECB2C485, player, linkedWaypointPed); }
		public static void _0x0F9CF06986300875(Any p0) { Function.Call(0x0F9CF06986300875, p0); }
		public static void _EAGLE_EYE_SET_TRACKING_UPGRADE(int player, float p1) { Function.Call(0xDFC85C5199045026, player, p1); }
		public static void _EAGLE_EYE_SET_TRACKING_UPGRADE_2(int player, float p1) { Function.Call(0x6FA957D1B55941C1, player, p1); }
		public static Any _0x1DA5C5B0923E1B85(Any p0) { return Function.Call<Any>(0x1DA5C5B0923E1B85, p0); }
		public static Any _0xAAED694CE814817F(Any p0) { return Function.Call<Any>(0xAAED694CE814817F, p0); }
		public static void EAGLE_EYE_SET_CUSTOM_ENTITY_TINT(int entity, int red, int green, int blue) { Function.Call(0x62ED71E133B6C9F1, entity, red, green, blue); }
		public static void _0xBC02B3D151D3859F(int entity, Any p1) { Function.Call(0xBC02B3D151D3859F, entity, p1); }
		public static void _EAGLE_EYE_SET_CUSTOM_DISTANCE(int entity, float distance) { Function.Call(0x907B16B3834C69E2, entity, distance); }
		public static void _0xF21C7A3F3FFBA629(Any p0) { Function.Call(0xF21C7A3F3FFBA629, p0); }
		public static void _SET_PLAYER_MANAGE_BUFF_SUPER_JUMP(int player, float p1) { Function.Call(0x292F0B6EDC82E3A4, player, p1); }
		public static void _SET_LOCAL_PLAYER_PERSONA_ABILITY_FLAG(int flagId, BOOL toggle) { Function.Call(0x7146CF430965927C, flagId, toggle); }
		public static void _SET_PLAYER_MAX_AMMO_OVERRIDE_FOR_AMMO_TYPE(int player, Hash ammoType, int amount) { Function.Call(0xE133C1EC5300F740, player, ammoType, amount); }
		public static void _0xC900A465364A85D6(int player) { Function.Call(0xC900A465364A85D6, player); }
		public static void _0xCFB2EED4FCB7BD77(Any p0, Any p1, Any p2) { Function.Call(0xCFB2EED4FCB7BD77, p0, p1, p2); }
		public static void _0x2BB8D58E88777499(Any p0) { Function.Call(0x2BB8D58E88777499, p0); }
		public static void _0x00EB5A760638DB55(Any p0, Any p1, Any p2) { Function.Call(0x00EB5A760638DB55, p0, p1, p2); }
		public static void _0x65887EAC535A0B0C(Any p0) { Function.Call(0x65887EAC535A0B0C, p0); }
		public static void _SET_WEAPON_DEGRADATION_MODIFIER(int player, float modifier) { Function.Call(0x11A7FF918EF6BC66, player, modifier); }
		public static void _SET_BOW_DRAW_REDUCTION_TIME_IN_DEADEYE(int player, float drawReductionTime) { Function.Call(0xBE0C524970892D41, player, drawReductionTime); }
		public static void _SET_BOW_STAMINA_DRAIN_SPEED(int player, float staminaDrain) { Function.Call(0xFE7C9CF376D23342, player, staminaDrain); }
		public static void _SET_DAMAGE_CLOSE_DISTANCE_BONUS(int player, float closeRangeLowerBound, float closeRangeUpperBound) { Function.Call(0x7761A30432C91297, player, closeRangeLowerBound, closeRangeUpperBound); }
		public static void _SET_DAMAGE_CLOSE_DISTANCE_BONUS_TOTAL(int player, float closeDamageBonus) { Function.Call(0x5006C36652D6EC56, player, closeDamageBonus); }
		public static void _SET_DAMAGE_FAR_DISTANCE_BONUS(int player, float farRangeLowerBound, float farRangeUpperBound) { Function.Call(0xED591CB17C8BA216, player, farRangeLowerBound, farRangeUpperBound); }
		public static void _SET_DAMAGE_FAR_DISTANCE_BONUS_TOTAL(int player, float farDamageBonus) { Function.Call(0x1F0E3A4434565F8F, player, farDamageBonus); }
		public static Any _0x6C54E69516CC56BD(Any p0) { return Function.Call<Any>(0x6C54E69516CC56BD, p0); }
		public static void _0x3A8611BD7BDE84F7(Any p0, Any p1) { Function.Call(0x3A8611BD7BDE84F7, p0, p1); }
		public static void _0xC177C827CEFC0AA4(Any p0, Any p1) { Function.Call(0xC177C827CEFC0AA4, p0, p1); }
		public static void _0xBD96185264DDAAEA(Any p0, Any p1) { Function.Call(0xBD96185264DDAAEA, p0, p1); }
		public static void _0x628E742FE1F79C4A(Any p0, Any p1) { Function.Call(0x628E742FE1F79C4A, p0, p1); }
		public static void _0xC6366A585659D15C(Any p0, Any p1) { Function.Call(0xC6366A585659D15C, p0, p1); }
		public static void _0x98CD760DE43B612E(Any p0, Any p1) { Function.Call(0x98CD760DE43B612E, p0, p1); }
		public static void _0x216BC0D3D2E413D2(int player, Any p1) { Function.Call(0x216BC0D3D2E413D2, player, p1); }
		public static void _0x45EF176B532CA851(Any p0, Any p1) { Function.Call(0x45EF176B532CA851, p0, p1); }
		public static void _0xA342495F93B7B838(Any p0, Any p1) { Function.Call(0xA342495F93B7B838, p0, p1); }
		public static void _0x3BB84F812E052C90(Any p0) { Function.Call(0x3BB84F812E052C90, p0); }
		public static void _0x9FC5A003FB76EDBD(Any p0, Any p1) { Function.Call(0x9FC5A003FB76EDBD, p0, p1); }
		public static void _0x0FAF95D71ED67ADE(int player, string p1) { Function.Call(0x0FAF95D71ED67ADE, player, p1); }
		public static void _0x988C9045531B9FCE(int player, string p1) { Function.Call(0x988C9045531B9FCE, player, p1); }
		public static void _0x06C3DB00B69D5435(int player, string p1) { Function.Call(0x06C3DB00B69D5435, player, p1); }
		public static void _0xBB6EA5D59E926095(int category, Hash emote) { Function.Call(0xBB6EA5D59E926095, category, emote); }
		public static BOOL _0xE1D356F5A66D0FFA(Hash emote) { return Function.Call<BOOL>(0xE1D356F5A66D0FFA, emote); }
		public static void _0x929DDD5538F3DF1F(Any p0, Any p1) { Function.Call(0x929DDD5538F3DF1F, p0, p1); }
		public static void _0xFA7DAAE3959E6C7B(Any p0, Any p1) { Function.Call(0xFA7DAAE3959E6C7B, p0, p1); }
		public static void _0x9461A8FAB0378E5B(Any p0, Any p1) { Function.Call(0x9461A8FAB0378E5B, p0, p1); }
		public static void _0xCB61A63AA53D7D22(Any p0, Any p1) { Function.Call(0xCB61A63AA53D7D22, p0, p1); }
		public static void _0xCFFC3ECCD7A5CCEB(int player, Hash weapon, BOOL p2) { Function.Call(0xCFFC3ECCD7A5CCEB, player, weapon, p2); }
		public static void _0x76F7E1BCD623A429(Any p0) { Function.Call(0x76F7E1BCD623A429, p0); }
		public static void _0x585CE159DB46FADB(Any p0, Any p1) { Function.Call(0x585CE159DB46FADB, p0, p1); }
		public static void _SET_PLAYER_RESET_FLAG(int player, int playerResetFlag, BOOL p2) { Function.Call(0x9F9A829C6751F3C7, player, playerResetFlag, p2); }
		public static Any _0xFE691E89C08937B6(Any p0, Any p1) { return Function.Call<Any>(0xFE691E89C08937B6, p0, p1); }
		public static int GET_MOUNT_OWNED_BY_PLAYER(int player) { return Function.Call<int>(0xF49F14462F0AE27C, player); }
		public static int _GET_PLAYER_OWNER_OF_MOUNT(int mount) { return Function.Call<int>(0xAD03B03737CE6810, mount); }
		public static void _SET_PLAYER_OWNS_MOUNT(int player, int mount) { Function.Call(0xE6D4E435B56D5BD0, player, mount); }
		public static int _GET_VEHICLE_OWNED_BY_PLAYER(int player) { return Function.Call<int>(0xB9050A97594C8832, player); }
		public static int _GET_PLAYER_OWNER_OF_VEHICLE(int vehicle) { return Function.Call<int>(0x7C803BDC8343228D, vehicle); }
		public static void _SET_PLAYER_OWNS_VEHICLE(int player, int vehicle) { Function.Call(0xD0E02AA618020D17, player, vehicle); }
		public static int _GET_PLAYER_HUNTING_WAGON(int player) { return Function.Call<int>(0x5CA6BBD4A7D8145E, player); }
		public static void _SET_PLAYER_HUNTING_WAGON(int player, int wagon) { Function.Call(0x6A4404BDFA62CE2C, player, wagon); }
		public static void _0x9044835BE9D9DBFE(Any p0, Any p1) { Function.Call(0x9044835BE9D9DBFE, p0, p1); }
		public static Any GET_DISCOVERABLE_NAME_HASH_AND_TYPE_FOR_ENTITY(Any p0, Any p1) { return Function.Call<Any>(0x0139637A3BFF8B6D, p0, p1); }
		public static Hash _GET_CONSTRUCTED_DISCOVERED_CHARACTER_NAME(Hash p0, BOOL model, BOOL _outfit) { return Function.Call<Hash>(0x8E84119A23C16623, p0, model, _outfit); }
		public static Hash GET_TARGET_CHARACTER_NAME_SCRIPT_OVERRIDE_HASH(int ped) { return Function.Call<Hash>(0x0335106F3ACABBED, ped); }
		public static string GET_TARGET_CHARACTER_NAME_SCRIPT_OVERRIDE_RAW_STRING(int ped) { return Function.Call<string>(0x755E08680F21EF30, ped); }
		public static Hash GET_TARGET_CHARACTER_NAME_FOR_LOCAL_PLAYER(int ped) { return Function.Call<Hash>(0x36E3D8B5A6552FE8, ped); }
		public static Any _0xDA9D7BE231FE865F(Any p0, Any p1, Any p2) { return Function.Call<Any>(0xDA9D7BE231FE865F, p0, p1, p2); }
		public static void _0x946D46CD6DFB9742(Any p0, Any p1, Any p2) { Function.Call(0x946D46CD6DFB9742, p0, p1, p2); }
		public static Any _0x0772F87D7B07719A(Any p0, Any p1, Any p2) { return Function.Call<Any>(0x0772F87D7B07719A, p0, p1, p2); }
		public static void _0xCDDD4B74660E2335(Any p0, Any p1, Any p2) { Function.Call(0xCDDD4B74660E2335, p0, p1, p2); }
		public static void _0x77E83C315A3B31CA(Any p0) { Function.Call(0x77E83C315A3B31CA, p0); }
		public static void _SET_PLAYER_HAS_DISCOVERED_CHARACTER_NAME_MP(Hash discoveryHash) { Function.Call(0x7C32191D9FB2BDEA, discoveryHash); }
		public static BOOL GET_HAS_PLAYER_DISCOVERED_CHARACTER_NAME_MP(Hash discoveryHash) { return Function.Call<BOOL>(0x354F689C4FFAAB37, discoveryHash); }
		public static void _MODIFY_PLAYER_DISCOVERED_CHARACTER_NAME_MP_SET_UNDISCOVERED(Hash discoveryHash) { Function.Call(0xFB0E622B401884D3, discoveryHash); }
		public static void _0xDC68829BB3F37023(int player, BOOL showingInfoCard) { Function.Call(0xDC68829BB3F37023, player, showingInfoCard); }
		public static void _0x4DBC4873707E8FD6(Any p0, Any p1, Any p2, Any p3) { Function.Call(0x4DBC4873707E8FD6, p0, p1, p2, p3); }
		public static void _0xCEDC16930526F728(Any p0) { Function.Call(0xCEDC16930526F728, p0); }
		public static void _0x14E57F88BA0A07FC(Hash location) { Function.Call(0x14E57F88BA0A07FC, location); }
		public static Any _0x2E1ABE627C95ED9B() { return Function.Call<Any>(0x2E1ABE627C95ED9B); }
		public static void _0x497A18F8F88AA9D8() { Function.Call(0x497A18F8F88AA9D8); }
		public static void _0x4F0D2256AAE94EDA(int p0) { Function.Call(0x4F0D2256AAE94EDA, p0); }
		public static void _SET_LOCKON_FOCUS_FIRE_VFX(int player, string p1) { Function.Call(0x5F8E0303C229C84B, player, p1); }
		public static Any _0x0B7803F6F7BB43E0() { return Function.Call<Any>(0x0B7803F6F7BB43E0); }
		public static Any _0xC74EB3F2EC169F6B(Any p0) { return Function.Call<Any>(0xC74EB3F2EC169F6B, p0); }
		public static void _0x3B296934DB026873(Any p0, Any p1) { Function.Call(0x3B296934DB026873, p0, p1); }
		public static void SET_MIN_TIME_BEFORE_HORSE_BUCKING(int mount, int iMinBuckTime) { Function.Call(0x506CE71FB6E8CF5E, mount, iMinBuckTime); }
		public static Any _0xF4CB347D7B5EB0FD() { return Function.Call<Any>(0xF4CB347D7B5EB0FD); }
		public static void _0xCD7CA3013FD12749(Any p0, Any p1) { Function.Call(0xCD7CA3013FD12749, p0, p1); }
		public static void _FORCE_REST_SCENARIO(BOOL toggle) { Function.Call(0xE5A3DD2FF84E1A4B, toggle); }
		public static BOOL _0x57028FD99886F6F9() { return Function.Call<BOOL>(0x57028FD99886F6F9); }
		public static void _0x35A33783EC3C3448(Any p0) { Function.Call(0x35A33783EC3C3448, p0); }
		public static void _0x39D8D7082BC34B72(Any p0) { Function.Call(0x39D8D7082BC34B72, p0); }
		public static void _0x1AD8AD999C27F44A(Any p0) { Function.Call(0x1AD8AD999C27F44A, p0); }
	}

	public static class POPULATION
	{
		public static int GET_NUM_MODELS_IN_POPULATION_SET(Hash popSetHash) { return Function.Call<int>(0xA1E3171ED0E47564, popSetHash); }
		public static Hash GET_PED_MODEL_NAME_IN_POPULATION_SET(Hash popSetHash, int index) { return Function.Call<Hash>(0x3EAFA1C533B7139E, popSetHash, index); }
		public static Hash GET_RANDOM_MODEL_FROM_POPULATION_SET(Hash popSetHash, int flags, Hash p2, BOOL p3, BOOL p4, float x, float y, float z) { return Function.Call<Hash>(0x6B12ED8C77E8567B, popSetHash, flags, p2, p3, p4, x, y, z); }
		public static PopZone _CREATE_POPZONE_FROM_VOLUME(Volume volume) { return Function.Call<PopZone>(0x9AC1C64FE46B6D09, volume); }
		public static void _DELETE_SCRIPT_POPZONE(PopZone popZone) { Function.Call(0xA6E6A66FC4CA4224, popZone); }
		public static BOOL _IS_POPZONE_VALID(PopZone popZone) { return Function.Call<BOOL>(0xA5BD585005EFCAD4, popZone); }
		public static void SET_POPZONE_POPULATION_SET(PopZone popZone, Hash populationSetHash) { Function.Call(0x3E6A49D9B519E85C, popZone, populationSetHash); }
		public static void _0x7E6BC0B94F5928F0(PopZone popZone, int p1, int p2) { Function.Call(0x7E6BC0B94F5928F0, popZone, p1, p2); }
		public static void _0x578E2FA64E847C60(PopZone popZone, int p1) { Function.Call(0x578E2FA64E847C60, popZone, p1); }
		public static void _0x08892122769770D5(PopZone popZone, BOOL p1) { Function.Call(0x08892122769770D5, popZone, p1); }
		public static void _0x0F1861101C9A9944(PopZone popZone, BOOL p1) { Function.Call(0x0F1861101C9A9944, popZone, p1); }
		public static void SET_SPAWNER_INFO_PRIORITY(Hash p0, Hash p1, int priority) { Function.Call(0x60CDE717A6D47769, p0, p1, priority); }
		public static void CLEAR_SPAWNER_INFO_PRIORITY(Hash p0, Hash p1) { Function.Call(0x217A54DE2D200305, p0, p1); }
		public static void _0x638FCFC6042A9473(Any p0, Any p1) { Function.Call(0x638FCFC6042A9473, p0, p1); }
		public static void _ADD_AMBIENT_AVOIDANCE_RESTRICTION(Volume volume, int includeFlags, int excludeFlags, Hash p3, Hash p4, Hash p5, int p6) { Function.Call(0xB56D41A694E42E86, volume, includeFlags, excludeFlags, p3, p4, p5, p6); }
		public static void _REMOVE_AMBIENT_AVOIDANCE_RESTRICTION(Volume volume) { Function.Call(0x74C2B3DC0B294102, volume); }
		public static void _ADD_AMBIENT_SPAWN_RESTRICTION(Volume volume, int includeFlags, int excludeFlags, Hash p3, Hash p4, Hash p5, int p6) { Function.Call(0x18262CAFEBB5FBE1, volume, includeFlags, excludeFlags, p3, p4, p5, p6); }
		public static void _REMOVE_AMBIENT_SPAWN_RESTRICTION(Volume volume) { Function.Call(0xA1CFB35069D23C23, volume); }
		public static void _0x2161278C6322F740(int includeFlags, int excludeFlags, int p2, Hash p3, int p4, Volume volume) { Function.Call(0x2161278C6322F740, includeFlags, excludeFlags, p2, p3, p4, volume); }
		public static void _0xF45E46DEECF7DF6E(int bitFlag, Any p1, Any p2, Any p3, Any p4) { Function.Call(0xF45E46DEECF7DF6E, bitFlag, p1, p2, p3, p4); }
		public static void _0x8EC7CD701F872F87(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5) { Function.Call(0x8EC7CD701F872F87, p0, p1, p2, p3, p4, p5); }
		public static void _0xC4533E3E87125C9E(Any p0) { Function.Call(0xC4533E3E87125C9E, p0); }
		public static void _SET_PED_SHOULD_IGNORE_AVOIDANCE_VOLUMES(int ped, int p1) { Function.Call(0xF74E134F40192884, ped, p1); }
		public static void _0xDBBF12EA7C1029B2(Any p0, Any p1) { Function.Call(0xDBBF12EA7C1029B2, p0, p1); }
		public static void _0x247F86595D396344(Any p0) { Function.Call(0x247F86595D396344, p0); }
		public static void _0x324AB2A68AD8AEE5() { Function.Call(0x324AB2A68AD8AEE5); }
		public static void DISABLE_AMBIENT_ROAD_POPULATION(BOOL unk) { Function.Call(0xC6DCC2A3A8825C85, unk); }
		public static void ENABLE_AMBIENT_ROAD_POPULATION() { Function.Call(0xBC90BDF4E5228EA1); }
		public static void _0x2660E7720EDC4BD0(Any p0, Any p1, Any p2) { Function.Call(0x2660E7720EDC4BD0, p0, p1, p2); }
		public static Hash _GET_RANDOM_FISH_TYPE_FOR_LOCATION() { return Function.Call<Hash>(0x595478B3BBC3076D); }
		public static void _0xEC116EDB683AD479(BOOL p0) { Function.Call(0xEC116EDB683AD479, p0); }
	}

	public static class POSSE
	{
		public static Any _0xC086FF658B2E51DB() { return Function.Call<Any>(0xC086FF658B2E51DB); }
		public static Any _0xC086FF658B2E51DA(Any p0) { return Function.Call<Any>(0xC086FF658B2E51DA, p0); }
		public static Any _0xC087FF658B2E51DA(Any p0, Any p1) { return Function.Call<Any>(0xC087FF658B2E51DA, p0, p1); }
		public static int POSSE_GET_POSSE_MEMBERSHIP_COUNT() { return Function.Call<int>(0xC088FF658B2E51DA); }
		public static Any _0xC089FF658B2E51DA(Any p0, Any p1) { return Function.Call<Any>(0xC089FF658B2E51DA, p0, p1); }
		public static void _0xC08AFF658B2E51DA(Any p0) { Function.Call(0xC08AFF658B2E51DA, p0); }
		public static Any _0xC08BFF658B2E51DA(Any p0) { return Function.Call<Any>(0xC08BFF658B2E51DA, p0); }
		public static void _0xC08AFF658B2E51DB(Any p0) { Function.Call(0xC08AFF658B2E51DB, p0); }
		public static Any _0xC08CFF658B2E51DA(Any p0, Any p1) { return Function.Call<Any>(0xC08CFF658B2E51DA, p0, p1); }
		public static Any _0xC09CFF658B2E51DA(Any p0, Any p1, Any p2) { return Function.Call<Any>(0xC09CFF658B2E51DA, p0, p1, p2); }
		public static Any _0xC08DEF658B2E51DA(Any p0) { return Function.Call<Any>(0xC08DEF658B2E51DA, p0); }
		public static Any _0xC08DFF658B2E51DA() { return Function.Call<Any>(0xC08DFF658B2E51DA); }
		public static Any _0xC08DFF658B2E51DB(Any p0) { return Function.Call<Any>(0xC08DFF658B2E51DB, p0); }
		public static Any _0xC08EFF658B2E51DB(Any p0, Any p1) { return Function.Call<Any>(0xC08EFF658B2E51DB, p0, p1); }
		public static Any _0xC08FFF658B2E51DA() { return Function.Call<Any>(0xC08FFF658B2E51DA); }
		public static Any _0xC08FFF658B2E51DB(Any p0) { return Function.Call<Any>(0xC08FFF658B2E51DB, p0); }
		public static Any _0xC084FF658B2E61DA(Any p0) { return Function.Call<Any>(0xC084FF658B2E61DA, p0); }
		public static Any _0xC084FF658B2E71DA(Any p0, Any p1, Any p2) { return Function.Call<Any>(0xC084FF658B2E71DA, p0, p1, p2); }
		public static Any _0xC084FF658B2E81DA(Any p0, Any p1, Any p2) { return Function.Call<Any>(0xC084FF658B2E81DA, p0, p1, p2); }
		public static Any _0xC084FF658B2E52DA(Any p0) { return Function.Call<Any>(0xC084FF658B2E52DA, p0); }
		public static Any _0xC084FF658B2E53DA() { return Function.Call<Any>(0xC084FF658B2E53DA); }
		public static Any _0xC084FF658B2E54DA(Any p0) { return Function.Call<Any>(0xC084FF658B2E54DA, p0); }
		public static Any _0xC084FF658B2E55DA(Any p0, Any p1) { return Function.Call<Any>(0xC084FF658B2E55DA, p0, p1); }
		public static void _0xC484FF658B2E55DA(Any p0) { Function.Call(0xC484FF658B2E55DA, p0); }
		public static void _0xC584FF658B2E55DA(Any p0) { Function.Call(0xC584FF658B2E55DA, p0); }
		public static void _0xC684FF658B2E55DA(Any p0) { Function.Call(0xC684FF658B2E55DA, p0); }
		public static Any _0xC184FF658B2E55DA(Any p0, Any p1) { return Function.Call<Any>(0xC184FF658B2E55DA, p0, p1); }
		public static Any _0xC284FF658B2E55DA(Any p0, Any p1, Any p2) { return Function.Call<Any>(0xC284FF658B2E55DA, p0, p1, p2); }
		public static Any _0xC394FF658B2E55DA(Any p0, Any p1, Any p2, Any p3) { return Function.Call<Any>(0xC394FF658B2E55DA, p0, p1, p2, p3); }
		public static Any _0xC07CFF658B2E51DA(Any p0, Any p1) { return Function.Call<Any>(0xC07CFF658B2E51DA, p0, p1); }
		public static Any _0xC06CFF658B2E51DA(Any p0, Any p1, Any p2) { return Function.Call<Any>(0xC06CFF658B2E51DA, p0, p1, p2); }
	}

	public static class PROPSET
	{
		public static BOOL _REQUEST_PROP_SET(Hash hash) { return Function.Call<BOOL>(0xF3DE57A46D5585E9, hash); }
		public static BOOL _REQUEST_PROP_SET_2(Hash hash) { return Function.Call<BOOL>(0xE72F591958F3ACAB, hash); }
		public static BOOL _HAS_PROP_SET_LOADED(Hash hash) { return Function.Call<BOOL>(0x48A88FC684C55FDC, hash); }
		public static BOOL _HAS_PROP_SET_LOADED_2(Hash hash) { return Function.Call<BOOL>(0xD090ABEF4D6A7D96, hash); }
		public static void _SET_PROP_SET_AS_NO_LONGER_NEEDED(PropSet propSet) { Function.Call(0x909E3C7FAE539FB1, propSet); }
		public static void _DELETE_PROP_SET(PropSet propSet, BOOL p1, BOOL p2) { Function.Call(0x58AC173A55D9D7B4, propSet, p1, p2); }
		public static BOOL _RELEASE_PROP_SET(Hash hash) { return Function.Call<BOOL>(0xB1964A83B345B4AB, hash); }
		public static PropSet _CREATE_PROP_SET(Hash hash, float x, float y, float z, int p4, float heading, float p6, BOOL p7, BOOL p8) { return Function.Call<PropSet>(0xE65C5CBA95F0E510, hash, x, y, z, p4, heading, p6, p7, p8); }
		public static PropSet _CREATE_PROP_SET_2(Hash hash, float x, float y, float z, int p4, float p5, float p6, BOOL p7, BOOL p8) { return Function.Call<PropSet>(0x899C97A1CCE7D483, hash, x, y, z, p4, p5, p6, p7, p8); }
		public static PropSet CREATE_PROP_SET_INSTANCE_ATTACHED_TO_ENTITY(Hash hash, float x, float y, float z, int entity, float p5, BOOL p6, int p7, BOOL p8) { return Function.Call<PropSet>(0x9609DBDDE18FAD8C, hash, x, y, z, entity, p5, p6, p7, p8); }
		public static PropSet _CREATE_PROP_SET_4(Hash hash, float x, float y, float z, int entity, float p5, BOOL p6, int p7, BOOL p8) { return Function.Call<PropSet>(0xACA7FB30269096D4, hash, x, y, z, entity, p5, p6, p7, p8); }
		public static BOOL DOES_PROP_SET_EXIST(PropSet propSet) { return Function.Call<BOOL>(0x7DDDCF815E650FF5, propSet); }
		public static BOOL _DOES_PROP_SET_OF_TYPE_EXIST_NEAR_COORDS(Hash propsetHash, float x, float y, float z) { return Function.Call<BOOL>(0x72068021F498E6E3, propsetHash, x, y, z); }
		public static BOOL IS_PROP_SET_FULLY_LOADED(PropSet propSet) { return Function.Call<BOOL>(0xF42DB680A8B2A4D9, propSet); }
		public static void _SET_PROP_SET_VISIBLE(PropSet propSet, BOOL toggle) { Function.Call(0x9D096A5BD02F953E, propSet, toggle); }
		public static BOOL _IS_PROP_SET_VISIBLE(PropSet propSet) { return Function.Call<BOOL>(0x0CE8AAFE9E433A23, propSet); }
		public static Hash _GET_PROP_SET_MODEL(PropSet propSet) { return Function.Call<Hash>(0xA6A9712955F53D9C, propSet); }
		public static Hash _GET_VEHICLE_PROP_SET_HASH(int vehicle) { return Function.Call<Hash>(0x36F69E7A22655653, vehicle); }
		public static int _GET_ENTITIES_FROM_PROP_SET(PropSet propSet, ItemSet itemSet, Hash model, BOOL p3, BOOL p4) { return Function.Call<int>(0x738271B660FE0695, propSet, itemSet, model, p3, p4); }
		public static void _0xC4B67EF3FD65622D(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5) { Function.Call(0xC4B67EF3FD65622D, p0, p1, p2, p3, p4, p5); }
		public static void _0x58E0B01D45CA7357(Any p0) { Function.Call(0x58E0B01D45CA7357, p0); }
		public static void _SET_PROP_SET_FLAG(PropSet propSet, int flag) { Function.Call(0xC1AB7EEFD3E6EE49, propSet, flag); }
		public static PropSet _GET_VEHICLE_PROP_SET(int vehicle) { return Function.Call<PropSet>(0xCE2ACD6F602803E5, vehicle); }
		public static BOOL _DOES_VEHICLE_HAVE_ANY_PROP_SET(int vehicle) { return Function.Call<BOOL>(0x53784CEA0159439B, vehicle); }
		public static void _ADD_PROP_SET_FOR_VEHICLE(int vehicle, Hash propset) { Function.Call(0xD80FAF919A2E56EA, vehicle, propset); }
		public static void _REMOVE_VEHICLE_PROP_SETS(int vehicle) { Function.Call(0x3BCF32FF37EA9F1D, vehicle); }
		public static BOOL _IS_VEHICLE_PROP_SET_LOADED(int vehicle) { return Function.Call<BOOL>(0x155B2FBE72D7D1D0, vehicle); }
		public static void _ADD_ADDITIONAL_PROP_SET_FOR_VEHICLE(int vehicle, Hash propset) { Function.Call(0x75F90E4051CC084C, vehicle, propset); }
		public static BOOL _IS_VEHICLE_PROP_SET_LOADED_ADDITIONAL(int vehicle) { return Function.Call<BOOL>(0x7264F9CA87A9830B, vehicle); }
		public static PropSet _GET_VEHICLE_LIGHT_PROP_SET(int vehicle) { return Function.Call<PropSet>(0xA079300AF757FB1A, vehicle); }
		public static BOOL _DOES_VEHICLE_HAVE_ANY_LIGHT_PROP_SET(int vehicle) { return Function.Call<BOOL>(0xC9B4B3A36F81FD75, vehicle); }
		public static void _ADD_LIGHT_PROP_SET_TO_VEHICLE(int vehicle, Hash lightPropset) { Function.Call(0xC0F0417A90402742, vehicle, lightPropset); }
		public static void _REMOVE_VEHICLE_LIGHT_PROP_SETS(int vehicle) { Function.Call(0xE31C0CB1C3186D40, vehicle); }
		public static BOOL _IS_VEHICLE_LIGHT_PROP_SET_LOADED(int vehicle) { return Function.Call<BOOL>(0x0790473EEE1977D3, vehicle); }
		public static PropSet _GET_TRAIN_CARRIAGE_PROP_SET(int trainCarriage) { return Function.Call<PropSet>(0xCFC0BD09BB1B73FF, trainCarriage); }
		public static BOOL _HAS_VEHICLE_TRAILER_PROP_SET_LOADED(int vehicle, int wagonIndex) { return Function.Call<BOOL>(0x8F3333F0A6900B3C, vehicle, wagonIndex); }
		public static PropSet _GET_PROP_SET_AT_COORDS(Hash propsetHash, float x, float y, float z) { return Function.Call<PropSet>(0xC061E50F8D299F95, propsetHash, x, y, z); }
	}

	public static class QUEUE
	{
		public static BOOL _EVENT_QUEUE_IS_EMPTY(Hash hash) { return Function.Call<BOOL>(0x402B5D7D269FF796, hash); }
		public static void _EVENT_QUEUE_POP(Hash hash) { Function.Call(0xD87DF294B049211D, hash); }
	}

	public static class RECORDING
	{
		public static void _STOP_RECORDING_THIS_FRAME() { Function.Call(0xA8C44C13419634F2); }
	}

	public static class REPLAY
	{
		public static BOOL _IS_INTERIOR_RENDERING_DISABLED() { return Function.Call<BOOL>(0x0F838D47DE58EDB2); }
		public static void _0x57C6525034E76EB0() { Function.Call(0x57C6525034E76EB0); }
		public static BOOL OPEN_VIDEO_EDITOR() { return Function.Call<BOOL>(0xB3F2829907403C13); }
		public static BOOL CLOSE_VIDEO_EDITOR(Any p0) { return Function.Call<BOOL>(0xCEEC64BD27A59312, p0); }
		public static BOOL IS_VIDEO_EDITOR_RUNNING() { return Function.Call<BOOL>(0x9EEB007317FA3B9C); }
	}

	public static class SCRIPTS
	{
		public static unsafe void _SET_PLAYER_BIT_AT_INDEX(Any* value, int bitIndex) { Function.Call(0x31010318BA9897AC, value, bitIndex); }
		public static unsafe void _CLEAR_PLAYER_BIT_AT_INDEX(Any* value, int bitIndex) { Function.Call(0xD426E2E3288469D6, value, bitIndex); }
		public static void _0xE4ABE20DCE7C7CFE(Any p0, Any p1, Any p2) { Function.Call(0xE4ABE20DCE7C7CFE, p0, p1, p2); }
		public static void _0xFFDDF802279BE128(Any p0, Any p1, Any p2) { Function.Call(0xFFDDF802279BE128, p0, p1, p2); }
		public static void _0x64F765D9A1F8F02C(Any p0, Any p1, Any p2) { Function.Call(0x64F765D9A1F8F02C, p0, p1, p2); }
		public static unsafe void _SET_ALL_PLAYER_BITS(Any* value) { Function.Call(0x20F4CB76689ACDBC, value); }
		public static unsafe void _CLEAR_ALL_PLAYER_BITS(Any* value) { Function.Call(0xDE544B7EC0C187CC, value); }
		public static Any _0x72B2E00C9BAC6789(Any p0, Any p1) { return Function.Call<Any>(0x72B2E00C9BAC6789, p0, p1); }
		public static unsafe BOOL _IS_ANY_PLAYER_BIT_SET(int* playerBits) { return Function.Call<BOOL>(0x179A6F0EE2E79026, playerBits); }
		public static unsafe int GET_BLOCK_OF_PLAYER_BITS(Any* value, int p1) { return Function.Call<int>(0xFA3B530A5CC693D5, value, p1); }
		public static unsafe void SET_BLOCK_OF_PLAYER_BITS(Any* value, int p1, int p2) { Function.Call(0xC6DFB8C04C86D5A5, value, p1, p2); }
		public static unsafe int COUNT_PLAYER_BITS(Any* value) { return Function.Call<int>(0x462C687BEA254BD9, value); }
		public static void _0x1BDB5A07307F6929(Any p0, Any p1) { Function.Call(0x1BDB5A07307F6929, p0, p1); }
		public static void _0x1C5EB3C27F7508CB(Any p0, Any p1) { Function.Call(0x1C5EB3C27F7508CB, p0, p1); }
		public static void _0x42A429CDFED6D99D(Any p0, Any p1, Any p2) { Function.Call(0x42A429CDFED6D99D, p0, p1, p2); }
		public static void _0x5827BE85A87B073D(Any p0) { Function.Call(0x5827BE85A87B073D, p0); }
		public static Any _0x0A79C81C418F5D38(Any p0, Any p1) { return Function.Call<Any>(0x0A79C81C418F5D38, p0, p1); }
		public static Any _0xA88E1D7FA1E20080(Any p0) { return Function.Call<Any>(0xA88E1D7FA1E20080, p0); }
		public static unsafe int COUNT_PARTICIPANT_BITS(Any* value) { return Function.Call<int>(0x2F050A3FF8738245, value); }
		public static void REQUEST_SCRIPT(string scriptName) { Function.Call(0x46ED607DDD40D7FE, scriptName); }
		public static void SET_SCRIPT_AS_NO_LONGER_NEEDED(string scriptName) { Function.Call(0x0086D3067E1CFD1C, scriptName); }
		public static BOOL HAS_SCRIPT_LOADED(string scriptName) { return Function.Call<BOOL>(0xE97BD36574F8B0A6, scriptName); }
		public static BOOL DOES_SCRIPT_EXIST(string scriptName) { return Function.Call<BOOL>(0x552B171E3F69E5AE, scriptName); }
		public static void REQUEST_SCRIPT_WITH_NAME_HASH(Hash scriptHash) { Function.Call(0xF6B9CE3F8D5B9B74, scriptHash); }
		public static void SET_SCRIPT_WITH_NAME_HASH_AS_NO_LONGER_NEEDED(Hash scriptHash) { Function.Call(0x50723A1567C8361E, scriptHash); }
		public static BOOL HAS_SCRIPT_WITH_NAME_HASH_LOADED(Hash scriptHash) { return Function.Call<BOOL>(0xA5D8E0C2F3C7EEBC, scriptHash); }
		public static BOOL DOES_SCRIPT_WITH_NAME_HASH_EXIST(Hash scriptHash) { return Function.Call<BOOL>(0xA34E89749F628284, scriptHash); }
		public static void TERMINATE_THREAD(int threadId) { Function.Call(0x87ED52AE40EA1A52, threadId); }
		public static BOOL IS_THREAD_ACTIVE(int threadId, BOOL ignoreKilledState) { return Function.Call<BOOL>(0x46E9AE36D8FA6417, threadId, ignoreKilledState); }
		public static BOOL DOES_THREAD_EXIST(int threadId) { return Function.Call<BOOL>(0xFF975BC4435A0FA3, threadId); }
		public static unsafe void GET_THREAD_EXISTENCE_DETAILS(int threadId, BOOL* threadExists, BOOL* hasScriptHandler) { Function.Call(0xD92FA81B64920E85, threadId, threadExists, hasScriptHandler); }
		public static Hash _GET_HASH_OF_THREAD(int threadId) { return Function.Call<Hash>(0x724CB89D35B283D0, threadId); }
		public static void SCRIPT_THREAD_ITERATOR_RESET() { Function.Call(0x39382EB8DCD8684D); }
		public static int SCRIPT_THREAD_ITERATOR_GET_NEXT_THREAD_ID() { return Function.Call<int>(0x3CE3FB167E837D7C); }
		public static BOOL _IS_BACKGROUND_SCRIPT(int threadId) { return Function.Call<BOOL>(0x20B7F69B40C6B755, threadId); }
		public static int GET_ID_OF_THIS_THREAD() { return Function.Call<int>(0x55525C346BEF6960); }
		public static void TERMINATE_THIS_THREAD() { Function.Call(0x5E8B6D17FF91CD59); }
		public static int _GET_NUMBER_OF_REFERENCES_OF_SCRIPT_WITH_NAME_HASH(Hash scriptHash) { return Function.Call<int>(0x8E34C953364A76DD, scriptHash); }
		public static void _REQUEST_THREAD_EXIT(int threadId) { Function.Call(0x7DE4643157AD646C, threadId); }
		public static void _REQUEST_THREAD_EXIT_FOR_ALL_THREADS_WITH_THIS_NAME(Hash nameHash) { Function.Call(0x7423F7835770F619, nameHash); }
		public static BOOL IS_THREAD_EXIT_REQUESTED() { return Function.Call<BOOL>(0x9E4EF615E307FBBE); }
		public static BOOL _IS_THREAD_EXIT_REQUESTED_FOR_THREAD_WITH_THIS_ID(int threadId) { return Function.Call<BOOL>(0x30BED53646C86D11, threadId); }
		public static int _GET_THREAD_EXIT_REASON() { return Function.Call<int>(0x54AE4FDEEFEAB77E); }
		public static Hash GET_HASH_OF_THIS_SCRIPT_NAME() { return Function.Call<Hash>(0xBC2C927F5C264960); }
		public static int GET_NUMBER_OF_EVENTS(int _eventGroup) { return Function.Call<int>(0x5CE8DE5909565748, _eventGroup); }
		public static BOOL GET_EVENT_EXISTS(int _eventGroup, int _eventIndex) { return Function.Call<BOOL>(0xC9F59C0A710ECD34, _eventGroup, _eventIndex); }
		public static Hash GET_EVENT_AT_INDEX(int _eventGroup, int _eventIndex) { return Function.Call<Hash>(0xA85E614430EFF816, _eventGroup, _eventIndex); }
		public static unsafe BOOL GET_EVENT_DATA(int _eventGroup, int _eventIndex, Any* _eventData, int _eventDataSize) { return Function.Call<BOOL>(0x57EC5FA4D4D6AFCA, _eventGroup, _eventIndex, _eventData, _eventDataSize); }
		public static void SET_EVENT_FLAG_FOR_DELETION(int _eventGroup, int _eventIndex, BOOL p2) { Function.Call(0x4768D5252EAEB76F, _eventGroup, _eventIndex, p2); }
		public static unsafe void TRIGGER_SCRIPT_EVENT(int _eventGroup, Any* _eventData, int _eventDataSize, int scriptMetadataIndex, int* playerBits) { Function.Call(0x5AE99C571D5BBE5D, _eventGroup, _eventData, _eventDataSize, scriptMetadataIndex, playerBits); }
		public static unsafe void _TRIGGER_SCRIPT_EVENT_2(Any* _eventData, int _eventDataSize, int scriptMetadataIndex, int threadId) { Function.Call(0x8B61C950A148FFA2, _eventData, _eventDataSize, scriptMetadataIndex, threadId); }
		public static Any _0xE7282390542F570D(Any p0) { return Function.Call<Any>(0xE7282390542F570D, p0); }
		public static void _0x11B0A0B282FA9B10(BOOL p0) { Function.Call(0x11B0A0B282FA9B10, p0); }
		public static void _0x6F700A4BF7C3331B(BOOL p0) { Function.Call(0x6F700A4BF7C3331B, p0); }
		public static void _0xF9E951A1E5517C06() { Function.Call(0xF9E951A1E5517C06); }
		public static void _0x76CBCD9EADC00955() { Function.Call(0x76CBCD9EADC00955); }
		public static void SHUTDOWN_LOADING_SCREEN() { Function.Call(0xFC179D7E8886DADF); }
		public static void SET_NO_LOADING_SCREEN(BOOL toggle) { Function.Call(0x5CB83156AA038F95, toggle); }
		public static BOOL GET_NO_LOADING_SCREEN() { return Function.Call<BOOL>(0x323DAF00687E0F28); }
		public static void _DISPLAY_LOADING_SCREENS(Hash p0, Hash p1, Hash p2, string gamemodeName, string title, string subtitle) { Function.Call(0x1E5B70E53DB661E5, p0, p1, p2, gamemodeName, title, subtitle); }
		public static void _0x29FB4CE89472C3CB(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7) { Function.Call(0x29FB4CE89472C3CB, p0, p1, p2, p3, p4, p5, p6, p7); }
		public static void STOP_DISPLAYING_MP_TRANSITION_LOADING_SCREENS(Any p0) { Function.Call(0x778D4733E0F2F265, p0); }
		public static BOOL IS_LOADING_SCREEN_VISIBLE() { return Function.Call<BOOL>(0xB54ADBE65D528FCB); }
		public static void BAIL_TO_LANDING_PAGE(int bailCode) { Function.Call(0xBC2C927F5C264243, bailCode); }
		public static void BAIL_WITH_PASS_THROUGH_PARAMS(string _params) { Function.Call(0xE98204D3C25AE14C, _params); }
		public static BOOL _BG_EXITED_BECAUSE_BACKGROUND_THREAD_STOPPED() { return Function.Call<BOOL>(0x2238EC3EC631AB1F); }
		public static void _0x4858148E3B8A75D0() { Function.Call(0x4858148E3B8A75D0); }
		public static void BG_START_CONTEXT_HASH(Hash contextHash) { Function.Call(0x2EB67D564DCC09D5, contextHash); }
		public static void BG_END_CONTEXT_HASH(Hash contextHash) { Function.Call(0x6D1431744182CDE8, contextHash); }
		public static void BG_START_CONTEXT(string contextName) { Function.Call(0x49BA5678BA040CA7, contextName); }
		public static void BG_END_CONTEXT(string contextName) { Function.Call(0x3ABF7BA1C3E2C8CF, contextName); }
		public static BOOL _0x4AE1DFF337A86FDE(int scriptIndex, string p1) { return Function.Call<BOOL>(0x4AE1DFF337A86FDE, scriptIndex, p1); }
		public static int _0x55C40B7592BAD213(int scriptIndex, string p1) { return Function.Call<int>(0x55C40B7592BAD213, scriptIndex, p1); }
		public static int _0x829CD22E043A2577(Hash p0) { return Function.Call<int>(0x829CD22E043A2577, p0); }
		public static void _BG_RELOAD_ALL_BACKGROUND_SCRIPTS() { Function.Call(0xBE7D814CFA181B56); }
		public static void _ACTIVATE_GOAL_CONTEXT(Hash goalContext) { Function.Call(0x7D654266025E921B, goalContext); }
		public static void _DEACTIVATE_GOAL_CONTEXT(Hash goalContext) { Function.Call(0x50B72A754EE64A71, goalContext); }
		public static BOOL _IS_GOAL_CONTEXT_ACTIVE(Hash goalContext) { return Function.Call<BOOL>(0x7409669C5ED50144, goalContext); }
		public static unsafe string _NET_RPC_GUID_TO_STRING(Any* netRpcGuid) { return Function.Call<string>(0xAC9FF854BD4BA9B5, netRpcGuid); }
		public static unsafe BOOL AWARDS_GET_RESULT_ITEM(Any* rpcGuid, Hash awardHash, int itemIndex, Any* _outResultItem) { return Function.Call<BOOL>(0xAC8FAB22A914AE34, rpcGuid, awardHash, itemIndex, _outResultItem); }
		public static unsafe BOOL _AWARDS_GET_UNLOCK_CLAIM_DATA(Any* rpcGuid, Hash awardHash, int dataIndex, Any* _outUnlockData) { return Function.Call<BOOL>(0xB9467E41DAB1CF2C, rpcGuid, awardHash, dataIndex, _outUnlockData); }
		public static unsafe BOOL _LOOT_GET_RESULT_ITEM(Any* rpcGuid, int itemIndex, Any* _outResultItem) { return Function.Call<BOOL>(0x4293B44A855F82CC, rpcGuid, itemIndex, _outResultItem); }
		public static unsafe BOOL _LOOT_GET_LOOT_CLAIM_DATA(Any* rpcGuid, int dataIndex, Any* _outLootData) { return Function.Call<BOOL>(0xF1E9045F5AA9E428, rpcGuid, dataIndex, _outLootData); }
		public static BOOL _STORE_GLOBAL_BLOCK(int index) { return Function.Call<BOOL>(0xB952A3AC41D58F2F, index); }
		public static BOOL _RESTORE_GLOBAL_BLOCK(int index) { return Function.Call<BOOL>(0xDC3914A99B4A5FDF, index); }
		public static BOOL _DOES_COMPRESSED_GLOBAL_BLOCK_BUFFER_EXIST(int index) { return Function.Call<BOOL>(0x66EE5B93C308F734, index); }
		public static void _SET_GLOBAL_BLOCK_CAN_BE_ACCESSED(int index, BOOL toggle) { Function.Call(0xE66F392BFCE734AF, index, toggle); }
		public static BOOL _GET_GLOBAL_BLOCK_CAN_BE_ACCESSED(int index) { return Function.Call<BOOL>(0x42A7EB5C814C2DE0, index); }
		public static void _SET_ALL_GLOBAL_BLOCKS_HAVE_BEEN_LOADED(BOOL toggle) { Function.Call(0x11986B05885564D2, toggle); }
		public static BOOL HAVE_ALL_CHILD_SCRIPTS_TERMINATED(int p0) { return Function.Call<BOOL>(0x380FFA15B72408FB, p0); }
		public static int START_NEW_SCRIPT(string scriptName, int stackSize) { return Function.Call<int>(0xE81651AD79516E48, scriptName, stackSize); }
		public static unsafe int START_NEW_SCRIPT_WITH_ARGS(string scriptName, Any* args, int argCount, int stackSize) { return Function.Call<int>(0xB8BA7F44DF1575E1, scriptName, args, argCount, stackSize); }
		public static int START_NEW_SCRIPT_WITH_NAME_HASH(Hash scriptHash, int stackSize) { return Function.Call<int>(0xEB1C67C3A5333A92, scriptHash, stackSize); }
		public static unsafe int START_NEW_SCRIPT_WITH_NAME_HASH_AND_ARGS(Hash scriptHash, Any* args, int argCount, int stackSize) { return Function.Call<int>(0xC4BB298BD441BE78, scriptHash, args, argCount, stackSize); }
	}

	public static class SAVE
	{
		public static void _0x4FB5869E2B37FC00() { Function.Call(0x4FB5869E2B37FC00); }
		public static BOOL SAVEGAME_SAVE_SP(Hash savegameType) { return Function.Call<BOOL>(0x62C9EB51656D68CE, savegameType); }
		public static BOOL SAVEGAME_SAVE_MP(Hash savegameType) { return Function.Call<BOOL>(0x1840F3B30ED0105F, savegameType); }
		public static BOOL SAVEGAME_IS_SAVE_PENDING() { return Function.Call<BOOL>(0x3CF46F55C6585590); }
		public static Any _0x1431540BCA1A1BD2() { return Function.Call<Any>(0x1431540BCA1A1BD2); }
		public static Any _0xA7ECEBAFBAF997A5(Hash savegameType) { return Function.Call<Any>(0xA7ECEBAFBAF997A5, savegameType); }
		public static void _0xED4B0C1057892B2E(Any p0, Any p1, Any p2, Any p3) { Function.Call(0xED4B0C1057892B2E, p0, p1, p2, p3); }
		public static void _0x9BB83C4DD7BE0802(Any p0, Any p1, Any p2, Any p3, Any p4) { Function.Call(0x9BB83C4DD7BE0802, p0, p1, p2, p3, p4); }
		public static void _0xE8346E62FD7FB962() { Function.Call(0xE8346E62FD7FB962); }
		public static void _0xC0ABF784590798A9(Any p0) { Function.Call(0xC0ABF784590798A9, p0); }
		public static Any _0xB00CE33465B5406D(Any p0, Any p1) { return Function.Call<Any>(0xB00CE33465B5406D, p0, p1); }
		public static void _0x529B9CCD0972AF4D(Any p0, Any p1) { Function.Call(0x529B9CCD0972AF4D, p0, p1); }
		public static void _0x529B9CCD0972AF4E(Any p0, Any p1) { Function.Call(0x529B9CCD0972AF4E, p0, p1); }
		public static void _0xB25B5A375BE5BE26(Any p0, Any p1) { Function.Call(0xB25B5A375BE5BE26, p0, p1); }
		public static void _0x35DEFECAE36D4FAE(Any p0, Any p1) { Function.Call(0x35DEFECAE36D4FAE, p0, p1); }
		public static void _0xBB7F4273C186BC4B(Any p0, Any p1) { Function.Call(0xBB7F4273C186BC4B, p0, p1); }
		public static void _0x5A10D6506B2F2C63(Any p0, Any p1) { Function.Call(0x5A10D6506B2F2C63, p0, p1); }
		public static void _0x4845E7E7643A908C(Any p0, Any p1) { Function.Call(0x4845E7E7643A908C, p0, p1); }
		public static void _0x186608A2AC6F9E88(Any p0, Any p1) { Function.Call(0x186608A2AC6F9E88, p0, p1); }
		public static void _0x443174C20B8B9E7F(Any p0, Any p1, Any p2) { Function.Call(0x443174C20B8B9E7F, p0, p1, p2); }
		public static void _0x8E8FFB9E4AD051D2(Any p0, Any p1, Any p2, Any p3) { Function.Call(0x8E8FFB9E4AD051D2, p0, p1, p2, p3); }
		public static void _0xE0B45E983BFC0768() { Function.Call(0xE0B45E983BFC0768); }
		public static void _0x81F4E92BE3958364(Any p0, Any p1, Any p2) { Function.Call(0x81F4E92BE3958364, p0, p1, p2); }
		public static void _0xA844FEB5C22C2C74() { Function.Call(0xA844FEB5C22C2C74); }
	}

	public static class SHAPETEST
	{
		public static ScrHandle START_SHAPE_TEST_LOS_PROBE(float x1, float y1, float z1, float x2, float y2, float z2, int flags, int entity, int p8) { return Function.Call<ScrHandle>(0x7EE9F5D83DD4F90E, x1, y1, z1, x2, y2, z2, flags, entity, p8); }
		public static Any _0x04AA59CA40571C2E(Any p0, Any p1) { return Function.Call<Any>(0x04AA59CA40571C2E, p0, p1); }
		public static ScrHandle START_EXPENSIVE_SYNCHRONOUS_SHAPE_TEST_LOS_PROBE(float x1, float y1, float z1, float x2, float y2, float z2, int flags, int entityToIgnore, int p8) { return Function.Call<ScrHandle>(0x377906D8A31E5586, x1, y1, z1, x2, y2, z2, flags, entityToIgnore, p8); }
		public static ScrHandle START_SHAPE_TEST_BOX(float x, float y, float z, float x1, float y2, float z2, float rotX, float rotY, float rotZ, Any p9, Any p10, Any entity, Any p12) { return Function.Call<ScrHandle>(0xFE466162C4401D18, x, y, z, x1, y2, z2, rotX, rotY, rotZ, p9, p10, entity, p12); }
		public static ScrHandle START_SHAPE_TEST_CAPSULE(float x1, float y1, float z1, float x2, float y2, float z2, float radius, int flags, int entityToIgnore, int p9) { return Function.Call<ScrHandle>(0x28579D1B8F8AAC80, x1, y1, z1, x2, y2, z2, radius, flags, entityToIgnore, p9); }
		public static ScrHandle START_SHAPE_TEST_SWEPT_SPHERE(float x1, float y1, float z1, float x2, float y2, float z2, float radius, int flags, int entity, Any p9) { return Function.Call<ScrHandle>(0xAA5B7C8309F73230, x1, y1, z1, x2, y2, z2, radius, flags, entity, p9); }
		public static unsafe ScrHandle _START_SHAPE_TEST_SURROUNDING_COORDS(Vector3* pVec1, Vector3* pVec2, int flag, int entity, int flag2) { return Function.Call<ScrHandle>(0x9839013D8B6014F1, pVec1, pVec2, flag, entity, flag2); }
		public static unsafe int GET_SHAPE_TEST_RESULT(ScrHandle shapeTestHandle, BOOL* hit, Vector3* endCoords, Vector3* surfaceNormal, int* entityHit) { return Function.Call<int>(0xEDE8AC7C5108FB1D, shapeTestHandle, hit, endCoords, surfaceNormal, entityHit); }
	}

	public static class SOCIALCLUB
	{
		public static int SC_INBOX_GET_TOTAL_NUM_MESSAGES() { return Function.Call<int>(0x8EF0F633280C0663); }
		public static Hash SC_INBOX_GET_MESSAGE_TYPE_AT_INDEX(int msgIndex) { return Function.Call<Hash>(0xFF92537C4DDC1241, msgIndex); }
		public static BOOL SC_INBOX_GET_MESSAGE_IS_READ_AT_INDEX(int msgIndex) { return Function.Call<BOOL>(0x74CF39E030A382C4, msgIndex); }
		public static BOOL SC_INBOX_SET_MESSAGE_AS_READ_AT_INDEX(int msgIndex) { return Function.Call<BOOL>(0x63CAC501FFF66DC4, msgIndex); }
		public static unsafe BOOL SC_INBOX_MESSAGE_GET_DATA_INT(int p0, string context, int* _out) { return Function.Call<BOOL>(0x95BB39C4DA99F348, p0, context, _out); }
		public static BOOL SC_INBOX_MESSAGE_GET_DATA_STRING(int p0, string context, string _out) { return Function.Call<BOOL>(0x66F77FD58506FF6B, p0, context, _out); }
		public static string SC_INBOX_MESSAGE_GET_RAW_TYPE_AT_INDEX(int p0) { return Function.Call<string>(0x176D077685CD83E4, p0); }
		public static BOOL SC_PRESENCE_ATTR_SET_FLOAT(Hash attrHash, float value) { return Function.Call<BOOL>(0xA31DAFCDC33775E9, attrHash, value); }
		public static BOOL SC_PRESENCE_ATTR_SET_INT_EX(string attrName, int value, BOOL p2) { return Function.Call<BOOL>(0x0000000085488C49, attrName, value, p2); }
		public static BOOL SC_PRESENCE_ATTR_SET_FLOAT_EX(string attrName, float value, BOOL p2) { return Function.Call<BOOL>(0x00000000467F4CAA, attrName, value, p2); }
		public static BOOL SC_PRESENCE_ATTR_SET_STRING_EX(string attrName, string value, BOOL p2) { return Function.Call<BOOL>(0x00000000EB2D93B3, attrName, value, p2); }
		public static unsafe BOOL SC_PROFANITY_CHECK_STRING(string _string, int* token) { return Function.Call<BOOL>(0x9C74AC9D87B3FFF4, _string, token); }
		public static BOOL SC_PROFANITY_GET_CHECK_IS_VALID(int token) { return Function.Call<BOOL>(0x08C8052AF40C4247, token); }
		public static BOOL SC_PROFANITY_GET_CHECK_IS_PENDING(int token) { return Function.Call<BOOL>(0x3A10BCD0C8AA0B82, token); }
		public static BOOL SC_PROFANITY_GET_STRING_PASSED(int token) { return Function.Call<BOOL>(0xF302973BB8BE70E6, token); }
		public static int SC_PROFANITY_GET_STRING_STATUS(int token) { return Function.Call<int>(0x0CF3BFB99EBBE5B1, token); }
		public static BOOL _0xCBF743C984695CF3() { return Function.Call<BOOL>(0xCBF743C984695CF3); }
		public static int _0xD635DF6BAA5A6017() { return Function.Call<int>(0xD635DF6BAA5A6017); }
		public static unsafe BOOL _0xB4411D4D6B81438E(string p0, int* p1) { return Function.Call<BOOL>(0xB4411D4D6B81438E, p0, p1); }
		public static unsafe BOOL _0x060BBAD634C2B44B(string p0, float* p1) { return Function.Call<BOOL>(0x060BBAD634C2B44B, p0, p1); }
		public static BOOL _0x9F6DCD0C939C71E9(string p0, string p1) { return Function.Call<BOOL>(0x9F6DCD0C939C71E9, p0, p1); }
		public static BOOL _0x89D9BDE7334B110F(string p0) { return Function.Call<BOOL>(0x89D9BDE7334B110F, p0); }
		public static BOOL _0x09937EB0CEBC2F9F(string p0) { return Function.Call<BOOL>(0x09937EB0CEBC2F9F, p0); }
		public static int _0x03C03ABBABBEF752(string p0) { return Function.Call<int>(0x03C03ABBABBEF752, p0); }
		public static unsafe BOOL _0x3519CC3525319A96(string p0, int* p1, string p2) { return Function.Call<BOOL>(0x3519CC3525319A96, p0, p1, p2); }
		public static unsafe BOOL _0x1BDB56DB258F052D(string p0, float* p1, string p2) { return Function.Call<BOOL>(0x1BDB56DB258F052D, p0, p1, p2); }
		public static BOOL _0xC8FC3B2432E8229D(string p0, string p1, string p2) { return Function.Call<BOOL>(0xC8FC3B2432E8229D, p0, p1, p2); }
		public static BOOL _0x85EA0BEC7B1F7622(string p0, string p1) { return Function.Call<BOOL>(0x85EA0BEC7B1F7622, p0, p1); }
		public static BOOL _0x62B384FEFDE06817(int p0) { return Function.Call<BOOL>(0x62B384FEFDE06817, p0); }
		public static unsafe BOOL _0x7C981DE05A7403A0(int p0, string p1, int* p2) { return Function.Call<BOOL>(0x7C981DE05A7403A0, p0, p1, p2); }
		public static unsafe BOOL _0x91C9E2A0F9DD6DD4(int p0, string p1, float* p2) { return Function.Call<BOOL>(0x91C9E2A0F9DD6DD4, p0, p1, p2); }
		public static BOOL _0x049D2196D9D11184(int p0, string p1, string p2) { return Function.Call<BOOL>(0x049D2196D9D11184, p0, p1, p2); }
		public static BOOL _0x11EA52CAD1B55910(int p0, string p1) { return Function.Call<BOOL>(0x11EA52CAD1B55910, p0, p1); }
	}

	public static class SOCIALCLUBFEED
	{
		public static int _SC_FEED_SUBMIT_PRESET_MESSAGE(int type, int subType) { return Function.Call<int>(0xEFB64240F6B17817, type, subType); }
		public static BOOL SC_FEED_HUB_HAS_NEW_DATA() { return Function.Call<BOOL>(0x068332D20CB6F897); }
	}

	public static class SPACTIONPROXY
	{
		public static BOOL _SPACTIONPROXY_START_MANAGER() { return Function.Call<BOOL>(0x1F471B79ACC91BEE); }
		public static BOOL _SPACTIONPROXY_MANAGER_IS_READY() { return Function.Call<BOOL>(0x1F471B79ACC91BED); }
		public static BOOL _SPACTIONPROXY_MANAGER_IS_FAILED() { return Function.Call<BOOL>(0x1F471B79ACC91BEC); }
		public static unsafe BOOL _SPACTIONPROXY_GET_NEXT_PENDING_CRAFTING_ACTION(Any* data) { return Function.Call<BOOL>(0x1F471B79ACC97BEF, data); }
		public static unsafe BOOL _SPACTIONPROXY_GET_NEXT_PENDING_BUY_ACTION(Any* data) { return Function.Call<BOOL>(0x1F471B79ACC98BEF, data); }
		public static BOOL _SPACTIONPROXY_PROCESS_ACTION(Any p0, BOOL p1) { return Function.Call<BOOL>(0x1F471B79ACC94BEF, p0, p1); }
	}

	public static class STATS
	{
		public static unsafe BOOL STAT_ID_IS_VALID(Any* statId) { return Function.Call<BOOL>(0xC48FE1971C9743FF, statId); }
		public static unsafe BOOL STAT_ID_SET_INT(Any* statId, int value, BOOL p2) { return Function.Call<BOOL>(0xA4DDF5DF95E65EEE, statId, value, p2); }
		public static unsafe BOOL STAT_ID_SET_FLOAT(Any* statId, float value, BOOL p2) { return Function.Call<BOOL>(0x481BDF6A10C5EF68, statId, value, p2); }
		public static unsafe BOOL STAT_ID_SET_BOOL(Any* statId, BOOL value, BOOL p2) { return Function.Call<BOOL>(0x3B5107353267D7A1, statId, value, p2); }
		public static unsafe BOOL STAT_ID_SET_GXT_LABEL(Any* statId, string label, BOOL p2) { return Function.Call<BOOL>(0x05060A54834F2382, statId, label, p2); }
		public static unsafe BOOL STAT_ID_SET_DATE(Any* statId, Any* date, BOOL p2) { return Function.Call<BOOL>(0x1FAE9B2FAA2DFE06, statId, date, p2); }
		public static unsafe BOOL STAT_ID_GET_INT(Any* statId, int* p1) { return Function.Call<BOOL>(0x767FBC2AC802EF3E, statId, p1); }
		public static unsafe BOOL STAT_ID_GET_FLOAT(Any* statId, float* value) { return Function.Call<BOOL>(0xD7AE6C9C9C6AC54D, statId, value); }
		public static unsafe BOOL STAT_ID_GET_BOOL(Any* statId, BOOL* value) { return Function.Call<BOOL>(0x11B5E6D2AE73F48F, statId, value); }
		public static unsafe BOOL STAT_ID_GET_DATE(Any* statId, Any* date) { return Function.Call<BOOL>(0x8B0FACEFC36C824C, statId, date); }
		public static unsafe void _0x0FEE2561120F3333(Any* statId) { Function.Call(0x0FEE2561120F3333, statId); }
		public static unsafe void _STAT_ID_INCREMENT_INT(Any* statId, int value) { Function.Call(0x6A0184E904CDF25E, statId, value); }
		public static unsafe void _STAT_ID_INCREMENT_FLOAT(Any* statId, float value) { Function.Call(0x4A47E38EA3D60939, statId, value); }
		public static unsafe void _0xBD861AE8A5181ED7(Any* statId, Any p1) { Function.Call(0xBD861AE8A5181ED7, statId, p1); }
		public static unsafe void _0x91A4F58E01ED5E4C(Any* p0, Any p1) { Function.Call(0x91A4F58E01ED5E4C, p0, p1); }
		public static void _0xE141F6B40B1E3683(Any p0, Any p1) { Function.Call(0xE141F6B40B1E3683, p0, p1); }
		public static unsafe void STAT_ID_SET_TO_POSSE_ID(Any* statId) { Function.Call(0x34B22DE38477EDB4, statId); }
		public static Any _0x1E7384AB5D4F4581(Any p0) { return Function.Call<Any>(0x1E7384AB5D4F4581, p0); }
		public static unsafe Any _0x5420D398A42917FC(Any* p0, Any p1) { return Function.Call<Any>(0x5420D398A42917FC, p0, p1); }
		public static void _STAT_ITEM_FISH_CAUGHT(int fish, float weight, Hash category, Hash subcategory) { Function.Call(0xDA26263C87CCE9C1, fish, weight, category, subcategory); }
		public static void _0x831BF01C56149A8A(Any p0) { Function.Call(0x831BF01C56149A8A, p0); }
		public static void _0x7C2ABF6E556B21FC(Any p0, Any p1, Any p2, Any p3) { Function.Call(0x7C2ABF6E556B21FC, p0, p1, p2, p3); }
		public static void _0x8312F09C56149A8A(Any p0) { Function.Call(0x8312F09C56149A8A, p0); }
		public static void _0x378D3B1B11D9385B(Any p0) { Function.Call(0x378D3B1B11D9385B, p0); }
		public static void _0xDA26263C07CCE9C2(Any p0) { Function.Call(0xDA26263C07CCE9C2, p0); }
		public static void _0xD64DBC8B0424135F(Any p0, Any p1) { Function.Call(0xD64DBC8B0424135F, p0, p1); }
		public static void _0xA59590050F80FF2E(Any p0, Any p1, Any p2, Any p3) { Function.Call(0xA59590050F80FF2E, p0, p1, p2, p3); }
		public static void _0x90E9A5DADBABC918(Any p0) { Function.Call(0x90E9A5DADBABC918, p0); }
		public static void _0xF8181B5EF156862C(Any p0) { Function.Call(0xF8181B5EF156862C, p0); }
		public static void STAT_ADD_BOUNTY_TARGET(Hash p0, int ped) { Function.Call(0x6B1044FDC2B09101, p0, ped); }
		public static void _0x8C889E4CBB4B2356(Any p0, Any p1) { Function.Call(0x8C889E4CBB4B2356, p0, p1); }
		public static void STAT_BOUNTY_CAPTURED(Any p0) { Function.Call(0x262EF7CF49CF1EB9, p0); }
		public static void _0xA596890CF55B5095(int ped, BOOL p1) { Function.Call(0xA596890CF55B5095, ped, p1); }
		public static void STAT_BOUNTY_ESCAPED(int ped) { Function.Call(0xB22F05732F72F70C, ped); }
		public static void _0xF21A5D66874FCEDD(Any p0, Any p1, Any p2) { Function.Call(0xF21A5D66874FCEDD, p0, p1, p2); }
		public static void _0x3EB2791A1FBC8A42(Any p0, Any p1) { Function.Call(0x3EB2791A1FBC8A42, p0, p1); }
		public static void _0xDF95DF488A645CE7() { Function.Call(0xDF95DF488A645CE7); }
		public static void STAT_PHOTOGRAPH_TAKEN(ItemSet itemset) { Function.Call(0x4D31051A4CA83787, itemset); }
		public static void _0xBE66B26B6529E943(Any p0, Any p1, Any p2) { Function.Call(0xBE66B26B6529E943, p0, p1, p2); }
		public static void _0xF2B5ABDE09958689(Any p0, Any p1, Any p2) { Function.Call(0xF2B5ABDE09958689, p0, p1, p2); }
		public static void STAT_REGISTER_LEGENDARY_ANIMAL_DEED(Hash deedHash) { Function.Call(0xCD0D69C65BB0E8B9, deedHash); }
		public static Any _0x302E71C1D9EE75B9(Any p0, Any p1, Any p2) { return Function.Call<Any>(0x302E71C1D9EE75B9, p0, p1, p2); }
		public static BOOL STATSTRACKER_IS_INITIALIZED(Hash p0) { return Function.Call<BOOL>(0x01F4D242765C6B24, p0); }
		public static void _0x6123E2832C34243D(Any p0, Any p1, Any p2, Any p3, Any p4) { Function.Call(0x6123E2832C34243D, p0, p1, p2, p3, p4); }
		public static void _0xCA41E86545413B5B(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6) { Function.Call(0xCA41E86545413B5B, p0, p1, p2, p3, p4, p5, p6); }
		public static void STATSTRACKER_DEED_STARTED(Hash p0, Any p1) { Function.Call(0xB2A38826E5886E83, p0, p1); }
		public static void _0xD5910ECF81A2278C(Any p0, Any p1, Any p2, Any p3) { Function.Call(0xD5910ECF81A2278C, p0, p1, p2, p3); }
		public static void _0x99230691875FC218(Any p0, Any p1, Any p2, Any p3, Any p4) { Function.Call(0x99230691875FC218, p0, p1, p2, p3, p4); }
		public static void _0x025E98E317652CDD(Any p0) { Function.Call(0x025E98E317652CDD, p0); }
		public static void _0xE5A680A5D8B1F687(Any p0) { Function.Call(0xE5A680A5D8B1F687, p0); }
		public static Any _0x4DAC398297981B87(Any p0) { return Function.Call<Any>(0x4DAC398297981B87, p0); }
		public static BOOL CHAL_IS_GOAL_ACTIVE(Hash chalHash, Hash goalHash) { return Function.Call<BOOL>(0x04DAC3929796EB87, chalHash, goalHash); }
		public static void CHAL_SET_GOAL_DISABLED(Hash chalHash, Hash goalHash, BOOL disabled) { Function.Call(0xF63DF9EE16393343, chalHash, goalHash, disabled); }
		public static int CHAL_GET_NUM_RANKS_COMPLETED(Hash chalHash) { return Function.Call<int>(0x58CB53DB63F84DE9, chalHash); }
		public static int CHAL_GET_MAX_RANKS(Hash chalHash) { return Function.Call<int>(0x58CB53DB63F84DEA, chalHash); }
		public static void CHAL_ADD_GOAL_PROGRESS_INT(Hash chalHash, Hash goalHash, int value) { Function.Call(0xDDBD560745B1EE9A, chalHash, goalHash, value); }
		public static void CHAL_ADD_GOAL_PROGRESS_FLOAT(Hash chalHash, Hash goalHash, float value) { Function.Call(0x86922D8C02FB7703, chalHash, goalHash, value); }
		public static void CHAL_SET_GOAL_PROGRESS_INT(Hash chalHash, Hash goalHash, int value) { Function.Call(0xDDBD560745B1EE9B, chalHash, goalHash, value); }
		public static void CHAL_ADD_GOAL_PROGRESS_INT_BY_SCORE_ID(Hash p0, int value) { Function.Call(0xDDBD560745B1EE9C, p0, value); }
		public static void CHAL_ADD_GOAL_PROGRESS_FLOAT_BY_SCORE_ID(Hash p0, float value) { Function.Call(0x86922D8C02FB7705, p0, value); }
		public static BOOL CHAL_ACHIEVEMENT_IS_COMPLETE(Hash p0, Hash p1) { return Function.Call<BOOL>(0x77B97A827739D434, p0, p1); }
		public static int CHAL_ACHIEVEMENT_GET_PROGRESS_INT(Hash p0, Hash p1) { return Function.Call<int>(0x808712E428F697B8, p0, p1); }
		public static void CHAL_NET_START_CHAL(Hash chalHash) { Function.Call(0x4ABF7E4DB6279E8F, chalHash); }
		public static void CHAL_NET_STOP_CHAL(Hash chalHash) { Function.Call(0x43B0163154A50C86, chalHash); }
		public static void CHAL_NET_START_GOAL(Hash chalHash, Hash goalHash) { Function.Call(0xC3FCB47344DCB638, chalHash, goalHash); }
		public static void CHAL_NET_STOP_GOAL(Hash chalHash, Hash goalHash) { Function.Call(0x00CE6A93324A590B, chalHash, goalHash); }
		public static Any _0xDDBD560745B1EE98(Any p0, Any p1, Any p2) { return Function.Call<Any>(0xDDBD560745B1EE98, p0, p1, p2); }
		public static Any _0xB112B9262EC29C20(Any p0, Any p1) { return Function.Call<Any>(0xB112B9262EC29C20, p0, p1); }
		public static void _0x4FCBCC0584CD08E9(Any p0) { Function.Call(0x4FCBCC0584CD08E9, p0); }
		public static Any _0xCA1F0B5103936891(Any p0) { return Function.Call<Any>(0xCA1F0B5103936891, p0); }
		public static Any _0x8BA3D7B1E83EF803(Any p0) { return Function.Call<Any>(0x8BA3D7B1E83EF803, p0); }
		public static int CHAL_MISSION_GET_NUM_GOALS(Hash missionHash) { return Function.Call<int>(0x0B0576DD3A75E58D, missionHash); }
		public static int CHAL_MISSION_GET_NUM_GOALS_COMPLETE(Hash missionHash) { return Function.Call<int>(0xA785A52B59B7E7B2, missionHash); }
		public static BOOL CHAL_MISSION_IS_GOAL_COMPLETE(Hash missionHash, Hash goalHash) { return Function.Call<BOOL>(0xC0BB774787BBF301, missionHash, goalHash); }
		public static void CHAL_MISSION_ADD_GOAL_PROGRESS_INT(Hash missionHash, Hash goalHash, int value) { Function.Call(0x97E18E7C098626DE, missionHash, goalHash, value); }
		public static Any _0x9D0F5D2E1951CD84() { return Function.Call<Any>(0x9D0F5D2E1951CD84); }
		public static void _0x218F7710A139D012() { Function.Call(0x218F7710A139D012); }
		public static Any _0x3AEABAE3F3C7600C() { return Function.Call<Any>(0x3AEABAE3F3C7600C); }
		public static Any _0x3F6FD87D2030ADC6() { return Function.Call<Any>(0x3F6FD87D2030ADC6); }
		public static Any _0xA2E2BEA4E83F6270(Any p0) { return Function.Call<Any>(0xA2E2BEA4E83F6270, p0); }
		public static Any _0xB5E2EDA2135E0FA1(Any p0, Any p1, Any p2) { return Function.Call<Any>(0xB5E2EDA2135E0FA1, p0, p1, p2); }
		public static int WEEKLY_COLLECTIBLE_GET_NUM_SETS(Hash chalHash) { return Function.Call<int>(0x8F5317729F791D10, chalHash); }
		public static Hash WEEKLY_COLLECTIBLE_GET_ITEM_SET_BUY_AWARD(Hash chalHash, int index) { return Function.Call<Hash>(0x610783F646894D25, chalHash, index); }
		public static Hash WEEKLY_COLLECTIBLE_GET_ITEM_SET_LABEL(Hash chalHash, int index) { return Function.Call<Hash>(0xBFFA88522FF0F730, chalHash, index); }
		public static int WEEKLY_COLLECTIBLE_GET_NUM_ITEMS_IN_SET(Hash chalHash, int index) { return Function.Call<int>(0x7D675C9DDDB365BE, chalHash, index); }
		public static unsafe BOOL WEEKLY_COLLECTIBLE_GET_ITEM_IN_SET(Hash chalHash, int setIndex, int itemIndex, Hash* p3, int* p4) { return Function.Call<BOOL>(0xBA61BA6205A3F5A8, chalHash, setIndex, itemIndex, p3, p4); }
		public static void _0x4F2D5FA23DB992DE() { Function.Call(0x4F2D5FA23DB992DE); }
		public static void _0x4E463A3CDEFFFE96() { Function.Call(0x4E463A3CDEFFFE96); }
	}

	public static class STREAMING
	{
		public static void REQUEST_MODEL(Hash model, BOOL p1) { Function.Call(0xFA28FE3A6246FC30, model, p1); }
		public static BOOL HAS_MODEL_LOADED(Hash model) { return Function.Call<BOOL>(0x1283B8B89DD5D1B6, model); }
		public static void SET_MODEL_AS_NO_LONGER_NEEDED(Hash model) { Function.Call(0x4AD96EF928BD4F9A, model); }
		public static BOOL IS_MODEL_IN_CDIMAGE(Hash model) { return Function.Call<BOOL>(0xD6F3B6D7716CFF8E, model); }
		public static BOOL IS_MODEL_VALID(Hash model) { return Function.Call<BOOL>(0x392C8D8E07B70EFC, model); }
		public static BOOL IS_MODEL_A_PED(Hash model) { return Function.Call<BOOL>(0xC3F09DE9D6D17DDA, model); }
		public static BOOL IS_MODEL_A_VEHICLE(Hash model) { return Function.Call<BOOL>(0x354F62672DE7DB0A, model); }
		public static BOOL _IS_MODEL_AN_OBJECT(Hash model) { return Function.Call<BOOL>(0x274EE1B90CFA669E, model); }
		public static BOOL _HAS_COLLISION_LOADED_AT_COORD(float x, float y, float z) { return Function.Call<BOOL>(0xDA8B2EAF29E872E2, x, y, z); }
		public static void _0x80B3E0597366ADF1() { Function.Call(0x80B3E0597366ADF1); }
		public static void REQUEST_COLLISION_AT_COORD(float x, float y, float z) { Function.Call(0x0A3720F162A033C9, x, y, z); }
		public static void _REQUEST_METADATA_AT_COORD(float x, float y, float z) { Function.Call(0xA8432A14D4DC2101, x, y, z); }
		public static void REQUEST_COLLISION_FOR_MODEL(Hash model) { Function.Call(0xF1767BE37F661551, model); }
		public static BOOL HAS_COLLISION_FOR_MODEL_LOADED(Hash model) { return Function.Call<BOOL>(0x210A79C9EC89778F, model); }
		public static void REQUEST_ADDITIONAL_COLLISION_AT_COORD(float x, float y, float z) { Function.Call(0x83A8D71650D1894F, x, y, z); }
		public static BOOL DOES_ANIM_DICT_EXIST(string animDict) { return Function.Call<BOOL>(0x537F44CB0D7F150D, animDict); }
		public static void REQUEST_ANIM_DICT(string animDict) { Function.Call(0xA862A2AD321F94B4, animDict); }
		public static BOOL HAS_ANIM_DICT_LOADED(string animDict) { return Function.Call<BOOL>(0x27FF6FE8009B40CA, animDict); }
		public static void REMOVE_ANIM_DICT(string animDict) { Function.Call(0x4763145053A33D46, animDict); }
		public static void REQUEST_MOVE_NETWORK_DEF(string name) { Function.Call(0x2B6529C54D29037A, name); }
		public static BOOL HAS_MOVE_NETWORK_DEF_LOADED(string name) { return Function.Call<BOOL>(0x2C04D89A0FB4E244, name); }
		public static void REMOVE_MOVE_NETWORK_DEF(string name) { Function.Call(0x57A197AD83F66BBF, name); }
		public static void REQUEST_CLIP_SET(string clipSet) { Function.Call(0xEF7611B57A820126, clipSet); }
		public static BOOL HAS_CLIP_SET_LOADED(string clipSet) { return Function.Call<BOOL>(0x1F23D6B6DA1CC3B2, clipSet); }
		public static void REMOVE_CLIP_SET(string clipSet) { Function.Call(0x817FA1B1EE7CD6F0, clipSet); }
		public static void _REQUEST_CLIP_SET_BY_HASH(Hash clipSetHash) { Function.Call(0xAC37644A538F7524, clipSetHash); }
		public static void _0x03DDBF2D73799F9E(Any p0) { Function.Call(0x03DDBF2D73799F9E, p0); }
		public static Any _0x85B8F04555AB49B8(Any p0) { return Function.Call<Any>(0x85B8F04555AB49B8, p0); }
		public static void _0x9F348DE670423460(Any p0) { Function.Call(0x9F348DE670423460, p0); }
		public static Any _0x5288B7F0690F7C1F(Any p0) { return Function.Call<Any>(0x5288B7F0690F7C1F, p0); }
		public static int _REQUEST_SCENARIO_TYPE(Hash scenarioType, int p1, Any p2, Any p3) { return Function.Call<int>(0x19A6BE7D9C6884D3, scenarioType, p1, p2, p3); }
		public static BOOL _HAS_SCENARIO_TYPE_LOADED(Hash scenarioType, BOOL p1) { return Function.Call<BOOL>(0x9427C94D2E4094A4, scenarioType, p1); }
		public static Any _REMOVE_SCENARIO_ASSET(Hash scenarioType) { return Function.Call<Any>(0x4EDDD9E9CA5AF985, scenarioType); }
		public static Any _0xB223249B7798EEED(Any p0, Any p1, Any p2, Any p3) { return Function.Call<Any>(0xB223249B7798EEED, p0, p1, p2, p3); }
		public static Any _0xA0AE7653E8181725(Any p0) { return Function.Call<Any>(0xA0AE7653E8181725, p0); }
		public static Any _0x66BC28E50E85270E(Any p0) { return Function.Call<Any>(0x66BC28E50E85270E, p0); }
		public static unsafe BOOL _GET_IPL_BOUNDING_SPHERE(Hash iplHash, Vector3* position, float* radius) { return Function.Call<BOOL>(0x9C77964B0E07B633, iplHash, position, radius); }
		public static void REQUEST_IPL_HASH(Hash iplHash) { Function.Call(0x59767C5A7A9AE6DA, iplHash); }
		public static void REQUEST_IPL_BY_HASH(Hash iplHash) { Function.Call(0x9E211A378F95C97C, iplHash); }
		public static void REMOVE_IPL_HASH(Hash iplHash) { Function.Call(0x5A3E5CF7B4014B96, iplHash); }
		public static void REMOVE_IPL_BY_HASH(Hash iplHash) { Function.Call(0x431E3AB760629B34, iplHash); }
		public static BOOL IS_IPL_ACTIVE_HASH(Hash iplHash) { return Function.Call<BOOL>(0xD779B9B910BD3B7C, iplHash); }
		public static BOOL IS_IPL_ACTIVE_BY_HASH(Hash iplHash) { return Function.Call<BOOL>(0x93AC1B91CB6D9913, iplHash); }
		public static BOOL _IS_POSITION_INSIDE_IPL_STREAMING_EXTENTS(Hash iplHash, float x, float y, float z) { return Function.Call<BOOL>(0x73B40D97D7BAAD77, iplHash, x, y, z); }
		public static void _0xDEEE1F265B7ECEF5() { Function.Call(0xDEEE1F265B7ECEF5); }
		public static void SET_GAME_PAUSES_FOR_STREAMING(BOOL toggle) { Function.Call(0xB3BC8250F4FE8B63, toggle); }
		public static int GET_NUMBER_OF_STREAMING_REQUESTS() { return Function.Call<int>(0x30CCCC4D88E654CA); }
		public static void REQUEST_PTFX_ASSET() { Function.Call(0x001FF43843028E0C); }
		public static BOOL HAS_PTFX_ASSET_LOADED() { return Function.Call<BOOL>(0x13A3F30A9ED0BC31); }
		public static void REMOVE_PTFX_ASSET() { Function.Call(0x042F9049EA419E86); }
		public static void REQUEST_NAMED_PTFX_ASSET(Hash fxNameHash) { Function.Call(0xF2B2353BBC0D4E8F, fxNameHash); }
		public static BOOL HAS_NAMED_PTFX_ASSET_LOADED(Hash fxNameHash) { return Function.Call<BOOL>(0x65BB72F29138F5D6, fxNameHash); }
		public static void REMOVE_NAMED_PTFX_ASSET(Hash fxNameHash) { Function.Call(0xF20866829E1C81A2, fxNameHash); }
		public static void SET_POPULATION_BUDGET_MULTIPLIER(float fBudgetMultiplier) { Function.Call(0x2F9AC754FE179D58, fBudgetMultiplier); }
		public static float GET_POPULATION_BUDGET_MULTIPLIER() { return Function.Call<float>(0x8A3945405B31048F); }
		public static Any _0x071769BCB24379E5() { return Function.Call<Any>(0x071769BCB24379E5); }
		public static void CLEAR_FOCUS() { Function.Call(0x86CCAF7CE493EFBE); }
		public static void SET_FOCUS_POS_AND_VEL(float x, float y, float z, float offsetX, float offsetY, float offsetZ) { Function.Call(0x25F6EF88664540E2, x, y, z, offsetX, offsetY, offsetZ); }
		public static void SET_FOCUS_ENTITY(int entity) { Function.Call(0x955AEDD58F4BD309, entity); }
		public static BOOL IS_ENTITY_FOCUS(int entity) { return Function.Call<BOOL>(0xF87DE697E9A06EC6, entity); }
		public static void SET_MAPDATACULLBOX_ENABLED(string name, BOOL toggle) { Function.Call(0x3CACC83F6FED837C, name, toggle); }
		public static void _0x19ABCC581D28E6F9(Any p0) { Function.Call(0x19ABCC581D28E6F9, p0); }
		public static void _0xF01D21DF39554115(Any p0) { Function.Call(0xF01D21DF39554115, p0); }
		public static BOOL LOAD_SCENE_START(float posX, float posY, float posZ, float offsetX, float offsetY, float offsetZ, float radius, int p7) { return Function.Call<BOOL>(0x387AD749E3B69B70, posX, posY, posZ, offsetX, offsetY, offsetZ, radius, p7); }
		public static BOOL LOAD_SCENE_START_SPHERE(float x, float y, float z, float radius, Any p4) { return Function.Call<BOOL>(0x513F8AA5BF2F17CF, x, y, z, radius, p4); }
		public static void LOAD_SCENE_STOP() { Function.Call(0x5A8B01199C3E79C3); }
		public static BOOL IS_LOAD_SCENE_ACTIVE() { return Function.Call<BOOL>(0xCF45DF50C7775F2A); }
		public static BOOL IS_LOAD_SCENE_LOADED() { return Function.Call<BOOL>(0x0909F71B5C070797); }
		public static BOOL IS_RENDERED_SCENE_LOADED() { return Function.Call<BOOL>(0x45BF3A6239A576B7); }
		public static BOOL IS_PLAYER_SWITCH_IN_PROGRESS() { return Function.Call<BOOL>(0xED20CB1F5297791D); }
		public static void _0xA03A6812529AD9C8() { Function.Call(0xA03A6812529AD9C8); }
		public static void IPL_GROUP_SWAP_START(string iplName1, string iplName2) { Function.Call(0x20D504994FDC4412, iplName1, iplName2); }
		public static void IPL_GROUP_SWAP_CANCEL() { Function.Call(0x31108BB5715D035F); }
		public static BOOL IPL_GROUP_SWAP_IS_READY() { return Function.Call<BOOL>(0xC2C05DEFE85A0B64); }
		public static void IPL_GROUP_SWAP_FINISH() { Function.Call(0x040EE319EFD1D3B5); }
		public static BOOL IPL_GROUP_SWAP_IS_ACTIVE() { return Function.Call<BOOL>(0xFC464598F6EE97B0); }
		public static void PREFETCH_SRL(string srl) { Function.Call(0x354837E5A5BAA5AF, srl); }
		public static void _0xAE00387E53B1E9FC() { Function.Call(0xAE00387E53B1E9FC); }
		public static void _0xEF1A8A484118735E() { Function.Call(0xEF1A8A484118735E); }
		public static void _0xD9F2FF4AF394D926() { Function.Call(0xD9F2FF4AF394D926); }
		public static BOOL IS_SRL_LOADED() { return Function.Call<BOOL>(0x5C2C88512CF6DAFB); }
		public static void BEGIN_SRL() { Function.Call(0x0360710033BE60D9); }
		public static void END_SRL() { Function.Call(0x1CE71FB33CA079FE); }
		public static void SET_SRL_TIME(float p0) { Function.Call(0x18231AEF458BCFF2, p0); }
		public static void _0xD346248C1DCE0D76(Any p0, Any p1, Any p2, Any p3) { Function.Call(0xD346248C1DCE0D76, p0, p1, p2, p3); }
		public static void _0x7C907E8A725E5FD2(BOOL p0) { Function.Call(0x7C907E8A725E5FD2, p0); }
		public static void SET_HD_AREA(float x, float y, float z, float radius) { Function.Call(0xB88B905AFA35CB4D, x, y, z, radius); }
		public static void CLEAR_HD_AREA() { Function.Call(0xD83B22434E52728D); }
		public static void _0x09FBF15D73EFC900() { Function.Call(0x09FBF15D73EFC900); }
		public static void _0xF11D7CB962FCD747(Any p0) { Function.Call(0xF11D7CB962FCD747, p0); }
		public static void _0xB9B9E47EDB9D63DB() { Function.Call(0xB9B9E47EDB9D63DB); }
		public static void _0xBE8DAA9D8D01DA6A(Any p0, Any p1, Any p2) { Function.Call(0xBE8DAA9D8D01DA6A, p0, p1, p2); }
		public static Any _0x53764309C4618087(Any p0) { return Function.Call<Any>(0x53764309C4618087, p0); }
		public static void _0x032A14D082A9B269(Hash p0) { Function.Call(0x032A14D082A9B269, p0); }
		public static void _0xAFA87A7D41EE346A(Any p0) { Function.Call(0xAFA87A7D41EE346A, p0); }
		public static void _0x6A6E79FBE8678C98() { Function.Call(0x6A6E79FBE8678C98); }
		public static void _0xCC61D8D6C19D9F14(Any p0) { Function.Call(0xCC61D8D6C19D9F14, p0); }
		public static Any _0xDA7FDEFF4DE86839() { return Function.Call<Any>(0xDA7FDEFF4DE86839); }
		public static Any _0x5D5E2102B174B8D2() { return Function.Call<Any>(0x5D5E2102B174B8D2); }
		public static Any _0x7B8C2B846C05E5AD() { return Function.Call<Any>(0x7B8C2B846C05E5AD); }
		public static void _0x62D5F0588915B277() { Function.Call(0x62D5F0588915B277); }
		public static Any _0x2F4D53023F826FF0() { return Function.Call<Any>(0x2F4D53023F826FF0); }
		public static Any _0xDABFE48BA0D457AA() { return Function.Call<Any>(0xDABFE48BA0D457AA); }
		public static Any _0xE5B76E5B56CD77DD() { return Function.Call<Any>(0xE5B76E5B56CD77DD); }
		public static Any _0x27AF48C62B281341() { return Function.Call<Any>(0x27AF48C62B281341); }
		public static Any _0x99F92061EFE908BA() { return Function.Call<Any>(0x99F92061EFE908BA); }
		public static Any _0x05DD384F39DE1C8C(Any p0, Any p1) { return Function.Call<Any>(0x05DD384F39DE1C8C, p0, p1); }
		public static Any _0x198B85CC3C7A4593(Any p0, Any p1) { return Function.Call<Any>(0x198B85CC3C7A4593, p0, p1); }
		public static Any _0x2A6D1DAAB9EBB262(Any p0) { return Function.Call<Any>(0x2A6D1DAAB9EBB262, p0); }
		public static void _0x07559B29950301FF(Any p0, Any p1) { Function.Call(0x07559B29950301FF, p0, p1); }
		public static Any _0xD6E39DC5D46DF4AB(Any p0) { return Function.Call<Any>(0xD6E39DC5D46DF4AB, p0); }
		public static Any _0x8D56BDA343D9519F(Any p0) { return Function.Call<Any>(0x8D56BDA343D9519F, p0); }
		public static void _0xD840C130D7AACFA5(Any p0, Any p1, Any p2) { Function.Call(0xD840C130D7AACFA5, p0, p1, p2); }
		public static void _0x2E24C27B112B5B12(Any p0) { Function.Call(0x2E24C27B112B5B12, p0); }
		public static void _SET_GUARMA_WORLDHORIZON_ACTIVE(BOOL toggle) { Function.Call(0x74E2261D2A66849A, toggle); }
	}

	public static class TASK
	{
		public static void TASK_PAUSE(int ped, int ms) { Function.Call(0xE73A266DB0CA9042, ped, ms); }
		public static void TASK_STAND_STILL(int ped, int time) { Function.Call(0x919BE13EED931959, ped, time); }
		public static void TASK_JUMP(int ped, BOOL unused) { Function.Call(0x0AE4086104E067B1, ped, unused); }
		public static void _TASK_JUMP_2(int ped, float x, float y, float z, int entity) { Function.Call(0x91083103137D7254, ped, x, y, z, entity); }
		public static void TASK_COWER(int ped, int duration, int pedToCowerFrom, string p3) { Function.Call(0x3EB1FE9E8E908E15, ped, duration, pedToCowerFrom, p3); }
		public static void TASK_HANDS_UP(int ped, int duration, int facingPed, int p3, BOOL p4) { Function.Call(0xF2EAB31979A7F910, ped, duration, facingPed, p3, p4); }
		public static void TASK_KNOCKED_OUT(int ped, float p1, BOOL permanently) { Function.Call(0xF90427F00A495A28, ped, p1, permanently); }
		public static void TASK_KNOCKED_OUT_AND_HOGTIED(int ped, float p1, int p2) { Function.Call(0x42AC6401ABB8C7E5, ped, p1, p2); }
		public static void _0xFFB520A3E16F7B7B(int ped, float p1) { Function.Call(0xFFB520A3E16F7B7B, ped, p1); }
		public static void _0x8B1FDF63C3193EDA(int ped, float p1) { Function.Call(0x8B1FDF63C3193EDA, ped, p1); }
		public static void UPDATE_TASK_HANDS_UP_DURATION(int ped, int duration) { Function.Call(0xA98FCAFD7893C834, ped, duration); }
		public static void _0x28EF780BDEA8A639(int ped, int p1) { Function.Call(0x28EF780BDEA8A639, ped, p1); }
		public static void TASK_DUCK(int ped, int p1) { Function.Call(0xA14B5FBF986BAC23, ped, p1); }
		public static void _TASK_BOARD_VEHICLE(int ped, int vehicle, Any p2, Any p3, Any p4, Any p5) { Function.Call(0xE53D17AD837CBF7C, ped, vehicle, p2, p3, p4, p5); }
		public static void _TASK_DISEMBARK_VEHICLE(Any p0, int vehicle, int p2, Any p3, float p4, Any p5) { Function.Call(0xA7C6854BB5A4192A, p0, vehicle, p2, p3, p4, p5); }
		public static void _TASK_BOARD_VEHICLE_2(int ped, Any p1, Any p2, float p3, int flags) { Function.Call(0xE41A09C8DDFF7AA4, ped, p1, p2, p3, flags); }
		public static void TASK_DISEMBARK_NEAREST_TRAIN_CARRIAGE(int ped, float p1, int flags) { Function.Call(0x0A11F3BDEC03ED5F, ped, p1, flags); }
		public static void TASK_ENTER_VEHICLE(int ped, int vehicle, int timeout, int seat, float speed, int flag, Any p6) { Function.Call(0xC20E50AA46D09CA8, ped, vehicle, timeout, seat, speed, flag, p6); }
		public static void TASK_LEAVE_VEHICLE(int ped, int vehicle, int flags, int unkPed) { Function.Call(0xD3DBCE61A490BE02, ped, vehicle, flags, unkPed); }
		public static void TASK_MOUNT_ANIMAL(int ped, int mount, int timer, int seatIndex, float pedSpeed, int mountStyle, Any p6, Any p7) { Function.Call(0x92DB0739813C5186, ped, mount, timer, seatIndex, pedSpeed, mountStyle, p6, p7); }
		public static void TASK_DISMOUNT_ANIMAL(int rider, int taskFlag, Any p2, Any p3, Any p4, int targetPed) { Function.Call(0x48E92D3DDE23C23A, rider, taskFlag, p2, p3, p4, targetPed); }
		public static void TASK_HITCH_ANIMAL(int ped, int scenarioPoint, int flag) { Function.Call(0x9030AD4B6207BFE8, ped, scenarioPoint, flag); }
		public static void _0xE05A5D39BE6E93AF(Any p0) { Function.Call(0xE05A5D39BE6E93AF, p0); }
		public static void TASK_VEHICLE_DRIVE_TO_COORD(int ped, int vehicle, float x, float y, float z, float speed, Any p6, Hash vehicleModel, int drivingMode, float stopRange, float p10) { Function.Call(0xE2A2AA2F659D77A7, ped, vehicle, x, y, z, speed, p6, vehicleModel, drivingMode, stopRange, p10); }
		public static void _TASK_VEHICLE_DRIVE_TO_COORD_2(int ped, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8) { Function.Call(0xF0108F01FB105DA2, ped, p1, p2, p3, p4, p5, p6, p7, p8); }
		public static void TASK_VEHICLE_DRIVE_WANDER(int ped, int vehicle, float speed, int drivingStyle) { Function.Call(0x480142959D337D00, ped, vehicle, speed, drivingStyle); }
		public static void TASK_FOLLOW_TO_OFFSET_OF_ENTITY(int ped, int entity, float offsetX, float offsetY, float offsetZ, float movementSpeed, int timeout, float stoppingRange, BOOL persistFollowing, BOOL p9, BOOL walkOnly, BOOL p11, BOOL p12, BOOL p13) { Function.Call(0x304AE42E357B8C7E, ped, entity, offsetX, offsetY, offsetZ, movementSpeed, timeout, stoppingRange, persistFollowing, p9, walkOnly, p11, p12, p13); }
		public static void TASK_FOLLOW_TO_OFFSET_OF_COORD(int ped, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8, Any p9, Any p10, Any p11, Any p12, Any p13, Any p14) { Function.Call(0x2E3676282C18A692, ped, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14); }
		public static void _0x3FFCD7BBA074CC80(int ped, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8) { Function.Call(0x3FFCD7BBA074CC80, ped, p1, p2, p3, p4, p5, p6, p7, p8); }
		public static void TASK_GO_STRAIGHT_TO_COORD(int ped, float x, float y, float z, float moveBlendSpeedY, int p5, float p6, float p7, int p8) { Function.Call(0xD76B57B44F1E6F8B, ped, x, y, z, moveBlendSpeedY, p5, p6, p7, p8); }
		public static void TASK_GO_STRAIGHT_TO_COORD_RELATIVE_TO_ENTITY(int ped, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7) { Function.Call(0x61E360B7E040D12E, ped, p1, p2, p3, p4, p5, p6, p7); }
		public static void TASK_MOVE_IN_TRAFFIC(int ped, Any p1, Any p2, Any p3) { Function.Call(0x8AA1593AEC087A29, ped, p1, p2, p3); }
		public static void TASK_MOVE_IN_TRAFFIC_TO_DESTINATION(int ped, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7) { Function.Call(0xDCA3A13F7A45338B, ped, p1, p2, p3, p4, p5, p6, p7); }
		public static void TASK_MOVE_IN_TRAFFIC_AWAY_FROM_ENTITY(int ped, Any p1, Any p2, Any p3, Any p4) { Function.Call(0x13DED0BC45600FE1, ped, p1, p2, p3, p4); }
		public static void _0xBAAB791AA72C2821(Any p0, Any p1) { Function.Call(0xBAAB791AA72C2821, p0, p1); }
		public static void TASK_MOVE_FOLLOW_ROAD_USING_NAVMESH(int ped, float moveBlendRatio, float x, float y, float z, Any p5) { Function.Call(0x79482C12482A860D, ped, moveBlendRatio, x, y, z, p5); }
		public static void TASK_ACHIEVE_HEADING(int ped, float heading, int timeout) { Function.Call(0x93B93A37987F1F3D, ped, heading, timeout); }
		public static void TASK_FLUSH_ROUTE() { Function.Call(0x841142A1376E9006); }
		public static void TASK_EXTEND_ROUTE(float x, float y, float z) { Function.Call(0x1E7889778264843A, x, y, z); }
		public static void TASK_FOLLOW_POINT_ROUTE(int ped, Any p1, Any p2, Any p3, Any p4, Any p5) { Function.Call(0x0E14C5550DC3CD1D, ped, p1, p2, p3, p4, p5); }
		public static void TASK_ENTER_ANIM_SCENE(int ped, AnimScene animScene, string entityName, string playbackListName, float enterSpeed, BOOL bAutoStart, int flag, int p7, float p8) { Function.Call(0xC2329B0206426644, ped, animScene, entityName, playbackListName, enterSpeed, bAutoStart, flag, p7, p8); }
		public static void TASK_MOVE_BE_IN_FORMATION(int ped, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6) { Function.Call(0x4AA5AA97C65E4A2F, ped, p1, p2, p3, p4, p5, p6); }
		public static void TASK_GO_TO_ENTITY(int ped, int target, int duration, float distance, float speed, float p5, int p6) { Function.Call(0x6A071245EB0D1882, ped, target, duration, distance, speed, p5, p6); }
		public static void TASK_FOLLOW_AND_CONVERSE_WITH_PED(int ped, int targetPed, Any p2, Any p3, float p4, float p5, int p6, Any p7, Any p8, float p9, float p10) { Function.Call(0x489FFCCCE7392B55, ped, targetPed, p2, p3, p4, p5, p6, p7, p8, p9, p10); }
		public static void _0xA052608A12559BBB(Any p0, Any p1) { Function.Call(0xA052608A12559BBB, p0, p1); }
		public static void TASK_WANDER_AND_CONVERSE_WITH_PED(int ped, Any p1, Any p2, Any p3) { Function.Call(0x8AC76D1408731732, ped, p1, p2, p3); }
		public static void TASK_LEAD_AND_CONVERSE(int ped, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8) { Function.Call(0xAA19711D33C6708C, ped, p1, p2, p3, p4, p5, p6, p7, p8); }
		public static void _0xDE0C8B145EA466FF(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5) { Function.Call(0xDE0C8B145EA466FF, p0, p1, p2, p3, p4, p5); }
		public static void TASK_SEEK_CLEAR_LOS_TO_ENTITY(int ped, int entity, float p2, float p3, float p4) { Function.Call(0x8D7F2A63688C20A4, ped, entity, p2, p3, p4); }
		public static void TASK_GO_TO_WHISTLE(int ped, int p1, int whistleType) { Function.Call(0xBAD6545608CECA6E, ped, p1, whistleType); }
		public static Any _0xEB67D4E056C85A81(Any p0) { return Function.Call<Any>(0xEB67D4E056C85A81, p0); }
		public static Any _0x78D8C1D4EB80C588(Any p0) { return Function.Call<Any>(0x78D8C1D4EB80C588, p0); }
		public static void TASK_LEAD_HORSE(int ped, int horse) { Function.Call(0x9A7A4A54596FE09D, ped, horse); }
		public static void TASK_STOP_LEADING_HORSE(int ped) { Function.Call(0xED27560703F37258, ped); }
		public static void _TASK_FLEE_FROM_COORD(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8, Any p9, Any p10, Any p11) { Function.Call(0x6879FF208ED87F2A, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11); }
		public static void _TASK_FLEE_FROM_PED(int ped, int fleeFromTarget, float x, float y, float z, float distance, int p6, int p7, float p8, int targetPed) { Function.Call(0x7B74D8EEDE9B5727, ped, fleeFromTarget, x, y, z, distance, p6, p7, p8, targetPed); }
		public static void TASK_SMART_FLEE_COORD(int ped, float x, float y, float z, float distance, int time, int fleeType, float fleeSpeed) { Function.Call(0x94587F17E9C365D5, ped, x, y, z, distance, time, fleeType, fleeSpeed); }
		public static void TASK_SMART_FLEE_PED(int ped, int fleeFromTarget, float fleeDistance, int fleeTime, int fleeType, float fleeSpeed, int targetPed) { Function.Call(0x22B0D0E37CCB840D, ped, fleeFromTarget, fleeDistance, fleeTime, fleeType, fleeSpeed, targetPed); }
		public static void _0x673A8779D229BA5A(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5) { Function.Call(0x673A8779D229BA5A, p0, p1, p2, p3, p4, p5); }
		public static void _0x2E1D6D87346BB7D2(Any p0, Any p1, Any p2, Any p3) { Function.Call(0x2E1D6D87346BB7D2, p0, p1, p2, p3); }
		public static void TASK_FLEE_COORD(int ped, float x, float y, float z, int fleeStyle, int p5, float p6, int duration, int p8) { Function.Call(0x58428248BF4B64E4, ped, x, y, z, fleeStyle, p5, p6, duration, p8); }
		public static void TASK_FLEE_PED(int ped, int fleeFromTarget, int fleeStyle, int flag, float p4, int p5, int p6) { Function.Call(0xFD45175A6DFD7CE9, ped, fleeFromTarget, fleeStyle, flag, p4, p5, p6); }
		public static void TASK_FLEE_COORD_VIA(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8, Any p9, Any p10, Any p11) { Function.Call(0x390E0B697D25EAF5, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11); }
		public static void TASK_FLEE_PED_VIA(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8, Any p9) { Function.Call(0x5802E0F910E4CF1D, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9); }
		public static void _ADD_FLEE_TARGET_COORDS(int ped, float x, float y, float z, float p4) { Function.Call(0xE8F1A5B4CED3725A, ped, x, y, z, p4); }
		public static void ADD_FLEE_TARGET_PED(int ped, int targetPed, float p2) { Function.Call(0x3923EC958249657D, ped, targetPed, p2); }
		public static void _0xA42DC7919159CCCF(Any p0) { Function.Call(0xA42DC7919159CCCF, p0); }
		public static void TASK_FLY_AWAY(int ped, Any p1) { Function.Call(0xE86A537B5A3C297C, ped, p1); }
		public static void TASK_FLY_TO_COORD(int ped, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6) { Function.Call(0xD6CFC2D59DA72042, ped, p1, p2, p3, p4, p5, p6); }
		public static void TASK_FLYING_CIRCLE(int ped, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6) { Function.Call(0x72997893BFB8ECCC, ped, p1, p2, p3, p4, p5, p6); }
		public static void TASK_WALK_AWAY(int ped, int entity) { Function.Call(0x04ACFAC71E6858F9, ped, entity); }
		public static void TASK_SHOCKING_EVENT_REACT(int ped, Any p1, Any p2) { Function.Call(0x452419CBD838065B, ped, p1, p2); }
		public static void TASK_REACT(int ped, int reactingTo, float x, float y, float z, string reactionName, float p6, float p7, int p8) { Function.Call(0xC4C32C31920E1B70, ped, reactingTo, x, y, z, reactionName, p6, p7, p8); }
		public static void TASK_WANDER_IN_AREA(int ped, float x, float y, float z, float radius, float p5, float p6, int p7) { Function.Call(0xE054346CA3A0F315, ped, x, y, z, radius, p5, p6, p7); }
		public static void TASK_WANDER_IN_VOLUME(int ped, Volume volume, float p2, float p3, int p4) { Function.Call(0x9FDA168777B28424, ped, volume, p2, p3, p4); }
		public static void TASK_WANDER_STANDARD(int ped, float p1, int p2) { Function.Call(0xBB9CE077274F6A1B, ped, p1, p2); }
		public static void TASK_WANDER_SWIM(int ped, Any p1) { Function.Call(0x527EA3DB8BC7F03B, ped, p1); }
		public static void TASK_PLANT_BOMB(int ped, float x, float y, float z, float heading) { Function.Call(0x965FEC691D55E9BF, ped, x, y, z, heading); }
		public static void TASK_HORSE_ACTION(int ped, int action, int targetPed, Any p3) { Function.Call(0xA09CFD29100F06C3, ped, action, targetPed, p3); }
		public static void TASK_ANIMAL_INTERACTION(int ped, int targetPed, Hash interactionType, Hash interactionModel, BOOL skipIdleAnimationClip) { Function.Call(0xCD181A959CFDD7F4, ped, targetPed, interactionType, interactionModel, skipIdleAnimationClip); }
		public static void TASK_COMBAT_ANIMAL_WARN(int ped, Any p1, Any p2) { Function.Call(0xF960F3D57B660E96, ped, p1, p2); }
		public static void TASK_COMBAT_ANIMAL_CHARGE_PED(int ped, int targetPed, BOOL p2, Any p3, Any p4, Any p5, Any p6) { Function.Call(0xEE3AA414CF99F368, ped, targetPed, p2, p3, p4, p5, p6); }
		public static Any _0x76610D12A838EBDE(Any p0) { return Function.Call<Any>(0x76610D12A838EBDE, p0); }
		public static void TASK_AMBIENT_ANIMAL_STALK(int ped, Any p1, Any p2) { Function.Call(0x37C13863ABA1B4A3, ped, p1, p2); }
		public static void TASK_AMBIENT_ANIMAL_HUNT(int ped, Any p1, Any p2) { Function.Call(0x4B39D8F9D0FE7749, ped, p1, p2); }
		public static void TASK_ANIMAL_UNALERTED(int ped, Any p1, Any p2, Any p3, Any p4) { Function.Call(0x21FDF9A25CFE1CE5, ped, p1, p2, p3, p4); }
		public static void TASK_ANIMAL_ALERTED(int ped, Any p1, Any p2) { Function.Call(0x979D93372FC8C565, ped, p1, p2); }
		public static void TASK_ANIMAL_FLEE(int ped, int targetPed, Any p2) { Function.Call(0xA899B61C66F09134, ped, targetPed, p2); }
		public static Any _0x244430C13BA5258E(Any p0, Any p1, Any p2, Any p3) { return Function.Call<Any>(0x244430C13BA5258E, p0, p1, p2, p3); }
		public static void TASK_EAT(int ped, Any p1, Any p2) { Function.Call(0xBD7949BD07299672, ped, p1, p2); }
		public static void TASK_BARK(int ped, int barkAtTarget, Hash mood) { Function.Call(0x83BFC1F836B2F3F2, ped, barkAtTarget, mood); }
		public static unsafe void TASK_FOLLOW_PAVEMENT_TO_COORD(int ped, Any* args) { Function.Call(0x1B1475414E70DD8E, ped, args); }
		public static void TASK_FOLLOW_NAV_MESH_TO_COORD(int ped, float x, float y, float z, float speedMultiplier, int timeout, float stoppingRange, int flags, float heading) { Function.Call(0x15D3A79D4E44B913, ped, x, y, z, speedMultiplier, timeout, stoppingRange, flags, heading); }
		public static void TASK_FOLLOW_NAV_MESH_TO_COORD_ADVANCED(int ped, float x, float y, float z, float speedMultiplier, int timeout, float stoppingRange, int flags, float p8, float p9, float p10, int entity, float unk) { Function.Call(0x17F58B88D085DBAC, ped, x, y, z, speedMultiplier, timeout, stoppingRange, flags, p8, p9, p10, entity, unk); }
		public static void SET_PED_PATH_CAN_USE_CLIMBOVERS(int ped, BOOL toggle) { Function.Call(0x8E06A6FE76C9EFF4, ped, toggle); }
		public static void SET_PED_PATH_CAN_USE_LADDERS(int ped, BOOL toggle) { Function.Call(0x77A5B103C87F476E, ped, toggle); }
		public static void SET_PED_PATH_CAN_DROP_FROM_HEIGHT(int ped, BOOL toggle) { Function.Call(0xE361C5C71C431A4F, ped, toggle); }
		public static Any _0xE6A151364C600B24(Any p0) { return Function.Call<Any>(0xE6A151364C600B24, p0); }
		public static void _0x1632EB9386CDBE64(Any p0, Any p1) { Function.Call(0x1632EB9386CDBE64, p0, p1); }
		public static void SET_PED_PATH_CLIMB_COST_MODIFIER(int ped, float modifier) { Function.Call(0x88E32DB8C1A4AA4B, ped, modifier); }
		public static void SET_PED_PATH_DEEP_SNOW_COST_MODIFIER(int ped, float modifier) { Function.Call(0xE8C296B75EACC357, ped, modifier); }
		public static void SET_PED_PATH_FOLIAGE_COST_MODIFIER(int ped, float modifier) { Function.Call(0x3AD8EFF9703BE657, ped, modifier); }
		public static void _0x8798CF6815B8FE0F(Any p0, Any p1) { Function.Call(0x8798CF6815B8FE0F, p0, p1); }
		public static void _0x5B68D0007D9C92EB(Any p0, Any p1) { Function.Call(0x5B68D0007D9C92EB, p0, p1); }
		public static void _0x82ED59F095056550(Any p0, Any p1) { Function.Call(0x82ED59F095056550, p0, p1); }
		public static void _0xE01C8DC8EDD28D31(Any p0, Any p1) { Function.Call(0xE01C8DC8EDD28D31, p0, p1); }
		public static void _0x098CAA6DBE7D8D82(Any p0, Any p1) { Function.Call(0x098CAA6DBE7D8D82, p0, p1); }
		public static BOOL _GET_PED_IS_IGNORING_DEAD_BODIES(int ped) { return Function.Call<BOOL>(0x1948BBE561A2375A, ped); }
		public static void _SET_PED_IGNORE_DEAD_BODIES(int ped, BOOL toggle) { Function.Call(0x013A7BA5015C1372, ped, toggle); }
		public static void _SET_PED_PATH_LADDER_COST_MODIFIER(int ped, float modifier) { Function.Call(0x70F7A1EAB1AE3AA8, ped, modifier); }
		public static void SET_PED_PATH_MAY_ENTER_WATER(int ped, BOOL mayEnterWater) { Function.Call(0xF35425A4204367EC, ped, mayEnterWater); }
		public static void _SET_PED_PATH_MAY_ENTER_DEEP_WATER(int ped, BOOL mayEnterDeepWater) { Function.Call(0x9DE63896B176EA94, ped, mayEnterDeepWater); }
		public static void _0xC6170856E54557B2(Any p0, Any p1, Any p2) { Function.Call(0xC6170856E54557B2, p0, p1, p2); }
		public static void _0xF948F4356F010F11(Any p0, Any p1, Any p2) { Function.Call(0xF948F4356F010F11, p0, p1, p2); }
		public static void SET_PED_PATH_PREFER_TO_AVOID_WATER(int ped, BOOL avoidWater, float p2) { Function.Call(0x38FE1EC73743793C, ped, avoidWater, p2); }
		public static void _0x8BB283A7888AD1AD(Any p0, Any p1, Any p2) { Function.Call(0x8BB283A7888AD1AD, p0, p1, p2); }
		public static void _0x12990818C1D35886(Any p0, Any p1, Any p2) { Function.Call(0x12990818C1D35886, p0, p1, p2); }
		public static void _0x7C015D8BCEC72CF4(Any p0, Any p1) { Function.Call(0x7C015D8BCEC72CF4, p0, p1); }
		public static void SET_PED_PATH_AVOID_FIRE(int ped, BOOL avoidFire) { Function.Call(0x4455517B28441E60, ped, avoidFire); }
		public static void _0x42CFD8FD8CC8DC69(Any p0, Any p1) { Function.Call(0x42CFD8FD8CC8DC69, p0, p1); }
		public static void _0x216343750545A486(Any p0, Any p1, Any p2) { Function.Call(0x216343750545A486, p0, p1, p2); }
		public static void _0x06ECF3925BC2ABAE(Any p0, Any p1) { Function.Call(0x06ECF3925BC2ABAE, p0, p1); }
		public static void _0xFA30E2254461ADEB(Any p0, Any p1) { Function.Call(0xFA30E2254461ADEB, p0, p1); }
		public static void TASK_GO_TO_COORD_ANY_MEANS(int ped, float x, float y, float z, float speed, int entity, BOOL p6, int walkingStyle, float p8) { Function.Call(0x5BC448CB78FA3E88, ped, x, y, z, speed, entity, p6, walkingStyle, p8); }
		public static void TASK_GO_TO_COORD_ANY_MEANS_EXTRA_PARAMS(int ped, float x, float y, float z, float speed, Any p5, BOOL p6, int walkingStyle, float p8, Any p9, Any p10, Any p11, Any p12) { Function.Call(0x1DD45F9ECFDB1BC9, ped, x, y, z, speed, p5, p6, walkingStyle, p8, p9, p10, p11, p12); }
		public static void TASK_GO_TO_COORD_ANY_MEANS_EXTRA_PARAMS_WITH_CRUISE_SPEED(int ped, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8, Any p9, Any p10, Any p11, Any p12, Any p13, Any p14) { Function.Call(0xB8ECD61F531A7B02, ped, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14); }
		public static void TASK_PLAY_ANIM(int ped, string animDict, string animName, float speed, float speedMultiplier, int duration, int flags, float playbackRate, BOOL p8, int p9, BOOL p10, string taskFilter, BOOL p12) { Function.Call(0xEA47FE3719165B94, ped, animDict, animName, speed, speedMultiplier, duration, flags, playbackRate, p8, p9, p10, taskFilter, p12); }
		public static void TASK_PLAY_ANIM_ADVANCED(int ped, string animDict, string animName, float posX, float posY, float posZ, float rotX, float rotY, float rotZ, float speed, float speedMultiplier, int duration, int flags, float p13, int p14, int p15, int p16) { Function.Call(0x83CDB10EA29B370B, ped, animDict, animName, posX, posY, posZ, rotX, rotY, rotZ, speed, speedMultiplier, duration, flags, p13, p14, p15, p16); }
		public static void TASK_PLAY_UPPER_ANIM_FACING_ENTITY(int ped, string animDict, string animName, int entity, int p4, float p5, float p6, int p7, float p8, BOOL p9, BOOL p10, float p11, string p12, int p13, float p14) { Function.Call(0xAD67214236AB1CFE, ped, animDict, animName, entity, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14); }
		public static void STOP_ANIM_TASK(int ped, string animDictionary, string animationName, float p3) { Function.Call(0x97FF36A1D40EA00A, ped, animDictionary, animationName, p3); }
		public static unsafe void TASK_SCRIPTED_ANIMATION(int ped, Any* args) { Function.Call(0x126EF75F1E17ABE5, ped, args); }
		public static unsafe void PLAY_ENTITY_SCRIPTED_ANIM(int entity, Any* args) { Function.Call(0x77A1EEC547E7FCF1, entity, args); }
		public static void STOP_ANIM_PLAYBACK(int ped, int p1, BOOL p2) { Function.Call(0xEE08C992D238C5D1, ped, p1, p2); }
		public static void SET_ANIM_FILTER(Any p0, Any p1, Any p2, Any p3) { Function.Call(0x87B66D77D545DB66, p0, p1, p2, p3); }
		public static void SET_ANIM_RATE(Any p0, float p1, Any p2, BOOL p3) { Function.Call(0x032D49C5E359C847, p0, p1, p2, p3); }
		public static BOOL CAN_START_ITEM_INTERACTION(int ped, Hash itemHash, Hash interactionAnimHash, int p3) { return Function.Call<BOOL>(0x2D19BC4DF626CBE7, ped, itemHash, interactionAnimHash, p3); }
		public static void START_TASK_ITEM_INTERACTION(int ped, Hash itemHash, Hash interactionAnimHash, int p3, int flag, float p5) { Function.Call(0xAE72E7DF013AAA61, ped, itemHash, interactionAnimHash, p3, flag, p5); }
		public static void _TASK_ITEM_INTERACTION_2(int ped, Hash propNameGxt, Object prop, Hash propId, Hash itemInteractionState, int p5, Any p6, float p7) { Function.Call(0x72F52AA2D2B172CC, ped, propNameGxt, prop, propId, itemInteractionState, p5, p6, p7); }
		public static unsafe void _TASK_ITEM_INTERACTION_3(int ped, Hash item, Any* guid, Any p3, Any p4, Any p5, float p6) { Function.Call(0xD61D5E1AD9876DEB, ped, item, guid, p3, p4, p5, p6); }
		public static void _0xB35370D5353995CB(Any p0, Any p1, Any p2) { Function.Call(0xB35370D5353995CB, p0, p1, p2); }
		public static Hash GET_ITEM_INTERACTION_STATE(int ped) { return Function.Call<Hash>(0x6AA3DCA2C6F5EB6D, ped); }
		public static Hash GET_ITEM_INTERACTION_ITEM_ID(int ped) { return Function.Call<Hash>(0x804425C4BBD00883, ped); }
		public static BOOL IS_PED_RUNNING_INSPECTION_TASK(int ped) { return Function.Call<BOOL>(0x038B1F1674F0E242, ped); }
		public static BOOL IS_PED_RUNNING_TASK_ITEM_INTERACTION(int ped) { return Function.Call<BOOL>(0xEC7E480FF8BD0BED, ped); }
		public static int _GET_ITEM_INTERACTION_ENTITY_FROM_PED(int ped, Hash item) { return Function.Call<int>(0x05A0100EA714DB68, ped, item); }
		public static float GET_ITEM_INTERACTION_PROMPT_PROGRESS(int ped, Hash inputContext) { return Function.Call<float>(0xBC864A70AD55E0C1, ped, inputContext); }
		public static Any _0x678D3226CF70B9C8(Any p0, Any p1) { return Function.Call<Any>(0x678D3226CF70B9C8, p0, p1); }
		public static void TASK_EVASIVE_ANIM(int ped, Any p1, Any p2) { Function.Call(0x5F22926E1BCE9B08, ped, p1, p2); }
		public static void TASK_LOOK_AT_COORD(int ped, float x, float y, float z, Any p4, Any p5, Any p6, Any p7) { Function.Call(0x6FA46612594F7973, ped, x, y, z, p4, p5, p6, p7); }
		public static void TASK_LOOK_AT_ENTITY(int ped, int lookAtTarget, int duration, int p3, int p4, int p5) { Function.Call(0x69F4BE8C8CC4796C, ped, lookAtTarget, duration, p3, p4, p5); }
		public static void TASK_CLEAR_LOOK_AT(int ped) { Function.Call(0x0F804F1DB19B9689, ped); }
		public static Any _0x508F5053E3F6F0C4(Any p0, Any p1, Any p2, Any p3, Any p4) { return Function.Call<Any>(0x508F5053E3F6F0C4, p0, p1, p2, p3, p4); }
		public static void _0x23767D80C7EED7C6(Any p0, Any p1) { Function.Call(0x23767D80C7EED7C6, p0, p1); }
		public static unsafe void OPEN_SEQUENCE_TASK(int* taskSequenceId) { Function.Call(0xE8854A4326B9E12B, taskSequenceId); }
		public static void CLOSE_SEQUENCE_TASK(int taskSequenceId) { Function.Call(0x39E72BC99E6360CB, taskSequenceId); }
		public static void TASK_PERFORM_SEQUENCE(int ped, int taskSequenceId) { Function.Call(0x5ABA3986D90D8A3B, ped, taskSequenceId); }
		public static void _TASK_PERFORM_SEQUENCE_2(Any p0, Any p1, Any p2, Any p3) { Function.Call(0x4FC0AF869D6E309D, p0, p1, p2, p3); }
		public static unsafe void CLEAR_SEQUENCE_TASK(int* taskSequenceId) { Function.Call(0x3841422E9C488D8C, taskSequenceId); }
		public static void SET_SEQUENCE_TO_REPEAT(int taskSequenceId, BOOL repeat) { Function.Call(0x58C70CF3A41E4AE7, taskSequenceId, repeat); }
		public static int GET_SEQUENCE_PROGRESS(int ped) { return Function.Call<int>(0x00A9010CFE1E3533, ped); }
		public static BOOL GET_IS_TASK_ACTIVE(int ped, int taskIndex) { return Function.Call<BOOL>(0xB0760331C7AA4155, ped, taskIndex); }
		public static int GET_SCRIPT_TASK_STATUS(int ped, Hash taskHash, BOOL p2) { return Function.Call<int>(0x77F1BEB8863288D5, ped, taskHash, p2); }
		public static Any _0x9FF5F9B24E870748(Any p0) { return Function.Call<Any>(0x9FF5F9B24E870748, p0); }
		public static float _GET_SCRIPT_TASK_ACTION_TIME(int ped, Hash task) { return Function.Call<float>(0xA710DC5D25F8B942, ped, task); }
		public static void REACT_LOOK_AT(int ped, int targetPed, int lookIntensity, int exitAnimation, float duration, int p5, int targetPed2, Any p7, Any p8) { Function.Call(0xE7FA07624574B79A, ped, targetPed, lookIntensity, exitAnimation, duration, p5, targetPed2, p7, p8); }
		public static void REACT_LOOK_AT_END(int ped, int exitAnimation, BOOL p2) { Function.Call(0x541E5B41DCA45828, ped, exitAnimation, p2); }
		public static BOOL IS_PED_SCENARIO_REACT_LOOKING(int ped, BOOL p1) { return Function.Call<BOOL>(0x916B8E075ABC8B4E, ped, p1); }
		public static int GET_ACTIVE_VEHICLE_MISSION_TYPE(int vehicle) { return Function.Call<int>(0x534AEBA6E5ED4CAB, vehicle); }
		public static void TASK_LEAVE_ANY_VEHICLE(int ped, int p1, int taskFlag) { Function.Call(0x504D54DF3F6F2247, ped, p1, taskFlag); }
		public static Any _0xBD70108D01875299(Any p0) { return Function.Call<Any>(0xBD70108D01875299, p0); }
		public static void TASK_USE_RANDOM_SCENARIO_IN_GROUP(int ped, Any p1, Any p2, Any p3, Any p4) { Function.Call(0x14747F4A5971DE4E, ped, p1, p2, p3, p4); }
		public static void TASK_AIM_GUN_AT_ENTITY(int ped, int targetEntity, int duration, BOOL p3, int p4) { Function.Call(0x9B53BB6E8943AF53, ped, targetEntity, duration, p3, p4); }
		public static void TASK_TURN_PED_TO_FACE_ENTITY(int ped, int targetEntity, int duration, float p3, float p4, float p5) { Function.Call(0x5AD23D40115353AC, ped, targetEntity, duration, p3, p4, p5); }
		public static void TASK_AIM_GUN_AT_COORD(int ped, float x, float y, float z, int time, BOOL p5, BOOL p6) { Function.Call(0x6671F3EEC681BDA1, ped, x, y, z, time, p5, p6); }
		public static void TASK_AIM_AT_COORD(int ped, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6) { Function.Call(0x4AF1D73861212F52, ped, p1, p2, p3, p4, p5, p6); }
		public static void TASK_AIM_AT_ENTITY(int ped, Any p1, Any p2, Any p3, Any p4) { Function.Call(0xCF7569BD0FB480A0, ped, p1, p2, p3, p4); }
		public static void TASK_SHOOT_AT_COORD(int ped, float x, float y, float z, int duration, Hash firingPattern, Any p6) { Function.Call(0x46A6CC01E0826106, ped, x, y, z, duration, firingPattern, p6); }
		public static void TASK_SHUFFLE_TO_NEXT_VEHICLE_SEAT(int ped, int vehicle) { Function.Call(0x7AA80209BDA643EB, ped, vehicle); }
		public static void CLEAR_PED_TASKS(int ped, BOOL p1, BOOL p2) { Function.Call(0xE1EF3C1216AFF2CD, ped, p1, p2); }
		public static void _0x1A7D63CB1B0BB223(Any p0) { Function.Call(0x1A7D63CB1B0BB223, p0); }
		public static void _0xB2D15D3551FE4FAE(Any p0) { Function.Call(0xB2D15D3551FE4FAE, p0); }
		public static void _0xDF94844D474F31E5(int ped) { Function.Call(0xDF94844D474F31E5, ped); }
		public static void _0xEBA2081E0A5F4D17(Any p0) { Function.Call(0xEBA2081E0A5F4D17, p0); }
		public static void _0x141BC64C8D7C5529(int vehicle) { Function.Call(0x141BC64C8D7C5529, vehicle); }
		public static void CLEAR_PED_SECONDARY_TASK(int ped) { Function.Call(0x176CECF6F920D707, ped); }
		public static void TASK_EVERYONE_LEAVE_VEHICLE_IN_ORDER(int vehicle, BOOL p1) { Function.Call(0x6F1C49F275BD25B3, vehicle, p1); }
		public static void TASK_INVESTIGATE(int ped, Any p1, Any p2, Any p3, Any p4, Any p5) { Function.Call(0x5C8514540D27FBFB, ped, p1, p2, p3, p4, p5); }
		public static void TASK_GOTO_ENTITY_OFFSET(int ped, int entity, Any p2, float x, float y, float z, int duration) { Function.Call(0xE39B4FF4FDEBDE27, ped, entity, p2, x, y, z, duration); }
		public static void TASK_GOTO_ENTITY_OFFSET_XY(int ped, int entity, int duration, float p3, float p4, float p5, float p6, BOOL p7) { Function.Call(0x338E7EF52B6095A9, ped, entity, duration, p3, p4, p5, p6, p7); }
		public static void TASK_GOTO_ENTITY_OFFSET_XYZ(int ped, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8) { Function.Call(0xFA6DA9D151769392, ped, p1, p2, p3, p4, p5, p6, p7, p8); }
		public static void TASK_GOTO_ENTITY_OFFSET_XY_AIMING(int ped, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8) { Function.Call(0x901BD69984400F62, ped, p1, p2, p3, p4, p5, p6, p7, p8); }
		public static void TASK_GOTO_ENTITY_OFFSET_XYZ_AIMING(int ped, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8, Any p9) { Function.Call(0x41B0832CA96B5351, ped, p1, p2, p3, p4, p5, p6, p7, p8, p9); }
		public static void TASK_FOLLOW_ENTITY_WHILE_AIMING_AT_ENTITY(int ped, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7) { Function.Call(0x2D532EAA142CF83F, ped, p1, p2, p3, p4, p5, p6, p7); }
		public static void TASK_TURN_PED_TO_FACE_COORD(int ped, float x, float y, float z, int duration) { Function.Call(0x1DDA930A0AC38571, ped, x, y, z, duration); }
		public static void TASK_VEHICLE_TEMP_ACTION(int driver, int vehicle, int action, int time) { Function.Call(0xC429DCEEB339E129, driver, vehicle, action, time); }
		public static void TASK_VEHICLE_MISSION(int driver, int vehicle, int vehicleTarget, int missionType, float p4, Any p5, float p6, float p7, BOOL DriveAgainstTraffic) { Function.Call(0x659427E0EF36BCDE, driver, vehicle, vehicleTarget, missionType, p4, p5, p6, p7, DriveAgainstTraffic); }
		public static void TASK_VEHICLE_DRIVE_TO_DESTINATION(int driver, int vehicle, float x, float y, float z, float speed, int drivingFlags, int p7, float stoppingRange1, float stoppingRange2, BOOL p10) { Function.Call(0x7F241A0D14354583, driver, vehicle, x, y, z, speed, drivingFlags, p7, stoppingRange1, stoppingRange2, p10); }
		public static void _TASK_VEHICLE_DRIVE_TO_DESTINATION_2(int vehicle, float x, float y, float z, float speed, int p5, int p6, float p7, float p8) { Function.Call(0x391073B9D3CCE2BA, vehicle, x, y, z, speed, p5, p6, p7, p8); }
		public static void _TASK_VEHICLE_FLEE_ON_CLEANUP(int vehicle, float p1, float p2, float p3, float speed, Hash type) { Function.Call(0x55CD5FDDD4335C1E, vehicle, p1, p2, p3, speed, type); }
		public static void TASK_VEHICLE_DRIVE_STRAIGHT_TO_POINT(int driver, int vehicle, float x, float y, float z, float p5, float p6, int flag) { Function.Call(0x089FF2FB965F0A29, driver, vehicle, x, y, z, p5, p6, flag); }
		public static void _TASK_VEHICLE_DRIVE_TO_POINT_2(int vehicle, float x, float y, float z, float p4, float p5, Any p6) { Function.Call(0x6524A8981E8BE7C9, vehicle, x, y, z, p4, p5, p6); }
		public static void _0x1D125814EBC517EB(Any p0, Any p1, Any p2, Any p3) { Function.Call(0x1D125814EBC517EB, p0, p1, p2, p3); }
		public static BOOL _0x583AE9AF9CEE0958(int vehicle, float x, float y, float z) { return Function.Call<BOOL>(0x583AE9AF9CEE0958, vehicle, x, y, z); }
		public static void TASK_VEHICLE_MISSION_PED_TARGET(int ped, int vehicle, int pedTarget, int mode, float maxSpeed, int drivingStyle, float minDistance, float p7, BOOL DriveAgainstTraffic) { Function.Call(0x9454528DF15D657A, ped, vehicle, pedTarget, mode, maxSpeed, drivingStyle, minDistance, p7, DriveAgainstTraffic); }
		public static void _0xA263ADBBC8056214(Any p0, Any p1) { Function.Call(0xA263ADBBC8056214, p0, p1); }
		public static void TASK_VEHICLE_ESCORT(int ped, int vehicle, int targetVehicle, int mode, float speed, int drivingStyle, float minDistance, int p7, float noRoadsDistance) { Function.Call(0x0FA6E4B75F302400, ped, vehicle, targetVehicle, mode, speed, drivingStyle, minDistance, p7, noRoadsDistance); }
		public static void TASK_BOAT_MISSION(int pedDriver, int boat, Any p2, Any p3, float x, float y, float z, Any p7, float maxSpeed, int drivingStyle, float p10, Any p11) { Function.Call(0x15C86013127CE63F, pedDriver, boat, p2, p3, x, y, z, p7, maxSpeed, drivingStyle, p10, p11); }
		public static void TASK_WEAPON(int ped) { Function.Call(0x7157B82D60E4BC46, ped); }
		public static void TASK_DRIVE_BY(int driverPed, int targetPed, int targetVehicle, float targetX, float targetY, float targetZ, float distanceToShoot, int pedAccuracy, BOOL p8, Hash firingPattern) { Function.Call(0x2F8AF0E82773A171, driverPed, targetPed, targetVehicle, targetX, targetY, targetZ, distanceToShoot, pedAccuracy, p8, firingPattern); }
		public static void SET_DRIVEBY_TASK_TARGET(int shootingPed, int targetPed, int targetVehicle, float x, float y, float z) { Function.Call(0xE5B302114D8162EE, shootingPed, targetPed, targetVehicle, x, y, z); }
		public static void CLEAR_DRIVEBY_TASK_UNDERNEATH_DRIVING_TASK(int ped) { Function.Call(0xC35B5CDB2824CF69, ped); }
		public static BOOL IS_DRIVEBY_TASK_UNDERNEATH_DRIVING_TASK(int ped) { return Function.Call<BOOL>(0x8785E6E40C7A8818, ped); }
		public static BOOL GET_IS_PED_AIMING_IN_THE_AIR(int ped) { return Function.Call<BOOL>(0x8785E6E40C7A8819, ped); }
		public static void _SET_PED_CLEAR_AIMING_IN_THE_AIR(int ped, Any p1) { Function.Call(0x34C0010188D7C54A, ped, p1); }
		public static BOOL IS_MOUNTED_WEAPON_TASK_UNDERNEATH_DRIVING_TASK(int ped) { return Function.Call<BOOL>(0xA320EF046186FA3B, ped); }
		public static void TASK_WARP_PED_INTO_VEHICLE(int ped, int vehicle, int seat) { Function.Call(0x9A7D091411C5F684, ped, vehicle, seat); }
		public static void TASK_SHOOT_AT_ENTITY(int entity, int targetEntity, int duration, Hash firingPattern, BOOL affectCockedState) { Function.Call(0x08DA95E8298AE772, entity, targetEntity, duration, firingPattern, affectCockedState); }
		public static unsafe void TASK_SHOOT_WITH_WEAPON(int ped, Any* args) { Function.Call(0x08AA95E8298AE772, ped, args); }
		public static void _0x2416EC2F31F75266(int entity, int targetEntity, int duration, Any p3, Any p4) { Function.Call(0x2416EC2F31F75266, entity, targetEntity, duration, p3, p4); }
		public static void _0x41323F4E0C4AE94B(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6) { Function.Call(0x41323F4E0C4AE94B, p0, p1, p2, p3, p4, p5, p6); }
		public static Any _0x5EA655F01D93667A(Any p0) { return Function.Call<Any>(0x5EA655F01D93667A, p0); }
		public static void TASK_CLIMB(int ped, BOOL unused) { Function.Call(0x89D9FCC2435112F1, ped, unused); }
		public static void _TASK_CLIMB_2(int ped, float heading) { Function.Call(0xDF1D85BCAF60D537, ped, heading); }
		public static void TASK_CLIMB_LADDER(int ped, Any p1, Any p2, Any p3) { Function.Call(0xB6C987F9285A3814, ped, p1, p2, p3); }
		public static void CLEAR_PED_TASKS_IMMEDIATELY(int ped, BOOL p1, BOOL resetCrouch) { Function.Call(0xAAA34F8A7CB32098, ped, p1, resetCrouch); }
		public static void TASK_PERFORM_SEQUENCE_FROM_PROGRESS(int ped, Any p1, Any p2, Any p3) { Function.Call(0x89221B16730234F0, ped, p1, p2, p3); }
		public static void SET_PED_DESIRED_MOVE_BLEND_RATIO(int ped, float p1) { Function.Call(0x1E982AC8716912C5, ped, p1); }
		public static float GET_PED_DESIRED_MOVE_BLEND_RATIO(int ped) { return Function.Call<float>(0x8517D4A6CA8513ED, ped); }
		public static void TASK_GOTO_ENTITY_AIMING(int ped, int target, float distanceToStopAt, float StartAimingDist) { Function.Call(0xA9DA48FAB8A76C12, ped, target, distanceToStopAt, StartAimingDist); }
		public static void TASK_SET_SPHERE_DEFENSIVE_AREA(int ped, float p1, float p2, float p3, float p4) { Function.Call(0x933C06518B52A9A4, ped, p1, p2, p3, p4); }
		public static void TASK_CLEAR_DEFENSIVE_AREA(int ped) { Function.Call(0x95A6C46A31D1917D, ped); }
		public static void TASK_PED_SLIDE_TO_COORD(int ped, float x, float y, float z, float heading, float p5) { Function.Call(0xD04FE6765D990A06, ped, x, y, z, heading, p5); }
		public static Any _0x9420FB11B8D77948(Any p0) { return Function.Call<Any>(0x9420FB11B8D77948, p0); }
		public static Any _0x6BA606AB3A83BC4D(Any p0) { return Function.Call<Any>(0x6BA606AB3A83BC4D, p0); }
		public static ScrHandle ADD_COVER_POINT(float p0, float p1, float p2, float p3, Any p4, Any p5, Any p6, BOOL p7) { return Function.Call<ScrHandle>(0xD5C12A75C7B9497F, p0, p1, p2, p3, p4, p5, p6, p7); }
		public static Any _0x59872EA4CBD11C56(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8) { return Function.Call<Any>(0x59872EA4CBD11C56, p0, p1, p2, p3, p4, p5, p6, p7, p8); }
		public static void REMOVE_COVER_POINT(ScrHandle coverpoint) { Function.Call(0xAE287C923D891715, coverpoint); }
		public static BOOL DOES_SCRIPTED_COVER_POINT_EXIST_AT_COORDS(Any p0, Any p1, Any p2, Any p3) { return Function.Call<BOOL>(0xA98B8E3C088E5A31, p0, p1, p2, p3); }
		public static Vector3 GET_SCRIPTED_COVER_POINT_COORDS(ScrHandle coverpoint) { return Function.Call<Vector3>(0x594A1028FC2A3E85, coverpoint); }
		public static Vector3 _0xE116F6F2DA2D777E(Any p0) { return Function.Call<Vector3>(0xE116F6F2DA2D777E, p0); }
		public static void _0x50AA09A0DA64E73C(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6) { Function.Call(0x50AA09A0DA64E73C, p0, p1, p2, p3, p4, p5, p6); }
		public static void _0xE5831AA1E2FD147C(Any p0) { Function.Call(0xE5831AA1E2FD147C, p0); }
		public static void TASK_COMBAT_PED(int ped, int targetPed, int p2, int p3) { Function.Call(0xF166E48407BAC484, ped, targetPed, p2, p3); }
		public static void TASK_COMBAT_PED_TIMED(int ped, int targetPed, int p2, Any p3) { Function.Call(0x944F30DCB7096BDE, ped, targetPed, p2, p3); }
		public static void _TASK_COMBAT_PED_3(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5) { Function.Call(0xC624414FA748B9BA, p0, p1, p2, p3, p4, p5); }
		public static void TASK_SEEK_COVER_FROM_POS(int ped, float x, float y, float z, Any p4, Any p5, Any p6, Any p7) { Function.Call(0x75AC2B60386D89F2, ped, x, y, z, p4, p5, p6, p7); }
		public static void TASK_SEEK_COVER_FROM_PED(int ped, Any p1, Any p2, Any p3, Any p4, Any p5) { Function.Call(0x84D32B3BEC531324, ped, p1, p2, p3, p4, p5); }
		public static void TASK_SEEK_COVER_TO_COVER_POINT(int ped, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8) { Function.Call(0xD43D95C7A869447F, ped, p1, p2, p3, p4, p5, p6, p7, p8); }
		public static void TASK_SEEK_COVER_TO_COORDS(int ped, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8, Any p9, Any p10) { Function.Call(0x39246A6958EF072C, ped, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10); }
		public static void TASK_PUT_PED_DIRECTLY_INTO_COVER(int ped, float x, float y, float z, int timeout, BOOL p5, float p6, Any p7, Any p8, ScrHandle coverpoint, BOOL p10, BOOL p11, Any p12) { Function.Call(0x4172393E6BE1FECE, ped, x, y, z, timeout, p5, p6, p7, p8, coverpoint, p10, p11, p12); }
		public static void _TASK_PUT_PED_DIRECTLY_INTO_COVER_FROM_COORDS(int ped, float x, float y, float z, float fromX, float fromY, float fromZ, int timeout, Any p8, Any p9, Any p10, Any p11, Any p12, Any p13, Any p14, Any p15, Any p16, Any p17) { Function.Call(0xDF8A5855B9F9A97B, ped, x, y, z, fromX, fromY, fromZ, timeout, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17); }
		public static void TASK_PUT_PED_DIRECTLY_INTO_MELEE(int ped, int meleeTarget, Hash meleeStyle, float p3, float animBlendRatio, BOOL p5, int p6) { Function.Call(0x1C6CD14A876FFE39, ped, meleeTarget, meleeStyle, p3, animBlendRatio, p5, p6); }
		public static void TASK_PUT_PED_DIRECTLY_INTO_GRAPPLE(int ped, int grappleTarget, Hash grappleStyle, float p3, float p4, BOOL p5, int p6) { Function.Call(0xA05F3F20889D7A5B, ped, grappleTarget, grappleStyle, p3, p4, p5, p6); }
		public static void TASK_COMPANION_AMBIENT(int ped, Any p1) { Function.Call(0xE017CF6E2527FE4F, ped, p1); }
		public static void _0x098036CAB8373D36(Any p0) { Function.Call(0x098036CAB8373D36, p0); }
		public static void _0x10C44F633E2D6D9E(Any p0) { Function.Call(0x10C44F633E2D6D9E, p0); }
		public static void _0x7FB78B2199C10E92(Any p0) { Function.Call(0x7FB78B2199C10E92, p0); }
		public static void TASK_GUARD(int ped, Any p1, Any p2) { Function.Call(0xB9FB242EACCAF30F, ped, p1, p2); }
		public static void TASK_GUARD_CURRENT_POSITION(int ped, float p1, float p2, BOOL p3) { Function.Call(0x4A58A47A72E3FCB4, ped, p1, p2, p3); }
		public static void _TASK_GUARD_ASSIGNED_DEFENSIVE_AREA_2(int ped, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7) { Function.Call(0x1FC9B33976BACD6C, ped, p1, p2, p3, p4, p5, p6, p7); }
		public static void TASK_GUARD_ASSIGNED_DEFENSIVE_AREA(int ped, float p1, float p2, float p3, float p4, float p5, Any p6) { Function.Call(0xD2A207EEBDF9889B, ped, p1, p2, p3, p4, p5, p6); }
		public static void TASK_STAND_GUARD(int ped, float x, float y, float z, float heading, string scenarioName) { Function.Call(0xAE032F8BBA959E90, ped, x, y, z, heading, scenarioName); }
		public static void SET_DRIVE_TASK_CRUISE_SPEED(int driver, float cruiseSpeed) { Function.Call(0x5C9B84BD7D31D908, driver, cruiseSpeed); }
		public static void SET_DRIVE_TASK_MAX_CRUISE_SPEED(int ped, float maxCruiseSpeed) { Function.Call(0x404A5AA9B9F0B746, ped, maxCruiseSpeed); }
		public static void ADD_COVER_BLOCKING_AREA(float playerX, float playerY, float playerZ, float radiusX, float radiusY, float radiusZ, BOOL p6, BOOL p7, BOOL p8, BOOL p9) { Function.Call(0x45C597097DD7CB81, playerX, playerY, playerZ, radiusX, radiusY, radiusZ, p6, p7, p8, p9); }
		public static void _ADD_COVER_BLOCKING_VOLUME(Volume volume, BOOL p1, BOOL p2, BOOL p3, BOOL p4) { Function.Call(0xEB2ED1DC3AEC0654, volume, p1, p2, p3, p4); }
		public static void REMOVE_ALL_COVER_BLOCKING_AREAS() { Function.Call(0xDB6708C0B46F56D8); }
		public static void _0x2A10538D0A005E81(Any p0, Any p1) { Function.Call(0x2A10538D0A005E81, p0, p1); }
		public static void _0x4F57397388E1DFF8() { Function.Call(0x4F57397388E1DFF8); }
		public static void TASK_ROB_PED(int ped, Any p1, Any p2, Any p3, Any p4) { Function.Call(0x7BB967F85D8CCBDB, ped, p1, p2, p3, p4); }
		public static BOOL _0xBEDBE39B5FD98FD6(int ped) { return Function.Call<BOOL>(0xBEDBE39B5FD98FD6, ped); }
		public static int CREATE_SCENARIO_POINT_HASH(Hash scenarioHash, float x, float y, float z, float heading, Any p5, Any p6, BOOL p7) { return Function.Call<int>(0x94B745CE41DB58A1, scenarioHash, x, y, z, heading, p5, p6, p7); }
		public static int CREATE_SCENARIO_POINT_HASH_ATTACHED_TO_ENTITY(int entity, Hash scenarioHash, float x, float y, float z, float heading, Any p6, Any p7, BOOL p8) { return Function.Call<int>(0x794AB1379A74064D, entity, scenarioHash, x, y, z, heading, p6, p7, p8); }
		public static BOOL _DOES_SCENARIO_POINT_HAVE_PROPS(int scenario) { return Function.Call<BOOL>(0xEA31F199A73801D3, scenario); }
		public static int GET_PROP_FOR_SCENARIO_POINT(int scenarioPoint, string name) { return Function.Call<int>(0x295514F198EFD0CA, scenarioPoint, name); }
		public static BOOL _ASSOCIATE_PROP_WITH_SCENARIO(int scenario, int entity, string propName, BOOL p3) { return Function.Call<BOOL>(0x8360C47380B6F351, scenario, entity, propName, p3); }
		public static void _SET_SCENARIO_POINT_FLAG(int scenario, int flag, BOOL value) { Function.Call(0x5AF19B6CC2115D34, scenario, flag, value); }
		public static BOOL _IS_SCENARIO_POINT_FLAG_SET(int scenario, int flag) { return Function.Call<BOOL>(0x8569C38D2FB80650, scenario, flag); }
		public static void _0xADC45010BC17AF0E(Any p0, Any p1) { Function.Call(0xADC45010BC17AF0E, p0, p1); }
		public static Any _0x974DA3408DEC4E79(Any p0) { return Function.Call<Any>(0x974DA3408DEC4E79, p0); }
		public static BOOL _DISASSOCIATE_PROP_FROM_SCENARIO(int scenario, string propName) { return Function.Call<BOOL>(0x6EF4E31B4D5D2DA0, scenario, propName); }
		public static BOOL DOES_SCENARIO_POINT_EXIST(int scenario) { return Function.Call<BOOL>(0x841475AC96E794D1, scenario); }
		public static Any _0x22CD2C33ED4467A1(Any p0) { return Function.Call<Any>(0x22CD2C33ED4467A1, p0); }
		public static int _GET_SCENARIO_POINT_ENTITY(int scenario) { return Function.Call<int>(0x7467165EE97D3C68, scenario); }
		public static int _GET_PED_USING_SCENARIO_POINT(int scenario) { return Function.Call<int>(0x5BA659955369B0E2, scenario); }
		public static Vector3 _GET_SCENARIO_POINT_COORDS(int scenario, BOOL p1) { return Function.Call<Vector3>(0xA8452DD321607029, scenario, p1); }
		public static Vector3 _0x91CB5E431F579BA1(Any p0) { return Function.Call<Vector3>(0x91CB5E431F579BA1, p0); }
		public static Any _0x370F57C47F68EBCA(Any p0) { return Function.Call<Any>(0x370F57C47F68EBCA, p0); }
		public static float _GET_SCENARIO_POINT_HEADING(int scenario, BOOL p1) { return Function.Call<float>(0xB93EA7184BAA85C3, scenario, p1); }
		public static float _GET_SCENARIO_POINT_RADIUS(int scenario) { return Function.Call<float>(0x6718F40313A2B5A6, scenario); }
		public static void _SET_SCENARIO_POINT_COORDS(int scenario, float xPos, float yPos, float zPos, BOOL p4) { Function.Call(0x2056AB38DF06825C, scenario, xPos, yPos, zPos, p4); }
		public static void _SET_SCENARIO_POINT_HEADING(int scenario, float heading, BOOL p2) { Function.Call(0xD3A0DA8F91612C6E, scenario, heading, p2); }
		public static void _SET_SCENARIO_POINT_RADIUS(int scenario, float radius) { Function.Call(0xC47D9080A9A8856A, scenario, radius); }
		public static void _0xA7479FB665361EDB(Any p0, Any p1) { Function.Call(0xA7479FB665361EDB, p0, p1); }
		public static void _0xE69FDA40AAC3EFC0(Any p0, Any p1) { Function.Call(0xE69FDA40AAC3EFC0, p0, p1); }
		public static unsafe int GET_SCENARIO_POINTS_IN_AREA(float posX, float posY, float posZ, float radius, Any* scenariosInRadius, int size) { return Function.Call<int>(0x345EC3B7EBDE1CB5, posX, posY, posZ, radius, scenariosInRadius, size); }
		public static Any _0xEFD875C2791EBEFD(Any p0, Any p1, Any p2, Any p3) { return Function.Call<Any>(0xEFD875C2791EBEFD, p0, p1, p2, p3); }
		public static Any _0x152664AA3188B193(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5) { return Function.Call<Any>(0x152664AA3188B193, p0, p1, p2, p3, p4, p5); }
		public static Any _0xE7BBC4E56B989449(Any p0, Any p1, Any p2) { return Function.Call<Any>(0xE7BBC4E56B989449, p0, p1, p2); }
		public static int _GET_SCENARIO_POINT_PED_IS_USING(int ped, BOOL p1) { return Function.Call<int>(0xDF7993356F52359A, ped, p1); }
		public static Any GET_RANSACK_SCENARIO_POINT_PED_IS_USING(int ped) { return Function.Call<Any>(0xD04241BBF6D03A5E, ped); }
		public static void _SET_SCENARIO_CONTAINER_OPENING_STATE(int entity, BOOL open) { Function.Call(0x188F8071F244B9B8, entity, open); }
		public static Any _0xA9E7672F8C6C6F74(Any p0) { return Function.Call<Any>(0xA9E7672F8C6C6F74, p0); }
		public static Any _0x0A98A362C5A19A43(Any p0) { return Function.Call<Any>(0x0A98A362C5A19A43, p0); }
		public static Any _0x849791EBBDBA0362(Any p0) { return Function.Call<Any>(0x849791EBBDBA0362, p0); }
		public static Any _0x640A602946A8C972(Any p0) { return Function.Call<Any>(0x640A602946A8C972, p0); }
		public static Any _0x01AF8A3729231A43(Any p0) { return Function.Call<Any>(0x01AF8A3729231A43, p0); }
		public static BOOL _GET_SCENARIO_CONTAINER_OPENING_STATE(int entity) { return Function.Call<BOOL>(0xB219612B5568E9EC, entity); }
		public static void _RESET_SCENARIO_FOR_ENTITY(int scenario, int entity) { Function.Call(0x2E20878FD208A68E, scenario, entity); }
		public static void _0x4161648394262FDF(Any p0, Any p1, Any p2, Any p3) { Function.Call(0x4161648394262FDF, p0, p1, p2, p3); }
		public static void _0x9C8F42A5D1859DC1(Any p0) { Function.Call(0x9C8F42A5D1859DC1, p0); }
		public static void _DELETE_SCENARIO_POINT(int scenario) { Function.Call(0x81948DFE4F5A0283, scenario); }
		public static void TASK_USE_SCENARIO_POINT(int ped, int scenario, string conditionalAnim, int p3, BOOL p4, BOOL p5, Hash p6, BOOL p7, float p8, BOOL p9) { Function.Call(0xCCDAE6324B6A821C, ped, scenario, conditionalAnim, p3, p4, p5, p6, p7, p8, p9); }
		public static void _TASK_USE_SCENARIO_POINT_2(int ped, int ped2, Any p2, string p3, int p4, Hash p5, float p6, BOOL p7) { Function.Call(0x0F6641449DD86FBE, ped, ped2, p2, p3, p4, p5, p6, p7); }
		public static void TASK_START_SCENARIO_IN_PLACE_HASH(int ped, Hash scenarioHash, int duration, BOOL playEnterAnim, Hash conditionalHash, float heading, BOOL p6) { Function.Call(0x524B54361229154F, ped, scenarioHash, duration, playEnterAnim, conditionalHash, heading, p6); }
		public static void _TASK_START_SCENARIO_IN_PLACE_2(int ped, Any p1, string p2, int p3, BOOL p4, float p5, BOOL p6) { Function.Call(0xA917E39F2CEFD215, ped, p1, p2, p3, p4, p5, p6); }
		public static void TASK_START_SCENARIO_AT_POSITION(int ped, Hash scenarioHash, float x, float y, float z, float heading, int duration, BOOL sittingScenario, BOOL teleport, string p9, float p10, BOOL p11) { Function.Call(0x4D1F61FC34AF3CD1, ped, scenarioHash, x, y, z, heading, duration, sittingScenario, teleport, p9, p10, p11); }
		public static Any _0xF97F462779B31786(Any p0) { return Function.Call<Any>(0xF97F462779B31786, p0); }
		public static Any _0x6C269F673C47031E(Any p0) { return Function.Call<Any>(0x6C269F673C47031E, p0); }
		public static void _0x9667CCE29BFA0780(Any p0) { Function.Call(0x9667CCE29BFA0780, p0); }
		public static Any _0x00FFE0F85253C572(Any p0) { return Function.Call<Any>(0x00FFE0F85253C572, p0); }
		public static void _TASK_USE_NEAREST_SCENARIO_TO_COORD(int ped, float x, float y, float z, float distance, int duration, BOOL p6, BOOL p7, BOOL p8, BOOL p9) { Function.Call(0x322BFDEA666E2B0E, ped, x, y, z, distance, duration, p6, p7, p8, p9); }
		public static void TASK_USE_NEAREST_SCENARIO_TO_COORD_WARP(int ped, float x, float y, float z, float distance, int duration, BOOL p6, BOOL p7, BOOL p8, BOOL p9) { Function.Call(0x58E2E0F23F6B76C3, ped, x, y, z, distance, duration, p6, p7, p8, p9); }
		public static void TASK_USE_NEAREST_TRAIN_SCENARIO_TO_COORD_WARP(int ped, float x, float y, float z, float distance) { Function.Call(0x3774B03456DD6106, ped, x, y, z, distance); }
		public static void TASK_USE_NEAREST_SCENARIO_CHAIN_TO_COORD(int ped, float x, float y, float z, float distance, BOOL p5, BOOL p6, BOOL p7, BOOL p8) { Function.Call(0x9FDA1B3D7E7028B3, ped, x, y, z, distance, p5, p6, p7, p8); }
		public static void TASK_USE_NEAREST_SCENARIO_CHAIN_TO_COORD_WARP(int ped, float x, float y, float z, float distance, BOOL p5, BOOL p6, BOOL p7, BOOL p8) { Function.Call(0x97A28E63F0BA5631, ped, x, y, z, distance, p5, p6, p7, p8); }
		public static Any _0xFDECCA06E8B81346(Any p0) { return Function.Call<Any>(0xFDECCA06E8B81346, p0); }
		public static Any _0x2D657B10F211C572(int ped, float p1) { return Function.Call<Any>(0x2D657B10F211C572, ped, p1); }
		public static void TASK_RIDE_TRAIN(int ped, int train, int scenarioPoint, Hash scenarioHash) { Function.Call(0x37FB1C870E2EC2C6, ped, train, scenarioPoint, scenarioHash); }
		public static Any _0x79197F7D2BB5E73A(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5) { return Function.Call<Any>(0x79197F7D2BB5E73A, p0, p1, p2, p3, p4, p5); }
		public static BOOL DOES_SCENARIO_EXIST_IN_AREA(float x, float y, float z, float radius, BOOL p4, Any p5, BOOL p6) { return Function.Call<BOOL>(0x5A59271FFADD33C1, x, y, z, radius, p4, p5, p6); }
		public static BOOL DOES_SCENARIO_OF_TYPE_EXIST_IN_AREA_HASH(float x, float y, float z, Hash typeHash, float radius, BOOL p5) { return Function.Call<BOOL>(0x6EEAD6AF637DA752, x, y, z, typeHash, radius, p5); }
		public static int FIND_SCENARIO_OF_TYPE_HASH(float xPos, float yPos, float zPos, Hash scenarioType, float distance, Any p5, BOOL p6) { return Function.Call<int>(0xF533D68FF970D190, xPos, yPos, zPos, scenarioType, distance, p5, p6); }
		public static void _0x0D322AEF8878B8FE(Any p0, Any p1) { Function.Call(0x0D322AEF8878B8FE, p0, p1); }
		public static Any _0xD508FA229F1C4900(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5) { return Function.Call<Any>(0xD508FA229F1C4900, p0, p1, p2, p3, p4, p5); }
		public static void _0xB8E213D02F37947D(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6) { Function.Call(0xB8E213D02F37947D, p0, p1, p2, p3, p4, p5, p6); }
		public static BOOL IS_SCENARIO_OCCUPIED(float p0, float p1, float p2, float p3, BOOL p4) { return Function.Call<BOOL>(0x788756D73AC2E07C, p0, p1, p2, p3, p4); }
		public static Any _0x1ACBC313966C21F3(int scenario) { return Function.Call<Any>(0x1ACBC313966C21F3, scenario); }
		public static BOOL PED_HAS_USE_SCENARIO_TASK(int ped) { return Function.Call<BOOL>(0x295E3CCEC879CCD7, ped); }
		public static BOOL _PED_IS_IN_SCENARIO_BASE(int ped) { return Function.Call<BOOL>(0x02EBBB3989B7E695, ped); }
		public static Any _0x90703A8F75EE4ABD(Any p0, Any p1) { return Function.Call<Any>(0x90703A8F75EE4ABD, p0, p1); }
		public static void _0xD999E379265A4501(Any p0, Any p1, Any p2) { Function.Call(0xD999E379265A4501, p0, p1, p2); }
		public static void PLAY_ANIM_ON_RUNNING_SCENARIO(int ped, string animDict, string animName) { Function.Call(0x748040460F8DF5DC, ped, animDict, animName); }
		public static Any _0x74F0209674864CBD() { return Function.Call<Any>(0x74F0209674864CBD); }
		public static Any _0xE1C105E6BBA48270() { return Function.Call<Any>(0xE1C105E6BBA48270); }
		public static Any _0x1AC5A8AB50CFAA33(Any p0) { return Function.Call<Any>(0x1AC5A8AB50CFAA33, p0); }
		public static void _0xBEEFBB608D2AA68A(Any p0) { Function.Call(0xBEEFBB608D2AA68A, p0); }
		public static void _0x19BC99C678FBA139(Any p0, Any p1, Any p2) { Function.Call(0x19BC99C678FBA139, p0, p1, p2); }
		public static void _0x5D9B0BAAF04CF65B(Any p0, Any p1, Any p2, Any p3) { Function.Call(0x5D9B0BAAF04CF65B, p0, p1, p2, p3); }
		public static void _0x9B6A58FDB0024F12(Any p0, Any p1) { Function.Call(0x9B6A58FDB0024F12, p0, p1); }
		public static void _0xBC3F847AE2C3DC65(Any p0, Any p1) { Function.Call(0xBC3F847AE2C3DC65, p0, p1); }
		public static void _0x450080DDEDB91258(Any p0, Any p1) { Function.Call(0x450080DDEDB91258, p0, p1); }
		public static void _0x954451EA2D2120FB(Any p0, Any p1) { Function.Call(0x954451EA2D2120FB, p0, p1); }
		public static void _0x0F4F6C4CE471259D(Any p0, Any p1) { Function.Call(0x0F4F6C4CE471259D, p0, p1); }
		public static void _0xB8E3486D107F4194(Any p0, Any p1) { Function.Call(0xB8E3486D107F4194, p0, p1); }
		public static void _0x827A58CED9D4D5B4(Any p0, Any p1) { Function.Call(0x827A58CED9D4D5B4, p0, p1); }
		public static void _0x4A7D73989F52EB37(Any p0, Any p1) { Function.Call(0x4A7D73989F52EB37, p0, p1); }
		public static void _0xB79817DB31FF72B9(Any p0, Any p1) { Function.Call(0xB79817DB31FF72B9, p0, p1); }
		public static void _0x65D281985F2BDFC2(Any p0, Any p1) { Function.Call(0x65D281985F2BDFC2, p0, p1); }
		public static void _0x885D19AC2B6FBFF4(Any p0, Any p1) { Function.Call(0x885D19AC2B6FBFF4, p0, p1); }
		public static void _0x2064B33F6E6B92D4(Any p0, Any p1, Any p2, Any p3) { Function.Call(0x2064B33F6E6B92D4, p0, p1, p2, p3); }
		public static void _0xCE4E669400E5F8AA(Any p0, Any p1, Any p2, Any p3) { Function.Call(0xCE4E669400E5F8AA, p0, p1, p2, p3); }
		public static void _0x2EB977293923C723(Any p0, Any p1) { Function.Call(0x2EB977293923C723, p0, p1); }
		public static void _0xE9225354FB7437A7(Any p0, Any p1) { Function.Call(0xE9225354FB7437A7, p0, p1); }
		public static void _0x764DB5A48390FBAD(Any p0, Any p1) { Function.Call(0x764DB5A48390FBAD, p0, p1); }
		public static void _0x8F8C84363810691A(Any p0, Any p1) { Function.Call(0x8F8C84363810691A, p0, p1); }
		public static void _0xFF8AFCA532B500D4(Any p0, Any p1) { Function.Call(0xFF8AFCA532B500D4, p0, p1); }
		public static Any _0xFE5D28B9B7837CC1(Any p0, Any p1, Any p2, Any p3) { return Function.Call<Any>(0xFE5D28B9B7837CC1, p0, p1, p2, p3); }
		public static void _0x2B8AF29A78024BD3(Any p0) { Function.Call(0x2B8AF29A78024BD3, p0); }
		public static Any _0x0365000D8BF86531(Any p0) { return Function.Call<Any>(0x0365000D8BF86531, p0); }
		public static Vector3 _0x865732725536EE39(Any p0) { return Function.Call<Vector3>(0x865732725536EE39, p0); }
		public static void _0x0E184495B27BB57D() { Function.Call(0x0E184495B27BB57D); }
		public static BOOL DOES_SCENARIO_GROUP_EXIST(string scenarioGroup) { return Function.Call<BOOL>(0xF9034C136C9E00D3, scenarioGroup); }
		public static BOOL _DOES_SCENARIO_GROUP_EXIST_HASH(Hash scenarioGroup) { return Function.Call<BOOL>(0x76E98B52369A289C, scenarioGroup); }
		public static BOOL IS_SCENARIO_GROUP_ENABLED(string scenarioGroup) { return Function.Call<BOOL>(0x367A09DED4E05B99, scenarioGroup); }
		public static BOOL _IS_SCENARIO_GROUP_ENABLED_HASH(Hash scenarioGroup) { return Function.Call<BOOL>(0xDCC374913DE6AAA6, scenarioGroup); }
		public static void SET_SCENARIO_GROUP_ENABLED(string scenarioGroup, BOOL toggle) { Function.Call(0x02C8E5B49848664E, scenarioGroup, toggle); }
		public static void _SET_SCENARIO_GROUP_ENABLED_HASH(Hash scenarioGroup, BOOL toggle) { Function.Call(0x9925EDDB6EAB88CD, scenarioGroup, toggle); }
		public static void RESET_SCENARIO_GROUPS_ENABLED() { Function.Call(0xDD902D0349AFAD3A); }
		public static void _0x358A1A751B335A11(Any p0) { Function.Call(0x358A1A751B335A11, p0); }
		public static void FORCE_SCENARIO_GROUP_PRIORITY(Any p0, Any p1) { Function.Call(0x444C910A5058E568, p0, p1); }
		public static Any _0xE55478C5EDF70AC2(Any p0) { return Function.Call<Any>(0xE55478C5EDF70AC2, p0); }
		public static BOOL _IS_SCENARIO_POINT_ACTIVE(int scenario) { return Function.Call<BOOL>(0x0CC36D4156006509, scenario); }
		public static void _SET_SCENARIO_POINT_ACTIVE(int scenario, BOOL active) { Function.Call(0xEEE4829304F93EEE, scenario, active); }
		public static void _RESET_SCENARIO_SCRIPT(int scenario) { Function.Call(0x5A40040BB5AE3EA2, scenario); }
		public static BOOL IS_SCENARIO_TYPE_ENABLED(string scenarioType) { return Function.Call<BOOL>(0x3A815DB3EA088722, scenarioType); }
		public static void SET_SCENARIO_TYPE_ENABLED(string scenarioType, BOOL toggle) { Function.Call(0xEB47EC4E34FB7EE1, scenarioType, toggle); }
		public static void _SET_SCENARIO_TYPE_ENABLED_HASH(Hash scenarioType, BOOL toggle) { Function.Call(0xD00E50E673802D71, scenarioType, toggle); }
		public static void RESET_SCENARIO_TYPES_ENABLED() { Function.Call(0x0D40EE2A7F2B2D6D); }
		public static int _GET_SCENARIO_POINT_TYPE_PED_IS_USING(int ped) { return Function.Call<int>(0x2D0571BB55879DA2, ped); }
		public static Hash _GET_SCENARIO_POINT_TYPE(int scenario) { return Function.Call<Hash>(0xA92450B5AE687AAF, scenario); }
		public static BOOL IS_PED_ACTIVE_IN_SCENARIO(int ped, int scenario) { return Function.Call<BOOL>(0xAA135F9482C82CC3, ped, scenario); }
		public static BOOL IS_PED_EXITING_SCENARIO(int ped, BOOL p1) { return Function.Call<BOOL>(0x0C3CB2E600C8977D, ped, p1); }
		public static Any _0x2C497BDEF897C6DF(Any p0) { return Function.Call<Any>(0x2C497BDEF897C6DF, p0); }
		public static void TASK_COMBAT_HATED_TARGETS_IN_AREA(int ped, float x, float y, float z, float radius, int flags, Any p6) { Function.Call(0x4CF5F55DAC3280A0, ped, x, y, z, radius, flags, p6); }
		public static void TASK_COMBAT_HATED_TARGETS_NO_LOS_TEST(int ped, float radius) { Function.Call(0xB5BC69D9C4060BC3, ped, radius); }
		public static void TASK_COMBAT_HATED_TARGETS_AROUND_PED(int ped, float radius, int flags, Any p3) { Function.Call(0x7BF835BB9E2698C8, ped, radius, flags, p3); }
		public static void TASK_COMBAT_HATED_TARGETS_AROUND_PED_TIMED(int ped, float radius, float p2, Any p3) { Function.Call(0x2BBA30B854534A0C, ped, radius, p2, p3); }
		public static void TASK_COMBAT_HATED_TARGETS(int ped, float radius) { Function.Call(0x8182B561A29BD597, ped, radius); }
		public static void _0x30B391915538EBE2(Any p0) { Function.Call(0x30B391915538EBE2, p0); }
		public static void TASK_THROW_PROJECTILE(int ped, Any p1, Any p2, Any p3) { Function.Call(0x7285951DBF6B5A51, ped, p1, p2, p3); }
		public static void _TASK_THROW_PROJECTILE_2(Any p0, Any p1, Any p2, Any p3) { Function.Call(0x7282356DFF6B5A51, p0, p1, p2, p3); }
		public static void TASK_WHISTLE_ANIM(int ped, Hash audPedWhistleType, Hash p2) { Function.Call(0xD6401A1B2F63BED6, ped, audPedWhistleType, p2); }
		public static void TASK_SWAP_WEAPON(int ped, Any p1, Any p2, Any p3, Any p4) { Function.Call(0xA21C51255B205245, ped, p1, p2, p3, p4); }
		public static void _0x0000A8ACDC2E1B6A(Any p0, Any p1) { Function.Call(0x0000A8ACDC2E1B6A, p0, p1); }
		public static void TASK_RELOAD_WEAPON(int ped, BOOL unused) { Function.Call(0x62D2916F56B9CD2D, ped, unused); }
		public static void TASK_PICK_UP_WEAPON(int ped, Any p1) { Function.Call(0x55B0ECFD98596624, ped, p1); }
		public static BOOL IS_PED_GETTING_UP(int ped) { return Function.Call<BOOL>(0x2A74E1D5F2F00EEC, ped); }
		public static void TASK_ANIMAL_WRITHE(int ped, Any p1, Any p2) { Function.Call(0x8C038A39C4A4B6D6, ped, p1, p2); }
		public static void _TASK_ANIMAL_BLEED_OUT(int ped, int killer, BOOL p2, Hash weaponHash, int p4, int p5) { Function.Call(0x30A768C30D385EC5, ped, killer, p2, weaponHash, p4, p5); }
		public static BOOL IS_PED_IN_WRITHE(int ped) { return Function.Call<BOOL>(0xDEB6D52126E7D640, ped); }
		public static Any _0x3F8387DB1B9F31B7(Any p0, Any p1) { return Function.Call<Any>(0x3F8387DB1B9F31B7, p0, p1); }
		public static Any _0x756C7B4C43DF0422(Any p0) { return Function.Call<Any>(0x756C7B4C43DF0422, p0); }
		public static Any _0x351F74ED6177EBE7() { return Function.Call<Any>(0x351F74ED6177EBE7); }
		public static Any _0x6C50B9DCCCA70023(Any p0) { return Function.Call<Any>(0x6C50B9DCCCA70023, p0); }
		public static void TASK_REVIVE_TARGET(int ped, int reviver, Hash tool) { Function.Call(0x356088527D9EBAAD, ped, reviver, tool); }
		public static void OPEN_PATROL_ROUTE(string patrolRoute) { Function.Call(0xA36BFB5EE89F3D82, patrolRoute); }
		public static void CLOSE_PATROL_ROUTE() { Function.Call(0xB043ECA801B8CBC1); }
		public static void ADD_PATROL_ROUTE_NODE(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8, Any p9) { Function.Call(0x8EDF950167586B7C, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9); }
		public static void ADD_PATROL_ROUTE_LINK(Any p0, Any p1) { Function.Call(0x23083260DEC3A551, p0, p1); }
		public static void CREATE_PATROL_ROUTE() { Function.Call(0xAF8A443CCC8018DC); }
		public static void DELETE_PATROL_ROUTE(string patrolRoute) { Function.Call(0x7767DD9D65E91319, patrolRoute); }
		public static Any _0x643FD1556F621772(Any p0, Any p1, Any p2) { return Function.Call<Any>(0x643FD1556F621772, p0, p1, p2); }
		public static void TASK_PATROL(int ped, string patrolRoute, Any p2, BOOL p3, BOOL p4) { Function.Call(0xBDA5DF49D080FE4E, ped, patrolRoute, p2, p3, p4); }
		public static void _TASK_PATROL_2(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7) { Function.Call(0x964B06C88E4C86DB, p0, p1, p2, p3, p4, p5, p6, p7); }
		public static void TASK_STAY_IN_COVER(int ped) { Function.Call(0xE5DA8615A6180789, ped); }
		public static void TASK_VEHICLE_SHOOT_AT_PED(int ped, int target, float p2) { Function.Call(0x10AB107B887214D8, ped, target, p2); }
		public static void TASK_VEHICLE_AIM_AT_PED(int ped, int target) { Function.Call(0xE41885592B08B097, ped, target); }
		public static void TASK_VEHICLE_SHOOT_AT_COORD(int ped, float x, float y, float z, float p4) { Function.Call(0x5190796ED39C9B6D, ped, x, y, z, p4); }
		public static void _0xAF2EF28CE3084505(Any p0, Any p1, Any p2, Any p3) { Function.Call(0xAF2EF28CE3084505, p0, p1, p2, p3); }
		public static void TASK_VEHICLE_AIM_AT_COORD(int ped, float x, float y, float z) { Function.Call(0x447C1E9EF844BC0F, ped, x, y, z); }
		public static void TASK_VEHICLE_GOTO_NAVMESH(int ped, int vehicle, float x, float y, float z, float speed, int behaviorFlag, float stoppingRange) { Function.Call(0x195AEEB13CEFE2EE, ped, vehicle, x, y, z, speed, behaviorFlag, stoppingRange); }
		public static void TASK_GO_TO_COORD_WHILE_AIMING_AT_COORD(int ped, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8, Any p9, Any p10, Any p11, Any p12, Any p13, Any p14, Any p15) { Function.Call(0x11315AB3385B8AC0, ped, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15); }
		public static void TASK_GO_TO_COORD_WHILE_AIMING_AT_COORD_USING_COMBAT_STYLE(int ped, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8, Any p9, Any p10, Any p11, Any p12, Any p13, Any p14, Any p15) { Function.Call(0x639C0425A0B4E77E, ped, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15); }
		public static void TASK_GO_TO_COORD_WHILE_AIMING_AT_ENTITY(int ped, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8, Any p9, Any p10, Any p11, Any p12, Any p13, Any p14) { Function.Call(0xB2A16444EAD9AE47, ped, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14); }
		public static void TASK_GO_TO_COORD_WHILE_AIMING_AT_ENTITY_USING_COMBAT_STYLE(int ped, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8, Any p9, Any p10, Any p11, Any p12, Any p13, Any p14) { Function.Call(0x78426D0982D083C9, ped, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14); }
		public static void TASK_GO_TO_ENTITY_WHILE_AIMING_AT_ENTITY(int ped, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8, Any p9, Any p10) { Function.Call(0x97465886D35210E9, ped, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10); }
		public static void TASK_GO_TO_ENTITY_WHILE_AIMING_AT_ENTITY_USING_COMBAT_STYLE(int ped, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8, Any p9, Any p10) { Function.Call(0xCEF0117C233026AD, ped, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10); }
		public static void TASK_GO_TO_COORD_AND_AIM_AT_HATED_ENTITIES_NEAR_COORD(int ped, float goToLocationX, float goToLocationY, float goToLocationZ, float focusLocationX, float focusLocationY, float focusLocationZ, float speed, BOOL shootAtEnemies, float distanceToStopAt, float noRoadsDistance, BOOL unkTrue, int unkFlag, int aimingFlag, Hash firingPattern) { Function.Call(0xA55547801EB331FC, ped, goToLocationX, goToLocationY, goToLocationZ, focusLocationX, focusLocationY, focusLocationZ, speed, shootAtEnemies, distanceToStopAt, noRoadsDistance, unkTrue, unkFlag, aimingFlag, firingPattern); }
		public static void TASK_GO_TO_COORD_AND_AIM_AT_HATED_ENTITIES_NEAR_COORD_USING_COMBAT_STYLE(int ped, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8, Any p9, Any p10, Any p11, Any p12, Any p13, Any p14) { Function.Call(0x87BD711FC31EA273, ped, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14); }
		public static void SET_HIGH_FALL_TASK(int ped, int p1, int p2, int p3) { Function.Call(0x8C825BDC7741D37C, ped, p1, p2, p3); }
		public static void _0x5217B7B6DB78E1F3(Any p0, Any p1, Any p2, Any p3, Any p4) { Function.Call(0x5217B7B6DB78E1F3, p0, p1, p2, p3, p4); }
		public static void REQUEST_WAYPOINT_RECORDING(string waypointRecording) { Function.Call(0x9EEFB62EB27B5792, waypointRecording); }
		public static BOOL GET_IS_WAYPOINT_RECORDING_LOADED(string waypointRecording) { return Function.Call<BOOL>(0xCB4E8BE8A0063C5D, waypointRecording); }
		public static void REMOVE_WAYPOINT_RECORDING(string waypointRecording) { Function.Call(0xFF1B8B4AA1C25DC8, waypointRecording); }
		public static void _0xF718931A82EEB898() { Function.Call(0xF718931A82EEB898); }
		public static unsafe BOOL WAYPOINT_RECORDING_GET_NUM_POINTS(string waypointRecording, int* points) { return Function.Call<BOOL>(0x5343532C01A07234, waypointRecording, points); }
		public static unsafe BOOL WAYPOINT_RECORDING_GET_COORD(string waypointRecording, int point, Vector3* coord) { return Function.Call<BOOL>(0x2FB897405C90B361, waypointRecording, point, coord); }
		public static float WAYPOINT_RECORDING_GET_SPEED_AT_POINT(string waypointRecording, int point) { return Function.Call<float>(0x005622AEBC33ACA9, waypointRecording, point); }
		public static unsafe BOOL WAYPOINT_RECORDING_GET_CLOSEST_WAYPOINT(string waypointRecording, float x, float y, float z, int* point) { return Function.Call<BOOL>(0xB629A298081F876F, waypointRecording, x, y, z, point); }
		public static void TASK_FOLLOW_WAYPOINT_RECORDING_ADVANCED(int ped, Any p1) { Function.Call(0x0CFC13EBC19BCA52, ped, p1); }
		public static void TASK_FOLLOW_WAYPOINT_RECORDING(int ped, string waypointRecording, int p2, int flag, int p4, BOOL p5, Any p6, int p7) { Function.Call(0x0759591819534F7B, ped, waypointRecording, p2, flag, p4, p5, p6, p7); }
		public static void TASK_FOLLOW_WAYPOINT_RECORDING_AT_OFFSET(int ped, string waypointRecording, float p2, int p3, int p4, int p5, BOOL p6) { Function.Call(0xBE9B0520BD7C445B, ped, waypointRecording, p2, p3, p4, p5, p6); }
		public static void TASK_FOLLOW_ENTITY_ALONG_WAYPOINT_RECORDING_AT_OFFSET(int ped0, int ped1, string waypointRecording, float p3, float p4, int p5, int p6, int p7, BOOL p8) { Function.Call(0x4D2B787BAE9AB760, ped0, ped1, waypointRecording, p3, p4, p5, p6, p7, p8); }
		public static BOOL IS_WAYPOINT_PLAYBACK_GOING_ON_FOR_PED(int ped, string waypointRecording) { return Function.Call<BOOL>(0xE03B3F2D3DC59B64, ped, waypointRecording); }
		public static int GET_PED_WAYPOINT_PROGRESS(int ped) { return Function.Call<int>(0x2720AAA75001E094, ped); }
		public static float GET_PED_WAYPOINT_DISTANCE(int ped) { return Function.Call<float>(0xE6A877C64CAF1BC5, ped); }
		public static Any SET_PED_WAYPOINT_ROUTE_OFFSET(int ped, float p1, float p2, float p3) { return Function.Call<Any>(0xED98E10B0AFCE4B4, ped, p1, p2, p3); }
		public static float GET_WAYPOINT_DISTANCE_ALONG_ROUTE(string waypointRecording, int p1) { return Function.Call<float>(0xA5B769058763E497, waypointRecording, p1); }
		public static float _0x3ACC128510142B9D(string waypointRecording, float x, float y, float z) { return Function.Call<float>(0x3ACC128510142B9D, waypointRecording, x, y, z); }
		public static BOOL WAYPOINT_PLAYBACK_GET_IS_PAUSED(int ped) { return Function.Call<BOOL>(0x701375A7D43F01CB, ped); }
		public static BOOL WAYPOINT_PLAYBACK_GET_IS_AIMING(int ped) { return Function.Call<BOOL>(0xD73A5D1F0325C71C, ped); }
		public static BOOL WAYPOINT_PLAYBACK_GET_IS_SHOOTING(int ped) { return Function.Call<BOOL>(0xA5B94DF8AF058F46, ped); }
		public static void WAYPOINT_PLAYBACK_PAUSE(int ped, Any p1, Any p2, Any p3) { Function.Call(0x0F342546AA06FED5, ped, p1, p2, p3); }
		public static void WAYPOINT_PLAYBACK_RESUME(int ped, BOOL p1, int p2, int p3) { Function.Call(0x244F70C84C547D2D, ped, p1, p2, p3); }
		public static void WAYPOINT_PLAYBACK_OVERRIDE_SPEED(int ped, float speed, Any p2, Any p3, Any p4) { Function.Call(0x7D7D2B47FA788E85, ped, speed, p2, p3, p4); }
		public static void WAYPOINT_PLAYBACK_USE_DEFAULT_SPEED(int ped) { Function.Call(0x6599D834B12D0800, ped); }
		public static float GET_PED_WAYPOINT_OVERRIDE_SPEED(int ped) { return Function.Call<float>(0xD39A2F3E7FCAFF08, ped); }
		public static void USE_WAYPOINT_RECORDING_AS_ASSISTED_MOVEMENT_ROUTE(string waypointRecording, BOOL p1, float p2, float p3, BOOL p4) { Function.Call(0x5A353B8E6B1095B5, waypointRecording, p1, p2, p3, p4); }
		public static void WAYPOINT_PLAYBACK_START_AIMING_AT_PED(Any p0, Any p1, Any p2, Any p3) { Function.Call(0x20E330937C399D29, p0, p1, p2, p3); }
		public static void WAYPOINT_PLAYBACK_START_AIMING_AT_ENTITY(Any p0, Any p1, Any p2, Any p3) { Function.Call(0x4F158205E0C74385, p0, p1, p2, p3); }
		public static void WAYPOINT_PLAYBACK_START_AIMING_AT_COORD(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5) { Function.Call(0x8968400D900ED8B3, p0, p1, p2, p3, p4, p5); }
		public static void WAYPOINT_PLAYBACK_START_SHOOTING_AT_PED(Any p0, Any p1, Any p2, Any p3, Any p4) { Function.Call(0xE70BA7B90F8390DC, p0, p1, p2, p3, p4); }
		public static void WAYPOINT_PLAYBACK_START_SHOOTING_AT_ENTITY(Any p0, Any p1, Any p2, Any p3, Any p4) { Function.Call(0x4AF458F71C1196D2, p0, p1, p2, p3, p4); }
		public static void WAYPOINT_PLAYBACK_START_SHOOTING_AT_COORD(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6) { Function.Call(0x057A25CFCC9DB671, p0, p1, p2, p3, p4, p5, p6); }
		public static void WAYPOINT_PLAYBACK_STOP_AIMING_OR_SHOOTING(Any p0) { Function.Call(0x47EFA040EBB8E2EA, p0); }
		public static void ASSISTED_MOVEMENT_REMOVE_ROUTE(string route) { Function.Call(0x3548536485DD792B, route); }
		public static unsafe BOOL _CREATE_WAYPOINT_PATH(string pathName, Any* p1, int nodes, int p3) { return Function.Call<BOOL>(0x5C885E0978B6AD60, pathName, p1, nodes, p3); }
		public static BOOL ASSISTED_MOVEMENT_IS_ROUTE_LOADED(string route) { return Function.Call<BOOL>(0x60F9A4393A21F741, route); }
		public static void ASSISTED_MOVEMENT_SET_ROUTE_PROPERTIES(string route, int props) { Function.Call(0xD5002D78B7162E1B, route, props); }
		public static void SET_ENABLE_SPEED_RESTRAIN_FOR_WAYPOINT_RECORDING_LEADER(Any p0, Any p1) { Function.Call(0x295F03DC97BEEBC1, p0, p1); }
		public static void SET_UP_SPEED_RESTRAIN_INFORMATION_FOR_PLAYER_FOLLOWER(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8) { Function.Call(0xB5C51DD544F14F58, p0, p1, p2, p3, p4, p5, p6, p7, p8); }
		public static void TASK_VEHICLE_FOLLOW_WAYPOINT_RECORDING(int ped, int vehicle, string waypointRecording, int drivingMode, Any p4, int eWaypoint, int flag, float p7, BOOL p8, float stoppingDist, Any p10) { Function.Call(0x3123FAA6DB1CF7ED, ped, vehicle, waypointRecording, drivingMode, p4, eWaypoint, flag, p7, p8, stoppingDist, p10); }
		public static void _TASK_VEHICLE_FOLLOW_WAYPOINT_RECORDING_2(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8, Any p9) { Function.Call(0x041D17A9E221AE30, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9); }
		public static BOOL IS_WAYPOINT_PLAYBACK_GOING_ON_FOR_VEHICLE(Any p0, Any p1) { return Function.Call<BOOL>(0xF5134943EA29868C, p0, p1); }
		public static int GET_VEHICLE_WAYPOINT_PROGRESS(int vehicle) { return Function.Call<int>(0x9824CFF8FC66E159, vehicle); }
		public static int GET_VEHICLE_WAYPOINT_TARGET_POINT(int vehicle) { return Function.Call<int>(0x416B62AC8B9E5BBD, vehicle); }
		public static void VEHICLE_WAYPOINT_PLAYBACK_PAUSE(int vehicle) { Function.Call(0x8A4E6AC373666BC5, vehicle); }
		public static Any VEHICLE_WAYPOINT_PLAYBACK_GET_IS_PAUSED(Any p0) { return Function.Call<Any>(0x4D6D30AB18B0B089, p0); }
		public static void VEHICLE_WAYPOINT_PLAYBACK_RESUME(int vehicle) { Function.Call(0xDC04FCAA7839D492, vehicle); }
		public static void VEHICLE_WAYPOINT_PLAYBACK_USE_DEFAULT_SPEED(int vehicle) { Function.Call(0x5CEB25A7D2848963, vehicle); }
		public static void VEHICLE_WAYPOINT_PLAYBACK_OVERRIDE_SPEED(int vehicle, float speed) { Function.Call(0x121F0593E0A431D7, vehicle, speed); }
		public static Any GET_VEHICLE_WAYPOINT_PLAYBACK_OVERRIDE_SPEED(Any p0) { return Function.Call<Any>(0x3DC971EB22F73447, p0); }
		public static void TASK_SET_BLOCKING_OF_NON_TEMPORARY_EVENTS(int ped, BOOL toggle) { Function.Call(0x90D2156198831D69, ped, toggle); }
		public static void TASK_SET_STEALTH_MOVEMENT(int ped, BOOL p1, Any p2, BOOL p3) { Function.Call(0x4C3FA937B44A90FA, ped, p1, p2, p3); }
		public static void TASK_SET_CROUCH_MOVEMENT(int ped, BOOL p1, Any p2, BOOL p3) { Function.Call(0x17293C633C8AC019, ped, p1, p2, p3); }
		public static void TASK_FORCE_MOTION_STATE(int ped, Hash motionStateHash, BOOL p2) { Function.Call(0x4F056E1AFFEF17AB, ped, motionStateHash, p2); }
		public static void TASK_MOVE_NETWORK_BY_NAME(int ped, string task, float multiplier, BOOL p3, string animDict, int flags) { Function.Call(0x2D537BA194896636, ped, task, multiplier, p3, animDict, flags); }
		public static unsafe void TASK_MOVE_NETWORK_BY_NAME_WITH_INIT_PARAMS(int ped, string moveNetworkDefName, Any* taskData, float p3, BOOL p4, string animDict, int flags) { Function.Call(0x139805C2A67C4795, ped, moveNetworkDefName, taskData, p3, p4, animDict, flags); }
		public static unsafe void TASK_MOVE_NETWORK_ADVANCED_BY_NAME_WITH_INIT_PARAMS(int ped, string moveNetworkDefName, Any* taskData, float xPos, float yPos, float zPos, float xRot, float yRot, float zRot, int p9, float p10, int p11, int p12, int flag, int p14) { Function.Call(0x7B6A04F98BBAFB2C, ped, moveNetworkDefName, taskData, xPos, yPos, zPos, xRot, yRot, zRot, p9, p10, p11, p12, flag, p14); }
		public static void TASK_MOVE_NETWORK_ADVANCED_BY_NAME_WITH_INIT_PARAMS_ATTACHED(int ped, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8, Any p9, Any p10, Any p11, Any p12, Any p13, Any p14, Any p15, Any p16, Any p17) { Function.Call(0xF92171093BCABED4, ped, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17); }
		public static BOOL IS_TASK_MOVE_NETWORK_ACTIVE(int ped) { return Function.Call<BOOL>(0x921CE12C489C4C41, ped); }
		public static Hash _GET_TASK_MOVE_NETWORK_ID(int ped) { return Function.Call<Hash>(0xCACC2F9D994504B7, ped); }
		public static BOOL IS_TASK_MOVE_NETWORK_READY_FOR_TRANSITION(int ped) { return Function.Call<BOOL>(0x30ED88D5E0C56A37, ped); }
		public static void REQUEST_TASK_MOVE_NETWORK_STATE_TRANSITION(int ped, string name) { Function.Call(0xD01015C7316AE176, ped, name); }
		public static string GET_TASK_MOVE_NETWORK_STATE(int ped) { return Function.Call<string>(0x717E4D1F2048376D, ped); }
		public static Any _0xE9A6400D1A0E7A55(Any p0) { return Function.Call<Any>(0xE9A6400D1A0E7A55, p0); }
		public static void _0x615DC4A82E90BB48(Any p0, Any p1, Any p2) { Function.Call(0x615DC4A82E90BB48, p0, p1, p2); }
		public static void SET_TASK_MOVE_NETWORK_SIGNAL_FLOAT(int ped, string signalName, float value) { Function.Call(0xD5BB4025AE449A4E, ped, signalName, value); }
		public static void _0x099D4A855D53B03B(Any p0, Any p1, Any p2) { Function.Call(0x099D4A855D53B03B, p0, p1, p2); }
		public static void SET_TASK_MOVE_NETWORK_SIGNAL_BOOL(int ped, string signalName, BOOL value) { Function.Call(0xB0A6CFD2C69C1088, ped, signalName, value); }
		public static void _SET_TASK_MOVE_NETWORK_SIGNAL_VECTOR(int ped, string signalName, float x, float y, float z) { Function.Call(0x4662BFE01938D98D, ped, signalName, x, y, z); }
		public static float _GET_TASK_MOVE_NETWORK_PHASE_FLOAT(int ped, string phaseName) { return Function.Call<float>(0x844CEEE428EA35B0, ped, phaseName); }
		public static BOOL GET_TASK_MOVE_NETWORK_EVENT(int ped, string _eventName) { return Function.Call<BOOL>(0xB4F47213DF45A64C, ped, _eventName); }
		public static void _0x9585FF23C4B8EDE0(Any p0, Any p1) { Function.Call(0x9585FF23C4B8EDE0, p0, p1); }
		public static void _0xEAF87DA2BE78A15B(Any p0, Any p1) { Function.Call(0xEAF87DA2BE78A15B, p0, p1); }
		public static void _0x3BBEECC5B8F35318(Any p0, Any p1) { Function.Call(0x3BBEECC5B8F35318, p0, p1); }
		public static BOOL IS_MOVE_BLEND_RATIO_STILL(int ped) { return Function.Call<BOOL>(0x349CE7B56DAFD95C, ped); }
		public static BOOL IS_MOVE_BLEND_RATIO_WALKING(int ped) { return Function.Call<BOOL>(0xF133BBBE91E1691F, ped); }
		public static BOOL IS_MOVE_BLEND_RATIO_RUNNING(int ped) { return Function.Call<BOOL>(0xD4D8636C0199A939, ped); }
		public static BOOL IS_MOVE_BLEND_RATIO_SPRINTING(int ped) { return Function.Call<BOOL>(0x24A2AD74FA9814E2, ped); }
		public static BOOL IS_PED_STILL(int ped) { return Function.Call<BOOL>(0xAC29253EEF8F0180, ped); }
		public static BOOL IS_PED_WALKING(int ped) { return Function.Call<BOOL>(0xDE4C184B2B9B071A, ped); }
		public static BOOL IS_PED_RUNNING(int ped) { return Function.Call<BOOL>(0xC5286FFC176F28A2, ped); }
		public static BOOL IS_PED_SPRINTING(int ped) { return Function.Call<BOOL>(0x57E457CD2C0FC168, ped); }
		public static BOOL IS_PED_IN_HIT_REACT(int ped) { return Function.Call<BOOL>(0xF330A5C062B29BED, ped); }
		public static void TASK_ARREST_PED(int ped, int target) { Function.Call(0xF3B9A78A178572B1, ped, target); }
		public static BOOL IS_PED_BEING_ARRESTED(int ped) { return Function.Call<BOOL>(0x90A09F3A45FED688, ped); }
		public static BOOL _IS_PED_ARRESTING_ANY_PED(int ped) { return Function.Call<BOOL>(0xA9CC7856D52DBD25, ped); }
		public static void _CUFF_PED(int ped) { Function.Call(0x7981037A96E7D174, ped); }
		public static void UNCUFF_PED(int ped) { Function.Call(0x67406F2C8F87FC4F, ped); }
		public static BOOL IS_PED_CUFFED(int ped) { return Function.Call<BOOL>(0x74E559B3BC910685, ped); }
		public static BOOL _IS_PED_DUELLING(int ped) { return Function.Call<BOOL>(0xC8B29D18022EA2B7, ped); }
		public static void TASK_DUEL(int ped, Any p1, float p2, int entity, float p4, int p5, float vPosOpponentX, float vPosOpponentY, float vPosOpponentZ, float fOpponentHead, int p10) { Function.Call(0x5D5B0D5BC3626E5A, ped, p1, p2, entity, p4, p5, vPosOpponentX, vPosOpponentY, vPosOpponentZ, fOpponentHead, p10); }
		public static Any _0x908BB14BCE85C80E(Any p0) { return Function.Call<Any>(0x908BB14BCE85C80E, p0); }
		public static Any _0x1F7A9A9C38C13A56(Any p0) { return Function.Call<Any>(0x1F7A9A9C38C13A56, p0); }
		public static Any _0x3FEB770D8ED9047A(Any p0) { return Function.Call<Any>(0x3FEB770D8ED9047A, p0); }
		public static Any _0x30146C25686B7836(Any p0, Any p1) { return Function.Call<Any>(0x30146C25686B7836, p0, p1); }
		public static Any _0x59AE5CA4FFB4E378(Any p0, Any p1) { return Function.Call<Any>(0x59AE5CA4FFB4E378, p0, p1); }
		public static void _0x748D5E0D2A1A4C61(Any p0, Any p1, Any p2) { Function.Call(0x748D5E0D2A1A4C61, p0, p1, p2); }
		public static void END_DUEL(int ped, BOOL p1, float p2) { Function.Call(0xEED08A3A98B847E2, ped, p1, p2); }
		public static void _0x651F0530083C0E5A(Any p0, Any p1) { Function.Call(0x651F0530083C0E5A, p0, p1); }
		public static void TASK_CARRIABLE(int entity, Hash carryConfig, int carrier, int carriableSlot, int flags) { Function.Call(0xF0B4F759F35CC7F5, entity, carryConfig, carrier, carriableSlot, flags); }
		public static void _0x9EBD34958AB6F824(Any p0) { Function.Call(0x9EBD34958AB6F824, p0); }
		public static BOOL GET_IS_CARRIABLE_ENTITY(int entity) { return Function.Call<BOOL>(0x0CCFE72B43C9CF96, entity); }
		public static Any _0x10ADFDF07B7DFFBA(Any p0, Any p1, Any p2) { return Function.Call<Any>(0x10ADFDF07B7DFFBA, p0, p1, p2); }
		public static void TASK_PLACE_CARRIED_ENTITY_AT_COORD(int ped, int entity, float x, float y, float z, float p5, int flags) { Function.Call(0xC7F0B43DCDC57E3D, ped, entity, x, y, z, p5, flags); }
		public static void TASK_PLACE_CARRIED_ENTITY_ON_MOUNT(int ped, int entity, int mount, float p3) { Function.Call(0x6D3D87C57B3D52C7, ped, entity, mount, p3); }
		public static void TASK_DUMP_CARRIABLE_FROM_PARENT(int ped, int ped2, int entity) { Function.Call(0x17CA98707B15926A, ped, ped2, entity); }
		public static void _0x36D188AECB26094B(Any p0) { Function.Call(0x36D188AECB26094B, p0); }
		public static void _0xE2CF104ADD49D4BF(Any p0) { Function.Call(0xE2CF104ADD49D4BF, p0); }
		public static void TASK_PICKUP_CARRIABLE_ENTITY(int ped, int entity) { Function.Call(0x502EC17B1BED4BFA, ped, entity); }
		public static void TASK_HOGTIE_TARGET_PED(int ped, int targetPed) { Function.Call(0x27829AFD3E03AC1A, ped, targetPed); }
		public static void _TASK_CUT_FREE_HOGTIED_TARGET_PED(int ped, int targetPed) { Function.Call(0x81D16C4FF3A77ADF, ped, targetPed); }
		public static void _TASK_CUT_FREE_HOGTIED_TARGET_PED_2(int ped, int targetPed, float p2) { Function.Call(0x525421A507216084, ped, targetPed, p2); }
		public static void _SET_HOGTIE_ESCAPE_TIMER(int ped, float time) { Function.Call(0xAB591AE6B48B913E, ped, time); }
		public static float _GET_HOGTIE_ESCAPE_TIMER(int ped) { return Function.Call<float>(0x4687E69D258BBE41, ped); }
		public static Any _0x03D741CB4052E26C(Any p0) { return Function.Call<Any>(0x03D741CB4052E26C, p0); }
		public static BOOL _REQUEST_HERB_COMPOSITE_ASSET(Hash asset) { return Function.Call<BOOL>(0x73F0D0327BFA0812, asset); }
		public static BOOL ARE_COMPOSITE_LOOTABLE_ENTITY_DEF_ASSETS_LOADED(Hash asset) { return Function.Call<BOOL>(0x5E5D96BE25E9DF68, asset); }
		public static unsafe int _CREATE_HERB_COMPOSITES(Hash asset, float x, float y, float z, float heading, int groundSetting, Any* p6, int p7) { return Function.Call<int>(0x5B4BBE80AD5972DC, asset, x, y, z, heading, groundSetting, p6, p7); }
		public static void _DELETE_PATCH_OBJECTS_FROM_HERB_COMPOSITES(int compositeId, BOOL p1) { Function.Call(0x5758B1EE0C3FD4AC, compositeId, p1); }
		public static unsafe int _GET_HERB_COMPOSITE_NUM_ENTITIES(int compositeId, Any* _outEntities) { return Function.Call<int>(0x96C6ED22FB742C3E, compositeId, _outEntities); }
		public static Any _0xDF56A2B50C04DEA4(Any p0, Any p1) { return Function.Call<Any>(0xDF56A2B50C04DEA4, p0, p1); }
		public static void TASK_LOOT_ENTITY(int ped, int entity) { Function.Call(0x48FAE038401A2888, ped, entity); }
		public static void TASK_BREAK_VEHICLE_DOOR_LOCK(int ped, int vehicle) { Function.Call(0xBB28D1BC9EA8A6A5, ped, vehicle); }
		public static void TASK_LOOT_NEAREST_ENTITY(int ped, float x, float y, float z, int p4, float p5) { Function.Call(0xCF1501CBC4059412, ped, x, y, z, p4, p5); }
		public static void TASK_LASSO_PED(int ped, int targetPed) { Function.Call(0xC716EB2BD16370A3, ped, targetPed); }
		public static void TASK_HOGTIEABLE(int ped) { Function.Call(0x6AFD8FE0D723328F, ped); }
		public static void UNHOGTIE_PED(int ped, int flags, Hash getupSetHash, string p3, string p4, float p5) { Function.Call(0x79559BAD83CCD038, ped, flags, getupSetHash, p3, p4, p5); }
		public static void _0x722D6A49200174FE(Any p0, Any p1, Any p2, Any p3, Any p4) { Function.Call(0x722D6A49200174FE, p0, p1, p2, p3, p4); }
		public static void _MAKE_OBJECT_CARRIABLE(Object _object) { Function.Call(0x78B4567E18B54480, _object); }
		public static void MAKE_OBJECT_NOT_CARRIABLE(Object _object) { Function.Call(0x67BFCED22909834D, _object); }
		public static void _0x8E1DDE26D270CC5E(Any p0, Any p1) { Function.Call(0x8E1DDE26D270CC5E, p0, p1); }
		public static void _0xA6A76D666A281F2D(Any p0, Hash item) { Function.Call(0xA6A76D666A281F2D, p0, item); }
		public static void _0xA21AA2F0C2180125(Any p0, Any p1) { Function.Call(0xA21AA2F0C2180125, p0, p1); }
		public static Any _0xE47DD64B9F02677D(Any p0) { return Function.Call<Any>(0xE47DD64B9F02677D, p0); }
		public static void _0xFF745B0346E19E2C(Any p0) { Function.Call(0xFF745B0346E19E2C, p0); }
		public static Any _0xB8F52A3F84A7CC59(Any p0) { return Function.Call<Any>(0xB8F52A3F84A7CC59, p0); }
		public static void _0x6AFDA2264925BD11(Any p0) { Function.Call(0x6AFDA2264925BD11, p0); }
		public static void _0x816A3ACD265E2297(Any p0, Any p1) { Function.Call(0x816A3ACD265E2297, p0, p1); }
		public static void _0x4E806A395D43A458(Any p0) { Function.Call(0x4E806A395D43A458, p0); }
		public static void SET_TEAM_CARRIABLE_ENTITY(Any p0, Any p1, Any p2) { Function.Call(0x545BF19F86E80F11, p0, p1, p2); }
		public static BOOL IS_TEAM_CARRIABLE_ENTITY(Any p0, Any p1) { return Function.Call<BOOL>(0x559A6F8C5133B4EE, p0, p1); }
		public static BOOL _IS_HAT_BEING_PICKED_UP(Object hatObject) { return Function.Call<BOOL>(0x11CD066F54DA0133, hatObject); }
		public static void _0x9ADDBB9242179D56(Object _object, int ped) { Function.Call(0x9ADDBB9242179D56, _object, ped); }
		public static BOOL _IS_HAT_BEING_PICKED_UP_2(Object hatObject) { return Function.Call<BOOL>(0x4ECCC2815CA79AE2, hatObject); }
		public static void _TASK_EQUIP_HAT(Object hatObject, int ped) { Function.Call(0xAA0AF6025160243A, hatObject, ped); }
		public static Any _0x7CB99FADDE73CD1B(Any p0) { return Function.Call<Any>(0x7CB99FADDE73CD1B, p0); }
		public static void _0xF3C3503276F4A034(int entity, Any p1) { Function.Call(0xF3C3503276F4A034, entity, p1); }
		public static Any _0x6DAC799857EF3F11(Any p0, Any p1) { return Function.Call<Any>(0x6DAC799857EF3F11, p0, p1); }
		public static Any _0x920684BE432875B1(Any p0) { return Function.Call<Any>(0x920684BE432875B1, p0); }
		public static BOOL SET_ENHANCED_BREAK_FREE(int ped, BOOL p1, string p2) { return Function.Call<BOOL>(0x1BF9D36A5EAFFBAE, ped, p1, p2); }
		public static Any _0x6AFD84AEAA3EA538(Any p0) { return Function.Call<Any>(0x6AFD84AEAA3EA538, p0); }
		public static void _0xBD1C3C0F271C39D3(Any p0, Any p1) { Function.Call(0xBD1C3C0F271C39D3, p0, p1); }
		public static void _0x1ECF56C040FD839C(Any p0, Any p1) { Function.Call(0x1ECF56C040FD839C, p0, p1); }
		public static void _0xF40A109B4B79A848(Any p0, Any p1, Any p2) { Function.Call(0xF40A109B4B79A848, p0, p1, p2); }
		public static BOOL _IS_PED_LEADING_HORSE(int ped) { return Function.Call<BOOL>(0xEFC4303DDC6E60D3, ped); }
		public static Any _0xAC5045AB7F1A34FD(Any p0) { return Function.Call<Any>(0xAC5045AB7F1A34FD, p0); }
		public static int _GET_LED_HORSE_FROM_PED(int ped) { return Function.Call<int>(0xED1F514AF4732258, ped); }
		public static void TASK_TURN_TO_FACE_CLOSEST_PED(int ped, float p1, float p2, int p3) { Function.Call(0x84179419DBDD36F2, ped, p1, p2, p3); }
		public static BOOL TASK_CONFRONT(int ped, int targetPed, int p2) { return Function.Call<BOOL>(0x3A2A2071DF5CC569, ped, targetPed, p2); }
		public static BOOL TASK_POLICE(int ped, BOOL p1) { return Function.Call<BOOL>(0x87BE56724650408E, ped, p1); }
		public static BOOL TASK_MELEE(int ped, int targetPed, Hash p2, Any p3, Any p4, float p5, Any p6, float p7) { return Function.Call<BOOL>(0x482C99D0B38D1B0A, ped, targetPed, p2, p3, p4, p5, p6, p7); }
		public static BOOL TASK_GRAPPLE(int ped, int targetPed, Hash grappleStyle, int p3, float p4, int p5, int p6) { return Function.Call<BOOL>(0x779A2FFACEFAEA7B, ped, targetPed, grappleStyle, p3, p4, p5, p6); }
		public static BOOL _TASK_INTIMIDATED(Any p0, Any p1, Any p2, Any p3, Any p4) { return Function.Call<BOOL>(0x648B75D44930D6BD, p0, p1, p2, p3, p4); }
		public static BOOL _TASK_INTIMIDATED_2(int victim, int attacker, int p2, BOOL p3, BOOL p4, BOOL everyFrame, BOOL p6, BOOL p7, int flag) { return Function.Call<BOOL>(0x933ACC1A1771A288, victim, attacker, p2, p3, p4, everyFrame, p6, p7, flag); }
		public static void _0x2948235DB2058E99(Any p0, Any p1) { Function.Call(0x2948235DB2058E99, p0, p1); }
		public static void _0xB2F47A1AFDFCC595(Any p0, Any p1) { Function.Call(0xB2F47A1AFDFCC595, p0, p1); }
		public static void _0x41D1331AFAD5A091(int ped, int p1, Any p2) { Function.Call(0x41D1331AFAD5A091, ped, p1, p2); }
		public static void _0x801BD27403F3CBA0(Any p0, Any p1, Any p2, Any p3) { Function.Call(0x801BD27403F3CBA0, p0, p1, p2, p3); }
		public static void _0x0FE797DD9F70DFA6(Any p0, Any p1, Any p2, Any p3) { Function.Call(0x0FE797DD9F70DFA6, p0, p1, p2, p3); }
		public static void TASK_PERSISTENT_CHARACTER(int ped) { Function.Call(0x4391700CBD89C3D8, ped); }
		public static void _0xFC7F71CF49F70B6B(Any p0) { Function.Call(0xFC7F71CF49F70B6B, p0); }
		public static void _0xE01F55B2896F6B37(Any p0, Any p1) { Function.Call(0xE01F55B2896F6B37, p0, p1); }
		public static Any _0xE62754D09354F6CF(Any p0) { return Function.Call<Any>(0xE62754D09354F6CF, p0); }
		public static void _0x4BA972D0E5AD8122(Any p0, Any p1) { Function.Call(0x4BA972D0E5AD8122, p0, p1); }
		public static unsafe BOOL _GET_TASK_FISHING(int ped, Any* p1) { return Function.Call<BOOL>(0xF3735ACD11ACD500, ped, p1); }
		public static unsafe BOOL _SET_TASK_FISHING(int ped, Any* p1) { return Function.Call<BOOL>(0xF3735ACD11ACD501, ped, p1); }
		public static void TASK_SWAP_FISHING_BAIT(int ped, string bait, BOOL withoutBuoy) { Function.Call(0x2C28AC30A72722DA, ped, bait, withoutBuoy); }
		public static void _SET_FISHING_BAIT(int ped, string bait, BOOL withoutBuoy, BOOL instantly) { Function.Call(0x9B0C7FA063E67629, ped, bait, withoutBuoy, instantly); }
		public static void _0x1F298C7BD30D1240(int ped) { Function.Call(0x1F298C7BD30D1240, ped); }
		public static void _PED_FISHINGROD_HOOK_ENTITY(int ped, int entity) { Function.Call(0x1A52076D26E09004, ped, entity); }
		public static void _0xCE71C2F9BAA3F975(int ped, int entity) { Function.Call(0xCE71C2F9BAA3F975, ped, entity); }
		public static BOOL _0xB520DBDA7FCF573F(int ped) { return Function.Call<BOOL>(0xB520DBDA7FCF573F, ped); }
		public static void _0x31BB338F64D5C861(int ped, BOOL p1) { Function.Call(0x31BB338F64D5C861, ped, p1); }
		public static void _0x517D01BF27B682D1(int ped, int entity, float p2, float p3, float p4, float p5, int p6) { Function.Call(0x517D01BF27B682D1, ped, entity, p2, p3, p4, p5, p6); }
		public static void _0x88FD60D846D9CD63(int ped) { Function.Call(0x88FD60D846D9CD63, ped); }
		public static void _0x9050DF2C53801208(int ped, float p1) { Function.Call(0x9050DF2C53801208, ped, p1); }
		public static void _0x22CDBF317C40A122(int ped) { Function.Call(0x22CDBF317C40A122, ped); }
		public static Any _0x5952DFA38FA529FE() { return Function.Call<Any>(0x5952DFA38FA529FE); }
		public static void TASK_PLAY_EMOTE_WITH_HASH(int ped, int emoteType, int playbackMode, Hash emote, BOOL isSecondaryTask, BOOL canBreakOut, BOOL disableEarlyOutAnimTag, BOOL ignoreInvalidMainTask, BOOL destroyProps) { Function.Call(0xB31A277C1AC7B7FF, ped, emoteType, playbackMode, emote, isSecondaryTask, canBreakOut, disableEarlyOutAnimTag, ignoreInvalidMainTask, destroyProps); }
		public static void _TASK_PLAY_EMOTE(int ped, int emoteType, int playbackMode, Hash emote, BOOL isSecondaryTask, BOOL canBreakOut, BOOL disableEarlyOutAnimTag, BOOL ignoreInvalidMainTask, BOOL destroyProps) { Function.Call(0x884E3436CC1F41DD, ped, emoteType, playbackMode, emote, isSecondaryTask, canBreakOut, disableEarlyOutAnimTag, ignoreInvalidMainTask, destroyProps); }
		public static void _0x6A1AF481407BF6E9(Any p0) { Function.Call(0x6A1AF481407BF6E9, p0); }
		public static void _TASK_EMOTE_OUTRO(int ped) { Function.Call(0xBDFEEB7600BCD938, ped); }
		public static void _0xEC516FE805D2CB2D(Any p0) { Function.Call(0xEC516FE805D2CB2D, p0); }
		public static void _0x59AEA4DC640814B9(Any p0, Any p1) { Function.Call(0x59AEA4DC640814B9, p0, p1); }
		public static Any _0x11C7CE1AE38911B5(Any p0) { return Function.Call<Any>(0x11C7CE1AE38911B5, p0); }
		public static Any _0xD0ABC4EA3B5E21A0(Any p0, Any p1) { return Function.Call<Any>(0xD0ABC4EA3B5E21A0, p0, p1); }
		public static BOOL IS_EMOTE_TASK_RUNNING(int ped, Any p1) { return Function.Call<BOOL>(0xCF9B71C0AF824036, ped, p1); }
	}

	public static class TELEMETRY
	{
		public static void _TELEMETRY_SET_IS_FLOW(BOOL toggle) { Function.Call(0x9BEE018A63FFFAD9, toggle); }
		public static void _0xEC0BD8736DCAF841(BOOL toggle) { Function.Call(0xEC0BD8736DCAF841, toggle); }
		public static void _TELEMETRY_MISSION_STARTED(Any p0, Any p1, Any p2, Any p3) { Function.Call(0x15B0CC1B36F1DE29, p0, p1, p2, p3); }
		public static void _TELEMETRY_MISSION_OVER(Any p0, Any p1) { Function.Call(0xD894437E12C17AEC, p0, p1); }
		public static void _TELEMETRY_MISSION_CHECKPOINT(Any p0, Any p1, Any p2) { Function.Call(0x8EC7890D446BD9C1, p0, p1, p2); }
		public static void _TELEMETRY_PLAYER_SPAWNED(int ped) { Function.Call(0x5DA4718DF897EB25, ped); }
		public static unsafe BOOL _TELEMETRY_CREATE_UUID(Any* uuid) { return Function.Call<BOOL>(0xE692D336F8A2A97F, uuid); }
		public static void _TELEMETRY_MATCH_QUEUE(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6) { Function.Call(0x4C08D2B6D8BE17E4, p0, p1, p2, p3, p4, p5, p6); }
		public static unsafe void _TELEMETRY_MATCH_STARTED(Any* p0, Any* p1) { Function.Call(0xF620F47B4F4A78C4, p0, p1); }
		public static void _TELEMETRY_MATCH_OVER(Any p0, Any p1, Any p2, Any p3, Any p4) { Function.Call(0xA2058154357726BB, p0, p1, p2, p3, p4); }
		public static unsafe void _TELEMETRY_MATCH_VOTE(Any* p0, Any* p1) { Function.Call(0xEF3C68F56BAD7B69, p0, p1); }
		public static void _TELEMETRY_LOBBY_PROGRESSION(Any p0, Any p1, Any p2, Any p3) { Function.Call(0xECD67E9FA677CCCF, p0, p1, p2, p3); }
		public static void _TELEMETRY_GAME_PROGRESS(Any p0, Any p1) { Function.Call(0x51EC204A6E5B5A1A, p0, p1); }
		public static void _TELEMETRY_HERB_PICKED(Hash herbType) { Function.Call(0xAE693EC3A178F6C2, herbType); }
		public static unsafe void _TELEMETRY_ANIMAL_SKINNED(Hash type, Any* items) { Function.Call(0x7581972ADF5D699A, type, items); }
		public static void _TELEMETRY_CAMP_CREATED(Any p0) { Function.Call(0x565EAA726B2CE3B7, p0); }
		public static void _TELEMETRY_CAMP_SUPPLIES(Any p0, Any p1, Any p2, Any p3, Any p4) { Function.Call(0x217F47761376E16E, p0, p1, p2, p3, p4); }
		public static void _TELEMETRY_REGION(Hash regionHash) { Function.Call(0xCD6F8A0335D821F9, regionHash); }
		public static void _TELEMETRY_SHOP_ENTRY(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5) { Function.Call(0x775B2ED944E44973, p0, p1, p2, p3, p4, p5); }
		public static void _TELEMETRY_SHOP_EXIT(Any p0, Any p1) { Function.Call(0xF78E669FDC202E73, p0, p1); }
		public static void _0xCA9E42F437625A85(int p0, Hash p1, Hash p2) { Function.Call(0xCA9E42F437625A85, p0, p1, p2); }
		public static void _TELEMETRY_SHOP_PURCHASE(Any p0, Any p1, Any p2, Any p3, Any p4) { Function.Call(0x2A374E6F0075EE81, p0, p1, p2, p3, p4); }
		public static void _TELEMETRY_SHOP_SELL(Any p0, Any p1, Any p2, Any p3, Any p4) { Function.Call(0x9BD8A9D0A774A6F8, p0, p1, p2, p3, p4); }
		public static void _TELEMETRY_GOLD_STORE(Any p0, Any p1, Any p2, Any p3) { Function.Call(0x536B6025E94AC48F, p0, p1, p2, p3); }
		public static void _0x32D5898C4898CD95() { Function.Call(0x32D5898C4898CD95); }
		public static void _TELEMETRY_SHOP_CUTSCENE(Any p0, Any p1, Any p2, Any p3) { Function.Call(0xB0B19B56697836F5, p0, p1, p2, p3); }
		public static void _TELEMETRY_AMBIENT_VIGNETTE(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6) { Function.Call(0x3145044F3990D321, p0, p1, p2, p3, p4, p5, p6); }
		public static void _TELEMETRY_DISCOVERABLE(Any p0) { Function.Call(0xF5EAD898EF387E73, p0); }
		public static void _TELEMETRY_HONOR(Any p0, Any p1) { Function.Call(0xE6B763C7F4902201, p0, p1); }
		public static void _TELEMETRY_CRAFT_ITEM(Any p0, Any p1, Any p2, Any p3) { Function.Call(0x78C2E029DB205A3A, p0, p1, p2, p3); }
		public static void TELEMETRY_CAMP_DONATE(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8) { Function.Call(0xDF516E598D966D06, p0, p1, p2, p3, p4, p5, p6, p7, p8); }
		public static void _TELEMETRY_MOONSHINE_BREW(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8, Any p9, Any p10) { Function.Call(0xB5013EFBB5516867, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10); }
		public static void _TELEMETRY_COLLECT(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6) { Function.Call(0xD6CB05DDAEE43AFD, p0, p1, p2, p3, p4, p5, p6); }
		public static void _TELEMETRY_MISSION_ILO_OPTION(Any p0, Any p1) { Function.Call(0xEA323F5E1A4DA2F1, p0, p1); }
		public static void _0x6571E4327390EC0B(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5) { Function.Call(0x6571E4327390EC0B, p0, p1, p2, p3, p4, p5); }
		public static void _TELEMETRY_GANG_SHARES(Any p0, Any p1, Any p2, Any p3) { Function.Call(0xE6DC9B21AC7A8729, p0, p1, p2, p3); }
		public static void _TELEMETRY_FAST_TRAVEL(Any p0, Any p1, Any p2, Any p3, Any p4) { Function.Call(0x7CEF4AC79F7E7FAD, p0, p1, p2, p3, p4); }
		public static void _TELEMETRY_NET_CAMP(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6) { Function.Call(0xA72773C3134F9A57, p0, p1, p2, p3, p4, p5, p6); }
		public static void _0x7E002A36AEFCFB55() { Function.Call(0x7E002A36AEFCFB55); }
		public static void _TELEMETRY_SLEEP(Any p0) { Function.Call(0xF9F14080D80937BD, p0); }
		public static void _TELEMETRY_PARLEY_FEUD(Any p0, Any p1, Any p2, Any p3, Any p4) { Function.Call(0xF37A2149BC9A8A27, p0, p1, p2, p3, p4); }
		public static void TELEMETRY_PLAYER_MENU_PIN(Any p0, Any p1, Any p2, Any p3) { Function.Call(0x076C5843371EB889, p0, p1, p2, p3); }
		public static void _TELEMETRY_NOTORIETY(Any p0, Any p1, Any p2, Any p3) { Function.Call(0xE26970A7AE0F28E9, p0, p1, p2, p3); }
		public static void _TELEMETRY_DEFENSIVE(Any p0, Any p1, Any p2) { Function.Call(0xE57529D23541D2DD, p0, p1, p2); }
		public static void _TELEMETRY_LOOT(Any p0, Any p1, Any p2, Any p3) { Function.Call(0xCF63EF77B0DF0397, p0, p1, p2, p3); }
		public static void _0x2C24AF8EEEEF8A55(Any p0, Any p1, Any p2) { Function.Call(0x2C24AF8EEEEF8A55, p0, p1, p2); }
		public static void _TELEMETRY_FAVOR_EMOTE(Any p0, Any p1, Any p2) { Function.Call(0x16B23D4F7A1F50D9, p0, p1, p2); }
		public static void _TELEMETRY_POKER_OVER(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8, Any p9) { Function.Call(0x8127C5AA05C5A210, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9); }
		public static unsafe BOOL _0x80A02D9F948A8BCA(Any* requestId, Any* telemetryId) { return Function.Call<BOOL>(0x80A02D9F948A8BCA, requestId, telemetryId); }
		public static unsafe BOOL _0xF184B3ECE36219CF(Any* transactionId, Any* telemetryId) { return Function.Call<BOOL>(0xF184B3ECE36219CF, transactionId, telemetryId); }
		public static void _TELEMETRY_ROLE_BOUNTY(Any p0) { Function.Call(0xAB43D1C80B5E9500, p0); }
		public static unsafe void _TELEMETRY_BOUNTY_TARGET(Any* data) { Function.Call(0x52FA31DB8F3AD25D, data); }
		public static void _TELEMETRY_PRISON(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6) { Function.Call(0xB204BF9F30298D77, p0, p1, p2, p3, p4, p5, p6); }
		public static void _TELEMETRY_ROLE_TRADER(Any p0, Any p1) { Function.Call(0x476038B5A0734C10, p0, p1); }
		public static void _TELEMETRY_ROLE_MOONSHINER(Any p0, Any p1) { Function.Call(0x99D40C5D74BC88E9, p0, p1); }
		public static void _TELEMETRY_ROLE_COLLECTOR(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6) { Function.Call(0x4AC38DFD286DAD14, p0, p1, p2, p3, p4, p5, p6); }
		public static void _TELEMETRY_PHOTO(Any p0, Any p1, Any p2, Any p3) { Function.Call(0xED22BE4C5A399E63, p0, p1, p2, p3); }
		public static void _TELEMETRY_START_GUN_LOCKER_INTERACTION() { Function.Call(0xF0D54E0651DD7E07); }
		public static void _TELEMETRY_GUN_LOCKER() { Function.Call(0x415FE28ED44BFF14); }
		public static void _TELEMETRY_GUN_LOCKER_WEAPON_STORED(Hash p0) { Function.Call(0xC3ADF4880784FA9C, p0); }
		public static void _TELEMETRY_GUN_LOCKER_WEAPON_REMOVED(Hash p0) { Function.Call(0x317D9C9560529CC2, p0); }
		public static void _TELEMETRY_ROLE_TOKEN_TRANSACTION(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5) { Function.Call(0x32C2939564D74BFF, p0, p1, p2, p3, p4, p5); }
		public static void _TELEMETRY_COUPON(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5) { Function.Call(0x621D719C4836292B, p0, p1, p2, p3, p4, p5); }
		public static void TELEMETRY_PERSONAL_VEHICLE_MOUNT(Any p0, Any p1, Any p2, Any p3) { Function.Call(0xFF9052BC7A3B7D33, p0, p1, p2, p3); }
		public static void _TELEMETRY_PERSONAL_VEHICLE_WAGON(Any p0, Any p1, Any p2) { Function.Call(0xE67AF24C5A3B6058, p0, p1, p2); }
		public static void _TELEMETRY_MENU_NAVIGATION(Any p0, Any p1, Any p2, Any p3) { Function.Call(0x3255D4D2082C6339, p0, p1, p2, p3); }
		public static void _TELEMETRY_HUB_NAVIGATION(Any p0, Any p1, Any p2, Any p3) { Function.Call(0x25CC50EC1A6F3A96, p0, p1, p2, p3); }
		public static void _0x37AA282163B0D2C4(Any p0, Any p1) { Function.Call(0x37AA282163B0D2C4, p0, p1); }
		public static void _TELEMETRY_SAMPLE(Any p0, Any p1, Any p2, Any p3, Any p4) { Function.Call(0x61559675D23D8BD1, p0, p1, p2, p3, p4); }
		public static void _TELEMETRY_ROLE_NATURALIST(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8, Any p9) { Function.Call(0x6FB9EA308F302922, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9); }
		public static void _TELEMETRY_PHOTO_CAM(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8) { Function.Call(0x0777D65EE8A17517, p0, p1, p2, p3, p4, p5, p6, p7, p8); }
		public static void _TELEMETRY_INTRO_SKIP(Any p0, Any p1, Any p2) { Function.Call(0x1B554723799245F4, p0, p1, p2); }
		public static void ANALYTICS_PLAYTIME_FREEMODE_START() { Function.Call(0xE9F24081D84931B8); }
		public static void ANALYTICS_PLAYTIME_FREEMODE_END() { Function.Call(0x3180E991D4B8F248); }
		public static unsafe void _TELEMETRY_CUSTOM(Any* args) { Function.Call(0x40914CCF2A1AB531, args); }
		public static unsafe void _TELEMETRY_MATCH_NOMINATION(Any* args) { Function.Call(0x330029E121380CEB, args); }
		public static void _TELEMETRY_CHAR_CREATOR(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6) { Function.Call(0x7207AD471BC9278C, p0, p1, p2, p3, p4, p5, p6); }
	}

	public static class TXD
	{
		public static BOOL DOES_STREAMED_TXD_EXIST(Hash txdHash) { return Function.Call<BOOL>(0xBA0163B277C2D2D0, txdHash); }
		public static void REQUEST_STREAMED_TXD(Hash txdHash, BOOL p1) { Function.Call(0xDB1BD07FB464584D, txdHash, p1); }
		public static BOOL HAS_STREAMED_TXD_LOADED(Hash txdHash) { return Function.Call<BOOL>(0xBE72591D1509FFE4, txdHash); }
		public static void SET_STREAMED_TXD_AS_NO_LONGER_NEEDED(Hash txdHash) { Function.Call(0x8232F37DF762ACB2, txdHash); }
		public static BOOL DOES_STREAMED_TEXTURE_DICT_EXIST(string textureDict) { return Function.Call<BOOL>(0x7332461FC59EB7EC, textureDict); }
		public static void REQUEST_STREAMED_TEXTURE_DICT(string textureDict, BOOL p1) { Function.Call(0xC1BA29DF5631B0F8, textureDict, p1); }
		public static BOOL HAS_STREAMED_TEXTURE_DICT_LOADED(string textureDict) { return Function.Call<BOOL>(0x54D6900929CCF162, textureDict); }
		public static void SET_STREAMED_TEXTURE_DICT_AS_NO_LONGER_NEEDED(string textureDict) { Function.Call(0x4ACA10A91F66F1E2, textureDict); }
	}

	public static class UIAPPS
	{
		public static BOOL IS_UIAPP_ACTIVE_BY_HASH(Hash appNameHash) { return Function.Call<BOOL>(0x25B7A0206BDFAC76, appNameHash); }
		public static BOOL IS_ANY_UIAPP_ACTIVE() { return Function.Call<BOOL>(0xAC959AB99AAF3D9F); }
		public static BOOL IS_UIAPP_RUNNING_BY_HASH(Hash appNameHash) { return Function.Call<BOOL>(0x4E511D093A86AD49, appNameHash); }
		public static BOOL IS_UIAPP_RUNNING(string appName) { return Function.Call<BOOL>(0xDE4A9B35D028979F, appName); }
		public static BOOL IS_ANY_UIAPP_RUNNING() { return Function.Call<BOOL>(0xDB30BEC7A7A5CBD3); }
		public static Hash _GET_UIAPP_CURRENT_ACTIVITY_BY_HASH(Hash appNameHash) { return Function.Call<Hash>(0x96FD694FE5BE55DC, appNameHash); }
		public static void _CLOSE_UIAPP_BY_HASH(Hash appNameHash) { Function.Call(0x2FF10C9C3F92277E, appNameHash); }
		public static void _CLOSE_UIAPP_BY_HASH_IMMEDIATE(Hash appNameHash) { Function.Call(0x04428420A248A354, appNameHash); }
		public static void _CLOSE_UIAPP(string appName) { Function.Call(0x818C6CA9B659E8EC, appName); }
		public static void _CLOSE_UIAPP_IMMEDIATE(string appName) { Function.Call(0x3015635426D1B17C, appName); }
		public static void _CLOSE_ALL_UIAPPS() { Function.Call(0xAD7B70F7230C5A12); }
		public static void _CLOSE_ALL_UIAPPS_IMMEDIATE() { Function.Call(0x12769EEB8DBD7A7B); }
		public static int LAUNCH_UIAPP_BY_HASH_WITH_ENTRY(Hash appNameHash, Hash entryHash) { return Function.Call<int>(0xC1BCF31E975B3195, appNameHash, entryHash); }
		public static int LAUNCH_UIAPP_BY_HASH(Hash appNameHash) { return Function.Call<int>(0xC8FC7F4E4CF4F581, appNameHash); }
		public static int LAUNCH_UIAPP_WITH_ENTRY(string appName, string entry) { return Function.Call<int>(0x7B2027BAC5C8EC89, appName, entry); }
		public static BOOL CAN_LAUNCH_UIAPP_BY_HASH_WITH_ENTRY(Hash appNameHash, Hash entryHash) { return Function.Call<BOOL>(0x16F47D434B6086BF, appNameHash, entryHash); }
		public static BOOL CAN_LAUNCH_UIAPP_BY_HASH(Hash appNameHash) { return Function.Call<BOOL>(0xE555EC27D65EDE80, appNameHash); }
		public static BOOL REQUEST_UIAPP_TRANSITION_BY_HASH(Hash appNameHash, Hash transitionHash) { return Function.Call<BOOL>(0x7689CD255655BFD7, appNameHash, transitionHash); }
		public static BOOL IS_UIAPP_TRANSITIONING_BY_HASH(Hash appNameHash) { return Function.Call<BOOL>(0x42095B886D30DE66, appNameHash); }
	}

	public static class UIDEBUG
	{
		public static void _BG_DISPLAY_TEXT(string text, float x, float y) { Function.Call(0x16794E044C9EFB58, text, x, y); }
		public static void _BG_SET_TEXT_SCALE(float scaleX, float scaleY) { Function.Call(0xA1253A3C870B6843, scaleX, scaleY); }
		public static void _BG_SET_TEXT_COLOR(int red, int green, int blue, int alpha) { Function.Call(0x16FA5CE47F184F1E, red, green, blue, alpha); }
	}

	public static class UIEVENTS
	{
		public static BOOL EVENTS_UI_IS_PENDING(Hash hash) { return Function.Call<BOOL>(0x67ED5A7963F2F722, hash); }
		public static unsafe BOOL EVENTS_UI_GET_MESSAGE(Hash hash, Any* _eventData) { return Function.Call<BOOL>(0xE24E957294241444, hash, _eventData); }
		public static unsafe BOOL EVENTS_UI_PEEK_MESSAGE(Hash hash, Any* _eventData) { return Function.Call<BOOL>(0x90237103F27F7937, hash, _eventData); }
		public static void EVENTS_UI_POP_MESSAGE(Hash hash) { Function.Call(0x8E8A2369F48EC839, hash); }
	}

	public static class UIFEED
	{
		public static unsafe Any _UI_FEED_POST_HELP_TEXT(Any* p0, Any* p1, BOOL p2) { return Function.Call<Any>(0x049D5C615BD38BAD, p0, p1, p2); }
		public static unsafe int _UI_FEED_POST_LOCATION_SHARD(Any* duration, Any* data, BOOL p2, BOOL p3) { return Function.Call<int>(0xD05590C1AB38F068, duration, data, p2, p3); }
		public static unsafe Any _UI_FEED_POST_OBJECTIVE(Any* p0, Any* p1, BOOL p2) { return Function.Call<Any>(0xCEDBF17EFCC0E4A4, p0, p1, p2); }
		public static unsafe Any _UI_FEED_POST_FEED_TICKER(Any* p0, Any* p1, BOOL p2) { return Function.Call<Any>(0xB2920B9760F0F36B, p0, p1, p2); }
		public static unsafe Any _UI_FEED_POST_SAMPLE_TOAST(Any* p0, Any* p1, BOOL p2, BOOL p3) { return Function.Call<Any>(0x26E87218390E6729, p0, p1, p2, p3); }
		public static Any _0xAFF5BE9BA496CE40(Any p0, Any p1, Any p2, Any p3, Any p4) { return Function.Call<Any>(0xAFF5BE9BA496CE40, p0, p1, p2, p3, p4); }
		public static unsafe Any _UI_FEED_POST_SAMPLE_TOAST_WITH_APP_LINK(Any* p0, Any* p1, BOOL p2, BOOL p3, BOOL p4) { return Function.Call<Any>(0x38838A646FB30AAE, p0, p1, p2, p3, p4); }
		public static unsafe Any _UI_FEED_POST_SAMPLE_NOTIFICATION(Any* p0, Any* p1, int p2, int p3) { return Function.Call<Any>(0xC927890AA64E9661, p0, p1, p2, p3); }
		public static Any _UI_FEED_POST_RANKUP_TOAST(Any p0, Any p1, Any p2, Any p3) { return Function.Call<Any>(0x3F9FDDBA79117C69, p0, p1, p2, p3); }
		public static Any _0x18D6869FBFFEC0F8(Any p0, Any p1, Any p2, Any p3) { return Function.Call<Any>(0x18D6869FBFFEC0F8, p0, p1, p2, p3); }
		public static unsafe Any _UI_FEED_POST_SAMPLE_TOAST_RIGHT(Any* p0, Any* p1, BOOL p2) { return Function.Call<Any>(0xB249EBCB30DD88E0, p0, p1, p2); }
		public static unsafe Any _UI_FEED_POST_MISSION_NAME(Any* p0, Any* p1, BOOL p2) { return Function.Call<Any>(0x2024F4F333095FB1, p0, p1, p2); }
		public static unsafe Any _UI_FEED_POST_RETICLE_MESSAGE(Any* p0, Any* p1, BOOL p2) { return Function.Call<Any>(0x893128CDB4B81FBB, p0, p1, p2); }
		public static unsafe Any _UI_FEED_POST_ONE_TEXT_SHARD(Any* p0, Any* p1, BOOL p2) { return Function.Call<Any>(0x860DDFE97CC94DF0, p0, p1, p2); }
		public static unsafe Any _UI_FEED_POST_TWO_TEXT_SHARD(Any* p0, Any* p1, BOOL p2, BOOL p3) { return Function.Call<Any>(0xA6F4216AB10EB08E, p0, p1, p2, p3); }
		public static unsafe Any _UI_FEED_POST_THREE_TEXT_SHARD(Any* p0, Any* p1, BOOL p2, BOOL p3, BOOL p4) { return Function.Call<Any>(0x02BCC0FE9EBA3529, p0, p1, p2, p3, p4); }
		public static unsafe Any _UI_FEED_POST_GAME_UPDATE_SHARD(Any* p0, Any* p1, BOOL p2) { return Function.Call<Any>(0x8D1249BD28791878, p0, p1, p2); }
		public static unsafe Any _UI_FEED_POST_VOICE_CHAT_FEED(Any* p0, Any* p1, BOOL p2) { return Function.Call<Any>(0xC48152BC6B3E821C, p0, p1, p2); }
		public static void UI_FEED_CLEAR_CHANNEL(Any p0, Any p1, Any p2) { Function.Call(0xDD1232B332CBB9E7, p0, p1, p2); }
		public static void _UI_FEED_CLEAR_ALL_CHANNELS() { Function.Call(0x6035E8FBCA32AC5E); }
		public static void _UI_FEED_CLEAR_HELP_TEXT_FEED(Any p0, Any p1) { Function.Call(0x2F901291EF177B02, p0, p1); }
		public static void _0x6D85126F6CCF02C9(Any p0, Any p1, Any p2) { Function.Call(0x6D85126F6CCF02C9, p0, p1, p2); }
		public static Any _0x4E88A65968A55C78(Any p0, Any p1) { return Function.Call<Any>(0x4E88A65968A55C78, p0, p1); }
		public static Any _0x0FD07141AD048AAE(Any p0, Any p1) { return Function.Call<Any>(0x0FD07141AD048AAE, p0, p1); }
		public static int _UI_FEED_GET_MESSAGE_STATE(Any p0) { return Function.Call<int>(0x59FA676177DBE4C9, p0); }
		public static int UI_FEED_GET_CURRENT_MESSAGE(int p0) { return Function.Call<int>(0xC17F69E1418CD11F, p0); }
		public static BOOL _0xB7223B91CD6B7E07(int p0) { return Function.Call<BOOL>(0xB7223B91CD6B7E07, p0); }
	}

	public static class UILOG
	{
		public static BOOL _UILOG_IS_ENTRY_REGISTERED(int p0, Hash p1) { return Function.Call<BOOL>(0xB8188CCF52202475, p0, p1); }
		public static void _UILOG_ADD_ENTRY_HASH(int p0, int p1, float x, float y, float z, Hash p5, Hash p6, Any p7) { Function.Call(0x69D5479982355D8F, p0, p1, x, y, z, p5, p6, p7); }
		public static void _UILOG_ADD_ITEM_TO_TASK_LIST(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7) { Function.Call(0x49C63FDF69744A27, p0, p1, p2, p3, p4, p5, p6, p7); }
		public static void _UILOG_SET_ENTRY_ICON_TEXTURE(int p0, Hash p1, Hash icon, Hash iconDictionary) { Function.Call(0x6965469934958D8F, p0, p1, icon, iconDictionary); }
		public static void _UILOG_SET_ENTRY_BRIEF_TEXTURE(int p0, Hash p1, Hash texture, Hash textureDictionary) { Function.Call(0x69684D9936958D8F, p0, p1, texture, textureDictionary); }
		public static void _UILOG_UPDATE_ENTRY_SUBHEADER(int p0, Hash p1, string p2) { Function.Call(0x80D6524190258C3E, p0, p1, p2); }
		public static void _UILOG_SET_ENTRY_PINNED(int p0, Hash p1, BOOL p2) { Function.Call(0x72A5CD214B342568, p0, p1, p2); }
		public static void _UILOG_MARK_MISSION_COMPLETED(Hash p0) { Function.Call(0xDE31D66D1E54C471, p0); }
		public static void _UILOG_MARK_ENTRY_AVAILABILITY(int p0, Hash p1, int p2, string p3) { Function.Call(0x13E8D7DD08543482, p0, p1, p2, p3); }
		public static void _UILOG_MARK_ALL_ENTRIES_AVAILABILITY(int p0, string p1) { Function.Call(0x3920574CF0A2B7B6, p0, p1); }
		public static void _UILOG_REMOVE_ENTRY(int p0, Hash p1) { Function.Call(0xD594A19BE09A75C6, p0, p1); }
		public static void _0xA31013798FADCADC(Any p0, Any p1, Any p2) { Function.Call(0xA31013798FADCADC, p0, p1, p2); }
		public static void _0xA49D6D503E3EA847(Any p0, Any p1, Any p2, Any p3, Any p4) { Function.Call(0xA49D6D503E3EA847, p0, p1, p2, p3, p4); }
		public static void _0x763637F9B838B0A7(Any p0, Any p1, Any p2) { Function.Call(0x763637F9B838B0A7, p0, p1, p2); }
		public static void _UILOG_CLEAR_ALL_ENTRIES() { Function.Call(0xB95B4EA6B1EDF035); }
		public static void _UILOG_ADD_OR_UPDATE_OBJECTIVE(int p0, Hash p1, Hash p2, string p3, BOOL p4, BOOL p5, BOOL p6) { Function.Call(0xB43163388484CC87, p0, p1, p2, p3, p4, p5, p6); }
		public static void _0xA20398536B7F1134(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5) { Function.Call(0xA20398536B7F1134, p0, p1, p2, p3, p4, p5); }
		public static void _UILOG_SET_CACHED_OBJECTIVE(string p0) { Function.Call(0xFA233F8FE190514C, p0); }
		public static void _UILOG_CLEAR_CACHED_OBJECTIVE() { Function.Call(0xDFF0D417277B41F8); }
		public static BOOL _UILOG_HAS_DISPLAYED_CACHED_OBJECTIVE() { return Function.Call<BOOL>(0xCC48FFBB45B54F71); }
		public static void _UILOG_CLEAR_HAS_DISPLAYED_CACHED_OBJECTIVE() { Function.Call(0xA3108D6981A5CADB); }
		public static void _UILOG_SET_HAS_DISPLAYED_CACHED_OBJECTIVE() { Function.Call(0xA3108D6981A5CADC); }
		public static string _UILOG_GET_CACHED_OBJECTIVE() { return Function.Call<string>(0x15A4461BEB788096); }
		public static void _UILOG_PRINT_CACHED_OBJECTIVE() { Function.Call(0xE9990552DEC71600); }
		public static Any _UILOG_SET_PENDING_DETAILS_ID(int p0, Hash p1) { return Function.Call<Any>(0x136A027CF37B0A4F, p0, p1); }
		public static Any _0x2A4765812202E671() { return Function.Call<Any>(0x2A4765812202E671); }
		public static void _UILOG_ADD_TOTAL_TAKE_ENTRY(Hash p0, Hash p1, string p2, string p3, Hash p4) { Function.Call(0x60C59968E8E87E6B, p0, p1, p2, p3, p4); }
		public static void _UILOG_SET_TOTAL_TAKE_SUMMARY(string p0, string p1) { Function.Call(0xD106B211EF1B8F04, p0, p1); }
		public static unsafe int _UILOG_POST_NOTIFICATION(Any* data) { return Function.Call<int>(0x49E58FE6EF40B987, data); }
		public static void _0xDA0A30153FCC0FFD() { Function.Call(0xDA0A30153FCC0FFD); }
	}

	public static class UIPINNING
	{
		public static string _0x3138582E0A13BFAB(Hash hash) { return Function.Call<string>(0x3138582E0A13BFAB, hash); }
	}

	public static class UITUTORIAL
	{
		public static BOOL _UITUTORIAL_GET_IS_THREAT_INDICATOR_CAPABLE_RADAR_SHOWN() { return Function.Call<BOOL>(0x2CC24A2A7A1489C4); }
		public static BOOL _UITUTORIAL_GET_IS_THREAT_INDICATOR_ON() { return Function.Call<BOOL>(0xFC2E0A5E9ED4E1B4); }
		public static void _UITUTORIAL_SET_RPG_ICON_VISIBILITY(int rpgIcon, int visibility) { Function.Call(0xC116E6DF68DCE667, rpgIcon, visibility); }
	}

	public static class UISTATEMACHINE
	{
		public static Any _UIFLOWBLOCK_REQUEST(Any p0) { return Function.Call<Any>(0xC0081B34E395CE48, p0); }
		public static void _UIFLOWBLOCK_RELEASE(Any p0) { Function.Call(0xF320A77DD5F781DF, p0); }
		public static Any _UIFLOWBLOCK_IS_LOADED(Any p0) { return Function.Call<Any>(0x10A93C057B6BD944, p0); }
		public static Any _UIFLOWBLOCK_ENTER(Any p0, Any p1) { return Function.Call<Any>(0x3B7519720C9DCB45, p0, p1); }
		public static Any UI_STATE_MACHINE_EXISTS(Any p0) { return Function.Call<Any>(0x5D15569C0FEBF757, p0); }
		public static Any UI_STATE_MACHINE_CREATE(Any p0, Any p1) { return Function.Call<Any>(0x4C6F2C4B7A03A266, p0, p1); }
		public static Any UI_STATE_MACHINE_CAN_REQUEST_TRANSITION(Any p0) { return Function.Call<Any>(0xF7C180F57F85D0B8, p0); }
		public static Any UI_STATE_MACHINE_REQUEST_TRANSITION(Any p0, Any p1) { return Function.Call<Any>(0x7EA9C3547E80350E, p0, p1); }
		public static void UI_STATE_MACHINE_REQUEST_EXIT(Any p0, Any p1) { Function.Call(0x6B9FE4F0BA521A19, p0, p1); }
		public static BOOL _UI_STATE_MACHINE_IS_EXITED(Hash p0) { return Function.Call<BOOL>(0x11E73195E735B25B, p0); }
		public static void UI_STATE_MACHINE_DESTROY(Any p0) { Function.Call(0x4EB122210A90E2D8, p0); }
		public static unsafe void UI_STATE_MACHINE_DESTROY_AND_CLEAR(Any* p0) { Function.Call(0x2738D68D2B4E09E7, p0); }
	}

	public static class UISTICKYFEED
	{
		public static unsafe int _UI_STICKY_FEED_CREATE_ERROR_MESSAGE(Any* p0, Any* p1, BOOL p2) { return Function.Call<int>(0x9F2CC2439A04E7BA, p0, p1, p2); }
		public static unsafe int _UI_STICKY_FEED_CREATE_DEATH_FAIL_MESSAGE(Any* p0, Any* p1, BOOL p2) { return Function.Call<int>(0x815C4065AE6E6071, p0, p1, p2); }
		public static unsafe int _UI_STICKY_FEED_CREATE_WARNING_MESSAGE(Any* p0, Any* p1, BOOL p2) { return Function.Call<int>(0x339E16B41780FC35, p0, p1, p2); }
		public static unsafe void _UI_STICKY_FEED_UPDATE_MESSAGE(int msgId, Any* p1, BOOL p2) { Function.Call(0xBC6F454E310124DA, msgId, p1, p2); }
		public static void _UI_STICKY_FEED_CLEAR_MESSAGE(int msgId) { Function.Call(0x00A15B94CBA4F76F, msgId); }
		public static BOOL _UI_STICKY_FEED_IS_CHANNEL_ACTIVE(int p0) { return Function.Call<BOOL>(0xC5C395C60B542A3C, p0); }
		public static BOOL _UI_STICKY_FEED_IS_ALERT_SCREEN_ACTIVE() { return Function.Call<BOOL>(0xF8806EC3FF840FDC); }
		public static int _UI_STICKY_FEED_GET_MESSAGE_STATE(int msgId) { return Function.Call<int>(0x07954320D77F6A3D, msgId); }
	}

	public static class UNLOCK
	{
		public static BOOL _UNLOCK_IS_UNLOCK_FLAG_SET(Hash unlockHash, int flag) { return Function.Call<BOOL>(0x6B6369647F26F09F, unlockHash, flag); }
		public static BOOL UNLOCK_IS_UNLOCKED(Hash unlockHash) { return Function.Call<BOOL>(0xC4B660C7B6040E75, unlockHash); }
		public static void UNLOCK_SET_UNLOCKED(Hash unlockHash, BOOL toggle) { Function.Call(0x1B7C5ADA8A6910A0, unlockHash, toggle); }
		public static BOOL UNLOCK_IS_VISIBLE(Hash unlockHash) { return Function.Call<BOOL>(0x8588A14B75AF096B, unlockHash); }
		public static void UNLOCK_SET_VISIBLE(Hash unlockHash, BOOL toggle) { Function.Call(0x46B901A8ECDB5A61, unlockHash, toggle); }
		public static BOOL _UNLOCK_IS_NEW(Hash unlockHash) { return Function.Call<BOOL>(0x644166BA7AA49DEA, unlockHash); }
		public static void _UNLOCK_SET_NEW(Hash unlockHash, BOOL toggle) { Function.Call(0xA6D79C7AEF870A99, unlockHash, toggle); }
		public static BOOL _UNLOCK_IS_LOOTABLE(Hash unlockHash) { return Function.Call<BOOL>(0x66BF197E066050DE, unlockHash); }
		public static unsafe void _0x7C1C2062CFAD06FE(Hash unlockHash, Any* data) { Function.Call(0x7C1C2062CFAD06FE, unlockHash, data); }
	}

	public static class VEHICLE
	{
		public static void _0x6355602C02EDC6DF(int entity, Any p1) { Function.Call(0x6355602C02EDC6DF, entity, p1); }
		public static void _SET_VEHICLE_IS_IN_HURRY(int vehicle, BOOL enabled) { Function.Call(0xCE1531927AD6C9F8, vehicle, enabled); }
		public static int CREATE_VEHICLE(Hash modelHash, float x, float y, float z, float heading, BOOL isNetwork, BOOL bScriptHostVeh, BOOL bDontAutoCreateDraftAnimals, BOOL p8) { return Function.Call<int>(0xAF35D0D2583051B0, modelHash, x, y, z, heading, isNetwork, bScriptHostVeh, bDontAutoCreateDraftAnimals, p8); }
		public static int _CREATE_DRAFT_VEHICLE(Hash modelHash, float x, float y, float z, float heading, BOOL isNetwork, BOOL bScriptHostVeh, BOOL bDontAutoCreateDraftAnimals, Hash draftAnimalPopGroup, BOOL p9) { return Function.Call<int>(0x214651FB1DFEBA89, modelHash, x, y, z, heading, isNetwork, bScriptHostVeh, bDontAutoCreateDraftAnimals, draftAnimalPopGroup, p9); }
		public static unsafe void DELETE_VEHICLE(int* vehicle) { Function.Call(0xE20A909D8C4A70F8, vehicle); }
		public static unsafe void _FADE_AND_DESTROY_VEHICLE(int* vehicle) { Function.Call(0x35DC1877312FBA0F, vehicle); }
		public static BOOL _IS_VEHICLE_FADING_OUT(int vehicle) { return Function.Call<BOOL>(0x5136B284B67B35C7, vehicle); }
		public static void _0x1240E8596A8308B9(Any p0, Any p1) { Function.Call(0x1240E8596A8308B9, p0, p1); }
		public static void SET_VEHICLE_ALLOW_NO_PASSENGERS_LOCKON(int veh, BOOL toggle) { Function.Call(0xECB9E9BC887E8060, veh, toggle); }
		public static BOOL IS_VEHICLE_MODEL(int vehicle, Hash model) { return Function.Call<BOOL>(0x0045A54EC7A22455, vehicle, model); }
		public static void _SET_ALL_VEHICLE_GENERATORS_DISABLED_FOR_VOLUME(Volume volume, BOOL toggle) { Function.Call(0x424FFCB9F0D2D4B5, volume, toggle); }
		public static void SET_ALL_VEHICLE_GENERATORS_ACTIVE_IN_AREA(float x1, float y1, float z1, float x2, float y2, float z2, BOOL p6, BOOL p7) { Function.Call(0xBBB134FB9D50C0CC, x1, y1, z1, x2, y2, z2, p6, p7); }
		public static void SET_ALL_VEHICLE_GENERATORS_ACTIVE() { Function.Call(0x3D596E6E88A02C24); }
		public static BOOL SET_VEHICLE_ON_GROUND_PROPERLY(int vehicle, BOOL p1) { return Function.Call<BOOL>(0x7263332501E07F52, vehicle, p1); }
		public static BOOL IS_VEHICLE_STOPPED(int vehicle) { return Function.Call<BOOL>(0x78C3311A73135241, vehicle); }
		public static int GET_VEHICLE_NUMBER_OF_PASSENGERS(int vehicle) { return Function.Call<int>(0x59F3F16577CD79B2, vehicle); }
		public static int GET_VEHICLE_MAX_NUMBER_OF_PASSENGERS(int vehicle) { return Function.Call<int>(0xA9C55F1C15E62E06, vehicle); }
		public static int GET_VEHICLE_MODEL_NUMBER_OF_SEATS(Hash modelHash) { return Function.Call<int>(0x9A578736FF3A17C3, modelHash); }
		public static BOOL IS_SEAT_WARP_ONLY(int vehicle, int seatIndex) { return Function.Call<BOOL>(0x7892685BF6D9775E, vehicle, seatIndex); }
		public static unsafe BOOL _GET_VEHICLE_TURRET_SEAT(int vehicle, int* seatIndex) { return Function.Call<BOOL>(0xFF5791B7639C2A46, vehicle, seatIndex); }
		public static Any _0xA9E185D498B9AC67(Any p0, Any p1) { return Function.Call<Any>(0xA9E185D498B9AC67, p0, p1); }
		public static void SET_VEHICLE_DENSITY_MULTIPLIER_THIS_FRAME(float multiplier) { Function.Call(0x606374EBFC27B133, multiplier); }
		public static void SET_RANDOM_VEHICLE_DENSITY_MULTIPLIER_THIS_FRAME(float multiplier) { Function.Call(0x1F91D44490E1EA0C, multiplier); }
		public static void SET_PARKED_VEHICLE_DENSITY_MULTIPLIER_THIS_FRAME(float multiplier) { Function.Call(0xFEDFA97638D61D4A, multiplier); }
		public static void SET_DISABLE_RANDOM_TRAINS_THIS_FRAME(BOOL toggle) { Function.Call(0xD4288603E8766FF7, toggle); }
		public static void SET_VEHICLE_DOORS_LOCKED(int vehicle, int doorLockStatus) { Function.Call(0x96F78A6A075D55D9, vehicle, doorLockStatus); }
		public static void SET_VEHICLE_INDIVIDUAL_DOORS_LOCKED(int vehicle, int doorId, int doorLockStatus) { Function.Call(0xA9F1D75195CC40F6, vehicle, doorId, doorLockStatus); }
		public static void SET_VEHICLE_DOORS_LOCKED_FOR_PLAYER(int vehicle, int player, BOOL toggle) { Function.Call(0x359A8EA1FB8D6F0F, vehicle, player, toggle); }
		public static BOOL GET_VEHICLE_DOORS_LOCKED_FOR_PLAYER(int vehicle, int player) { return Function.Call<BOOL>(0xFA2CDDFEB8BC898B, vehicle, player); }
		public static void SET_VEHICLE_DOORS_LOCKED_FOR_ALL_PLAYERS(int vehicle, BOOL toggle) { Function.Call(0x2381977DA948F8DC, vehicle, toggle); }
		public static void SET_VEHICLE_DOORS_LOCKED_FOR_TEAM(int vehicle, int team, BOOL toggle) { Function.Call(0xE712BC978770F105, vehicle, team, toggle); }
		public static BOOL _GET_VEHICLE_DOORS_LOCKED_FOR_TEAM(int vehicle, int team) { return Function.Call<BOOL>(0xDD1E1393D966D39A, vehicle, team); }
		public static void EXPLODE_VEHICLE(int vehicle, BOOL isAudible, BOOL isInvisible, Any p3, Any p4) { Function.Call(0x75DCED9EEC5769D7, vehicle, isAudible, isInvisible, p3, p4); }
		public static void _0x750D42C013F64AE7(Any p0, Any p1) { Function.Call(0x750D42C013F64AE7, p0, p1); }
		public static void _0xE78993FF9022C064(Any p0) { Function.Call(0xE78993FF9022C064, p0); }
		public static void _0x9868C0D0134855F7(Any p0) { Function.Call(0x9868C0D0134855F7, p0); }
		public static void _HIDE_HORSE_REINS(int vehicle) { Function.Call(0x201B8ED4FF7FE9F5, vehicle); }
		public static void _SHOW_HORSE_REINS(int vehicle) { Function.Call(0x41CDA90EE3450921, vehicle); }
		public static void _0xD21A3D421E7F09F7(Any p0, Any p1) { Function.Call(0xD21A3D421E7F09F7, p0, p1); }
		public static void _0xA13028E22564A1BD(Any p0, Any p1) { Function.Call(0xA13028E22564A1BD, p0, p1); }
		public static void _0x485B05EF05B9AEE9(Any p0, Any p1) { Function.Call(0x485B05EF05B9AEE9, p0, p1); }
		public static void SET_BOAT_ANCHOR(int vehicle, BOOL toggle) { Function.Call(0xAEAB044F05B92659, vehicle, toggle); }
		public static void _0x6B53F4B811E583D2(int vehicle, BOOL toggle) { Function.Call(0x6B53F4B811E583D2, vehicle, toggle); }
		public static BOOL CAN_ANCHOR_BOAT_HERE(int vehicle) { return Function.Call<BOOL>(0xC075176CFB8B4128, vehicle); }
		public static void _SET_BOAT_FROZEN_WHEN_ANCHORED(int vehicle, BOOL p1, BOOL p2) { Function.Call(0x286771F3059A37A7, vehicle, p1, p2); }
		public static void _0x75B49ACD73617437(int vehicle, BOOL p1) { Function.Call(0x75B49ACD73617437, vehicle, p1); }
		public static void _SET_BOAT_MOVEMENT_RESISTANCE(int vehicle, float value) { Function.Call(0xE3261532550D6A9F, vehicle, value); }
		public static void SET_BOAT_SINKS_WHEN_WRECKED(int vehicle, BOOL toggle) { Function.Call(0x62A6D317A011EA1D, vehicle, toggle); }
		public static void _SET_FORCE_HIGH_LOD_VEHICLE(int vehicle, BOOL p1) { Function.Call(0x1098CDA477890165, vehicle, p1); }
		public static void _0x98A7598C579EE871(Any p0, Any p1, Any p2) { Function.Call(0x98A7598C579EE871, p0, p1, p2); }
		public static void _0x9E8711C81AA17876(int vehicle, BOOL p1) { Function.Call(0x9E8711C81AA17876, vehicle, p1); }
		public static void SET_VEHICLE_STRONG(int vehicle, BOOL toggle) { Function.Call(0xAB315515C9F8803D, vehicle, toggle); }
		public static BOOL IS_VEHICLE_SEAT_FREE(int vehicle, int seatIndex) { return Function.Call<BOOL>(0xE052C1B1CAA4ECE4, vehicle, seatIndex); }
		public static int GET_PED_IN_VEHICLE_SEAT(int vehicle, int seatIndex) { return Function.Call<int>(0xBB40DD2270B65366, vehicle, seatIndex); }
		public static int GET_LAST_PED_IN_VEHICLE_SEAT(int vehicle, int seatIndex) { return Function.Call<int>(0x74583B19FEEAFDA7, vehicle, seatIndex); }
		public static BOOL IS_DRAFT_VEHICLE(int vehicle) { return Function.Call<BOOL>(0xEA44E97849E9F3DD, vehicle); }
		public static int _GET_PED_IN_DRAFT_HARNESS(int vehicle, int harnessId) { return Function.Call<int>(0xA8BA0BAE0173457B, vehicle, harnessId); }
		public static void SET_VEHICLE_FORWARD_SPEED(int vehicle, float speed) { Function.Call(0xF9F92AF49F12F6E7, vehicle, speed); }
		public static void BRING_VEHICLE_TO_HALT(int vehicle, float distance, int duration, BOOL unknown) { Function.Call(0x260BE8F09E326A20, vehicle, distance, duration, unknown); }
		public static BOOL _IS_VEHICLE_BROUGHT_TO_HALT(int vehicle) { return Function.Call<BOOL>(0x404527BC03DA0E6C, vehicle); }
		public static void _STOP_BRING_VEHICLE_TO_HALT(int vehicle) { Function.Call(0x7C06330BFDDA182E, vehicle); }
		public static void _0xE12F5ED49F44D40D(Any p0) { Function.Call(0xE12F5ED49F44D40D, p0); }
		public static void _0xF6E3D38869D0F7AD(Any p0) { Function.Call(0xF6E3D38869D0F7AD, p0); }
		public static void SET_VEHICLE_DOORS_SHUT(int vehicle, BOOL closeInstantly) { Function.Call(0xA4FFCD645B11F25A, vehicle, closeInstantly); }
		public static void SET_VEHICLE_TYRES_CAN_BURST(int vehicle, BOOL toggle) { Function.Call(0xEBD0A4E935106FE5, vehicle, toggle); }
		public static void SET_VEHICLE_WHEELS_CAN_BREAK(int vehicle, BOOL enabled) { Function.Call(0x839137C40275FB77, vehicle, enabled); }
		public static void SET_VEHICLE_DOORS_TO_OPEN_AT_ANY_DISTANCE(int vehicle, BOOL toggle) { Function.Call(0x362CEDD2A41E0747, vehicle, toggle); }
		public static void SET_VEHICLE_DOOR_OPEN(int vehicle, int doorId, BOOL loose, BOOL openInstantly) { Function.Call(0x550CE392A4672412, vehicle, doorId, loose, openInstantly); }
		public static void REMOVE_VEHICLE_WINDOW(int vehicle, int windowIndex) { Function.Call(0x745F15A215F2DDF1, vehicle, windowIndex); }
		public static void _0x8878FF3EEE2868A9(Any p0, Any p1) { Function.Call(0x8878FF3EEE2868A9, p0, p1); }
		public static void _SET_VEHICLE_DIRT_LEVEL_2(int vehicle, float dirtLevel) { Function.Call(0xBAE0EEDF93F05EAA, vehicle, dirtLevel); }
		public static void _SET_VEHICLE_MUD_LEVEL(int vehicle, float mudLevel) { Function.Call(0x4D15E49764CB328A, vehicle, mudLevel); }
		public static void SET_VEHICLE_LIGHTS(int vehicle, int state) { Function.Call(0x629F0A0E952CAE7D, vehicle, state); }
		public static void SET_RANDOM_TRAINS(BOOL toggle) { Function.Call(0x1156C6EE7E82A98A, toggle); }
		public static int _0x331CBD247FC5DAA8(Hash configHash, float x, float y, float z, BOOL direction, BOOL p5) { return Function.Call<int>(0x331CBD247FC5DAA8, configHash, x, y, z, direction, p5); }
		public static BOOL _0x0516FAE561276EFC(int trackIndex) { return Function.Call<BOOL>(0x0516FAE561276EFC, trackIndex); }
		public static int _GET_TRAIN_TRACK_FROM_TRAIN_VEHICLE(int train) { return Function.Call<int>(0x45853F4E17D847D5, train); }
		public static int _GET_TRAIN_VEHICLE_FROM_TRACK_INDEX(int trackIndex) { return Function.Call<int>(0x6E585A616ABB8401, trackIndex); }
		public static void _0x15206E88FF7617DF(int trackIndex, float p1) { Function.Call(0x15206E88FF7617DF, trackIndex, p1); }
		public static void _0xA7966807953A18EE(int trackIndex, float p1) { Function.Call(0xA7966807953A18EE, trackIndex, p1); }
		public static void _0x6B34BE961F639E21(int trackIndex, int p1) { Function.Call(0x6B34BE961F639E21, trackIndex, p1); }
		public static void _0xE6BD7DD3FD474415(int train, BOOL p1) { Function.Call(0xE6BD7DD3FD474415, train, p1); }
		public static void _0x615B3B8E73634509(int trackIndex, float p1) { Function.Call(0x615B3B8E73634509, trackIndex, p1); }
		public static void _0x38E7DD70A242D5CB(int trackIndex, int p1) { Function.Call(0x38E7DD70A242D5CB, trackIndex, p1); }
		public static void _0x63509DDF102E08E8(int trackIndex, int p1) { Function.Call(0x63509DDF102E08E8, trackIndex, p1); }
		public static void _0x7408B5C66BA31ADB(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8, Any p9, Any p10) { Function.Call(0x7408B5C66BA31ADB, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10); }
		public static void _0x41365DB586CD9E8E(int trackIndex, float p1) { Function.Call(0x41365DB586CD9E8E, trackIndex, p1); }
		public static void _0xD0AABE5B9F8FA589(int trackIndex, float p1) { Function.Call(0xD0AABE5B9F8FA589, trackIndex, p1); }
		public static void _0x427C919E9809E370(int trackIndex, int p1) { Function.Call(0x427C919E9809E370, trackIndex, p1); }
		public static BOOL _DOES_TRAIN_EXIST_ON_TRACK(int trackIndex) { return Function.Call<BOOL>(0xC29996A337BDD099, trackIndex); }
		public static Vector3 _GET_TRAIN_POSITION_ON_TRACK(int trackIndex) { return Function.Call<Vector3>(0x1E8A921112891651, trackIndex); }
		public static BOOL _0xB4241AD8F5AEE9ED(int trackIndex) { return Function.Call<BOOL>(0xB4241AD8F5AEE9ED, trackIndex); }
		public static void _0xA230A5DDE12ED374(Any p0) { Function.Call(0xA230A5DDE12ED374, p0); }
		public static void _0x0D5FDF0D36FA10CD(int trackIndex) { Function.Call(0x0D5FDF0D36FA10CD, trackIndex); }
		public static void _0xE682002DB1F30669(Any p0) { Function.Call(0xE682002DB1F30669, p0); }
		public static void _0x718EB706B6E998A0(int trackIndex) { Function.Call(0x718EB706B6E998A0, trackIndex); }
		public static BOOL _0xF05DFAF1ADFEF2CD(Hash trainConfig, float x, float y, float z, BOOL direction, BOOL p5) { return Function.Call<BOOL>(0xF05DFAF1ADFEF2CD, trainConfig, x, y, z, direction, p5); }
		public static Any _0xD1DF5E54F4ACBE1A(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6) { return Function.Call<Any>(0xD1DF5E54F4ACBE1A, p0, p1, p2, p3, p4, p5, p6); }
		public static Any _0x0FDDEE66E3465726(Any p0) { return Function.Call<Any>(0x0FDDEE66E3465726, p0); }
		public static void _0x4C05B42A8D937796() { Function.Call(0x4C05B42A8D937796); }
		public static void _0xB961DD799A837BD7() { Function.Call(0xB961DD799A837BD7); }
		public static void _0x16B86A49E072AA85() { Function.Call(0x16B86A49E072AA85); }
		public static void _0x2A7413168F6CD5A8() { Function.Call(0x2A7413168F6CD5A8); }
		public static void _0xFFFE15B433300B8C(Any p0, Any p1, Any p2) { Function.Call(0xFFFE15B433300B8C, p0, p1, p2); }
		public static void _0x6EA1273D525427F4(Any p0, Any p1, Any p2) { Function.Call(0x6EA1273D525427F4, p0, p1, p2); }
		public static Any _0x7BE0746539DEF0C8(Any p0, Any p1) { return Function.Call<Any>(0x7BE0746539DEF0C8, p0, p1); }
		public static void _0x3137EDC899E6DAE4(Any p0, Any p1) { Function.Call(0x3137EDC899E6DAE4, p0, p1); }
		public static int _0x6C87F49BFA181DB5(float x, float y, float z) { return Function.Call<int>(0x6C87F49BFA181DB5, x, y, z); }
		public static int _GET_TRACK_INDEX_FROM_COORDS(float x, float y, float z) { return Function.Call<int>(0x85D39F5E3B6D7EB0, x, y, z); }
		public static Vector3 _GET_NEAREST_TRAIN_TRACK_POSITION(float x, float y, float z) { return Function.Call<Vector3>(0x6DE03BCC15E81710, x, y, z); }
		public static void DELETE_ALL_TRAINS() { Function.Call(0xA3120A1385F17FF7); }
		public static Any _0x0E558D3A49D759D6(Any p0, Any p1) { return Function.Call<Any>(0x0E558D3A49D759D6, p0, p1); }
		public static void _0xD4907EF4334C7602(Any p0, Any p1) { Function.Call(0xD4907EF4334C7602, p0, p1); }
		public static void _0x68830738A6BFB370(Any p0, Any p1) { Function.Call(0x68830738A6BFB370, p0, p1); }
		public static void SET_TRAIN_SPEED(int train, float speed) { Function.Call(0xDFBA6BBFF7CCAFBB, train, speed); }
		public static void _SET_TRAIN_MAX_SPEED(int train, float speed) { Function.Call(0x9F29999DFDF2AEB8, train, speed); }
		public static void SET_TRAIN_CRUISE_SPEED(int train, float speed) { Function.Call(0x01021EB2E96B793C, train, speed); }
		public static int _GET_TRAIN_CARRIAGE_TRAILER_NUMBER(int train) { return Function.Call<int>(0x60B7D1DCC312697D, train); }
		public static Hash _GET_TRAIN_MODEL_FROM_TRAIN_CONFIG_BY_CAR_INDEX(Hash trainConfig, int trainCarIndex) { return Function.Call<Hash>(0x8DF5F6A19F99F0D5, trainConfig, trainCarIndex); }
		public static int _GET_NUM_CARS_FROM_TRAIN_CONFIG(Hash trainConfig) { return Function.Call<int>(0x635423D55CA84FC8, trainConfig); }
		public static int _GET_TRAIN_CAR(int train) { return Function.Call<int>(0x671A07C9A1CD50A5, train); }
		public static void _SET_TRAIN_STOPS_FOR_STATIONS(int train, BOOL toggle) { Function.Call(0x4182C037AA1F0091, train, toggle); }
		public static void _0xDD100CE1EBBF37E3(Any p0, Any p1) { Function.Call(0xDD100CE1EBBF37E3, p0, p1); }
		public static void _0x160C1B5AB48AB87C(int train, float p1) { Function.Call(0x160C1B5AB48AB87C, train, p1); }
		public static BOOL IS_TRAIN_WAITING_AT_STATION(int train) { return Function.Call<BOOL>(0xE887BD31D97793F6, train); }
		public static void _SET_TRAIN_HALT(int train) { Function.Call(0x3660BCAB3A6BB734, train); }
		public static void _SET_TRAIN_LEAVE_STATION(int train) { Function.Call(0x787E43477746876F, train); }
		public static void SET_RANDOM_BOATS(BOOL toggle) { Function.Call(0xF44D446D4E36DB87, toggle); }
		public static void REQUEST_VEHICLE_RECORDING(int recording, string script) { Function.Call(0xC474CF16EDA45DC9, recording, script); }
		public static BOOL HAS_VEHICLE_RECORDING_BEEN_LOADED(int recording, string script) { return Function.Call<BOOL>(0xBA9325BE372AB6EA, recording, script); }
		public static unsafe void REMOVE_VEHICLE_RECORDING(Any p0, Any* p1) { Function.Call(0x139E35755418F6AA, p0, p1); }
		public static Vector3 GET_POSITION_OF_VEHICLE_RECORDING_AT_TIME(int recording, float time, string script) { return Function.Call<Vector3>(0x1A00961A1BE94E5E, recording, time, script); }
		public static Vector3 GET_ROTATION_OF_VEHICLE_RECORDING_AT_TIME(int recording, float time, string script) { return Function.Call<Vector3>(0x61787DD28B8CC0D5, recording, time, script); }
		public static float GET_TIME_POSITION_IN_RECORDING(int vehicle) { return Function.Call<float>(0x233B51C7913FA031, vehicle); }
		public static void START_PLAYBACK_RECORDED_VEHICLE(int vehicle, int recording, string script, BOOL p3) { Function.Call(0x4932B84E3276508E, vehicle, recording, script, p3); }
		public static void FORCE_PLAYBACK_RECORDED_VEHICLE_UPDATE(int vehicle, BOOL p1) { Function.Call(0x59ECA796021B0539, vehicle, p1); }
		public static void STOP_PLAYBACK_RECORDED_VEHICLE(int vehicle) { Function.Call(0xBF9B4D6267E8C26D, vehicle); }
		public static BOOL IS_PLAYBACK_GOING_ON_FOR_VEHICLE(int vehicle) { return Function.Call<BOOL>(0x02774B3A9034278F, vehicle); }
		public static BOOL IS_PLAYBACK_USING_AI_GOING_ON_FOR_VEHICLE(int vehicle) { return Function.Call<BOOL>(0x5A7472606EC5B7C1, vehicle); }
		public static void SET_PLAYBACK_SPEED(int vehicle, float speed) { Function.Call(0xD78084EED4CD94C6, vehicle, speed); }
		public static void SKIP_TIME_IN_PLAYBACK_RECORDED_VEHICLE(int vehicle, float time) { Function.Call(0x5F5E6379C59EFC56, vehicle, time); }
		public static int GET_CLOSEST_VEHICLE(float x, float y, float z, float radius, Hash modelHash, int flags) { return Function.Call<int>(0x52F45D033645181B, x, y, z, radius, modelHash, flags); }
		public static int GET_TRAIN_CARRIAGE(int train, int trailerNumber) { return Function.Call<int>(0xD0FB093A4CDB932C, train, trailerNumber); }
		public static unsafe void DELETE_MISSION_TRAIN(int* train) { Function.Call(0x0D3630FB07E8B570, train); }
		public static unsafe void SET_MISSION_TRAIN_AS_NO_LONGER_NEEDED(int* train, BOOL p1) { Function.Call(0xBBE7648349B49BE8, train, p1); }
		public static void SET_MISSION_TRAIN_COORDS(int train, float x, float y, float z) { Function.Call(0x7632755962AB9922, train, x, y, z); }
		public static void _SET_MISSION_TRAIN_WARP_TO_COORDS(int train, float x, float y, float z, BOOL direction) { Function.Call(0xC9EA26893C9E4024, train, x, y, z, direction); }
		public static void _0xA72B1BF3857B94D7(int train, BOOL p1) { Function.Call(0xA72B1BF3857B94D7, train, p1); }
		public static BOOL _IS_THIS_MODEL_A_DRAFT_VEHICLE(Hash model) { return Function.Call<BOOL>(0xB9D5BDDA88E1BB66, model); }
		public static BOOL IS_THIS_MODEL_A_BOAT(Hash model) { return Function.Call<BOOL>(0x799CFC7C5B743B15, model); }
		public static BOOL IS_THIS_MODEL_A_TRAIN(Hash model) { return Function.Call<BOOL>(0xFC08C8F8C1EDF174, model); }
		public static void SET_VEHICLE_CAN_BE_TARGETTED(int vehicle, BOOL state) { Function.Call(0x05254BA0B44ADC16, vehicle, state); }
		public static void _0x63DC1F22C903B709(int vehicle, BOOL p1) { Function.Call(0x63DC1F22C903B709, vehicle, p1); }
		public static void SET_VEHICLE_CAN_BE_VISIBLY_DAMAGED(int vehicle, BOOL state) { Function.Call(0x4BF8131AE811541C, vehicle, state); }
		public static void SET_VEHICLE_HAS_UNBREAKABLE_LIGHTS(int vehicle, BOOL p1) { Function.Call(0xC903855E028A05F2, vehicle, p1); }
		public static void SET_VEHICLE_RESPECTS_LOCKS_WHEN_HAS_DRIVER(int vehicle, BOOL p1) { Function.Call(0x33992A808DF1C1BA, vehicle, p1); }
		public static void _0x065D03A9D6B2C6B5(Any p0, Any p1) { Function.Call(0x065D03A9D6B2C6B5, p0, p1); }
		public static void SET_VEHICLE_DIRT_LEVEL(int vehicle, float dirtLevel) { Function.Call(0x758C3460EE915D0A, vehicle, dirtLevel); }
		public static BOOL IS_VEHICLE_DOOR_FULLY_OPEN(int vehicle, int doorId) { return Function.Call<BOOL>(0x7AE191143C7A9107, vehicle, doorId); }
		public static void SET_VEHICLE_ENGINE_ON(int vehicle, BOOL value, BOOL instantly) { Function.Call(0xB64CFA14CB9A2E78, vehicle, value, instantly); }
		public static void SET_VEHICLE_UNDRIVEABLE(int vehicle, BOOL toggle) { Function.Call(0x6E884BAB713A2A94, vehicle, toggle); }
		public static void SET_VEHICLE_PROVIDES_COVER(int vehicle, BOOL toggle) { Function.Call(0x652712478F1721F4, vehicle, toggle); }
		public static void _0x3053064F909B5F42(Any p0, Any p1) { Function.Call(0x3053064F909B5F42, p0, p1); }
		public static void SET_VEHICLE_DOOR_CONTROL(int vehicle, int doorId, int speed, float angle) { Function.Call(0xD57F10EBBA814ECF, vehicle, doorId, speed, angle); }
		public static void SET_VEHICLE_DOOR_LATCHED(int vehicle, int doorId, BOOL p2, BOOL p3, BOOL p4) { Function.Call(0x06F8A202EB312A3C, vehicle, doorId, p2, p3, p4); }
		public static void SET_VEHICLE_DOOR_SHUT(int vehicle, int doorId, BOOL closeInstantly) { Function.Call(0x6A3C24B91FD0EA09, vehicle, doorId, closeInstantly); }
		public static void SET_VEHICLE_DOOR_BROKEN(int vehicle, int doorId, BOOL deleteDoor) { Function.Call(0x9666CF20A1C6D780, vehicle, doorId, deleteDoor); }
		public static void SET_VEHICLE_CAN_BREAK(int vehicle, BOOL toggle) { Function.Call(0xC5ED9D59B4646611, vehicle, toggle); }
		public static void SET_VEHICLE_IS_CONSIDERED_BY_PLAYER(int vehicle, BOOL toggle) { Function.Call(0x54800D386C5825E5, vehicle, toggle); }
		public static void _0x7549B9E841940695(int vehicle, BOOL p1) { Function.Call(0x7549B9E841940695, vehicle, p1); }
		public static int GET_VEHICLE_DOOR_LOCK_STATUS(int vehicle) { return Function.Call<int>(0xC867FD144F2469D3, vehicle); }
		public static void _SET_VEHICLE_DOOR_CAN_BREAK(int vehicle, int doorId, BOOL isBreakable) { Function.Call(0x081FB9D6422F804C, vehicle, doorId, isBreakable); }
		public static BOOL IS_VEHICLE_ON_ALL_WHEELS(int vehicle) { return Function.Call<BOOL>(0x0D5D119529654EE0, vehicle); }
		public static BOOL _GET_TRAIN_DIRECTION(int train) { return Function.Call<BOOL>(0x3C9628A811CBD724, train); }
		public static BOOL _GET_TRAIN_DIRECTION_FROM_INDEX(int trackIndex) { return Function.Call<BOOL>(0x67995318F5FAA496, trackIndex); }
		public static unsafe Any _0x09034479E6E3E269(int train, Hash* trainTrack, int* junctionIndex) { return Function.Call<Any>(0x09034479E6E3E269, train, trainTrack, junctionIndex); }
		public static unsafe BOOL _GET_TRAIN_TRACK_JUNCTION_AT_COORDS(Hash trainTrack, float x, float y, float z, int* junctionIndex) { return Function.Call<BOOL>(0x86AFC343CF7F0B34, trainTrack, x, y, z, junctionIndex); }
		public static Any _0xD9BF3ED8EFB67EA3(Any p0, Any p1, Any p2, Any p3, Any p4) { return Function.Call<Any>(0xD9BF3ED8EFB67EA3, p0, p1, p2, p3, p4); }
		public static Vector3 _0x785639D89F8451AB(Any p0, Any p1) { return Function.Call<Vector3>(0x785639D89F8451AB, p0, p1); }
		public static void _SET_TRAIN_TRACK_JUNCTION_SWITCH(Hash trainTrack, int junctionIndex, BOOL enabled) { Function.Call(0xE6C5E2125EB210C1, trainTrack, junctionIndex, enabled); }
		public static void _0x3ABFA128F5BF5A70(Hash trainTrack, int junctionIndex, BOOL enabled) { Function.Call(0x3ABFA128F5BF5A70, trainTrack, junctionIndex, enabled); }
		public static Any _0x2C46D2A591D8C322(Any p0, Any p1, Any p2) { return Function.Call<Any>(0x2C46D2A591D8C322, p0, p1, p2); }
		public static Any _0xCAFF2C9747103C02(Any p0, Any p1, Any p2) { return Function.Call<Any>(0xCAFF2C9747103C02, p0, p1, p2); }
		public static void _SET_ALL_JUNCTIONS_CLEARED() { Function.Call(0x138398153824E332); }
		public static void _0x34BCF6209B9668A7(int trackIndex, Any p1) { Function.Call(0x34BCF6209B9668A7, trackIndex, p1); }
		public static void _0xD0BA1853D76683C8(int trackIndex, float x, float y, float z, Any p4) { Function.Call(0xD0BA1853D76683C8, trackIndex, x, y, z, p4); }
		public static void SET_TRAIN_OFFSET_FROM_STATION(int train, float offset) { Function.Call(0x8EC47DD4300BF063, train, offset); }
		public static void _0xDC69F6913CCA0B99(Any p0, Any p1) { Function.Call(0xDC69F6913CCA0B99, p0, p1); }
		public static void _0x7840576C50A13DBA(int train, BOOL p1) { Function.Call(0x7840576C50A13DBA, train, p1); }
		public static Any _0xD0116DF21E6C7B36(Any p0, Any p1) { return Function.Call<Any>(0xD0116DF21E6C7B36, p0, p1); }
		public static void _DETACH_WAGON_ENTITY_FROM_TRAIN(int entity) { Function.Call(0x54CBDD6E1B4CB4DF, entity); }
		public static int _0x1180A2974D251B7B(int train) { return Function.Call<int>(0x1180A2974D251B7B, train); }
		public static int GET_CURRENT_STATION_FOR_TRAIN(int train) { return Function.Call<int>(0x86FA6D8B48667D75, train); }
		public static Hash _0x9CC94A948EAF5372(int trackIndex, int stationIndex) { return Function.Call<Hash>(0x9CC94A948EAF5372, trackIndex, stationIndex); }
		public static Any _0xDE8C5B9F65017FA1(int train) { return Function.Call<Any>(0xDE8C5B9F65017FA1, train); }
		public static int _GET_CURRENT_TRACK_FOR_TRAIN(int train) { return Function.Call<int>(0xAF787E081AC4A8EE, train); }
		public static Vector3 _GET_STATION_COORS_FROM_TRAIN_STATION_DATA(int trackIndex, int stationIndex) { return Function.Call<Vector3>(0xBA958F68031DDBFC, trackIndex, stationIndex); }
		public static int GET_TRACK_INDEX_OF_TRAIN(int train) { return Function.Call<int>(0x865FEC2FA899F29C, train); }
		public static void _0x1A861F899EBBE17C(int train, BOOL p1) { Function.Call(0x1A861F899EBBE17C, train, p1); }
		public static void _0xF8F7DA13CFBD4532(int trackIndex, BOOL p1) { Function.Call(0xF8F7DA13CFBD4532, trackIndex, p1); }
		public static void _TRIGGER_TRAIN_WHISTLE(int train, string whistleSequence, BOOL p2, BOOL p3) { Function.Call(0xCFE122EC635CC2B2, train, whistleSequence, p2, p3); }
		public static void _0x2BB2B5BCF0DF8008(Any p0, Any p1) { Function.Call(0x2BB2B5BCF0DF8008, p0, p1); }
		public static void _0x6703872EC09BC158(Any p0, Any p1) { Function.Call(0x6703872EC09BC158, p0, p1); }
		public static void _0x1BFBAFCC6760FF02(int train, BOOL p1) { Function.Call(0x1BFBAFCC6760FF02, train, p1); }
		public static Any _0xF5EA41C1408695FB(Any p0, Any p1, Any p2, Any p3) { return Function.Call<Any>(0xF5EA41C1408695FB, p0, p1, p2, p3); }
		public static void SET_VEHICLE_FIXED(int vehicle) { Function.Call(0x79811282A9D1AE56, vehicle); }
		public static void SET_DISABLE_VEHICLE_PETROL_TANK_FIRES(int vehicle, BOOL toggle) { Function.Call(0xB70986AB19B04AFF, vehicle, toggle); }
		public static void SET_DISABLE_VEHICLE_PETROL_TANK_DAMAGE(int vehicle, BOOL toggle) { Function.Call(0x5795FBE7A2001C14, vehicle, toggle); }
		public static void SET_DISABLE_VEHICLE_ENGINE_FIRES(int vehicle, BOOL p1) { Function.Call(0xD146EE5F2B06B95E, vehicle, p1); }
		public static void _0x8F75941C86EEBFCA(int vehicle, BOOL p1) { Function.Call(0x8F75941C86EEBFCA, vehicle, p1); }
		public static void _0xC84E138448507567(int vehicle, BOOL p1) { Function.Call(0xC84E138448507567, vehicle, p1); }
		public static void REMOVE_VEHICLES_FROM_GENERATORS_IN_AREA(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5) { Function.Call(0xC619A44639BC0CB4, p0, p1, p2, p3, p4, p5); }
		public static void SET_VEHICLE_STEER_BIAS(int vehicle, float value) { Function.Call(0x84DAAE11E9EE4FC3, vehicle, value); }
		public static BOOL IS_VEHICLE_EXTRA_TURNED_ON(int vehicle, int extraId) { return Function.Call<BOOL>(0xFA9A55D9C4351625, vehicle, extraId); }
		public static void SET_VEHICLE_EXTRA(int vehicle, int extraId, BOOL disable) { Function.Call(0xBB6F89150BC9D16B, vehicle, extraId, disable); }
		public static BOOL DOES_EXTRA_EXIST(int vehicle, int extraId) { return Function.Call<BOOL>(0xAF5E7E9A7620FFB5, vehicle, extraId); }
		public static void SET_VEHICLE_DAMAGE(int vehicle, float xOffset, float yOffset, float zOffset, float damage, float radius, BOOL p6) { Function.Call(0x1D7678F81452BB41, vehicle, xOffset, yOffset, zOffset, damage, radius, p6); }
		public static float GET_VEHICLE_ENGINE_HEALTH(int vehicle) { return Function.Call<float>(0x90DBFFAC43B22081, vehicle); }
		public static void SET_VEHICLE_ENGINE_HEALTH(int vehicle, float health) { Function.Call(0x8BDC5B998B4654EF, vehicle, health); }
		public static float GET_VEHICLE_PETROL_TANK_HEALTH(int vehicle) { return Function.Call<float>(0x1E5A9B356D5098BE, vehicle); }
		public static void SET_VEHICLE_PETROL_TANK_HEALTH(int vehicle, float health) { Function.Call(0x6AB2918EE3BEC94C, vehicle, health); }
		public static BOOL IS_VEHICLE_STUCK_TIMER_UP(int vehicle, int stuckType, int ms) { return Function.Call<BOOL>(0x1ABA9753939503C5, vehicle, stuckType, ms); }
		public static void RESET_VEHICLE_STUCK_TIMER(int vehicle, int nullAttributes) { Function.Call(0x23298B468F7D88B6, vehicle, nullAttributes); }
		public static BOOL IS_VEHICLE_DRIVEABLE(int vehicle, BOOL p1, BOOL p2) { return Function.Call<BOOL>(0xB86D29B10F627379, vehicle, p1, p2); }
		public static BOOL IS_VEHICLE_WRECKED(int vehicle) { return Function.Call<BOOL>(0xDDBEA5506C848227, vehicle); }
		public static BOOL _IS_VEHICLE_ON_FIRE(int vehicle) { return Function.Call<BOOL>(0x0E3BF7ED4169EC43, vehicle); }
		public static void SET_VEHICLE_HAS_BEEN_OWNED_BY_PLAYER(int vehicle, BOOL owned) { Function.Call(0xBB5A3FA8ED3979C5, vehicle, owned); }
		public static void START_VEHICLE_HORN(int vehicle, int duration, Hash mode, BOOL forever) { Function.Call(0xB4E3BFC39CA16057, vehicle, duration, mode, forever); }
		public static void SET_VEHICLE_HAS_STRONG_AXLES(int vehicle, BOOL toggle) { Function.Call(0x252253C8A45AA1FC, vehicle, toggle); }
		public static void _SET_VEHICLE_SNOW_LEVEL(int vehicle, float snowLevel) { Function.Call(0x6F73EFAB11651D7F, vehicle, snowLevel); }
		public static void _SET_VEHICLE_WET_LEVEL(int vehicle, float wetLevel) { Function.Call(0x5AABB09F6FBD1F87, vehicle, wetLevel); }
		public static void _SET_VEHICLE_TINT(int vehicle, int tintId) { Function.Call(0x8268B098F6FCA4E2, vehicle, tintId); }
		public static void _SET_VEHICLE_LIVERY(int vehicle, int liveryIndex) { Function.Call(0xF89D82A0582E46ED, vehicle, liveryIndex); }
		public static int _GET_VEHICLE_TINT(int vehicle) { return Function.Call<int>(0xA44D65E6C624526F, vehicle); }
		public static int _GET_VEHICLE_LIVERY(int vehicle) { return Function.Call<int>(0xBB765B8FD49A796C, vehicle); }
		public static BOOL IS_VEHICLE_WINDOW_INTACT(int vehicle, int windowIndex) { return Function.Call<BOOL>(0x0E7910A63E05B12C, vehicle, windowIndex); }
		public static BOOL ARE_ANY_VEHICLE_SEATS_FREE(int vehicle) { return Function.Call<BOOL>(0xA0A424505A1B6429, vehicle); }
		public static void SET_VEHICLE_EXPLODES_ON_HIGH_EXPLOSION_DAMAGE(int vehicle, BOOL toggle) { Function.Call(0xA402939C6761E1A3, vehicle, toggle); }
		public static void _0x8D3230A0ED7DE39F(int vehicle, BOOL p1) { Function.Call(0x8D3230A0ED7DE39F, vehicle, p1); }
		public static BOOL IS_ANY_VEHICLE_NEAR_POINT(float x, float y, float z, float radius) { return Function.Call<BOOL>(0x5698BA4FD04D39C4, x, y, z, radius); }
		public static void REQUEST_VEHICLE_HIGH_DETAIL_MODEL(int vehicle) { Function.Call(0x84B81EF78BD22357, vehicle); }
		public static void REQUEST_VEHICLE_ASSET(Hash vehicleHash, int vehicleAsset) { Function.Call(0x81A15811460FAB3A, vehicleHash, vehicleAsset); }
		public static void _0xCF9DA72002FC16BF(Any p0, Any p1, Any p2) { Function.Call(0xCF9DA72002FC16BF, p0, p1, p2); }
		public static BOOL HAS_VEHICLE_ASSET_LOADED(int vehicleAsset) { return Function.Call<BOOL>(0xB935F3154BC913C8, vehicleAsset); }
		public static void REMOVE_VEHICLE_ASSET(int vehicleAsset) { Function.Call(0x888A4E675B38F5AD, vehicleAsset); }
		public static Any SET_VEHICLE_AUTOMATICALLY_ATTACHES(int vehicle, BOOL p1, Any p2) { return Function.Call<Any>(0x501354951CD942DE, vehicle, p1, p2); }
		public static void _0x104D9A7B1C0D0783(int vehicle, float p1) { Function.Call(0x104D9A7B1C0D0783, vehicle, p1); }
		public static BOOL IS_VEHICLE_IN_BURNOUT(int vehicle) { return Function.Call<BOOL>(0x3F5029A8FC060C48, vehicle); }
		public static void SET_VEHICLE_HANDBRAKE(int vehicle, BOOL toggle) { Function.Call(0x91BE51AEC4E99710, vehicle, toggle); }
		public static void INSTANTLY_FILL_VEHICLE_POPULATION() { Function.Call(0x1FF00DB43026B12F); }
		public static BOOL HAS_INSTANT_FILL_VEHICLE_POPULATION_FINISHED() { return Function.Call<BOOL>(0x2701D01D5E18FC31); }
		public static unsafe BOOL GET_VEHICLE_TRAILER_VEHICLE(int vehicle, int* trailer) { return Function.Call<BOOL>(0xCF867A239EC30741, vehicle, trailer); }
		public static float GET_VEHICLE_ESTIMATED_MAX_SPEED(int vehicle) { return Function.Call<float>(0xFE52F34491529F0B, vehicle); }
		public static int ADD_ROAD_NODE_SPEED_ZONE(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8, Any p9, Any p10) { return Function.Call<int>(0x4C221BAC54D735C3, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10); }
		public static BOOL REMOVE_ROAD_NODE_SPEED_ZONE(int speedzone) { return Function.Call<BOOL>(0xFE9AB3354ACE6C9C, speedzone); }
		public static BOOL IS_ENTRY_POINT_FOR_SEAT_CLEAR(int ped, int vehicle, int seatIndex, BOOL side, BOOL onEnter) { return Function.Call<BOOL>(0x80DDCCB2F4A3EB57, ped, vehicle, seatIndex, side, onEnter); }
		public static BOOL CAN_SHUFFLE_SEAT(int vehicle, int seatIndex) { return Function.Call<BOOL>(0xF8B2D32A2231FD24, vehicle, seatIndex); }
		public static void MODIFY_VEHICLE_TOP_SPEED(int vehicle, float value) { Function.Call(0x35AD938C74CACD6A, vehicle, value); }
		public static void _0x23A3AB86E0807721(int vehicle, BOOL toggle) { Function.Call(0x23A3AB86E0807721, vehicle, toggle); }
		public static void _0xC1842F40FD501DA2(Any p0, BOOL p1) { Function.Call(0xC1842F40FD501DA2, p0, p1); }
		public static BOOL _IS_BOAT_GROUNDED(int vehicle) { return Function.Call<BOOL>(0x30D86B2B7622D0EB, vehicle); }
		public static void _0x09C970AE59ABF6B2(int vehicle, BOOL p1) { Function.Call(0x09C970AE59ABF6B2, vehicle, p1); }
		public static void LOCK_DOORS_WHEN_NO_LONGER_NEEDED(int vehicle) { Function.Call(0x1EF36558FBDE2DAA, vehicle); }
		public static int GET_LAST_DRIVEN_VEHICLE() { return Function.Call<int>(0xA94F3E0AB9695E19); }
		public static void CLEAR_LAST_DRIVEN_VEHICLE() { Function.Call(0x0EFC5DC62E67609B); }
		public static void SET_PED_OWNS_VEHICLE(int ped, int vehicle) { Function.Call(0x838C216C2B05A009, ped, vehicle); }
		public static int _GET_VEHICLE_OWNER(int vehicle) { return Function.Call<int>(0xB729679356A889AE, vehicle); }
		public static void SET_VEHICLE_LOD_MULTIPLIER(int vehicle, float multiplier) { Function.Call(0x5F5E2B1B9EAECC0F, vehicle, multiplier); }
		public static void _SET_VEHICLE_LOD_LEVEL(int vehicle, int lodLevel) { Function.Call(0x3FA7D7D1E0EA809E, vehicle, lodLevel); }
		public static void _0x7F8E2B131E1DCA6C(Any p0, BOOL p1) { Function.Call(0x7F8E2B131E1DCA6C, p0, p1); }
		public static void COPY_VEHICLE_DAMAGES(int sourceVehicle, int targetVehicle) { Function.Call(0xDBC28A8C683CD80B, sourceVehicle, targetVehicle); }
		public static void SET_VEHICLE_SHOOT_AT_TARGET(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5) { Function.Call(0xB79BE78C665B3E6D, p0, p1, p2, p3, p4, p5); }
		public static void SET_FORCE_HD_VEHICLE(int vehicle, BOOL toggle) { Function.Call(0x373CB1283308BD7B, vehicle, toggle); }
		public static void TRACK_VEHICLE_VISIBILITY(int vehicle) { Function.Call(0x1F3969B140DEE157, vehicle); }
		public static BOOL IS_VEHICLE_VISIBLE(int vehicle) { return Function.Call<BOOL>(0x424910CD5DE8C246, vehicle); }
		public static Any _0x13C190302369308B(Any p0) { return Function.Call<Any>(0x13C190302369308B, p0); }
		public static void SET_ENABLE_VEHICLE_SLIPSTREAMING(BOOL p0) { Function.Call(0x73F1E4F6DF26FE30, p0); }
		public static void SET_VEHICLE_INACTIVE_DURING_PLAYBACK(int vehicle, BOOL toggle) { Function.Call(0x4EA71B4C9DB3C3F1, vehicle, toggle); }
		public static void SET_VEHICLE_ENGINE_CAN_DEGRADE(int vehicle, BOOL toggle) { Function.Call(0x48E4C137A71C2688, vehicle, toggle); }
		public static void SET_VEHICLE_IS_STOLEN(int vehicle, BOOL isStolen) { Function.Call(0x6C32FC81DFF25C9A, vehicle, isStolen); }
		public static void _0xCBF88256E44D5D39(int vehicle, BOOL p1) { Function.Call(0xCBF88256E44D5D39, vehicle, p1); }
		public static void _0xC325A6BAA62CF8A2(int vehicle, BOOL p1) { Function.Call(0xC325A6BAA62CF8A2, vehicle, p1); }
		public static void _0x0CD7914D17A970AB(Any p0, Any p1) { Function.Call(0x0CD7914D17A970AB, p0, p1); }
		public static void _0x23F66C36F8E5EAAB(Any p0, Any p1) { Function.Call(0x23F66C36F8E5EAAB, p0, p1); }
		public static void _0x697DF68F3A761A50(Any p0) { Function.Call(0x697DF68F3A761A50, p0); }
		public static void _0x27E3F2B57209FA54(Any p0, Any p1) { Function.Call(0x27E3F2B57209FA54, p0, p1); }
		public static void DISABLE_VEHICLE_WEAPON(BOOL disabled, Hash weaponHash, int vehicle, int owner) { Function.Call(0x94B1E71B144356A5, disabled, weaponHash, vehicle, owner); }
		public static void SET_VEHICLE_CAN_BE_USED_BY_FLEEING_PEDS(int vehicle, BOOL toggle) { Function.Call(0xE42952510F84AFDB, vehicle, toggle); }
		public static void SET_VEHICLE_KEEP_ENGINE_ON_WHEN_ABANDONED(int vehicle, BOOL toggle) { Function.Call(0x1549BA7FE83A2383, vehicle, toggle); }
		public static void SET_VEHICLE_WHEELS_CAN_BREAK_OFF_WHEN_BLOW_UP(int vehicle, BOOL toggle) { Function.Call(0xC462C79379ABBCB1, vehicle, toggle); }
		public static void _0x15CC8C33D7FFCC4A(int vehicle, int p1) { Function.Call(0x15CC8C33D7FFCC4A, vehicle, p1); }
		public static void _0x0893DAFBFA67110E(int vehicle, BOOL toggle) { Function.Call(0x0893DAFBFA67110E, vehicle, toggle); }
		public static void SET_VEHICLE_EXCLUSIVE_DRIVER(int vehicle, int ped, int index) { Function.Call(0xC6B9BF123B9463B6, vehicle, ped, index); }
		public static unsafe BOOL _IS_PED_EXCLUSIVE_DRIVER_OF_VEHICLE(int ped, int vehicle, int* _outIndex) { return Function.Call<BOOL>(0xB213D2A560B2E48B, ped, vehicle, _outIndex); }
		public static void _0xDC0556D0F484ECAA(Any p0) { Function.Call(0xDC0556D0F484ECAA, p0); }
		public static void _SET_DISABLE_SUPERDUMMY_MODE(int vehicle, BOOL p1) { Function.Call(0x1716D787D9B94202, vehicle, p1); }
		public static float GET_VEHICLE_BODY_HEALTH(int vehicle) { return Function.Call<float>(0x42113B857E33C16E, vehicle); }
		public static void SET_VEHICLE_BODY_HEALTH(int vehicle, float value) { Function.Call(0x55CCAAE4F28C67A0, vehicle, value); }
		public static Any _0xE777DDF3E78397E8(Any p0) { return Function.Call<Any>(0xE777DDF3E78397E8, p0); }
		public static void _0xCEC4CA2CAB8FA98C(int vehicle, BOOL p1) { Function.Call(0xCEC4CA2CAB8FA98C, vehicle, p1); }
		public static void _0x012701ED938B85DE(float p0, float p1) { Function.Call(0x012701ED938B85DE, p0, p1); }
		public static void _0x8379E05871AD24E0() { Function.Call(0x8379E05871AD24E0); }
		public static void _SET_HORSE_TRAFFIC_GROUPING_DISTRIBUTION(Any p0, Any p1, Any p2, Any p3) { Function.Call(0xF5FFB08976911B50, p0, p1, p2, p3); }
		public static BOOL _ATTACH_DRAFT_VEHICLE_HARNESS_PED(int mount, int draft, int harnessId) { return Function.Call<BOOL>(0x316CDB5B6E8F4110, mount, draft, harnessId); }
		public static BOOL _DETACH_DRAFT_VEHICLE_HARNESS_FROM_INDEX(int draft, int harnessId) { return Function.Call<BOOL>(0x4402960666000E62, draft, harnessId); }
		public static BOOL _DETACH_DRAFT_VEHICLE_HARNESS_PED(int draft, int ped) { return Function.Call<BOOL>(0xB36D3EC70963BE60, draft, ped); }
		public static void _0x0F7F603BDE08C4D3(Any p0) { Function.Call(0x0F7F603BDE08C4D3, p0); }
		public static int _GET_NUM_DRAFT_VEHICLE_HARNESS_PED(Hash modelHash) { return Function.Call<int>(0x5B1A26BB18E7D451, modelHash); }
		public static Vector3 _GET_CHECKPOINT_TRAIN_SPAWN_LOCATION(int trackIndex, float x, float y, float z, float distance, BOOL direction) { return Function.Call<Vector3>(0x35D302397E524939, trackIndex, x, y, z, distance, direction); }
		public static void _0xC399CC89FBA05DA0(int vehicle, BOOL p1) { Function.Call(0xC399CC89FBA05DA0, vehicle, p1); }
		public static unsafe void _GET_ROWING_OARS(int vehicle, int* left, int* right) { Function.Call(0xA6E210FB4283B767, vehicle, left, right); }
		public static int GET_DRIVER_OF_VEHICLE(int vehicle) { return Function.Call<int>(0x2963B5C1637E8A27, vehicle); }
		public static void _SET_FORCE_COACH_ROBBERY_LOOT(int vehicle, Hash coachrobberyLoot) { Function.Call(0xF489F94BFEE12BB0, vehicle, coachrobberyLoot); }
		public static Any _0x0BA4250D20007C2E(Any p0) { return Function.Call<Any>(0x0BA4250D20007C2E, p0); }
		public static void _0x2200AB13CBD10F4E(int vehicle, float x, float y, float z, BOOL p4, float p5) { Function.Call(0x2200AB13CBD10F4E, vehicle, x, y, z, p4, p5); }
		public static void _0xB42C87521D1BDD2F(int vehicle, float x, float y, float z) { Function.Call(0xB42C87521D1BDD2F, vehicle, x, y, z); }
		public static void _0xC351394B932A6A50(Any p0) { Function.Call(0xC351394B932A6A50, p0); }
		public static void _0x172E9DD35858DCD7(Any p0) { Function.Call(0x172E9DD35858DCD7, p0); }
		public static int _GET_BREAKABLE_VEHICLE_LOCKS_STATE(int vehicle) { return Function.Call<int>(0xE015CF1F2C0959D8, vehicle); }
		public static Any _0x877EA24EB1614495(Any p0, Any p1, Any p2) { return Function.Call<Any>(0x877EA24EB1614495, p0, p1, p2); }
		public static Object _GET_BREAKABLE_VEHICLE_LOCK_OBJECT(int vehicle, int index) { return Function.Call<Object>(0x58F2244C1286D09A, vehicle, index); }
		public static int _GET_NUM_BREAKABLE_VEHICLE_LOCK_OBJECTS(int vehicle) { return Function.Call<int>(0x2FA86833E3617E2D, vehicle); }
		public static void SET_BREAKABLE_VEHICLE_LOCKS_UNBREAKABLE(int vehicle, BOOL toggle) { Function.Call(0xBC4735F48CD983EF, vehicle, toggle); }
		public static void _0x9D12796EF4BF9EA9(Any p0) { Function.Call(0x9D12796EF4BF9EA9, p0); }
		public static void _0x850CE59DEC2028F3(int vehicle, Any p1) { Function.Call(0x850CE59DEC2028F3, vehicle, p1); }
		public static void _0x0355FE37240E2C77(Any p0, Any p1) { Function.Call(0x0355FE37240E2C77, p0, p1); }
		public static void _0x3D86997A86FEEF0D(Any p0, Any p1) { Function.Call(0x3D86997A86FEEF0D, p0, p1); }
		public static void _0xD826690B5CF3BEFF(int vehicle, Any p1) { Function.Call(0xD826690B5CF3BEFF, vehicle, p1); }
		public static void _BREAK_OFF_DRAFT_WHEEL(int vehicle, int wheelIndex, float destroyingForce) { Function.Call(0xC372B6A88F6E4AD8, vehicle, wheelIndex, destroyingForce); }
		public static unsafe BOOL GET_DRAFT_ANIMAL_COUNT(int vehicle, int* expected, int* actual) { return Function.Call<BOOL>(0xA19447D83294E29F, vehicle, expected, actual); }
		public static void _0x165BE2001E5E4B75(Any p0) { Function.Call(0x165BE2001E5E4B75, p0); }
		public static void _SET_DRAFT_VEHICLE_ANIMALS_CAN_DETACH(int draft, BOOL canDetach) { Function.Call(0x6090A031C69F384E, draft, canDetach); }
		public static void _SET_DRAFT_VEHICLE_YOKE_CAN_BREAK(int draft, BOOL canBreak) { Function.Call(0x226C6A4E3346D288, draft, canBreak); }
		public static void _ADD_TRAIN_TEMPORARY_STOP(int train, int trackIndex, float x, float y, float z) { Function.Call(0x41503629D1139ABC, train, trackIndex, x, y, z); }
		public static void _0x0794199B25E499E1(int wagon, BOOL p1) { Function.Call(0x0794199B25E499E1, wagon, p1); }
		public static void _0x73118A3EE9C9B6DB(int wagon, int p1, BOOL p2) { Function.Call(0x73118A3EE9C9B6DB, wagon, p1, p2); }
		public static BOOL _0xE1C0F8781BF130C2(int wagon, int p1) { return Function.Call<BOOL>(0xE1C0F8781BF130C2, wagon, p1); }
		public static BOOL _IS_VEHICLE_WHEEL_DESTROYED(int vehicle, int wheel) { return Function.Call<BOOL>(0xCB2CA620C48BC875, vehicle, wheel); }
		public static BOOL _0x18714953CCED17D3(int vehicle) { return Function.Call<BOOL>(0x18714953CCED17D3, vehicle); }
		public static void _0x41F0B254DDF71473(int wagon) { Function.Call(0x41F0B254DDF71473, wagon); }
		public static void _SET_VEHICLE_DETERIORATION(int vehicle, float amount, int p2, BOOL p3) { Function.Call(0x8E5DA070BAD3279E, vehicle, amount, p2, p3); }
		public static BOOL _IS_VEHICLE_DOOR_BROKEN(int vehicle, int doorId) { return Function.Call<BOOL>(0xE979BB5602AD3402, vehicle, doorId); }
		public static int _BREAK_OFF_VEHICLE_WHEEL(int vehicle, int wheelIndex) { return Function.Call<int>(0xD4F5EFB55769D272, vehicle, wheelIndex); }
		public static BOOL _DELETE_VEHICLE_LANTERNS(int vehicle) { return Function.Call<BOOL>(0xE1A83D4A3B5D7938, vehicle); }
		public static void _0x6DE072AC8A95FFC1(int vehicle, BOOL p1) { Function.Call(0x6DE072AC8A95FFC1, vehicle, p1); }
		public static void _SET_DRAFT_VEHICLE_DESIRED_SPEED(int vehicle, float speed) { Function.Call(0x0C3F0F7F92CA847C, vehicle, speed); }
		public static float _GET_DRAFT_VEHICLE_DESIRED_SPEED(int vehicle) { return Function.Call<float>(0xC6D7DDC843176701, vehicle); }
		public static void _0xC4A2C11FC0D41916(int vehicle, BOOL p1) { Function.Call(0xC4A2C11FC0D41916, vehicle, p1); }
		public static void _0xFC4F15A7DDDC47B1(int vehicle, BOOL p1) { Function.Call(0xFC4F15A7DDDC47B1, vehicle, p1); }
		public static void _0x4C60C333F9CCA2B6(int vehicle, BOOL p1) { Function.Call(0x4C60C333F9CCA2B6, vehicle, p1); }
		public static void _0xCF342503CA4C8DF1(int vehicle, float p1) { Function.Call(0xCF342503CA4C8DF1, vehicle, p1); }
		public static void _0x06A09A6E0C6D2A84(int train, BOOL p1) { Function.Call(0x06A09A6E0C6D2A84, train, p1); }
		public static void _0xAE7E66A61E7C17A5(int train, BOOL p1) { Function.Call(0xAE7E66A61E7C17A5, train, p1); }
		public static void _0xEF28A614B4B264B8(int train, BOOL p1) { Function.Call(0xEF28A614B4B264B8, train, p1); }
		public static void _0x04F0579DBDD32F34(int vehicle) { Function.Call(0x04F0579DBDD32F34, vehicle); }
		public static void _0x12F6C6ED3EFF42DE(int vehicle, float x, float y, float z) { Function.Call(0x12F6C6ED3EFF42DE, vehicle, x, y, z); }
		public static void _0x87B974E54C71BA7B(int vehicle, BOOL p1) { Function.Call(0x87B974E54C71BA7B, vehicle, p1); }
		public static BOOL _HAS_TRAIN_LOADED(int train) { return Function.Call<BOOL>(0xBD3C4A2ED509205E, train); }
		public static int _CREATE_MISSION_TRAIN(Hash configHash, float x, float y, float z, BOOL direction, BOOL passengers, BOOL p6, BOOL conductor) { return Function.Call<int>(0xC239DBD9A57D2A71, configHash, x, y, z, direction, passengers, p6, conductor); }
		public static void _0xD1EFA8D68BF5D63D(Any p0, Any p1, Any p2, Any p3) { Function.Call(0xD1EFA8D68BF5D63D, p0, p1, p2, p3); }
		public static Any _0x1121B07088ED3013(Any p0) { return Function.Call<Any>(0x1121B07088ED3013, p0); }
		public static Any _0x42404D57D621601A(Any p0) { return Function.Call<Any>(0x42404D57D621601A, p0); }
		public static Any _0x288CBB414C3C2FBB(Any p0) { return Function.Call<Any>(0x288CBB414C3C2FBB, p0); }
		public static void _0x6FD7BDF10304363A(Any p0, Any p1) { Function.Call(0x6FD7BDF10304363A, p0, p1); }
		public static void _0xCEB1F1EED484A5B4(Any p0, Any p1) { Function.Call(0xCEB1F1EED484A5B4, p0, p1); }
		public static Any _0xF57DB8E83DCD8349(Any p0) { return Function.Call<Any>(0xF57DB8E83DCD8349, p0); }
		public static void _SET_BALLOON_HOVER_STATE(int balloon, float p1) { Function.Call(0x7C9E45A4CED2E8DA, balloon, p1); }
		public static void _SET_DRAFT_VEHICLE_ALLOW_DRAFT_ANIMAL_AUTO_CREATION(int vehicle, BOOL allow) { Function.Call(0x87344305778E5415, vehicle, allow); }
		public static void _0x6835AFEA10E186F4(Any p0, Any p1) { Function.Call(0x6835AFEA10E186F4, p0, p1); }
		public static void _SET_DRAFT_ANIMAL_RANDOM_SEED(int vehicle, int seed) { Function.Call(0x8C6D9A399126C194, vehicle, seed); }
		public static Any _0x14DA8C4BC2CCD90A(Any p0) { return Function.Call<Any>(0x14DA8C4BC2CCD90A, p0); }
		public static Any _0xCACAB2B123BBDBD6(Any p0, Any p1, Any p2) { return Function.Call<Any>(0xCACAB2B123BBDBD6, p0, p1, p2); }
		public static void _0xFF2B1F59FB892F14(Any p0) { Function.Call(0xFF2B1F59FB892F14, p0); }
		public static void _0x5AADC7BBBB1BCEEB(Any p0, Any p1, Any p2, Any p3, Any p4) { Function.Call(0x5AADC7BBBB1BCEEB, p0, p1, p2, p3, p4); }
		public static BOOL _GET_VEHICLE_IS_PROP_SET_APPLIED(int vehicle) { return Function.Call<BOOL>(0xD798DF5DB67B1659, vehicle); }
		public static void _SET_BATCH_TARP_HEIGHT(int vehicle, float height, BOOL immediately) { Function.Call(0x31F343383F19C987, vehicle, height, immediately); }
		public static void _0x07E2E21E799080A0(Any p0, Any p1) { Function.Call(0x07E2E21E799080A0, p0, p1); }
		public static void _0xC2E62678D602853C(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6) { Function.Call(0xC2E62678D602853C, p0, p1, p2, p3, p4, p5, p6); }
		public static void _0x873AAF600CC36DAC(Any p0) { Function.Call(0x873AAF600CC36DAC, p0); }
		public static Any _0x51C7694E140FAE43(Any p0) { return Function.Call<Any>(0x51C7694E140FAE43, p0); }
		public static void _0x8DECD262602548B9(Any p0, Any p1) { Function.Call(0x8DECD262602548B9, p0, p1); }
		public static void _0xCBC7B6F9A56B79F6(Any p0, Any p1) { Function.Call(0xCBC7B6F9A56B79F6, p0, p1); }
		public static BOOL _0x37D238BE69F7378A(int trackIndex) { return Function.Call<BOOL>(0x37D238BE69F7378A, trackIndex); }
		public static void _0x703D4FB366DA4452(Any p0, Any p1) { Function.Call(0x703D4FB366DA4452, p0, p1); }
		public static void _0x762FDC4C19E5A981(int trainCarriage, BOOL p1) { Function.Call(0x762FDC4C19E5A981, trainCarriage, p1); }
		public static Any _0x2045429505158D1A(Any p0) { return Function.Call<Any>(0x2045429505158D1A, p0); }
		public static void _0x13EB275BF81636D1(Any p0, Any p1) { Function.Call(0x13EB275BF81636D1, p0, p1); }
	}

	public static class VOICE
	{
		public static BOOL _0xCCF71FCFA0070B1A() { return Function.Call<BOOL>(0xCCF71FCFA0070B1A); }
		public static void _0x79F478FF5F9F4F05(BOOL p0) { Function.Call(0x79F478FF5F9F4F05, p0); }
		public static BOOL _0xAA35FD9ABAB490A3(int player) { return Function.Call<BOOL>(0xAA35FD9ABAB490A3, player); }
		public static unsafe BOOL _0x356135B9B10A2A82(Any* gamerHandle) { return Function.Call<BOOL>(0x356135B9B10A2A82, gamerHandle); }
		public static BOOL _0xEF6F2A35FAAF2ED7(int player) { return Function.Call<BOOL>(0xEF6F2A35FAAF2ED7, player); }
		public static BOOL _0x49623BCFC3A3D829(int player, BOOL muted) { return Function.Call<BOOL>(0x49623BCFC3A3D829, player, muted); }
		public static BOOL _0x919AF2D93E9AA89D(int player) { return Function.Call<BOOL>(0x919AF2D93E9AA89D, player); }
		public static BOOL _0x0DED260A1958A82E(int player) { return Function.Call<BOOL>(0x0DED260A1958A82E, player); }
		public static BOOL _0x8E462DB1EAA9C47C(int player) { return Function.Call<BOOL>(0x8E462DB1EAA9C47C, player); }
		public static float _0x5CA7FB7D6DE49DCC(int player) { return Function.Call<float>(0x5CA7FB7D6DE49DCC, player); }
		public static void _0x58125B691F6827D5(float proximity) { Function.Call(0x58125B691F6827D5, proximity); }
		public static float _0x2F82CAB262C8AE26(int player) { return Function.Call<float>(0x2F82CAB262C8AE26, player); }
		public static void _0x08797A8C03868CB8(float threshold) { Function.Call(0x08797A8C03868CB8, threshold); }
		public static void _0xB779F4FA19269AEC(int p0) { Function.Call(0xB779F4FA19269AEC, p0); }
		public static void _0x1FBF7F5BA7E4BE3A(int p0) { Function.Call(0x1FBF7F5BA7E4BE3A, p0); }
		public static void _0xDC9B361CB7776673(int player) { Function.Call(0xDC9B361CB7776673, player); }
		public static void _0xEC8703E4536A9952() { Function.Call(0xEC8703E4536A9952); }
		public static Any _0xDB622ECD3DCBE078(int player) { return Function.Call<Any>(0xDB622ECD3DCBE078, player); }
		public static void _0xB6E79850B759A30E(int teamId, BOOL allow) { Function.Call(0xB6E79850B759A30E, teamId, allow); }
		public static void _0x4791899615D70FA2(int player, int p1, int p2) { Function.Call(0x4791899615D70FA2, player, p1, p2); }
		public static void _0xF8938CF3984092A5(int player) { Function.Call(0xF8938CF3984092A5, player); }
		public static int _0x767931C727DF2ED7(int player, int p1) { return Function.Call<int>(0x767931C727DF2ED7, player, p1); }
		public static void _0x1C38C3577901AF1F() { Function.Call(0x1C38C3577901AF1F); }
		public static void _0xB3E8841F6BDAF83E() { Function.Call(0xB3E8841F6BDAF83E); }
	}

	public static class VOLUME
	{
		public static Volume _CREATE_VOLUME_BY_HASH(Hash volumeType, float x, float y, float z, float rotX, float rotY, float rotZ, float scaleX, float scaleY, float scaleZ) { return Function.Call<Volume>(0x502022FA1AF9DC86, volumeType, x, y, z, rotX, rotY, rotZ, scaleX, scaleY, scaleZ); }
		public static Volume _CREATE_VOLUME_BOX(float x, float y, float z, float rotX, float rotY, float rotZ, float scaleX, float scaleY, float scaleZ) { return Function.Call<Volume>(0xDF85637F22706891, x, y, z, rotX, rotY, rotZ, scaleX, scaleY, scaleZ); }
		public static Volume _CREATE_VOLUME_CYLINDER(float x, float y, float z, float rotX, float rotY, float rotZ, float scaleX, float scaleY, float scaleZ) { return Function.Call<Volume>(0x0522D4774B82E3E6, x, y, z, rotX, rotY, rotZ, scaleX, scaleY, scaleZ); }
		public static Volume _CREATE_VOLUME_SPHERE(float x, float y, float z, float rotX, float rotY, float rotZ, float scaleX, float scaleY, float scaleZ) { return Function.Call<Volume>(0xB3FB80A32BAE3065, x, y, z, rotX, rotY, rotZ, scaleX, scaleY, scaleZ); }
		public static Volume _CREATE_VOLUME_AGGREGATE() { return Function.Call<Volume>(0x59F6F5C1D129F106); }
		public static Volume _CREATE_VOLUME_BY_HASH_WITH_CUSTOM_NAME(Hash volumeType, float x, float y, float z, float rotX, float rotY, float rotZ, float scaleX, float scaleY, float scaleZ, string name) { return Function.Call<Volume>(0x1F85E4AC774A201E, volumeType, x, y, z, rotX, rotY, rotZ, scaleX, scaleY, scaleZ, name); }
		public static Volume _CREATE_ANTI_GRIEF_VOLUME(Hash volumeType, float x, float y, float z, float rotX, float rotY, float rotZ, float scaleX, float scaleY, float scaleZ) { return Function.Call<Volume>(0x0EB78C2B156635B1, volumeType, x, y, z, rotX, rotY, rotZ, scaleX, scaleY, scaleZ); }
		public static void _SET_ANTI_GRIEF_VOLUME_BLOCKS_HORSE(Volume volume, BOOL toggle) { Function.Call(0xBE551C2CC421185D, volume, toggle); }
		public static void _SET_ANTI_GRIEF_VOLUME_BLOCKS_PLAYER(Volume volume, BOOL toggle) { Function.Call(0x5B23DFF8E0948BB2, volume, toggle); }
		public static Volume _CREATE_WALK_AND_TALK_VOLUME(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8, Any p9, Any p10, Any p11, Any p12) { return Function.Call<Volume>(0xFD0E389CD44434B6, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12); }
		public static Volume _CREATE_SPEED_VOLUME(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6, Any p7, Any p8, Any p9, Any p10, Any p11, Any p12, Any p13, Any p14) { return Function.Call<Volume>(0xBBE768E3AE76E07C, p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14); }
		public static Volume _CREATE_VOLUME_BOX_WITH_CUSTOM_NAME(float x, float y, float z, float rotX, float rotY, float rotZ, float scaleX, float scaleY, float scaleZ, string name) { return Function.Call<Volume>(0xF68485C7495D848E, x, y, z, rotX, rotY, rotZ, scaleX, scaleY, scaleZ, name); }
		public static Volume _CREATE_VOLUME_CYLINDER_WITH_CUSTOM_NAME(float x, float y, float z, float rotX, float rotY, float rotZ, float scaleX, float scaleY, float scaleZ, string name) { return Function.Call<Volume>(0xDF1E350EDDF06E59, x, y, z, rotX, rotY, rotZ, scaleX, scaleY, scaleZ, name); }
		public static Volume _CREATE_VOLUME_SPHERE_WITH_CUSTOM_NAME(float x, float y, float z, float rotX, float rotY, float rotZ, float scaleX, float scaleY, float scaleZ, string name) { return Function.Call<Volume>(0x10157BC3247FF3BA, x, y, z, rotX, rotY, rotZ, scaleX, scaleY, scaleZ, name); }
		public static Volume _CREATE_VOLUME_AGGREGATE_WITH_CUSTOM_NAME(string name) { return Function.Call<Volume>(0x5D580DE6398BB162, name); }
		public static void _ADD_BOUNDS_TO_AGGREGATE_VOLUME(Volume volume, Volume aggregate) { Function.Call(0x6E0D3C3F828DA773, volume, aggregate); }
		public static void _REMOVE_BOUNDS_FROM_AGGREGATE_VOLUME(Volume volume, Volume aggregate) { Function.Call(0xF92FA8890DECECF6, volume, aggregate); }
		public static void _ADD_VOLUME_TO_VOLUME_AGGREGATE(Volume aggregate, Hash typeHash, float x, float y, float z, float rotX, float rotY, float rotZ, float scaleX, float scaleY, float scaleZ) { Function.Call(0x12FCAA23F2320422, aggregate, typeHash, x, y, z, rotX, rotY, rotZ, scaleX, scaleY, scaleZ); }
		public static void _ADD_BOX_VOLUME_TO_VOLUME_AGGREGATE(Volume aggregate, float p1, float p2, float p3, float p4, float p5, float p6, float p7, float p8, float p9) { Function.Call(0x39816F6F94F385AD, aggregate, p1, p2, p3, p4, p5, p6, p7, p8, p9); }
		public static void _ADD_CYLINDER_VOLUME_TO_VOLUME_AGGREGATE(Volume aggregate, float p1, float p2, float p3, float p4, float p5, float p6, float p7, float p8, float p9) { Function.Call(0xBCE668AAF83608BE, aggregate, p1, p2, p3, p4, p5, p6, p7, p8, p9); }
		public static void _ADD_SPHERE_VOLUME_TO_VOLUME_AGGREGATE(Volume aggregate, float p1, float p2, float p3, float p4, float p5, float p6, float p7, float p8, float p9) { Function.Call(0x5B7D7BF36D2DE18B, aggregate, p1, p2, p3, p4, p5, p6, p7, p8, p9); }
		public static void _DELETE_VOLUME(Volume volume) { Function.Call(0x43F867EF5C463A53, volume); }
		public static BOOL DOES_VOLUME_EXIST(Volume volume) { return Function.Call<BOOL>(0x92A78D0BEDB332A3, volume); }
		public static BOOL IS_POINT_IN_VOLUME(Volume volume, float x, float y, float z) { return Function.Call<BOOL>(0xF256A75210C5C0EB, volume, x, y, z); }
		public static Vector3 _GET_VOLUME_COORDS(Volume volume) { return Function.Call<Vector3>(0xF70F00013A62F866, volume); }
		public static BOOL _SET_VOLUME_COORDS(Volume volume, float posX, float posY, float posZ) { return Function.Call<BOOL>(0x541B8576615C33DE, volume, posX, posY, posZ); }
		public static Vector3 _GET_VOLUME_ROTATION(Volume volume) { return Function.Call<Vector3>(0x18675BC914891122, volume); }
		public static BOOL _SET_VOLUME_ROTATION(Volume volume, float rotX, float rotY, float rotZ) { return Function.Call<BOOL>(0xA07CF1B21B56F041, volume, rotX, rotY, rotZ); }
		public static Vector3 _GET_VOLUME_SCALE(Volume volume) { return Function.Call<Vector3>(0x3E2A25B2416DD67E, volume); }
		public static BOOL _SET_VOLUME_SCALE(Volume volume, float scaleX, float scaleY, float scaleZ) { return Function.Call<BOOL>(0xA46E98BDC407E23D, volume, scaleX, scaleY, scaleZ); }
		public static unsafe void _GET_VOLUME_BOUNDS(Volume volume, Vector3* min, Vector3* max) { Function.Call(0x5737199AF2DC609F, volume, min, max); }
		public static void _0x748C5F51A18CB8F0(Any p0) { Function.Call(0x748C5F51A18CB8F0, p0); }
		public static Any _0x2B32B11520626229(Any p0, Any p1, Any p2, Any p3, Any p4) { return Function.Call<Any>(0x2B32B11520626229, p0, p1, p2, p3, p4); }
		public static Any _0x40F769D31A00D5A0(Any p0, Any p1) { return Function.Call<Any>(0x40F769D31A00D5A0, p0, p1); }
		public static Vector3 _0xD882C5B3991575B7(Any p0, Any p1, Any p2, Any p3, Any p4) { return Function.Call<Vector3>(0xD882C5B3991575B7, p0, p1, p2, p3, p4); }
		public static void _0xB469CFD9E065EB99(Any p0, Any p1) { Function.Call(0xB469CFD9E065EB99, p0, p1); }
		public static Any _0x7FD78DFD0C5D7B9B(Any p0) { return Function.Call<Any>(0x7FD78DFD0C5D7B9B, p0); }
		public static Any _0xEE1D6FF54CAF7714(Any p0, Any p1) { return Function.Call<Any>(0xEE1D6FF54CAF7714, p0, p1); }
		public static void _0xD52DF30355EA7C8E(Any p0, Any p1, Any p2) { Function.Call(0xD52DF30355EA7C8E, p0, p1, p2); }
		public static void SET_VOLUME_OWNER_PERSISTENT_CHARACTER(Volume volume, PersChar persChar, BOOL p2) { Function.Call(0xE2BE6FFA4A13CBB0, volume, persChar, p2); }
		public static void _0x6D5F9E69BA1BE783(Any p0) { Function.Call(0x6D5F9E69BA1BE783, p0); }
		public static void _0x998202B206872672(Any p0) { Function.Call(0x998202B206872672, p0); }
		public static void _0x4A8FEFC43FD8AC9B(Any p0, Any p1, Any p2) { Function.Call(0x4A8FEFC43FD8AC9B, p0, p1, p2); }
		public static void _0xF3A2FBA5985C8CD5(Any p0, Any p1, Any p2, Any p3) { Function.Call(0xF3A2FBA5985C8CD5, p0, p1, p2, p3); }
		public static void _0x53D05D60E5F5B40C(Any p0, Any p1, Any p2, Any p3) { Function.Call(0x53D05D60E5F5B40C, p0, p1, p2, p3); }
		public static Any _0xCA5C90D40665D5CE(Any p0, Any p1) { return Function.Call<Any>(0xCA5C90D40665D5CE, p0, p1); }
		public static void _0x3EFABB21E14A6BD1(Any p0, Any p1, Any p2) { Function.Call(0x3EFABB21E14A6BD1, p0, p1, p2); }
		public static BOOL _IS_AGGREGATE_VOLUME(Volume volume) { return Function.Call<BOOL>(0xFEFF01B5725BCD22, volume); }
		public static Volume _CREATE_VOLUME_LOCK(float x, float y, float z, float radius, int flag, Any p5) { return Function.Call<Volume>(0x00BBF7CEAE8C666A, x, y, z, radius, flag, p5); }
		public static Volume _CREATE_VOLUME_LOCK_ATTACHED_TO_ENTITY(int entity, float radius, int flag, Any p3) { return Function.Call<Volume>(0xF383E96C4904DF0C, entity, radius, flag, p3); }
		public static BOOL _IS_VOLUME_LOCK_REQUEST_VALID_2(int volLockRequestId) { return Function.Call<BOOL>(0xF6A8A652A6B186CD, volLockRequestId); }
		public static Vector3 _0xC4019CF9AE8E931A(Any p0) { return Function.Call<Vector3>(0xC4019CF9AE8E931A, p0); }
		public static Any _0xF6CE6F9C3897804E(Any p0) { return Function.Call<Any>(0xF6CE6F9C3897804E, p0); }
		public static Any _0xF6F5447D418DAA82(Any p0) { return Function.Call<Any>(0xF6F5447D418DAA82, p0); }
		public static void _0xD4FA73FE628FEC63(Any p0, Any p1) { Function.Call(0xD4FA73FE628FEC63, p0, p1); }
		public static void _0xB440F4E35393FC39(Any p0, Any p1) { Function.Call(0xB440F4E35393FC39, p0, p1); }
		public static void _0xD460135C98940274(Any p0, Any p1) { Function.Call(0xD460135C98940274, p0, p1); }
		public static void _0xEBA87B9273835CF3(Any p0, Any p1) { Function.Call(0xEBA87B9273835CF3, p0, p1); }
		public static Any _0xAA9EE2AAFC717623(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5) { return Function.Call<Any>(0xAA9EE2AAFC717623, p0, p1, p2, p3, p4, p5); }
		public static Any _0x870E9981ED27C815(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5) { return Function.Call<Any>(0x870E9981ED27C815, p0, p1, p2, p3, p4, p5); }
		public static BOOL DOES_VOLUME_COLLIDE_WITH_ANY_VOLUME_LOCK(float x, float y, float z, float radius, BOOL p4, int p5, int p6) { return Function.Call<BOOL>(0x397769175A7DBB30, x, y, z, radius, p4, p5, p6); }
		public static Any _0x769BB7626B8CDB06(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6) { return Function.Call<Any>(0x769BB7626B8CDB06, p0, p1, p2, p3, p4, p5, p6); }
		public static Any _0x51E52C9687FCDEEC(Any p0, Any p1, Any p2, Any p3, Any p4, Any p5, Any p6) { return Function.Call<Any>(0x51E52C9687FCDEEC, p0, p1, p2, p3, p4, p5, p6); }
		public static unsafe int _FIND_VOLUME_LOCK_REQUEST_ID_WITH_ARGS(Any* args) { return Function.Call<int>(0x77A6E4AD0C496F81, args); }
		public static void _0xEC43C2FFB70E3F30(Any p0, Any p1, Any p2, Any p3) { Function.Call(0xEC43C2FFB70E3F30, p0, p1, p2, p3); }
		public static void _0x695DAC2DB928F308(Any p0, Any p1) { Function.Call(0x695DAC2DB928F308, p0, p1); }
		public static void _RELEASE_LOCK_VOLUME(int volLockRequestId) { Function.Call(0xFDFECC6EE4491E11, volLockRequestId); }
		public static void _0xAC355980681A7F89(Any p0) { Function.Call(0xAC355980681A7F89, p0); }
		public static Any _0x58D3803FA639A3BB(Any p0) { return Function.Call<Any>(0x58D3803FA639A3BB, p0); }
		public static void _0xC61E2FD926DBB406() { Function.Call(0xC61E2FD926DBB406); }
		public static int REQUEST_VOLUME_LOCK(float x, float y, float z, float radius, int p4, int p5) { return Function.Call<int>(0xF14BCEF290F869E1, x, y, z, radius, p4, p5); }
		public static unsafe int REQUEST_VOLUME_LOCK_WITH_ARGS(Any* args) { return Function.Call<int>(0x183C0B6CFEFFCAE4, args); }
		public static BOOL IS_VOLUME_LOCK_REQUEST_VALID(int volLockRequestId) { return Function.Call<BOOL>(0xA4A4359320345B34, volLockRequestId); }
		public static int GET_VOLUME_LOCK_REQUEST_STATUS(int volLockRequestId) { return Function.Call<int>(0xB33A604345F58202, volLockRequestId); }
		public static Any _0x351D71B8B72B858B(Any p0) { return Function.Call<Any>(0x351D71B8B72B858B, p0); }
		public static void _0xFA15C9A320E707B0() { Function.Call(0xFA15C9A320E707B0); }
		public static void _0x52572B331E693AED(Any p0, Any p1, Any p2) { Function.Call(0x52572B331E693AED, p0, p1, p2); }
		public static void _0x128FC3A893BF853A(Any p0) { Function.Call(0x128FC3A893BF853A, p0); }
		public static void _SET_VOLUME_RELATIONSHIP(Volume volume, Hash relationshipGroup) { Function.Call(0xFD010A2154B40676, volume, relationshipGroup); }
		public static Hash _GET_VOLUME_RELATIONSHIP_GROUP_FROM_VOLUME(Volume volume) { return Function.Call<Hash>(0x666C2F53ABEFC952, volume); }
	}

	public static class WATER
	{
		public static void DISABLE_WATER_LOOKUP() { Function.Call(0x754616EC6965D1FB); }
		public static void ENABLE_WATER_LOOKUP() { Function.Call(0x754616EC6965D1BF); }
		public static unsafe BOOL GET_WATER_HEIGHT(float x, float y, float z, float* height) { return Function.Call<BOOL>(0xFCA8B23F28813F69, x, y, z, height); }
		public static unsafe BOOL GET_WATER_HEIGHT_NO_WAVES(float x, float y, float z, float* height) { return Function.Call<BOOL>(0xDCF3690AA262C03F, x, y, z, height); }
		public static unsafe BOOL TEST_PROBE_AGAINST_ALL_WATER(float x1, float y1, float z1, float x2, float y2, float z2, Any p6, Any* p7) { return Function.Call<BOOL>(0x8974647ED222EA5F, x1, y1, z1, x2, y2, z2, p6, p7); }
		public static unsafe BOOL TEST_VERTICAL_PROBE_AGAINST_ALL_WATER(float x, float y, float z, Any p3, float* height) { return Function.Call<BOOL>(0x2B3451FA1E3142E2, x, y, z, p3, height); }
		public static void REMOVE_EXTRA_CALMING_QUAD(int index) { Function.Call(0x4BEF8DD75AF6C71C, index); }
		public static void _0x09A1C7DFDCE54FBC(int p0) { Function.Call(0x09A1C7DFDCE54FBC, p0); }
		public static void _0xF0FBF193F1F5C0EA(int ped) { Function.Call(0xF0FBF193F1F5C0EA, ped); }
		public static void _0xA33F5069B0CB89B8() { Function.Call(0xA33F5069B0CB89B8); }
		public static void _0xB34A6009A0DB80B8(int entity) { Function.Call(0xB34A6009A0DB80B8, entity); }
		public static void _SET_OCEAN_GUARMA_WATER_QUADRANT(float wavesHeight, float p1, int p2, float p3, float p4, float p5, float p6, float wavesStrength, int p8) { Function.Call(0xC63540AEF8384732, wavesHeight, p1, p2, p3, p4, p5, p6, wavesStrength, p8); }
		public static void _0xC63540AEF8384769() { Function.Call(0xC63540AEF8384769); }
		public static void _SET_WORLD_WATER_TYPE(int waterType) { Function.Call(0xE8770EE02AEE45C2, waterType); }
		public static int _GET_WORLD_WATER_TYPE() { return Function.Call<int>(0x189739A7631C1867); }
		public static void _0x0DCEC6A92E497E17(int entity, int p1) { Function.Call(0x0DCEC6A92E497E17, entity, p1); }
		public static void _0xE8126623008372AA() { Function.Call(0xE8126623008372AA); }
	}

	public static class WEAPON
	{
		public static Hash _GET_WEAPON_UNLOCK(Hash weaponHash) { return Function.Call<Hash>(0x865F36299079FB75, weaponHash); }
		public static void _ADD_AMMO_TO_PED(int ped, Hash weaponHash, int amount, Hash addReason) { Function.Call(0xB190BCA3F4042F95, ped, weaponHash, amount, addReason); }
		public static void _ADD_AMMO_TO_PED_BY_TYPE(int ped, Hash ammoType, int amount, Hash addReason) { Function.Call(0x106A811C6D3035F3, ped, ammoType, amount, addReason); }
		public static void _REMOVE_AMMO_FROM_PED(int ped, Hash weaponHash, int amount, Hash removeReason) { Function.Call(0xF4823C813CB8277D, ped, weaponHash, amount, removeReason); }
		public static void _REMOVE_AMMO_FROM_PED_BY_TYPE(int ped, Hash ammoHash, int amount, Hash removeReason) { Function.Call(0xB6CFEC32E3742779, ped, ammoHash, amount, removeReason); }
		public static void _REMOVE_ALL_PED_AMMO(int ped) { Function.Call(0x1B83C0DEEBCBB214, ped); }
		public static void SET_PED_AMMO(int ped, Hash weaponHash, int ammo) { Function.Call(0x14E56BC5B5DB6A19, ped, weaponHash, ammo); }
		public static void _0x8A779706DA5CA3DD(Any p0, Any p1, Any p2) { Function.Call(0x8A779706DA5CA3DD, p0, p1, p2); }
		public static void _0x9409C62504A8F9E9(Any p0, Any p1) { Function.Call(0x9409C62504A8F9E9, p0, p1); }
		public static void _SET_VEHICLE_WEAPON_HEADING_LIMITS(int vehicle, int p1, float minHeading, float maxHeading) { Function.Call(0x56CB3B4305A4F7CE, vehicle, p1, minHeading, maxHeading); }
		public static Any _SET_VEHICLE_WEAPON_HEADING_LIMITS_2(int vehicle, int p1, float minHeading, float maxHeading) { return Function.Call<Any>(0xBF5987E1CDE63501, vehicle, p1, minHeading, maxHeading); }
		public static void SET_VEHICLE_WEAPON_HEADING(int vehicle, int seatIndex, float heading, BOOL p3) { Function.Call(0x194D877FC5597B7D, vehicle, seatIndex, heading, p3); }
		public static void SET_PED_INFINITE_AMMO(int ped, BOOL toggle, Hash weaponHash) { Function.Call(0x3EDCB0505123623B, ped, toggle, weaponHash); }
		public static void _SET_PED_INFINITE_AMMO_CLIP(int ped, BOOL toggle) { Function.Call(0xFBAA1E06B6BCA741, ped, toggle); }
		public static int GET_AMMO_IN_PED_WEAPON(int ped, Hash weaponHash) { return Function.Call<int>(0x015A522136D7F951, ped, weaponHash); }
		public static int GET_MAX_AMMO_IN_CLIP(int ped, Hash weaponHash, BOOL p2) { return Function.Call<int>(0xA38DCFFCEA8962FA, ped, weaponHash, p2); }
		public static unsafe BOOL GET_AMMO_IN_CLIP(int ped, int* ammo, Hash weaponHash) { return Function.Call<BOOL>(0x2E1202248937775C, ped, ammo, weaponHash); }
		public static unsafe BOOL _GET_AMMO_IN_CLIP_BY_INVENTORY_UID(int ped, int* ammo, Any* inventoryUid) { return Function.Call<BOOL>(0x678F00858980F516, ped, ammo, inventoryUid); }
		public static BOOL SET_AMMO_IN_CLIP(int ped, Hash weaponHash, int ammo) { return Function.Call<BOOL>(0xDCD2A934D65CB497, ped, weaponHash, ammo); }
		public static unsafe Any _REFILL_AMMO_IN_CLIP(int ped, Any* clipInventoryUid, int p2) { return Function.Call<Any>(0xDF4A3404D022ADDE, ped, clipInventoryUid, p2); }
		public static unsafe BOOL GET_MAX_AMMO(int ped, int* ammo, Hash weaponHash) { return Function.Call<BOOL>(0xDC16122C7A20C933, ped, ammo, weaponHash); }
		public static void SET_PED_AMMO_BY_TYPE(int ped, Hash ammoType, int ammo) { Function.Call(0x5FD1E1F011E76D7E, ped, ammoType, ammo); }
		public static int GET_PED_AMMO_BY_TYPE(int ped, Hash ammoType) { return Function.Call<int>(0x39D22031557946C1, ped, ammoType); }
		public static void SET_PED_AMMO_TO_DROP(int ped, int p1, int p2) { Function.Call(0xA4EFEF9440A5B0EF, ped, p1, p2); }
		public static Hash _GET_AMMO_TYPE_FOR_WEAPON(Hash weaponHash) { return Function.Call<Hash>(0x5C2EA6C44F515F34, weaponHash); }
		public static Hash GET_PED_AMMO_TYPE_FROM_WEAPON(int ped, Hash weaponHash) { return Function.Call<Hash>(0x7FEAD38B326B9F74, ped, weaponHash); }
		public static Hash _GET_WEAPON_TYPE_FROM_AMMO_TYPE(Hash ammoType) { return Function.Call<Hash>(0x7AA043F6C41D151E, ammoType); }
		public static Hash _GET_WEAPON_COMPONENT_TYPE_MODEL(Hash componentHash) { return Function.Call<Hash>(0x59DE03442B6C9598, componentHash); }
		public static Hash _GET_WEAPONTYPE_MODEL(Hash weaponHash) { return Function.Call<Hash>(0xF70825EB340E7D15, weaponHash); }
		public static Hash _GET_WEAPONTYPE_SLOT(Hash weaponHash) { return Function.Call<Hash>(0x46F032B8DDF46CDE, weaponHash); }
		public static Hash GET_WEAPONTYPE_GROUP(Hash weaponHash) { return Function.Call<Hash>(0xEDCA14CA5199FF25, weaponHash); }
		public static Hash _0xF8204EF17410BF43(Hash weaponGroupHash, float p1, float p2, Any p3) { return Function.Call<Hash>(0xF8204EF17410BF43, weaponGroupHash, p1, p2, p3); }
		public static BOOL _IS_WEAPON_KIT(Hash weaponHash) { return Function.Call<BOOL>(0x6ABAD7B0A854F8FB, weaponHash); }
		public static BOOL _IS_WEAPON_KIT_2(Hash weaponHash) { return Function.Call<BOOL>(0x49E40483948AF062, weaponHash); }
		public static BOOL IS_WEAPON_BOW(Hash weaponHash) { return Function.Call<BOOL>(0xC4DEC3CA8C365A5D, weaponHash); }
		public static BOOL _IS_WEAPON_LANTERN(Hash weaponHash) { return Function.Call<BOOL>(0x79407D33328286C6, weaponHash); }
		public static BOOL _IS_WEAPON_TORCH(Hash weaponHash) { return Function.Call<BOOL>(0x506F1DE1BFC75304, weaponHash); }
		public static unsafe BOOL GIVE_WEAPON_TO_PED_WITH_OPTIONS(int ped, Any* data, Any* _outData) { return Function.Call<BOOL>(0xBE7E42B07FD317AC, ped, data, _outData); }
		public static Hash GIVE_WEAPON_TO_PED(int ped, Hash weaponHash, int ammoCount, BOOL bForceInHand, BOOL bForceInHolster, int attachPoint, BOOL bAllowMultipleCopies, float p7, float p8, Hash addReason, BOOL bIgnoreUnlocks, float permanentDegradation, BOOL p12) { return Function.Call<Hash>(0x5E3BDDBCB83F3D84, ped, weaponHash, ammoCount, bForceInHand, bForceInHolster, attachPoint, bAllowMultipleCopies, p7, p8, addReason, bIgnoreUnlocks, permanentDegradation, p12); }
		public static void _SET_FORCE_CURRENT_WEAPON_INTO_COCKED_STATE(int ped, int attachPoint) { Function.Call(0x5230D3F6EE56CFE6, ped, attachPoint); }
		public static Any _0x9F0E1892C7F228A8(Any p0) { return Function.Call<Any>(0x9F0E1892C7F228A8, p0); }
		public static void _HOLSTER_PED_WEAPONS(int ped, BOOL p1, BOOL p2, BOOL p3, BOOL immediately) { Function.Call(0x94A3C1B804D291EC, ped, p1, p2, p3, immediately); }
		public static void _HIDE_PED_WEAPONS(int ped, int p0, BOOL immediately) { Function.Call(0xFCCC886EDE3C63EC, ped, p0, immediately); }
		public static void _0x4820A6939D7CEF28(Any p0, Any p1) { Function.Call(0x4820A6939D7CEF28, p0, p1); }
		public static void SET_CURRENT_PED_WEAPON(int ped, Hash weaponHash, BOOL equipNow, int attachPoint, BOOL p4, BOOL p5) { Function.Call(0xADF692B254977C0C, ped, weaponHash, equipNow, attachPoint, p4, p5); }
		public static unsafe BOOL GET_CURRENT_PED_WEAPON(int ped, Hash* weaponHash, BOOL p2, int attachPoint, BOOL p4) { return Function.Call<BOOL>(0x3A87E44BB9A01D54, ped, weaponHash, p2, attachPoint, p4); }
		public static int GET_CURRENT_PED_WEAPON_ENTITY_INDEX(int ped, int attachPoint) { return Function.Call<int>(0x3B390A939AF0B5FC, ped, attachPoint); }
		public static BOOL _ENABLE_WEAPON_RESTORE(int ped) { return Function.Call<BOOL>(0xC395355843BE134B, ped); }
		public static Hash GET_PED_BACKUP_WEAPON(int ped, BOOL p1) { return Function.Call<Hash>(0xC71FE230A513C30F, ped, p1); }
		public static Any _0x486C96A0DCD2BC92(Any p0, Any p1) { return Function.Call<Any>(0x486C96A0DCD2BC92, p0, p1); }
		public static Hash _GET_PED_WORST_WEAPON(int ped, BOOL p1, BOOL p2, BOOL p3) { return Function.Call<Hash>(0xDA37A053C1522F5D, ped, p1, p2, p3); }
		public static Hash GET_BEST_PED_WEAPON(int ped, BOOL p1, BOOL p2) { return Function.Call<Hash>(0x8483E98E8B888AE2, ped, p1, p2); }
		public static unsafe Any _GET_BEST_PED_WEAPON_IN_INVENTORY(int ped, Any p1, Any* guidPrimary) { return Function.Call<Any>(0x7B98500614C8E8B8, ped, p1, guidPrimary); }
		public static unsafe void GET_BEST_PED_SHORTARM_GUID(int ped, Any* _outGUID, BOOL p2, BOOL p3) { Function.Call(0xF52BD94B47CCF736, ped, _outGUID, p2, p3); }
		public static unsafe BOOL GET_PED_WEAPON_GUID_AT_ATTACH_POINT(int ped, int attachPoint, Any* weaponGuid) { return Function.Call<BOOL>(0x6929E22158E52265, ped, attachPoint, weaponGuid); }
		public static Hash _GET_BEST_PED_WEAPON_IN_GROUP(int ped, Hash weaponGroup, BOOL p2, BOOL p3) { return Function.Call<Hash>(0x9F67929D98E7C6E8, ped, weaponGroup, p2, p3); }
		public static Hash _GET_DEFAULT_UNARMED_WEAPON_HASH(int ped) { return Function.Call<Hash>(0x08FF1099ED2E6E21, ped); }
		public static void _SET_AMMO_IN_TURRET(int vehicle, Hash turretHash, int ammo) { Function.Call(0xBDDA0C290C228159, vehicle, turretHash, ammo); }
		public static BOOL SET_CURRENT_PED_VEHICLE_WEAPON(int ped, Hash weaponHash) { return Function.Call<BOOL>(0x75C55983C2C39DAA, ped, weaponHash); }
		public static unsafe BOOL GET_CURRENT_PED_VEHICLE_WEAPON(int ped, Hash* weaponHash) { return Function.Call<BOOL>(0x1017582BCD3832DC, ped, weaponHash); }
		public static BOOL IS_PED_ARMED(int ped, int flags) { return Function.Call<BOOL>(0xCB690F680A3EA971, ped, flags); }
		public static Any _0xA2091482ED42EF85(Any p0, Any p1) { return Function.Call<Any>(0xA2091482ED42EF85, p0, p1); }
		public static BOOL _0x2387D6E9C6B478AA(int ped) { return Function.Call<BOOL>(0x2387D6E9C6B478AA, ped); }
		public static BOOL IS_WEAPON_VALID(Hash weaponHash) { return Function.Call<BOOL>(0x937C71165CF334B3, weaponHash); }
		public static BOOL _IS_AMMO_VALID(Hash ammoHash) { return Function.Call<BOOL>(0x1F7977C9101F807F, ammoHash); }
		public static Any _0x23BF601A42F329A0(Any p0) { return Function.Call<Any>(0x23BF601A42F329A0, p0); }
		public static BOOL IS_PED_CARRYING_WEAPON(int ped, Hash weaponHash) { return Function.Call<BOOL>(0xF29A186ED428B552, ped, weaponHash); }
		public static BOOL HAS_PED_GOT_WEAPON(int ped, Hash weaponHash, int p2, BOOL p3) { return Function.Call<BOOL>(0x8DECB02F88F428BC, ped, weaponHash, p2, p3); }
		public static Any _0x07E1C35F0078C3F9(Any p0, Any p1) { return Function.Call<Any>(0x07E1C35F0078C3F9, p0, p1); }
		public static BOOL IS_PED_WEAPON_READY_TO_SHOOT(int ped) { return Function.Call<BOOL>(0xB80CA294F2F26749, ped); }
		public static Hash _GET_PED_WEAPON_IN_SLOT(int ped, Hash slotHash) { return Function.Call<Hash>(0xDBC4B552B2AE9A83, ped, slotHash); }
		public static void GIVE_DELAYED_WEAPON_TO_PED(int ped, Hash weaponHash, int ammoCount, BOOL p3, Hash addReason) { Function.Call(0xB282DC6EBD803C75, ped, weaponHash, ammoCount, p3, addReason); }
		public static void REMOVE_ALL_PED_WEAPONS(int ped, BOOL p1, BOOL p2) { Function.Call(0xF25DF915FA38C5F3, ped, p1, p2); }
		public static void REMOVE_WEAPON_FROM_PED(int ped, Hash weaponHash, BOOL p2, Hash removeReason) { Function.Call(0x4899CB088EDF59B8, ped, weaponHash, p2, removeReason); }
		public static unsafe void _REMOVE_WEAPON_FROM_PED_BY_GUID(int ped, Any* weaponGuid, Hash removeReason) { Function.Call(0x51C3B71591811485, ped, weaponGuid, removeReason); }
		public static void HIDE_PED_WEAPON_FOR_SCRIPTED_CUTSCENE(int ped, BOOL toggle) { Function.Call(0x6F6981D2253C208F, ped, toggle); }
		public static void SET_PED_CURRENT_WEAPON_VISIBLE(int ped, BOOL visible, BOOL deselectWeapon, BOOL p3, BOOL p4) { Function.Call(0x0725A4CCFDED9A70, ped, visible, deselectWeapon, p3, p4); }
		public static void _SET_PED_WEAPON_ATTACH_POINT_VISIBILITY(int ped, int attachPoint, BOOL visible) { Function.Call(0x67E21ACC5C0C970C, ped, attachPoint, visible); }
		public static void _SET_PED_ALL_WEAPONS_VISIBILITY(int ped, BOOL visible) { Function.Call(0x4F806A6CFED89468, ped, visible); }
		public static void SET_PED_DROPS_WEAPONS_WHEN_DEAD(int ped, BOOL toggle) { Function.Call(0x476AE72C1D19D1A8, ped, toggle); }
		public static void _0x431240A58484D5D0(int ped, BOOL toggle) { Function.Call(0x431240A58484D5D0, ped, toggle); }
		public static void _0x45E57FDD531C9477(int ped, BOOL toggle) { Function.Call(0x45E57FDD531C9477, ped, toggle); }
		public static void _0xF08D8FEB455F2C8C(int ped, BOOL toggle) { Function.Call(0xF08D8FEB455F2C8C, ped, toggle); }
		public static void _0x16D9841A85FA627E(int ped, BOOL toggle) { Function.Call(0x16D9841A85FA627E, ped, toggle); }
		public static unsafe BOOL GET_PED_LAST_WEAPON_IMPACT_COORD(int ped, Vector3* coords) { return Function.Call<BOOL>(0x6C4D0409BA1A2BC2, ped, coords); }
		public static void _CLEAR_PED_LAST_WEAPON_DAMAGE(int ped) { Function.Call(0x087D8F4BC65F68E4, ped); }
		public static BOOL _HAS_ENTITY_BEEN_DAMAGED_BY_WEAPON(int entity, Hash weaponName, int weaponType) { return Function.Call<BOOL>(0xDCF06D0CDFF68424, entity, weaponName, weaponType); }
		public static void SET_PED_DROPS_INVENTORY_WEAPON(int ped, Hash weaponHash, float xOffset, float yOffset, float zOffset, int ammoCount) { Function.Call(0x208A1888007FC0E6, ped, weaponHash, xOffset, yOffset, zOffset, ammoCount); }
		public static void _0xB0FB9B196A3D13F0(Any p0, Any p1, Any p2) { Function.Call(0xB0FB9B196A3D13F0, p0, p1, p2); }
		public static void _0x2EBF70E1D8C06683(Any p0, Any p1) { Function.Call(0x2EBF70E1D8C06683, p0, p1); }
		public static void _0x63B83A526329AFBC(Any p0) { Function.Call(0x63B83A526329AFBC, p0); }
		public static Any _MAKE_PED_RELOAD(int ped) { return Function.Call<Any>(0x79E1E511FF7EFB13, ped); }
		public static Any _REFILL_AMMO_IN_CURRENT_PED_WEAPON(int ped) { return Function.Call<Any>(0x0A2AB7B7ABC055F4, ped); }
		public static int MAKE_PED_DROP_WEAPON(int ped, BOOL p1, int attachPoint, BOOL p3, BOOL p4) { return Function.Call<int>(0xCEF4C65DE502D367, ped, p1, attachPoint, p3, p4); }
		public static Hash _GET_PED_CURRENT_HELD_WEAPON(int ped) { return Function.Call<Hash>(0x8425C5F057012DAB, ped); }
		public static void SET_ALLOW_ANY_WEAPON_DROP(int ped, BOOL toggle) { Function.Call(0x78030C7867D8B9B6, ped, toggle); }
		public static void _0xA3716A77DCF17424(Any p0, Any p1, Any p2) { Function.Call(0xA3716A77DCF17424, p0, p1, p2); }
		public static void _0x457B16951AD77C1B(Any p0) { Function.Call(0x457B16951AD77C1B, p0); }
		public static Any _0x3799EFCC3C8CD5E1(Any p0) { return Function.Call<Any>(0x3799EFCC3C8CD5E1, p0); }
		public static float _GET_MAX_LOCKON_DISTANCE_OF_CURRENT_PED_WEAPON(int ped) { return Function.Call<float>(0x79B1A6E780266DB0, ped); }
		public static void _REMOVE_WEAPON_COMPONENT_FROM_PED(int ped, Hash componentHash, Hash weaponHash) { Function.Call(0x19F70C4D80494FF8, ped, componentHash, weaponHash); }
		public static BOOL _HAS_PED_GOT_WEAPON_COMPONENT(int ped, Hash componentHash, Hash weaponHash) { return Function.Call<BOOL>(0xBBC67A6F965C688A, ped, componentHash, weaponHash); }
		public static BOOL _IS_PED_CURRENT_WEAPON_HOLSTERED(int ped) { return Function.Call<BOOL>(0xBDD9C235D8D1052E, ped); }
		public static Any _0xD2209866B0CB72EA(Any p0, Any p1) { return Function.Call<Any>(0xD2209866B0CB72EA, p0, p1); }
		public static void _REQUEST_WEAPON_ASSET(Hash weaponHash, int p1, BOOL p2) { Function.Call(0x72D4CB5DB927009C, weaponHash, p1, p2); }
		public static BOOL _HAS_WEAPON_ASSET_LOADED(Hash weaponHash) { return Function.Call<BOOL>(0xFF07CF465F48B830, weaponHash); }
		public static void _REMOVE_WEAPON_ASSET(Hash weaponHash) { Function.Call(0xC3896D03E2852236, weaponHash); }
		public static void _0xE9B3FEC825668291(Any p0, Any p1, Any p2) { Function.Call(0xE9B3FEC825668291, p0, p1, p2); }
		public static Any _0x9CCA3131E6B53C68(Any p0, Any p1, Any p2) { return Function.Call<Any>(0x9CCA3131E6B53C68, p0, p1, p2); }
		public static string _GET_WEAPON_NAME_2(Hash weaponHash) { return Function.Call<string>(0x6D3AC61694A791C5, weaponHash); }
		public static string _GET_WEAPON_NAME(Hash weaponHash) { return Function.Call<string>(0x89CF5FF3D363311E, weaponHash); }
		public static string _GET_WEAPON_NAME_WITH_PERMANENT_DEGRADATION(Hash weaponHash, float permanentDegradationLevel) { return Function.Call<string>(0x7A56D66C78D8EF8E, weaponHash, permanentDegradationLevel); }
		public static void _0xB832F1A686B9B810(Any p0, Any p1, Any p2) { Function.Call(0xB832F1A686B9B810, p0, p1, p2); }
		public static Any _0x5A695BD328586B44(Any p0, Any p1) { return Function.Call<Any>(0x5A695BD328586B44, p0, p1); }
		public static void _0x641351E9AD103890(Any p0, Any p1) { Function.Call(0x641351E9AD103890, p0, p1); }
		public static void SET_INSTANTLY_EQUIP_WEAPON_PICKUPS(int ped, BOOL toggle) { Function.Call(0x739B9C6D0E7F7F93, ped, toggle); }
		public static void _SET_FORCE_AUTO_EQUIP(int ped, BOOL toggle) { Function.Call(0xBE711B14A159E84F, ped, toggle); }
		public static void _SEND_WEAPON_TO_INVENTORY(int ped, Hash weaponHash) { Function.Call(0xE9BD19F8121ADE3E, ped, weaponHash); }
		public static void _0x14FF0C2545527F9B(int horse, Hash weaponHash, int ped) { Function.Call(0x14FF0C2545527F9B, horse, weaponHash, ped); }
		public static void _0xD4C6E24D955FF061(Any p0) { Function.Call(0xD4C6E24D955FF061, p0); }
		public static Any _0xAFFD0CCF31F469B8(Any p0) { return Function.Call<Any>(0xAFFD0CCF31F469B8, p0); }
		public static Hash _GET_WEAPON_STAT_ID(Hash weaponHash) { return Function.Call<Hash>(0x8EC44AE8DECFF841, weaponHash); }
		public static BOOL _HAS_ENTITY_BEEN_DAMAGED_BY_WEAPON_RECENTLY(int entity, Hash weaponHash, int ms) { return Function.Call<BOOL>(0x9E2D5D6BC97A5F1E, entity, weaponHash, ms); }
		public static Hash _GET_PED_HOGTIE_WEAPON(int ped) { return Function.Call<Hash>(0x90EB1CB189923587, ped); }
		public static Object _CREATE_WEAPON_OBJECT(Hash weaponHash, int ammoCount, float x, float y, float z, BOOL showWorldModel, float scale) { return Function.Call<Object>(0x9888652B8BA77F73, weaponHash, ammoCount, x, y, z, showWorldModel, scale); }
		public static void REMOVE_WEAPON_COMPONENT_FROM_WEAPON_OBJECT(Object weaponObject, Hash component) { Function.Call(0xF7D82B0D66777611, weaponObject, component); }
		public static BOOL HAS_WEAPON_GOT_WEAPON_COMPONENT(Object weapon, Hash addonHash) { return Function.Call<BOOL>(0x76A18844E743BF91, weapon, addonHash); }
		public static unsafe void _GIVE_WEAPON_COMPONENT_TO_WEAPON_OBJECT(Object* weaponObject, int ped, Hash componentHash, BOOL p3) { Function.Call(0x1A47699E8D533E8F, weaponObject, ped, componentHash, p3); }
		public static Object _GET_WEAPON_OBJECT_FROM_PED(int ped, BOOL p1) { return Function.Call<Object>(0xC6A6789BB405D11C, ped, p1); }
		public static Object _GET_PED_WEAPON_OBJECT(int ped, BOOL p1) { return Function.Call<Object>(0x6CA484C9A7377E4F, ped, p1); }
		public static void _GIVE_WEAPON_COMPONENT_TO_ENTITY(int entity, Hash componentHash, Hash weaponHash, BOOL p3) { Function.Call(0x74C9090FDD1BB48E, entity, componentHash, weaponHash, p3); }
		public static void _0x74C9080FDD1BB48E(Any p0, Any p1) { Function.Call(0x74C9080FDD1BB48E, p0, p1); }
		public static void _0x74C9080FDD1BB48F(Any p0, Any p1) { Function.Call(0x74C9080FDD1BB48F, p0, p1); }
		public static void _0x74C2365FDD1BB48F(Any p0, Any p1) { Function.Call(0x74C2365FDD1BB48F, p0, p1); }
		public static void _0x74C90AAACC1DD48F(Any p0) { Function.Call(0x74C90AAACC1DD48F, p0); }
		public static Any _0x74C8000FDD1BB111(Any p0, Any p1) { return Function.Call<Any>(0x74C8000FDD1BB111, p0, p1); }
		public static Any _0x74C8000FDD1BB222(Any p0, Any p1) { return Function.Call<Any>(0x74C8000FDD1BB222, p0, p1); }
		public static Hash _GET_WEAPON_GUN_SPINNING_WEAPON_EMOTE_TRICK_TYPE_HASH(Hash emote, int weaponEmoteTrickType) { return Function.Call<Hash>(0xF4601C1203B1A78D, emote, weaponEmoteTrickType); }
		public static void _SET_ACTIVE_GUN_SPINNING_EQUIP_KIT_EMOTE_TWIRL(int ped, Hash emote) { Function.Call(0xCBCFFF805F1B4596, ped, emote); }
		public static Hash _GET_PED_GUN_SPINNING_EQUIPPED_KIT_EMOTE_TWIRL(int ped) { return Function.Call<Hash>(0x2C4FEC3D0EFA9FC0, ped); }
		public static void _SET_ACTIVE_GUN_SPINNING_KIT_EMOTE_TWIRL(int ped, int weaponEmoteTrickType, Hash spin) { Function.Call(0x01F661BB9C71B465, ped, weaponEmoteTrickType, spin); }
		public static Hash _GET_PED_GUN_SPINNING_HASH_FROM_WEAPON_EMOTE_VARIATION(int ped, int weaponEmoteVariation) { return Function.Call<Hash>(0xF3B1620B920D1708, ped, weaponEmoteVariation); }
		public static int _GET_WEAPON_EMOTE_VARIATION(int ped, int variation) { return Function.Call<int>(0x86147D05FA831D3A, ped, variation); }
		public static void _SET_GUN_SPINNING_INVENTORY_SLOT_ID_ACTIVATE(int ped, int emoteType) { Function.Call(0x408CF580C5E96D49, ped, emoteType); }
		public static BOOL _GET_CAN_TWIRL_WEAPON(Hash weaponHash) { return Function.Call<BOOL>(0x6554ECCE226F2A2A, weaponHash); }
		public static unsafe BOOL _0xCD356B42C57BFE01(int ped, Any* p1) { return Function.Call<BOOL>(0xCD356B42C57BFE01, ped, p1); }
		public static Any _0xBC9444F2FF94A9C0(Any p0) { return Function.Call<Any>(0xBC9444F2FF94A9C0, p0); }
		public static Hash _GET_DEFAULT_PED_WEAPON_COLLECTION(Hash pedModel) { return Function.Call<Hash>(0xD42514C182121C23, pedModel); }
		public static void _GIVE_WEAPON_COLLECTION_TO_PED(int ped, Hash weaponCollection) { Function.Call(0x899A04AFCC725D04, ped, weaponCollection); }
		public static BOOL _0xF252A85B8F3F8C58(Hash weaponCollection, Hash dualwieldVariant) { return Function.Call<BOOL>(0xF252A85B8F3F8C58, weaponCollection, dualwieldVariant); }
		public static Hash _0x9EEFD670F10656D7(Hash weaponCollection, Hash weaponGroup) { return Function.Call<Hash>(0x9EEFD670F10656D7, weaponCollection, weaponGroup); }
		public static Any _0xF2F585411E748B9C(Any p0, Any p1) { return Function.Call<Any>(0xF2F585411E748B9C, p0, p1); }
		public static int GET_WEAPON_CLIP_SIZE(Hash weaponHash) { return Function.Call<int>(0xD3750CCC00635FC2, weaponHash); }
		public static void _0xA769D753922B031B(Any p0, Any p1, Any p2) { Function.Call(0xA769D753922B031B, p0, p1, p2); }
		public static void _0xC5899C4CD2E2495D(Any p0) { Function.Call(0xC5899C4CD2E2495D, p0); }
		public static BOOL GET_ALLOW_DUAL_WIELD(int ped) { return Function.Call<BOOL>(0x918990BD9CE08582, ped); }
		public static void _SET_ALLOW_DUAL_WIELD(int ped, BOOL allow) { Function.Call(0x83B8D50EB9446BBA, ped, allow); }
		public static BOOL _0x44C8F4908F1B2622(int ped, Hash ammoHash) { return Function.Call<BOOL>(0x44C8F4908F1B2622, ped, ammoHash); }
		public static BOOL _IS_WEAPON_KNIFE(Hash weaponHash) { return Function.Call<BOOL>(0x792E3EF76C911959, weaponHash); }
		public static BOOL IS_WEAPON_REVOLVER(Hash weaponHash) { return Function.Call<BOOL>(0xC212F1D05A8232BB, weaponHash); }
		public static BOOL IS_WEAPON_PISTOL(Hash weaponHash) { return Function.Call<BOOL>(0xDDC64F5E31EEDAB6, weaponHash); }
		public static BOOL IS_WEAPON_REPEATER(Hash weaponHash) { return Function.Call<BOOL>(0xDDB2578E95EF7138, weaponHash); }
		public static BOOL IS_WEAPON_RIFLE(Hash weaponHash) { return Function.Call<BOOL>(0x0A82317B7EBFC420, weaponHash); }
		public static BOOL IS_WEAPON_SHOTGUN(Hash weaponHash) { return Function.Call<BOOL>(0xC75386174ECE95D5, weaponHash); }
		public static BOOL _IS_WEAPON_SNIPER(Hash weaponHash) { return Function.Call<BOOL>(0x6AD66548840472E5, weaponHash); }
		public static BOOL IS_WEAPON_MELEE_WEAPON(Hash weaponHash) { return Function.Call<BOOL>(0x959383DCD42040DA, weaponHash); }
		public static BOOL _IS_WEAPON_THROWABLE(Hash weaponHash) { return Function.Call<BOOL>(0x30E7C16B12DA8211, weaponHash); }
		public static BOOL _IS_WEAPON_LASSO(Hash weaponHash) { return Function.Call<BOOL>(0x6E4E1A82081EABED, weaponHash); }
		public static BOOL _IS_WEAPON_BINOCULARS(Hash weaponHash) { return Function.Call<BOOL>(0xC853230E76A152DF, weaponHash); }
		public static BOOL IS_WEAPON_A_GUN(Hash weaponHash) { return Function.Call<BOOL>(0x705BE297EEBDB95D, weaponHash); }
		public static BOOL _IS_WEAPON_TWO_HANDED(Hash weaponHash) { return Function.Call<BOOL>(0x0556E9D2ECF39D01, weaponHash); }
		public static BOOL _IS_WEAPON_ONE_HANDED(Hash weaponHash) { return Function.Call<BOOL>(0xD955FEE4B87AFA07, weaponHash); }
		public static BOOL _IS_WEAPON_SILENT(Hash weaponHash) { return Function.Call<BOOL>(0x5809DBCA0A37C82B, weaponHash); }
		public static Any _0xEA522F991E120D45(Any p0) { return Function.Call<Any>(0xEA522F991E120D45, p0); }
		public static BOOL _IS_AMMO_SILENT(Hash ammoHash) { return Function.Call<BOOL>(0xD2866CBA797E872E, ammoHash); }
		public static BOOL _IS_AMMO_SILENT_2(Hash ammoHash) { return Function.Call<BOOL>(0x7EFACC589B98C488, ammoHash); }
		public static BOOL SHOULD_WEAPON_BE_DISCARDED_WHEN_SWAPPED(Hash weaponHash) { return Function.Call<BOOL>(0x2C83212A7AA51D3D, weaponHash); }
		public static Any _0x5B235F24472F2C3B(Any p0, Any p1) { return Function.Call<Any>(0x5B235F24472F2C3B, p0, p1); }
		public static Any _0xBFCA7AFABF9D7967(Any p0, Any p1) { return Function.Call<Any>(0xBFCA7AFABF9D7967, p0, p1); }
		public static Any _0x495A04CAEC263AF8(Any p0, Any p1) { return Function.Call<Any>(0x495A04CAEC263AF8, p0, p1); }
		public static Any _0x95CA12E2C68043E5(Any p0, Any p1) { return Function.Call<Any>(0x95CA12E2C68043E5, p0, p1); }
		public static Any _0xABC18A28BAD4B46F(Any p0, Any p1) { return Function.Call<Any>(0xABC18A28BAD4B46F, p0, p1); }
		public static Any _0x80BB243789008A82(Any p0, Any p1) { return Function.Call<Any>(0x80BB243789008A82, p0, p1); }
		public static float _GET_WEAPON_DAMAGE(Object weaponObject) { return Function.Call<float>(0x904103D5D2333977, weaponObject); }
		public static void _SET_WEAPON_DAMAGE(Object weaponObject, float level, BOOL p2) { Function.Call(0xE22060121602493B, weaponObject, level, p2); }
		public static float _GET_WEAPON_DIRT(Object weaponObject) { return Function.Call<float>(0x810E8AE9AFEA7E54, weaponObject); }
		public static void _SET_WEAPON_DIRT(Object weaponObject, float level, BOOL p2) { Function.Call(0x812CE61DEBCAB948, weaponObject, level, p2); }
		public static float _GET_WEAPON_SOOT(Object weaponObject) { return Function.Call<float>(0x4BF66F8878F67663, weaponObject); }
		public static void _SET_WEAPON_SOOT(Object weaponObject, float level, BOOL p2) { Function.Call(0xA9EF4AD10BDDDB57, weaponObject, level, p2); }
		public static void _SET_WEAPON_LEVEL_THRESHOLD(Object weaponObject, float threshold) { Function.Call(0xD4071EFC83794B2F, weaponObject, threshold); }
		public static float GET_WEAPON_DEGRADATION(Object weaponObject) { return Function.Call<float>(0x0D78E1097F89E637, weaponObject); }
		public static float GET_WEAPON_PERMANENT_DEGRADATION(Object weaponObject) { return Function.Call<float>(0xD56E5F336C675EFA, weaponObject); }
		public static void _SET_WEAPON_DEGRADATION(Object weaponObject, float level) { Function.Call(0xA7A57E89E965D839, weaponObject, level); }
		public static void _LISTEN_PROJECTILE_HIT_EVENTS(BOOL listen) { Function.Call(0xDA5D3F2C6DD5B5D4, listen); }
		public static float _GET_WEAPON_SCALE(Object weaponObject) { return Function.Call<float>(0x22084CA699219624, weaponObject); }
		public static void _SET_WEAPON_SCALE(Object weaponObject, float scale) { Function.Call(0xC3544AD0522E69B4, weaponObject, scale); }
		public static Any _0x58425FCA3D3A2D15(Any p0) { return Function.Call<Any>(0x58425FCA3D3A2D15, p0); }
		public static Any _0xEC97101A8F311282(Any p0) { return Function.Call<Any>(0xEC97101A8F311282, p0); }
		public static Hash _GET_CURRENT_PED_WEAPON_AMMO_TYPE(int ped, Object weaponObject) { return Function.Call<Hash>(0x7E7B19A4355FEE13, ped, weaponObject); }
		public static unsafe Hash _GET_CURRENT_AMMO_TYPE_FROM_GUID(int ped, Any* weaponGuid) { return Function.Call<Hash>(0xAF9D167A5656D6A6, ped, weaponGuid); }
		public static BOOL _IS_AMMO_TYPE_VALID_FOR_WEAPON(Hash weaponHash, Hash ammoHash) { return Function.Call<BOOL>(0xC570B881754DF609, weaponHash, ammoHash); }
		public static void _SET_AMMO_TYPE_FOR_PED_WEAPON(int ped, Hash weaponHash, Hash ammoHash) { Function.Call(0xCC9C4393523833E2, ped, weaponHash, ammoHash); }
		public static void _0x183CE355115B6E75(Any p0, Any p1) { Function.Call(0x183CE355115B6E75, p0, p1); }
		public static unsafe void _SET_AMMO_TYPE_FOR_PED_WEAPON_INVENTORY(int ped, Any* weaponInventoryUid, Hash ammoHash) { Function.Call(0xEBE46B501BC3FBCF, ped, weaponInventoryUid, ammoHash); }
		public static void _DISABLE_AMMO_TYPE_FOR_PED_WEAPON(int ped, Hash weaponHash, Hash ammoHash) { Function.Call(0xF0D728EEA3C99775, ped, weaponHash, ammoHash); }
		public static void _DISABLE_AMMO_TYPE_FOR_PED(int ped, Hash ammoHash) { Function.Call(0xAA5A52204E077883, ped, ammoHash); }
		public static void _0xD63B4BA3A02A99E0(Any p0, Any p1) { Function.Call(0xD63B4BA3A02A99E0, p0, p1); }
		public static void _ENABLE_AMMO_TYPE_FOR_PED_WEAPON(int ped, Hash weaponHash, Hash ammoHash) { Function.Call(0x23FB9FACA28779C1, ped, weaponHash, ammoHash); }
		public static void _ENABLE_AMMO_TYPE_FOR_PED(int ped, Hash weaponHash) { Function.Call(0x3B7B7908B7ADFB4B, ped, weaponHash); }
		public static void _0x404514D231DB27A0(Any p0, Any p1) { Function.Call(0x404514D231DB27A0, p0, p1); }
		public static void _0xD53846B9C931C181(Any p0, Any p1, Any p2) { Function.Call(0xD53846B9C931C181, p0, p1, p2); }
		public static void _0x000FA7A4A8443AF7(Any p0) { Function.Call(0x000FA7A4A8443AF7, p0); }
		public static void _0xECBB26529A737EF6(Any p0) { Function.Call(0xECBB26529A737EF6, p0); }
		public static int _GET_WEAPON_ATTACH_POINT(int ped, int attachPoint) { return Function.Call<int>(0xCAD4FE9398820D24, ped, attachPoint); }
		public static Any _0x4823F13A21F51964(Any p0, Any p1) { return Function.Call<Any>(0x4823F13A21F51964, p0, p1); }
		public static unsafe void SET_CURRENT_PED_WEAPON_BY_GUID(int ped, Any* weaponUid, BOOL p2, BOOL p3, BOOL p4, BOOL p5) { Function.Call(0x12FB95FE3D579238, ped, weaponUid, p2, p3, p4, p5); }
		public static unsafe void SET_PLAYER_PED_QUICK_SWAP_WEAPON_BY_GUID(int ped, Any* guidPrimary, Any* guidSecondary) { Function.Call(0xEC1F85DA51D3D6C4, ped, guidPrimary, guidSecondary); }
		public static unsafe void _GET_PLAYER_PED_QUICK_SWAP_WEAPON_BY_GUID(int ped, Any* guidPrimary, Any* guidSecondary) { Function.Call(0xB7E52A058B07C7E2, ped, guidPrimary, guidSecondary); }
		public static BOOL _0x0DE0944ECCB3DF5D(Any p0) { return Function.Call<BOOL>(0x0DE0944ECCB3DF5D, p0); }
		public static Any _0x46D42883E873C1D7(int ped) { return Function.Call<Any>(0x46D42883E873C1D7, ped); }
		public static BOOL _IS_TARGET_PED_CONSTRAINED_BY_PED_USING_BOLAS(int ped, int targetPed) { return Function.Call<BOOL>(0x8D50F43298AB9545, ped, targetPed); }
		public static int _0x65DC4AC5B96614CB(Hash weaponHash) { return Function.Call<int>(0x65DC4AC5B96614CB, weaponHash); }
	}

	public static class ZONE
	{
		public static Hash _GET_MAP_ZONE_AT_COORDS(float x, float y, float z, int type) { return Function.Call<Hash>(0x43AD8FC02B429D33, x, y, z, type); }
		public static Hash _GET_WATER_MAP_ZONE_AT_COORDS(float x, float y, float z) { return Function.Call<Hash>(0x5BA7A68A346A5A91, x, y, z); }
	}

	public static class COMPAPP
	{
		public static void _0xB6FD96420C0126A1(Hash p0, BOOL p1) { Function.Call(0xB6FD96420C0126A1, p0, p1); }
		public static void _0x74BCCEB233AD95B2(Hash p0, int p1) { Function.Call(0x74BCCEB233AD95B2, p0, p1); }
		public static void _0x29C733459A9011EB(Hash p0, string p1) { Function.Call(0x29C733459A9011EB, p0, p1); }
		public static BOOL _0x7AF1BB4504EA5ED9() { return Function.Call<BOOL>(0x7AF1BB4504EA5ED9); }
		public static void _0xCCB4635A071FB62D() { Function.Call(0xCCB4635A071FB62D); }
	}
}
