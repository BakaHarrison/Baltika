using testWeb.Model;

namespace testWeb.Repository
{
    public interface IBaltika
    {
        public Baltika Add(Baltika baltika);
        public Baltika Get(int id);
        public Baltika Update(Baltika baltika);
        public List<Baltika> GetAll();
        public Baltika Delete(int id);
    }
}
