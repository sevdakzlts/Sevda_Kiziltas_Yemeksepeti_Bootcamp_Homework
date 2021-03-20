import React, {useState} from 'react';
import TodoForm from './TodoForm';
import Todo from './Todo';


function TodoList() {
    const [todoitem, setTodos] = useState ([]);

    const addTodo = todo => {
        if(!todo.text || /^\s*$/.test(todo.text)){
            return;
        }

        const newTodos = [todo, ...todoitem];

        setTodos(newTodos);
    };

    const updateTodo = (todoId, newValue) => {
        if(!newValue.text || /^\s*$/.test(newValue.text)){
            return;
        }

        setTodos(prev => prev.map(item=>(item.id === todoId ? newValue : item)));
    };

    const removeTodo = id => {
        const removeArr = [...todoitem].filter(todo=>todo.id !== id)

        setTodos(removeArr);
    }

    const completeTodo = id => {
        let updatedTodos = todoitem.map(todo =>{
            if (todo.id === id) {
                todo.isComplete = !todo.isComplete;
            }
            return todo;
        });
        setTodos(updatedTodos);
    };

    return(
        <div>
            <h1>What's New Plan</h1>
            <TodoForm onSubmit= {addTodo}/>
            <Todo todoitem={todoitem} completeTodo={completeTodo} removeTodo={removeTodo} updateTodo={updateTodo} />
        </div>
    );
};

export default TodoList;