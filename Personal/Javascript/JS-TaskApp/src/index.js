import React from "react";
import ReactDOM from "react-dom";
import "@atlaskit/css-reset";
import initialData from "./example-data";
import "./style.scss";
import { DragDropContext, Droppable, Draggable } from "react-beautiful-dnd";

class App extends React.Component {
  state = initialData;

  onDragStart = () => {
    document.body.style.transition = "background-color 0.2s ease";
  };

  onDragUpdate = (update) => {
    const { destination } = update;
    const opacity = destination
      ? destination.index / Object.keys(this.state.tasks).length +
        1 / Object.keys(this.state.tasks).length
      : 0;
    document.body.style.backgroundColor = `rgba(255, 166, 0, ${opacity})`;
  };

  onDragEnd = (result) => {
    document.body.style.backgroundColor = `rgba(255, 166, 0, 0)`;
    const { destination, source, draggableId } = result;

    if (!destination) return;

    if (
      destination.droppableId === source.droppableId &&
      destination.index === source.index
    )
      return;

    const start = this.state.columns[source.droppableId];
    const finish = this.state.columns[destination.droppableId];

    if (start === finish) {
      const newTaskIds = Array.from(start.taskIds);
      newTaskIds.splice(source.index, 1);
      newTaskIds.splice(destination.index, 0, draggableId);

      const newColumn = {
        ...start,
        taskIds: newTaskIds,
      };

      const newState = {
        ...this.state,
        columns: {
          ...this.state.columns,
          [newColumn.id]: newColumn,
        },
      };

      this.setState(newState);
      return;
    }

    const startTaskIds = Array.from(start.taskIds);
    startTaskIds.splice(source.index, 1);
    const newStart = {
      ...start,
      taskIds: startTaskIds,
    };

    const finishTaskIds = Array.from(finish.taskIds);
    finishTaskIds.splice(destination.index, 0, draggableId);
    const newFinish = {
      ...finish,
      taskIds: finishTaskIds,
    };

    const newState = {
      ...this.state,
      columns: {
        ...this.state.columns,
        [newStart.id]: newStart,
        [newFinish.id]: newFinish,
      },
    };
    this.setState(newState);
  };

  render() {
    document.documentElement.style.setProperty(
      "--column-count",
      this.state.columnOrder.length
    );
    return (
      <DragDropContext
        onDragStart={this.onDragStart}
        onDragUpdate={this.onDragUpdate}
        onDragEnd={this.onDragEnd}
      >
        {this.state.columnOrder.map((columnId) => {
          const column = this.state.columns[columnId];
          const tasks = column.taskIds.map(
            (taskId) => this.state.tasks[taskId]
          );

          return <Column key={column.id} column={column} tasks={tasks} />;
        })}
      </DragDropContext>
    );
  }
}

class Column extends React.Component {
  render() {
    return (
      <div className="container">
        <h3 className="title">{this.props.column.title}</h3>
        <Droppable droppableId={this.props.column.id}>
          {(provided, snapshot) => (
            <div
              className={`task-list ${
                snapshot.isDraggingOver ? "highlight" : "default"
              }`}
              ref={provided.innerRef}
              {...provided.droppableProps}
            >
              {this.props.tasks.map((task, index) => (
                <Task key={task.id} task={task} index={index} />
              ))}
              {provided.placeholder}
            </div>
          )}
        </Droppable>
      </div>
    );
  }
}

class Task extends React.Component {
  render() {
    return (
      <Draggable draggableId={this.props.task.id} index={this.props.index}>
        {(provided, snapshot) => (
          <div
            className={`task${snapshot.isDragging ? " highlight" : ""}`}
            {...provided.draggableProps}
            {...provided.dragHandleProps}
            ref={provided.innerRef}
          >
            {this.props.task.content}
          </div>
        )}
      </Draggable>
    );
  }
}

ReactDOM.render(<App />, document.getElementById("root"));
