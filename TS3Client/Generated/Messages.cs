// TS3Client - A free TeamSpeak3 client implementation
// Copyright (C) 2017  TS3Client contributors
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the Open Software License v. 3.0
//
// You should have received a copy of the Open Software License along with this
// program. If not, see <https://opensource.org/licenses/OSL-3.0>.























namespace TS3Client.Messages
{
	using Commands;
	using Helper;
	using System;
	using System.Globalization;

	using UidT = System.String;
	using ClientDbIdT = System.UInt64;
	using ClientIdT = System.UInt16;
	using ChannelIdT = System.UInt64;
	using ServerGroupIdT = System.UInt64;
	using ChannelGroupIdT = System.UInt64;


	public sealed class ChannelChanged : INotification
	{
		public NotificationType NotifyType { get; } = NotificationType.ChannelChanged;
		

		public ChannelIdT ChannelId { get; set; }

		public void SetField(string name, ReadOnlySpan<char> value)
		{

			switch(name)
			{

			case "cid": ChannelId = ChannelIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			
			}

		}
	}

	public sealed class ChannelCreated : INotification
	{
		public NotificationType NotifyType { get; } = NotificationType.ChannelCreated;
		

		public ChannelIdT ChannelId { get; set; }
		public ClientIdT InvokerId { get; set; }
		public string InvokerName { get; set; }
		public UidT InvokerUid { get; set; }
		public int Order { get; set; }
		public string Name { get; set; }
		public string Topic { get; set; }
		public bool IsDefault { get; set; }
		public bool HasPassword { get; set; }
		public bool IsPermanent { get; set; }
		public bool IsSemiPermanent { get; set; }
		public Codec Codec { get; set; }
		public byte CodecQuality { get; set; }
		public int NeededTalkPower { get; set; }
		public int IconId { get; set; }
		public ushort MaxClients { get; set; }
		public ushort MaxFamilyClients { get; set; }
		public int CodecLatencyFactor { get; set; }
		public bool IsUnencrypted { get; set; }
		public TimeSpan DeleteDelay { get; set; }
		public bool IsMaxClientsUnlimited { get; set; }
		public bool IsMaxFamilyClientsUnlimited { get; set; }
		public bool InheritsMaxFamilyClients { get; set; }
		public string PhoneticName { get; set; }
		public ChannelIdT ChannelParentId { get; set; }

		public void SetField(string name, ReadOnlySpan<char> value)
		{

			switch(name)
			{

			case "cid": ChannelId = ChannelIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "invokerid": InvokerId = ClientIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "invokername": InvokerName = Ts3String.Unescape(value); break;
			case "invokeruid": InvokerUid = Ts3String.Unescape(value); break;
			case "channel_order": Order = int.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "channel_name": Name = Ts3String.Unescape(value); break;
			case "channel_topic": Topic = Ts3String.Unescape(value); break;
			case "channel_flag_default": IsDefault = value.Length > 0 && value[0] != '0'; break;
			case "channel_flag_password": HasPassword = value.Length > 0 && value[0] != '0'; break;
			case "channel_flag_permanent": IsPermanent = value.Length > 0 && value[0] != '0'; break;
			case "channel_flag_semi_permanent": IsSemiPermanent = value.Length > 0 && value[0] != '0'; break;
			case "channel_codec": Codec = (Codec)byte.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "channel_codec_quality": CodecQuality = byte.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "channel_needed_talk_power": NeededTalkPower = int.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "channel_icon_id": IconId = unchecked((int)long.Parse(value.NewString(), CultureInfo.InvariantCulture)); break;
			case "channel_maxclients": MaxClients = ushort.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "channel_maxfamilyclients": MaxFamilyClients = ushort.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "channel_codec_latency_factor": CodecLatencyFactor = int.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "channel_codec_is_unencrypted": IsUnencrypted = value.Length > 0 && value[0] != '0'; break;
			case "channel_delete_delay": DeleteDelay = TimeSpan.FromSeconds(double.Parse(value.NewString(), CultureInfo.InvariantCulture)); break;
			case "channel_flag_maxclients_unlimited": IsMaxClientsUnlimited = value.Length > 0 && value[0] != '0'; break;
			case "channel_flag_maxfamilyclients_unlimited": IsMaxFamilyClientsUnlimited = value.Length > 0 && value[0] != '0'; break;
			case "channel_flag_maxfamilyclients_inherited": InheritsMaxFamilyClients = value.Length > 0 && value[0] != '0'; break;
			case "channel_name_phonetic": PhoneticName = Ts3String.Unescape(value); break;
			case "cpid": ChannelParentId = ChannelIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			
			}

		}
	}

	public sealed class ChannelData : IResponse
	{
		
		public string ReturnCode { get; set; }

		public ChannelIdT Id { get; set; }
		public ChannelIdT ParentChannelId { get; set; }
		public TimeSpan DurationEmpty { get; set; }
		public int TotalFamilyClients { get; set; }
		public int TotalClients { get; set; }
		public int NeededSubscribePower { get; set; }
		public int Order { get; set; }
		public string Name { get; set; }
		public string Topic { get; set; }
		public bool IsDefault { get; set; }
		public bool HasPassword { get; set; }
		public bool IsPermanent { get; set; }
		public bool IsSemiPermanent { get; set; }
		public Codec Codec { get; set; }
		public byte CodecQuality { get; set; }
		public int NeededTalkPower { get; set; }
		public int IconId { get; set; }
		public ushort MaxClients { get; set; }
		public ushort MaxFamilyClients { get; set; }

		public void SetField(string name, ReadOnlySpan<char> value)
		{

			switch(name)
			{

			case "id": Id = ChannelIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "pid": ParentChannelId = ChannelIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "seconds_empty": DurationEmpty = TimeSpan.FromSeconds(double.Parse(value.NewString(), CultureInfo.InvariantCulture)); break;
			case "total_clients_family": TotalFamilyClients = int.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "total_clients": TotalClients = int.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "channel_needed_subscribe_power": NeededSubscribePower = int.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "channel_order": Order = int.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "channel_name": Name = Ts3String.Unescape(value); break;
			case "channel_topic": Topic = Ts3String.Unescape(value); break;
			case "channel_flag_default": IsDefault = value.Length > 0 && value[0] != '0'; break;
			case "channel_flag_password": HasPassword = value.Length > 0 && value[0] != '0'; break;
			case "channel_flag_permanent": IsPermanent = value.Length > 0 && value[0] != '0'; break;
			case "channel_flag_semi_permanent": IsSemiPermanent = value.Length > 0 && value[0] != '0'; break;
			case "channel_codec": Codec = (Codec)byte.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "channel_codec_quality": CodecQuality = byte.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "channel_needed_talk_power": NeededTalkPower = int.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "channel_icon_id": IconId = unchecked((int)long.Parse(value.NewString(), CultureInfo.InvariantCulture)); break;
			case "channel_maxclients": MaxClients = ushort.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "channel_maxfamilyclients": MaxFamilyClients = ushort.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "return_code": ReturnCode = Ts3String.Unescape(value); break;
			}

		}
	}

	public sealed class ChannelDeleted : INotification
	{
		public NotificationType NotifyType { get; } = NotificationType.ChannelDeleted;
		

		public ChannelIdT ChannelId { get; set; }
		public ClientIdT InvokerId { get; set; }
		public string InvokerName { get; set; }
		public UidT InvokerUid { get; set; }

		public void SetField(string name, ReadOnlySpan<char> value)
		{

			switch(name)
			{

			case "cid": ChannelId = ChannelIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "invokerid": InvokerId = ClientIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "invokername": InvokerName = Ts3String.Unescape(value); break;
			case "invokeruid": InvokerUid = Ts3String.Unescape(value); break;
			
			}

		}
	}

	public sealed class ChannelEdited : INotification
	{
		public NotificationType NotifyType { get; } = NotificationType.ChannelEdited;
		

		public ChannelIdT ChannelId { get; set; }
		public ClientIdT InvokerId { get; set; }
		public string InvokerName { get; set; }
		public UidT InvokerUid { get; set; }
		public int Order { get; set; }
		public string Name { get; set; }
		public string Topic { get; set; }
		public bool IsDefault { get; set; }
		public bool HasPassword { get; set; }
		public bool IsPermanent { get; set; }
		public bool IsSemiPermanent { get; set; }
		public Codec Codec { get; set; }
		public byte CodecQuality { get; set; }
		public int NeededTalkPower { get; set; }
		public int IconId { get; set; }
		public ushort MaxClients { get; set; }
		public ushort MaxFamilyClients { get; set; }
		public int CodecLatencyFactor { get; set; }
		public bool IsUnencrypted { get; set; }
		public TimeSpan DeleteDelay { get; set; }
		public bool IsMaxClientsUnlimited { get; set; }
		public bool IsMaxFamilyClientsUnlimited { get; set; }
		public bool InheritsMaxFamilyClients { get; set; }
		public string PhoneticName { get; set; }
		public Reason Reason { get; set; }

		public void SetField(string name, ReadOnlySpan<char> value)
		{

			switch(name)
			{

			case "cid": ChannelId = ChannelIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "invokerid": InvokerId = ClientIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "invokername": InvokerName = Ts3String.Unescape(value); break;
			case "invokeruid": InvokerUid = Ts3String.Unescape(value); break;
			case "channel_order": Order = int.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "channel_name": Name = Ts3String.Unescape(value); break;
			case "channel_topic": Topic = Ts3String.Unescape(value); break;
			case "channel_flag_default": IsDefault = value.Length > 0 && value[0] != '0'; break;
			case "channel_flag_password": HasPassword = value.Length > 0 && value[0] != '0'; break;
			case "channel_flag_permanent": IsPermanent = value.Length > 0 && value[0] != '0'; break;
			case "channel_flag_semi_permanent": IsSemiPermanent = value.Length > 0 && value[0] != '0'; break;
			case "channel_codec": Codec = (Codec)byte.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "channel_codec_quality": CodecQuality = byte.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "channel_needed_talk_power": NeededTalkPower = int.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "channel_icon_id": IconId = unchecked((int)long.Parse(value.NewString(), CultureInfo.InvariantCulture)); break;
			case "channel_maxclients": MaxClients = ushort.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "channel_maxfamilyclients": MaxFamilyClients = ushort.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "channel_codec_latency_factor": CodecLatencyFactor = int.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "channel_codec_is_unencrypted": IsUnencrypted = value.Length > 0 && value[0] != '0'; break;
			case "channel_delete_delay": DeleteDelay = TimeSpan.FromSeconds(double.Parse(value.NewString(), CultureInfo.InvariantCulture)); break;
			case "channel_flag_maxclients_unlimited": IsMaxClientsUnlimited = value.Length > 0 && value[0] != '0'; break;
			case "channel_flag_maxfamilyclients_unlimited": IsMaxFamilyClientsUnlimited = value.Length > 0 && value[0] != '0'; break;
			case "channel_flag_maxfamilyclients_inherited": InheritsMaxFamilyClients = value.Length > 0 && value[0] != '0'; break;
			case "channel_name_phonetic": PhoneticName = Ts3String.Unescape(value); break;
			case "reasonid": { if (!Enum.TryParse(value.NewString(), out Reason val)) throw new FormatException(); Reason = val; } break;
			
			}

		}
	}

