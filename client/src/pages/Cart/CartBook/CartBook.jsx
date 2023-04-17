
const CartBook = () => {
  return (
    <div>
      <div className='flex items-center justify-center mb-10 gap-6 mx-auto'>
        <p className='font-roboto700 text-black text-5xl'>Оберіть дату та час замовлення:</p>
        <input type='datetime-local' />
      </div>
      <button className='mb-20 text-white bg-chocolate py-6 px-24 rounded-3xl font-roboto700 text-5xl'>Замовити</button>
    </div>
  )
}

export default CartBook
