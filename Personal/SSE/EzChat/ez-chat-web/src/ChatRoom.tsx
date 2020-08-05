import React from "react";
import "./style.css";
import { Link } from "react-router-dom";

class ChatRoom extends React.Component<{}, any> {
  connector: EventSource;
  api: string;
  constructor(props: any) {
    super(props);

    this.api = "http://localhost:6172/ezchat"
    this.connector = new EventSource(this.api + "/connect");
    this.state = {
      name: "",
      text: "",
      color: `hsl(${Math.random() * 360}, 100%, 75%)`,
      data: {
        general: [{name: "Server", color: "#F00", message: "Welcome to EzChat!"}],
      },
    };
  }

  componentDidMount = () => {
    this.connector.onerror = () => this.updateData({name: "Server", color: "#F00", message: "Couldn't connect to server!"});
    this.connector.onmessage = (e: any) => this.updateData(JSON.parse(e.data));
  };

  usernamePrompt = () => {
    const [username, setUsername] = React.useState("");
    const [legal, setLegal] = React.useState(false);
    const [clicked, setClicked] = React.useState(false);
    return (
      <div className="usernamePrompt-wrapper">
        <div className="usernamePrompt">
          <h1 className="title">Ez Chat</h1>
          {!username && clicked && (
            <p className="usernamePromptError">Please fill in a username!</p>
          )}
          <label htmlFor="username">Username:</label>
          <input
            type="text"
            name="username"
            placeholder="My Cool Name"
            onChange={(event) => setUsername(event.target.value.trim())}
          />
          {!legal && clicked && (
            <p className="usernamePromptError">
              You have to agree with our ToS!
            </p>
          )}
          <input
            type="checkbox"
            name="legal"
            onChange={(event) => setLegal(event.target.checked)}
          />
          <label htmlFor="legal">
            I agree that EzChat is not responsible for anything that happens in
            the chatroom's and I confirm that I'm above the age of 13!
          </label>
          <div className="button-wrapper">
            <button
              type="submit"
              onClick={() => {
                setClicked(true);
                localStorage.clear();
                if (username && legal) {
                  this.setState({ name: username });
                }
              }}
            >
              Join Chat
            </button>
          </div>
        </div>
      </div>
    );
  };

  ezChatChat = () => {
    return (
      <div className="ez-chat-chat">
        <div className="chat">
          {this.state.data.general.map((item: any, index: number) => (
            <p key={index}>
              <span style={{ color: item.color }}>{item.name}</span>:{" "}
              {item.message}
            </p>
          ))}
        </div>
        <div className="chat-box">
          <label htmlFor="chat-box">Chat box:</label>
          <textarea
            name="chat-box"
            placeholder="Send a message!"
            className="box"
            value={this.state.text}
            onChange={(event) => {
              this.setState({ text: event.target.value });
            }}
            onKeyPress={this.processKey}
          />
        </div>
      </div>
    );
  };

  ezChatPanel = () => {
    return (
      <div className="ez-chat-panel">
        <Link className="title-wrapper" to="/">
          <h1 className="title">Ez Chat</h1>
        </Link>
        <a className="powered-by" href="http://www.xiler.net">
          <p>Powered by</p>
          <img
            src="https://raw.githubusercontent.com/XilerNet/MainWebsite/master/public/assets/logo-128x.png"
            alt="Xiler Network"
          />
          <div className="xiler-wrapper">
            <p className="xiler">Xiler</p>
          </div>
        </a>
      </div>
    );
  };

  processKey = (e: any) => {
    if (e.key === "Enter") {
      if (this.state.text.trim() === "") {
        return;
      }
      e.preventDefault();
      this.setState({ text: "" });
      const data = {
        name: this.state.name,
        color: this.state.color,
        message: this.state.text.trim(),
      };
      let xhr = new XMLHttpRequest();
      xhr.open("POST", this.api + "/send")
      xhr.send(JSON.stringify(data))
    }
  };

  updateData = (data: any) => {
    this.setState({
      data: {
        general: [data, ...this.state.data.general],
      },
    });
  };

  chatFrame = () => {
    return (
      <div>
        {this.ezChatPanel()}
        {this.ezChatChat()}
      </div>
    );
  };

  render() {
    return (
      <React.Fragment>
        {this.state.name === "" && <this.usernamePrompt />}
        {this.state.name !== "" && <this.chatFrame />}
      </React.Fragment>
    );
  }
}

export default ChatRoom;
