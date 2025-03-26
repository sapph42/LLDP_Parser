using System.ComponentModel;

namespace SapphTools.Parsers.Lldp.Ieee.MacPhyConfigFields; 
public enum MauType : ushort {
    [Description("other or unknown")]
    Unk = 0,

    [Description("AUI")]
    Aui = 1,

    [Description("10BASE-5")]
    Base105 = 2,

    [Description("FOIRL")]
    Foirl = 3,

    [Description("10BASE-2")]
    Base102 = 4,

    [Description("10BASE-T duplex mode unknown")]
    Base10T = 5,

    [Description("10BASE-FP")]
    Base10FP = 6,

    [Description("10BASE-FB")]
    Base10FB = 7,

    [Description("10BASE-FL duplex mode unknown")]
    Base10FL = 8,

    [Description("10BROAD36")]
    Broad10_36 = 9,

    [Description("10BASE-T  half duplex mode")]
    Base10T_Half = 10,

    [Description("10BASE-T  full duplex mode")]
    Base10T_Full = 11,

    [Description("10BASE-FL half duplex mode")]
    Base10FL_Half = 12,

    [Description("10BASE-FL full duplex mode")]
    Base10FL_Full = 13,

    [Description("100BASE-T4")]
    Base100T4 = 14,

    [Description("100BASE-TX half duplex mode")]
    Base100TX_Half = 15,

    [Description("100BASE-TX full duplex mode")]
    Base100TX_Full = 16,

    [Description("100BASE-FX half duplex mode")]
    Base100FX_Half = 17,

    [Description("100BASE-FX full duplex mode")]
    Base100FX_Full = 18,

    [Description("100BASE-T2 half duplex mode")]
    Base100T2_Half = 19,

    [Description("100BASE-T2 full duplex mode")]
    Base100T2_Full = 20,

    [Description("1000BASE-X half duplex mode")]
    Base1000X_Half = 21,

    [Description("1000BASE-X full duplex mode")]
    Base1000X_Full = 22,

    [Description("1000BASE-LX half duplex mode")]
    Base1000LX_Half = 23,

    [Description("1000BASE-LX full duplex mode")]
    Base1000LX_Full = 24,

    [Description("1000BASE-SX half duplex mode")]
    Base1000SX_Half = 25,

    [Description("1000BASE-SX full duplex mode")]
    Base1000SX_Full = 26,

    [Description("1000BASE-CX half duplex mode")]
    Base1000CX_Half = 27,

    [Description("1000BASE-CX full duplex mode")]
    Base1000CX_Full = 28,

    [Description("1000BASE-T half duplex mode")]
    Base1000T_Half = 29,

    [Description("1000BASE-T full duplex mode")]
    Base1000T_Full = 30,

    [Description("10GBASE-X")]
    Base10G_X = 31,

    [Description("10GBASE-LX4")]
    Base10G_LX4 = 32,

    [Description("10GBASE-R")]
    Base10G_R = 33,

    [Description("10GBASE-ER")]
    Base10G_ER = 34,

    [Description("10GBASE-LR")]
    Base10G_LR = 35,

    [Description("10GBASE-SR")]
    Base10G_SR = 36,

    [Description("10GBASE-W")]
    Base10G_W = 37,

    [Description("10GBASE-EW")]
    Base10G_EW = 38,

    [Description("10GBASE-LW")]
    Base10G_LW = 39,

    [Description("10GBASE-SW")]
    Base10G_SW = 40,

    [Description("10GBASE-CX4")]
    Base10G_CX4 = 41,

    [Description("2BASE-TL")]
    Base2_TL = 42,

    [Description("10PASS-TS")]
    Pass10_TS = 43,

    [Description("100BASE-BX10D")]
    Base100_BX10D = 44,

    [Description("100BASE-BX10U")]
    Base100_BX10U = 45,

    [Description("100BASE-LX10")]
    Base100_LX10 = 46,