	public sealed class ChannelGroupList : INotification
	{
		public NotificationType NotifyType { get; } = NotificationType.ChannelGroupList;
		

		public ChannelGroupIdT ChannelGroup { get; set; }
		public string Name { get; set; }
		public GroupType GroupType { get; set; }
		public int IconId { get; set; }
		public bool IsPermanent { get; set; }
		public int SortId { get; set; }
		public GroupNamingMode NamingMode { get; set; }
		public int NeededModifyPower { get; set; }
		public int NeededMemberAddPower { get; set; }
		public int NeededMemberRemovePower { get; set; }

		public void SetField(string name, ReadOnlySpan<char> value)
		{

			switch(name)
			{

			case "cgid": ChannelGroup = ChannelGroupIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "name": Name = Ts3String.Unescape(value); break;
			case "type": { if (!Enum.TryParse(value.NewString(), out GroupType val)) throw new FormatException(); GroupType = val; } break;
			case "iconid": IconId = unchecked((int)long.Parse(value.NewString(), CultureInfo.InvariantCulture)); break;
			case "savedb": IsPermanent = value.Length > 0 && value[0] != '0'; break;
			case "sortid": SortId = int.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "namemode": { if (!Enum.TryParse(value.NewString(), out GroupNamingMode val)) throw new FormatException(); NamingMode = val; } break;
			case "n_modifyp": NeededModifyPower = int.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "n_member_addp": NeededMemberAddPower = int.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "n_member_remove_p": NeededMemberRemovePower = int.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			
			}

		}
	}

	public sealed class ChannelList : INotification
	{
		public NotificationType NotifyType { get; } = NotificationType.ChannelList;
		

		public ChannelIdT ChannelId { get; set; }
		public ChannelIdT ChannelParentId { get; set; }
		public string Name { get; set; }
		public string Topic { get; set; }
		public Codec Codec { get; set; }
		public byte CodecQuality { get; set; }
		public ushort MaxClients { get; set; }
		public ushort MaxFamilyClients { get; set; }
		public int Order { get; set; }
		public bool IsPermanent { get; set; }
		public bool IsSemiPermanent { get; set; }
		public bool IsDefault { get; set; }
		public bool HasPassword { get; set; }
		public int CodecLatencyFactor { get; set; }
		public bool IsUnencrypted { get; set; }
		public TimeSpan DeleteDelay { get; set; }
		public bool IsMaxClientsUnlimited { get; set; }
		public bool IsMaxFamilyClientsUnlimited { get; set; }
		public bool InheritsMaxFamilyClients { get; set; }
		public int NeededTalkPower { get; set; }
		public bool ForcedSilence { get; set; }
		public string PhoneticName { get; set; }
		public int IconId { get; set; }
		public bool IsPrivate { get; set; }

		public void SetField(string name, ReadOnlySpan<char> value)
		{

			switch(name)
			{

			case "cid": ChannelId = ChannelIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "cpid": ChannelParentId = ChannelIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "channel_name": Name = Ts3String.Unescape(value); break;
			case "channel_topic": Topic = Ts3String.Unescape(value); break;
			case "channel_codec": Codec = (Codec)byte.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "channel_codec_quality": CodecQuality = byte.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "channel_maxclients": MaxClients = ushort.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "channel_maxfamilyclients": MaxFamilyClients = ushort.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "channel_order": Order = int.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "channel_flag_permanent": IsPermanent = value.Length > 0 && value[0] != '0'; break;
			case "channel_flag_semi_permanent": IsSemiPermanent = value.Length > 0 && value[0] != '0'; break;
			case "channel_flag_default": IsDefault = value.Length > 0 && value[0] != '0'; break;
			case "channel_flag_password": HasPassword = value.Length > 0 && value[0] != '0'; break;
			case "channel_codec_latency_factor": CodecLatencyFactor = int.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "channel_codec_is_unencrypted": IsUnencrypted = value.Length > 0 && value[0] != '0'; break;
			case "channel_delete_delay": DeleteDelay = TimeSpan.FromSeconds(double.Parse(value.NewString(), CultureInfo.InvariantCulture)); break;
			case "channel_flag_maxclients_unlimited": IsMaxClientsUnlimited = value.Length > 0 && value[0] != '0'; break;
			case "channel_flag_maxfamilyclients_unlimited": IsMaxFamilyClientsUnlimited = value.Length > 0 && value[0] != '0'; break;
			case "channel_flag_maxfamilyclients_inherited": InheritsMaxFamilyClients = value.Length > 0 && value[0] != '0'; break;
			case "channel_needed_talk_power": NeededTalkPower = int.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "channel_forced_silence": ForcedSilence = value.Length > 0 && value[0] != '0'; break;
			case "channel_name_phonetic": PhoneticName = Ts3String.Unescape(value); break;
			case "channel_icon_id": IconId = unchecked((int)long.Parse(value.NewString(), CultureInfo.InvariantCulture)); break;
			case "channel_flag_private": IsPrivate = value.Length > 0 && value[0] != '0'; break;
			
			}

		}
	}

	public sealed class ChannelListFinished : INotification
	{
		public NotificationType NotifyType { get; } = NotificationType.ChannelListFinished;
		


		public void SetField(string name, ReadOnlySpan<char> value)
		{

		}
	}

	public sealed class ChannelMoved : INotification
	{
		public NotificationType NotifyType { get; } = NotificationType.ChannelMoved;
		

		public int Order { get; set; }
		public ChannelIdT ChannelId { get; set; }
		public ClientIdT InvokerId { get; set; }
		public string InvokerName { get; set; }
		public UidT InvokerUid { get; set; }
		public Reason Reason { get; set; }
		public ChannelIdT ChannelParentId { get; set; }

		public void SetField(string name, ReadOnlySpan<char> value)
		{

			switch(name)
			{

			case "order": Order = int.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "cid": ChannelId = ChannelIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "invokerid": InvokerId = ClientIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "invokername": InvokerName = Ts3String.Unescape(value); break;
			case "invokeruid": InvokerUid = Ts3String.Unescape(value); break;
			case "reasonid": { if (!Enum.TryParse(value.NewString(), out Reason val)) throw new FormatException(); Reason = val; } break;
			case "cpid": ChannelParentId = ChannelIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			
			}

		}
	}

	public sealed class ChannelPasswordChanged : INotification
	{
		public NotificationType NotifyType { get; } = NotificationType.ChannelPasswordChanged;
		

		public ChannelIdT ChannelId { get; set; }

		public void SetField(string name, ReadOnlySpan<char> value)
		{

			switch(name)
			{

			case "cid": ChannelId = ChannelIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			
			}

		}
	}

	public sealed class ChannelSubscribed : INotification
	{
		public NotificationType NotifyType { get; } = NotificationType.ChannelSubscribed;
		

		public ChannelIdT ChannelId { get; set; }
		public TimeSpan EmptySince { get; set; }

		public void SetField(string name, ReadOnlySpan<char> value)
		{

			switch(name)
			{

			case "cid": ChannelId = ChannelIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "es": EmptySince = TimeSpan.FromSeconds(double.Parse(value.NewString(), CultureInfo.InvariantCulture)); break;
			
			}

		}
	}

	public sealed class ChannelUnsubscribed : INotification
	{
		public NotificationType NotifyType { get; } = NotificationType.ChannelUnsubscribed;
		

		public ChannelIdT ChannelId { get; set; }

		public void SetField(string name, ReadOnlySpan<char> value)
		{

			switch(name)
			{

			case "cid": ChannelId = ChannelIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			
			}

		}
	}

	public sealed class ClientChannelGroupChanged : INotification
	{
		public NotificationType NotifyType { get; } = NotificationType.ClientChannelGroupChanged;
		

		public ClientIdT InvokerId { get; set; }
		public string InvokerName { get; set; }
		public ChannelGroupIdT ChannelGroup { get; set; }
		public ChannelGroupIdT ChannelGroupIndex { get; set; }
		public ChannelIdT ChannelId { get; set; }
		public ClientIdT ClientId { get; set; }

		public void SetField(string name, ReadOnlySpan<char> value)
		{

			switch(name)
			{

			case "invokerid": InvokerId = ClientIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "invokername": InvokerName = Ts3String.Unescape(value); break;
			case "cgid": ChannelGroup = ChannelGroupIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "cgi": ChannelGroupIndex = ChannelGroupIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "cid": ChannelId = ChannelIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "clid": ClientId = ClientIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			
			}

		}
	}

	public sealed class ClientChatComposing : INotification
	{
		public NotificationType NotifyType { get; } = NotificationType.ClientChatComposing;
		

		public ClientIdT ClientId { get; set; }
		public UidT ClientUid { get; set; }

		public void SetField(string name, ReadOnlySpan<char> value)
		{

			switch(name)
			{

			case "clid": ClientId = ClientIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "cluid": ClientUid = Ts3String.Unescape(value); break;
			
			}

		}
	}

	public sealed class ClientData : IResponse
	{
		
		public string ReturnCode { get; set; }

