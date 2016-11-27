// Shader created with Shader Forge v1.30 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.30;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,lico:1,lgpr:1,limd:0,spmd:1,trmd:0,grmd:0,uamb:True,mssp:True,bkdf:False,hqlp:False,rprd:False,enco:False,rmgx:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:0,bdst:1,dpts:2,wrdp:True,dith:0,rfrpo:True,rfrpn:Refraction,coma:15,ufog:False,aust:True,igpj:False,qofs:0,qpre:2,rntp:3,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False;n:type:ShaderForge.SFN_Final,id:3138,x:32719,y:32712,varname:node_3138,prsc:2|emission-1702-RGB,clip-5336-OUT;n:type:ShaderForge.SFN_Color,id:7241,x:31674,y:32314,ptovrint:False,ptlb:Color,ptin:_Color,varname:node_7241,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.07843138,c2:0.3921569,c3:0.7843137,c4:1;n:type:ShaderForge.SFN_Tex2d,id:888,x:31788,y:32974,ptovrint:False,ptlb:node_888,ptin:_node_888,varname:node_888,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:8ec1786a4792f304c818ce96e75e27e9,ntxv:0,isnm:False|UVIN-9871-OUT;n:type:ShaderForge.SFN_Tex2d,id:9766,x:31788,y:33201,ptovrint:False,ptlb:node_9766,ptin:_node_9766,varname:node_9766,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:ac2f78ac8544d1045ae369ea39cd8cd7,ntxv:0,isnm:False|UVIN-6574-OUT;n:type:ShaderForge.SFN_TexCoord,id:199,x:30636,y:32969,varname:node_199,prsc:2,uv:0;n:type:ShaderForge.SFN_Rotator,id:3226,x:31295,y:32992,varname:node_3226,prsc:2|UVIN-1436-UVOUT,SPD-374-OUT;n:type:ShaderForge.SFN_Rotator,id:6838,x:31295,y:33246,varname:node_6838,prsc:2|UVIN-6365-UVOUT,SPD-8289-OUT;n:type:ShaderForge.SFN_UVTile,id:1436,x:30993,y:32993,varname:node_1436,prsc:2|UVIN-199-UVOUT,WDT-4665-OUT,HGT-4665-OUT,TILE-2559-OUT;n:type:ShaderForge.SFN_UVTile,id:6365,x:30993,y:33249,varname:node_6365,prsc:2|UVIN-199-UVOUT,WDT-5132-OUT,HGT-5132-OUT,TILE-2559-OUT;n:type:ShaderForge.SFN_Slider,id:8289,x:30836,y:33404,ptovrint:False,ptlb:node_8289,ptin:_node_8289,varname:node_8289,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:-1,cur:-0.4088489,max:1;n:type:ShaderForge.SFN_Slider,id:374,x:30947,y:33143,ptovrint:False,ptlb:node_374,ptin:_node_374,varname:node_374,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.501614,max:1;n:type:ShaderForge.SFN_Slider,id:4665,x:30455,y:33169,ptovrint:False,ptlb:node_4665,ptin:_node_4665,varname:node_4665,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:1;n:type:ShaderForge.SFN_Slider,id:5132,x:30455,y:33369,ptovrint:False,ptlb:node_5132,ptin:_node_5132,varname:node_5132,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:1;n:type:ShaderForge.SFN_Vector1,id:2559,x:30534,y:33278,varname:node_2559,prsc:2,v1:0;n:type:ShaderForge.SFN_Multiply,id:9871,x:31562,y:32908,varname:node_9871,prsc:2|A-5259-OUT,B-3226-UVOUT;n:type:ShaderForge.SFN_Slider,id:5259,x:31234,y:32784,ptovrint:False,ptlb:node_5259,ptin:_node_5259,varname:node_5259,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1.042289,max:2;n:type:ShaderForge.SFN_Multiply,id:6574,x:31530,y:33292,varname:node_6574,prsc:2|A-6838-UVOUT,B-1553-OUT;n:type:ShaderForge.SFN_Slider,id:1553,x:31150,y:33537,ptovrint:False,ptlb:node_1553,ptin:_node_1553,varname:node_1553,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1.112566,max:2;n:type:ShaderForge.SFN_Slider,id:9437,x:32001,y:32518,ptovrint:False,ptlb:node_9437,ptin:_node_9437,varname:node_9437,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1.765972,max:3;n:type:ShaderForge.SFN_Color,id:1702,x:32049,y:32699,ptovrint:False,ptlb:node_1702,ptin:_node_1702,varname:node_1702,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.1785251,c2:0.3400026,c3:0.9338235,c4:1;n:type:ShaderForge.SFN_Add,id:5336,x:32251,y:33108,varname:node_5336,prsc:2|A-888-A,B-9766-A;proporder:7241-888-9766-8289-374-4665-5132-5259-1553-9437-1702;pass:END;sub:END;*/

