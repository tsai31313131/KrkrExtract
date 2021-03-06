# CS_ARCH_X86, CS_MODE_64, CS_OPT_SYNTAX_ATT
0x62,0xa3,0x55,0x48,0x38,0xcd,0x01 = vinserti32x4 $1, %xmm21, %zmm5, %zmm17
0x62,0xe3,0x1d,0x40,0x38,0x4f,0x10,0x01 = vinserti32x4 $1, 256(%rdi), %zmm28, %zmm17
0x62,0x33,0x7d,0x48,0x39,0xc9,0x01 = vextracti32x4 $1, %zmm9, %xmm17
0x62,0x33,0xfd,0x48,0x3b,0xc9,0x01 = vextracti64x4 $1, %zmm9, %ymm17
0x62,0x73,0xfd,0x48,0x3b,0x4f,0x10,0x01 = vextracti64x4 $1, %zmm9, 512(%rdi)
0x62,0xb1,0x35,0x40,0x72,0xe1,0x02 = vpsrad $2, %zmm17, %zmm25
0x62,0xf1,0x35,0x40,0x72,0x64,0xb7,0x08,0x02 = vpsrad $2, 512(%rdi, %rsi, 4), %zmm25
0x62,0x21,0x1d,0x48,0xe2,0xc9 = vpsrad %xmm17, %zmm12, %zmm25
0x62,0x61,0x1d,0x48,0xe2,0x4c,0xb7,0x20 = vpsrad 512(%rdi, %rsi, 4), %zmm12, %zmm25
0x62,0xf2,0x7d,0xc9,0x58,0xc8 = vpbroadcastd %xmm0, %zmm1 {%k1} {z}
0x62,0xf1,0xfe,0x4b,0x6f,0xc8 = vmovdqu64 %zmm0, %zmm1 {%k3}