		public ClientIdT ClientId { get; set; }
		public UidT Uid { get; set; }
		public ChannelIdT ChannelId { get; set; }
		public ClientDbIdT DatabaseId { get; set; }
		public string Name { get; set; }
		public ClientType ClientType { get; set; }

		public void SetField(string name, ReadOnlySpan<char> value)
		{

			switch(name)
			{

			case "clid": ClientId = ClientIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "client_unique_identifier": Uid = Ts3String.Unescape(value); break;
			case "cid": ChannelId = ChannelIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "client_database_id": DatabaseId = ClientDbIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "client_nickname": Name = Ts3String.Unescape(value); break;
			case "client_type": { if (!Enum.TryParse(value.NewString(), out ClientType val)) throw new FormatException(); ClientType = val; } break;
			case "return_code": ReturnCode = Ts3String.Unescape(value); break;
			}

		}
	}

	public sealed class ClientDbData : IResponse
	{
		
		public string ReturnCode { get; set; }

		public string LastIp { get; set; }
		public ClientIdT ClientId { get; set; }
		public UidT Uid { get; set; }
		public ChannelIdT ChannelId { get; set; }
		public ClientDbIdT DatabaseId { get; set; }
		public string Name { get; set; }
		public ClientType ClientType { get; set; }
		public string AvatarHash { get; set; }
		public string Description { get; set; }
		public int IconId { get; set; }
		public DateTime CreationDate { get; set; }
		public DateTime LastConnected { get; set; }
		public int TotalConnections { get; set; }
		public long MonthlyUploadQuota { get; set; }
		public long MonthlyDownloadQuota { get; set; }
		public long TotalUploadQuota { get; set; }
		public long TotalDownloadQuota { get; set; }
		public string Base64HashClientUid { get; set; }

		public void SetField(string name, ReadOnlySpan<char> value)
		{

			switch(name)
			{

			case "client_lastip": LastIp = Ts3String.Unescape(value); break;
			case "clid": ClientId = ClientIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "client_unique_identifier": Uid = Ts3String.Unescape(value); break;
			case "cid": ChannelId = ChannelIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "client_database_id": DatabaseId = ClientDbIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "client_nickname": Name = Ts3String.Unescape(value); break;
			case "client_type": { if (!Enum.TryParse(value.NewString(), out ClientType val)) throw new FormatException(); ClientType = val; } break;
			case "client_flag_avatar": AvatarHash = Ts3String.Unescape(value); break;
			case "client_description": Description = Ts3String.Unescape(value); break;
			case "client_icon_id": IconId = unchecked((int)long.Parse(value.NewString(), CultureInfo.InvariantCulture)); break;
			case "client_created": CreationDate = Util.UnixTimeStart.AddSeconds(double.Parse(value.NewString(), CultureInfo.InvariantCulture)); break;
			case "client_lastconnected": LastConnected = Util.UnixTimeStart.AddSeconds(double.Parse(value.NewString(), CultureInfo.InvariantCulture)); break;
			case "client_totalconnections": TotalConnections = int.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "client_month_bytes_uploaded": MonthlyUploadQuota = long.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "client_month_bytes_downloaded": MonthlyDownloadQuota = long.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "client_total_bytes_uploaded": TotalUploadQuota = long.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "client_total_bytes_downloaded": TotalDownloadQuota = long.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "client_base64HashClientUID": Base64HashClientUid = Ts3String.Unescape(value); break;
			case "return_code": ReturnCode = Ts3String.Unescape(value); break;
			}

		}
	}

	public sealed class ClientEnterView : INotification
	{
		public NotificationType NotifyType { get; } = NotificationType.ClientEnterView;
		

		public Reason Reason { get; set; }
		public ChannelIdT TargetChannelId { get; set; }
		public ClientIdT InvokerId { get; set; }
		public string InvokerName { get; set; }
		public UidT InvokerUid { get; set; }
		public ClientIdT ClientId { get; set; }
		public ClientDbIdT DatabaseId { get; set; }
		public string Name { get; set; }
		public ClientType ClientType { get; set; }
		public ChannelIdT SourceChannelId { get; set; }
		public UidT Uid { get; set; }
		public string AvatarHash { get; set; }
		public string Description { get; set; }
		public int IconId { get; set; }
		public bool InputMuted { get; set; }
		public bool OutputMuted { get; set; }
		public bool OutputOnlyMuted { get; set; }
		public bool InputHardwareEnabled { get; set; }
		public bool OutputHardwareEnabled { get; set; }
		public string Metadata { get; set; }
		public bool IsRecording { get; set; }
		public ChannelGroupIdT ChannelGroup { get; set; }
		public ChannelIdT InheritedChannelGroupFromChannel { get; set; }
		public ServerGroupIdT[] ServerGroups { get; set; }
		public bool IsAway { get; set; }
		public string AwayMessage { get; set; }
		public int TalkPower { get; set; }
		public DateTime TalkPowerRequestTime { get; set; }
		public string TalkPowerRequestMessage { get; set; }
		public bool TalkPowerGranted { get; set; }
		public bool IsPrioritySpeaker { get; set; }
		public uint UnreadMessages { get; set; }
		public string PhoneticName { get; set; }
		public int NeededServerqueryViewPower { get; set; }
		public bool IsChannelCommander { get; set; }
		public string CountryCode { get; set; }
		public string Badges { get; set; }

		public void SetField(string name, ReadOnlySpan<char> value)
		{

			switch(name)
			{

			case "reasonid": { if (!Enum.TryParse(value.NewString(), out Reason val)) throw new FormatException(); Reason = val; } break;
			case "ctid": TargetChannelId = ChannelIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "invokerid": InvokerId = ClientIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "invokername": InvokerName = Ts3String.Unescape(value); break;
			case "invokeruid": InvokerUid = Ts3String.Unescape(value); break;
			case "clid": ClientId = ClientIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "client_database_id": DatabaseId = ClientDbIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "client_nickname": Name = Ts3String.Unescape(value); break;
			case "client_type": { if (!Enum.TryParse(value.NewString(), out ClientType val)) throw new FormatException(); ClientType = val; } break;
			case "cfid": SourceChannelId = ChannelIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "client_unique_identifier": Uid = Ts3String.Unescape(value); break;
			case "client_flag_avatar": AvatarHash = Ts3String.Unescape(value); break;
			case "client_description": Description = Ts3String.Unescape(value); break;
			case "client_icon_id": IconId = unchecked((int)long.Parse(value.NewString(), CultureInfo.InvariantCulture)); break;
			case "client_input_muted": InputMuted = value.Length > 0 && value[0] != '0'; break;
			case "client_output_muted": OutputMuted = value.Length > 0 && value[0] != '0'; break;
			case "client_outputonly_muted": OutputOnlyMuted = value.Length > 0 && value[0] != '0'; break;
			case "client_input_hardware": InputHardwareEnabled = value.Length > 0 && value[0] != '0'; break;
			case "client_output_hardware": OutputHardwareEnabled = value.Length > 0 && value[0] != '0'; break;
			case "client_meta_data": Metadata = Ts3String.Unescape(value); break;
			case "client_is_recording": IsRecording = value.Length > 0 && value[0] != '0'; break;
			case "client_channel_group_id": ChannelGroup = ChannelGroupIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "client_channel_group_inherited_channel_id": InheritedChannelGroupFromChannel = ChannelIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "client_servergroups": { if(value.Length == 0) ServerGroups = Array.Empty<ServerGroupIdT>(); else { var ss = new SpanSplitter(); ss.First(value, ','); int cnt = 0; for (int i = 0; i < value.Length; i++) if (value[i] == ',') cnt++; ServerGroups = new ServerGroupIdT[cnt + 1]; for(int i = 0; i < cnt + 1; i++) { ServerGroups[i] = ServerGroupIdT.Parse(ss.Trim(value).NewString(), CultureInfo.InvariantCulture); if (i < cnt) value = ss.Next(value); } } } break;
			case "client_away": IsAway = value.Length > 0 && value[0] != '0'; break;
			case "client_away_message": AwayMessage = Ts3String.Unescape(value); break;
			case "client_talk_power": TalkPower = int.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "client_talk_request": TalkPowerRequestTime = Util.UnixTimeStart.AddSeconds(double.Parse(value.NewString(), CultureInfo.InvariantCulture)); break;
			case "client_talk_request_msg": TalkPowerRequestMessage = Ts3String.Unescape(value); break;
			case "client_is_talker": TalkPowerGranted = value.Length > 0 && value[0] != '0'; break;
			case "client_is_priority_speaker": IsPrioritySpeaker = value.Length > 0 && value[0] != '0'; break;
			case "client_unread_messages": UnreadMessages = uint.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "client_nickname_phonetic": PhoneticName = Ts3String.Unescape(value); break;
			case "client_needed_serverquery_view_power": NeededServerqueryViewPower = int.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "client_is_channel_commander": IsChannelCommander = value.Length > 0 && value[0] != '0'; break;
			case "client_country": CountryCode = Ts3String.Unescape(value); break;
			case "client_badges": Badges = Ts3String.Unescape(value); break;
			
			}

		}
	}

	public sealed class ClientInfo : IResponse
	{
		
		public string ReturnCode { get; set; }