    [Description("1000BASE-BX10D")]
    Base1000_BX10D = 47,

    [Description("1000BASE-BX10U")]
    Base1000_BX10U = 48,

    [Description("1000BASE-LX10")]
    Base1000_LX10 = 49,

    [Description("1000BASE-PX10D")]
    Base1000_PX10D = 50,

    [Description("1000BASE-PX10U")]
    Base1000_PX10U = 51,

    [Description("1000BASE-PX20D")]
    Base1000_PX20D = 52,

    [Description("1000BASE-PX20U")]
    Base1000_PX20U = 53,

    [Description("10GBASE-T")]
    Base10G_T = 54,

    [Description("10GBASE-LRM")]
    Base10G_LRM = 55,

    [Description("1000BASE-KX")]
    Base1000_KX = 56,

    [Description("10GBASE-KX4")]
    Base10G_KX4 = 57,

    [Description("10GBASE-KR")]
    Base10G_KR = 58,

    [Description("10/1GBASE-PRX-D1")]
    Base10_1G_PRX_D1 = 59,

    [Description("10/1GBASE-PRX-D2")]
    Base10_1G_PRX_D2 = 60,

    [Description("10/1GBASE-PRX-D3")]
    Base10_1G_PRX_D3 = 61,

    [Description("10/1GBASE-PRX-U1")]
    Base10_1G_PRX_U1 = 62,

    [Description("10/1GBASE-PRX-U2")]
    Base10_1G_PRX_U2 = 63,

    [Description("10/1GBASE-PRX-U3")]
    Base10_1G_PRX_U3 = 64,

    [Description("10GBASE-PR-D1")]
    Base10G_PR_D1 = 65,

    [Description("10GBASE-PR-D2")]
    Base10G_PR_D2 = 66,

    [Description("10GBASE-PR-D3")]
    Base10G_PR_D3 = 67,

    [Description("10GBASE-PR-U1")]
    Base10G_PR_U1 = 68,

    [Description("10GBASE-PR-U3")]
    Base10G_PR_U3 = 69,

    [Description("40GBASE-KR4")]
    Base40G_KR4 = 70,

    [Description("40GBASE-CR4")]
    Base40G_CR4 = 71,

    [Description("40GBASE-SR4")]
    Base40G_SR4 = 72,

    [Description("40GBASE-FR")]
    Base40G_FR = 73,

    [Description("40GBASE-LR4")]
    Base40G_LR4 = 74,

    [Description("100GBASE-CR10")]
    Base100G_CR10 = 75,

    [Description("100GBASE-SR10")]
    Base100G_SR10 = 76,

    [Description("100GBASE-LR4")]
    Base100G_LR4 = 77,

    [Description("100GBASE-ER4")]
    Base100G_ER4 = 78,

    [Description("1000BASE-T1")]
    Base1000_T1 = 79,

    [Description("1000BASE-PX30D")]
    Base1000_PX30D = 80,

    [Description("1000BASE-PX30U")]
    Base1000_PX30U = 81,

    [Description("1000BASE-PX40D")]
    Base1000_PX40D = 82,

    [Description("1000BASE-PX40U")]
    Base1000_PX40U = 83,

    [Description("10/1GBASE-PRX-D4")]
    Base10_1G_PRX_D4 = 84,

    [Description("10/1GBASE-PRX-U4")]
    Base10_1G_PRX_U4 = 85,

    [Description("10GBASE-PRD4")]
    Base10G_PRD4 = 86,

    [Description("10GBASE-PRU4")]
    Base10G_PRU4 = 87,

    [Description("25GBASE-CR")]
    Base25G_CR = 88,

    [Description("25GBASE-CR-S")]
    Base25G_CR_S = 89,

    [Description("25GBASE-KR")]
    Base25G_KR = 90,

    [Description("25GBASE-KR-S")]
    Base25G_KR_S = 91,