Shader "Shader Forge/sdr_WaterBucket" {
    Properties {
        _Color ("Color", Color) = (0.07843138,0.3921569,0.7843137,1)
        _node_888 ("node_888", 2D) = "white" {}
        _node_9766 ("node_9766", 2D) = "white" {}
        _node_8289 ("node_8289", Range(-1, 1)) = -0.4088489
        _node_374 ("node_374", Range(0, 1)) = 0.501614
        _node_4665 ("node_4665", Range(0, 1)) = 1
        _node_5132 ("node_5132", Range(0, 1)) = 1
        _node_5259 ("node_5259", Range(0, 2)) = 1.042289
        _node_1553 ("node_1553", Range(0, 2)) = 1.112566
        _node_9437 ("node_9437", Range(0, 3)) = 1.765972
        _node_1702 ("node_1702", Color) = (0.1785251,0.3400026,0.9338235,1)
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "Queue"="AlphaTest"
            "RenderType"="TransparentCutout"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #include "UnityCG.cginc"
            #pragma multi_compile_fwdbase_fullshadows
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform float4 _TimeEditor;
            uniform sampler2D _node_888; uniform float4 _node_888_ST;
            uniform sampler2D _node_9766; uniform float4 _node_9766_ST;
            uniform float _node_8289;
            uniform float _node_374;
            uniform float _node_4665;
            uniform float _node_5132;
            uniform float _node_5259;
            uniform float _node_1553;
            uniform float4 _node_1702;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                float4 node_1008 = _Time + _TimeEditor;
                float node_3226_ang = node_1008.g;
                float node_3226_spd = _node_374;
                float node_3226_cos = cos(node_3226_spd*node_3226_ang);
                float node_3226_sin = sin(node_3226_spd*node_3226_ang);
                float2 node_3226_piv = float2(0.5,0.5);
                float node_2559 = 0.0;
                float2 node_1436_tc_rcp = float2(1.0,1.0)/float2( _node_4665, _node_4665 );
                float node_1436_ty = floor(node_2559 * node_1436_tc_rcp.x);
                float node_1436_tx = node_2559 - _node_4665 * node_1436_ty;
                float2 node_1436 = (i.uv0 + float2(node_1436_tx, node_1436_ty)) * node_1436_tc_rcp;
                float2 node_3226 = (mul(node_1436-node_3226_piv,float2x2( node_3226_cos, -node_3226_sin, node_3226_sin, node_3226_cos))+node_3226_piv);
                float2 node_9871 = (_node_5259*node_3226);
                float4 _node_888_var = tex2D(_node_888,TRANSFORM_TEX(node_9871, _node_888));
                float node_6838_ang = node_1008.g;
                float node_6838_spd = _node_8289;
                float node_6838_cos = cos(node_6838_spd*node_6838_ang);
                float node_6838_sin = sin(node_6838_spd*node_6838_ang);
                float2 node_6838_piv = float2(0.5,0.5);
                float2 node_6365_tc_rcp = float2(1.0,1.0)/float2( _node_5132, _node_5132 );
                float node_6365_ty = floor(node_2559 * node_6365_tc_rcp.x);
                float node_6365_tx = node_2559 - _node_5132 * node_6365_ty;
                float2 node_6365 = (i.uv0 + float2(node_6365_tx, node_6365_ty)) * node_6365_tc_rcp;
                float2 node_6838 = (mul(node_6365-node_6838_piv,float2x2( node_6838_cos, -node_6838_sin, node_6838_sin, node_6838_cos))+node_6838_piv);
                float2 node_6574 = (node_6838*_node_1553);
                float4 _node_9766_var = tex2D(_node_9766,TRANSFORM_TEX(node_6574, _node_9766));
                clip((_node_888_var.a+_node_9766_var.a) - 0.5);
////// Lighting:
////// Emissive:
                float3 emissive = _node_1702.rgb;
                float3 finalColor = emissive;
                return fixed4(finalColor,1);
            }
            ENDCG
        }
        Pass {
            Name "ShadowCaster"
            Tags {
                "LightMode"="ShadowCaster"
            }
            Offset 1, 1
            
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #define UNITY_PASS_SHADOWCASTER
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma exclude_renderers gles3 metal d3d11_9x xbox360 xboxone ps3 ps4 psp2 
            #pragma target 3.0
            uniform float4 _TimeEditor;
            uniform sampler2D _node_888; uniform float4 _node_888_ST;
            uniform sampler2D _node_9766; uniform float4 _node_9766_ST;
            uniform float _node_8289;
            uniform float _node_374;
            uniform float _node_4665;
            uniform float _node_5132;
            uniform float _node_5259;
            uniform float _node_1553;
            struct VertexInput {
                float4 vertex : POSITION;
                float2 texcoord0 : TEXCOORD0;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
                float2 uv0 : TEXCOORD1;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.pos = mul(UNITY_MATRIX_MVP, v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            float4 frag(VertexOutput i) : COLOR {
                float4 node_8229 = _Time + _TimeEditor;
                float node_3226_ang = node_8229.g;
                float node_3226_spd = _node_374;
                float node_3226_cos = cos(node_3226_spd*node_3226_ang);
                float node_3226_sin = sin(node_3226_spd*node_3226_ang);
                float2 node_3226_piv = float2(0.5,0.5);
                float node_2559 = 0.0;
                float2 node_1436_tc_rcp = float2(1.0,1.0)/float2( _node_4665, _node_4665 );
                float node_1436_ty = floor(node_2559 * node_1436_tc_rcp.x);
                float node_1436_tx = node_2559 - _node_4665 * node_1436_ty;
                float2 node_1436 = (i.uv0 + float2(node_1436_tx, node_1436_ty)) * node_1436_tc_rcp;
                float2 node_3226 = (mul(node_1436-node_3226_piv,float2x2( node_3226_cos, -node_3226_sin, node_3226_sin, node_3226_cos))+node_3226_piv);
                float2 node_9871 = (_node_5259*node_3226);
                float4 _node_888_var = tex2D(_node_888,TRANSFORM_TEX(node_9871, _node_888));
                float node_6838_ang = node_8229.g;
                float node_6838_spd = _node_8289;
                float node_6838_cos = cos(node_6838_spd*node_6838_ang);
                float node_6838_sin = sin(node_6838_spd*node_6838_ang);
                float2 node_6838_piv = float2(0.5,0.5);
                float2 node_6365_tc_rcp = float2(1.0,1.0)/float2( _node_5132, _node_5132 );
                float node_6365_ty = floor(node_2559 * node_6365_tc_rcp.x);
                float node_6365_tx = node_2559 - _node_5132 * node_6365_ty;
                float2 node_6365 = (i.uv0 + float2(node_6365_tx, node_6365_ty)) * node_6365_tc_rcp;
                float2 node_6838 = (mul(node_6365-node_6838_piv,float2x2( node_6838_cos, -node_6838_sin, node_6838_sin, node_6838_cos))+node_6838_piv);
                float2 node_6574 = (node_6838*_node_1553);
                float4 _node_9766_var = tex2D(_node_9766,TRANSFORM_TEX(node_6574, _node_9766));
                clip((_node_888_var.a+_node_9766_var.a) - 0.5);
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