		public TimeSpan ClientIdleTime { get; set; }
		public string ClientVersion { get; set; }
		public string ClientVersionSign { get; set; }
		public string ClientPlattform { get; set; }
		public string DefaultChannel { get; set; }
		public string SecurityHash { get; set; }
		public string LoginName { get; set; }
		public string DefaultToken { get; set; }
		public ulong FiletransferBandwidthSent { get; set; }
		public ulong FiletransferBandwidthReceived { get; set; }
		public ulong PacketsSentTotal { get; set; }
		public ulong PacketsReceivedTotal { get; set; }
		public ulong BytesSentTotal { get; set; }
		public ulong BytesReceivedTotal { get; set; }
		public ulong BandwidthSentLastSecondTotal { get; set; }
		public ulong BandwidthReceivedLastSecondTotal { get; set; }
		public ulong BandwidthSentLastMinuteTotal { get; set; }
		public ulong BandwidthReceivedLastMinuteTotal { get; set; }
		public TimeSpan ConnectedTime { get; set; }
		public string Ip { get; set; }
		public ChannelIdT ChannelId { get; set; }
		public UidT Uid { get; set; }
		public ClientDbIdT DatabaseId { get; set; }
		public string Name { get; set; }
		public ClientType ClientType { get; set; }
		public bool InputMuted { get; set; }
		public bool OutputMuted { get; set; }
		public bool OutputOnlyMuted { get; set; }
		public bool InputHardwareEnabled { get; set; }
		public bool OutputHardwareEnabled { get; set; }
		public string Metadata { get; set; }
		public bool IsRecording { get; set; }
		public ChannelGroupIdT ChannelGroup { get; set; }
		public ChannelIdT InheritedChannelGroupFromChannel { get; set; }
		public ServerGroupIdT[] ServerGroups { get; set; }
		public bool IsAway { get; set; }
		public string AwayMessage { get; set; }
		public int TalkPower { get; set; }
		public DateTime TalkPowerRequestTime { get; set; }
		public string TalkPowerRequestMessage { get; set; }
		public bool TalkPowerGranted { get; set; }
		public bool IsPrioritySpeaker { get; set; }
		public uint UnreadMessages { get; set; }
		public string PhoneticName { get; set; }
		public int NeededServerqueryViewPower { get; set; }
		public bool IsChannelCommander { get; set; }
		public string CountryCode { get; set; }
		public string Badges { get; set; }
		public DateTime CreationDate { get; set; }
		public DateTime LastConnected { get; set; }
		public int TotalConnections { get; set; }
		public long MonthlyUploadQuota { get; set; }
		public long MonthlyDownloadQuota { get; set; }
		public long TotalUploadQuota { get; set; }
		public long TotalDownloadQuota { get; set; }
		public string Base64HashClientUid { get; set; }
		public string AvatarHash { get; set; }
		public string Description { get; set; }
		public int IconId { get; set; }

		public void SetField(string name, ReadOnlySpan<char> value)
		{

			switch(name)
			{

			case "client_idle_time": ClientIdleTime = TimeSpan.FromMilliseconds(double.Parse(value.NewString(), CultureInfo.InvariantCulture)); break;
			case "client_version": ClientVersion = Ts3String.Unescape(value); break;
			case "client_version_sign": ClientVersionSign = Ts3String.Unescape(value); break;
			case "client_platform": ClientPlattform = Ts3String.Unescape(value); break;
			case "client_default_channel": DefaultChannel = Ts3String.Unescape(value); break;
			case "client_security_hash": SecurityHash = Ts3String.Unescape(value); break;
			case "client_login_name": LoginName = Ts3String.Unescape(value); break;
			case "client_default_token": DefaultToken = Ts3String.Unescape(value); break;
			case "connection_filetransfer_bandwidth_sent": FiletransferBandwidthSent = ulong.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "connection_filetransfer_bandwidth_received": FiletransferBandwidthReceived = ulong.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "connection_packets_sent_total": PacketsSentTotal = ulong.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "connection_packets_received_total": PacketsReceivedTotal = ulong.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "connection_bytes_sent_total": BytesSentTotal = ulong.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "connection_bytes_received_total": BytesReceivedTotal = ulong.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "connection_bandwidth_sent_last_second_total": BandwidthSentLastSecondTotal = ulong.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "connection_bandwidth_received_last_second_total": BandwidthReceivedLastSecondTotal = ulong.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "connection_bandwidth_sent_last_minute_total": BandwidthSentLastMinuteTotal = ulong.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "connection_bandwidth_received_last_minute_total": BandwidthReceivedLastMinuteTotal = ulong.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "connection_connected_time": ConnectedTime = TimeSpan.FromMilliseconds(double.Parse(value.NewString(), CultureInfo.InvariantCulture)); break;
			case "connection_client_ip": Ip = Ts3String.Unescape(value); break;
			case "cid": ChannelId = ChannelIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "client_unique_identifier": Uid = Ts3String.Unescape(value); break;
			case "client_database_id": DatabaseId = ClientDbIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "client_nickname": Name = Ts3String.Unescape(value); break;
			case "client_type": { if (!Enum.TryParse(value.NewString(), out ClientType val)) throw new FormatException(); ClientType = val; } break;
			case "client_input_muted": InputMuted = value.Length > 0 && value[0] != '0'; break;
			case "client_output_muted": OutputMuted = value.Length > 0 && value[0] != '0'; break;
			case "client_outputonly_muted": OutputOnlyMuted = value.Length > 0 && value[0] != '0'; break;
			case "client_input_hardware": InputHardwareEnabled = value.Length > 0 && value[0] != '0'; break;
			case "client_output_hardware": OutputHardwareEnabled = value.Length > 0 && value[0] != '0'; break;
			case "client_meta_data": Metadata = Ts3String.Unescape(value); break;
			case "client_is_recording": IsRecording = value.Length > 0 && value[0] != '0'; break;
			case "client_channel_group_id": ChannelGroup = ChannelGroupIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "client_channel_group_inherited_channel_id": InheritedChannelGroupFromChannel = ChannelIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "client_servergroups": { if(value.Length == 0) ServerGroups = Array.Empty<ServerGroupIdT>(); else { var ss = new SpanSplitter(); ss.First(value, ','); int cnt = 0; for (int i = 0; i < value.Length; i++) if (value[i] == ',') cnt++; ServerGroups = new ServerGroupIdT[cnt + 1]; for(int i = 0; i < cnt + 1; i++) { ServerGroups[i] = ServerGroupIdT.Parse(ss.Trim(value).NewString(), CultureInfo.InvariantCulture); if (i < cnt) value = ss.Next(value); } } } break;
			case "client_away": IsAway = value.Length > 0 && value[0] != '0'; break;
			case "client_away_message": AwayMessage = Ts3String.Unescape(value); break;
			case "client_talk_power": TalkPower = int.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "client_talk_request": TalkPowerRequestTime = Util.UnixTimeStart.AddSeconds(double.Parse(value.NewString(), CultureInfo.InvariantCulture)); break;
			case "client_talk_request_msg": TalkPowerRequestMessage = Ts3String.Unescape(value); break;
			case "client_is_talker": TalkPowerGranted = value.Length > 0 && value[0] != '0'; break;
			case "client_is_priority_speaker": IsPrioritySpeaker = value.Length > 0 && value[0] != '0'; break;
			case "client_unread_messages": UnreadMessages = uint.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "client_nickname_phonetic": PhoneticName = Ts3String.Unescape(value); break;
			case "client_needed_serverquery_view_power": NeededServerqueryViewPower = int.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "client_is_channel_commander": IsChannelCommander = value.Length > 0 && value[0] != '0'; break;
			case "client_country": CountryCode = Ts3String.Unescape(value); break;
			case "client_badges": Badges = Ts3String.Unescape(value); break;
			case "client_created": CreationDate = Util.UnixTimeStart.AddSeconds(double.Parse(value.NewString(), CultureInfo.InvariantCulture)); break;
			case "client_lastconnected": LastConnected = Util.UnixTimeStart.AddSeconds(double.Parse(value.NewString(), CultureInfo.InvariantCulture)); break;
			case "client_totalconnections": TotalConnections = int.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "client_month_bytes_uploaded": MonthlyUploadQuota = long.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "client_month_bytes_downloaded": MonthlyDownloadQuota = long.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "client_total_bytes_uploaded": TotalUploadQuota = long.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "client_total_bytes_downloaded": TotalDownloadQuota = long.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "client_base64HashClientUID": Base64HashClientUid = Ts3String.Unescape(value); break;
			case "client_flag_avatar": AvatarHash = Ts3String.Unescape(value); break;
			case "client_description": Description = Ts3String.Unescape(value); break;
			case "client_icon_id": IconId = unchecked((int)long.Parse(value.NewString(), CultureInfo.InvariantCulture)); break;
			case "return_code": ReturnCode = Ts3String.Unescape(value); break;
			}

		}
	}

	public sealed class ClientLeftView : INotification
	{
		public NotificationType NotifyType { get; } = NotificationType.ClientLeftView;
		

		public string ReasonMessage { get; set; }
		public TimeSpan BanTime { get; set; }
		public Reason Reason { get; set; }
		public ChannelIdT TargetChannelId { get; set; }
		public ClientIdT InvokerId { get; set; }
		public string InvokerName { get; set; }
		public UidT InvokerUid { get; set; }
		public ClientIdT ClientId { get; set; }
		public ChannelIdT SourceChannelId { get; set; }

		public void SetField(string name, ReadOnlySpan<char> value)
		{

			switch(name)
			{

			case "reasonmsg": ReasonMessage = Ts3String.Unescape(value); break;
			case "bantime": BanTime = TimeSpan.FromSeconds(double.Parse(value.NewString(), CultureInfo.InvariantCulture)); break;
			case "reasonid": { if (!Enum.TryParse(value.NewString(), out Reason val)) throw new FormatException(); Reason = val; } break;
			case "ctid": TargetChannelId = ChannelIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "invokerid": InvokerId = ClientIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "invokername": InvokerName = Ts3String.Unescape(value); break;
			case "invokeruid": InvokerUid = Ts3String.Unescape(value); break;
			case "clid": ClientId = ClientIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "cfid": SourceChannelId = ChannelIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			
			}

		}
	}

	public sealed class ClientMoved : INotification
	{
		public NotificationType NotifyType { get; } = NotificationType.ClientMoved;
		

		public ClientIdT ClientId { get; set; }
		public Reason Reason { get; set; }
		public ChannelIdT TargetChannelId { get; set; }
		public ClientIdT InvokerId { get; set; }
		public string InvokerName { get; set; }
		public UidT InvokerUid { get; set; }

		public void SetField(string name, ReadOnlySpan<char> value)
		{

			switch(name)
			{

			case "clid": ClientId = ClientIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "reasonid": { if (!Enum.TryParse(value.NewString(), out Reason val)) throw new FormatException(); Reason = val; } break;
			case "ctid": TargetChannelId = ChannelIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "invokerid": InvokerId = ClientIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "invokername": InvokerName = Ts3String.Unescape(value); break;
			case "invokeruid": InvokerUid = Ts3String.Unescape(value); break;
			
			}

		}
	}