    [Description("25GBASE-R")]
    Base25G_R = 92,

    [Description("25GBASE-SR")]
    Base25G_SR = 93,

    [Description("25GBASE-T")]
    Base25G_T = 94,

    [Description("40GBASE-ER4")]
    Base40G_ER4 = 95,

    [Description("40GBASE-R")]
    Base40G_R = 96,

    [Description("40GBASE-T")]
    Base40G_T = 97,

    [Description("100GBASE-CR4")]
    Base100G_CR4 = 98,

    [Description("100GBASE-KR4")]
    Base100G_KR4 = 99,

    [Description("100GBASE-KP4")]
    Base100G_KP4 = 100,

    [Description("100GBASE-R")]
    Base100G_R = 101,

    [Description("100GBASE-SR4")]
    Base100G_SR4 = 102,

    [Description("2.5GBASE-T")]
    Base2_5G_T = 103,

    [Description("5GBASE-T")]
    Base5G_T = 104,

    [Description("100BASE-T1")]
    Base100_T1 = 105,

    [Description("1000BASE-RHA")]
    Base1000_RHA = 106,

    [Description("1000BASE-RHB")]
    Base1000_RHB = 107,

    [Description("1000BASE-RHC")]
    Base1000_RHC = 108,

    [Description("2.5GBASE-KX")]
    Base2_5G_KX = 109,

    [Description("2.5GBASE-X")]
    Base2_5G_X = 110,

    [Description("5GBASE-KR")]
    Base5G_KR = 111,

    [Description("5GBASE-R")]
    Base_5G_R = 112,

    [Description("10GPASS-XR")]
    Pass10G_XR = 113,

    [Description("25GBASE-LR")]
    Base25G_LR = 114,

    [Description("25GBASE-ER")]
    Base25G_ER = 115,

    [Description("50GBASE-R")]
    Base50G_R = 116,

    [Description("50GBASE-CR")]
    Base50G_CR = 117,

    [Description("50GBASE-KR")]
    Base50G_KR = 118,

    [Description("50GBASE-SR")]
    Base50G_SR = 119,

    [Description("50GBASE-FR")]
    Base50G_FR = 120,

    [Description("50GBASE-LR")]
    Base50G_LR = 121,

    [Description("50GBASE-ER")]
    Base50G_ER = 122,

    [Description("100GBASE-CR2")]
    Base100G_CR2 = 123,

    [Description("100GBASE-KR2")]
    Base100G_KR2 = 124,

    [Description("100GBASE-SR2")]
    Base100G_SR2 = 125,

    [Description("100GBASE-DR")]
    Base100G_DR = 126,

    [Description("200GBASE-R")]
    Base200G_R = 127,

    [Description("200GBASE-DR4")]
    Base200G_DR4 = 128,

    [Description("200GBASE-FR4")]
    Base200G_FR4 = 129,

    [Description("200GBASE-LR4")]
    Base200G_LR4 = 130,

    [Description("200GBASE-CR4")]
    Base200G_CR4 = 131,

    [Description("200GBASE-KR4")]
    Base200G_KR4 = 132,

    [Description("200GBASE-SR4")]
    Base200G_SR4 = 133,

    [Description("200GBASE-ER4")]
    Base200G_ER4 = 134,

    [Description("400GBASE-R")]
    Base400G_R = 135,

    [Description("400GBASE-SR16")]
    Base400G_SR16 = 136,

    [Description("400GBASE-DR4")]
    Base400G_DR4 = 137,

    [Description("400GBASE-FR8")]
    Base400G_FR8 = 138,

    [Description("400GBASE-LR8")]
    Base400G_LR8 = 139,

    [Description("400GBASE-ER8")]
    Base400G_ER8 = 140,

    [Description("10BASE-T1L")]
    Base10_T1L = 141,

    [Description("10BASE-T1S half duplex mode")]
    Base10_T1S_Half = 142,

