namespace chapter9example3and4.myDTO
{
    interface IDTO
    {
        void Flip();
        void SetData();
        void RemoveData();
        void Focus();
        DTOFactory SetOffset(short offset);
    }
}
