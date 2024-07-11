import streamlit as st
#import io
#from io import BytesIO
from PIL import Image

def display_support():
    st.markdown("<div style='text-align: center;'>Share and Support</div>", unsafe_allow_html=True)
    
    st.write("""
        <div style="display: flex; flex-direction: column; align-items: center; justify-content: center;">
            <ul style="list-style-type: none; margin: 0; padding: 0; display: flex;">
                <li style="margin-right: 10px;"><a href="https://www.linkedin.com/in/mdkhaledbinjoha/" target="_blank"><img src="https://img.icons8.com/color/48/000000/linkedin.png"/></a></li>
                <li><a href="https://github.com/joha546" target="_blank"><img src="https://img.icons8.com/color/32/000000/github--v1.png"/></a></li>
            </ul>
        </div>
    """, unsafe_allow_html=True)
def streamlit_app():    
    
    # Google Logo and Title
    st.write('<div style="display: flex; flex-direction: row; align-items: center; justify-content: center;"><a style="margin-right: 10px;" href="https://www.google.com" target="_blank"><img src="https://img.icons8.com/color/32/000000/google-logo.png"/></a><h1 style="margin-left: 10px;">Google - Gemini Vision Pro</h1></div>', unsafe_allow_html=True)
    
    # Display support
    display_support()

if __name__ == "__main__":
    streamlit_app()
