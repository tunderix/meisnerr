// Shader created with Shader Forge v1.30 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.30;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:0,dpts:2,wrdp:False,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:True,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:True,fnfb:True;n:type:ShaderForge.SFN_Final,id:4795,x:32887,y:32809,varname:node_4795,prsc:2|emission-4189-OUT;n:type:ShaderForge.SFN_Tex2d,id:5922,x:31553,y:32138,ptovrint:False,ptlb:node_5922,ptin:_node_5922,varname:node_5922,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:7aace65e887f93a46bcc9760aa4bba23,ntxv:0,isnm:False|UVIN-6122-UVOUT;n:type:ShaderForge.SFN_Tex2d,id:2109,x:31570,y:32545,ptovrint:False,ptlb:node_2109,ptin:_node_2109,varname:node_2109,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:9bd3a41b8a9a3ab4bb35a367eb7afd17,ntxv:0,isnm:False|UVIN-4233-UVOUT;n:type:ShaderForge.SFN_Tex2d,id:4791,x:31565,y:32842,ptovrint:False,ptlb:node_4791,ptin:_node_4791,varname:node_4791,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:1e26324403491354aae490c62e9fbaae,ntxv:0,isnm:False|UVIN-6829-UVOUT;n:type:ShaderForge.SFN_Rotator,id:6122,x:30713,y:32618,varname:node_6122,prsc:2|UVIN-2521-UVOUT,SPD-729-OUT;n:type:ShaderForge.SFN_TexCoord,id:2521,x:30455,y:32615,varname:node_2521,prsc:2,uv:0;n:type:ShaderForge.SFN_Slider,id:729,x:30298,y:32790,ptovrint:False,ptlb:RotationSpeed 1,ptin:_RotationSpeed1,varname:node_729,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-1,cur:0.05,max:1;n:type:ShaderForge.SFN_Rotator,id:4233,x:30714,y:32797,varname:node_4233,prsc:2|UVIN-2521-UVOUT,SPD-9231-OUT;n:type:ShaderForge.SFN_Slider,id:9231,x:30299,y:32969,ptovrint:False,ptlb:RotationSpeed 2,ptin:_RotationSpeed2,varname:_RotationSpeed_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-1,cur:-0.03,max:1;n:type:ShaderForge.SFN_Rotator,id:6829,x:30714,y:32993,varname:node_6829,prsc:2|UVIN-2521-UVOUT,SPD-7182-OUT;n:type:ShaderForge.SFN_Slider,id:7182,x:30299,y:33165,ptovrint:False,ptlb:RotationSpeed 3,ptin:_RotationSpeed3,varname:_RotationSpeed_copy_copy,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-1,cur:0.07,max:1;n:type:ShaderForge.SFN_Lerp,id:1010,x:32113,y:32472,varname:node_1010,prsc:2|A-6757-OUT,B-6643-OUT,T-2109-RGB;n:type:ShaderForge.SFN_Lerp,id:9365,x:32324,y:32790,varname:node_9365,prsc:2|A-1010-OUT,B-3605-OUT,T-4791-RGB;n:type:ShaderForge.SFN_Multiply,id:6757,x:31860,y:32291,varname:node_6757,prsc:2|A-5922-RGB,B-538-OUT;n:type:ShaderForge.SFN_Slider,id:538,x:31343,y:32421,ptovrint:False,ptlb:Multiplier 1,ptin:_Multiplier1,varname:node_538,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:1;n:type:ShaderForge.SFN_Multiply,id:6643,x:31912,y:32557,varname:node_6643,prsc:2|A-2109-RGB,B-8437-OUT;n:type:ShaderForge.SFN_Slider,id:8437,x:31554,y:32756,ptovrint:False,ptlb:Multiplier 2,ptin:_Multiplier2,varname:_Multiplier2,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:1;n:type:ShaderForge.SFN_Multiply,id:3605,x:32132,y:32810,varname:node_3605,prsc:2|A-4791-RGB,B-558-OUT;n:type:ShaderForge.SFN_Slider,id:558,x:31744,y:32986,ptovrint:False,ptlb:Multiplier 3,ptin:_Multiplier3,varname:_Multiplier3,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:1;n:type:ShaderForge.SFN_Multiply,id:4189,x:32505,y:32910,varname:node_4189,prsc:2|A-9365-OUT,B-8858-OUT,C-1695-RGB,D-5910-RGB;n:type:ShaderForge.SFN_Slider,id:8858,x:32167,y:33093,ptovrint:False,ptlb:Multiplier 4,ptin:_Multiplier4,varname:_Multiplier4,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1.665797,max:3;n:type:ShaderForge.SFN_Color,id:1695,x:32324,y:33206,ptovrint:False,ptlb:node_1695,ptin:_node_1695,varname:node_1695,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.5,c2:0.5,c3:0.5,c4:1;n:type:ShaderForge.SFN_VertexColor,id:5910,x:32324,y:32934,varname:node_5910,prsc:2;proporder:5922-2109-4791-729-9231-7182-538-8437-558-8858-1695;pass:END;sub:END;*/

