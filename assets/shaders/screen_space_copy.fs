#version 330 core
out vec4 FragColor;

in vec2 TexCoords;

uniform sampler2D image;

void main()
{             
    FragColor = texture(image, TexCoords);
    //FragColor = vec4(1.0,1.0,1.0,1.0);
}