	public sealed class ClientNeededPermissions : INotification
	{
		public NotificationType NotifyType { get; } = NotificationType.ClientNeededPermissions;
		

		public PermissionId PermissionId { get; set; }
		public int PermissionValue { get; set; }

		public void SetField(string name, ReadOnlySpan<char> value)
		{

			switch(name)
			{

			case "permid": PermissionId = (PermissionId)uint.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "permvalue": PermissionValue = int.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			
			}

		}
	}

	public sealed class ClientServerGroup : INotification, IResponse
	{
		public NotificationType NotifyType { get; } = NotificationType.ClientServerGroup;
		public string ReturnCode { get; set; }

		public string Name { get; set; }
		public ServerGroupIdT ServerGroupId { get; set; }
		public ClientDbIdT ClientDbId { get; set; }

		public void SetField(string name, ReadOnlySpan<char> value)
		{

			switch(name)
			{

			case "name": Name = Ts3String.Unescape(value); break;
			case "sgid": ServerGroupId = ServerGroupIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "cldbid": ClientDbId = ClientDbIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "return_code": ReturnCode = Ts3String.Unescape(value); break;
			}

		}
	}

	public sealed class ClientServerGroupAdded : INotification
	{
		public NotificationType NotifyType { get; } = NotificationType.ClientServerGroupAdded;
		

		public string Name { get; set; }
		public ServerGroupIdT ServerGroupId { get; set; }
		public ClientIdT InvokerId { get; set; }
		public string InvokerName { get; set; }
		public UidT InvokerUid { get; set; }
		public ClientIdT ClientId { get; set; }
		public UidT ClientUid { get; set; }

		public void SetField(string name, ReadOnlySpan<char> value)
		{

			switch(name)
			{

			case "name": Name = Ts3String.Unescape(value); break;
			case "sgid": ServerGroupId = ServerGroupIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "invokerid": InvokerId = ClientIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "invokername": InvokerName = Ts3String.Unescape(value); break;
			case "invokeruid": InvokerUid = Ts3String.Unescape(value); break;
			case "clid": ClientId = ClientIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "cluid": ClientUid = Ts3String.Unescape(value); break;
			
			}

		}
	}

	public sealed class CommandError : INotification
	{
		public NotificationType NotifyType { get; } = NotificationType.CommandError;
		

		public Ts3ErrorCode Id { get; set; }
		public string Message { get; set; }
		public PermissionId MissingPermissionId { get; set; }
		public string ReturnCode { get; set; }
		public string ExtraMessage { get; set; }

		public void SetField(string name, ReadOnlySpan<char> value)
		{

			switch(name)
			{

			case "id": Id = (Ts3ErrorCode)uint.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "msg": Message = Ts3String.Unescape(value); break;
			case "failed_permid": MissingPermissionId = (PermissionId)uint.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "return_code": ReturnCode = Ts3String.Unescape(value); break;
			case "extra_msg": ExtraMessage = Ts3String.Unescape(value); break;
			
			}

		}
	}

	public sealed class ConnectionInfo : INotification
	{
		public NotificationType NotifyType { get; } = NotificationType.ConnectionInfo;
		

		public ClientIdT ClientId { get; set; }
		public TimeSpan Ping { get; set; }
		public TimeSpan PingDeviation { get; set; }
		public TimeSpan ConnectedTime { get; set; }
		public string Ip { get; set; }
		public ushort Port { get; set; }
		public ulong PacketsSentSpeech { get; set; }
		public ulong PacketsSentKeepalive { get; set; }
		public ulong PacketsSentControl { get; set; }
		public ulong BytesSentSpeech { get; set; }
		public ulong BytesSentKeepalive { get; set; }
		public ulong BytesSentControl { get; set; }
		public ulong PacketsReceivedSpeech { get; set; }
		public ulong PacketsReceivedKeepalive { get; set; }
		public ulong PacketsReceivedControl { get; set; }
		public ulong BytesReceivedSpeech { get; set; }
		public ulong BytesReceivedKeepalive { get; set; }
		public ulong BytesReceivedControl { get; set; }
		public float ServerToClientPacketlossSpeech { get; set; }
		public float ServerToClientPacketlossKeepalive { get; set; }
		public float ServerToClientPacketlossControl { get; set; }
		public float ServerToClientPacketlossTotal { get; set; }
		public float ClientToServerPacketlossSpeech { get; set; }
		public float ClientToServerPacketlossKeepalive { get; set; }
		public float ClientToServerPacketlossControl { get; set; }
		public float ClientToServerPacketlossTotal { get; set; }
		public ulong BandwidthSentLastSecondSpeech { get; set; }
		public ulong BandwidthSentLastSecondKeepalive { get; set; }
		public ulong BandwidthSentLastSecondControl { get; set; }
		public ulong BandwidthSentLastMinuteSpeech { get; set; }
		public ulong BandwidthSentLastMinuteKeepalive { get; set; }
		public ulong BandwidthSentLastMinuteControl { get; set; }
		public ulong BandwidthReceivedLastSecondSpeech { get; set; }
		public ulong BandwidthReceivedLastSecondKeepalive { get; set; }
		public ulong BandwidthReceivedLastSecondControl { get; set; }
		public ulong BandwidthReceivedLastMinuteSpeech { get; set; }
		public ulong BandwidthReceivedLastMinuteKeepalive { get; set; }
		public ulong BandwidthReceivedLastMinuteControl { get; set; }
		public ulong FiletransferBandwidthSent { get; set; }
		public ulong FiletransferBandwidthReceived { get; set; }
		public TimeSpan IdleTime { get; set; }

		public void SetField(string name, ReadOnlySpan<char> value)
		{

			switch(name)
			{

			case "clid": ClientId = ClientIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "connection_ping": Ping = TimeSpan.FromMilliseconds(double.Parse(value.NewString(), CultureInfo.InvariantCulture)); break;
			case "connection_ping_deviation": PingDeviation = TimeSpan.FromMilliseconds(double.Parse(value.NewString(), CultureInfo.InvariantCulture)); break;
			case "connection_connected_time": ConnectedTime = TimeSpan.FromMilliseconds(double.Parse(value.NewString(), CultureInfo.InvariantCulture)); break;
			case "connection_client_ip": Ip = Ts3String.Unescape(value); break;
			case "connection_client_port": Port = ushort.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "connection_packets_sent_speech": PacketsSentSpeech = ulong.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "connection_packets_sent_keepalive": PacketsSentKeepalive = ulong.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "connection_packets_sent_control": PacketsSentControl = ulong.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "connection_bytes_sent_speech": BytesSentSpeech = ulong.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "connection_bytes_sent_keepalive": BytesSentKeepalive = ulong.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "connection_bytes_sent_control": BytesSentControl = ulong.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "connection_packets_received_speech": PacketsReceivedSpeech = ulong.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "connection_packets_received_keepalive": PacketsReceivedKeepalive = ulong.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "connection_packets_received_control": PacketsReceivedControl = ulong.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "connection_bytes_received_speech": BytesReceivedSpeech = ulong.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "connection_bytes_received_keepalive": BytesReceivedKeepalive = ulong.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "connection_bytes_received_control": BytesReceivedControl = ulong.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "connection_server2client_packetloss_speech": ServerToClientPacketlossSpeech = float.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "connection_server2client_packetloss_keepalive": ServerToClientPacketlossKeepalive = float.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "connection_server2client_packetloss_control": ServerToClientPacketlossControl = float.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "connection_server2client_packetloss_total": ServerToClientPacketlossTotal = float.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "connection_client2server_packetloss_speech": ClientToServerPacketlossSpeech = float.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "connection_client2server_packetloss_keepalive": ClientToServerPacketlossKeepalive = float.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "connection_client2server_packetloss_control": ClientToServerPacketlossControl = float.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "connection_client2server_packetloss_total": ClientToServerPacketlossTotal = float.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "connection_bandwidth_sent_last_second_speech": BandwidthSentLastSecondSpeech = ulong.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "connection_bandwidth_sent_last_second_keepalive": BandwidthSentLastSecondKeepalive = ulong.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "connection_bandwidth_sent_last_second_control": BandwidthSentLastSecondControl = ulong.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "connection_bandwidth_sent_last_minute_speech": BandwidthSentLastMinuteSpeech = ulong.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "connection_bandwidth_sent_last_minute_keepalive": BandwidthSentLastMinuteKeepalive = ulong.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "connection_bandwidth_sent_last_minute_control": BandwidthSentLastMinuteControl = ulong.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "connection_bandwidth_received_last_second_speech": BandwidthReceivedLastSecondSpeech = ulong.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "connection_bandwidth_received_last_second_keepalive": BandwidthReceivedLastSecondKeepalive = ulong.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "connection_bandwidth_received_last_second_control": BandwidthReceivedLastSecondControl = ulong.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "connection_bandwidth_received_last_minute_speech": BandwidthReceivedLastMinuteSpeech = ulong.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "connection_bandwidth_received_last_minute_keepalive": BandwidthReceivedLastMinuteKeepalive = ulong.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "connection_bandwidth_received_last_minute_control": BandwidthReceivedLastMinuteControl = ulong.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "connection_filetransfer_bandwidth_sent": FiletransferBandwidthSent = ulong.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "connection_filetransfer_bandwidth_received": FiletransferBandwidthReceived = ulong.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "connection_idle_time": IdleTime = TimeSpan.FromMilliseconds(double.Parse(value.NewString(), CultureInfo.InvariantCulture)); break;
			
			}

		}
	}

	public sealed class ConnectionInfoRequest : INotification
	{
		public NotificationType NotifyType { get; } = NotificationType.ConnectionInfoRequest;
		


		public void SetField(string name, ReadOnlySpan<char> value)
		{

		}
	}

	public sealed class FileDownload : INotification, IResponse
	{
		public NotificationType NotifyType { get; } = NotificationType.FileDownload;
		public string ReturnCode { get; set; }

