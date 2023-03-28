import {useState} from 'react';
import {Menu} from 'antd';
import {Link} from 'react-router-dom';

const items = [
    {
        label:'Menu 1',
        path: '/'
    },
    {
        label: 'Menu 2',
        path:'/myapi'
    }
].map((item, index) => {
    return {
        key:index,
        label: <Link to={item.path}>{item.label}</Link>
    }
})

export const Header = () => {
    const [current, setCurrent] = useState('0');
    const onClick = (e) => {
        setCurrent(e.key);
    };

    return <Menu onClick={onClick} selectedKeys={[current]} mode='horizontal' items={items} />

}