    [Description("10BASE-T1S multidrop mode")]
    Base10_T1S_multi = 143,

    [Description("10BASE-T1S full duplex mode")]
    Base10_T1S_Full = 144,

    [Description("100GBASE-FR1")]
    Base100G_FR1 = 145,

    [Description("100GBASE-LR1")]
    Base100G_LR1 = 146,

    [Description("400GBASE-FR4")]
    Base400G_FR4 = 147,

    [Description("400GBASE-LR4-6")]
    Base400G_LR4_6 = 148,

    [Description("400GBASE-SR8")]
    Base400G_SR8 = 149,

    [Description("400GBASE-LR4.2")]
    Base400G_LR4_2 = 150,

    [Description("2.5GBASE-T1")]
    Base2_5G_T1 = 151,

    [Description("5GBASE-T1")]
    Base5G_T1 = 152,

    [Description("10GBASE-T1")]
    Base10G_T1 = 153,

    [Description("25/10GBASE-PQG-D2")]
    Base25_10G_PQG_D2 = 154,

    [Description("25/10GBASE-PQG-D3")]
    Base25_10G_PQG_D3 = 155,

    [Description("25/10GBASE-PQG-U2")]
    Base25_10G_PQG_U2 = 156,

    [Description("25/10GBASE-PQG-U3")]
    Base25_10G_PQG_U3 = 157,

    [Description("25/10GBASE-PQX-D2")]
    Base25_10G_PQX_D2 = 158,

    [Description("25/10GBASE-PQX-D3")]
    Base25_10G_PQX_D3 = 159,

    [Description("25/10GBASE-PQX-U2")]
    Base25_10G_PQX_U2 = 160,

    [Description("25/10GBASE-PQX-U3")]
    Base25_10G_PQX_U3 = 161,

    [Description("25GBASE-PQG-D2")]
    Base25G_PQG_D2 = 162,

    [Description("25GBASE-PQG-D3")]
    Base25G_PQG_D3 = 163,

    [Description("25GBASE-PQG-U2")]
    Base25G_PQG_U2 = 164,

    [Description("25GBASE-PQG-U3")]
    Base25G_PQG_U3 = 165,

    [Description("25GBASE-PQX-D2")]
    Base25G_PQX_D2 = 166,

    [Description("25GBASE-PQX-D3")]
    Base25G_PQX_D3 = 167,

    [Description("25GBASE-PQX-U2")]
    Base25G_PQX_U2 = 168,

    [Description("25GBASE-PQX-U3")]
    Base25G_PQX_U3 = 169,

    [Description("50/10GBASE-PQG-D2")]
    Base50_10G_PQG_D2 = 170,

    [Description("50/10GBASE-PQG-D3")]
    Base50_10G_PQG_D3 = 171,

    [Description("50/10GBASE-PQG-U2")]
    Base50_10G_PQG_U2 = 172,

    [Description("50/10GBASE-PQG-U3")]
    Base50_10G_PQG_U3 = 173,

    [Description("50/10GBASE-PQX-D2")]
    Base50_10G_PQX_D2 = 174,

    [Description("50/10GBASE-PQX-D3")]
    Base50_10G_PQX_D3 = 175,

    [Description("50/10GBASE-PQX-U2")]
    Base50_10G_PQX_U2 = 176,

    [Description("50/10GBASE-PQX-U3")]
    Base50_10G_PQX_U3 = 177,

    [Description("50/25GBASE-PQG-D2")]
    Base50_25G_PQG_D2 = 178,

    [Description("50/25GBASE-PQG-D3")]
    Base50_25G_PQG_D3 = 179,

    [Description("50/25GBASE-PQG-U2")]
    Base50_25G_PQG_U2 = 180,

    [Description("50/25GBASE-PQG-U3")]
    Base50_25G_PQG_U3 = 181,

    [Description("50/25GBASE-PQX-D2")]
    Base50_25G_PQX_D2 = 182,