		public ushort ClientFileTransferId { get; set; }
		public ushort ServerFileTransferId { get; set; }
		public string FileTransferKey { get; set; }
		public ushort Port { get; set; }
		public long Size { get; set; }
		public string Message { get; set; }

		public void SetField(string name, ReadOnlySpan<char> value)
		{

			switch(name)
			{

			case "clientftfid": ClientFileTransferId = ushort.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "serverftfid": ServerFileTransferId = ushort.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "ftkey": FileTransferKey = Ts3String.Unescape(value); break;
			case "port": Port = ushort.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "size": Size = long.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "msg": Message = Ts3String.Unescape(value); break;
			case "return_code": ReturnCode = Ts3String.Unescape(value); break;
			}

		}
	}

	public sealed class FileInfoTs : INotification, IResponse
	{
		public NotificationType NotifyType { get; } = NotificationType.FileInfoTs;
		public string ReturnCode { get; set; }

		public ChannelIdT ChannelId { get; set; }
		public string Path { get; set; }
		public string Name { get; set; }
		public long Size { get; set; }
		public DateTime DateTime { get; set; }

		public void SetField(string name, ReadOnlySpan<char> value)
		{

			switch(name)
			{

			case "cid": ChannelId = ChannelIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "path": Path = Ts3String.Unescape(value); break;
			case "name": Name = Ts3String.Unescape(value); break;
			case "size": Size = long.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "datetime": DateTime = Util.UnixTimeStart.AddSeconds(double.Parse(value.NewString(), CultureInfo.InvariantCulture)); break;
			case "return_code": ReturnCode = Ts3String.Unescape(value); break;
			}

		}
	}

	public sealed class FileList : INotification, IResponse
	{
		public NotificationType NotifyType { get; } = NotificationType.FileList;
		public string ReturnCode { get; set; }

		public ChannelIdT ChannelId { get; set; }
		public string Path { get; set; }
		public string Name { get; set; }
		public long Size { get; set; }
		public DateTime DateTime { get; set; }
		public bool IsFile { get; set; }

		public void SetField(string name, ReadOnlySpan<char> value)
		{

			switch(name)
			{

			case "cid": ChannelId = ChannelIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "path": Path = Ts3String.Unescape(value); break;
			case "name": Name = Ts3String.Unescape(value); break;
			case "size": Size = long.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "datetime": DateTime = Util.UnixTimeStart.AddSeconds(double.Parse(value.NewString(), CultureInfo.InvariantCulture)); break;
			case "type": IsFile = value.Length > 0 && value[0] != '0'; break;
			case "return_code": ReturnCode = Ts3String.Unescape(value); break;
			}

		}
	}

	public sealed class FileListFinished : INotification
	{
		public NotificationType NotifyType { get; } = NotificationType.FileListFinished;
		

		public ChannelIdT ChannelId { get; set; }
		public string Path { get; set; }

		public void SetField(string name, ReadOnlySpan<char> value)
		{

			switch(name)
			{

			case "cid": ChannelId = ChannelIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "path": Path = Ts3String.Unescape(value); break;
			
			}

		}
	}

	public sealed class FileTransfer : INotification, IResponse
	{
		public NotificationType NotifyType { get; } = NotificationType.FileTransfer;
		public string ReturnCode { get; set; }

		public ClientIdT ClientId { get; set; }
		public string Path { get; set; }
		public string Name { get; set; }
		public long Size { get; set; }
		public long SizeDone { get; set; }
		public ushort ClientFileTransferId { get; set; }
		public ushort ServerFileTransferId { get; set; }
		public ulong Sender { get; set; }
		public int Status { get; set; }
		public float CurrentSpeed { get; set; }
		public float AverageSpeed { get; set; }
		public TimeSpan Runtime { get; set; }

		public void SetField(string name, ReadOnlySpan<char> value)
		{

			switch(name)
			{

			case "clid": ClientId = ClientIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "path": Path = Ts3String.Unescape(value); break;
			case "name": Name = Ts3String.Unescape(value); break;
			case "size": Size = long.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "sizedone": SizeDone = long.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "clientftfid": ClientFileTransferId = ushort.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "serverftfid": ServerFileTransferId = ushort.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "sender": Sender = ulong.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "status": Status = int.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "current_speed": CurrentSpeed = float.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "average_speed": AverageSpeed = float.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "runtime": Runtime = TimeSpan.FromSeconds(double.Parse(value.NewString(), CultureInfo.InvariantCulture)); break;
			case "return_code": ReturnCode = Ts3String.Unescape(value); break;
			}

		}
	}

	public sealed class FileTransferStatus : INotification
	{
		public NotificationType NotifyType { get; } = NotificationType.FileTransferStatus;
		

		public ushort ClientFileTransferId { get; set; }
		public Ts3ErrorCode Status { get; set; }
		public string Message { get; set; }
		public long Size { get; set; }

		public void SetField(string name, ReadOnlySpan<char> value)
		{

			switch(name)
			{

			case "clientftfid": ClientFileTransferId = ushort.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "status": Status = (Ts3ErrorCode)uint.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "msg": Message = Ts3String.Unescape(value); break;
			case "size": Size = long.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			
			}

		}
	}

	public sealed class FileUpload : INotification, IResponse
	{
		public NotificationType NotifyType { get; } = NotificationType.FileUpload;
		public string ReturnCode { get; set; }

		public ushort ClientFileTransferId { get; set; }
		public ushort ServerFileTransferId { get; set; }
		public string FileTransferKey { get; set; }
		public ushort Port { get; set; }
		public long SeekPosistion { get; set; }
		public string Message { get; set; }

		public void SetField(string name, ReadOnlySpan<char> value)
		{

			switch(name)
			{

			case "clientftfid": ClientFileTransferId = ushort.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "serverftfid": ServerFileTransferId = ushort.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "ftkey": FileTransferKey = Ts3String.Unescape(value); break;
			case "port": Port = ushort.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "seekpos": SeekPosistion = long.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "msg": Message = Ts3String.Unescape(value); break;
			case "return_code": ReturnCode = Ts3String.Unescape(value); break;
			}

		}
	}

	public sealed class InitIvExpand : INotification
	{
		public NotificationType NotifyType { get; } = NotificationType.InitIvExpand;
		

		public string Alpha { get; set; }
		public string Beta { get; set; }
		public string Omega { get; set; }

		public void SetField(string name, ReadOnlySpan<char> value)
		{

			switch(name)
			{

			case "alpha": Alpha = Ts3String.Unescape(value); break;
			case "beta": Beta = Ts3String.Unescape(value); break;
			case "omega": Omega = Ts3String.Unescape(value); break;
			
			}

		}
	}

	public sealed class InitIvExpand2 : INotification
	{
		public NotificationType NotifyType { get; } = NotificationType.InitIvExpand2;
		

		public string License { get; set; }
		public string Beta { get; set; }
		public string Omega { get; set; }
		public bool Ot { get; set; }
		public string Proof { get; set; }
		public string Tvd { get; set; }

		public void SetField(string name, ReadOnlySpan<char> value)
		{

			switch(name)
			{

			case "l": License = Ts3String.Unescape(value); break;
			case "beta": Beta = Ts3String.Unescape(value); break;
			case "omega": Omega = Ts3String.Unescape(value); break;
			case "ot": Ot = value.Length > 0 && value[0] != '0'; break;
			case "proof": Proof = Ts3String.Unescape(value); break;
			case "tvd": Tvd = Ts3String.Unescape(value); break;
			
			}

		}
	}

	public sealed class InitServer : INotification
	{
		public NotificationType NotifyType { get; } = NotificationType.InitServer;
		

		public string WelcomeMessage { get; set; }
		public string ServerPlatform { get; set; }
		public string ServerVersion { get; set; }
		public ushort MaxClients { get; set; }
		public DateTime ServerCreated { get; set; }
		public string Hostmessage { get; set; }
		public HostMessageMode HostmessageMode { get; set; }
		public ulong VirtualServerId { get; set; }
		public string[] ServerIp { get; set; }
		public bool AskForPrivilege { get; set; }
		public string ClientName { get; set; }
		public ClientIdT ClientId { get; set; }
		public ushort ProtocolVersion { get; set; }
		public LicenseType LicenseType { get; set; }
		public int TalkPower { get; set; }
		public int NeededServerqueryViewPower { get; set; }
		public string Name { get; set; }
		public CodecEncryptionMode CodecEncryptionMode { get; set; }
		public ServerGroupIdT DefaultServerGroup { get; set; }
		public ChannelGroupIdT DefaultChannelGroup { get; set; }
		public string HostbannerUrl { get; set; }
		public string HostbannerGfxUrl { get; set; }
		public TimeSpan HostbannerGfxInterval { get; set; }
		public float PrioritySpeakerDimmModificator { get; set; }
		public string HostbuttonTooltip { get; set; }
		public string HostbuttonUrl { get; set; }
		public string HostbuttonGfxUrl { get; set; }
		public string PhoneticName { get; set; }
		public int IconId { get; set; }
		public HostBannerMode HostbannerMode { get; set; }
		public TimeSpan TempChannelDefaultDeleteDelay { get; set; }

