﻿using System.IO;
using Commons.Utils;
/*
   Author:Sagara
*/
namespace LoginServer.Emu.Networking.Handling.Frames.Send
{
    public class SpUnk : APacketProcessor
    {
        public override byte[] WritedData()
        {
            using (var stream = new MemoryStream())
            using (var writer = new BinaryWriter(stream))
            {
                //karyzir for InCube: i no have more time for analyse it
                writer.Write("E175B228017A110000".ToBytes());

                return stream.ToArray();
            }
        }
    }
}
