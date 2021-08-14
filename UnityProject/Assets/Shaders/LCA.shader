Shader "Custom/LCACorrection"
{
    //Adapted from tutorial: http://www.shaderslab.com/demo-78---chromatic-aberration.html
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}

        //Inspector UI
        [Header(LCA Correction)]
        [Header(Red Offset)]
        _RedX ("X", Range(-0.5, 0.5)) = 0.0
        _RedY ("Y", Range(-0.5, 0.5)) = 0.0
 
        [Header(Green Offset)]
        _GreenX ("X", Range(-0.5, 0.5)) = 0.0
        _GreenY ("Y", Range(-0.5, 0.5)) = 0.0
 
        [Header(Blue Offset)]
        _BlueX ("X", Range(-0.5, 0.5)) = 0.0
        _BlueY ("Y", Range(-0.5, 0.5)) = 0.0
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        
        Pass
        {
            
            CGPROGRAM

            #pragma vertex vert
            #pragma fragment frag
           
            #include "UnityCG.cginc"

            //Vertex shader set up
            struct appdata
			{
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct v2f
			{
				float2 uv : TEXCOORD0;
				float4 vertex : SV_POSITION;
			};

            //Standard vertex shader
			v2f vert (appdata v)
			{
				v2f o;
				o.vertex = UnityObjectToClipPos(v.vertex);
				o.uv = v.uv;
				return o;
			}
 
            sampler2D _MainTex;

            //Define 6 properties for offset; these are modified dynamically through slider UI scripts 
            float _RedX;
            float _RedY;
            float _GreenX;
            float _GreenY;
            float _BlueX;
            float _BlueY;
           
            //LCA performed in the fragment shader
            fixed4 frag (v2f_img i) : SV_Target
            {
                fixed4 color = fixed4(1, 1, 1, 1);

                //Compute offset in X and Y direction
                float2 red_uv = i.uv + float2(_RedX, _RedY);
                float2 green_uv = i.uv + float2(_GreenX, _GreenY);
                float2 blue_uv = i.uv + float2(_BlueX, _BlueY);
 

                //Update offset per channel -- ignoring alpha 
                //Red 
                color.r = tex2D(_MainTex, red_uv).r;
                //Green 
                color.g = tex2D(_MainTex, green_uv).g;
                //Blue
                color.b = tex2D(_MainTex, blue_uv).b;
 
                return color;
            }
            ENDCG
        }
    }
}