		public void SetField(string name, ReadOnlySpan<char> value)
		{

			switch(name)
			{

			case "virtualserver_welcomemessage": WelcomeMessage = Ts3String.Unescape(value); break;
			case "virtualserver_platform": ServerPlatform = Ts3String.Unescape(value); break;
			case "virtualserver_version": ServerVersion = Ts3String.Unescape(value); break;
			case "virtualserver_maxclients": MaxClients = ushort.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "virtualserver_created": ServerCreated = Util.UnixTimeStart.AddSeconds(double.Parse(value.NewString(), CultureInfo.InvariantCulture)); break;
			case "virtualserver_hostmessage": Hostmessage = Ts3String.Unescape(value); break;
			case "virtualserver_hostmessage_mode": { if (!Enum.TryParse(value.NewString(), out HostMessageMode val)) throw new FormatException(); HostmessageMode = val; } break;
			case "virtualserver_id": VirtualServerId = ulong.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "virtualserver_ip": { if(value.Length == 0) ServerIp = Array.Empty<string>(); else { var ss = new SpanSplitter(); ss.First(value, ','); int cnt = 0; for (int i = 0; i < value.Length; i++) if (value[i] == ',') cnt++; ServerIp = new string[cnt + 1]; for(int i = 0; i < cnt + 1; i++) { ServerIp[i] = Ts3String.Unescape(ss.Trim(value)); if (i < cnt) value = ss.Next(value); } } } break;
			case "virtualserver_ask_for_privilegekey": AskForPrivilege = value.Length > 0 && value[0] != '0'; break;
			case "acn": ClientName = Ts3String.Unescape(value); break;
			case "aclid": ClientId = ClientIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "pv": ProtocolVersion = ushort.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "lt": LicenseType = (LicenseType)ushort.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "client_talk_power": TalkPower = int.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "client_needed_serverquery_view_power": NeededServerqueryViewPower = int.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "virtualserver_name": Name = Ts3String.Unescape(value); break;
			case "virtualserver_codec_encryption_mode": { if (!Enum.TryParse(value.NewString(), out CodecEncryptionMode val)) throw new FormatException(); CodecEncryptionMode = val; } break;
			case "virtualserver_default_server_group": DefaultServerGroup = ServerGroupIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "virtualserver_default_channel_group": DefaultChannelGroup = ChannelGroupIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "virtualserver_hostbanner_url": HostbannerUrl = Ts3String.Unescape(value); break;
			case "virtualserver_hostbanner_gfx_url": HostbannerGfxUrl = Ts3String.Unescape(value); break;
			case "virtualserver_hostbanner_gfx_interval": HostbannerGfxInterval = TimeSpan.FromSeconds(double.Parse(value.NewString(), CultureInfo.InvariantCulture)); break;
			case "virtualserver_priority_speaker_dimm_modificator": PrioritySpeakerDimmModificator = float.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "virtualserver_hostbutton_tooltip": HostbuttonTooltip = Ts3String.Unescape(value); break;
			case "virtualserver_hostbutton_url": HostbuttonUrl = Ts3String.Unescape(value); break;
			case "virtualserver_hostbutton_gfx_url": HostbuttonGfxUrl = Ts3String.Unescape(value); break;
			case "virtualserver_name_phonetic": PhoneticName = Ts3String.Unescape(value); break;
			case "virtualserver_icon_id": IconId = unchecked((int)long.Parse(value.NewString(), CultureInfo.InvariantCulture)); break;
			case "virtualserver_hostbanner_mode": { if (!Enum.TryParse(value.NewString(), out HostBannerMode val)) throw new FormatException(); HostbannerMode = val; } break;
			case "virtualserver_channel_temp_delete_delay_default": TempChannelDefaultDeleteDelay = TimeSpan.FromSeconds(double.Parse(value.NewString(), CultureInfo.InvariantCulture)); break;
			
			}

		}
	}

	public sealed class PluginCommand : INotification
	{
		public NotificationType NotifyType { get; } = NotificationType.PluginCommand;
		

		public string Name { get; set; }
		public string Data { get; set; }

		public void SetField(string name, ReadOnlySpan<char> value)
		{

			switch(name)
			{

			case "name": Name = Ts3String.Unescape(value); break;
			case "data": Data = Ts3String.Unescape(value); break;
			
			}

		}
	}

	public sealed class ServerData : IResponse
	{
		
		public string ReturnCode { get; set; }

		public int ClientsOnline { get; set; }
		public int QueriesOnline { get; set; }
		public ushort MaxClients { get; set; }
		public TimeSpan Uptime { get; set; }
		public bool Autostart { get; set; }
		public string MachineId { get; set; }
		public string Name { get; set; }
		public ulong VirtualServerId { get; set; }
		public UidT VirtualServerUid { get; set; }
		public ushort VirtualServerPort { get; set; }
		public string VirtualServerStatus { get; set; }

		public void SetField(string name, ReadOnlySpan<char> value)
		{

			switch(name)
			{

			case "virtualserver_clientsonline": ClientsOnline = int.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "virtualserver_queryclientsonline": QueriesOnline = int.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "virtualserver_maxclients": MaxClients = ushort.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "virtualserver_uptime": Uptime = TimeSpan.FromSeconds(double.Parse(value.NewString(), CultureInfo.InvariantCulture)); break;
			case "virtualserver_autostart": Autostart = value.Length > 0 && value[0] != '0'; break;
			case "virtualserver_machine_id": MachineId = Ts3String.Unescape(value); break;
			case "virtualserver_name": Name = Ts3String.Unescape(value); break;
			case "virtualserver_id": VirtualServerId = ulong.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "virtualserver_unique_identifier": VirtualServerUid = Ts3String.Unescape(value); break;
			case "virtualserver_port": VirtualServerPort = ushort.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "virtualserver_status": VirtualServerStatus = Ts3String.Unescape(value); break;
			case "return_code": ReturnCode = Ts3String.Unescape(value); break;
			}

		}
	}

	public sealed class ServerEdited : INotification
	{
		public NotificationType NotifyType { get; } = NotificationType.ServerEdited;
		

		public ClientIdT InvokerId { get; set; }
		public string InvokerName { get; set; }
		public UidT InvokerUid { get; set; }
		public Reason Reason { get; set; }
		public string Name { get; set; }
		public CodecEncryptionMode CodecEncryptionMode { get; set; }
		public ServerGroupIdT DefaultServerGroup { get; set; }
		public ChannelGroupIdT DefaultChannelGroup { get; set; }
		public string HostbannerUrl { get; set; }
		public string HostbannerGfxUrl { get; set; }
		public TimeSpan HostbannerGfxInterval { get; set; }
		public float PrioritySpeakerDimmModificator { get; set; }
		public string HostbuttonTooltip { get; set; }
		public string HostbuttonUrl { get; set; }
		public string HostbuttonGfxUrl { get; set; }
		public string PhoneticName { get; set; }
		public int IconId { get; set; }
		public HostBannerMode HostbannerMode { get; set; }
		public TimeSpan TempChannelDefaultDeleteDelay { get; set; }

		public void SetField(string name, ReadOnlySpan<char> value)
		{

			switch(name)
			{

			case "invokerid": InvokerId = ClientIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "invokername": InvokerName = Ts3String.Unescape(value); break;
			case "invokeruid": InvokerUid = Ts3String.Unescape(value); break;
			case "reasonid": { if (!Enum.TryParse(value.NewString(), out Reason val)) throw new FormatException(); Reason = val; } break;
			case "virtualserver_name": Name = Ts3String.Unescape(value); break;
			case "virtualserver_codec_encryption_mode": { if (!Enum.TryParse(value.NewString(), out CodecEncryptionMode val)) throw new FormatException(); CodecEncryptionMode = val; } break;
			case "virtualserver_default_server_group": DefaultServerGroup = ServerGroupIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "virtualserver_default_channel_group": DefaultChannelGroup = ChannelGroupIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "virtualserver_hostbanner_url": HostbannerUrl = Ts3String.Unescape(value); break;
			case "virtualserver_hostbanner_gfx_url": HostbannerGfxUrl = Ts3String.Unescape(value); break;
			case "virtualserver_hostbanner_gfx_interval": HostbannerGfxInterval = TimeSpan.FromSeconds(double.Parse(value.NewString(), CultureInfo.InvariantCulture)); break;
			case "virtualserver_priority_speaker_dimm_modificator": PrioritySpeakerDimmModificator = float.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "virtualserver_hostbutton_tooltip": HostbuttonTooltip = Ts3String.Unescape(value); break;
			case "virtualserver_hostbutton_url": HostbuttonUrl = Ts3String.Unescape(value); break;
			case "virtualserver_hostbutton_gfx_url": HostbuttonGfxUrl = Ts3String.Unescape(value); break;
			case "virtualserver_name_phonetic": PhoneticName = Ts3String.Unescape(value); break;
			case "virtualserver_icon_id": IconId = unchecked((int)long.Parse(value.NewString(), CultureInfo.InvariantCulture)); break;
			case "virtualserver_hostbanner_mode": { if (!Enum.TryParse(value.NewString(), out HostBannerMode val)) throw new FormatException(); HostbannerMode = val; } break;
			case "virtualserver_channel_temp_delete_delay_default": TempChannelDefaultDeleteDelay = TimeSpan.FromSeconds(double.Parse(value.NewString(), CultureInfo.InvariantCulture)); break;
			
			}

		}
	}

	public sealed class ServerGroupAddResponse : IResponse
	{
		
		public string ReturnCode { get; set; }

		public ServerGroupIdT ServerGroupId { get; set; }

		public void SetField(string name, ReadOnlySpan<char> value)
		{

			switch(name)
			{

			case "sgid": ServerGroupId = ServerGroupIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "return_code": ReturnCode = Ts3String.Unescape(value); break;
			}

		}
	}

	public sealed class ServerGroupList : INotification
	{
		public NotificationType NotifyType { get; } = NotificationType.ServerGroupList;
		

		public ServerGroupIdT ServerGroupId { get; set; }
		public string Name { get; set; }
		public GroupType GroupType { get; set; }
		public int IconId { get; set; }
		public bool IsPermanent { get; set; }
		public int SortId { get; set; }
		public GroupNamingMode NamingMode { get; set; }
		public int NeededModifyPower { get; set; }
		public int NeededMemberAddPower { get; set; }
		public int NeededMemberRemovePower { get; set; }

		public void SetField(string name, ReadOnlySpan<char> value)
		{

			switch(name)
			{

			case "sgid": ServerGroupId = ServerGroupIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "name": Name = Ts3String.Unescape(value); break;
			case "type": { if (!Enum.TryParse(value.NewString(), out GroupType val)) throw new FormatException(); GroupType = val; } break;
			case "iconid": IconId = unchecked((int)long.Parse(value.NewString(), CultureInfo.InvariantCulture)); break;
			case "savedb": IsPermanent = value.Length > 0 && value[0] != '0'; break;
			case "sortid": SortId = int.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "namemode": { if (!Enum.TryParse(value.NewString(), out GroupNamingMode val)) throw new FormatException(); NamingMode = val; } break;
			case "n_modifyp": NeededModifyPower = int.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "n_member_addp": NeededMemberAddPower = int.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "n_member_remove_p": NeededMemberRemovePower = int.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			
			}

		}
	}

