const initialData = {
  tasks: {
    "task-1": {
      id: "task-1",
      content: "Take out the garbage",
    },
    "task-2": {
      id: "task-2",
      content: "Watch epic show",
    },
    "task-3": {
      id: "task-3",
      content: "Charge phone",
    },
    "task-4": {
      id: "task-4",
      content: "Cook dinner",
    },
  },
  columns: {
    "colum-1": {
      id: "colum-1",
      title: "To do",
      taskIds: ["task-1", "task-2", "task-3", "task-4"],
    },
    "colum-2": {
      id: "colum-2",
      title: "In progress",
      taskIds: [],
    },
    "colum-3": {
      id: "colum-3",
      title: "Finished",
      taskIds: [],
    },
  },
  columnOrder: ["colum-1", "colum-2", "colum-3"],
};

export default initialData;
