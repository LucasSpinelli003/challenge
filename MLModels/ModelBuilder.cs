using Microsoft.ML;
using Microsoft.ML.Trainers;
using ProductRecommendationAPI.Models;

namespace ProductRecommendationAPI.MLModels
{
    public static class ModelBuilder
    {
        private static readonly string ModelPath = "MLModels/ProductRecommendationModel.zip";

        public static void TrainModel()
        {
            var mlContext = new MLContext();
            var data = mlContext.Data.LoadFromTextFile<ProductRecommendationModel>("MLModels/data.csv", separatorChar: ',', hasHeader: true);

            var options = new MatrixFactorizationTrainer.Options
            {
                MatrixColumnIndexColumnName = "userId",
                MatrixRowIndexColumnName = "productId",
                LabelColumnName = "Label",
                NumberOfIterations = 20,
                ApproximationRank = 100
            };

            var pipeline = mlContext.Transforms.Conversion.MapValueToKey("Label", nameof(Product.Id))
                .Append(mlContext.Transforms.Text.FeaturizeText("Features", nameof(Product.Category)))
                .Append(mlContext.Recommendation().Trainers.MatrixFactorization(options));

            var model = pipeline.Fit(data);
            mlContext.Model.Save(model, data.Schema, ModelPath);
        }
    }
}