Shader "Shader Forge/sdr_Smoke" {
    Properties {
        _node_5922 ("node_5922", 2D) = "white" {}
        _node_2109 ("node_2109", 2D) = "white" {}
        _node_4791 ("node_4791", 2D) = "white" {}
        _RotationSpeed1 ("RotationSpeed 1", Range(-1, 1)) = 0.05
        _RotationSpeed2 ("RotationSpeed 2", Range(-1, 1)) = -0.03
        _RotationSpeed3 ("RotationSpeed 3", Range(-1, 1)) = 0.07
        _Multiplier1 ("Multiplier 1", Range(0, 1)) = 1
        _Multiplier2 ("Multiplier 2", Range(0, 1)) = 1
        _Multiplier3 ("Multiplier 3", Range(0, 1)) = 1
        _Multiplier4 ("Multiplier 4", Range(0, 3)) = 1.665797
        _node_1695 ("node_1695", Color) = (0.5,0.5,0.5,1)
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
            #pragma multi_compile_fwdbase
            #pragma multi_compile_fog
            #pragma target 3.0
            uniform float4 _TimeEditor;
            uniform sampler2D _node_5922; uniform float4 _node_5922_ST;
            uniform sampler2D _node_2109; uniform float4 _node_2109_ST;
            uniform sampler2D _node_4791; uniform float4 _node_4791_ST;
            uniform float _RotationSpeed1;
            uniform float _RotationSpeed2;
            uniform float _RotationSpeed3;
            uniform float _Multiplier1;
            uniform float _Multiplier2;
            uniform float _Multiplier3;
            uniform float _Multiplier4;
            uniform float4 _node_1695;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
                float4 vertexColor : COLOR;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float4 vertexColor : COLOR;
                UNITY_FOG_COORDS(1)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.vertexColor = v.vertexColor;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
////// Lighting:
////// Emissive:
                float4 node_3550 = _Time + _TimeEditor;
                float node_6122_ang = node_3550.g;
                float node_6122_spd = _RotationSpeed1;
                float node_6122_cos = cos(node_6122_spd*node_6122_ang);
                float node_6122_sin = sin(node_6122_spd*node_6122_ang);
                float2 node_6122_piv = float2(0.5,0.5);
                float2 node_6122 = (mul(i.uv0-node_6122_piv,float2x2( node_6122_cos, -node_6122_sin, node_6122_sin, node_6122_cos))+node_6122_piv);
                float4 _node_5922_var = tex2D(_node_5922,TRANSFORM_TEX(node_6122, _node_5922));
                float node_4233_ang = node_3550.g;
                float node_4233_spd = _RotationSpeed2;
                float node_4233_cos = cos(node_4233_spd*node_4233_ang);
                float node_4233_sin = sin(node_4233_spd*node_4233_ang);
                float2 node_4233_piv = float2(0.5,0.5);
                float2 node_4233 = (mul(i.uv0-node_4233_piv,float2x2( node_4233_cos, -node_4233_sin, node_4233_sin, node_4233_cos))+node_4233_piv);
                float4 _node_2109_var = tex2D(_node_2109,TRANSFORM_TEX(node_4233, _node_2109));
                float node_6829_ang = node_3550.g;
                float node_6829_spd = _RotationSpeed3;
                float node_6829_cos = cos(node_6829_spd*node_6829_ang);
                float node_6829_sin = sin(node_6829_spd*node_6829_ang);
                float2 node_6829_piv = float2(0.5,0.5);
                float2 node_6829 = (mul(i.uv0-node_6829_piv,float2x2( node_6829_cos, -node_6829_sin, node_6829_sin, node_6829_cos))+node_6829_piv);
                float4 _node_4791_var = tex2D(_node_4791,TRANSFORM_TEX(node_6829, _node_4791));
                float3 emissive = (lerp(lerp((_node_5922_var.rgb*_Multiplier1),(_node_2109_var.rgb*_Multiplier2),_node_2109_var.rgb),(_node_4791_var.rgb*_Multiplier3),_node_4791_var.rgb)*_Multiplier4*_node_1695.rgb*i.vertexColor.rgb);
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
