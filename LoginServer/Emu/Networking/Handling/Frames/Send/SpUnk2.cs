﻿using System.IO;
using Commons.Utils;
/*
   Author:Sagara
*/
namespace LoginServer.Emu.Networking.Handling.Frames.Send
{
    public class SpUnk2 : APacketProcessor
    {
        public override byte[] WritedData()
        {
            using (var stream = new MemoryStream())
            using (var writer = new BinaryWriter(stream))
            {
                //karyzir for InCube: i no have more time for analyse it
                //That client config packet
                writer.Write("010409C0C62D0000000000E093040000000000400D0300400D030000000000000000000004080C101C20202020202020202020202020202020202020202020202020203300000001000000805101000000000080510100000000008051010000000000000100060000960000003200040100040200040300040400040500040600040700040800040900040B00040C00040D00040E00040F00041000041100041200041300041400041500041600041700041800041900041F00042100042200042400042500042600042700042800042900042A00042B00042C00042D00042E00043D00043E00043F00044000046500046600046700046800046900046A00046B00046C00".ToBytes());

                return stream.ToArray();
            }
        }
    }
}