    [Description("50/25GBASE-PQX-D3")]
    Base50_25G_PQX_D3 = 183,

    [Description("50/25GBASE-PQX-U2")]
    Base50_25G_PQX_U2 = 184,

    [Description("50/25GBASE-PQX-U3")]
    Base50_25G_PQX_U3 = 185,

    [Description("50GBASE-PQG-D2")]
    Base50G_PQG_D2 = 186,

    [Description("50GBASE-PQG-D3")]
    Base50G_PQG_D3 = 187,

    [Description("50GBASE-PQG-U2")]
    Base50G_PQG_U2 = 188,

    [Description("50GBASE-PQG-U3")]
    Base50G_PQG_U3 = 189,

    [Description("50GBASE-PQX-D2")]
    Base50G_PQX_D2 = 190,

    [Description("50GBASE-PQX-D3")]
    Base50G_PQX_D3 = 191,

    [Description("50GBASE-PQX-U2")]
    Base50G_PQX_U2 = 192,

    [Description("50GBASE-PQX-U3")]
    Base50G_PQX_U3 = 193,

    [Description("100GBASE-ZR")]
    Base100G_ZR = 194,

    [Description("10GBASE-BR10-D")]
    Base10G_BR10_D = 195,

    [Description("10GBASE-BR10-U")]
    Base10G_BR10_U = 196,

    [Description("10GBASE-BR20-D")]
    Base10G_BR20_D = 197,

    [Description("10GBASE-BR20-U")]
    Base10G_BR20_U = 198,

    [Description("10GBASE-BR40-D")]
    Base10G_BR40_D = 199,

    [Description("10GBASE-BR40-U")]
    Base10G_BR40_U = 200,

    [Description("25GBASE-BR10-D")]
    Base25G_BR10_D = 201,

    [Description("25GBASE-BR10-U")]
    Base25G_BR10_U = 202,

    [Description("25GBASE-BR20-D")]
    Base25G_BR20_D = 203,

    [Description("25GBASE-BR20-U")]
    Base25G_BR20_U = 204,

    [Description("25GBASE-BR40-D")]
    Base25G_BR40_D = 205,

    [Description("25GBASE-BR40-U")]
    Base25G_BR40_U = 206,

    [Description("50GBASE-BR10-D")]
    Base50G_BR10_D = 207,

    [Description("50GBASE-BR10-U")]
    Base50G_BR10_U = 208,

    [Description("50GBASE-BR20-D")]
    Base50G_BR20_D = 209,

    [Description("50GBASE-BR20-U")]
    Base50G_BR20_U = 210,

    [Description("50GBASE-BR40-D")]
    Base50G_BR40_D = 211,

    [Description("50GBASE-BR40-U")]
    Base50G_BR40_U = 212,

    [Description("2.5GBASE-AU")]
    Base2_5G_AU = 213,

    [Description("5GBASE-AU")]
    Base5G_AU = 214,

    [Description("10GBASE-AU")]
    Base10G_AU = 215,

    [Description("25GBASE-AU")]
    Base25G_AU = 216,

    [Description("50GBASE-AU")]
    Base50G_AU = 217,

    [Description("25GBASE-T1")]
    Base25G_T1 = 218,

    [Description("400GBASE-DR4-2")]
    Base400G_DR4_2 = 219,

    [Description("800GBASE-CR8")]
    Base800_CR8 = 220,

    [Description("800GBASE-DR8")]
    Base800_DR8 = 221,

    [Description("800GBASE-DR8-2")]
    Base800_DR8_2 = 222,

    [Description("800GBASE-KR8")]
    Base800_KR8 = 223,

    [Description("800GBASE-R")]
    Base800_R = 224,

    [Description("800GBASE-SR8")]
    Base800_SR8 = 225,

    [Description("800GBASE-VR8")]
    Base800_VR8 = 226,
}
