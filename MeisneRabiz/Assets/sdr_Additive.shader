// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'

// Shader created with Shader Forge v1.30 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.30;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:3,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:0,dpts:2,wrdp:False,dith:0,rfrpo:False,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:True,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:True,fnfb:True;n:type:ShaderForge.SFN_Final,id:4795,x:33151,y:32651,varname:node_4795,prsc:2|emission-1925-OUT;n:type:ShaderForge.SFN_TexCoord,id:1580,x:31729,y:32651,varname:node_1580,prsc:2,uv:0;n:type:ShaderForge.SFN_UVTile,id:1604,x:31951,y:32420,varname:node_1604,prsc:2|UVIN-1580-UVOUT,WDT-6661-OUT,HGT-5058-OUT,TILE-2751-OUT;n:type:ShaderForge.SFN_Slider,id:6661,x:31572,y:32822,ptovrint:False,ptlb:UV width,ptin:_UVwidth,varname:node_6661,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:10;n:type:ShaderForge.SFN_Slider,id:5058,x:31572,y:32923,ptovrint:False,ptlb:UV height,ptin:_UVheight,varname:node_5058,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:10;n:type:ShaderForge.SFN_Slider,id:2751,x:31572,y:33020,ptovrint:False,ptlb:Tile,ptin:_Tile,varname:node_2751,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:10;n:type:ShaderForge.SFN_Tex2d,id:377,x:32523,y:32843,varname:node_377,prsc:2,tex:f74a619042351524da66574ed1b15c23,ntxv:0,isnm:False|UVIN-7505-UVOUT,TEX-3272-TEX;n:type:ShaderForge.SFN_Tex2dAsset,id:1030,x:32030,y:32925,ptovrint:False,ptlb:node_1030,ptin:_node_1030,varname:node_1030,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:6b71b6422a0120641bb73c9fbd954b06,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2dAsset,id:3272,x:32094,y:33127,ptovrint:False,ptlb:node_3272,ptin:_node_3272,varname:node_3272,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:f74a619042351524da66574ed1b15c23,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2dAsset,id:3498,x:32041,y:33407,ptovrint:False,ptlb:node_3498,ptin:_node_3498,varname:node_3498,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:a5dd96e4bafe3f443b7c1143e34b3f4b,ntxv:0,isnm:False;n:type:ShaderForge.SFN_Tex2d,id:5541,x:32435,y:33119,varname:node_5541,prsc:2,tex:f74a619042351524da66574ed1b15c23,ntxv:0,isnm:False|UVIN-7066-UVOUT,TEX-3272-TEX;n:type:ShaderForge.SFN_Tex2d,id:5157,x:32230,y:33311,varname:node_5157,prsc:2,tex:a5dd96e4bafe3f443b7c1143e34b3f4b,ntxv:0,isnm:False|UVIN-741-UVOUT,TEX-3498-TEX;n:type:ShaderForge.SFN_Panner,id:7505,x:32162,y:32384,varname:node_7505,prsc:2,spu:1,spv:0|UVIN-1604-UVOUT;n:type:ShaderForge.SFN_Panner,id:7066,x:32162,y:32590,varname:node_7066,prsc:2,spu:-1,spv:0|UVIN-1604-UVOUT;n:type:ShaderForge.SFN_Panner,id:741,x:32162,y:32763,varname:node_741,prsc:2,spu:0.5,spv:0|UVIN-1604-UVOUT;n:type:ShaderForge.SFN_Lerp,id:5346,x:32733,y:33083,varname:node_5346,prsc:2|A-377-RGB,B-5541-RGB,T-5541-RGB;n:type:ShaderForge.SFN_Lerp,id:8448,x:32909,y:33083,varname:node_8448,prsc:2|A-5346-OUT,B-5157-RGB,T-5157-RGB;n:type:ShaderForge.SFN_Color,id:4519,x:32720,y:32530,ptovrint:False,ptlb:node_4519,ptin:_node_4519,varname:node_4519,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:1,c2:0,c3:0,c4:1;n:type:ShaderForge.SFN_Multiply,id:1925,x:32919,y:32701,varname:node_1925,prsc:2|A-76-OUT,B-4519-RGB,C-8448-OUT;n:type:ShaderForge.SFN_Slider,id:76,x:32545,y:32699,ptovrint:False,ptlb:Multiplier,ptin:_Multiplier,varname:node_76,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.7179487,max:3;n:type:ShaderForge.SFN_Slider,id:6714,x:32005,y:32233,ptovrint:False,ptlb:node_6714,ptin:_node_6714,varname:node_6714,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-10,cur:2.187354,max:10;proporder:6661-5058-2751-1030-3272-3498-4519-76;pass:END;sub:END;*/

Shader "Shader Forge/sdr_Additive" {
    Properties {
        _UVwidth ("UV width", Range(0, 10)) = 1
        _UVheight ("UV height", Range(0, 10)) = 1
        _Tile ("Tile", Range(0, 10)) = 1
        _node_1030 ("node_1030", 2D) = "white" {}
        _node_3272 ("node_3272", 2D) = "white" {}
        _node_3498 ("node_3498", 2D) = "white" {}
        _node_4519 ("node_4519", Color) = (1,0,0,1)
        _Multiplier ("Multiplier", Range(0, 3)) = 0.7179487
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend One One
            ZWrite Off
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdbase
            #pragma multi_compile_fog
            #pragma target 3.0
            uniform float4 _TimeEditor;
            uniform float _UVwidth;
            uniform float _UVheight;
            uniform float _Tile;
            uniform sampler2D _node_3272; uniform float4 _node_3272_ST;
            uniform sampler2D _node_3498; uniform float4 _node_3498_ST;
            uniform float4 _node_4519;
            uniform float _Multiplier;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 posWorld : TEXCOORD1;
                float3 normalDir : TEXCOORD2;
                UNITY_FOG_COORDS(3)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
////// Lighting:
////// Emissive:
                float4 node_2975 = _Time + _TimeEditor;
                float2 node_1604_tc_rcp = float2(1.0,1.0)/float2( _UVwidth, _UVheight );
                float node_1604_ty = floor(_Tile * node_1604_tc_rcp.x);
                float node_1604_tx = _Tile - _UVwidth * node_1604_ty;
                float2 node_1604 = (i.uv0 + float2(node_1604_tx, node_1604_ty)) * node_1604_tc_rcp;
                float2 node_7505 = (node_1604+node_2975.g*float2(1,0));
                float4 node_377 = tex2D(_node_3272,TRANSFORM_TEX(node_7505, _node_3272));
                float2 node_7066 = (node_1604+node_2975.g*float2(-1,0));
                float4 node_5541 = tex2D(_node_3272,TRANSFORM_TEX(node_7066, _node_3272));
                float2 node_741 = (node_1604+node_2975.g*float2(0.5,0));
                float4 node_5157 = tex2D(_node_3498,TRANSFORM_TEX(node_741, _node_3498));
                float3 emissive = (_Multiplier*_node_4519.rgb*lerp(lerp(node_377.rgb,node_5541.rgb,node_5541.rgb),node_5157.rgb,node_5157.rgb));
                float3 finalColor = emissive;
                fixed4 finalRGBA = fixed4(finalColor,1);
                UNITY_APPLY_FOG_COLOR(i.fogCoord, finalRGBA, fixed4(0.5,0.5,0.5,1));
                return finalRGBA;
            }
            ENDCG
        }
    }
    CustomEditor "ShaderForgeMaterialInspector"
}
