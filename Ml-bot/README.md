# MLBot Application

This is a simple PyQt-based ChatBot application that interacts with the OpenAI GPT-3.5 Turbo model to provide answers to user questions. The application allows users to ask questions, submit them to the OpenAI API, and display the model's response.

## Features

- Ask custom questions and receive answers about Machine Learning from OpenAI's GPT-3.5 Turbo model.
- Choose from popular predefined questions for quick responses.
- A user-friendly graphical interface using PyQt.

## Getting Started

Follow the steps below to set up and run the ChatBot application:

### Prerequisites

- Python 3.x installed on your machine.
- PyQt5 library installed. Install it using the following command:

  ```
  pip install PyQt5
  ```

- OpenAI account with API key. Get your API key from [OpenAI](https://beta.openai.com/signup/) and replace `Constants.API_KEY` in the `Constants.py` file with your key.
- Here I haven't uploaded Constants.py due to restriction that I can public key. You can configure by your own

### Running the Application

1. Clone the repository:

   ```bash
   git clone https://github.com/joha546/Ml-bot.git
   ```

2. Navigate to the project directory:

   ```bash
   cd MlBot
   ```

3. Run the application:

   ```bash
   python main.py
   ```

4. The ChatBot window will appear, allowing you to interact with the model.

## Usage

- Enter your custom question in the "Ask Your Question Here" field and click the "Submit" button.
- Alternatively, click on one of the popular predefined questions to quickly get answers.

## Troubleshooting

- If you encounter any issues, ensure that your OpenAI API key is correctly configured in the `Constants.py` file.
- Check your OpenAI account for API usage quotas and billing information.

## Acknowledgments

- This application uses the OpenAI GPT-3.5 Turbo model. For more information, visit [OpenAI](https://beta.openai.com/).

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
```
