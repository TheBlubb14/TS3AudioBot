type CmdBotInfo = {
    Id: number;
    Name: string;
    Server: string;
}

type CmdBotsSettings = {
    run: boolean;
}

type CmdSongPosition = {
    length: string;
    position: string;
}

type CmdSong = {
    title: string;
    source: string;
}

type ApiError = {
    ErrorCode: number;
    ErrorMessage: string;
    ErrorName: string;
    HelpLink?: string;
}