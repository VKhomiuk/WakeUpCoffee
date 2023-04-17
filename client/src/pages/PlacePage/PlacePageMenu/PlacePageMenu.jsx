import { useState } from "react"
import MenuItem from './assets/coffee.png'

const PlacePageMenu = () => {

  const [currentTab, setCurrentTab] = useState('Кава')

  const tabs = [
    'Кава',
    'Чай',
    'Не кава',
    'Холодна кава',
  ]

  const menuItems = [
    {
      img: MenuItem,
      title: 'Еспресо',
      description: 'Дивовижна та ароматна, зухвала і збудлива, міцна і злегка гіркувата. Саме такою є кава еспресо - справжня кава для справжнього життя!',
      cookTime: '1 хв',
      price: '18 грн',
      id: 0
    },
    {
      img: MenuItem,
      title: 'Еспресо',
      description: 'Дивовижна та ароматна, зухвала і збудлива, міцна і злегка гіркувата. Саме такою є кава еспресо - справжня кава для справжнього життя!',
      cookTime: '1 хв',
      price: '18 грн',
      id: 1
    }

  ]

  const handleActiveTab = (tab) => {
    console.log(currentTab)
    setCurrentTab(tab)
  }

  return (
    <div>
      <div className='flex justify-evenly items-center bg-black py-5'>
        {tabs.map(el => <span className={`font-roboto500 cursor-pointer text-2xl 
            ${currentTab === el ? 'text-white underline' : 'text-chocolate'}`} id={el} onClick={e => handleActiveTab(e.target.id)} >{el}</span>)}
      </div>
      <div>
        <h3 className='underline text-black font-roboto500 text-5xl mt-8 mb-10'>{currentTab}</h3>
        <div className='w-9/12 mx-auto flex flex-col gap-20 mb-20'>
          {menuItems.map(el => <MenuTile {...el} />)}
        </div>
      </div>
    </div>
  )
}

const MenuTile = ({ img, title, description, cookTime, price, id }) => {
  return (
    <div className='flex flex-wrap justify-between items-center gap-12'>
      <img src={img} />
      <div className='text-left flex flex-col flex-auto w-6/12 justify-between h-full'>
        <h5 className='font-inter font-bold text-4xl'>{title}</h5>
        <p className='font-inter font-regular text-black text-3xl mb-5'>{description}</p>
        <p className='font-roboto500 text-4xl text-black'>Час приготування: {cookTime}</p>
        <p className='font-roboto500 text-4xl text-black'>Ціна: {price}</p>
        <button className='text-4xl font-roboto700 text-caramel w-fit bg-chocolate mt-5 py-6 px-8 rounded-3xl'>Додати до замовлення</button>
      </div>
    </div>
  )
}

export default PlacePageMenu
