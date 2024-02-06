#version 330 core
out vec4 FragColor;
// in vec3 ourColor;
in vec3 ourPosition;
uniform vec3 iResolution;
uniform float iTime;


void main()
{
    
    vec2 d = fract(ourPosition.xy * 4.0) - 0.5; 
     float df = length(d);

        vec3 a = vec3(0.5, 0.5, 0.5);
    vec3 b = vec3(0.5, 0.5, 0.5);
    vec3 c = vec3(1.0, 1.0, 1.0);
    vec3 dx = vec3(0.263, 0.416, 0.557);
    
    vec3 color = a + b * cos(6.28318 *(c*(df+iTime)+dx));


    df = sin(df * 20 + iTime)/20;
    df = abs(df);
    df = 0.02 /df;
    color*= df;
    FragColor = vec4(color , 1.0);    // note how the position value is linearly interpolated to get all the different colors
}