	public sealed class TextMessage : INotification
	{
		public NotificationType NotifyType { get; } = NotificationType.TextMessage;
		

		public TextMessageTargetMode Target { get; set; }
		public string Message { get; set; }
		public ClientIdT TargetClientId { get; set; }
		public ClientIdT InvokerId { get; set; }
		public string InvokerName { get; set; }
		public UidT InvokerUid { get; set; }

		public void SetField(string name, ReadOnlySpan<char> value)
		{

			switch(name)
			{

			case "targetmode": { if (!Enum.TryParse(value.NewString(), out TextMessageTargetMode val)) throw new FormatException(); Target = val; } break;
			case "msg": Message = Ts3String.Unescape(value); break;
			case "target": TargetClientId = ClientIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "invokerid": InvokerId = ClientIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "invokername": InvokerName = Ts3String.Unescape(value); break;
			case "invokeruid": InvokerUid = Ts3String.Unescape(value); break;
			
			}

		}
	}

	public sealed class TokenUsed : INotification
	{
		public NotificationType NotifyType { get; } = NotificationType.TokenUsed;
		

		public string UsedToken { get; set; }
		public string TokenCustomSet { get; set; }
		public string Token1 { get; set; }
		public string Token2 { get; set; }
		public ClientIdT ClientId { get; set; }
		public ClientDbIdT ClientDbId { get; set; }
		public UidT ClientUid { get; set; }

		public void SetField(string name, ReadOnlySpan<char> value)
		{

			switch(name)
			{

			case "token": UsedToken = Ts3String.Unescape(value); break;
			case "tokencustomset": TokenCustomSet = Ts3String.Unescape(value); break;
			case "token1": Token1 = Ts3String.Unescape(value); break;
			case "token2": Token2 = Ts3String.Unescape(value); break;
			case "clid": ClientId = ClientIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "cldbid": ClientDbId = ClientDbIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "cluid": ClientUid = Ts3String.Unescape(value); break;
			
			}

		}
	}

	public sealed class WhoAmI : IResponse
	{
		
		public string ReturnCode { get; set; }

		public ClientIdT ClientId { get; set; }
		public ChannelIdT ChannelId { get; set; }
		public string Name { get; set; }
		public ClientDbIdT DatabaseId { get; set; }
		public string LoginName { get; set; }
		public ulong OriginServerId { get; set; }
		public ulong VirtualServerId { get; set; }
		public UidT VirtualServerUid { get; set; }
		public ushort VirtualServerPort { get; set; }
		public string VirtualServerStatus { get; set; }
		public UidT Uid { get; set; }

		public void SetField(string name, ReadOnlySpan<char> value)
		{

			switch(name)
			{

			case "client_id": ClientId = ClientIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "client_channel_id": ChannelId = ChannelIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "client_nickname": Name = Ts3String.Unescape(value); break;
			case "client_database_id": DatabaseId = ClientDbIdT.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "client_login_name": LoginName = Ts3String.Unescape(value); break;
			case "client_origin_server_id": OriginServerId = ulong.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "virtualserver_id": VirtualServerId = ulong.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "virtualserver_unique_identifier": VirtualServerUid = Ts3String.Unescape(value); break;
			case "virtualserver_port": VirtualServerPort = ushort.Parse(value.NewString(), CultureInfo.InvariantCulture); break;
			case "virtualserver_status": VirtualServerStatus = Ts3String.Unescape(value); break;
			case "client_unique_identifier": Uid = Ts3String.Unescape(value); break;
			case "return_code": ReturnCode = Ts3String.Unescape(value); break;
			}

		}
	}

	public enum NotificationType
	{
		Unknown,
		ChannelChanged,
		ChannelCreated,
		ChannelDeleted,
		ChannelEdited,
		ChannelGroupList,
		ChannelList,
		ChannelListFinished,
		ChannelMoved,
		ChannelPasswordChanged,
		ChannelSubscribed,
		ChannelUnsubscribed,
		ClientChannelGroupChanged,
		ClientChatComposing,
		ClientEnterView,
		ClientLeftView,
		ClientMoved,
		ClientNeededPermissions,
		ClientServerGroup,
		ClientServerGroupAdded,
		CommandError,
		ConnectionInfo,
		ConnectionInfoRequest,
		FileDownload,
		FileInfoTs,
		FileList,
		FileListFinished,
		FileTransfer,
		FileTransferStatus,
		FileUpload,
		InitIvExpand,
		InitIvExpand2,
		InitServer,
		PluginCommand,
		ServerEdited,
		ServerGroupList,
		TextMessage,
		TokenUsed,
	}

	public static class MessageHelper
	{
		public static NotificationType GetNotificationType(string name)
		{
			switch(name)
			{
			case "notifychannelchanged": return NotificationType.ChannelChanged;
			case "notifychannelcreated": return NotificationType.ChannelCreated;
			case "notifychanneldeleted": return NotificationType.ChannelDeleted;
			case "notifychanneledited": return NotificationType.ChannelEdited;
			case "notifychannelgrouplist": return NotificationType.ChannelGroupList;
			case "channellist": return NotificationType.ChannelList;
			case "channellistfinished": return NotificationType.ChannelListFinished;
			case "notifychannelmoved": return NotificationType.ChannelMoved;
			case "notifychannelpasswordchanged": return NotificationType.ChannelPasswordChanged;
			case "notifychannelsubscribed": return NotificationType.ChannelSubscribed;
			case "notifychannelunsubscribed": return NotificationType.ChannelUnsubscribed;
			case "notifyclientchannelgroupchanged": return NotificationType.ClientChannelGroupChanged;
			case "notifyclientchatcomposing": return NotificationType.ClientChatComposing;
			case "notifycliententerview": return NotificationType.ClientEnterView;
			case "notifyclientleftview": return NotificationType.ClientLeftView;
			case "notifyclientmoved": return NotificationType.ClientMoved;
			case "notifyclientneededpermissions": return NotificationType.ClientNeededPermissions;
			case "notifyservergroupsbyclientid": return NotificationType.ClientServerGroup;
			case "notifyservergroupclientadded": return NotificationType.ClientServerGroupAdded;
			case "error": return NotificationType.CommandError;
			case "notifyconnectioninfo": return NotificationType.ConnectionInfo;
			case "notifyconnectioninforequest": return NotificationType.ConnectionInfoRequest;
			case "notifystartdownload": return NotificationType.FileDownload;
			case "notifyfileinfo": return NotificationType.FileInfoTs;
			case "notifyfilelist": return NotificationType.FileList;
			case "notifyfilelistfinished": return NotificationType.FileListFinished;
			case "notifyfiletransferlist": return NotificationType.FileTransfer;
			case "notifystatusfiletransfer": return NotificationType.FileTransferStatus;
			case "notifystartupload": return NotificationType.FileUpload;
			case "initivexpand": return NotificationType.InitIvExpand;
			case "initivexpand2": return NotificationType.InitIvExpand2;
			case "initserver": return NotificationType.InitServer;
			case "notifyplugincmd": return NotificationType.PluginCommand;
			case "notifyserveredited": return NotificationType.ServerEdited;
			case "notifyservergrouplist": return NotificationType.ServerGroupList;
			case "notifytextmessage": return NotificationType.TextMessage;
			case "notifytokenused": return NotificationType.TokenUsed;
			default: return NotificationType.Unknown;
			}
		}

		public static INotification GenerateNotificationType(NotificationType name)
		{
			switch(name)
			{
			case NotificationType.ChannelChanged: return new ChannelChanged();
			case NotificationType.ChannelCreated: return new ChannelCreated();
			case NotificationType.ChannelDeleted: return new ChannelDeleted();
			case NotificationType.ChannelEdited: return new ChannelEdited();
			case NotificationType.ChannelGroupList: return new ChannelGroupList();
			case NotificationType.ChannelList: return new ChannelList();
			case NotificationType.ChannelListFinished: return new ChannelListFinished();
			case NotificationType.ChannelMoved: return new ChannelMoved();
			case NotificationType.ChannelPasswordChanged: return new ChannelPasswordChanged();
			case NotificationType.ChannelSubscribed: return new ChannelSubscribed();
			case NotificationType.ChannelUnsubscribed: return new ChannelUnsubscribed();
			case NotificationType.ClientChannelGroupChanged: return new ClientChannelGroupChanged();
			case NotificationType.ClientChatComposing: return new ClientChatComposing();
			case NotificationType.ClientEnterView: return new ClientEnterView();
			case NotificationType.ClientLeftView: return new ClientLeftView();
			case NotificationType.ClientMoved: return new ClientMoved();
			case NotificationType.ClientNeededPermissions: return new ClientNeededPermissions();
			case NotificationType.ClientServerGroup: return new ClientServerGroup();
			case NotificationType.ClientServerGroupAdded: return new ClientServerGroupAdded();
			case NotificationType.CommandError: return new CommandError();
			case NotificationType.ConnectionInfo: return new ConnectionInfo();
			case NotificationType.ConnectionInfoRequest: return new ConnectionInfoRequest();
			case NotificationType.FileDownload: return new FileDownload();
			case NotificationType.FileInfoTs: return new FileInfoTs();
			case NotificationType.FileList: return new FileList();
			case NotificationType.FileListFinished: return new FileListFinished();
			case NotificationType.FileTransfer: return new FileTransfer();
			case NotificationType.FileTransferStatus: return new FileTransferStatus();
			case NotificationType.FileUpload: return new FileUpload();
			case NotificationType.InitIvExpand: return new InitIvExpand();
			case NotificationType.InitIvExpand2: return new InitIvExpand2();
			case NotificationType.InitServer: return new InitServer();
			case NotificationType.PluginCommand: return new PluginCommand();
			case NotificationType.ServerEdited: return new ServerEdited();
			case NotificationType.ServerGroupList: return new ServerGroupList();
			case NotificationType.TextMessage: return new TextMessage();
			case NotificationType.TokenUsed: return new TokenUsed();
			case NotificationType.Unknown:
			default: throw Util.UnhandledDefault(name);
			}
		}
	}
}